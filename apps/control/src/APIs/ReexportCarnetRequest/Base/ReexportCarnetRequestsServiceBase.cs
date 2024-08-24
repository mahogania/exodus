using Control.APIs;
using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Control.APIs.Extensions;
using Control.Infrastructure;
using Control.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Control.APIs;

public abstract class ReexportCarnetRequestsServiceBase : IReexportCarnetRequestsService
{
    protected readonly ControlDbContext _context;

    public ReexportCarnetRequestsServiceBase(ControlDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one Reexport Carnet Request
    /// </summary>
    public async Task<ReexportCarnetRequest> CreateReexportCarnetRequest(
        ReexportCarnetRequestCreateInput createDto
    )
    {
        var reexportCarnetRequest = new ReexportCarnetRequestDbModel
        {
            CarnetNumber = createDto.CarnetNumber,
            CarnetTypeCode = createDto.CarnetTypeCode,
            CreatedAt = createDto.CreatedAt,
            ManagementNumberOfCarnet = createDto.ManagementNumberOfCarnet,
            ReferenceNo = createDto.ReferenceNo,
            UpdatedAt = createDto.UpdatedAt
        };

        if (createDto.Id != null)
        {
            reexportCarnetRequest.Id = createDto.Id;
        }
        if (createDto.ReexportCarnetControl != null)
        {
            reexportCarnetRequest.ReexportCarnetControl = await _context
                .ReexportCarnetControls.Where(reexportCarnetControl =>
                    createDto.ReexportCarnetControl.Id == reexportCarnetControl.Id
                )
                .FirstOrDefaultAsync();
        }

        _context.ReexportCarnetRequests.Add(reexportCarnetRequest);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<ReexportCarnetRequestDbModel>(
            reexportCarnetRequest.Id
        );

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one Reexport Carnet Request
    /// </summary>
    public async Task DeleteReexportCarnetRequest(ReexportCarnetRequestWhereUniqueInput uniqueId)
    {
        var reexportCarnetRequest = await _context.ReexportCarnetRequests.FindAsync(uniqueId.Id);
        if (reexportCarnetRequest == null)
        {
            throw new NotFoundException();
        }

        _context.ReexportCarnetRequests.Remove(reexportCarnetRequest);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many Reexport Carnet Requests
    /// </summary>
    public async Task<List<ReexportCarnetRequest>> ReexportCarnetRequests(
        ReexportCarnetRequestFindManyArgs findManyArgs
    )
    {
        var reexportCarnetRequests = await _context
            .ReexportCarnetRequests.Include(x => x.ReexportCarnetControl)
            .ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return reexportCarnetRequests.ConvertAll(reexportCarnetRequest =>
            reexportCarnetRequest.ToDto()
        );
    }

    /// <summary>
    /// Meta data about Reexport Carnet Request records
    /// </summary>
    public async Task<MetadataDto> ReexportCarnetRequestsMeta(
        ReexportCarnetRequestFindManyArgs findManyArgs
    )
    {
        var count = await _context
            .ReexportCarnetRequests.ApplyWhere(findManyArgs.Where)
            .CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one Reexport Carnet Request
    /// </summary>
    public async Task<ReexportCarnetRequest> ReexportCarnetRequest(
        ReexportCarnetRequestWhereUniqueInput uniqueId
    )
    {
        var reexportCarnetRequests = await this.ReexportCarnetRequests(
            new ReexportCarnetRequestFindManyArgs
            {
                Where = new ReexportCarnetRequestWhereInput { Id = uniqueId.Id }
            }
        );
        var reexportCarnetRequest = reexportCarnetRequests.FirstOrDefault();
        if (reexportCarnetRequest == null)
        {
            throw new NotFoundException();
        }

        return reexportCarnetRequest;
    }

    /// <summary>
    /// Update one Reexport Carnet Request
    /// </summary>
    public async Task UpdateReexportCarnetRequest(
        ReexportCarnetRequestWhereUniqueInput uniqueId,
        ReexportCarnetRequestUpdateInput updateDto
    )
    {
        var reexportCarnetRequest = updateDto.ToModel(uniqueId);

        _context.Entry(reexportCarnetRequest).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!_context.ReexportCarnetRequests.Any(e => e.Id == reexportCarnetRequest.Id))
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
    /// Get a Reexport Carnet Control record for Reexport Carnet Request
    /// </summary>
    public async Task<ReexportCarnetControl> GetReexportCarnetControl(
        ReexportCarnetRequestWhereUniqueInput uniqueId
    )
    {
        var reexportCarnetRequest = await _context
            .ReexportCarnetRequests.Where(reexportCarnetRequest =>
                reexportCarnetRequest.Id == uniqueId.Id
            )
            .Include(reexportCarnetRequest => reexportCarnetRequest.ReexportCarnetControl)
            .FirstOrDefaultAsync();
        if (reexportCarnetRequest == null)
        {
            throw new NotFoundException();
        }
        return reexportCarnetRequest.ReexportCarnetControl.ToDto();
    }
}
