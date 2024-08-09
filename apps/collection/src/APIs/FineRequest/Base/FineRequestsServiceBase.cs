using Collection.APIs;
using Collection.APIs.Common;
using Collection.APIs.Dtos;
using Collection.APIs.Errors;
using Collection.APIs.Extensions;
using Collection.Infrastructure;
using Collection.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Collection.APIs;

public abstract class FineRequestsServiceBase : IFineRequestsService
{
    protected readonly CollectionDbContext _context;

    public FineRequestsServiceBase(CollectionDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one FINE REQUEST
    /// </summary>
    public async Task<FineRequest> CreateFineRequest(FineRequestCreateInput createDto)
    {
        var fineRequest = new FineRequestDbModel
        {
            AlignmentOrder = createDto.AlignmentOrder,
            CreatedAt = createDto.CreatedAt,
            DeletionOn = createDto.DeletionOn,
            FinalModificationDateAndTime = createDto.FinalModificationDateAndTime,
            FinalModifierId = createDto.FinalModifierId,
            FineAmount = createDto.FineAmount,
            FineImpositionRequestNumber = createDto.FineImpositionRequestNumber,
            FineRelatedTaxCode = createDto.FineRelatedTaxCode,
            FirstRegistrantId = createDto.FirstRegistrantId,
            FirstRegistrationDateAndTime = createDto.FirstRegistrationDateAndTime,
            InfractionCode = createDto.InfractionCode,
            MaximumAmount = createDto.MaximumAmount,
            MinimumAmount = createDto.MinimumAmount,
            OperationTypeCode = createDto.OperationTypeCode,
            UpdatedAt = createDto.UpdatedAt
        };

        if (createDto.Id != null)
        {
            fineRequest.Id = createDto.Id;
        }

        _context.FineRequests.Add(fineRequest);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<FineRequestDbModel>(fineRequest.Id);

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one FINE REQUEST
    /// </summary>
    public async Task DeleteFineRequest(FineRequestWhereUniqueInput uniqueId)
    {
        var fineRequest = await _context.FineRequests.FindAsync(uniqueId.Id);
        if (fineRequest == null)
        {
            throw new NotFoundException();
        }

        _context.FineRequests.Remove(fineRequest);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many FINE REQUESTS
    /// </summary>
    public async Task<List<FineRequest>> FineRequests(FineRequestFindManyArgs findManyArgs)
    {
        var fineRequests = await _context
            .FineRequests.ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return fineRequests.ConvertAll(fineRequest => fineRequest.ToDto());
    }

    /// <summary>
    /// Meta data about FINE REQUEST records
    /// </summary>
    public async Task<MetadataDto> FineRequestsMeta(FineRequestFindManyArgs findManyArgs)
    {
        var count = await _context.FineRequests.ApplyWhere(findManyArgs.Where).CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one FINE REQUEST
    /// </summary>
    public async Task<FineRequest> FineRequest(FineRequestWhereUniqueInput uniqueId)
    {
        var fineRequests = await this.FineRequests(
            new FineRequestFindManyArgs { Where = new FineRequestWhereInput { Id = uniqueId.Id } }
        );
        var fineRequest = fineRequests.FirstOrDefault();
        if (fineRequest == null)
        {
            throw new NotFoundException();
        }

        return fineRequest;
    }

    /// <summary>
    /// Update one FINE REQUEST
    /// </summary>
    public async Task UpdateFineRequest(
        FineRequestWhereUniqueInput uniqueId,
        FineRequestUpdateInput updateDto
    )
    {
        var fineRequest = updateDto.ToModel(uniqueId);

        _context.Entry(fineRequest).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!_context.FineRequests.Any(e => e.Id == fineRequest.Id))
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
