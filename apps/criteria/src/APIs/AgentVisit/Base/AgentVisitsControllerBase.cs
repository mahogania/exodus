using Criteria.APIs;
using Criteria.APIs.Common;
using Criteria.APIs.Dtos;
using Criteria.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Criteria.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class AgentVisitsControllerBase : ControllerBase
{
    protected readonly IAgentVisitsService _service;

    public AgentVisitsControllerBase(IAgentVisitsService service)
    {
        _service = service;
    }

    /// <summary>
    /// Create one Agent Visit
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<AgentVisit>> CreateAgentVisit(AgentVisitCreateInput input)
    {
        var agentVisit = await _service.CreateAgentVisit(input);

        return CreatedAtAction(nameof(AgentVisit), new { id = agentVisit.Id }, agentVisit);
    }

    /// <summary>
    /// Delete one Agent Visit
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteAgentVisit(
        [FromRoute()] AgentVisitWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteAgentVisit(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many Agent Visits
    /// </summary>
    [HttpGet()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<AgentVisit>>> AgentVisits(
        [FromQuery()] AgentVisitFindManyArgs filter
    )
    {
        return Ok(await _service.AgentVisits(filter));
    }

    /// <summary>
    /// Meta data about Agent Visit records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> AgentVisitsMeta(
        [FromQuery()] AgentVisitFindManyArgs filter
    )
    {
        return Ok(await _service.AgentVisitsMeta(filter));
    }

    /// <summary>
    /// Get one Agent Visit
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<AgentVisit>> AgentVisit(
        [FromRoute()] AgentVisitWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.AgentVisit(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one Agent Visit
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateAgentVisit(
        [FromRoute()] AgentVisitWhereUniqueInput uniqueId,
        [FromQuery()] AgentVisitUpdateInput agentVisitUpdateDto
    )
    {
        try
        {
            await _service.UpdateAgentVisit(uniqueId, agentVisitUpdateDto);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
