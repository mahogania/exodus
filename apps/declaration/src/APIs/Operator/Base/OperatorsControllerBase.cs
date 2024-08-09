using Microsoft.AspNetCore.Mvc;
using Statement.APIs;
using Microsoft.AspNetCore.Authorization;
using Statement.APIs.Dtos;
using Statement.APIs.Errors;
using Statement.APIs.Common;

namespace Statement.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class OperatorsControllerBase : ControllerBase
{
    protected readonly IOperatorsService _service;
    public OperatorsControllerBase(IOperatorsService service)
    {
        _service = service;
    }

    /// <summary>
    /// Create one Operator
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<Operator>> CreateOperator(OperatorCreateInput input)
    {
        var operator = await _service.CreateOperator(input);

        return CreatedAtAction(nameof(Operator), new { id = operator.Id }, operator);
    }

    /// <summary>
    /// Delete one Operator
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteOperator([FromRoute()]
    OperatorWhereUniqueInput uniqueId)
    {
        try
        {
            await _service.DeleteOperator(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many Operators
    /// </summary>
    [HttpGet()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<Operator>>> Operators([FromQuery()]
    OperatorFindManyArgs filter)
    {
        return Ok(await _service.Operators(filter));
    }

    /// <summary>
    /// Meta data about Operator records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> OperatorsMeta([FromQuery()]
    OperatorFindManyArgs filter)
    {
        return Ok(await _service.OperatorsMeta(filter));
    }

    /// <summary>
    /// Get one Operator
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<Operator>> Operator([FromRoute()]
    OperatorWhereUniqueInput uniqueId)
    {
        try
        {
            return await _service.Operator(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one Operator
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateOperator([FromRoute()]
    OperatorWhereUniqueInput uniqueId, [FromQuery()]
    OperatorUpdateInput operatorUpdateDto)
    {
        try
        {
            await _service.UpdateOperator(uniqueId, operatorUpdateDto);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

}
