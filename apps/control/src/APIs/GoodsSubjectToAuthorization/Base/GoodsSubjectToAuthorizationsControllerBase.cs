using Control.APIs;
using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class GoodsSubjectToAuthorizationsControllerBase : ControllerBase
{
    protected readonly IGoodsSubjectToAuthorizationsService _service;

    public GoodsSubjectToAuthorizationsControllerBase(IGoodsSubjectToAuthorizationsService service)
    {
        _service = service;
    }

    /// <summary>
    /// Create one GOODS SUBJECT TO AUTHORIZATION
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<GoodsSubjectToAuthorization>> CreateGoodsSubjectToAuthorization(
        GoodsSubjectToAuthorizationCreateInput input
    )
    {
        var goodsSubjectToAuthorization = await _service.CreateGoodsSubjectToAuthorization(input);

        return CreatedAtAction(
            nameof(GoodsSubjectToAuthorization),
            new { id = goodsSubjectToAuthorization.Id },
            goodsSubjectToAuthorization
        );
    }

    /// <summary>
    /// Delete one GOODS SUBJECT TO AUTHORIZATION
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteGoodsSubjectToAuthorization(
        [FromRoute()] GoodsSubjectToAuthorizationWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteGoodsSubjectToAuthorization(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many GOODS SUBJECT TO AUTHORIZATIONS
    /// </summary>
    [HttpGet()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<GoodsSubjectToAuthorization>>> GoodsSubjectToAuthorizations(
        [FromQuery()] GoodsSubjectToAuthorizationFindManyArgs filter
    )
    {
        return Ok(await _service.GoodsSubjectToAuthorizations(filter));
    }

    /// <summary>
    /// Meta data about GOODS SUBJECT TO AUTHORIZATION records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> GoodsSubjectToAuthorizationsMeta(
        [FromQuery()] GoodsSubjectToAuthorizationFindManyArgs filter
    )
    {
        return Ok(await _service.GoodsSubjectToAuthorizationsMeta(filter));
    }

    /// <summary>
    /// Get one GOODS SUBJECT TO AUTHORIZATION
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<GoodsSubjectToAuthorization>> GoodsSubjectToAuthorization(
        [FromRoute()] GoodsSubjectToAuthorizationWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.GoodsSubjectToAuthorization(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one GOODS SUBJECT TO AUTHORIZATION
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateGoodsSubjectToAuthorization(
        [FromRoute()] GoodsSubjectToAuthorizationWhereUniqueInput uniqueId,
        [FromQuery()] GoodsSubjectToAuthorizationUpdateInput goodsSubjectToAuthorizationUpdateDto
    )
    {
        try
        {
            await _service.UpdateGoodsSubjectToAuthorization(
                uniqueId,
                goodsSubjectToAuthorizationUpdateDto
            );
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
