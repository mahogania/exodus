using Fret.APIs;
using Fret.APIs.Common;
using Fret.APIs.Dtos;
using Fret.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Fret.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class TrainsControllerBase : ControllerBase
{
    protected readonly ITrainsService _service;

    public TrainsControllerBase(ITrainsService service)
    {
        _service = service;
    }

    /// <summary>
    /// Create one Train
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<Train>> CreateTrain(TrainCreateInput input)
    {
        var train = await _service.CreateTrain(input);

        return CreatedAtAction(nameof(Train), new { id = train.Id }, train);
    }

    /// <summary>
    /// Delete one Train
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteTrain([FromRoute()] TrainWhereUniqueInput uniqueId)
    {
        try
        {
            await _service.DeleteTrain(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many Trains
    /// </summary>
    [HttpGet()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<Train>>> Trains([FromQuery()] TrainFindManyArgs filter)
    {
        return Ok(await _service.Trains(filter));
    }

    /// <summary>
    /// Meta data about Train records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> TrainsMeta([FromQuery()] TrainFindManyArgs filter)
    {
        return Ok(await _service.TrainsMeta(filter));
    }

    /// <summary>
    /// Get one Train
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<Train>> Train([FromRoute()] TrainWhereUniqueInput uniqueId)
    {
        try
        {
            return await _service.Train(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one Train
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateTrain(
        [FromRoute()] TrainWhereUniqueInput uniqueId,
        [FromQuery()] TrainUpdateInput trainUpdateDto
    )
    {
        try
        {
            await _service.UpdateTrain(uniqueId, trainUpdateDto);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
