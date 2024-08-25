using Criteria.APIs.Common;
using Criteria.APIs.Dtos;

namespace Criteria.APIs;

public interface IAgentVisitsService
{
    /// <summary>
    /// Create one Agent Visit
    /// </summary>
    public Task<AgentVisit> CreateAgentVisit(AgentVisitCreateInput agentvisit);

    /// <summary>
    /// Delete one Agent Visit
    /// </summary>
    public Task DeleteAgentVisit(AgentVisitWhereUniqueInput uniqueId);

    /// <summary>
    /// Find many Agent Visits
    /// </summary>
    public Task<List<AgentVisit>> AgentVisits(AgentVisitFindManyArgs findManyArgs);

    /// <summary>
    /// Meta data about Agent Visit records
    /// </summary>
    public Task<MetadataDto> AgentVisitsMeta(AgentVisitFindManyArgs findManyArgs);

    /// <summary>
    /// Get one Agent Visit
    /// </summary>
    public Task<AgentVisit> AgentVisit(AgentVisitWhereUniqueInput uniqueId);

    /// <summary>
    /// Update one Agent Visit
    /// </summary>
    public Task UpdateAgentVisit(
        AgentVisitWhereUniqueInput uniqueId,
        AgentVisitUpdateInput updateDto
    );
}
