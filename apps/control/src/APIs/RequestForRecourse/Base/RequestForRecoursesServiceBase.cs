using Control.APIs;
using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Control.APIs.Extensions;
using Control.Infrastructure;
using Control.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Control.APIs;

public abstract class RequestForRecoursesServiceBase : IRequestForRecoursesService
{
    protected readonly ControlDbContext _context;

    public RequestForRecoursesServiceBase(ControlDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one REQUEST FOR RECOURSE
    /// </summary>
    public async Task<RequestForRecourse> CreateRequestForRecourse(
        RequestForRecourseCreateInput createDto
    )
    {
        var requestForRecourse = new RequestForRecourseDbModel
        {
            CreatedAt = createDto.CreatedAt,
            UpdatedAt = createDto.UpdatedAt
        };

        if (createDto.Id != null)
        {
            requestForRecourse.Id = createDto.Id;
        }

        _context.RequestForRecourses.Add(requestForRecourse);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<RequestForRecourseDbModel>(requestForRecourse.Id);

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one REQUEST FOR RECOURSE
    /// </summary>
    public async Task DeleteRequestForRecourse(RequestForRecourseWhereUniqueInput uniqueId)
    {
        var requestForRecourse = await _context.RequestForRecourses.FindAsync(uniqueId.Id);
        if (requestForRecourse == null)
        {
            throw new NotFoundException();
        }

        _context.RequestForRecourses.Remove(requestForRecourse);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many REQUEST FOR RECOURSES
    /// </summary>
    public async Task<List<RequestForRecourse>> RequestForRecourses(
        RequestForRecourseFindManyArgs findManyArgs
    )
    {
        var requestForRecourses = await _context
            .RequestForRecourses.ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return requestForRecourses.ConvertAll(requestForRecourse => requestForRecourse.ToDto());
    }

    /// <summary>
    /// Meta data about REQUEST FOR RECOURSE records
    /// </summary>
    public async Task<MetadataDto> RequestForRecoursesMeta(
        RequestForRecourseFindManyArgs findManyArgs
    )
    {
        var count = await _context.RequestForRecourses.ApplyWhere(findManyArgs.Where).CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one REQUEST FOR RECOURSE
    /// </summary>
    public async Task<RequestForRecourse> RequestForRecourse(
        RequestForRecourseWhereUniqueInput uniqueId
    )
    {
        var requestForRecourses = await this.RequestForRecourses(
            new RequestForRecourseFindManyArgs
            {
                Where = new RequestForRecourseWhereInput { Id = uniqueId.Id }
            }
        );
        var requestForRecourse = requestForRecourses.FirstOrDefault();
        if (requestForRecourse == null)
        {
            throw new NotFoundException();
        }

        return requestForRecourse;
    }

    /// <summary>
    /// Update one REQUEST FOR RECOURSE
    /// </summary>
    public async Task UpdateRequestForRecourse(
        RequestForRecourseWhereUniqueInput uniqueId,
        RequestForRecourseUpdateInput updateDto
    )
    {
        var requestForRecourse = updateDto.ToModel(uniqueId);

        _context.Entry(requestForRecourse).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!_context.RequestForRecourses.Any(e => e.Id == requestForRecourse.Id))
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
