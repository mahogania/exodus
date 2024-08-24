using Control.APIs.Common;
using Control.APIs.Dtos;

namespace Control.APIs;

public interface ICommonDetailedDeclarationsService
{
    /// <summary>
    /// Create one Common Detailed Declaration
    /// </summary>
    public Task<CommonDetailedDeclaration> CreateCommonDetailedDeclaration(
        CommonDetailedDeclarationCreateInput commondetaileddeclaration
    );

    /// <summary>
    /// Delete one Common Detailed Declaration
    /// </summary>
    public Task DeleteCommonDetailedDeclaration(CommonDetailedDeclarationWhereUniqueInput uniqueId);

    /// <summary>
    /// Find many COMMON DETAILED DECLARATIONS
    /// </summary>
    public Task<List<CommonDetailedDeclaration>> CommonDetailedDeclarations(
        CommonDetailedDeclarationFindManyArgs findManyArgs
    );

    /// <summary>
    /// Meta data about Common Detailed Declaration records
    /// </summary>
    public Task<MetadataDto> CommonDetailedDeclarationsMeta(
        CommonDetailedDeclarationFindManyArgs findManyArgs
    );

    /// <summary>
    /// Get one Common Detailed Declaration
    /// </summary>
    public Task<CommonDetailedDeclaration> CommonDetailedDeclaration(
        CommonDetailedDeclarationWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Update one Common Detailed Declaration
    /// </summary>
    public Task UpdateCommonDetailedDeclaration(
        CommonDetailedDeclarationWhereUniqueInput uniqueId,
        CommonDetailedDeclarationUpdateInput updateDto
    );

    /// <summary>
    /// Connect multiple Articles Expected for Re Import/Export records to COMMON DETAILED DECLARATION
    /// </summary>
    public Task ConnectArticlesExpectedForReImportExport(
        CommonDetailedDeclarationWhereUniqueInput uniqueId,
        ExpectedReimportReexportArticleWhereUniqueInput[] expectedReimportReexportArticlesId
    );

    /// <summary>
    /// Disconnect multiple Articles Expected for Re Import/Export records from COMMON DETAILED DECLARATION
    /// </summary>
    public Task DisconnectArticlesExpectedForReImportExport(
        CommonDetailedDeclarationWhereUniqueInput uniqueId,
        ExpectedReimportReexportArticleWhereUniqueInput[] expectedReimportReexportArticlesId
    );

    /// <summary>
    /// Find multiple Articles Expected for Re Import/Export records for COMMON DETAILED DECLARATION
    /// </summary>
    public Task<List<ExpectedReimportReexportArticle>> FindArticlesExpectedForReImportExport(
        CommonDetailedDeclarationWhereUniqueInput uniqueId,
        ExpectedReimportReexportArticleFindManyArgs ExpectedReimportReexportArticleFindManyArgs
    );

    /// <summary>
    /// Update multiple Articles Expected for Re Import/Export records for COMMON DETAILED DECLARATION
    /// </summary>
    public Task UpdateArticlesExpectedForReImportExport(
        CommonDetailedDeclarationWhereUniqueInput uniqueId,
        ExpectedReimportReexportArticleWhereUniqueInput[] expectedReimportReexportArticlesId
    );
}
