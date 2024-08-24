using Microsoft.EntityFrameworkCore;
using Traveler.APIs;
using Traveler.APIs.Common;
using Traveler.APIs.Dtos;
using Traveler.APIs.Errors;
using Traveler.APIs.Extensions;
using Traveler.Infrastructure;
using Traveler.Infrastructure.Models;

namespace Traveler.APIs;

public abstract class TpdEntryAndExitHistoriesServiceBase : ITpdEntryAndExitHistoriesService
{
    protected readonly TravelerDbContext _context;

    public TpdEntryAndExitHistoriesServiceBase(TravelerDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one TpdEntryAndExitHistory
    /// </summary>
    public async Task<TpdEntryAndExitHistory> CreateTpdEntryAndExitHistory(
        TpdEntryAndExitHistoryCreateInput createDto
    )
    {
        var tpdEntryAndExitHistory = new TpdEntryAndExitHistoryDbModel
        {
            CreatedAt = createDto.CreatedAt,
            DeletionOn = createDto.DeletionOn,
            EntryAndExitSerialNumber = createDto.EntryAndExitSerialNumber,
            EntryExitCode = createDto.EntryExitCode,
            FinalModificationDateAndTime = createDto.FinalModificationDateAndTime,
            FirstRegistrationDateAndTime = createDto.FirstRegistrationDateAndTime,
            OfficeCode = createDto.OfficeCode,
            RegistrationDate = createDto.RegistrationDate,
            RegistrationDateAndTime = createDto.RegistrationDateAndTime,
            TpdManagementNumber = createDto.TpdManagementNumber,
            UpdatedAt = createDto.UpdatedAt
        };

        if (createDto.Id != null)
        {
            tpdEntryAndExitHistory.Id = createDto.Id;
        }
        if (createDto.GeneralTravelerInformationTpds != null)
        {
            tpdEntryAndExitHistory.GeneralTravelerInformationTpds = await _context
                .GeneralTravelerInformationTpds.Where(generalTravelerInformationTpd =>
                    createDto
                        .GeneralTravelerInformationTpds.Select(t => t.Id)
                        .Contains(generalTravelerInformationTpd.Id)
                )
                .ToListAsync();
        }

        if (createDto.ImportDeclarations != null)
        {
            tpdEntryAndExitHistory.ImportDeclarations = await _context
                .ImportDeclarations.Where(importDeclaration =>
                    createDto.ImportDeclarations.Select(t => t.Id).Contains(importDeclaration.Id)
                )
                .ToListAsync();
        }

        _context.TpdEntryAndExitHistories.Add(tpdEntryAndExitHistory);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<TpdEntryAndExitHistoryDbModel>(
            tpdEntryAndExitHistory.Id
        );

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one TpdEntryAndExitHistory
    /// </summary>
    public async Task DeleteTpdEntryAndExitHistory(TpdEntryAndExitHistoryWhereUniqueInput uniqueId)
    {
        var tpdEntryAndExitHistory = await _context.TpdEntryAndExitHistories.FindAsync(uniqueId.Id);
        if (tpdEntryAndExitHistory == null)
        {
            throw new NotFoundException();
        }

        _context.TpdEntryAndExitHistories.Remove(tpdEntryAndExitHistory);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many TpdEntryAndExitHistories
    /// </summary>
    public async Task<List<TpdEntryAndExitHistory>> TpdEntryAndExitHistories(
        TpdEntryAndExitHistoryFindManyArgs findManyArgs
    )
    {
        var tpdEntryAndExitHistories = await _context
            .TpdEntryAndExitHistories.Include(x => x.GeneralTravelerInformationTpds)
            .Include(x => x.ImportDeclarations)
            .ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return tpdEntryAndExitHistories.ConvertAll(tpdEntryAndExitHistory =>
            tpdEntryAndExitHistory.ToDto()
        );
    }

    /// <summary>
    /// Meta data about TpdEntryAndExitHistory records
    /// </summary>
    public async Task<MetadataDto> TpdEntryAndExitHistoriesMeta(
        TpdEntryAndExitHistoryFindManyArgs findManyArgs
    )
    {
        var count = await _context
            .TpdEntryAndExitHistories.ApplyWhere(findManyArgs.Where)
            .CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one TpdEntryAndExitHistory
    /// </summary>
    public async Task<TpdEntryAndExitHistory> TpdEntryAndExitHistory(
        TpdEntryAndExitHistoryWhereUniqueInput uniqueId
    )
    {
        var tpdEntryAndExitHistories = await this.TpdEntryAndExitHistories(
            new TpdEntryAndExitHistoryFindManyArgs
            {
                Where = new TpdEntryAndExitHistoryWhereInput { Id = uniqueId.Id }
            }
        );
        var tpdEntryAndExitHistory = tpdEntryAndExitHistories.FirstOrDefault();
        if (tpdEntryAndExitHistory == null)
        {
            throw new NotFoundException();
        }

        return tpdEntryAndExitHistory;
    }

    /// <summary>
    /// Update one TpdEntryAndExitHistory
    /// </summary>
    public async Task UpdateTpdEntryAndExitHistory(
        TpdEntryAndExitHistoryWhereUniqueInput uniqueId,
        TpdEntryAndExitHistoryUpdateInput updateDto
    )
    {
        var tpdEntryAndExitHistory = updateDto.ToModel(uniqueId);

        if (updateDto.GeneralTravelerInformationTpds != null)
        {
            tpdEntryAndExitHistory.GeneralTravelerInformationTpds = await _context
                .GeneralTravelerInformationTpds.Where(generalTravelerInformationTpd =>
                    updateDto
                        .GeneralTravelerInformationTpds.Select(t => t)
                        .Contains(generalTravelerInformationTpd.Id)
                )
                .ToListAsync();
        }

        if (updateDto.ImportDeclarations != null)
        {
            tpdEntryAndExitHistory.ImportDeclarations = await _context
                .ImportDeclarations.Where(importDeclaration =>
                    updateDto.ImportDeclarations.Select(t => t).Contains(importDeclaration.Id)
                )
                .ToListAsync();
        }

        _context.Entry(tpdEntryAndExitHistory).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!_context.TpdEntryAndExitHistories.Any(e => e.Id == tpdEntryAndExitHistory.Id))
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
    /// Connect multiple GeneralTravelerInformationTpds records to TpdEntryAndExitHistory
    /// </summary>
    public async Task ConnectGeneralTravelerInformationTpds(
        TpdEntryAndExitHistoryWhereUniqueInput uniqueId,
        GeneralTravelerInformationTpdWhereUniqueInput[] generalTravelerInformationTpdsId
    )
    {
        var parent = await _context
            .TpdEntryAndExitHistories.Include(x => x.GeneralTravelerInformationTpds)
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
    /// Disconnect multiple GeneralTravelerInformationTpds records from TpdEntryAndExitHistory
    /// </summary>
    public async Task DisconnectGeneralTravelerInformationTpds(
        TpdEntryAndExitHistoryWhereUniqueInput uniqueId,
        GeneralTravelerInformationTpdWhereUniqueInput[] generalTravelerInformationTpdsId
    )
    {
        var parent = await _context
            .TpdEntryAndExitHistories.Include(x => x.GeneralTravelerInformationTpds)
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
    /// Find multiple GeneralTravelerInformationTpds records for TpdEntryAndExitHistory
    /// </summary>
    public async Task<List<GeneralTravelerInformationTpd>> FindGeneralTravelerInformationTpds(
        TpdEntryAndExitHistoryWhereUniqueInput uniqueId,
        GeneralTravelerInformationTpdFindManyArgs tpdEntryAndExitHistoryFindManyArgs
    )
    {
        var generalTravelerInformationTpds = await _context
            .GeneralTravelerInformationTpds.Where(m => m.TpdEntryAndExitHistoryId == uniqueId.Id)
            .ApplyWhere(tpdEntryAndExitHistoryFindManyArgs.Where)
            .ApplySkip(tpdEntryAndExitHistoryFindManyArgs.Skip)
            .ApplyTake(tpdEntryAndExitHistoryFindManyArgs.Take)
            .ApplyOrderBy(tpdEntryAndExitHistoryFindManyArgs.SortBy)
            .ToListAsync();

        return generalTravelerInformationTpds.Select(x => x.ToDto()).ToList();
    }

    /// <summary>
    /// Update multiple GeneralTravelerInformationTpds records for TpdEntryAndExitHistory
    /// </summary>
    public async Task UpdateGeneralTravelerInformationTpds(
        TpdEntryAndExitHistoryWhereUniqueInput uniqueId,
        GeneralTravelerInformationTpdWhereUniqueInput[] generalTravelerInformationTpdsId
    )
    {
        var tpdEntryAndExitHistory = await _context
            .TpdEntryAndExitHistories.Include(t => t.GeneralTravelerInformationTpds)
            .FirstOrDefaultAsync(x => x.Id == uniqueId.Id);
        if (tpdEntryAndExitHistory == null)
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

        tpdEntryAndExitHistory.GeneralTravelerInformationTpds = generalTravelerInformationTpds;
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Connect multiple ImportDeclarations records to TpdEntryAndExitHistory
    /// </summary>
    public async Task ConnectImportDeclarations(
        TpdEntryAndExitHistoryWhereUniqueInput uniqueId,
        ImportDeclarationWhereUniqueInput[] importDeclarationsId
    )
    {
        var parent = await _context
            .TpdEntryAndExitHistories.Include(x => x.ImportDeclarations)
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
    /// Disconnect multiple ImportDeclarations records from TpdEntryAndExitHistory
    /// </summary>
    public async Task DisconnectImportDeclarations(
        TpdEntryAndExitHistoryWhereUniqueInput uniqueId,
        ImportDeclarationWhereUniqueInput[] importDeclarationsId
    )
    {
        var parent = await _context
            .TpdEntryAndExitHistories.Include(x => x.ImportDeclarations)
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
    /// Find multiple ImportDeclarations records for TpdEntryAndExitHistory
    /// </summary>
    public async Task<List<ImportDeclaration>> FindImportDeclarations(
        TpdEntryAndExitHistoryWhereUniqueInput uniqueId,
        ImportDeclarationFindManyArgs tpdEntryAndExitHistoryFindManyArgs
    )
    {
        var importDeclarations = await _context
            .ImportDeclarations.Where(m => m.TpdEntryAndExitHistoryId == uniqueId.Id)
            .ApplyWhere(tpdEntryAndExitHistoryFindManyArgs.Where)
            .ApplySkip(tpdEntryAndExitHistoryFindManyArgs.Skip)
            .ApplyTake(tpdEntryAndExitHistoryFindManyArgs.Take)
            .ApplyOrderBy(tpdEntryAndExitHistoryFindManyArgs.SortBy)
            .ToListAsync();

        return importDeclarations.Select(x => x.ToDto()).ToList();
    }

    /// <summary>
    /// Update multiple ImportDeclarations records for TpdEntryAndExitHistory
    /// </summary>
    public async Task UpdateImportDeclarations(
        TpdEntryAndExitHistoryWhereUniqueInput uniqueId,
        ImportDeclarationWhereUniqueInput[] importDeclarationsId
    )
    {
        var tpdEntryAndExitHistory = await _context
            .TpdEntryAndExitHistories.Include(t => t.ImportDeclarations)
            .FirstOrDefaultAsync(x => x.Id == uniqueId.Id);
        if (tpdEntryAndExitHistory == null)
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

        tpdEntryAndExitHistory.ImportDeclarations = importDeclarations;
        await _context.SaveChangesAsync();
    }
}
