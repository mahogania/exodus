using Collection.APIs;
using Collection.APIs.Common;
using Collection.APIs.Dtos;
using Collection.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Collection.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class DistributionsControllerBase : ControllerBase
{
    protected readonly IDistributionsService _service;

    public DistributionsControllerBase(IDistributionsService service)
    {
        _service = service;
    }

    /// <summary>
    /// Create one DISTRIBUTION
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<Distribution>> CreateDistribution(DistributionCreateInput input)
    {
        var distribution = await _service.CreateDistribution(input);

        return CreatedAtAction(nameof(Distribution), new { id = distribution.Id }, distribution);
    }

    /// <summary>
    /// Delete one DISTRIBUTION
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteDistribution(
        [FromRoute()] DistributionWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteDistribution(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many DISTRIBUTIONS
    /// </summary>
    [HttpGet()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<Distribution>>> Distributions(
        [FromQuery()] DistributionFindManyArgs filter
    )
    {
        return Ok(await _service.Distributions(filter));
    }

    /// <summary>
    /// Meta data about DISTRIBUTION records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> DistributionsMeta(
        [FromQuery()] DistributionFindManyArgs filter
    )
    {
        return Ok(await _service.DistributionsMeta(filter));
    }

    /// <summary>
    /// Get one DISTRIBUTION
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<Distribution>> Distribution(
        [FromRoute()] DistributionWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.Distribution(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one DISTRIBUTION
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateDistribution(
        [FromRoute()] DistributionWhereUniqueInput uniqueId,
        [FromQuery()] DistributionUpdateInput distributionUpdateDto
    )
    {
        try
        {
            await _service.UpdateDistribution(uniqueId, distributionUpdateDto);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
