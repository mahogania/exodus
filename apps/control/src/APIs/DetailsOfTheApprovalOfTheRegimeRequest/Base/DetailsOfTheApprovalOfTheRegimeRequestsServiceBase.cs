using Clre.APIs;
using Clre.APIs.Common;
using Clre.APIs.Dtos;
using Clre.APIs.Errors;
using Clre.APIs.Extensions;
using Clre.Infrastructure;
using Clre.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Clre.APIs;

public abstract class DetailsOfTheApprovalOfTheRegimeRequestsServiceBase
    : IDetailsOfTheApprovalOfTheRegimeRequestsService
{
    protected readonly ClreDbContext _context;

    public DetailsOfTheApprovalOfTheRegimeRequestsServiceBase(ClreDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one DETAIL OF THE APPROVAL OF THE REGIME REQUEST
    /// </summary>
    public async Task<DetailsOfTheApprovalOfTheRegimeRequest> CreateDetailsOfTheApprovalOfTheRegimeRequest(
        DetailsOfTheApprovalOfTheRegimeRequestCreateInput createDto
    )
    {
        var detailsOfTheApprovalOfTheRegimeRequest =
            new DetailsOfTheApprovalOfTheRegimeRequestDbModel
            {
                BrandName = createDto.BrandName,
                ChassisNumber = createDto.ChassisNumber,
                CreatedAt = createDto.CreatedAt,
                CurrencyCode = createDto.CurrencyCode,
                DateAndTimeOfFinalModification = createDto.DateAndTimeOfFinalModification,
                DateAndTimeOfFirstRegistration = createDto.DateAndTimeOfFirstRegistration,
                FinalModifierSId = createDto.FinalModifierSId,
                FirstRegistrantSId = createDto.FirstRegistrantSId,
                Price = createDto.Price,
                RectificationFrequency = createDto.RectificationFrequency,
                RegimeRequestNumber = createDto.RegimeRequestNumber,
                RegistrationNumber = createDto.RegistrationNumber,
                SequenceNumber = createDto.SequenceNumber,
                SuppressionOn = createDto.SuppressionOn,
                UpdatedAt = createDto.UpdatedAt,
                VehicleModelName = createDto.VehicleModelName,
                VehiclePower = createDto.VehiclePower
            };

        if (createDto.Id != null)
        {
            detailsOfTheApprovalOfTheRegimeRequest.Id = createDto.Id;
        }

        _context.DetailsOfTheApprovalOfTheRegimeRequests.Add(
            detailsOfTheApprovalOfTheRegimeRequest
        );
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<DetailsOfTheApprovalOfTheRegimeRequestDbModel>(
            detailsOfTheApprovalOfTheRegimeRequest.Id
        );

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one DETAIL OF THE APPROVAL OF THE REGIME REQUEST
    /// </summary>
    public async Task DeleteDetailsOfTheApprovalOfTheRegimeRequest(
        DetailsOfTheApprovalOfTheRegimeRequestWhereUniqueInput uniqueId
    )
    {
        var detailsOfTheApprovalOfTheRegimeRequest =
            await _context.DetailsOfTheApprovalOfTheRegimeRequests.FindAsync(uniqueId.Id);
        if (detailsOfTheApprovalOfTheRegimeRequest == null)
        {
            throw new NotFoundException();
        }

        _context.DetailsOfTheApprovalOfTheRegimeRequests.Remove(
            detailsOfTheApprovalOfTheRegimeRequest
        );
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many details of the approval of the regime requests
    /// </summary>
    public async Task<
        List<DetailsOfTheApprovalOfTheRegimeRequest>
    > DetailsOfTheApprovalOfTheRegimeRequests(
        DetailsOfTheApprovalOfTheRegimeRequestFindManyArgs findManyArgs
    )
    {
        var detailsOfTheApprovalOfTheRegimeRequests = await _context
            .DetailsOfTheApprovalOfTheRegimeRequests.ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return detailsOfTheApprovalOfTheRegimeRequests.ConvertAll(
            detailsOfTheApprovalOfTheRegimeRequest => detailsOfTheApprovalOfTheRegimeRequest.ToDto()
        );
    }

    /// <summary>
    /// Meta data about DETAIL OF THE APPROVAL OF THE REGIME REQUEST records
    /// </summary>
    public async Task<MetadataDto> DetailsOfTheApprovalOfTheRegimeRequestsMeta(
        DetailsOfTheApprovalOfTheRegimeRequestFindManyArgs findManyArgs
    )
    {
        var count = await _context
            .DetailsOfTheApprovalOfTheRegimeRequests.ApplyWhere(findManyArgs.Where)
            .CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one DETAIL OF THE APPROVAL OF THE REGIME REQUEST
    /// </summary>
    public async Task<DetailsOfTheApprovalOfTheRegimeRequest> DetailsOfTheApprovalOfTheRegimeRequest(
        DetailsOfTheApprovalOfTheRegimeRequestWhereUniqueInput uniqueId
    )
    {
        var detailsOfTheApprovalOfTheRegimeRequests =
            await this.DetailsOfTheApprovalOfTheRegimeRequests(
                new DetailsOfTheApprovalOfTheRegimeRequestFindManyArgs
                {
                    Where = new DetailsOfTheApprovalOfTheRegimeRequestWhereInput
                    {
                        Id = uniqueId.Id
                    }
                }
            );
        var detailsOfTheApprovalOfTheRegimeRequest =
            detailsOfTheApprovalOfTheRegimeRequests.FirstOrDefault();
        if (detailsOfTheApprovalOfTheRegimeRequest == null)
        {
            throw new NotFoundException();
        }

        return detailsOfTheApprovalOfTheRegimeRequest;
    }

    /// <summary>
    /// Update one DETAIL OF THE APPROVAL OF THE REGIME REQUEST
    /// </summary>
    public async Task UpdateDetailsOfTheApprovalOfTheRegimeRequest(
        DetailsOfTheApprovalOfTheRegimeRequestWhereUniqueInput uniqueId,
        DetailsOfTheApprovalOfTheRegimeRequestUpdateInput updateDto
    )
    {
        var detailsOfTheApprovalOfTheRegimeRequest = updateDto.ToModel(uniqueId);

        _context.Entry(detailsOfTheApprovalOfTheRegimeRequest).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (
                !_context.DetailsOfTheApprovalOfTheRegimeRequests.Any(e =>
                    e.Id == detailsOfTheApprovalOfTheRegimeRequest.Id
                )
            )
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
