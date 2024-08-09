using Collection.APIs;
using Collection.APIs.Common;
using Collection.APIs.Dtos;
using Collection.APIs.Errors;
using Collection.APIs.Extensions;
using Collection.Infrastructure;
using Collection.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Collection.APIs;

public abstract class NoticeTypesServiceBase : INoticeTypesService
{
    protected readonly CollectionDbContext _context;

    public NoticeTypesServiceBase(CollectionDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one NOTICE TYPE
    /// </summary>
    public async Task<NoticeType> CreateNoticeType(NoticeTypeCreateInput createDto)
    {
        var noticeType = new NoticeTypeDbModel
        {
            CreatedAt = createDto.CreatedAt,
            DeletionOn = createDto.DeletionOn,
            FinalModificationDateAndTime = createDto.FinalModificationDateAndTime,
            FinalModifierId = createDto.FinalModifierId,
            FirstRegistrantId = createDto.FirstRegistrantId,
            FirstRegistrationDateAndTime = createDto.FirstRegistrationDateAndTime,
            LatePaymentInterestAmountCapRate = createDto.LatePaymentInterestAmountCapRate,
            LatePaymentInterestRate = createDto.LatePaymentInterestRate,
            NoticeTypeCode = createDto.NoticeTypeCode,
            NumberOfDueDays = createDto.NumberOfDueDays,
            NumberOfTimesUsed = createDto.NumberOfTimesUsed,
            UpdatedAt = createDto.UpdatedAt,
            UsedOn = createDto.UsedOn
        };

        if (createDto.Id != null)
        {
            noticeType.Id = createDto.Id;
        }

        _context.NoticeTypes.Add(noticeType);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<NoticeTypeDbModel>(noticeType.Id);

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one NOTICE TYPE
    /// </summary>
    public async Task DeleteNoticeType(NoticeTypeWhereUniqueInput uniqueId)
    {
        var noticeType = await _context.NoticeTypes.FindAsync(uniqueId.Id);
        if (noticeType == null)
        {
            throw new NotFoundException();
        }

        _context.NoticeTypes.Remove(noticeType);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many NOTICE TYPES
    /// </summary>
    public async Task<List<NoticeType>> NoticeTypes(NoticeTypeFindManyArgs findManyArgs)
    {
        var noticeTypes = await _context
            .NoticeTypes.ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return noticeTypes.ConvertAll(noticeType => noticeType.ToDto());
    }

    /// <summary>
    /// Meta data about NOTICE TYPE records
    /// </summary>
    public async Task<MetadataDto> NoticeTypesMeta(NoticeTypeFindManyArgs findManyArgs)
    {
        var count = await _context.NoticeTypes.ApplyWhere(findManyArgs.Where).CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one NOTICE TYPE
    /// </summary>
    public async Task<NoticeType> NoticeType(NoticeTypeWhereUniqueInput uniqueId)
    {
        var noticeTypes = await this.NoticeTypes(
            new NoticeTypeFindManyArgs { Where = new NoticeTypeWhereInput { Id = uniqueId.Id } }
        );
        var noticeType = noticeTypes.FirstOrDefault();
        if (noticeType == null)
        {
            throw new NotFoundException();
        }

        return noticeType;
    }

    /// <summary>
    /// Update one NOTICE TYPE
    /// </summary>
    public async Task UpdateNoticeType(
        NoticeTypeWhereUniqueInput uniqueId,
        NoticeTypeUpdateInput updateDto
    )
    {
        var noticeType = updateDto.ToModel(uniqueId);

        _context.Entry(noticeType).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!_context.NoticeTypes.Any(e => e.Id == noticeType.Id))
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
