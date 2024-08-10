using Collection.APIs.Common;
using Collection.APIs.Dtos;
using Collection.APIs.Errors;
using Collection.APIs.Extensions;
using Collection.Infrastructure;
using Collection.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Collection.APIs;

public abstract class FineCancellationRequestsServiceBase : IFineCancellationRequestsService
{
    protected readonly CollectionDbContext _context;

    public FineCancellationRequestsServiceBase(CollectionDbContext context)
    {
        _context = context;
    }

    /// <summary>
    ///     Create one FINE CANCELLATION REQUEST
    /// </summary>
    public async Task<FineCancellationRequest> CreateFineCancellationRequest(
        FineCancellationRequestCreateInput createDto
    )
    {
        var fineCancellationRequest = new FineCancellationRequestDbModel
        {
            ApprovalId = createDto.ApprovalId,
            AttachmentId = createDto.AttachmentId,
            CreatedAt = createDto.CreatedAt,
            DeletionOn = createDto.DeletionOn,
            FinalModificationDateAndTime = createDto.FinalModificationDateAndTime,
            FinalModifierId = createDto.FinalModifierId,
            FineCancellationReasonContent = createDto.FineCancellationReasonContent,
            FineCancellationRequestNo = createDto.FineCancellationRequestNo,
            FirstRegistrantId = createDto.FirstRegistrantId,
            FirstRegistrationDateAndTime = createDto.FirstRegistrationDateAndTime,
            NoticeNo = createDto.NoticeNo,
            OfficeCode = createDto.OfficeCode,
            RequestDate = createDto.RequestDate,
            RequestingPersonId = createDto.RequestingPersonId,
            ServiceCode = createDto.ServiceCode,
            UpdatedAt = createDto.UpdatedAt
        };

        if (createDto.Id != null) fineCancellationRequest.Id = createDto.Id;

        _context.FineCancellationRequests.Add(fineCancellationRequest);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<FineCancellationRequestDbModel>(
            fineCancellationRequest.Id
        );

        if (result == null) throw new NotFoundException();

        return result.ToDto();
    }

    /// <summary>
    ///     Delete one FINE CANCELLATION REQUEST
    /// </summary>
    public async Task DeleteFineCancellationRequest(
        FineCancellationRequestWhereUniqueInput uniqueId
    )
    {
        var fineCancellationRequest = await _context.FineCancellationRequests.FindAsync(
            uniqueId.Id
        );
        if (fineCancellationRequest == null) throw new NotFoundException();

        _context.FineCancellationRequests.Remove(fineCancellationRequest);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    ///     Find many FINE CANCELLATION REQUESTS
    /// </summary>
    public async Task<List<FineCancellationRequest>> FineCancellationRequests(
        FineCancellationRequestFindManyArgs findManyArgs
    )
    {
        var fineCancellationRequests = await _context
            .FineCancellationRequests.ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return fineCancellationRequests.ConvertAll(fineCancellationRequest =>
            fineCancellationRequest.ToDto()
        );
    }

    /// <summary>
    ///     Meta data about FINE CANCELLATION REQUEST records
    /// </summary>
    public async Task<MetadataDto> FineCancellationRequestsMeta(
        FineCancellationRequestFindManyArgs findManyArgs
    )
    {
        var count = await _context
            .FineCancellationRequests.ApplyWhere(findManyArgs.Where)
            .CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    ///     Get one FINE CANCELLATION REQUEST
    /// </summary>
    public async Task<FineCancellationRequest> FineCancellationRequest(
        FineCancellationRequestWhereUniqueInput uniqueId
    )
    {
        var fineCancellationRequests = await FineCancellationRequests(
            new FineCancellationRequestFindManyArgs
            {
                Where = new FineCancellationRequestWhereInput { Id = uniqueId.Id }
            }
        );
        var fineCancellationRequest = fineCancellationRequests.FirstOrDefault();
        if (fineCancellationRequest == null) throw new NotFoundException();

        return fineCancellationRequest;
    }

    /// <summary>
    ///     Update one FINE CANCELLATION REQUEST
    /// </summary>
    public async Task UpdateFineCancellationRequest(
        FineCancellationRequestWhereUniqueInput uniqueId,
        FineCancellationRequestUpdateInput updateDto
    )
    {
        var fineCancellationRequest = updateDto.ToModel(uniqueId);

        _context.Entry(fineCancellationRequest).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!_context.FineCancellationRequests.Any(e => e.Id == fineCancellationRequest.Id))
                throw new NotFoundException();
            throw;
        }
    }
}
