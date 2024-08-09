using Collection.APIs;
using Collection.APIs.Common;
using Collection.APIs.Dtos;
using Collection.APIs.Errors;
using Collection.APIs.Extensions;
using Collection.Infrastructure;
using Collection.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Collection.APIs;

public abstract class AdjustmentsServiceBase : IAdjustmentsService
{
    protected readonly CollectionDbContext _context;

    public AdjustmentsServiceBase(CollectionDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one ADJUSTMENT
    /// </summary>
    public async Task<Adjustment> CreateAdjustment(AdjustmentCreateInput createDto)
    {
        var adjustment = new AdjustmentDbModel
        {
            AdjustmentDate = createDto.AdjustmentDate,
            AdjustmentReasonContent = createDto.AdjustmentReasonContent,
            AttachedFileId = createDto.AttachedFileId,
            CreatedAt = createDto.CreatedAt,
            DeletionOn = createDto.DeletionOn,
            FinalModificationDateAndTime = createDto.FinalModificationDateAndTime,
            FinalModifierId = createDto.FinalModifierId,
            FirstRegistrantId = createDto.FirstRegistrantId,
            FirstRegistrationDateAndTime = createDto.FirstRegistrationDateAndTime,
            LatePaymentInterestAmount = createDto.LatePaymentInterestAmount,
            LatePaymentInterestAmountExistingBeforeLatePayment =
                createDto.LatePaymentInterestAmountExistingBeforeLatePayment,
            NoticeNumber = createDto.NoticeNumber,
            NumberOfAdjustments = createDto.NumberOfAdjustments,
            NumberOfLatePayments = createDto.NumberOfLatePayments,
            OfficeCode = createDto.OfficeCode,
            PreviousTotalNoticeAmount = createDto.PreviousTotalNoticeAmount,
            RegisteringPersonId = createDto.RegisteringPersonId,
            ServiceCode = createDto.ServiceCode,
            TotalNoticeAmount = createDto.TotalNoticeAmount,
            UnadjustedLatePaymentInterestAmount = createDto.UnadjustedLatePaymentInterestAmount,
            UpdatedAt = createDto.UpdatedAt
        };

        if (createDto.Id != null)
        {
            adjustment.Id = createDto.Id;
        }

        _context.Adjustments.Add(adjustment);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<AdjustmentDbModel>(adjustment.Id);

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one ADJUSTMENT
    /// </summary>
    public async Task DeleteAdjustment(AdjustmentWhereUniqueInput uniqueId)
    {
        var adjustment = await _context.Adjustments.FindAsync(uniqueId.Id);
        if (adjustment == null)
        {
            throw new NotFoundException();
        }

        _context.Adjustments.Remove(adjustment);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many ADJUSTMENTS
    /// </summary>
    public async Task<List<Adjustment>> Adjustments(AdjustmentFindManyArgs findManyArgs)
    {
        var adjustments = await _context
            .Adjustments.ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return adjustments.ConvertAll(adjustment => adjustment.ToDto());
    }

    /// <summary>
    /// Meta data about ADJUSTMENT records
    /// </summary>
    public async Task<MetadataDto> AdjustmentsMeta(AdjustmentFindManyArgs findManyArgs)
    {
        var count = await _context.Adjustments.ApplyWhere(findManyArgs.Where).CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one ADJUSTMENT
    /// </summary>
    public async Task<Adjustment> Adjustment(AdjustmentWhereUniqueInput uniqueId)
    {
        var adjustments = await this.Adjustments(
            new AdjustmentFindManyArgs { Where = new AdjustmentWhereInput { Id = uniqueId.Id } }
        );
        var adjustment = adjustments.FirstOrDefault();
        if (adjustment == null)
        {
            throw new NotFoundException();
        }

        return adjustment;
    }

    /// <summary>
    /// Update one ADJUSTMENT
    /// </summary>
    public async Task UpdateAdjustment(
        AdjustmentWhereUniqueInput uniqueId,
        AdjustmentUpdateInput updateDto
    )
    {
        var adjustment = updateDto.ToModel(uniqueId);

        _context.Entry(adjustment).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!_context.Adjustments.Any(e => e.Id == adjustment.Id))
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
