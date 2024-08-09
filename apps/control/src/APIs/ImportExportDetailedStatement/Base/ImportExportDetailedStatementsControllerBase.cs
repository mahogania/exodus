using Clre.APIs;
using Clre.APIs.Common;
using Clre.APIs.Dtos;
using Clre.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Clre.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class ImportExportDetailedStatementsControllerBase : ControllerBase
{
    protected readonly IImportExportDetailedStatementsService _service;

    public ImportExportDetailedStatementsControllerBase(
        IImportExportDetailedStatementsService service
    )
    {
        _service = service;
    }

    /// <summary>
    /// Create one IMPORT/EXPORT DETAILED STATEMENT
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<ImportExportDetailedStatement>
    > CreateImportExportDetailedStatement(ImportExportDetailedStatementCreateInput input)
    {
        var importExportDetailedStatement = await _service.CreateImportExportDetailedStatement(
            input
        );

        return CreatedAtAction(
            nameof(ImportExportDetailedStatement),
            new { id = importExportDetailedStatement.Id },
            importExportDetailedStatement
        );
    }

    /// <summary>
    /// Delete one IMPORT/EXPORT DETAILED STATEMENT
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteImportExportDetailedStatement(
        [FromRoute()] ImportExportDetailedStatementWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteImportExportDetailedStatement(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many IMPORT/EXPORT DETAILED STATEMENTS
    /// </summary>
    [HttpGet()]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<List<ImportExportDetailedStatement>>
    > ImportExportDetailedStatements([FromQuery()] ImportExportDetailedStatementFindManyArgs filter)
    {
        return Ok(await _service.ImportExportDetailedStatements(filter));
    }

    /// <summary>
    /// Meta data about IMPORT/EXPORT DETAILED STATEMENT records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> ImportExportDetailedStatementsMeta(
        [FromQuery()] ImportExportDetailedStatementFindManyArgs filter
    )
    {
        return Ok(await _service.ImportExportDetailedStatementsMeta(filter));
    }

    /// <summary>
    /// Get one IMPORT/EXPORT DETAILED STATEMENT
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<ImportExportDetailedStatement>> ImportExportDetailedStatement(
        [FromRoute()] ImportExportDetailedStatementWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.ImportExportDetailedStatement(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one IMPORT/EXPORT DETAILED STATEMENT
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateImportExportDetailedStatement(
        [FromRoute()] ImportExportDetailedStatementWhereUniqueInput uniqueId,
        [FromQuery()]
            ImportExportDetailedStatementUpdateInput importExportDetailedStatementUpdateDto
    )
    {
        try
        {
            await _service.UpdateImportExportDetailedStatement(
                uniqueId,
                importExportDetailedStatementUpdateDto
            );
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
