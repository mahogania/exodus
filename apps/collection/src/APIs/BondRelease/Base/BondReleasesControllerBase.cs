using Collection.APIs.Common;
using Collection.APIs.Dtos;
using Collection.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Collection.APIs;

[Route("api/[controller]")]
[ApiController]
public abstract class BondReleasesControllerBase : ControllerBase
{
    protected readonly IBondReleasesService _service;

    public BondReleasesControllerBase(IBondReleasesService service)
    {
        _service = service;
    }

    /// <summary>
    ///     Create one BOND RELEASE
    /// </summary>
    [HttpPost]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<BondRelease>> CreateBondRelease(BondReleaseCreateInput input)
    {
        var bondRelease = await _service.CreateBondRelease(input);

        return CreatedAtAction(nameof(BondRelease), new { id = bondRelease.Id }, bondRelease);
    }

    /// <summary>
    ///     Delete one BOND RELEASE
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteBondRelease(
        [FromRoute] BondReleaseWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteBondRelease(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    ///     Find many BOND RELEASES
    /// </summary>
    [HttpGet]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<BondRelease>>> BondReleases(
        [FromQuery] BondReleaseFindManyArgs filter
    )
    {
        return Ok(await _service.BondReleases(filter));
    }

    /// <summary>
    ///     Meta data about BOND RELEASE records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> BondReleasesMeta(
        [FromQuery] BondReleaseFindManyArgs filter
    )
    {
        return Ok(await _service.BondReleasesMeta(filter));
    }

    /// <summary>
    ///     Get one BOND RELEASE
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<BondRelease>> BondRelease(
        [FromRoute] BondReleaseWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.BondRelease(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    ///     Update one BOND RELEASE
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateBondRelease(
        [FromRoute] BondReleaseWhereUniqueInput uniqueId,
        [FromQuery] BondReleaseUpdateInput bondReleaseUpdateDto
    )
    {
        try
        {
            await _service.UpdateBondRelease(uniqueId, bondReleaseUpdateDto);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
