using Criteria.APIs;
using Criteria.APIs.Common;
using Criteria.APIs.Dtos;
using Criteria.APIs.Errors;
using Criteria.APIs.Extensions;
using Criteria.Infrastructure;
using Criteria.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Criteria.APIs;

public abstract class AgentVisitsServiceBase : IAgentVisitsService
{
    protected readonly CriteriaDbContext _context;

    public AgentVisitsServiceBase(CriteriaDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one Agent Visit
    /// </summary>
    public async Task<AgentVisit> CreateAgentVisit(AgentVisitCreateInput createDto)
    {
        var agentVisit = new AgentVisitDbModel
        {
            AgencyCode = createDto.AgencyCode,
            CreatedAt = createDto.CreatedAt,
            ServiceCode = createDto.ServiceCode,
            UpdatedAt = createDto.UpdatedAt,
            VerificationDate = createDto.VerificationDate,
            VerifierId = createDto.VerifierId
        };

        if (createDto.Id != null)
        {
            agentVisit.Id = createDto.Id;
        }

        _context.AgentVisits.Add(agentVisit);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<AgentVisitDbModel>(agentVisit.Id);

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one Agent Visit
    /// </summary>
    public async Task DeleteAgentVisit(AgentVisitWhereUniqueInput uniqueId)
    {
        var agentVisit = await _context.AgentVisits.FindAsync(uniqueId.Id);
        if (agentVisit == null)
        {
            throw new NotFoundException();
        }

        _context.AgentVisits.Remove(agentVisit);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many Agent Visits
    /// </summary>
    public async Task<List<AgentVisit>> AgentVisits(AgentVisitFindManyArgs findManyArgs)
    {
        var agentVisits = await _context
            .AgentVisits.ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return agentVisits.ConvertAll(agentVisit => agentVisit.ToDto());
    }

    /// <summary>
    /// Meta data about Agent Visit records
    /// </summary>
    public async Task<MetadataDto> AgentVisitsMeta(AgentVisitFindManyArgs findManyArgs)
    {
        var count = await _context.AgentVisits.ApplyWhere(findManyArgs.Where).CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one Agent Visit
    /// </summary>
    public async Task<AgentVisit> AgentVisit(AgentVisitWhereUniqueInput uniqueId)
    {
        var agentVisits = await this.AgentVisits(
            new AgentVisitFindManyArgs { Where = new AgentVisitWhereInput { Id = uniqueId.Id } }
        );
        var agentVisit = agentVisits.FirstOrDefault();
        if (agentVisit == null)
        {
            throw new NotFoundException();
        }

        return agentVisit;
    }

    /// <summary>
    /// Update one Agent Visit
    /// </summary>
    public async Task UpdateAgentVisit(
        AgentVisitWhereUniqueInput uniqueId,
        AgentVisitUpdateInput updateDto
    )
    {
        var agentVisit = updateDto.ToModel(uniqueId);

        _context.Entry(agentVisit).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!_context.AgentVisits.Any(e => e.Id == agentVisit.Id))
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
