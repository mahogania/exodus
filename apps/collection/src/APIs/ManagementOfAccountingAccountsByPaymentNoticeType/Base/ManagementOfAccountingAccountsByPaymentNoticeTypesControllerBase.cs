using Collection.APIs;
using Collection.APIs.Common;
using Collection.APIs.Dtos;
using Collection.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Collection.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class ManagementOfAccountingAccountsByPaymentNoticeTypesControllerBase
    : ControllerBase
{
    protected readonly IManagementOfAccountingAccountsByPaymentNoticeTypesService _service;

    public ManagementOfAccountingAccountsByPaymentNoticeTypesControllerBase(
        IManagementOfAccountingAccountsByPaymentNoticeTypesService service
    )
    {
        _service = service;
    }

    /// <summary>
    /// Create one MANAGEMENT OF ACCOUNTING ACCOUNTS BY PAYMENT NOTICE TYPE
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<ManagementOfAccountingAccountsByPaymentNoticeType>
    > CreateManagementOfAccountingAccountsByPaymentNoticeType(
        ManagementOfAccountingAccountsByPaymentNoticeTypeCreateInput input
    )
    {
        var managementOfAccountingAccountsByPaymentNoticeType =
            await _service.CreateManagementOfAccountingAccountsByPaymentNoticeType(input);

        return CreatedAtAction(
            nameof(ManagementOfAccountingAccountsByPaymentNoticeType),
            new { id = managementOfAccountingAccountsByPaymentNoticeType.Id },
            managementOfAccountingAccountsByPaymentNoticeType
        );
    }

    /// <summary>
    /// Delete one MANAGEMENT OF ACCOUNTING ACCOUNTS BY PAYMENT NOTICE TYPE
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteManagementOfAccountingAccountsByPaymentNoticeType(
        [FromRoute()] ManagementOfAccountingAccountsByPaymentNoticeTypeWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteManagementOfAccountingAccountsByPaymentNoticeType(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many MANAGEMENT OF ACCOUNTING ACCOUNTS BY PAYMENT NOTICE TYPES
    /// </summary>
    [HttpGet()]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<List<ManagementOfAccountingAccountsByPaymentNoticeType>>
    > ManagementOfAccountingAccountsByPaymentNoticeTypes(
        [FromQuery()] ManagementOfAccountingAccountsByPaymentNoticeTypeFindManyArgs filter
    )
    {
        return Ok(await _service.ManagementOfAccountingAccountsByPaymentNoticeTypes(filter));
    }

    /// <summary>
    /// Meta data about MANAGEMENT OF ACCOUNTING ACCOUNTS BY PAYMENT NOTICE TYPE records
    /// </summary>
    [HttpPost("meta")]
    public async Task<
        ActionResult<MetadataDto>
    > ManagementOfAccountingAccountsByPaymentNoticeTypesMeta(
        [FromQuery()] ManagementOfAccountingAccountsByPaymentNoticeTypeFindManyArgs filter
    )
    {
        return Ok(await _service.ManagementOfAccountingAccountsByPaymentNoticeTypesMeta(filter));
    }

    /// <summary>
    /// Get one MANAGEMENT OF ACCOUNTING ACCOUNTS BY PAYMENT NOTICE TYPE
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<ManagementOfAccountingAccountsByPaymentNoticeType>
    > ManagementOfAccountingAccountsByPaymentNoticeType(
        [FromRoute()] ManagementOfAccountingAccountsByPaymentNoticeTypeWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.ManagementOfAccountingAccountsByPaymentNoticeType(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one MANAGEMENT OF ACCOUNTING ACCOUNTS BY PAYMENT NOTICE TYPE
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateManagementOfAccountingAccountsByPaymentNoticeType(
        [FromRoute()] ManagementOfAccountingAccountsByPaymentNoticeTypeWhereUniqueInput uniqueId,
        [FromQuery()]
            ManagementOfAccountingAccountsByPaymentNoticeTypeUpdateInput managementOfAccountingAccountsByPaymentNoticeTypeUpdateDto
    )
    {
        try
        {
            await _service.UpdateManagementOfAccountingAccountsByPaymentNoticeType(
                uniqueId,
                managementOfAccountingAccountsByPaymentNoticeTypeUpdateDto
            );
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
