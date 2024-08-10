using Collection.APIs.Common;
using Collection.APIs.Dtos;
using Collection.APIs.Errors;
using Collection.APIs.Extensions;
using Collection.Infrastructure;
using Collection.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Collection.APIs;

public abstract class NoticeStaggeringsServiceBase : INoticeStaggeringsService
{
    protected readonly CollectionDbContext _context;

    public NoticeStaggeringsServiceBase(CollectionDbContext context)
    {
        _context = context;
    }

    /// <summary>
    ///     Create one NOTICE STAGGERING
    /// </summary>
    public async Task<NoticeStaggering> CreateNoticeStaggering(
        NoticeStaggeringCreateInput createDto
    )
    {
        var noticeStaggering = new NoticeStaggeringDbModel
        {
            AttachmentId = createDto.AttachmentId,
            CreatedAt = createDto.CreatedAt,
            DeletionOn = createDto.DeletionOn,
            FinalModificationDateAndTime = createDto.FinalModificationDateAndTime,
            FinalModifierId = createDto.FinalModifierId,
            FirstRegistrantId = createDto.FirstRegistrantId,
            FirstRegistrationDateAndTime = createDto.FirstRegistrationDateAndTime,
            NoticeNo = createDto.NoticeNo,
            NumberOfStaggeredNotices = createDto.NumberOfStaggeredNotices,
            OfficeCode = createDto.OfficeCode,
            RegisteringPersonId = createDto.RegisteringPersonId,
            ServiceCode = createDto.ServiceCode,
            StaggeredNoticesGroupingDate = createDto.StaggeredNoticesGroupingDate,
            StaggeredNoticesGroupingPersonId = createDto.StaggeredNoticesGroupingPersonId,
            StaggeredNoticesGroupingReasonContent = createDto.StaggeredNoticesGroupingReasonContent,
            StaggeringDate = createDto.StaggeringDate,
            StaggeringReasonContent = createDto.StaggeringReasonContent,
            UpdatedAt = createDto.UpdatedAt
        };

        if (createDto.Id != null) noticeStaggering.Id = createDto.Id;

        _context.NoticeStaggerings.Add(noticeStaggering);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<NoticeStaggeringDbModel>(noticeStaggering.Id);

        if (result == null) throw new NotFoundException();

        return result.ToDto();
    }

    /// <summary>
    ///     Delete one NOTICE STAGGERING
    /// </summary>
    public async Task DeleteNoticeStaggering(NoticeStaggeringWhereUniqueInput uniqueId)
    {
        var noticeStaggering = await _context.NoticeStaggerings.FindAsync(uniqueId.Id);
        if (noticeStaggering == null) throw new NotFoundException();

        _context.NoticeStaggerings.Remove(noticeStaggering);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    ///     Find many NOTICE STAGGERINGS
    /// </summary>
    public async Task<List<NoticeStaggering>> NoticeStaggerings(
        NoticeStaggeringFindManyArgs findManyArgs
    )
    {
        var noticeStaggerings = await _context
            .NoticeStaggerings.ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return noticeStaggerings.ConvertAll(noticeStaggering => noticeStaggering.ToDto());
    }

    /// <summary>
    ///     Meta data about NOTICE STAGGERING records
    /// </summary>
    public async Task<MetadataDto> NoticeStaggeringsMeta(NoticeStaggeringFindManyArgs findManyArgs)
    {
        var count = await _context.NoticeStaggerings.ApplyWhere(findManyArgs.Where).CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    ///     Get one NOTICE STAGGERING
    /// </summary>
    public async Task<NoticeStaggering> NoticeStaggering(NoticeStaggeringWhereUniqueInput uniqueId)
    {
        var noticeStaggerings = await NoticeStaggerings(
            new NoticeStaggeringFindManyArgs
            {
                Where = new NoticeStaggeringWhereInput { Id = uniqueId.Id }
            }
        );
        var noticeStaggering = noticeStaggerings.FirstOrDefault();
        if (noticeStaggering == null) throw new NotFoundException();

        return noticeStaggering;
    }

    /// <summary>
    ///     Update one NOTICE STAGGERING
    /// </summary>
    public async Task UpdateNoticeStaggering(
        NoticeStaggeringWhereUniqueInput uniqueId,
        NoticeStaggeringUpdateInput updateDto
    )
    {
        var noticeStaggering = updateDto.ToModel(uniqueId);

        _context.Entry(noticeStaggering).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!_context.NoticeStaggerings.Any(e => e.Id == noticeStaggering.Id))
                throw new NotFoundException();
            throw;
        }
    }
}
