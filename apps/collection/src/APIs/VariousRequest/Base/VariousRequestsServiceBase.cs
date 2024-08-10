using Collection.APIs.Common;
using Collection.APIs.Dtos;
using Collection.APIs.Errors;
using Collection.APIs.Extensions;
using Collection.Infrastructure;
using Collection.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Collection.APIs;

public abstract class VariousRequestsServiceBase : IVariousRequestsService
{
    protected readonly CollectionDbContext _context;

    public VariousRequestsServiceBase(CollectionDbContext context)
    {
        _context = context;
    }

    /// <summary>
    ///     Create one VARIOUS REQUEST
    /// </summary>
    public async Task<VariousRequest> CreateVariousRequest(VariousRequestCreateInput createDto)
    {
        var variousRequest = new VariousRequestDbModel
        {
            AttachmentFileId = createDto.AttachmentFileId,
            CodeJustificationDescription = createDto.CodeJustificationDescription,
            CreatedAt = createDto.CreatedAt,
            DeclarantCode = createDto.DeclarantCode,
            DeclarantName = createDto.DeclarantName,
            DeletionOn = createDto.DeletionOn,
            FinalModificationDateAndTime = createDto.FinalModificationDateAndTime,
            FinalModifierId = createDto.FinalModifierId,
            FirstRegistrantId = createDto.FirstRegistrantId,
            FirstRegistrationDateAndTime = createDto.FirstRegistrationDateAndTime,
            OfficeCode = createDto.OfficeCode,
            ProcessingDate = createDto.ProcessingDate,
            ProcessingResult = createDto.ProcessingResult,
            ProcessingStatusCode = createDto.ProcessingStatusCode,
            ReceiverId = createDto.ReceiverId,
            ReferenceNo = createDto.ReferenceNo,
            ReferenceNumberTypeCode = createDto.ReferenceNumberTypeCode,
            RequestDate = createDto.RequestDate,
            RequestNo = createDto.RequestNo,
            RequestTypeCode = createDto.RequestTypeCode,
            ServiceCode = createDto.ServiceCode,
            UpdatedAt = createDto.UpdatedAt
        };

        if (createDto.Id != null) variousRequest.Id = createDto.Id;

        _context.VariousRequests.Add(variousRequest);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<VariousRequestDbModel>(variousRequest.Id);

        if (result == null) throw new NotFoundException();

        return result.ToDto();
    }

    /// <summary>
    ///     Delete one VARIOUS REQUEST
    /// </summary>
    public async Task DeleteVariousRequest(VariousRequestWhereUniqueInput uniqueId)
    {
        var variousRequest = await _context.VariousRequests.FindAsync(uniqueId.Id);
        if (variousRequest == null) throw new NotFoundException();

        _context.VariousRequests.Remove(variousRequest);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    ///     Find many VARIOUS REQUESTS
    /// </summary>
    public async Task<List<VariousRequest>> VariousRequests(VariousRequestFindManyArgs findManyArgs)
    {
        var variousRequests = await _context
            .VariousRequests.ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return variousRequests.ConvertAll(variousRequest => variousRequest.ToDto());
    }

    /// <summary>
    ///     Meta data about VARIOUS REQUEST records
    /// </summary>
    public async Task<MetadataDto> VariousRequestsMeta(VariousRequestFindManyArgs findManyArgs)
    {
        var count = await _context.VariousRequests.ApplyWhere(findManyArgs.Where).CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    ///     Get one VARIOUS REQUEST
    /// </summary>
    public async Task<VariousRequest> VariousRequest(VariousRequestWhereUniqueInput uniqueId)
    {
        var variousRequests = await VariousRequests(
            new VariousRequestFindManyArgs
            {
                Where = new VariousRequestWhereInput { Id = uniqueId.Id }
            }
        );
        var variousRequest = variousRequests.FirstOrDefault();
        if (variousRequest == null) throw new NotFoundException();

        return variousRequest;
    }

    /// <summary>
    ///     Update one VARIOUS REQUEST
    /// </summary>
    public async Task UpdateVariousRequest(
        VariousRequestWhereUniqueInput uniqueId,
        VariousRequestUpdateInput updateDto
    )
    {
        var variousRequest = updateDto.ToModel(uniqueId);

        _context.Entry(variousRequest).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!_context.VariousRequests.Any(e => e.Id == variousRequest.Id))
                throw new NotFoundException();
            throw;
        }
    }
}
