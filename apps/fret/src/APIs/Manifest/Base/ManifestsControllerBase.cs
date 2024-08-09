using Fret.APIs;
using Fret.APIs.Common;
using Fret.APIs.Dtos;
using Fret.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Fret.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class ManifestsControllerBase : ControllerBase
{
    protected readonly IManifestsService _service;

    public ManifestsControllerBase(IManifestsService service)
    {
        _service = service;
    }

    /// <summary>
    /// Create one Manifeste
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<Manifest>> CreateManifest(ManifestCreateInput input)
    {
        var manifest = await _service.CreateManifest(input);

        return CreatedAtAction(nameof(Manifest), new { id = manifest.Id }, manifest);
    }

    /// <summary>
    /// Delete one Manifeste
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteManifest([FromRoute()] ManifestWhereUniqueInput uniqueId)
    {
        try
        {
            await _service.DeleteManifest(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many Manifests
    /// </summary>
    [HttpGet()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<Manifest>>> Manifests(
        [FromQuery()] ManifestFindManyArgs filter
    )
    {
        return Ok(await _service.Manifests(filter));
    }

    /// <summary>
    /// Meta data about Manifeste records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> ManifestsMeta(
        [FromQuery()] ManifestFindManyArgs filter
    )
    {
        return Ok(await _service.ManifestsMeta(filter));
    }

    /// <summary>
    /// Get one Manifeste
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<Manifest>> Manifest(
        [FromRoute()] ManifestWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.Manifest(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one Manifeste
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateManifest(
        [FromRoute()] ManifestWhereUniqueInput uniqueId,
        [FromQuery()] ManifestUpdateInput manifestUpdateDto
    )
    {
        try
        {
            await _service.UpdateManifest(uniqueId, manifestUpdateDto);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
