using Control.APIs;
using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Control.APIs.Extensions;
using Control.Infrastructure;
using Control.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Control.APIs;

public abstract class TransitCarnetRequestsServiceBase : ITransitCarnetRequestsService
{
    protected readonly ControlDbContext _context;

    public TransitCarnetRequestsServiceBase(ControlDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one Transit Carnet Request
    /// </summary>
    public async Task<TransitCarnetRequest> CreateTransitCarnetRequest(
        TransitCarnetRequestCreateInput createDto
    )
    {
        var transitCarnetRequest = new TransitCarnetRequestDbModel
        {
            CarnetTypeCode = createDto.CarnetTypeCode,
            CreatedAt = createDto.CreatedAt,
            ManagementNumberOfCarnet = createDto.ManagementNumberOfCarnet,
            ReferenceNo = createDto.ReferenceNo,
            UpdatedAt = createDto.UpdatedAt
        };

        if (createDto.Id != null)
        {
            transitCarnetRequest.Id = createDto.Id;
        }
        if (createDto.TransitCarnetControl != null)
        {
            transitCarnetRequest.TransitCarnetControl = await _context
                .TransitCarnetControls.Where(transitCarnetControl =>
                    createDto.TransitCarnetControl.Id == transitCarnetControl.Id
                )
                .FirstOrDefaultAsync();
        }

        _context.TransitCarnetRequests.Add(transitCarnetRequest);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<TransitCarnetRequestDbModel>(transitCarnetRequest.Id);

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one Transit Carnet Request
    /// </summary>
    public async Task DeleteTransitCarnetRequest(TransitCarnetRequestWhereUniqueInput uniqueId)
    {
        var transitCarnetRequest = await _context.TransitCarnetRequests.FindAsync(uniqueId.Id);
        if (transitCarnetRequest == null)
        {
            throw new NotFoundException();
        }

        _context.TransitCarnetRequests.Remove(transitCarnetRequest);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many Transit Carnet Requests
    /// </summary>
    public async Task<List<TransitCarnetRequest>> TransitCarnetRequests(
        TransitCarnetRequestFindManyArgs findManyArgs
    )
    {
        var transitCarnetRequests = await _context
            .TransitCarnetRequests.Include(x => x.TransitCarnetControl)
            .ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return transitCarnetRequests.ConvertAll(transitCarnetRequest =>
            transitCarnetRequest.ToDto()
        );
    }

    /// <summary>
    /// Meta data about Transit Carnet Request records
    /// </summary>
    public async Task<MetadataDto> TransitCarnetRequestsMeta(
        TransitCarnetRequestFindManyArgs findManyArgs
    )
    {
        var count = await _context
            .TransitCarnetRequests.ApplyWhere(findManyArgs.Where)
            .CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one Transit Carnet Request
    /// </summary>
    public async Task<TransitCarnetRequest> TransitCarnetRequest(
        TransitCarnetRequestWhereUniqueInput uniqueId
    )
    {
        var transitCarnetRequests = await this.TransitCarnetRequests(
            new TransitCarnetRequestFindManyArgs
            {
                Where = new TransitCarnetRequestWhereInput { Id = uniqueId.Id }
            }
        );
        var transitCarnetRequest = transitCarnetRequests.FirstOrDefault();
        if (transitCarnetRequest == null)
        {
            throw new NotFoundException();
        }

        return transitCarnetRequest;
    }

    /// <summary>
    /// Update one Transit Carnet Request
    /// </summary>
    public async Task UpdateTransitCarnetRequest(
        TransitCarnetRequestWhereUniqueInput uniqueId,
        TransitCarnetRequestUpdateInput updateDto
    )
    {
        var transitCarnetRequest = updateDto.ToModel(uniqueId);

        _context.Entry(transitCarnetRequest).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!_context.TransitCarnetRequests.Any(e => e.Id == transitCarnetRequest.Id))
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
    /// Get a Transit Carnet Control record for Transit Carnet Request
    /// </summary>
    public async Task<TransitCarnetControl> GetTransitCarnetControl(
        TransitCarnetRequestWhereUniqueInput uniqueId
    )
    {
        var transitCarnetRequest = await _context
            .TransitCarnetRequests.Where(transitCarnetRequest =>
                transitCarnetRequest.Id == uniqueId.Id
            )
            .Include(transitCarnetRequest => transitCarnetRequest.TransitCarnetControl)
            .FirstOrDefaultAsync();
        if (transitCarnetRequest == null)
        {
            throw new NotFoundException();
        }
        return transitCarnetRequest.TransitCarnetControl.ToDto();
    }
}
