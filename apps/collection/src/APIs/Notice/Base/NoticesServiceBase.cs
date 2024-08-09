using Collection.APIs;
using Collection.APIs.Common;
using Collection.APIs.Dtos;
using Collection.APIs.Errors;
using Collection.APIs.Extensions;
using Collection.Infrastructure;
using Collection.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Collection.APIs;

public abstract class NoticesServiceBase : INoticesService
{
    protected readonly CollectionDbContext _context;

    public NoticesServiceBase(CollectionDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one NOTICE
    /// </summary>
    public async Task<Notice> CreateNotice(NoticeCreateInput createDto)
    {
        var notice = new NoticeDbModel
        {
            AmountOfOtherChargeableFees = createDto.AmountOfOtherChargeableFees,
            BondTypeCode = createDto.BondTypeCode,
            CancellationDate = createDto.CancellationDate,
            CancelledOn = createDto.CancelledOn,
            CollectedOn = createDto.CollectedOn,
            CreatedAt = createDto.CreatedAt,
            DeclarantCode = createDto.DeclarantCode,
            DeclarationNo = createDto.DeclarationNo,
            DeletionOn = createDto.DeletionOn,
            ExtendedDeadlineOn = createDto.ExtendedDeadlineOn,
            FinalModificationDateAndTime = createDto.FinalModificationDateAndTime,
            FinalModifierId = createDto.FinalModifierId,
            FinancialManagerName = createDto.FinancialManagerName,
            FineAmount = createDto.FineAmount,
            FirstRegistrantId = createDto.FirstRegistrantId,
            FirstRegistrationDateAndTime = createDto.FirstRegistrationDateAndTime,
            LateDate = createDto.LateDate,
            LateInterestAdjustedYn = createDto.LateInterestAdjustedYn,
            LateInterestAmount = createDto.LateInterestAmount,
            LatePaymentOn = createDto.LatePaymentOn,
            NiuCategoryCode = createDto.NiuCategoryCode,
            NoticeCancellationReasonCode = createDto.NoticeCancellationReasonCode,
            NoticeNo = createDto.NoticeNo,
            NoticeProcessingStatusCode = createDto.NoticeProcessingStatusCode,
            NoticeTypeCode = createDto.NoticeTypeCode,
            NotificationDate = createDto.NotificationDate,
            OfficeCode = createDto.OfficeCode,
            OriginalNoticeNo = createDto.OriginalNoticeNo,
            PaymentDeadline = createDto.PaymentDeadline,
            PaymentNoticeIssuanceMoment = createDto.PaymentNoticeIssuanceMoment,
            ReceiptIssuedOn = createDto.ReceiptIssuedOn,
            ReferenceDate = createDto.ReferenceDate,
            ReferenceNo = createDto.ReferenceNo,
            ReferenceNumberTypeCode = createDto.ReferenceNumberTypeCode,
            RefundedAmount = createDto.RefundedAmount,
            SentYn = createDto.SentYn,
            ServiceCode = createDto.ServiceCode,
            StaggeredNoticeOn = createDto.StaggeredNoticeOn,
            StaggeredNoticeProcessingCode = createDto.StaggeredNoticeProcessingCode,
            TaxpayerIdentificationNo = createDto.TaxpayerIdentificationNo,
            TotalAmount = createDto.TotalAmount,
            TransmissionTypeCode = createDto.TransmissionTypeCode,
            UnadjustedLateInterestAmount = createDto.UnadjustedLateInterestAmount,
            UpdatedAt = createDto.UpdatedAt,
            UseOfRemovalCreditOn = createDto.UseOfRemovalCreditOn,
            VehicleOn = createDto.VehicleOn
        };

        if (createDto.Id != null)
        {
            notice.Id = createDto.Id;
        }

        _context.Notices.Add(notice);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<NoticeDbModel>(notice.Id);

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one NOTICE
    /// </summary>
    public async Task DeleteNotice(NoticeWhereUniqueInput uniqueId)
    {
        var notice = await _context.Notices.FindAsync(uniqueId.Id);
        if (notice == null)
        {
            throw new NotFoundException();
        }

        _context.Notices.Remove(notice);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many NOTICES
    /// </summary>
    public async Task<List<Notice>> Notices(NoticeFindManyArgs findManyArgs)
    {
        var notices = await _context
            .Notices.ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return notices.ConvertAll(notice => notice.ToDto());
    }

    /// <summary>
    /// Meta data about NOTICE records
    /// </summary>
    public async Task<MetadataDto> NoticesMeta(NoticeFindManyArgs findManyArgs)
    {
        var count = await _context.Notices.ApplyWhere(findManyArgs.Where).CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one NOTICE
    /// </summary>
    public async Task<Notice> Notice(NoticeWhereUniqueInput uniqueId)
    {
        var notices = await this.Notices(
            new NoticeFindManyArgs { Where = new NoticeWhereInput { Id = uniqueId.Id } }
        );
        var notice = notices.FirstOrDefault();
        if (notice == null)
        {
            throw new NotFoundException();
        }

        return notice;
    }

    /// <summary>
    /// Update one NOTICE
    /// </summary>
    public async Task UpdateNotice(NoticeWhereUniqueInput uniqueId, NoticeUpdateInput updateDto)
    {
        var notice = updateDto.ToModel(uniqueId);

        _context.Entry(notice).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!_context.Notices.Any(e => e.Id == notice.Id))
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
