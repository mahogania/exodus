using Microsoft.EntityFrameworkCore;
using Traveler.APIs;
using Traveler.APIs.Common;
using Traveler.APIs.Dtos;
using Traveler.APIs.Errors;
using Traveler.APIs.Extensions;
using Traveler.Infrastructure;
using Traveler.Infrastructure.Models;

namespace Traveler.APIs;

public abstract class TravelerSearchHistoriesServiceBase : ITravelerSearchHistoriesService
{
    protected readonly TravelerDbContext _context;

    public TravelerSearchHistoriesServiceBase(TravelerDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one TravelerSearchHistory
    /// </summary>
    public async Task<TravelerSearchHistory> CreateTravelerSearchHistory(
        TravelerSearchHistoryCreateInput createDto
    )
    {
        var travelerSearchHistory = new TravelerSearchHistoryDbModel
        {
            CreatedAt = createDto.CreatedAt,
            UpdatedAt = createDto.UpdatedAt
        };

        if (createDto.Id != null)
        {
            travelerSearchHistory.Id = createDto.Id;
        }
        if (createDto.GeneralTravelerInformationTpds != null)
        {
            travelerSearchHistory.GeneralTravelerInformationTpds = await _context
                .GeneralTravelerInformationTpds.Where(generalTravelerInformationTpd =>
                    createDto
                        .GeneralTravelerInformationTpds.Select(t => t.Id)
                        .Contains(generalTravelerInformationTpd.Id)
                )
                .ToListAsync();
        }

        _context.TravelerSearchHistories.Add(travelerSearchHistory);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<TravelerSearchHistoryDbModel>(
            travelerSearchHistory.Id
        );

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one TravelerSearchHistory
    /// </summary>
    public async Task DeleteTravelerSearchHistory(TravelerSearchHistoryWhereUniqueInput uniqueId)
    {
        var travelerSearchHistory = await _context.TravelerSearchHistories.FindAsync(uniqueId.Id);
        if (travelerSearchHistory == null)
        {
            throw new NotFoundException();
        }

        _context.TravelerSearchHistories.Remove(travelerSearchHistory);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many TravelerSearchHistories
    /// </summary>
    public async Task<List<TravelerSearchHistory>> TravelerSearchHistories(
        TravelerSearchHistoryFindManyArgs findManyArgs
    )
    {
        var travelerSearchHistories = await _context
            .TravelerSearchHistories.Include(x => x.GeneralTravelerInformationTpds)
            .ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return travelerSearchHistories.ConvertAll(travelerSearchHistory =>
            travelerSearchHistory.ToDto()
        );
    }

    /// <summary>
    /// Meta data about TravelerSearchHistory records
    /// </summary>
    public async Task<MetadataDto> TravelerSearchHistoriesMeta(
        TravelerSearchHistoryFindManyArgs findManyArgs
    )
    {
        var count = await _context
            .TravelerSearchHistories.ApplyWhere(findManyArgs.Where)
            .CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one TravelerSearchHistory
    /// </summary>
    public async Task<TravelerSearchHistory> TravelerSearchHistory(
        TravelerSearchHistoryWhereUniqueInput uniqueId
    )
    {
        var travelerSearchHistories = await this.TravelerSearchHistories(
            new TravelerSearchHistoryFindManyArgs
            {
                Where = new TravelerSearchHistoryWhereInput { Id = uniqueId.Id }
            }
        );
        var travelerSearchHistory = travelerSearchHistories.FirstOrDefault();
        if (travelerSearchHistory == null)
        {
            throw new NotFoundException();
        }

        return travelerSearchHistory;
    }

    /// <summary>
    /// Update one TravelerSearchHistory
    /// </summary>
    public async Task UpdateTravelerSearchHistory(
        TravelerSearchHistoryWhereUniqueInput uniqueId,
        TravelerSearchHistoryUpdateInput updateDto
    )
    {
        var travelerSearchHistory = updateDto.ToModel(uniqueId);

        if (updateDto.GeneralTravelerInformationTpds != null)
        {
            travelerSearchHistory.GeneralTravelerInformationTpds = await _context
                .GeneralTravelerInformationTpds.Where(generalTravelerInformationTpd =>
                    updateDto
                        .GeneralTravelerInformationTpds.Select(t => t)
                        .Contains(generalTravelerInformationTpd.Id)
                )
                .ToListAsync();
        }

        _context.Entry(travelerSearchHistory).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!_context.TravelerSearchHistories.Any(e => e.Id == travelerSearchHistory.Id))
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
    /// Connect multiple GeneralTravelerInformationTpds records to TravelerSearchHistory
    /// </summary>
    public async Task ConnectGeneralTravelerInformationTpds(
        TravelerSearchHistoryWhereUniqueInput uniqueId,
        GeneralTravelerInformationTpdWhereUniqueInput[] generalTravelerInformationTpdsId
    )
    {
        var parent = await _context
            .TravelerSearchHistories.Include(x => x.GeneralTravelerInformationTpds)
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
    /// Disconnect multiple GeneralTravelerInformationTpds records from TravelerSearchHistory
    /// </summary>
    public async Task DisconnectGeneralTravelerInformationTpds(
        TravelerSearchHistoryWhereUniqueInput uniqueId,
        GeneralTravelerInformationTpdWhereUniqueInput[] generalTravelerInformationTpdsId
    )
    {
        var parent = await _context
            .TravelerSearchHistories.Include(x => x.GeneralTravelerInformationTpds)
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
    /// Find multiple GeneralTravelerInformationTpds records for TravelerSearchHistory
    /// </summary>
    public async Task<List<GeneralTravelerInformationTpd>> FindGeneralTravelerInformationTpds(
        TravelerSearchHistoryWhereUniqueInput uniqueId,
        GeneralTravelerInformationTpdFindManyArgs travelerSearchHistoryFindManyArgs
    )
    {
        var generalTravelerInformationTpds = await _context
            .GeneralTravelerInformationTpds.Where(m => m.TravelerSearchHistoryId == uniqueId.Id)
            .ApplyWhere(travelerSearchHistoryFindManyArgs.Where)
            .ApplySkip(travelerSearchHistoryFindManyArgs.Skip)
            .ApplyTake(travelerSearchHistoryFindManyArgs.Take)
            .ApplyOrderBy(travelerSearchHistoryFindManyArgs.SortBy)
            .ToListAsync();

        return generalTravelerInformationTpds.Select(x => x.ToDto()).ToList();
    }

    /// <summary>
    /// Update multiple GeneralTravelerInformationTpds records for TravelerSearchHistory
    /// </summary>
    public async Task UpdateGeneralTravelerInformationTpds(
        TravelerSearchHistoryWhereUniqueInput uniqueId,
        GeneralTravelerInformationTpdWhereUniqueInput[] generalTravelerInformationTpdsId
    )
    {
        var travelerSearchHistory = await _context
            .TravelerSearchHistories.Include(t => t.GeneralTravelerInformationTpds)
            .FirstOrDefaultAsync(x => x.Id == uniqueId.Id);
        if (travelerSearchHistory == null)
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

        travelerSearchHistory.GeneralTravelerInformationTpds = generalTravelerInformationTpds;
        await _context.SaveChangesAsync();
    }
}
