using Control.APIs;
using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class ProceduresControllerBase : ControllerBase
{
    protected readonly IProceduresService _service;

    public ProceduresControllerBase(IProceduresService service)
    {
        _service = service;
    }

    /// <summary>
    /// Create one Procedure
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<Procedure>> CreateProcedure(ProcedureCreateInput input)
    {
        var procedure = await _service.CreateProcedure(input);

        return CreatedAtAction(nameof(Procedure), new { id = procedure.Id }, procedure);
    }

    /// <summary>
    /// Delete one Procedure
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteProcedure(
        [FromRoute()] ProcedureWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteProcedure(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many Procedures
    /// </summary>
    [HttpGet()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<Procedure>>> Procedures(
        [FromQuery()] ProcedureFindManyArgs filter
    )
    {
        return Ok(await _service.Procedures(filter));
    }

    /// <summary>
    /// Meta data about Procedure records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> ProceduresMeta(
        [FromQuery()] ProcedureFindManyArgs filter
    )
    {
        return Ok(await _service.ProceduresMeta(filter));
    }

    /// <summary>
    /// Get one Procedure
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<Procedure>> Procedure(
        [FromRoute()] ProcedureWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.Procedure(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one Procedure
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateProcedure(
        [FromRoute()] ProcedureWhereUniqueInput uniqueId,
        [FromQuery()] ProcedureUpdateInput procedureUpdateDto
    )
    {
        try
        {
            await _service.UpdateProcedure(uniqueId, procedureUpdateDto);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Connect multiple Analysis Requests records to Procedure
    /// </summary>
    [HttpPost("{Id}/analysisRequests")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> ConnectAnalysisRequests(
        [FromRoute()] ProcedureWhereUniqueInput uniqueId,
        [FromQuery()] AnalysisRequestWhereUniqueInput[] analysisRequestsId
    )
    {
        try
        {
            await _service.ConnectAnalysisRequests(uniqueId, analysisRequestsId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Disconnect multiple Analysis Requests records from Procedure
    /// </summary>
    [HttpDelete("{Id}/analysisRequests")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DisconnectAnalysisRequests(
        [FromRoute()] ProcedureWhereUniqueInput uniqueId,
        [FromBody()] AnalysisRequestWhereUniqueInput[] analysisRequestsId
    )
    {
        try
        {
            await _service.DisconnectAnalysisRequests(uniqueId, analysisRequestsId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find multiple Analysis Requests records for Procedure
    /// </summary>
    [HttpGet("{Id}/analysisRequests")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<AnalysisRequest>>> FindAnalysisRequests(
        [FromRoute()] ProcedureWhereUniqueInput uniqueId,
        [FromQuery()] AnalysisRequestFindManyArgs filter
    )
    {
        try
        {
            return Ok(await _service.FindAnalysisRequests(uniqueId, filter));
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update multiple Analysis Requests records for Procedure
    /// </summary>
    [HttpPatch("{Id}/analysisRequests")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateAnalysisRequests(
        [FromRoute()] ProcedureWhereUniqueInput uniqueId,
        [FromBody()] AnalysisRequestWhereUniqueInput[] analysisRequestsId
    )
    {
        try
        {
            await _service.UpdateAnalysisRequests(uniqueId, analysisRequestsId);
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
        [FromRoute()] ProcedureWhereUniqueInput uniqueId,
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
        [FromRoute()] ProcedureWhereUniqueInput uniqueId,
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
        [FromRoute()] ProcedureWhereUniqueInput uniqueId,
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
        [FromRoute()] ProcedureWhereUniqueInput uniqueId,
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
        [FromRoute()] ProcedureWhereUniqueInput uniqueId,
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
        [FromRoute()] ProcedureWhereUniqueInput uniqueId,
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
        [FromRoute()] ProcedureWhereUniqueInput uniqueId,
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
        [FromRoute()] ProcedureWhereUniqueInput uniqueId,
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
        [FromRoute()] ProcedureWhereUniqueInput uniqueId
    )
    {
        var commonDetailedDeclaration = await _service.GetCommonDetailedDeclaration(uniqueId);
        return Ok(commonDetailedDeclaration);
    }

    /// <summary>
    /// Connect multiple Common Express Clearances records to Procedure
    /// </summary>
    [HttpPost("{Id}/commonExpressClearances")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> ConnectCommonExpressClearances(
        [FromRoute()] ProcedureWhereUniqueInput uniqueId,
        [FromQuery()] CommonExpressClearanceWhereUniqueInput[] commonExpressClearancesId
    )
    {
        try
        {
            await _service.ConnectCommonExpressClearances(uniqueId, commonExpressClearancesId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Disconnect multiple Common Express Clearances records from Procedure
    /// </summary>
    [HttpDelete("{Id}/commonExpressClearances")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DisconnectCommonExpressClearances(
        [FromRoute()] ProcedureWhereUniqueInput uniqueId,
        [FromBody()] CommonExpressClearanceWhereUniqueInput[] commonExpressClearancesId
    )
    {
        try
        {
            await _service.DisconnectCommonExpressClearances(uniqueId, commonExpressClearancesId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find multiple Common Express Clearances records for Procedure
    /// </summary>
    [HttpGet("{Id}/commonExpressClearances")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<CommonExpressClearance>>> FindCommonExpressClearances(
        [FromRoute()] ProcedureWhereUniqueInput uniqueId,
        [FromQuery()] CommonExpressClearanceFindManyArgs filter
    )
    {
        try
        {
            return Ok(await _service.FindCommonExpressClearances(uniqueId, filter));
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update multiple Common Express Clearances records for Procedure
    /// </summary>
    [HttpPatch("{Id}/commonExpressClearances")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateCommonExpressClearances(
        [FromRoute()] ProcedureWhereUniqueInput uniqueId,
        [FromBody()] CommonExpressClearanceWhereUniqueInput[] commonExpressClearancesId
    )
    {
        try
        {
            await _service.UpdateCommonExpressClearances(uniqueId, commonExpressClearancesId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Connect multiple Common Origin Certificate Requests records to Request
    /// </summary>
    [HttpPost("{Id}/commonOriginCertificateRequests")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> ConnectCommonOriginCertificateRequests(
        [FromRoute()] ProcedureWhereUniqueInput uniqueId,
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
        [FromRoute()] ProcedureWhereUniqueInput uniqueId,
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
        [FromRoute()] ProcedureWhereUniqueInput uniqueId,
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
        [FromRoute()] ProcedureWhereUniqueInput uniqueId,
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
        [FromRoute()] ProcedureWhereUniqueInput uniqueId,
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
        [FromRoute()] ProcedureWhereUniqueInput uniqueId,
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
        [FromRoute()] ProcedureWhereUniqueInput uniqueId,
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
        [FromRoute()] ProcedureWhereUniqueInput uniqueId,
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
        [FromRoute()] ProcedureWhereUniqueInput uniqueId,
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
        [FromRoute()] ProcedureWhereUniqueInput uniqueId,
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
        [FromRoute()] ProcedureWhereUniqueInput uniqueId,
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
        [FromRoute()] ProcedureWhereUniqueInput uniqueId,
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
    /// Connect multiple Postal Goods Clearances records to Procedure
    /// </summary>
    [HttpPost("{Id}/postalGoodsClearances")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> ConnectPostalGoodsClearances(
        [FromRoute()] ProcedureWhereUniqueInput uniqueId,
        [FromQuery()] PostalGoodsClearanceWhereUniqueInput[] postalGoodsClearancesId
    )
    {
        try
        {
            await _service.ConnectPostalGoodsClearances(uniqueId, postalGoodsClearancesId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Disconnect multiple Postal Goods Clearances records from Procedure
    /// </summary>
    [HttpDelete("{Id}/postalGoodsClearances")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DisconnectPostalGoodsClearances(
        [FromRoute()] ProcedureWhereUniqueInput uniqueId,
        [FromBody()] PostalGoodsClearanceWhereUniqueInput[] postalGoodsClearancesId
    )
    {
        try
        {
            await _service.DisconnectPostalGoodsClearances(uniqueId, postalGoodsClearancesId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find multiple Postal Goods Clearances records for Procedure
    /// </summary>
    [HttpGet("{Id}/postalGoodsClearances")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<PostalGoodsClearance>>> FindPostalGoodsClearances(
        [FromRoute()] ProcedureWhereUniqueInput uniqueId,
        [FromQuery()] PostalGoodsClearanceFindManyArgs filter
    )
    {
        try
        {
            return Ok(await _service.FindPostalGoodsClearances(uniqueId, filter));
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update multiple Postal Goods Clearances records for Procedure
    /// </summary>
    [HttpPatch("{Id}/postalGoodsClearances")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdatePostalGoodsClearances(
        [FromRoute()] ProcedureWhereUniqueInput uniqueId,
        [FromBody()] PostalGoodsClearanceWhereUniqueInput[] postalGoodsClearancesId
    )
    {
        try
        {
            await _service.UpdatePostalGoodsClearances(uniqueId, postalGoodsClearancesId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Connect multiple Postal Parcel Simplified Clearances records to Procedure
    /// </summary>
    [HttpPost("{Id}/postalParcelSimplifiedClearances")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> ConnectPostalParcelSimplifiedClearances(
        [FromRoute()] ProcedureWhereUniqueInput uniqueId,
        [FromQuery()]
            PostalParcelSimplifiedClearanceWhereUniqueInput[] postalParcelSimplifiedClearancesId
    )
    {
        try
        {
            await _service.ConnectPostalParcelSimplifiedClearances(
                uniqueId,
                postalParcelSimplifiedClearancesId
            );
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Disconnect multiple Postal Parcel Simplified Clearances records from Procedure
    /// </summary>
    [HttpDelete("{Id}/postalParcelSimplifiedClearances")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DisconnectPostalParcelSimplifiedClearances(
        [FromRoute()] ProcedureWhereUniqueInput uniqueId,
        [FromBody()]
            PostalParcelSimplifiedClearanceWhereUniqueInput[] postalParcelSimplifiedClearancesId
    )
    {
        try
        {
            await _service.DisconnectPostalParcelSimplifiedClearances(
                uniqueId,
                postalParcelSimplifiedClearancesId
            );
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find multiple Postal Parcel Simplified Clearances records for Procedure
    /// </summary>
    [HttpGet("{Id}/postalParcelSimplifiedClearances")]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<List<PostalParcelSimplifiedClearance>>
    > FindPostalParcelSimplifiedClearances(
        [FromRoute()] ProcedureWhereUniqueInput uniqueId,
        [FromQuery()] PostalParcelSimplifiedClearanceFindManyArgs filter
    )
    {
        try
        {
            return Ok(await _service.FindPostalParcelSimplifiedClearances(uniqueId, filter));
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update multiple Postal Parcel Simplified Clearances records for Procedure
    /// </summary>
    [HttpPatch("{Id}/postalParcelSimplifiedClearances")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdatePostalParcelSimplifiedClearances(
        [FromRoute()] ProcedureWhereUniqueInput uniqueId,
        [FromBody()]
            PostalParcelSimplifiedClearanceWhereUniqueInput[] postalParcelSimplifiedClearancesId
    )
    {
        try
        {
            await _service.UpdatePostalParcelSimplifiedClearances(
                uniqueId,
                postalParcelSimplifiedClearancesId
            );
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
        [FromRoute()] ProcedureWhereUniqueInput uniqueId,
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
        [FromRoute()] ProcedureWhereUniqueInput uniqueId,
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
        [FromRoute()] ProcedureWhereUniqueInput uniqueId,
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
        [FromRoute()] ProcedureWhereUniqueInput uniqueId,
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
