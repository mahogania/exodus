using Control.APIs.Common;
using Control.APIs.Dtos;

namespace Control.APIs;

public interface IExpectedReimportReexportArticlesService
{
    /// <summary>
    /// Create one Expected Reimport Reexport Article
    /// </summary>
    public Task<ExpectedReimportReexportArticle> CreateExpectedReimportReexportArticle(
        ExpectedReimportReexportArticleCreateInput expectedreimportreexportarticle
    );

    /// <summary>
    /// Delete one Expected Reimport Reexport Article
    /// </summary>
    public Task DeleteExpectedReimportReexportArticle(
        ExpectedReimportReexportArticleWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Find many EXPECTED REIMPORT/REEXPORT ARTICLES
    /// </summary>
    public Task<List<ExpectedReimportReexportArticle>> ExpectedReimportReexportArticles(
        ExpectedReimportReexportArticleFindManyArgs findManyArgs
    );

    /// <summary>
    /// Meta data about Expected Reimport Reexport Article records
    /// </summary>
    public Task<MetadataDto> ExpectedReimportReexportArticlesMeta(
        ExpectedReimportReexportArticleFindManyArgs findManyArgs
    );

    /// <summary>
    /// Get one Expected Reimport Reexport Article
    /// </summary>
    public Task<ExpectedReimportReexportArticle> ExpectedReimportReexportArticle(
        ExpectedReimportReexportArticleWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Update one Expected Reimport Reexport Article
    /// </summary>
    public Task UpdateExpectedReimportReexportArticle(
        ExpectedReimportReexportArticleWhereUniqueInput uniqueId,
        ExpectedReimportReexportArticleUpdateInput updateDto
    );

    /// <summary>
    /// Get a COMMON DETAILED DECLARATIONS record for EXPECTED REIMPORT/REEXPORT ARTICLE
    /// </summary>
    public Task<CommonDetailedDeclaration> GetCommonDetailedDeclarations(
        ExpectedReimportReexportArticleWhereUniqueInput uniqueId
    );
}
