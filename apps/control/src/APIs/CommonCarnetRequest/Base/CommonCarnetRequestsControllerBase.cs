using Control.APIs;
using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class CommonCarnetRequestsControllerBase : ControllerBase
{
    protected readonly ICommonCarnetRequestsService _service;

    public CommonCarnetRequestsControllerBase(ICommonCarnetRequestsService service)
    {
        _service = service;
    }

    /// <summary>
    /// Create one Common Carnet Request
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<CommonCarnetRequest>> CreateCommonCarnetRequest(
        CommonCarnetRequestCreateInput input
    )
    {
        var commonCarnetRequest = await _service.CreateCommonCarnetRequest(input);

        return CreatedAtAction(
            nameof(CommonCarnetRequest),
            new { id = commonCarnetRequest.Id },
            commonCarnetRequest
        );
    }

    /// <summary>
    /// Delete one Common Carnet Request
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteCommonCarnetRequest(
        [FromRoute()] CommonCarnetRequestWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteCommonCarnetRequest(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many Common Carnet Requests
    /// </summary>
    [HttpGet()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<CommonCarnetRequest>>> CommonCarnetRequests(
        [FromQuery()] CommonCarnetRequestFindManyArgs filter
    )
    {
        return Ok(await _service.CommonCarnetRequests(filter));
    }

    /// <summary>
    /// Meta data about Common Carnet Request records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> CommonCarnetRequestsMeta(
        [FromQuery()] CommonCarnetRequestFindManyArgs filter
    )
    {
        return Ok(await _service.CommonCarnetRequestsMeta(filter));
    }

    /// <summary>
    /// Get one Common Carnet Request
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<CommonCarnetRequest>> CommonCarnetRequest(
        [FromRoute()] CommonCarnetRequestWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.CommonCarnetRequest(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one Common Carnet Request
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateCommonCarnetRequest(
        [FromRoute()] CommonCarnetRequestWhereUniqueInput uniqueId,
        [FromQuery()] CommonCarnetRequestUpdateInput commonCarnetRequestUpdateDto
    )
    {
        try
        {
            await _service.UpdateCommonCarnetRequest(uniqueId, commonCarnetRequestUpdateDto);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Connect multiple Article Carnet Requests records to Common Carnet Request
    /// </summary>
    [HttpPost("{Id}/articleCarnetRequests")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> ConnectArticleCarnetRequests(
        [FromRoute()] CommonCarnetRequestWhereUniqueInput uniqueId,
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
    /// Disconnect multiple Article Carnet Requests records from Common Carnet Request
    /// </summary>
    [HttpDelete("{Id}/articleCarnetRequests")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DisconnectArticleCarnetRequests(
        [FromRoute()] CommonCarnetRequestWhereUniqueInput uniqueId,
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
    /// Find multiple Article Carnet Requests records for Common Carnet Request
    /// </summary>
    [HttpGet("{Id}/articleCarnetRequests")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<ArticleCarnetRequest>>> FindArticleCarnetRequests(
        [FromRoute()] CommonCarnetRequestWhereUniqueInput uniqueId,
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
    /// Update multiple Article Carnet Requests records for Common Carnet Request
    /// </summary>
    [HttpPatch("{Id}/articleCarnetRequests")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateArticleCarnetRequests(
        [FromRoute()] CommonCarnetRequestWhereUniqueInput uniqueId,
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
    /// Connect multiple CarnetControls records to Common Carnet Request
    /// </summary>
    [HttpPost("{Id}/carnetControls")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> ConnectCarnetControls(
        [FromRoute()] CommonCarnetRequestWhereUniqueInput uniqueId,
        [FromQuery()] CarnetControlWhereUniqueInput[] carnetControlsId
    )
    {
        try
        {
            await _service.ConnectCarnetControls(uniqueId, carnetControlsId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Disconnect multiple CarnetControls records from Common Carnet Request
    /// </summary>
    [HttpDelete("{Id}/carnetControls")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DisconnectCarnetControls(
        [FromRoute()] CommonCarnetRequestWhereUniqueInput uniqueId,
        [FromBody()] CarnetControlWhereUniqueInput[] carnetControlsId
    )
    {
        try
        {
            await _service.DisconnectCarnetControls(uniqueId, carnetControlsId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find multiple CarnetControls records for Common Carnet Request
    /// </summary>
    [HttpGet("{Id}/carnetControls")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<CarnetControl>>> FindCarnetControls(
        [FromRoute()] CommonCarnetRequestWhereUniqueInput uniqueId,
        [FromQuery()] CarnetControlFindManyArgs filter
    )
    {
        try
        {
            return Ok(await _service.FindCarnetControls(uniqueId, filter));
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update multiple CarnetControls records for Common Carnet Request
    /// </summary>
    [HttpPatch("{Id}/carnetControls")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateCarnetControls(
        [FromRoute()] CommonCarnetRequestWhereUniqueInput uniqueId,
        [FromBody()] CarnetControlWhereUniqueInput[] carnetControlsId
    )
    {
        try
        {
            await _service.UpdateCarnetControls(uniqueId, carnetControlsId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Connect multiple Extended Period Carnet Requests records to Common Carnet Request
    /// </summary>
    [HttpPost("{Id}/extendedPeriodCarnetRequests")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> ConnectExtendedPeriodCarnetRequests(
        [FromRoute()] CommonCarnetRequestWhereUniqueInput uniqueId,
        [FromQuery()] ExtendedPeriodCarnetRequestWhereUniqueInput[] extendedPeriodCarnetRequestsId
    )
    {
        try
        {
            await _service.ConnectExtendedPeriodCarnetRequests(
                uniqueId,
                extendedPeriodCarnetRequestsId
            );
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Disconnect multiple Extended Period Carnet Requests records from Common Carnet Request
    /// </summary>
    [HttpDelete("{Id}/extendedPeriodCarnetRequests")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DisconnectExtendedPeriodCarnetRequests(
        [FromRoute()] CommonCarnetRequestWhereUniqueInput uniqueId,
        [FromBody()] ExtendedPeriodCarnetRequestWhereUniqueInput[] extendedPeriodCarnetRequestsId
    )
    {
        try
        {
            await _service.DisconnectExtendedPeriodCarnetRequests(
                uniqueId,
                extendedPeriodCarnetRequestsId
            );
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find multiple Extended Period Carnet Requests records for Common Carnet Request
    /// </summary>
    [HttpGet("{Id}/extendedPeriodCarnetRequests")]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<List<ExtendedPeriodCarnetRequest>>
    > FindExtendedPeriodCarnetRequests(
        [FromRoute()] CommonCarnetRequestWhereUniqueInput uniqueId,
        [FromQuery()] ExtendedPeriodCarnetRequestFindManyArgs filter
    )
    {
        try
        {
            return Ok(await _service.FindExtendedPeriodCarnetRequests(uniqueId, filter));
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update multiple Extended Period Carnet Requests records for Common Carnet Request
    /// </summary>
    [HttpPatch("{Id}/extendedPeriodCarnetRequests")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateExtendedPeriodCarnetRequests(
        [FromRoute()] CommonCarnetRequestWhereUniqueInput uniqueId,
        [FromBody()] ExtendedPeriodCarnetRequestWhereUniqueInput[] extendedPeriodCarnetRequestsId
    )
    {
        try
        {
            await _service.UpdateExtendedPeriodCarnetRequests(
                uniqueId,
                extendedPeriodCarnetRequestsId
            );
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Connect multiple Import Carnet Requests records to Common Carnet Request
    /// </summary>
    [HttpPost("{Id}/importCarnetRequests")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> ConnectImportCarnetRequests(
        [FromRoute()] CommonCarnetRequestWhereUniqueInput uniqueId,
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
    /// Disconnect multiple Import Carnet Requests records from Common Carnet Request
    /// </summary>
    [HttpDelete("{Id}/importCarnetRequests")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DisconnectImportCarnetRequests(
        [FromRoute()] CommonCarnetRequestWhereUniqueInput uniqueId,
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
    /// Find multiple Import Carnet Requests records for Common Carnet Request
    /// </summary>
    [HttpGet("{Id}/importCarnetRequests")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<ImportCarnetRequest>>> FindImportCarnetRequests(
        [FromRoute()] CommonCarnetRequestWhereUniqueInput uniqueId,
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
    /// Update multiple Import Carnet Requests records for Common Carnet Request
    /// </summary>
    [HttpPatch("{Id}/importCarnetRequests")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateImportCarnetRequests(
        [FromRoute()] CommonCarnetRequestWhereUniqueInput uniqueId,
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
    /// Connect multiple Reexport Carnet Requests records to Common Carnet Request
    /// </summary>
    [HttpPost("{Id}/reexportCarnetRequests")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> ConnectReexportCarnetRequests(
        [FromRoute()] CommonCarnetRequestWhereUniqueInput uniqueId,
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
    /// Disconnect multiple Reexport Carnet Requests records from Common Carnet Request
    /// </summary>
    [HttpDelete("{Id}/reexportCarnetRequests")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DisconnectReexportCarnetRequests(
        [FromRoute()] CommonCarnetRequestWhereUniqueInput uniqueId,
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
    /// Find multiple Reexport Carnet Requests records for Common Carnet Request
    /// </summary>
    [HttpGet("{Id}/reexportCarnetRequests")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<ReexportCarnetRequest>>> FindReexportCarnetRequests(
        [FromRoute()] CommonCarnetRequestWhereUniqueInput uniqueId,
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
    /// Update multiple Reexport Carnet Requests records for Common Carnet Request
    /// </summary>
    [HttpPatch("{Id}/reexportCarnetRequests")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateReexportCarnetRequests(
        [FromRoute()] CommonCarnetRequestWhereUniqueInput uniqueId,
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
    /// Connect multiple Transit Carnet Requests records to Common Carnet Request
    /// </summary>
    [HttpPost("{Id}/transitCarnetRequests")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> ConnectTransitCarnetRequests(
        [FromRoute()] CommonCarnetRequestWhereUniqueInput uniqueId,
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
    /// Disconnect multiple Transit Carnet Requests records from Common Carnet Request
    /// </summary>
    [HttpDelete("{Id}/transitCarnetRequests")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DisconnectTransitCarnetRequests(
        [FromRoute()] CommonCarnetRequestWhereUniqueInput uniqueId,
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
    /// Find multiple Transit Carnet Requests records for Common Carnet Request
    /// </summary>
    [HttpGet("{Id}/transitCarnetRequests")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<TransitCarnetRequest>>> FindTransitCarnetRequests(
        [FromRoute()] CommonCarnetRequestWhereUniqueInput uniqueId,
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
    /// Update multiple Transit Carnet Requests records for Common Carnet Request
    /// </summary>
    [HttpPatch("{Id}/transitCarnetRequests")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateTransitCarnetRequests(
        [FromRoute()] CommonCarnetRequestWhereUniqueInput uniqueId,
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
