using Microsoft.EntityFrameworkCore;
using Traveler.APIs;
using Traveler.APIs.Common;
using Traveler.APIs.Dtos;
using Traveler.APIs.Errors;
using Traveler.APIs.Extensions;
using Traveler.Infrastructure;
using Traveler.Infrastructure.Models;

namespace Traveler.APIs;

public abstract class InspectorRatingModificationHistoriesServiceBase
    : IInspectorRatingModificationHistoriesService
{
    protected readonly TravelerDbContext _context;

    public InspectorRatingModificationHistoriesServiceBase(TravelerDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one InspectorRatingModificationHistory
    /// </summary>
    public async Task<InspectorRatingModificationHistory> CreateInspectorRatingModificationHistory(
        InspectorRatingModificationHistoryCreateInput createDto
    )
    {
        var inspectorRatingModificationHistory = new InspectorRatingModificationHistoryDbModel
        {
            AuditorClassificationCode = createDto.AuditorClassificationCode,
            CreatedAt = createDto.CreatedAt,
            DistributionContent = createDto.DistributionContent,
            DistributionReasonCode = createDto.DistributionReasonCode,
            ExaminerIdAfterModification = createDto.ExaminerIdAfterModification,
            ExaminerIdBeforeChange = createDto.ExaminerIdBeforeChange,
            FinalModificationDateAndTime = createDto.FinalModificationDateAndTime,
            FirstRegistrationDateAndTime = createDto.FirstRegistrationDateAndTime,
            HistorySequenceNumber = createDto.HistorySequenceNumber,
            ReferenceNumber = createDto.ReferenceNumber,
            UpdatedAt = createDto.UpdatedAt
        };

        if (createDto.Id != null)
        {
            inspectorRatingModificationHistory.Id = createDto.Id;
        }
        if (createDto.GeneralTravelerInformationTpds != null)
        {
            inspectorRatingModificationHistory.GeneralTravelerInformationTpds = await _context
                .GeneralTravelerInformationTpds.Where(generalTravelerInformationTpd =>
                    createDto
                        .GeneralTravelerInformationTpds.Select(t => t.Id)
                        .Contains(generalTravelerInformationTpd.Id)
                )
                .ToListAsync();
        }

        _context.InspectorRatingModificationHistories.Add(inspectorRatingModificationHistory);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<InspectorRatingModificationHistoryDbModel>(
            inspectorRatingModificationHistory.Id
        );

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one InspectorRatingModificationHistory
    /// </summary>
    public async Task DeleteInspectorRatingModificationHistory(
        InspectorRatingModificationHistoryWhereUniqueInput uniqueId
    )
    {
        var inspectorRatingModificationHistory =
            await _context.InspectorRatingModificationHistories.FindAsync(uniqueId.Id);
        if (inspectorRatingModificationHistory == null)
        {
            throw new NotFoundException();
        }

        _context.InspectorRatingModificationHistories.Remove(inspectorRatingModificationHistory);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many InspectorRatingModificationHistories
    /// </summary>
    public async Task<
        List<InspectorRatingModificationHistory>
    > InspectorRatingModificationHistories(
        InspectorRatingModificationHistoryFindManyArgs findManyArgs
    )
    {
        var inspectorRatingModificationHistories = await _context
            .InspectorRatingModificationHistories.Include(x => x.GeneralTravelerInformationTpds)
            .ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return inspectorRatingModificationHistories.ConvertAll(inspectorRatingModificationHistory =>
            inspectorRatingModificationHistory.ToDto()
        );
    }

    /// <summary>
    /// Meta data about InspectorRatingModificationHistory records
    /// </summary>
    public async Task<MetadataDto> InspectorRatingModificationHistoriesMeta(
        InspectorRatingModificationHistoryFindManyArgs findManyArgs
    )
    {
        var count = await _context
            .InspectorRatingModificationHistories.ApplyWhere(findManyArgs.Where)
            .CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one InspectorRatingModificationHistory
    /// </summary>
    public async Task<InspectorRatingModificationHistory> InspectorRatingModificationHistory(
        InspectorRatingModificationHistoryWhereUniqueInput uniqueId
    )
    {
        var inspectorRatingModificationHistories = await this.InspectorRatingModificationHistories(
            new InspectorRatingModificationHistoryFindManyArgs
            {
                Where = new InspectorRatingModificationHistoryWhereInput { Id = uniqueId.Id }
            }
        );
        var inspectorRatingModificationHistory =
            inspectorRatingModificationHistories.FirstOrDefault();
        if (inspectorRatingModificationHistory == null)
        {
            throw new NotFoundException();
        }

        return inspectorRatingModificationHistory;
    }

    /// <summary>
    /// Update one InspectorRatingModificationHistory
    /// </summary>
    public async Task UpdateInspectorRatingModificationHistory(
        InspectorRatingModificationHistoryWhereUniqueInput uniqueId,
        InspectorRatingModificationHistoryUpdateInput updateDto
    )
    {
        var inspectorRatingModificationHistory = updateDto.ToModel(uniqueId);

        if (updateDto.GeneralTravelerInformationTpds != null)
        {
            inspectorRatingModificationHistory.GeneralTravelerInformationTpds = await _context
                .GeneralTravelerInformationTpds.Where(generalTravelerInformationTpd =>
                    updateDto
                        .GeneralTravelerInformationTpds.Select(t => t)
                        .Contains(generalTravelerInformationTpd.Id)
                )
                .ToListAsync();
        }

        _context.Entry(inspectorRatingModificationHistory).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (
                !_context.InspectorRatingModificationHistories.Any(e =>
                    e.Id == inspectorRatingModificationHistory.Id
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
    /// Connect multiple GeneralTravelerInformationTpds records to InspectorRatingModificationHistory
    /// </summary>
    public async Task ConnectGeneralTravelerInformationTpds(
        InspectorRatingModificationHistoryWhereUniqueInput uniqueId,
        GeneralTravelerInformationTpdWhereUniqueInput[] generalTravelerInformationTpdsId
    )
    {
        var parent = await _context
            .InspectorRatingModificationHistories.Include(x => x.GeneralTravelerInformationTpds)
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
    /// Disconnect multiple GeneralTravelerInformationTpds records from InspectorRatingModificationHistory
    /// </summary>
    public async Task DisconnectGeneralTravelerInformationTpds(
        InspectorRatingModificationHistoryWhereUniqueInput uniqueId,
        GeneralTravelerInformationTpdWhereUniqueInput[] generalTravelerInformationTpdsId
    )
    {
        var parent = await _context
            .InspectorRatingModificationHistories.Include(x => x.GeneralTravelerInformationTpds)
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
    /// Find multiple GeneralTravelerInformationTpds records for InspectorRatingModificationHistory
    /// </summary>
    public async Task<List<GeneralTravelerInformationTpd>> FindGeneralTravelerInformationTpds(
        InspectorRatingModificationHistoryWhereUniqueInput uniqueId,
        GeneralTravelerInformationTpdFindManyArgs inspectorRatingModificationHistoryFindManyArgs
    )
    {
        var generalTravelerInformationTpds = await _context
            .GeneralTravelerInformationTpds.Where(m =>
                m.InspectorRatingModificationHistoryId == uniqueId.Id
            )
            .ApplyWhere(inspectorRatingModificationHistoryFindManyArgs.Where)
            .ApplySkip(inspectorRatingModificationHistoryFindManyArgs.Skip)
            .ApplyTake(inspectorRatingModificationHistoryFindManyArgs.Take)
            .ApplyOrderBy(inspectorRatingModificationHistoryFindManyArgs.SortBy)
            .ToListAsync();

        return generalTravelerInformationTpds.Select(x => x.ToDto()).ToList();
    }

    /// <summary>
    /// Update multiple GeneralTravelerInformationTpds records for InspectorRatingModificationHistory
    /// </summary>
    public async Task UpdateGeneralTravelerInformationTpds(
        InspectorRatingModificationHistoryWhereUniqueInput uniqueId,
        GeneralTravelerInformationTpdWhereUniqueInput[] generalTravelerInformationTpdsId
    )
    {
        var inspectorRatingModificationHistory = await _context
            .InspectorRatingModificationHistories.Include(t => t.GeneralTravelerInformationTpds)
            .FirstOrDefaultAsync(x => x.Id == uniqueId.Id);
        if (inspectorRatingModificationHistory == null)
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

        inspectorRatingModificationHistory.GeneralTravelerInformationTpds =
            generalTravelerInformationTpds;
        await _context.SaveChangesAsync();
    }
}
