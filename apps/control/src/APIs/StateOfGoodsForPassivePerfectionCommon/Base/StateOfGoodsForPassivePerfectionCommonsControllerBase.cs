using Control.APIs;
using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class StateOfGoodsForPassivePerfectionCommonsControllerBase : ControllerBase
{
    protected readonly IStateOfGoodsForPassivePerfectionCommonsService _service;

    public StateOfGoodsForPassivePerfectionCommonsControllerBase(
        IStateOfGoodsForPassivePerfectionCommonsService service
    )
    {
        _service = service;
    }

    /// <summary>
    /// Create one STATE OF GOODS FOR PASSIVE PERFECTION COMMON
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<StateOfGoodsForPassivePerfectionCommon>
    > CreateStateOfGoodsForPassivePerfectionCommon(
        StateOfGoodsForPassivePerfectionCommonCreateInput input
    )
    {
        var stateOfGoodsForPassivePerfectionCommon =
            await _service.CreateStateOfGoodsForPassivePerfectionCommon(input);

        return CreatedAtAction(
            nameof(StateOfGoodsForPassivePerfectionCommon),
            new { id = stateOfGoodsForPassivePerfectionCommon.Id },
            stateOfGoodsForPassivePerfectionCommon
        );
    }

    /// <summary>
    /// Delete one STATE OF GOODS FOR PASSIVE PERFECTION COMMON
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteStateOfGoodsForPassivePerfectionCommon(
        [FromRoute()] StateOfGoodsForPassivePerfectionCommonWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteStateOfGoodsForPassivePerfectionCommon(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many STATE OF GOODS FOR PASSIVE PERFECTION COMMONS
    /// </summary>
    [HttpGet()]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<List<StateOfGoodsForPassivePerfectionCommon>>
    > StateOfGoodsForPassivePerfectionCommons(
        [FromQuery()] StateOfGoodsForPassivePerfectionCommonFindManyArgs filter
    )
    {
        return Ok(await _service.StateOfGoodsForPassivePerfectionCommons(filter));
    }

    /// <summary>
    /// Meta data about STATE OF GOODS FOR PASSIVE PERFECTION COMMON records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> StateOfGoodsForPassivePerfectionCommonsMeta(
        [FromQuery()] StateOfGoodsForPassivePerfectionCommonFindManyArgs filter
    )
    {
        return Ok(await _service.StateOfGoodsForPassivePerfectionCommonsMeta(filter));
    }

    /// <summary>
    /// Get one STATE OF GOODS FOR PASSIVE PERFECTION COMMON
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<StateOfGoodsForPassivePerfectionCommon>
    > StateOfGoodsForPassivePerfectionCommon(
        [FromRoute()] StateOfGoodsForPassivePerfectionCommonWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.StateOfGoodsForPassivePerfectionCommon(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one STATE OF GOODS FOR PASSIVE PERFECTION COMMON
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateStateOfGoodsForPassivePerfectionCommon(
        [FromRoute()] StateOfGoodsForPassivePerfectionCommonWhereUniqueInput uniqueId,
        [FromQuery()]
            StateOfGoodsForPassivePerfectionCommonUpdateInput stateOfGoodsForPassivePerfectionCommonUpdateDto
    )
    {
        try
        {
            await _service.UpdateStateOfGoodsForPassivePerfectionCommon(
                uniqueId,
                stateOfGoodsForPassivePerfectionCommonUpdateDto
            );
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
