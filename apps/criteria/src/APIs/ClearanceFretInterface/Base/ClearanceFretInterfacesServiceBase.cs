using Criteria.APIs;
using Criteria.APIs.Common;
using Criteria.APIs.Dtos;
using Criteria.APIs.Errors;
using Criteria.APIs.Extensions;
using Criteria.Infrastructure;
using Criteria.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Criteria.APIs;

public abstract class ClearanceFretInterfacesServiceBase : IClearanceFretInterfacesService
{
    protected readonly CriteriaDbContext _context;

    public ClearanceFretInterfacesServiceBase(CriteriaDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one Clearance Fret Interface
    /// </summary>
    public async Task<ClearanceFretInterface> CreateClearanceFretInterface(
        ClearanceFretInterfaceCreateInput createDto
    )
    {
        var clearanceFretInterface = new ClearanceFretInterfaceDbModel
        {
            AuthorizedGrossWeight = createDto.AuthorizedGrossWeight,
            AuthorizedNetWeightUnitCodeProcessingOn =
                createDto.AuthorizedNetWeightUnitCodeProcessingOn,
            AuthorizedPackageUnitCode = createDto.AuthorizedPackageUnitCode,
            AuthorizedPackagingNumber = createDto.AuthorizedPackagingNumber,
            ContainerizedCargoStorageLocationCode = createDto.ContainerizedCargoStorageLocationCode,
            CreatedAt = createDto.CreatedAt,
            Crn = createDto.Crn,
            DeclarantCode = createDto.DeclarantCode,
            DeclarationTypeCode = createDto.DeclarationTypeCode,
            DetailedDeclarationNumber = createDto.DetailedDeclarationNumber,
            EpcCode = createDto.EpcCode,
            ProcessingContent = createDto.ProcessingContent,
            ProcessingResultCode = createDto.ProcessingResultCode,
            UpdatedAt = createDto.UpdatedAt,
            ValidationDate = createDto.ValidationDate
        };

        if (createDto.Id != null)
        {
            clearanceFretInterface.Id = createDto.Id;
        }
        if (createDto.ClearanceFretContainer != null)
        {
            clearanceFretInterface.ClearanceFretContainer = await _context
                .ClearanceFretContainers.Where(clearanceFretContainer =>
                    createDto
                        .ClearanceFretContainer.Select(t => t.Id)
                        .Contains(clearanceFretContainer.Id)
                )
                .ToListAsync();
        }

        _context.ClearanceFretInterfaces.Add(clearanceFretInterface);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<ClearanceFretInterfaceDbModel>(
            clearanceFretInterface.Id
        );

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one Clearance Fret Interface
    /// </summary>
    public async Task DeleteClearanceFretInterface(ClearanceFretInterfaceWhereUniqueInput uniqueId)
    {
        var clearanceFretInterface = await _context.ClearanceFretInterfaces.FindAsync(uniqueId.Id);
        if (clearanceFretInterface == null)
        {
            throw new NotFoundException();
        }

        _context.ClearanceFretInterfaces.Remove(clearanceFretInterface);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many Dedouanement Fret Interfaces
    /// </summary>
    public async Task<List<ClearanceFretInterface>> ClearanceFretInterfaces(
        ClearanceFretInterfaceFindManyArgs findManyArgs
    )
    {
        var clearanceFretInterfaces = await _context
            .ClearanceFretInterfaces.Include(x => x.ClearanceFretContainer)
            .ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return clearanceFretInterfaces.ConvertAll(clearanceFretInterface =>
            clearanceFretInterface.ToDto()
        );
    }

    /// <summary>
    /// Meta data about Clearance Fret Interface records
    /// </summary>
    public async Task<MetadataDto> ClearanceFretInterfacesMeta(
        ClearanceFretInterfaceFindManyArgs findManyArgs
    )
    {
        var count = await _context
            .ClearanceFretInterfaces.ApplyWhere(findManyArgs.Where)
            .CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one Clearance Fret Interface
    /// </summary>
    public async Task<ClearanceFretInterface> ClearanceFretInterface(
        ClearanceFretInterfaceWhereUniqueInput uniqueId
    )
    {
        var clearanceFretInterfaces = await this.ClearanceFretInterfaces(
            new ClearanceFretInterfaceFindManyArgs
            {
                Where = new ClearanceFretInterfaceWhereInput { Id = uniqueId.Id }
            }
        );
        var clearanceFretInterface = clearanceFretInterfaces.FirstOrDefault();
        if (clearanceFretInterface == null)
        {
            throw new NotFoundException();
        }

        return clearanceFretInterface;
    }

    /// <summary>
    /// Update one Clearance Fret Interface
    /// </summary>
    public async Task UpdateClearanceFretInterface(
        ClearanceFretInterfaceWhereUniqueInput uniqueId,
        ClearanceFretInterfaceUpdateInput updateDto
    )
    {
        var clearanceFretInterface = updateDto.ToModel(uniqueId);

        if (updateDto.ClearanceFretContainer != null)
        {
            clearanceFretInterface.ClearanceFretContainer = await _context
                .ClearanceFretContainers.Where(clearanceFretContainer =>
                    updateDto
                        .ClearanceFretContainer.Select(t => t)
                        .Contains(clearanceFretContainer.Id)
                )
                .ToListAsync();
        }

        _context.Entry(clearanceFretInterface).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!_context.ClearanceFretInterfaces.Any(e => e.Id == clearanceFretInterface.Id))
            {
                throw new NotFoundException();
            }
            else
            {
                throw;
            }
        }
    }

    /// <summary>
    /// Connect multiple Clearance Fret Container records to Clearance Fret Interface
    /// </summary>
    public async Task ConnectClearanceFretContainer(
        ClearanceFretInterfaceWhereUniqueInput uniqueId,
        ClearanceFretContainerWhereUniqueInput[] clearanceFretContainersId
    )
    {
        var parent = await _context
            .ClearanceFretInterfaces.Include(x => x.ClearanceFretContainer)
            .FirstOrDefaultAsync(x => x.Id == uniqueId.Id);
        if (parent == null)
        {
            throw new NotFoundException();
        }

        var clearanceFretContainers = await _context
            .ClearanceFretContainers.Where(t =>
                clearanceFretContainersId.Select(x => x.Id).Contains(t.Id)
            )
            .ToListAsync();
        if (clearanceFretContainers.Count == 0)
        {
            throw new NotFoundException();
        }

        var clearanceFretContainersToConnect = clearanceFretContainers.Except(
            parent.ClearanceFretContainer
        );

        foreach (var clearanceFretContainer in clearanceFretContainersToConnect)
        {
            parent.ClearanceFretContainer.Add(clearanceFretContainer);
        }

        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Disconnect multiple Clearance Fret Container records from Clearance Fret Interface
    /// </summary>
    public async Task DisconnectClearanceFretContainer(
        ClearanceFretInterfaceWhereUniqueInput uniqueId,
        ClearanceFretContainerWhereUniqueInput[] clearanceFretContainersId
    )
    {
        var parent = await _context
            .ClearanceFretInterfaces.Include(x => x.ClearanceFretContainer)
            .FirstOrDefaultAsync(x => x.Id == uniqueId.Id);
        if (parent == null)
        {
            throw new NotFoundException();
        }

        var clearanceFretContainers = await _context
            .ClearanceFretContainers.Where(t =>
                clearanceFretContainersId.Select(x => x.Id).Contains(t.Id)
            )
            .ToListAsync();

        foreach (var clearanceFretContainer in clearanceFretContainers)
        {
            parent.ClearanceFretContainer?.Remove(clearanceFretContainer);
        }
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find multiple Clearance Fret Container records for Clearance Fret Interface
    /// </summary>
    public async Task<List<ClearanceFretContainer>> FindClearanceFretContainer(
        ClearanceFretInterfaceWhereUniqueInput uniqueId,
        ClearanceFretContainerFindManyArgs clearanceFretInterfaceFindManyArgs
    )
    {
        var clearanceFretContainers = await _context
            .ClearanceFretContainers.Where(m => m.ClearanceFretInterfaceId == uniqueId.Id)
            .ApplyWhere(clearanceFretInterfaceFindManyArgs.Where)
            .ApplySkip(clearanceFretInterfaceFindManyArgs.Skip)
            .ApplyTake(clearanceFretInterfaceFindManyArgs.Take)
            .ApplyOrderBy(clearanceFretInterfaceFindManyArgs.SortBy)
            .ToListAsync();

        return clearanceFretContainers.Select(x => x.ToDto()).ToList();
    }

    /// <summary>
    /// Update multiple Clearance Fret Container records for Clearance Fret Interface
    /// </summary>
    public async Task UpdateClearanceFretContainer(
        ClearanceFretInterfaceWhereUniqueInput uniqueId,
        ClearanceFretContainerWhereUniqueInput[] clearanceFretContainersId
    )
    {
        var clearanceFretInterface = await _context
            .ClearanceFretInterfaces.Include(t => t.ClearanceFretContainer)
            .FirstOrDefaultAsync(x => x.Id == uniqueId.Id);
        if (clearanceFretInterface == null)
        {
            throw new NotFoundException();
        }

        var clearanceFretContainers = await _context
            .ClearanceFretContainers.Where(a =>
                clearanceFretContainersId.Select(x => x.Id).Contains(a.Id)
            )
            .ToListAsync();

        if (clearanceFretContainers.Count == 0)
        {
            throw new NotFoundException();
        }

        clearanceFretInterface.ClearanceFretContainer = clearanceFretContainers;
        await _context.SaveChangesAsync();
    }
}
