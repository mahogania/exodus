using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[Route("api/[controller]")]
[ApiController]
public abstract class MaterialsAtWithReexportationInTheStatesControllerBase : ControllerBase
{
    protected readonly IMaterialsAtWithReexportationInTheStatesService _service;

    public MaterialsAtWithReexportationInTheStatesControllerBase(
        IMaterialsAtWithReexportationInTheStatesService service
    )
    {
        _service = service;
    }

    /// <summary>
    ///     Create one MATERIALS AT WITH REEXPORTATION IN THE STATE
    /// </summary>
    [HttpPost]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<MaterialsAtWithReexportationInTheState>
    > CreateMaterialsAtWithReexportationInTheState(
        MaterialsAtWithReexportationInTheStateCreateInput input
    )
    {
        var materialsAtWithReexportationInTheState =
            await _service.CreateMaterialsAtWithReexportationInTheState(input);

        return CreatedAtAction(
            nameof(MaterialsAtWithReexportationInTheState),
            new { id = materialsAtWithReexportationInTheState.Id },
            materialsAtWithReexportationInTheState
        );
    }

    /// <summary>
    ///     Delete one MATERIALS AT WITH REEXPORTATION IN THE STATE
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteMaterialsAtWithReexportationInTheState(
        [FromRoute] MaterialsAtWithReexportationInTheStateWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteMaterialsAtWithReexportationInTheState(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    ///     Find many MATERIALS AT WITH REEXPORTATION IN THE STATES
    /// </summary>
    [HttpGet]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<List<MaterialsAtWithReexportationInTheState>>
    > MaterialsAtWithReexportationInTheStates(
        [FromQuery] MaterialsAtWithReexportationInTheStateFindManyArgs filter
    )
    {
        return Ok(await _service.MaterialsAtWithReexportationInTheStates(filter));
    }

    /// <summary>
    ///     Meta data about MATERIALS AT WITH REEXPORTATION IN THE STATE records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> MaterialsAtWithReexportationInTheStatesMeta(
        [FromQuery] MaterialsAtWithReexportationInTheStateFindManyArgs filter
    )
    {
        return Ok(await _service.MaterialsAtWithReexportationInTheStatesMeta(filter));
    }

    /// <summary>
    ///     Get one MATERIALS AT WITH REEXPORTATION IN THE STATE
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<MaterialsAtWithReexportationInTheState>
    > MaterialsAtWithReexportationInTheState(
        [FromRoute] MaterialsAtWithReexportationInTheStateWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.MaterialsAtWithReexportationInTheState(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    ///     Update one MATERIALS AT WITH REEXPORTATION IN THE STATE
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateMaterialsAtWithReexportationInTheState(
        [FromRoute] MaterialsAtWithReexportationInTheStateWhereUniqueInput uniqueId,
        [FromQuery] MaterialsAtWithReexportationInTheStateUpdateInput materialsAtWithReexportationInTheStateUpdateDto
    )
    {
        try
        {
            await _service.UpdateMaterialsAtWithReexportationInTheState(
                uniqueId,
                materialsAtWithReexportationInTheStateUpdateDto
            );
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
