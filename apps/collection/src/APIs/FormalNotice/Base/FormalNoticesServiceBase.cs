using Collection.APIs;
using Collection.APIs.Common;
using Collection.APIs.Dtos;
using Collection.APIs.Errors;
using Collection.APIs.Extensions;
using Collection.Infrastructure;
using Collection.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Collection.APIs;

public abstract class FormalNoticesServiceBase : IFormalNoticesService
{
    protected readonly CollectionDbContext _context;

    public FormalNoticesServiceBase(CollectionDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one FORMAL NOTICE
    /// </summary>
    public async Task<FormalNotice> CreateFormalNotice(FormalNoticeCreateInput createDto)
    {
        var formalNotice = new FormalNoticeDbModel
        {
            CreatedAt = createDto.CreatedAt,
            DeletionOn = createDto.DeletionOn,
            FinalModificationDateAndTime = createDto.FinalModificationDateAndTime,
            FinalModifierId = createDto.FinalModifierId,
            FirstRegistrantId = createDto.FirstRegistrantId,
            FirstRegistrationDateAndTime = createDto.FirstRegistrationDateAndTime,
            FormalNoticeNumber = createDto.FormalNoticeNumber,
            InitialApAmount = createDto.InitialApAmount,
            LatePaymentDate = createDto.LatePaymentDate,
            LatePaymentInterestAmount = createDto.LatePaymentInterestAmount,
            NoticeNumber = createDto.NoticeNumber,
            NotificationDate = createDto.NotificationDate,
            NumberOfFormalNotices = createDto.NumberOfFormalNotices,
            NumberOfLatePayments = createDto.NumberOfLatePayments,
            PaymentDeadline = createDto.PaymentDeadline,
            UpdatedAt = createDto.UpdatedAt
        };

        if (createDto.Id != null)
        {
            formalNotice.Id = createDto.Id;
        }

        _context.FormalNotices.Add(formalNotice);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<FormalNoticeDbModel>(formalNotice.Id);

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one FORMAL NOTICE
    /// </summary>
    public async Task DeleteFormalNotice(FormalNoticeWhereUniqueInput uniqueId)
    {
        var formalNotice = await _context.FormalNotices.FindAsync(uniqueId.Id);
        if (formalNotice == null)
        {
            throw new NotFoundException();
        }

        _context.FormalNotices.Remove(formalNotice);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many FORMAL NOTICES
    /// </summary>
    public async Task<List<FormalNotice>> FormalNotices(FormalNoticeFindManyArgs findManyArgs)
    {
        var formalNotices = await _context
            .FormalNotices.ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return formalNotices.ConvertAll(formalNotice => formalNotice.ToDto());
    }

    /// <summary>
    /// Meta data about FORMAL NOTICE records
    /// </summary>
    public async Task<MetadataDto> FormalNoticesMeta(FormalNoticeFindManyArgs findManyArgs)
    {
        var count = await _context.FormalNotices.ApplyWhere(findManyArgs.Where).CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one FORMAL NOTICE
    /// </summary>
    public async Task<FormalNotice> FormalNotice(FormalNoticeWhereUniqueInput uniqueId)
    {
        var formalNotices = await this.FormalNotices(
            new FormalNoticeFindManyArgs { Where = new FormalNoticeWhereInput { Id = uniqueId.Id } }
        );
        var formalNotice = formalNotices.FirstOrDefault();
        if (formalNotice == null)
        {
            throw new NotFoundException();
        }

        return formalNotice;
    }

    /// <summary>
    /// Update one FORMAL NOTICE
    /// </summary>
    public async Task UpdateFormalNotice(
        FormalNoticeWhereUniqueInput uniqueId,
        FormalNoticeUpdateInput updateDto
    )
    {
        var formalNotice = updateDto.ToModel(uniqueId);

        _context.Entry(formalNotice).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!_context.FormalNotices.Any(e => e.Id == formalNotice.Id))
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
