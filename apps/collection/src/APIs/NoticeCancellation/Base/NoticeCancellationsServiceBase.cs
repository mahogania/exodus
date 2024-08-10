using Collection.APIs.Common;
using Collection.APIs.Dtos;
using Collection.APIs.Errors;
using Collection.APIs.Extensions;
using Collection.Infrastructure;
using Collection.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Collection.APIs;

public abstract class NoticeCancellationsServiceBase : INoticeCancellationsService
{
    protected readonly CollectionDbContext _context;

    public NoticeCancellationsServiceBase(CollectionDbContext context)
    {
        _context = context;
    }

    /// <summary>
    ///     Create one NOTICE CANCELLATION
    /// </summary>
    public async Task<NoticeCancellation> CreateNoticeCancellation(
        NoticeCancellationCreateInput createDto
    )
    {
        var noticeCancellation = new NoticeCancellationDbModel
        {
            AttachmentId = createDto.AttachmentId,
            CancellationDate = createDto.CancellationDate,
            CancellationReasonContent = createDto.CancellationReasonContent,
            CreatedAt = createDto.CreatedAt,
            DeletionOn = createDto.DeletionOn,
            FinalModificationDateAndTime = createDto.FinalModificationDateAndTime,
            FinalModifierId = createDto.FinalModifierId,
            FirstRegistrantId = createDto.FirstRegistrantId,
            FirstRegistrationDateAndTime = createDto.FirstRegistrationDateAndTime,
            NoticeCancellationRequestNo = createDto.NoticeCancellationRequestNo,
            NoticeNo = createDto.NoticeNo,
            OfficeCode = createDto.OfficeCode,
            RegisteringPersonId = createDto.RegisteringPersonId,
            RegistrationDate = createDto.RegistrationDate,
            RequestOrderNo = createDto.RequestOrderNo,
            ServiceCode = createDto.ServiceCode,
            UpdatedAt = createDto.UpdatedAt
        };

        if (createDto.Id != null) noticeCancellation.Id = createDto.Id;

        _context.NoticeCancellations.Add(noticeCancellation);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<NoticeCancellationDbModel>(noticeCancellation.Id);

        if (result == null) throw new NotFoundException();

        return result.ToDto();
    }

    /// <summary>
    ///     Delete one NOTICE CANCELLATION
    /// </summary>
    public async Task DeleteNoticeCancellation(NoticeCancellationWhereUniqueInput uniqueId)
    {
        var noticeCancellation = await _context.NoticeCancellations.FindAsync(uniqueId.Id);
        if (noticeCancellation == null) throw new NotFoundException();

        _context.NoticeCancellations.Remove(noticeCancellation);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    ///     Find many NOTICE CANCELLATIONS
    /// </summary>
    public async Task<List<NoticeCancellation>> NoticeCancellations(
        NoticeCancellationFindManyArgs findManyArgs
    )
    {
        var noticeCancellations = await _context
            .NoticeCancellations.ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return noticeCancellations.ConvertAll(noticeCancellation => noticeCancellation.ToDto());
    }

    /// <summary>
    ///     Meta data about NOTICE CANCELLATION records
    /// </summary>
    public async Task<MetadataDto> NoticeCancellationsMeta(
        NoticeCancellationFindManyArgs findManyArgs
    )
    {
        var count = await _context.NoticeCancellations.ApplyWhere(findManyArgs.Where).CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    ///     Get one NOTICE CANCELLATION
    /// </summary>
    public async Task<NoticeCancellation> NoticeCancellation(
        NoticeCancellationWhereUniqueInput uniqueId
    )
    {
        var noticeCancellations = await NoticeCancellations(
            new NoticeCancellationFindManyArgs
            {
                Where = new NoticeCancellationWhereInput { Id = uniqueId.Id }
            }
        );
        var noticeCancellation = noticeCancellations.FirstOrDefault();
        if (noticeCancellation == null) throw new NotFoundException();

        return noticeCancellation;
    }

    /// <summary>
    ///     Update one NOTICE CANCELLATION
    /// </summary>
    public async Task UpdateNoticeCancellation(
        NoticeCancellationWhereUniqueInput uniqueId,
        NoticeCancellationUpdateInput updateDto
    )
    {
        var noticeCancellation = updateDto.ToModel(uniqueId);

        _context.Entry(noticeCancellation).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!_context.NoticeCancellations.Any(e => e.Id == noticeCancellation.Id))
                throw new NotFoundException();
            throw;
        }
    }
}
