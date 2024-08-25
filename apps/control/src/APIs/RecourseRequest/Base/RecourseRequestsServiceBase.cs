using Control.APIs;
using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Control.APIs.Extensions;
using Control.Infrastructure;
using Control.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Control.APIs;

public abstract class RecourseRequestsServiceBase : IRecourseRequestsService
{
    protected readonly ControlDbContext _context;

    public RecourseRequestsServiceBase(ControlDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one Recourse Request
    /// </summary>
    public async Task<RecourseRequest> CreateRecourseRequest(RecourseRequestCreateInput createDto)
    {
        var recourseRequest = new RecourseRequestDbModel
        {
            CreatedAt = createDto.CreatedAt,
            UpdatedAt = createDto.UpdatedAt
        };

        if (createDto.Id != null)
        {
            recourseRequest.Id = createDto.Id;
        }
        if (createDto.Journal != null)
        {
            recourseRequest.Journal = await _context
                .Procedures.Where(procedure => createDto.Journal.Id == procedure.Id)
                .FirstOrDefaultAsync();
        }

        _context.RecourseRequests.Add(recourseRequest);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<RecourseRequestDbModel>(recourseRequest.Id);

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one Recourse Request
    /// </summary>
    public async Task DeleteRecourseRequest(RecourseRequestWhereUniqueInput uniqueId)
    {
        var recourseRequest = await _context.RecourseRequests.FindAsync(uniqueId.Id);
        if (recourseRequest == null)
        {
            throw new NotFoundException();
        }

        _context.RecourseRequests.Remove(recourseRequest);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many REQUEST FOR RECOURSES
    /// </summary>
    public async Task<List<RecourseRequest>> RecourseRequests(
        RecourseRequestFindManyArgs findManyArgs
    )
    {
        var recourseRequests = await _context
            .RecourseRequests.Include(x => x.Journal)
            .ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return recourseRequests.ConvertAll(recourseRequest => recourseRequest.ToDto());
    }

    /// <summary>
    /// Meta data about Recourse Request records
    /// </summary>
    public async Task<MetadataDto> RecourseRequestsMeta(RecourseRequestFindManyArgs findManyArgs)
    {
        var count = await _context.RecourseRequests.ApplyWhere(findManyArgs.Where).CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one Recourse Request
    /// </summary>
    public async Task<RecourseRequest> RecourseRequest(RecourseRequestWhereUniqueInput uniqueId)
    {
        var recourseRequests = await this.RecourseRequests(
            new RecourseRequestFindManyArgs
            {
                Where = new RecourseRequestWhereInput { Id = uniqueId.Id }
            }
        );
        var recourseRequest = recourseRequests.FirstOrDefault();
        if (recourseRequest == null)
        {
            throw new NotFoundException();
        }

        return recourseRequest;
    }

    /// <summary>
    /// Update one Recourse Request
    /// </summary>
    public async Task UpdateRecourseRequest(
        RecourseRequestWhereUniqueInput uniqueId,
        RecourseRequestUpdateInput updateDto
    )
    {
        var recourseRequest = updateDto.ToModel(uniqueId);

        _context.Entry(recourseRequest).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!_context.RecourseRequests.Any(e => e.Id == recourseRequest.Id))
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
    /// Get a Journal record for Recourse Request
    /// </summary>
    public async Task<Procedure> GetJournal(RecourseRequestWhereUniqueInput uniqueId)
    {
        var recourseRequest = await _context
            .RecourseRequests.Where(recourseRequest => recourseRequest.Id == uniqueId.Id)
            .Include(recourseRequest => recourseRequest.Journal)
            .FirstOrDefaultAsync();
        if (recourseRequest == null)
        {
            throw new NotFoundException();
        }
        return recourseRequest.Journal.ToDto();
    }
}
