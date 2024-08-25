using Criteria.APIs;
using Criteria.APIs.Common;
using Criteria.APIs.Dtos;
using Criteria.APIs.Errors;
using Criteria.APIs.Extensions;
using Criteria.Infrastructure;
using Criteria.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Criteria.APIs;

public abstract class ClearanceFretContainersServiceBase : IClearanceFretContainersService
{
    protected readonly CriteriaDbContext _context;

    public ClearanceFretContainersServiceBase(CriteriaDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one Clearance Fret Container
    /// </summary>
    public async Task<ClearanceFretContainer> CreateClearanceFretContainer(
        ClearanceFretContainerCreateInput createDto
    )
    {
        var clearanceFretContainer = new ClearanceFretContainerDbModel
        {
            ContainerId = createDto.ContainerId,
            CreatedAt = createDto.CreatedAt,
            UpdatedAt = createDto.UpdatedAt
        };

        if (createDto.Id != null)
        {
            clearanceFretContainer.Id = createDto.Id;
        }
        if (createDto.ClearanceFretInterface != null)
        {
            clearanceFretContainer.ClearanceFretInterface = await _context
                .ClearanceFretInterfaces.Where(clearanceFretInterface =>
                    createDto.ClearanceFretInterface.Id == clearanceFretInterface.Id
                )
                .FirstOrDefaultAsync();
        }

        _context.ClearanceFretContainers.Add(clearanceFretContainer);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<ClearanceFretContainerDbModel>(
            clearanceFretContainer.Id
        );

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one Clearance Fret Container
    /// </summary>
    public async Task DeleteClearanceFretContainer(ClearanceFretContainerWhereUniqueInput uniqueId)
    {
        var clearanceFretContainer = await _context.ClearanceFretContainers.FindAsync(uniqueId.Id);
        if (clearanceFretContainer == null)
        {
            throw new NotFoundException();
        }

        _context.ClearanceFretContainers.Remove(clearanceFretContainer);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many Clearance Fret Containers
    /// </summary>
    public async Task<List<ClearanceFretContainer>> ClearanceFretContainers(
        ClearanceFretContainerFindManyArgs findManyArgs
    )
    {
        var clearanceFretContainers = await _context
            .ClearanceFretContainers.Include(x => x.ClearanceFretInterface)
            .ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return clearanceFretContainers.ConvertAll(clearanceFretContainer =>
            clearanceFretContainer.ToDto()
        );
    }

    /// <summary>
    /// Meta data about Clearance Fret Container records
    /// </summary>
    public async Task<MetadataDto> ClearanceFretContainersMeta(
        ClearanceFretContainerFindManyArgs findManyArgs
    )
    {
        var count = await _context
            .ClearanceFretContainers.ApplyWhere(findManyArgs.Where)
            .CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one Clearance Fret Container
    /// </summary>
    public async Task<ClearanceFretContainer> ClearanceFretContainer(
        ClearanceFretContainerWhereUniqueInput uniqueId
    )
    {
        var clearanceFretContainers = await this.ClearanceFretContainers(
            new ClearanceFretContainerFindManyArgs
            {
                Where = new ClearanceFretContainerWhereInput { Id = uniqueId.Id }
            }
        );
        var clearanceFretContainer = clearanceFretContainers.FirstOrDefault();
        if (clearanceFretContainer == null)
        {
            throw new NotFoundException();
        }

        return clearanceFretContainer;
    }

    /// <summary>
    /// Update one Clearance Fret Container
    /// </summary>
    public async Task UpdateClearanceFretContainer(
        ClearanceFretContainerWhereUniqueInput uniqueId,
        ClearanceFretContainerUpdateInput updateDto
    )
    {
        var clearanceFretContainer = updateDto.ToModel(uniqueId);

        _context.Entry(clearanceFretContainer).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!_context.ClearanceFretContainers.Any(e => e.Id == clearanceFretContainer.Id))
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
    /// Get a Clearance Fret Interface record for Clearance Fret Container
    /// </summary>
    public async Task<ClearanceFretInterface> GetClearanceFretInterface(
        ClearanceFretContainerWhereUniqueInput uniqueId
    )
    {
        var clearanceFretContainer = await _context
            .ClearanceFretContainers.Where(clearanceFretContainer =>
                clearanceFretContainer.Id == uniqueId.Id
            )
            .Include(clearanceFretContainer => clearanceFretContainer.ClearanceFretInterface)
            .FirstOrDefaultAsync();
        if (clearanceFretContainer == null)
        {
            throw new NotFoundException();
        }
        return clearanceFretContainer.ClearanceFretInterface.ToDto();
    }
}
