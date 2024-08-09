using Collection.APIs;
using Collection.APIs.Common;
using Collection.APIs.Dtos;
using Collection.APIs.Errors;
using Collection.APIs.Extensions;
using Collection.Infrastructure;
using Collection.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Collection.APIs;

public abstract class NoticeOfDefaultsServiceBase : INoticeOfDefaultsService
{
    protected readonly CollectionDbContext _context;

    public NoticeOfDefaultsServiceBase(CollectionDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one NOTICE OF DEFAULT
    /// </summary>
    public async Task<NoticeOfDefault> CreateNoticeOfDefault(NoticeOfDefaultCreateInput createDto)
    {
        var noticeOfDefault = new NoticeOfDefaultDbModel
        {
            CreatedAt = createDto.CreatedAt,
            DefaultNoticeNumber = createDto.DefaultNoticeNumber,
            DeletionOn = createDto.DeletionOn,
            FinalModificationDateAndTime = createDto.FinalModificationDateAndTime,
            FinalModifierId = createDto.FinalModifierId,
            FirstRegistrantId = createDto.FirstRegistrantId,
            FirstRegistrationDateAndTime = createDto.FirstRegistrationDateAndTime,
            InitialApAmount = createDto.InitialApAmount,
            LatePaymentDate = createDto.LatePaymentDate,
            LatePaymentInterestAmount = createDto.LatePaymentInterestAmount,
            NoticeNumber = createDto.NoticeNumber,
            NotificationDate = createDto.NotificationDate,
            NumberOfDefaultNotices = createDto.NumberOfDefaultNotices,
            NumberOfLatePayments = createDto.NumberOfLatePayments,
            PaymentDeadline = createDto.PaymentDeadline,
            UpdatedAt = createDto.UpdatedAt
        };

        if (createDto.Id != null)
        {
            noticeOfDefault.Id = createDto.Id;
        }

        _context.NoticeOfDefaults.Add(noticeOfDefault);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<NoticeOfDefaultDbModel>(noticeOfDefault.Id);

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one NOTICE OF DEFAULT
    /// </summary>
    public async Task DeleteNoticeOfDefault(NoticeOfDefaultWhereUniqueInput uniqueId)
    {
        var noticeOfDefault = await _context.NoticeOfDefaults.FindAsync(uniqueId.Id);
        if (noticeOfDefault == null)
        {
            throw new NotFoundException();
        }

        _context.NoticeOfDefaults.Remove(noticeOfDefault);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many NOTICE OF DEFAULTS
    /// </summary>
    public async Task<List<NoticeOfDefault>> NoticeOfDefaults(
        NoticeOfDefaultFindManyArgs findManyArgs
    )
    {
        var noticeOfDefaults = await _context
            .NoticeOfDefaults.ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return noticeOfDefaults.ConvertAll(noticeOfDefault => noticeOfDefault.ToDto());
    }

    /// <summary>
    /// Meta data about NOTICE OF DEFAULT records
    /// </summary>
    public async Task<MetadataDto> NoticeOfDefaultsMeta(NoticeOfDefaultFindManyArgs findManyArgs)
    {
        var count = await _context.NoticeOfDefaults.ApplyWhere(findManyArgs.Where).CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one NOTICE OF DEFAULT
    /// </summary>
    public async Task<NoticeOfDefault> NoticeOfDefault(NoticeOfDefaultWhereUniqueInput uniqueId)
    {
        var noticeOfDefaults = await this.NoticeOfDefaults(
            new NoticeOfDefaultFindManyArgs
            {
                Where = new NoticeOfDefaultWhereInput { Id = uniqueId.Id }
            }
        );
        var noticeOfDefault = noticeOfDefaults.FirstOrDefault();
        if (noticeOfDefault == null)
        {
            throw new NotFoundException();
        }

        return noticeOfDefault;
    }

    /// <summary>
    /// Update one NOTICE OF DEFAULT
    /// </summary>
    public async Task UpdateNoticeOfDefault(
        NoticeOfDefaultWhereUniqueInput uniqueId,
        NoticeOfDefaultUpdateInput updateDto
    )
    {
        var noticeOfDefault = updateDto.ToModel(uniqueId);

        _context.Entry(noticeOfDefault).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!_context.NoticeOfDefaults.Any(e => e.Id == noticeOfDefault.Id))
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
