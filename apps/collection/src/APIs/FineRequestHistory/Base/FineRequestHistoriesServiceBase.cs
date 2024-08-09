using Collection.APIs;
using Collection.APIs.Common;
using Collection.APIs.Dtos;
using Collection.APIs.Errors;
using Collection.APIs.Extensions;
using Collection.Infrastructure;
using Collection.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Collection.APIs;

public abstract class FineRequestHistoriesServiceBase : IFineRequestHistoriesService
{
    protected readonly CollectionDbContext _context;

    public FineRequestHistoriesServiceBase(CollectionDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one FINE REQUEST HISTORY
    /// </summary>
    public async Task<FineRequestHistory> CreateFineRequestHistory(
        FineRequestHistoryCreateInput createDto
    )
    {
        var fineRequestHistory = new FineRequestHistoryDbModel
        {
            AlignmentOrder = createDto.AlignmentOrder,
            CappedAmount = createDto.CappedAmount,
            CreatedAt = createDto.CreatedAt,
            DeletionOn = createDto.DeletionOn,
            FinalModificationDateAndTime = createDto.FinalModificationDateAndTime,
            FinalModifierId = createDto.FinalModifierId,
            FineAmount = createDto.FineAmount,
            FineImpositionRequestNo = createDto.FineImpositionRequestNo,
            FineRelatedTaxCode = createDto.FineRelatedTaxCode,
            FirstRegistrantId = createDto.FirstRegistrantId,
            FirstRegistrationDateAndTime = createDto.FirstRegistrationDateAndTime,
            FloorAmount = createDto.FloorAmount,
            InfractionCode = createDto.InfractionCode,
            OperationTypeCode = createDto.OperationTypeCode,
            RequestOrderNumber = createDto.RequestOrderNumber,
            UpdatedAt = createDto.UpdatedAt
        };

        if (createDto.Id != null)
        {
            fineRequestHistory.Id = createDto.Id;
        }

        _context.FineRequestHistories.Add(fineRequestHistory);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<FineRequestHistoryDbModel>(fineRequestHistory.Id);

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one FINE REQUEST HISTORY
    /// </summary>
    public async Task DeleteFineRequestHistory(FineRequestHistoryWhereUniqueInput uniqueId)
    {
        var fineRequestHistory = await _context.FineRequestHistories.FindAsync(uniqueId.Id);
        if (fineRequestHistory == null)
        {
            throw new NotFoundException();
        }

        _context.FineRequestHistories.Remove(fineRequestHistory);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many FINE REQUEST HISTORIES
    /// </summary>
    public async Task<List<FineRequestHistory>> FineRequestHistories(
        FineRequestHistoryFindManyArgs findManyArgs
    )
    {
        var fineRequestHistories = await _context
            .FineRequestHistories.ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return fineRequestHistories.ConvertAll(fineRequestHistory => fineRequestHistory.ToDto());
    }

    /// <summary>
    /// Meta data about FINE REQUEST HISTORY records
    /// </summary>
    public async Task<MetadataDto> FineRequestHistoriesMeta(
        FineRequestHistoryFindManyArgs findManyArgs
    )
    {
        var count = await _context.FineRequestHistories.ApplyWhere(findManyArgs.Where).CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one FINE REQUEST HISTORY
    /// </summary>
    public async Task<FineRequestHistory> FineRequestHistory(
        FineRequestHistoryWhereUniqueInput uniqueId
    )
    {
        var fineRequestHistories = await this.FineRequestHistories(
            new FineRequestHistoryFindManyArgs
            {
                Where = new FineRequestHistoryWhereInput { Id = uniqueId.Id }
            }
        );
        var fineRequestHistory = fineRequestHistories.FirstOrDefault();
        if (fineRequestHistory == null)
        {
            throw new NotFoundException();
        }

        return fineRequestHistory;
    }

    /// <summary>
    /// Update one FINE REQUEST HISTORY
    /// </summary>
    public async Task UpdateFineRequestHistory(
        FineRequestHistoryWhereUniqueInput uniqueId,
        FineRequestHistoryUpdateInput updateDto
    )
    {
        var fineRequestHistory = updateDto.ToModel(uniqueId);

        _context.Entry(fineRequestHistory).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!_context.FineRequestHistories.Any(e => e.Id == fineRequestHistory.Id))
            {
                throw new NotFoundException();
            }
            else
            {
                throw;
            }
        }
    }
}
