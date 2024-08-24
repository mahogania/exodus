using Microsoft.EntityFrameworkCore;
using Traveler.APIs;
using Traveler.APIs.Common;
using Traveler.APIs.Dtos;
using Traveler.APIs.Errors;
using Traveler.APIs.Extensions;
using Traveler.Infrastructure;
using Traveler.Infrastructure.Models;

namespace Traveler.APIs;

public abstract class TravelersArticlesEntryExitsServiceBase : ITravelersArticlesEntryExitsService
{
    protected readonly TravelerDbContext _context;

    public TravelersArticlesEntryExitsServiceBase(TravelerDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one TravelersArticlesEntryExit
    /// </summary>
    public async Task<TravelersArticlesEntryExit> CreateTravelersArticlesEntryExit(
        TravelersArticlesEntryExitCreateInput createDto
    )
    {
        var travelersArticlesEntryExit = new TravelersArticlesEntryExitDbModel
        {
            CreatedAt = createDto.CreatedAt,
            DeletionOn = createDto.DeletionOn,
            DepositedArticleSerialNumber = createDto.DepositedArticleSerialNumber,
            EntryAndExitCategoryCode = createDto.EntryAndExitCategoryCode,
            ExitedWeight = createDto.ExitedWeight,
            FinalModificationDateAndTime = createDto.FinalModificationDateAndTime,
            FirstRegistrationDateAndTime = createDto.FirstRegistrationDateAndTime,
            QuantityUnitCode = createDto.QuantityUnitCode,
            RemovalVoucherNumber = createDto.RemovalVoucherNumber,
            SectorCode = createDto.SectorCode,
            StockQuantity = createDto.StockQuantity,
            StockWeight = createDto.StockWeight,
            TravelerName = createDto.TravelerName,
            UpdatedAt = createDto.UpdatedAt,
            WeightUnit = createDto.WeightUnit
        };

        if (createDto.Id != null)
        {
            travelersArticlesEntryExit.Id = createDto.Id;
        }
        if (createDto.GeneralTravelerInformationTpds != null)
        {
            travelersArticlesEntryExit.GeneralTravelerInformationTpds = await _context
                .GeneralTravelerInformationTpds.Where(generalTravelerInformationTpd =>
                    createDto
                        .GeneralTravelerInformationTpds.Select(t => t.Id)
                        .Contains(generalTravelerInformationTpd.Id)
                )
                .ToListAsync();
        }

        if (createDto.ImportDeclarations != null)
        {
            travelersArticlesEntryExit.ImportDeclarations = await _context
                .ImportDeclarations.Where(importDeclaration =>
                    createDto.ImportDeclarations.Select(t => t.Id).Contains(importDeclaration.Id)
                )
                .ToListAsync();
        }

        _context.TravelersArticlesEntryExits.Add(travelersArticlesEntryExit);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<TravelersArticlesEntryExitDbModel>(
            travelersArticlesEntryExit.Id
        );

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one TravelersArticlesEntryExit
    /// </summary>
    public async Task DeleteTravelersArticlesEntryExit(
        TravelersArticlesEntryExitWhereUniqueInput uniqueId
    )
    {
        var travelersArticlesEntryExit = await _context.TravelersArticlesEntryExits.FindAsync(
            uniqueId.Id
        );
        if (travelersArticlesEntryExit == null)
        {
            throw new NotFoundException();
        }

        _context.TravelersArticlesEntryExits.Remove(travelersArticlesEntryExit);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many TravelersArticlesEntryExits
    /// </summary>
    public async Task<List<TravelersArticlesEntryExit>> TravelersArticlesEntryExits(
        TravelersArticlesEntryExitFindManyArgs findManyArgs
    )
    {
        var travelersArticlesEntryExits = await _context
            .TravelersArticlesEntryExits.Include(x => x.GeneralTravelerInformationTpds)
            .Include(x => x.ImportDeclarations)
            .ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return travelersArticlesEntryExits.ConvertAll(travelersArticlesEntryExit =>
            travelersArticlesEntryExit.ToDto()
        );
    }

    /// <summary>
    /// Meta data about TravelersArticlesEntryExit records
    /// </summary>
    public async Task<MetadataDto> TravelersArticlesEntryExitsMeta(
        TravelersArticlesEntryExitFindManyArgs findManyArgs
    )
    {
        var count = await _context
            .TravelersArticlesEntryExits.ApplyWhere(findManyArgs.Where)
            .CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one TravelersArticlesEntryExit
    /// </summary>
    public async Task<TravelersArticlesEntryExit> TravelersArticlesEntryExit(
        TravelersArticlesEntryExitWhereUniqueInput uniqueId
    )
    {
        var travelersArticlesEntryExits = await this.TravelersArticlesEntryExits(
            new TravelersArticlesEntryExitFindManyArgs
            {
                Where = new TravelersArticlesEntryExitWhereInput { Id = uniqueId.Id }
            }
        );
        var travelersArticlesEntryExit = travelersArticlesEntryExits.FirstOrDefault();
        if (travelersArticlesEntryExit == null)
        {
            throw new NotFoundException();
        }

        return travelersArticlesEntryExit;
    }

    /// <summary>
    /// Update one TravelersArticlesEntryExit
    /// </summary>
    public async Task UpdateTravelersArticlesEntryExit(
        TravelersArticlesEntryExitWhereUniqueInput uniqueId,
        TravelersArticlesEntryExitUpdateInput updateDto
    )
    {
        var travelersArticlesEntryExit = updateDto.ToModel(uniqueId);

        if (updateDto.GeneralTravelerInformationTpds != null)
        {
            travelersArticlesEntryExit.GeneralTravelerInformationTpds = await _context
                .GeneralTravelerInformationTpds.Where(generalTravelerInformationTpd =>
                    updateDto
                        .GeneralTravelerInformationTpds.Select(t => t)
                        .Contains(generalTravelerInformationTpd.Id)
                )
                .ToListAsync();
        }

        if (updateDto.ImportDeclarations != null)
        {
            travelersArticlesEntryExit.ImportDeclarations = await _context
                .ImportDeclarations.Where(importDeclaration =>
                    updateDto.ImportDeclarations.Select(t => t).Contains(importDeclaration.Id)
                )
                .ToListAsync();
        }

        _context.Entry(travelersArticlesEntryExit).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (
                !_context.TravelersArticlesEntryExits.Any(e =>
                    e.Id == travelersArticlesEntryExit.Id
                )
            )
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
    /// Connect multiple GeneralTravelerInformationTpds records to TravelersArticlesEntryExit
    /// </summary>
    public async Task ConnectGeneralTravelerInformationTpds(
        TravelersArticlesEntryExitWhereUniqueInput uniqueId,
        GeneralTravelerInformationTpdWhereUniqueInput[] generalTravelerInformationTpdsId
    )
    {
        var parent = await _context
            .TravelersArticlesEntryExits.Include(x => x.GeneralTravelerInformationTpds)
            .FirstOrDefaultAsync(x => x.Id == uniqueId.Id);
        if (parent == null)
        {
            throw new NotFoundException();
        }

        var generalTravelerInformationTpds = await _context
            .GeneralTravelerInformationTpds.Where(t =>
                generalTravelerInformationTpdsId.Select(x => x.Id).Contains(t.Id)
            )
            .ToListAsync();
        if (generalTravelerInformationTpds.Count == 0)
        {
            throw new NotFoundException();
        }

        var generalTravelerInformationTpdsToConnect = generalTravelerInformationTpds.Except(
            parent.GeneralTravelerInformationTpds
        );

        foreach (var generalTravelerInformationTpd in generalTravelerInformationTpdsToConnect)
        {
            parent.GeneralTravelerInformationTpds.Add(generalTravelerInformationTpd);
        }

        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Disconnect multiple GeneralTravelerInformationTpds records from TravelersArticlesEntryExit
    /// </summary>
    public async Task DisconnectGeneralTravelerInformationTpds(
        TravelersArticlesEntryExitWhereUniqueInput uniqueId,
        GeneralTravelerInformationTpdWhereUniqueInput[] generalTravelerInformationTpdsId
    )
    {
        var parent = await _context
            .TravelersArticlesEntryExits.Include(x => x.GeneralTravelerInformationTpds)
            .FirstOrDefaultAsync(x => x.Id == uniqueId.Id);
        if (parent == null)
        {
            throw new NotFoundException();
        }

        var generalTravelerInformationTpds = await _context
            .GeneralTravelerInformationTpds.Where(t =>
                generalTravelerInformationTpdsId.Select(x => x.Id).Contains(t.Id)
            )
            .ToListAsync();

        foreach (var generalTravelerInformationTpd in generalTravelerInformationTpds)
        {
            parent.GeneralTravelerInformationTpds?.Remove(generalTravelerInformationTpd);
        }
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find multiple GeneralTravelerInformationTpds records for TravelersArticlesEntryExit
    /// </summary>
    public async Task<List<GeneralTravelerInformationTpd>> FindGeneralTravelerInformationTpds(
        TravelersArticlesEntryExitWhereUniqueInput uniqueId,
        GeneralTravelerInformationTpdFindManyArgs travelersArticlesEntryExitFindManyArgs
    )
    {
        var generalTravelerInformationTpds = await _context
            .GeneralTravelerInformationTpds.Where(m =>
                m.TravelersArticlesEntryExitId == uniqueId.Id
            )
            .ApplyWhere(travelersArticlesEntryExitFindManyArgs.Where)
            .ApplySkip(travelersArticlesEntryExitFindManyArgs.Skip)
            .ApplyTake(travelersArticlesEntryExitFindManyArgs.Take)
            .ApplyOrderBy(travelersArticlesEntryExitFindManyArgs.SortBy)
            .ToListAsync();

        return generalTravelerInformationTpds.Select(x => x.ToDto()).ToList();
    }

    /// <summary>
    /// Update multiple GeneralTravelerInformationTpds records for TravelersArticlesEntryExit
    /// </summary>
    public async Task UpdateGeneralTravelerInformationTpds(
        TravelersArticlesEntryExitWhereUniqueInput uniqueId,
        GeneralTravelerInformationTpdWhereUniqueInput[] generalTravelerInformationTpdsId
    )
    {
        var travelersArticlesEntryExit = await _context
            .TravelersArticlesEntryExits.Include(t => t.GeneralTravelerInformationTpds)
            .FirstOrDefaultAsync(x => x.Id == uniqueId.Id);
        if (travelersArticlesEntryExit == null)
        {
            throw new NotFoundException();
        }

        var generalTravelerInformationTpds = await _context
            .GeneralTravelerInformationTpds.Where(a =>
                generalTravelerInformationTpdsId.Select(x => x.Id).Contains(a.Id)
            )
            .ToListAsync();

        if (generalTravelerInformationTpds.Count == 0)
        {
            throw new NotFoundException();
        }

        travelersArticlesEntryExit.GeneralTravelerInformationTpds = generalTravelerInformationTpds;
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Connect multiple ImportDeclarations records to TravelersArticlesEntryExit
    /// </summary>
    public async Task ConnectImportDeclarations(
        TravelersArticlesEntryExitWhereUniqueInput uniqueId,
        ImportDeclarationWhereUniqueInput[] importDeclarationsId
    )
    {
        var parent = await _context
            .TravelersArticlesEntryExits.Include(x => x.ImportDeclarations)
            .FirstOrDefaultAsync(x => x.Id == uniqueId.Id);
        if (parent == null)
        {
            throw new NotFoundException();
        }

        var importDeclarations = await _context
            .ImportDeclarations.Where(t => importDeclarationsId.Select(x => x.Id).Contains(t.Id))
            .ToListAsync();
        if (importDeclarations.Count == 0)
        {
            throw new NotFoundException();
        }

        var importDeclarationsToConnect = importDeclarations.Except(parent.ImportDeclarations);

        foreach (var importDeclaration in importDeclarationsToConnect)
        {
            parent.ImportDeclarations.Add(importDeclaration);
        }

        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Disconnect multiple ImportDeclarations records from TravelersArticlesEntryExit
    /// </summary>
    public async Task DisconnectImportDeclarations(
        TravelersArticlesEntryExitWhereUniqueInput uniqueId,
        ImportDeclarationWhereUniqueInput[] importDeclarationsId
    )
    {
        var parent = await _context
            .TravelersArticlesEntryExits.Include(x => x.ImportDeclarations)
            .FirstOrDefaultAsync(x => x.Id == uniqueId.Id);
        if (parent == null)
        {
            throw new NotFoundException();
        }

        var importDeclarations = await _context
            .ImportDeclarations.Where(t => importDeclarationsId.Select(x => x.Id).Contains(t.Id))
            .ToListAsync();

        foreach (var importDeclaration in importDeclarations)
        {
            parent.ImportDeclarations?.Remove(importDeclaration);
        }
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find multiple ImportDeclarations records for TravelersArticlesEntryExit
    /// </summary>
    public async Task<List<ImportDeclaration>> FindImportDeclarations(
        TravelersArticlesEntryExitWhereUniqueInput uniqueId,
        ImportDeclarationFindManyArgs travelersArticlesEntryExitFindManyArgs
    )
    {
        var importDeclarations = await _context
            .ImportDeclarations.Where(m => m.TravelersArticlesEntryExitId == uniqueId.Id)
            .ApplyWhere(travelersArticlesEntryExitFindManyArgs.Where)
            .ApplySkip(travelersArticlesEntryExitFindManyArgs.Skip)
            .ApplyTake(travelersArticlesEntryExitFindManyArgs.Take)
            .ApplyOrderBy(travelersArticlesEntryExitFindManyArgs.SortBy)
            .ToListAsync();

        return importDeclarations.Select(x => x.ToDto()).ToList();
    }

    /// <summary>
    /// Update multiple ImportDeclarations records for TravelersArticlesEntryExit
    /// </summary>
    public async Task UpdateImportDeclarations(
        TravelersArticlesEntryExitWhereUniqueInput uniqueId,
        ImportDeclarationWhereUniqueInput[] importDeclarationsId
    )
    {
        var travelersArticlesEntryExit = await _context
            .TravelersArticlesEntryExits.Include(t => t.ImportDeclarations)
            .FirstOrDefaultAsync(x => x.Id == uniqueId.Id);
        if (travelersArticlesEntryExit == null)
        {
            throw new NotFoundException();
        }

        var importDeclarations = await _context
            .ImportDeclarations.Where(a => importDeclarationsId.Select(x => x.Id).Contains(a.Id))
            .ToListAsync();

        if (importDeclarations.Count == 0)
        {
            throw new NotFoundException();
        }

        travelersArticlesEntryExit.ImportDeclarations = importDeclarations;
        await _context.SaveChangesAsync();
    }
}
