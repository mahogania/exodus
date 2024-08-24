using Control.APIs;
using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class JournalsControllerBase : ControllerBase
{
    protected readonly IJournalsService _service;

    public JournalsControllerBase(IJournalsService service)
    {
        _service = service;
    }

    /// <summary>
    /// Create one Journal
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<Journal>> CreateJournal(JournalCreateInput input)
    {
        var journal = await _service.CreateJournal(input);

        return CreatedAtAction(nameof(Journal), new { id = journal.Id }, journal);
    }

    /// <summary>
    /// Delete one Journal
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteJournal([FromRoute()] JournalWhereUniqueInput uniqueId)
    {
        try
        {
            await _service.DeleteJournal(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many Requests
    /// </summary>
    [HttpGet()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<Journal>>> Journals(
        [FromQuery()] JournalFindManyArgs filter
    )
    {
        return Ok(await _service.Journals(filter));
    }

    /// <summary>
    /// Meta data about Journal records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> JournalsMeta(
        [FromQuery()] JournalFindManyArgs filter
    )
    {
        return Ok(await _service.JournalsMeta(filter));
    }

    /// <summary>
    /// Get one Journal
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<Journal>> Journal([FromRoute()] JournalWhereUniqueInput uniqueId)
    {
        try
        {
            return await _service.Journal(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one Journal
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateJournal(
        [FromRoute()] JournalWhereUniqueInput uniqueId,
        [FromQuery()] JournalUpdateInput journalUpdateDto
    )
    {
        try
        {
            await _service.UpdateJournal(uniqueId, journalUpdateDto);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Connect multiple Cancellation Requests records to Request
    /// </summary>
    [HttpPost("{Id}/cancellationRequests")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> ConnectCancellationRequests(
        [FromRoute()] JournalWhereUniqueInput uniqueId,
        [FromQuery()] CancellationRequestWhereUniqueInput[] cancellationRequestsId
    )
    {
        try
        {
            await _service.ConnectCancellationRequests(uniqueId, cancellationRequestsId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Disconnect multiple Cancellation Requests records from Request
    /// </summary>
    [HttpDelete("{Id}/cancellationRequests")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DisconnectCancellationRequests(
        [FromRoute()] JournalWhereUniqueInput uniqueId,
        [FromBody()] CancellationRequestWhereUniqueInput[] cancellationRequestsId
    )
    {
        try
        {
            await _service.DisconnectCancellationRequests(uniqueId, cancellationRequestsId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find multiple Cancellation Requests records for Request
    /// </summary>
    [HttpGet("{Id}/cancellationRequests")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<CancellationRequest>>> FindCancellationRequests(
        [FromRoute()] JournalWhereUniqueInput uniqueId,
        [FromQuery()] CancellationRequestFindManyArgs filter
    )
    {
        try
        {
            return Ok(await _service.FindCancellationRequests(uniqueId, filter));
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update multiple Cancellation Requests records for Request
    /// </summary>
    [HttpPatch("{Id}/cancellationRequests")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateCancellationRequests(
        [FromRoute()] JournalWhereUniqueInput uniqueId,
        [FromBody()] CancellationRequestWhereUniqueInput[] cancellationRequestsId
    )
    {
        try
        {
            await _service.UpdateCancellationRequests(uniqueId, cancellationRequestsId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Connect multiple Common Active Goods Requests records to Journal
    /// </summary>
    [HttpPost("{Id}/commonActiveGoodsRequests")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> ConnectCommonActiveGoodsRequests(
        [FromRoute()] JournalWhereUniqueInput uniqueId,
        [FromQuery()] CommonActiveGoodsRequestWhereUniqueInput[] commonActiveGoodsRequestsId
    )
    {
        try
        {
            await _service.ConnectCommonActiveGoodsRequests(uniqueId, commonActiveGoodsRequestsId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Disconnect multiple Common Active Goods Requests records from Journal
    /// </summary>
    [HttpDelete("{Id}/commonActiveGoodsRequests")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DisconnectCommonActiveGoodsRequests(
        [FromRoute()] JournalWhereUniqueInput uniqueId,
        [FromBody()] CommonActiveGoodsRequestWhereUniqueInput[] commonActiveGoodsRequestsId
    )
    {
        try
        {
            await _service.DisconnectCommonActiveGoodsRequests(
                uniqueId,
                commonActiveGoodsRequestsId
            );
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find multiple Common Active Goods Requests records for Journal
    /// </summary>
    [HttpGet("{Id}/commonActiveGoodsRequests")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<CommonActiveGoodsRequest>>> FindCommonActiveGoodsRequests(
        [FromRoute()] JournalWhereUniqueInput uniqueId,
        [FromQuery()] CommonActiveGoodsRequestFindManyArgs filter
    )
    {
        try
        {
            return Ok(await _service.FindCommonActiveGoodsRequests(uniqueId, filter));
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update multiple Common Active Goods Requests records for Journal
    /// </summary>
    [HttpPatch("{Id}/commonActiveGoodsRequests")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateCommonActiveGoodsRequests(
        [FromRoute()] JournalWhereUniqueInput uniqueId,
        [FromBody()] CommonActiveGoodsRequestWhereUniqueInput[] commonActiveGoodsRequestsId
    )
    {
        try
        {
            await _service.UpdateCommonActiveGoodsRequests(uniqueId, commonActiveGoodsRequestsId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Get a Common Detailed Declaration record for Request
    /// </summary>
    [HttpGet("{Id}/commonDetailedDeclarations")]
    public async Task<ActionResult<List<CommonDetailedDeclaration>>> GetCommonDetailedDeclaration(
        [FromRoute()] JournalWhereUniqueInput uniqueId
    )
    {
        var commonDetailedDeclaration = await _service.GetCommonDetailedDeclaration(uniqueId);
        return Ok(commonDetailedDeclaration);
    }

    /// <summary>
    /// Connect multiple Common Origin Certificate Requests records to Request
    /// </summary>
    [HttpPost("{Id}/commonOriginCertificateRequests")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> ConnectCommonOriginCertificateRequests(
        [FromRoute()] JournalWhereUniqueInput uniqueId,
        [FromQuery()]
            CommonOriginCertificateRequestWhereUniqueInput[] commonOriginCertificateRequestsId
    )
    {
        try
        {
            await _service.ConnectCommonOriginCertificateRequests(
                uniqueId,
                commonOriginCertificateRequestsId
            );
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Disconnect multiple Common Origin Certificate Requests records from Request
    /// </summary>
    [HttpDelete("{Id}/commonOriginCertificateRequests")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DisconnectCommonOriginCertificateRequests(
        [FromRoute()] JournalWhereUniqueInput uniqueId,
        [FromBody()]
            CommonOriginCertificateRequestWhereUniqueInput[] commonOriginCertificateRequestsId
    )
    {
        try
        {
            await _service.DisconnectCommonOriginCertificateRequests(
                uniqueId,
                commonOriginCertificateRequestsId
            );
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find multiple Common Origin Certificate Requests records for Request
    /// </summary>
    [HttpGet("{Id}/commonOriginCertificateRequests")]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<List<CommonOriginCertificateRequest>>
    > FindCommonOriginCertificateRequests(
        [FromRoute()] JournalWhereUniqueInput uniqueId,
        [FromQuery()] CommonOriginCertificateRequestFindManyArgs filter
    )
    {
        try
        {
            return Ok(await _service.FindCommonOriginCertificateRequests(uniqueId, filter));
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update multiple Common Origin Certificate Requests records for Request
    /// </summary>
    [HttpPatch("{Id}/commonOriginCertificateRequests")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateCommonOriginCertificateRequests(
        [FromRoute()] JournalWhereUniqueInput uniqueId,
        [FromBody()]
            CommonOriginCertificateRequestWhereUniqueInput[] commonOriginCertificateRequestsId
    )
    {
        try
        {
            await _service.UpdateCommonOriginCertificateRequests(
                uniqueId,
                commonOriginCertificateRequestsId
            );
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Connect multiple Common Regime Requests records to Journal
    /// </summary>
    [HttpPost("{Id}/commonRegimeRequests")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> ConnectCommonRegimeRequests(
        [FromRoute()] JournalWhereUniqueInput uniqueId,
        [FromQuery()] CommonRegimeRequestWhereUniqueInput[] commonRegimeRequestsId
    )
    {
        try
        {
            await _service.ConnectCommonRegimeRequests(uniqueId, commonRegimeRequestsId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Disconnect multiple Common Regime Requests records from Journal
    /// </summary>
    [HttpDelete("{Id}/commonRegimeRequests")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DisconnectCommonRegimeRequests(
        [FromRoute()] JournalWhereUniqueInput uniqueId,
        [FromBody()] CommonRegimeRequestWhereUniqueInput[] commonRegimeRequestsId
    )
    {
        try
        {
            await _service.DisconnectCommonRegimeRequests(uniqueId, commonRegimeRequestsId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find multiple Common Regime Requests records for Journal
    /// </summary>
    [HttpGet("{Id}/commonRegimeRequests")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<CommonRegimeRequest>>> FindCommonRegimeRequests(
        [FromRoute()] JournalWhereUniqueInput uniqueId,
        [FromQuery()] CommonRegimeRequestFindManyArgs filter
    )
    {
        try
        {
            return Ok(await _service.FindCommonRegimeRequests(uniqueId, filter));
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update multiple Common Regime Requests records for Journal
    /// </summary>
    [HttpPatch("{Id}/commonRegimeRequests")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateCommonRegimeRequests(
        [FromRoute()] JournalWhereUniqueInput uniqueId,
        [FromBody()] CommonRegimeRequestWhereUniqueInput[] commonRegimeRequestsId
    )
    {
        try
        {
            await _service.UpdateCommonRegimeRequests(uniqueId, commonRegimeRequestsId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Connect multiple Foreign Operator Requests records to Request
    /// </summary>
    [HttpPost("{Id}/foreignOperatorRequests")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> ConnectForeignOperatorRequests(
        [FromRoute()] JournalWhereUniqueInput uniqueId,
        [FromQuery()] ForeignOperatorRequestWhereUniqueInput[] foreignOperatorRequestsId
    )
    {
        try
        {
            await _service.ConnectForeignOperatorRequests(uniqueId, foreignOperatorRequestsId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Disconnect multiple Foreign Operator Requests records from Request
    /// </summary>
    [HttpDelete("{Id}/foreignOperatorRequests")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DisconnectForeignOperatorRequests(
        [FromRoute()] JournalWhereUniqueInput uniqueId,
        [FromBody()] ForeignOperatorRequestWhereUniqueInput[] foreignOperatorRequestsId
    )
    {
        try
        {
            await _service.DisconnectForeignOperatorRequests(uniqueId, foreignOperatorRequestsId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find multiple Foreign Operator Requests records for Request
    /// </summary>
    [HttpGet("{Id}/foreignOperatorRequests")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<ForeignOperatorRequest>>> FindForeignOperatorRequests(
        [FromRoute()] JournalWhereUniqueInput uniqueId,
        [FromQuery()] ForeignOperatorRequestFindManyArgs filter
    )
    {
        try
        {
            return Ok(await _service.FindForeignOperatorRequests(uniqueId, filter));
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update multiple Foreign Operator Requests records for Request
    /// </summary>
    [HttpPatch("{Id}/foreignOperatorRequests")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateForeignOperatorRequests(
        [FromRoute()] JournalWhereUniqueInput uniqueId,
        [FromBody()] ForeignOperatorRequestWhereUniqueInput[] foreignOperatorRequestsId
    )
    {
        try
        {
            await _service.UpdateForeignOperatorRequests(uniqueId, foreignOperatorRequestsId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Connect multiple Recourse Requests records to Journal
    /// </summary>
    [HttpPost("{Id}/recourseRequests")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> ConnectRecourseRequests(
        [FromRoute()] JournalWhereUniqueInput uniqueId,
        [FromQuery()] RecourseRequestWhereUniqueInput[] recourseRequestsId
    )
    {
        try
        {
            await _service.ConnectRecourseRequests(uniqueId, recourseRequestsId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Disconnect multiple Recourse Requests records from Journal
    /// </summary>
    [HttpDelete("{Id}/recourseRequests")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DisconnectRecourseRequests(
        [FromRoute()] JournalWhereUniqueInput uniqueId,
        [FromBody()] RecourseRequestWhereUniqueInput[] recourseRequestsId
    )
    {
        try
        {
            await _service.DisconnectRecourseRequests(uniqueId, recourseRequestsId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find multiple Recourse Requests records for Journal
    /// </summary>
    [HttpGet("{Id}/recourseRequests")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<RecourseRequest>>> FindRecourseRequests(
        [FromRoute()] JournalWhereUniqueInput uniqueId,
        [FromQuery()] RecourseRequestFindManyArgs filter
    )
    {
        try
        {
            return Ok(await _service.FindRecourseRequests(uniqueId, filter));
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update multiple Recourse Requests records for Journal
    /// </summary>
    [HttpPatch("{Id}/recourseRequests")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateRecourseRequests(
        [FromRoute()] JournalWhereUniqueInput uniqueId,
        [FromBody()] RecourseRequestWhereUniqueInput[] recourseRequestsId
    )
    {
        try
        {
            await _service.UpdateRecourseRequests(uniqueId, recourseRequestsId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
