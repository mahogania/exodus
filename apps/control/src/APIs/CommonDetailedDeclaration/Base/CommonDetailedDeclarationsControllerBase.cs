using Control.APIs;
using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class CommonDetailedDeclarationsControllerBase : ControllerBase
{
    protected readonly ICommonDetailedDeclarationsService _service;

    public CommonDetailedDeclarationsControllerBase(ICommonDetailedDeclarationsService service)
    {
        _service = service;
    }

    /// <summary>
    /// Create one Common Detailed Declaration
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<CommonDetailedDeclaration>> CreateCommonDetailedDeclaration(
        CommonDetailedDeclarationCreateInput input
    )
    {
        var commonDetailedDeclaration = await _service.CreateCommonDetailedDeclaration(input);

        return CreatedAtAction(
            nameof(CommonDetailedDeclaration),
            new { id = commonDetailedDeclaration.Id },
            commonDetailedDeclaration
        );
    }

    /// <summary>
    /// Delete one Common Detailed Declaration
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteCommonDetailedDeclaration(
        [FromRoute()] CommonDetailedDeclarationWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteCommonDetailedDeclaration(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many COMMON DETAILED DECLARATIONS
    /// </summary>
    [HttpGet()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<CommonDetailedDeclaration>>> CommonDetailedDeclarations(
        [FromQuery()] CommonDetailedDeclarationFindManyArgs filter
    )
    {
        return Ok(await _service.CommonDetailedDeclarations(filter));
    }

    /// <summary>
    /// Meta data about Common Detailed Declaration records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> CommonDetailedDeclarationsMeta(
        [FromQuery()] CommonDetailedDeclarationFindManyArgs filter
    )
    {
        return Ok(await _service.CommonDetailedDeclarationsMeta(filter));
    }

    /// <summary>
    /// Get one Common Detailed Declaration
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<CommonDetailedDeclaration>> CommonDetailedDeclaration(
        [FromRoute()] CommonDetailedDeclarationWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.CommonDetailedDeclaration(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one Common Detailed Declaration
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateCommonDetailedDeclaration(
        [FromRoute()] CommonDetailedDeclarationWhereUniqueInput uniqueId,
        [FromQuery()] CommonDetailedDeclarationUpdateInput commonDetailedDeclarationUpdateDto
    )
    {
        try
        {
            await _service.UpdateCommonDetailedDeclaration(
                uniqueId,
                commonDetailedDeclarationUpdateDto
            );
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Connect multiple Articles Expected for Re Import/Export records to COMMON DETAILED DECLARATION
    /// </summary>
    [HttpPost("{Id}/expectedReimportReexportArticles")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> ConnectArticlesExpectedForReImportExport(
        [FromRoute()] CommonDetailedDeclarationWhereUniqueInput uniqueId,
        [FromQuery()]
            ExpectedReimportReexportArticleWhereUniqueInput[] expectedReimportReexportArticlesId
    )
    {
        try
        {
            await _service.ConnectArticlesExpectedForReImportExport(
                uniqueId,
                expectedReimportReexportArticlesId
            );
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Disconnect multiple Articles Expected for Re Import/Export records from COMMON DETAILED DECLARATION
    /// </summary>
    [HttpDelete("{Id}/expectedReimportReexportArticles")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DisconnectArticlesExpectedForReImportExport(
        [FromRoute()] CommonDetailedDeclarationWhereUniqueInput uniqueId,
        [FromBody()]
            ExpectedReimportReexportArticleWhereUniqueInput[] expectedReimportReexportArticlesId
    )
    {
        try
        {
            await _service.DisconnectArticlesExpectedForReImportExport(
                uniqueId,
                expectedReimportReexportArticlesId
            );
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find multiple Articles Expected for Re Import/Export records for COMMON DETAILED DECLARATION
    /// </summary>
    [HttpGet("{Id}/expectedReimportReexportArticles")]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<List<ExpectedReimportReexportArticle>>
    > FindArticlesExpectedForReImportExport(
        [FromRoute()] CommonDetailedDeclarationWhereUniqueInput uniqueId,
        [FromQuery()] ExpectedReimportReexportArticleFindManyArgs filter
    )
    {
        try
        {
            return Ok(await _service.FindArticlesExpectedForReImportExport(uniqueId, filter));
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update multiple Articles Expected for Re Import/Export records for COMMON DETAILED DECLARATION
    /// </summary>
    [HttpPatch("{Id}/expectedReimportReexportArticles")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateArticlesExpectedForReImportExport(
        [FromRoute()] CommonDetailedDeclarationWhereUniqueInput uniqueId,
        [FromBody()]
            ExpectedReimportReexportArticleWhereUniqueInput[] expectedReimportReexportArticlesId
    )
    {
        try
        {
            await _service.UpdateArticlesExpectedForReImportExport(
                uniqueId,
                expectedReimportReexportArticlesId
            );
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Get a Journal record for Common Detailed Declaration
    /// </summary>
    [HttpGet("{Id}/procedures")]
    public async Task<ActionResult<List<Procedure>>> GetJournal(
        [FromRoute()] CommonDetailedDeclarationWhereUniqueInput uniqueId
    )
    {
        var procedure = await _service.GetJournal(uniqueId);
        return Ok(procedure);
    }
}
