using Control.APIs;
using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Control.APIs.Extensions;
using Control.Infrastructure;
using Control.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Control.APIs;

public abstract class ExtendedPeriodCarnetRequestsServiceBase : IExtendedPeriodCarnetRequestsService
{
    protected readonly ControlDbContext _context;

    public ExtendedPeriodCarnetRequestsServiceBase(ControlDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one Extended Period Carnet Request
    /// </summary>
    public async Task<ExtendedPeriodCarnetRequest> CreateExtendedPeriodCarnetRequest(
        ExtendedPeriodCarnetRequestCreateInput createDto
    )
    {
        var extendedPeriodCarnetRequest = new ExtendedPeriodCarnetRequestDbModel
        {
            CarnetNumber = createDto.CarnetNumber,
            CarnetTypeCode = createDto.CarnetTypeCode,
            CreatedAt = createDto.CreatedAt,
            ManagementNumberOfCarnet = createDto.ManagementNumberOfCarnet,
            SequenceNumber = createDto.SequenceNumber,
            UpdatedAt = createDto.UpdatedAt
        };

        if (createDto.Id != null)
        {
            extendedPeriodCarnetRequest.Id = createDto.Id;
        }

        _context.ExtendedPeriodCarnetRequests.Add(extendedPeriodCarnetRequest);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<ExtendedPeriodCarnetRequestDbModel>(
            extendedPeriodCarnetRequest.Id
        );

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one Extended Period Carnet Request
    /// </summary>
    public async Task DeleteExtendedPeriodCarnetRequest(
        ExtendedPeriodCarnetRequestWhereUniqueInput uniqueId
    )
    {
        var extendedPeriodCarnetRequest = await _context.ExtendedPeriodCarnetRequests.FindAsync(
            uniqueId.Id
        );
        if (extendedPeriodCarnetRequest == null)
        {
            throw new NotFoundException();
        }

        _context.ExtendedPeriodCarnetRequests.Remove(extendedPeriodCarnetRequest);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many Extended Period Carnet Requests
    /// </summary>
    public async Task<List<ExtendedPeriodCarnetRequest>> ExtendedPeriodCarnetRequests(
        ExtendedPeriodCarnetRequestFindManyArgs findManyArgs
    )
    {
        var extendedPeriodCarnetRequests = await _context
            .ExtendedPeriodCarnetRequests.ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return extendedPeriodCarnetRequests.ConvertAll(extendedPeriodCarnetRequest =>
            extendedPeriodCarnetRequest.ToDto()
        );
    }

    /// <summary>
    /// Meta data about Extended Period Carnet Request records
    /// </summary>
    public async Task<MetadataDto> ExtendedPeriodCarnetRequestsMeta(
        ExtendedPeriodCarnetRequestFindManyArgs findManyArgs
    )
    {
        var count = await _context
            .ExtendedPeriodCarnetRequests.ApplyWhere(findManyArgs.Where)
            .CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one Extended Period Carnet Request
    /// </summary>
    public async Task<ExtendedPeriodCarnetRequest> ExtendedPeriodCarnetRequest(
        ExtendedPeriodCarnetRequestWhereUniqueInput uniqueId
    )
    {
        var extendedPeriodCarnetRequests = await this.ExtendedPeriodCarnetRequests(
            new ExtendedPeriodCarnetRequestFindManyArgs
            {
                Where = new ExtendedPeriodCarnetRequestWhereInput { Id = uniqueId.Id }
            }
        );
        var extendedPeriodCarnetRequest = extendedPeriodCarnetRequests.FirstOrDefault();
        if (extendedPeriodCarnetRequest == null)
        {
            throw new NotFoundException();
        }

        return extendedPeriodCarnetRequest;
    }

    /// <summary>
    /// Update one Extended Period Carnet Request
    /// </summary>
    public async Task UpdateExtendedPeriodCarnetRequest(
        ExtendedPeriodCarnetRequestWhereUniqueInput uniqueId,
        ExtendedPeriodCarnetRequestUpdateInput updateDto
    )
    {
        var extendedPeriodCarnetRequest = updateDto.ToModel(uniqueId);

        _context.Entry(extendedPeriodCarnetRequest).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (
                !_context.ExtendedPeriodCarnetRequests.Any(e =>
                    e.Id == extendedPeriodCarnetRequest.Id
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
