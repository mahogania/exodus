using Control.APIs;
using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Control.APIs.Extensions;
using Control.Infrastructure;
using Control.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Control.APIs;

public abstract class CarnetRequestsServiceBase : ICarnetRequestsService
{
    protected readonly ControlDbContext _context;

    public CarnetRequestsServiceBase(ControlDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one Carnet Request
    /// </summary>
    public async Task<CarnetRequest> CreateCarnetRequest(CarnetRequestCreateInput createDto)
    {
        var carnetRequest = new CarnetRequestDbModel
        {
            CarnetTypeCode = createDto.CarnetTypeCode,
            CreatedAt = createDto.CreatedAt,
            ManagementNumberOfCarnet = createDto.ManagementNumberOfCarnet,
            UpdatedAt = createDto.UpdatedAt
        };

        if (createDto.Id != null)
        {
            carnetRequest.Id = createDto.Id;
        }

        _context.CarnetRequests.Add(carnetRequest);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<CarnetRequestDbModel>(carnetRequest.Id);

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one Carnet Request
    /// </summary>
    public async Task DeleteCarnetRequest(CarnetRequestWhereUniqueInput uniqueId)
    {
        var carnetRequest = await _context.CarnetRequests.FindAsync(uniqueId.Id);
        if (carnetRequest == null)
        {
            throw new NotFoundException();
        }

        _context.CarnetRequests.Remove(carnetRequest);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many Carnet Requests
    /// </summary>
    public async Task<List<CarnetRequest>> CarnetRequests(CarnetRequestFindManyArgs findManyArgs)
    {
        var carnetRequests = await _context
            .CarnetRequests.ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return carnetRequests.ConvertAll(carnetRequest => carnetRequest.ToDto());
    }

    /// <summary>
    /// Meta data about Carnet Request records
    /// </summary>
    public async Task<MetadataDto> CarnetRequestsMeta(CarnetRequestFindManyArgs findManyArgs)
    {
        var count = await _context.CarnetRequests.ApplyWhere(findManyArgs.Where).CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one Carnet Request
    /// </summary>
    public async Task<CarnetRequest> CarnetRequest(CarnetRequestWhereUniqueInput uniqueId)
    {
        var carnetRequests = await this.CarnetRequests(
            new CarnetRequestFindManyArgs
            {
                Where = new CarnetRequestWhereInput { Id = uniqueId.Id }
            }
        );
        var carnetRequest = carnetRequests.FirstOrDefault();
        if (carnetRequest == null)
        {
            throw new NotFoundException();
        }

        return carnetRequest;
    }

    /// <summary>
    /// Update one Carnet Request
    /// </summary>
    public async Task UpdateCarnetRequest(
        CarnetRequestWhereUniqueInput uniqueId,
        CarnetRequestUpdateInput updateDto
    )
    {
        var carnetRequest = updateDto.ToModel(uniqueId);

        _context.Entry(carnetRequest).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!_context.CarnetRequests.Any(e => e.Id == carnetRequest.Id))
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
