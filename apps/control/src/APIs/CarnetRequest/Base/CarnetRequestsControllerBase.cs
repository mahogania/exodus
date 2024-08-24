using Control.APIs;
using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class CarnetRequestsControllerBase : ControllerBase
{
    protected readonly ICarnetRequestsService _service;

    public CarnetRequestsControllerBase(ICarnetRequestsService service)
    {
        _service = service;
    }

    /// <summary>
    /// Create one Carnet Request
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<CarnetRequest>> CreateCarnetRequest(
        CarnetRequestCreateInput input
    )
    {
        var carnetRequest = await _service.CreateCarnetRequest(input);

        return CreatedAtAction(nameof(CarnetRequest), new { id = carnetRequest.Id }, carnetRequest);
    }

    /// <summary>
    /// Delete one Carnet Request
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteCarnetRequest(
        [FromRoute()] CarnetRequestWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteCarnetRequest(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many Carnet Requests
    /// </summary>
    [HttpGet()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<CarnetRequest>>> CarnetRequests(
        [FromQuery()] CarnetRequestFindManyArgs filter
    )
    {
        return Ok(await _service.CarnetRequests(filter));
    }

    /// <summary>
    /// Meta data about Carnet Request records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> CarnetRequestsMeta(
        [FromQuery()] CarnetRequestFindManyArgs filter
    )
    {
        return Ok(await _service.CarnetRequestsMeta(filter));
    }

    /// <summary>
    /// Get one Carnet Request
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<CarnetRequest>> CarnetRequest(
        [FromRoute()] CarnetRequestWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.CarnetRequest(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one Carnet Request
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateCarnetRequest(
        [FromRoute()] CarnetRequestWhereUniqueInput uniqueId,
        [FromQuery()] CarnetRequestUpdateInput carnetRequestUpdateDto
    )
    {
        try
        {
            await _service.UpdateCarnetRequest(uniqueId, carnetRequestUpdateDto);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Connect multiple Article Carnet Requests records to Carnet Request
    /// </summary>
    [HttpPost("{Id}/articleCarnetRequests")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> ConnectArticleCarnetRequests(
        [FromRoute()] CarnetRequestWhereUniqueInput uniqueId,
        [FromQuery()] ArticleCarnetRequestWhereUniqueInput[] articleCarnetRequestsId
    )
    {
        try
        {
            await _service.ConnectArticleCarnetRequests(uniqueId, articleCarnetRequestsId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Disconnect multiple Article Carnet Requests records from Carnet Request
    /// </summary>
    [HttpDelete("{Id}/articleCarnetRequests")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DisconnectArticleCarnetRequests(
        [FromRoute()] CarnetRequestWhereUniqueInput uniqueId,
        [FromBody()] ArticleCarnetRequestWhereUniqueInput[] articleCarnetRequestsId
    )
    {
        try
        {
            await _service.DisconnectArticleCarnetRequests(uniqueId, articleCarnetRequestsId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find multiple Article Carnet Requests records for Carnet Request
    /// </summary>
    [HttpGet("{Id}/articleCarnetRequests")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<ArticleCarnetRequest>>> FindArticleCarnetRequests(
        [FromRoute()] CarnetRequestWhereUniqueInput uniqueId,
        [FromQuery()] ArticleCarnetRequestFindManyArgs filter
    )
    {
        try
        {
            return Ok(await _service.FindArticleCarnetRequests(uniqueId, filter));
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update multiple Article Carnet Requests records for Carnet Request
    /// </summary>
    [HttpPatch("{Id}/articleCarnetRequests")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateArticleCarnetRequests(
        [FromRoute()] CarnetRequestWhereUniqueInput uniqueId,
        [FromBody()] ArticleCarnetRequestWhereUniqueInput[] articleCarnetRequestsId
    )
    {
        try
        {
            await _service.UpdateArticleCarnetRequests(uniqueId, articleCarnetRequestsId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Get a Common Carnet Request record for Carnet Request
    /// </summary>
    [HttpGet("{Id}/commonCarnetRequests")]
    public async Task<ActionResult<List<CommonCarnetRequest>>> GetCommonCarnetRequest(
        [FromRoute()] CarnetRequestWhereUniqueInput uniqueId
    )
    {
        var commonCarnetRequest = await _service.GetCommonCarnetRequest(uniqueId);
        return Ok(commonCarnetRequest);
    }

    /// <summary>
    /// Get a Extended Period Carnet Requests record for Carnet Request
    /// </summary>
    [HttpGet("{Id}/extendedPeriodCarnetRequests")]
    public async Task<
        ActionResult<List<ExtendedPeriodCarnetRequest>>
    > GetExtendedPeriodCarnetRequests([FromRoute()] CarnetRequestWhereUniqueInput uniqueId)
    {
        var extendedPeriodCarnetRequest = await _service.GetExtendedPeriodCarnetRequests(uniqueId);
        return Ok(extendedPeriodCarnetRequest);
    }

    /// <summary>
    /// Connect multiple Import Carnet Requests records to Carnet Request
    /// </summary>
    [HttpPost("{Id}/importCarnetRequests")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> ConnectImportCarnetRequests(
        [FromRoute()] CarnetRequestWhereUniqueInput uniqueId,
        [FromQuery()] ImportCarnetRequestWhereUniqueInput[] importCarnetRequestsId
    )
    {
        try
        {
            await _service.ConnectImportCarnetRequests(uniqueId, importCarnetRequestsId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Disconnect multiple Import Carnet Requests records from Carnet Request
    /// </summary>
    [HttpDelete("{Id}/importCarnetRequests")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DisconnectImportCarnetRequests(
        [FromRoute()] CarnetRequestWhereUniqueInput uniqueId,
        [FromBody()] ImportCarnetRequestWhereUniqueInput[] importCarnetRequestsId
    )
    {
        try
        {
            await _service.DisconnectImportCarnetRequests(uniqueId, importCarnetRequestsId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find multiple Import Carnet Requests records for Carnet Request
    /// </summary>
    [HttpGet("{Id}/importCarnetRequests")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<ImportCarnetRequest>>> FindImportCarnetRequests(
        [FromRoute()] CarnetRequestWhereUniqueInput uniqueId,
        [FromQuery()] ImportCarnetRequestFindManyArgs filter
    )
    {
        try
        {
            return Ok(await _service.FindImportCarnetRequests(uniqueId, filter));
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update multiple Import Carnet Requests records for Carnet Request
    /// </summary>
    [HttpPatch("{Id}/importCarnetRequests")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateImportCarnetRequests(
        [FromRoute()] CarnetRequestWhereUniqueInput uniqueId,
        [FromBody()] ImportCarnetRequestWhereUniqueInput[] importCarnetRequestsId
    )
    {
        try
        {
            await _service.UpdateImportCarnetRequests(uniqueId, importCarnetRequestsId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Connect multiple Reexport Carnet Requests records to Carnet Request
    /// </summary>
    [HttpPost("{Id}/reexportCarnetRequests")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> ConnectReexportCarnetRequests(
        [FromRoute()] CarnetRequestWhereUniqueInput uniqueId,
        [FromQuery()] ReexportCarnetRequestWhereUniqueInput[] reexportCarnetRequestsId
    )
    {
        try
        {
            await _service.ConnectReexportCarnetRequests(uniqueId, reexportCarnetRequestsId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Disconnect multiple Reexport Carnet Requests records from Carnet Request
    /// </summary>
    [HttpDelete("{Id}/reexportCarnetRequests")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DisconnectReexportCarnetRequests(
        [FromRoute()] CarnetRequestWhereUniqueInput uniqueId,
        [FromBody()] ReexportCarnetRequestWhereUniqueInput[] reexportCarnetRequestsId
    )
    {
        try
        {
            await _service.DisconnectReexportCarnetRequests(uniqueId, reexportCarnetRequestsId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find multiple Reexport Carnet Requests records for Carnet Request
    /// </summary>
    [HttpGet("{Id}/reexportCarnetRequests")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<ReexportCarnetRequest>>> FindReexportCarnetRequests(
        [FromRoute()] CarnetRequestWhereUniqueInput uniqueId,
        [FromQuery()] ReexportCarnetRequestFindManyArgs filter
    )
    {
        try
        {
            return Ok(await _service.FindReexportCarnetRequests(uniqueId, filter));
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update multiple Reexport Carnet Requests records for Carnet Request
    /// </summary>
    [HttpPatch("{Id}/reexportCarnetRequests")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateReexportCarnetRequests(
        [FromRoute()] CarnetRequestWhereUniqueInput uniqueId,
        [FromBody()] ReexportCarnetRequestWhereUniqueInput[] reexportCarnetRequestsId
    )
    {
        try
        {
            await _service.UpdateReexportCarnetRequests(uniqueId, reexportCarnetRequestsId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Connect multiple Transit Carnet Requests records to Carnet Request
    /// </summary>
    [HttpPost("{Id}/transitCarnetRequests")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> ConnectTransitCarnetRequests(
        [FromRoute()] CarnetRequestWhereUniqueInput uniqueId,
        [FromQuery()] TransitCarnetRequestWhereUniqueInput[] transitCarnetRequestsId
    )
    {
        try
        {
            await _service.ConnectTransitCarnetRequests(uniqueId, transitCarnetRequestsId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Disconnect multiple Transit Carnet Requests records from Carnet Request
    /// </summary>
    [HttpDelete("{Id}/transitCarnetRequests")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DisconnectTransitCarnetRequests(
        [FromRoute()] CarnetRequestWhereUniqueInput uniqueId,
        [FromBody()] TransitCarnetRequestWhereUniqueInput[] transitCarnetRequestsId
    )
    {
        try
        {
            await _service.DisconnectTransitCarnetRequests(uniqueId, transitCarnetRequestsId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find multiple Transit Carnet Requests records for Carnet Request
    /// </summary>
    [HttpGet("{Id}/transitCarnetRequests")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<TransitCarnetRequest>>> FindTransitCarnetRequests(
        [FromRoute()] CarnetRequestWhereUniqueInput uniqueId,
        [FromQuery()] TransitCarnetRequestFindManyArgs filter
    )
    {
        try
        {
            return Ok(await _service.FindTransitCarnetRequests(uniqueId, filter));
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update multiple Transit Carnet Requests records for Carnet Request
    /// </summary>
    [HttpPatch("{Id}/transitCarnetRequests")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateTransitCarnetRequests(
        [FromRoute()] CarnetRequestWhereUniqueInput uniqueId,
        [FromBody()] TransitCarnetRequestWhereUniqueInput[] transitCarnetRequestsId
    )
    {
        try
        {
            await _service.UpdateTransitCarnetRequests(uniqueId, transitCarnetRequestsId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
