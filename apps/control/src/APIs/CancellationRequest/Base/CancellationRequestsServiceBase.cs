using Control.APIs;
using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Control.APIs.Extensions;
using Control.Infrastructure;
using Control.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Control.APIs;

public abstract class CancellationRequestsServiceBase : ICancellationRequestsService
{
    protected readonly ControlDbContext _context;

    public CancellationRequestsServiceBase(ControlDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one Cancellation Request
    /// </summary>
    public async Task<CancellationRequest> CreateCancellationRequest(
        CancellationRequestCreateInput createDto
    )
    {
        var cancellationRequest = new CancellationRequestDbModel
        {
            CancellationContent = createDto.CancellationContent,
            CancellationReasonCode = createDto.CancellationReasonCode,
            CreatedAt = createDto.CreatedAt,
            DateAndTimeOfFinalModification = createDto.DateAndTimeOfFinalModification,
            DateAndTimeOfFirstRegistration = createDto.DateAndTimeOfFirstRegistration,
            DateOfRequestForCancellation = createDto.DateOfRequestForCancellation,
            FinalOn = createDto.FinalOn,
            FirstRegistrantSId = createDto.FirstRegistrantSId,
            IdOfTheAttachedFile = createDto.IdOfTheAttachedFile,
            NumberOfCancellations = createDto.NumberOfCancellations,
            ProcessingStatusCode = createDto.ProcessingStatusCode,
            ReferenceNumber = createDto.ReferenceNumber,
            SuppressionOn = createDto.SuppressionOn,
            UpdatedAt = createDto.UpdatedAt
        };

        if (createDto.Id != null)
        {
            cancellationRequest.Id = createDto.Id;
        }
        if (createDto.Request != null)
        {
            cancellationRequest.Request = await _context
                .Journals.Where(journal => createDto.Request.Id == journal.Id)
                .FirstOrDefaultAsync();
        }

        _context.CancellationRequests.Add(cancellationRequest);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<CancellationRequestDbModel>(cancellationRequest.Id);

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one Cancellation Request
    /// </summary>
    public async Task DeleteCancellationRequest(CancellationRequestWhereUniqueInput uniqueId)
    {
        var cancellationRequest = await _context.CancellationRequests.FindAsync(uniqueId.Id);
        if (cancellationRequest == null)
        {
            throw new NotFoundException();
        }

        _context.CancellationRequests.Remove(cancellationRequest);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many Cancellation Requests
    /// </summary>
    public async Task<List<CancellationRequest>> CancellationRequests(
        CancellationRequestFindManyArgs findManyArgs
    )
    {
        var cancellationRequests = await _context
            .CancellationRequests.Include(x => x.Request)
            .ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return cancellationRequests.ConvertAll(cancellationRequest => cancellationRequest.ToDto());
    }

    /// <summary>
    /// Meta data about Cancellation Request records
    /// </summary>
    public async Task<MetadataDto> CancellationRequestsMeta(
        CancellationRequestFindManyArgs findManyArgs
    )
    {
        var count = await _context.CancellationRequests.ApplyWhere(findManyArgs.Where).CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one Cancellation Request
    /// </summary>
    public async Task<CancellationRequest> CancellationRequest(
        CancellationRequestWhereUniqueInput uniqueId
    )
    {
        var cancellationRequests = await this.CancellationRequests(
            new CancellationRequestFindManyArgs
            {
                Where = new CancellationRequestWhereInput { Id = uniqueId.Id }
            }
        );
        var cancellationRequest = cancellationRequests.FirstOrDefault();
        if (cancellationRequest == null)
        {
            throw new NotFoundException();
        }

        return cancellationRequest;
    }

    /// <summary>
    /// Update one Cancellation Request
    /// </summary>
    public async Task UpdateCancellationRequest(
        CancellationRequestWhereUniqueInput uniqueId,
        CancellationRequestUpdateInput updateDto
    )
    {
        var cancellationRequest = updateDto.ToModel(uniqueId);

        _context.Entry(cancellationRequest).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!_context.CancellationRequests.Any(e => e.Id == cancellationRequest.Id))
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
    /// Get a Request record for Cancellation Request
    /// </summary>
    public async Task<Journal> GetRequest(CancellationRequestWhereUniqueInput uniqueId)
    {
        var cancellationRequest = await _context
            .CancellationRequests.Where(cancellationRequest =>
                cancellationRequest.Id == uniqueId.Id
            )
            .Include(cancellationRequest => cancellationRequest.Request)
            .FirstOrDefaultAsync();
        if (cancellationRequest == null)
        {
            throw new NotFoundException();
        }
        return cancellationRequest.Request.ToDto();
    }
}
