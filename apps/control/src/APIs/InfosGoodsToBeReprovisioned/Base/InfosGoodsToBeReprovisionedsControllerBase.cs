using Control.APIs;
using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class InfosGoodsToBeReprovisionedsControllerBase : ControllerBase
{
    protected readonly IInfosGoodsToBeReprovisionedsService _service;

    public InfosGoodsToBeReprovisionedsControllerBase(IInfosGoodsToBeReprovisionedsService service)
    {
        _service = service;
    }

    /// <summary>
    /// Create one INFOS GOODS TO BE REPROVISIONED
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<InfosGoodsToBeReprovisioned>> CreateInfosGoodsToBeReprovisioned(
        InfosGoodsToBeReprovisionedCreateInput input
    )
    {
        var infosGoodsToBeReprovisioned = await _service.CreateInfosGoodsToBeReprovisioned(input);

        return CreatedAtAction(
            nameof(InfosGoodsToBeReprovisioned),
            new { id = infosGoodsToBeReprovisioned.Id },
            infosGoodsToBeReprovisioned
        );
    }

    /// <summary>
    /// Delete one INFOS GOODS TO BE REPROVISIONED
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteInfosGoodsToBeReprovisioned(
        [FromRoute()] InfosGoodsToBeReprovisionedWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteInfosGoodsToBeReprovisioned(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many INFOS GOODS TO BE REPROVISIONEDS
    /// </summary>
    [HttpGet()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<InfosGoodsToBeReprovisioned>>> InfosGoodsToBeReprovisioneds(
        [FromQuery()] InfosGoodsToBeReprovisionedFindManyArgs filter
    )
    {
        return Ok(await _service.InfosGoodsToBeReprovisioneds(filter));
    }

    /// <summary>
    /// Meta data about INFOS GOODS TO BE REPROVISIONED records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> InfosGoodsToBeReprovisionedsMeta(
        [FromQuery()] InfosGoodsToBeReprovisionedFindManyArgs filter
    )
    {
        return Ok(await _service.InfosGoodsToBeReprovisionedsMeta(filter));
    }

    /// <summary>
    /// Get one INFOS GOODS TO BE REPROVISIONED
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<InfosGoodsToBeReprovisioned>> InfosGoodsToBeReprovisioned(
        [FromRoute()] InfosGoodsToBeReprovisionedWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.InfosGoodsToBeReprovisioned(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one INFOS GOODS TO BE REPROVISIONED
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateInfosGoodsToBeReprovisioned(
        [FromRoute()] InfosGoodsToBeReprovisionedWhereUniqueInput uniqueId,
        [FromQuery()] InfosGoodsToBeReprovisionedUpdateInput infosGoodsToBeReprovisionedUpdateDto
    )
    {
        try
        {
            await _service.UpdateInfosGoodsToBeReprovisioned(
                uniqueId,
                infosGoodsToBeReprovisionedUpdateDto
            );
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
