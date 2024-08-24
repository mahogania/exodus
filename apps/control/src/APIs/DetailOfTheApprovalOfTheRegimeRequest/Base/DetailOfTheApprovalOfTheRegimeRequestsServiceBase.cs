using Control.APIs;
using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Control.APIs.Extensions;
using Control.Infrastructure;
using Control.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Control.APIs;

public abstract class DetailOfTheApprovalOfTheRegimeRequestsServiceBase
    : IDetailOfTheApprovalOfTheRegimeRequestsService
{
    protected readonly ControlDbContext _context;

    public DetailOfTheApprovalOfTheRegimeRequestsServiceBase(ControlDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one Detail of the approval of the Regime Request
    /// </summary>
    public async Task<DetailOfTheApprovalOfTheRegimeRequest> CreateDetailOfTheApprovalOfTheRegimeRequest(
        DetailOfTheApprovalOfTheRegimeRequestCreateInput createDto
    )
    {
        var detailOfTheApprovalOfTheRegimeRequest = new DetailOfTheApprovalOfTheRegimeRequestDbModel
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
            detailOfTheApprovalOfTheRegimeRequest.Id = createDto.Id;
        }

        _context.DetailOfTheApprovalOfTheRegimeRequests.Add(detailOfTheApprovalOfTheRegimeRequest);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<DetailOfTheApprovalOfTheRegimeRequestDbModel>(
            detailOfTheApprovalOfTheRegimeRequest.Id
        );

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one Detail of the approval of the Regime Request
    /// </summary>
    public async Task DeleteDetailOfTheApprovalOfTheRegimeRequest(
        DetailOfTheApprovalOfTheRegimeRequestWhereUniqueInput uniqueId
    )
    {
        var detailOfTheApprovalOfTheRegimeRequest =
            await _context.DetailOfTheApprovalOfTheRegimeRequests.FindAsync(uniqueId.Id);
        if (detailOfTheApprovalOfTheRegimeRequest == null)
        {
            throw new NotFoundException();
        }

        _context.DetailOfTheApprovalOfTheRegimeRequests.Remove(
            detailOfTheApprovalOfTheRegimeRequest
        );
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many Details of the approval of the Regime Request
    /// </summary>
    public async Task<
        List<DetailOfTheApprovalOfTheRegimeRequest>
    > DetailOfTheApprovalOfTheRegimeRequests(
        DetailOfTheApprovalOfTheRegimeRequestFindManyArgs findManyArgs
    )
    {
        var detailOfTheApprovalOfTheRegimeRequests = await _context
            .DetailOfTheApprovalOfTheRegimeRequests.ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return detailOfTheApprovalOfTheRegimeRequests.ConvertAll(
            detailOfTheApprovalOfTheRegimeRequest => detailOfTheApprovalOfTheRegimeRequest.ToDto()
        );
    }

    /// <summary>
    /// Meta data about Detail of the approval of the Regime Request records
    /// </summary>
    public async Task<MetadataDto> DetailOfTheApprovalOfTheRegimeRequestsMeta(
        DetailOfTheApprovalOfTheRegimeRequestFindManyArgs findManyArgs
    )
    {
        var count = await _context
            .DetailOfTheApprovalOfTheRegimeRequests.ApplyWhere(findManyArgs.Where)
            .CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one Detail of the approval of the Regime Request
    /// </summary>
    public async Task<DetailOfTheApprovalOfTheRegimeRequest> DetailOfTheApprovalOfTheRegimeRequest(
        DetailOfTheApprovalOfTheRegimeRequestWhereUniqueInput uniqueId
    )
    {
        var detailOfTheApprovalOfTheRegimeRequests =
            await this.DetailOfTheApprovalOfTheRegimeRequests(
                new DetailOfTheApprovalOfTheRegimeRequestFindManyArgs
                {
                    Where = new DetailOfTheApprovalOfTheRegimeRequestWhereInput { Id = uniqueId.Id }
                }
            );
        var detailOfTheApprovalOfTheRegimeRequest =
            detailOfTheApprovalOfTheRegimeRequests.FirstOrDefault();
        if (detailOfTheApprovalOfTheRegimeRequest == null)
        {
            throw new NotFoundException();
        }

        return detailOfTheApprovalOfTheRegimeRequest;
    }

    /// <summary>
    /// Update one Detail of the approval of the Regime Request
    /// </summary>
    public async Task UpdateDetailOfTheApprovalOfTheRegimeRequest(
        DetailOfTheApprovalOfTheRegimeRequestWhereUniqueInput uniqueId,
        DetailOfTheApprovalOfTheRegimeRequestUpdateInput updateDto
    )
    {
        var detailOfTheApprovalOfTheRegimeRequest = updateDto.ToModel(uniqueId);

        _context.Entry(detailOfTheApprovalOfTheRegimeRequest).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (
                !_context.DetailOfTheApprovalOfTheRegimeRequests.Any(e =>
                    e.Id == detailOfTheApprovalOfTheRegimeRequest.Id
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
