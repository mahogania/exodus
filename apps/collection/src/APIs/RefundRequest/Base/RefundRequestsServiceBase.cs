using Collection.APIs;
using Collection.APIs.Common;
using Collection.APIs.Dtos;
using Collection.APIs.Errors;
using Collection.APIs.Extensions;
using Collection.Infrastructure;
using Collection.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Collection.APIs;

public abstract class RefundRequestsServiceBase : IRefundRequestsService
{
    protected readonly CollectionDbContext _context;

    public RefundRequestsServiceBase(CollectionDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one REFUND REQUEST
    /// </summary>
    public async Task<RefundRequest> CreateRefundRequest(RefundRequestCreateInput createDto)
    {
        var refundRequest = new RefundRequestDbModel
        {
            AccountCode = createDto.AccountCode,
            ApprovalId = createDto.ApprovalId,
            AttachedFileId = createDto.AttachedFileId,
            CreatedAt = createDto.CreatedAt,
            DeletionFlag = createDto.DeletionFlag,
            FinalModificationDateAndTime = createDto.FinalModificationDateAndTime,
            FinalModifierId = createDto.FinalModifierId,
            FinancialOfficerSName = createDto.FinancialOfficerSName,
            FirstRegistrantId = createDto.FirstRegistrantId,
            FirstRegistrationDateAndTime = createDto.FirstRegistrationDateAndTime,
            NiuCategoryCode = createDto.NiuCategoryCode,
            OfficeCode = createDto.OfficeCode,
            PersonRequestingId = createDto.PersonRequestingId,
            ProcessingStatusCode = createDto.ProcessingStatusCode,
            ReceiptNumber = createDto.ReceiptNumber,
            ReferenceNumber = createDto.ReferenceNumber,
            ReferenceNumberTypeCode = createDto.ReferenceNumberTypeCode,
            RefundRequestNumber = createDto.RefundRequestNumber,
            RefundRequestedOn = createDto.RefundRequestedOn,
            RequestDate = createDto.RequestDate,
            ServiceCode = createDto.ServiceCode,
            TaxpayerIdentificationNumber = createDto.TaxpayerIdentificationNumber,
            UpdatedAt = createDto.UpdatedAt
        };

        if (createDto.Id != null)
        {
            refundRequest.Id = createDto.Id;
        }

        _context.RefundRequests.Add(refundRequest);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<RefundRequestDbModel>(refundRequest.Id);

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one REFUND REQUEST
    /// </summary>
    public async Task DeleteRefundRequest(RefundRequestWhereUniqueInput uniqueId)
    {
        var refundRequest = await _context.RefundRequests.FindAsync(uniqueId.Id);
        if (refundRequest == null)
        {
            throw new NotFoundException();
        }

        _context.RefundRequests.Remove(refundRequest);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many REFUND REQUESTS
    /// </summary>
    public async Task<List<RefundRequest>> RefundRequests(RefundRequestFindManyArgs findManyArgs)
    {
        var refundRequests = await _context
            .RefundRequests.ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return refundRequests.ConvertAll(refundRequest => refundRequest.ToDto());
    }

    /// <summary>
    /// Meta data about REFUND REQUEST records
    /// </summary>
    public async Task<MetadataDto> RefundRequestsMeta(RefundRequestFindManyArgs findManyArgs)
    {
        var count = await _context.RefundRequests.ApplyWhere(findManyArgs.Where).CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one REFUND REQUEST
    /// </summary>
    public async Task<RefundRequest> RefundRequest(RefundRequestWhereUniqueInput uniqueId)
    {
        var refundRequests = await this.RefundRequests(
            new RefundRequestFindManyArgs
            {
                Where = new RefundRequestWhereInput { Id = uniqueId.Id }
            }
        );
        var refundRequest = refundRequests.FirstOrDefault();
        if (refundRequest == null)
        {
            throw new NotFoundException();
        }

        return refundRequest;
    }

    /// <summary>
    /// Update one REFUND REQUEST
    /// </summary>
    public async Task UpdateRefundRequest(
        RefundRequestWhereUniqueInput uniqueId,
        RefundRequestUpdateInput updateDto
    )
    {
        var refundRequest = updateDto.ToModel(uniqueId);

        _context.Entry(refundRequest).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!_context.RefundRequests.Any(e => e.Id == refundRequest.Id))
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
