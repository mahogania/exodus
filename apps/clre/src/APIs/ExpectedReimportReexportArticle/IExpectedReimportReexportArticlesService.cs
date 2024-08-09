using Clre.APIs.Common;
using Clre.APIs.Dtos;

namespace Clre.APIs;

public interface IExpectedReimportReexportArticlesService
{
    /// <summary>
    /// Create one EXPECTED REIMPORT/REEXPORT ARTICLE
    /// </summary>
    public Task<ExpectedReimportReexportArticle> CreateExpectedReimportReexportArticle(
        ExpectedReimportReexportArticleCreateInput expectedreimportreexportarticle
    );

    /// <summary>
    /// Delete one EXPECTED REIMPORT/REEXPORT ARTICLE
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
    /// Meta data about EXPECTED REIMPORT/REEXPORT ARTICLE records
    /// </summary>
    public Task<MetadataDto> ExpectedReimportReexportArticlesMeta(
        ExpectedReimportReexportArticleFindManyArgs findManyArgs
    );

    /// <summary>
    /// Get one EXPECTED REIMPORT/REEXPORT ARTICLE
    /// </summary>
    public Task<ExpectedReimportReexportArticle> ExpectedReimportReexportArticle(
        ExpectedReimportReexportArticleWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Update one EXPECTED REIMPORT/REEXPORT ARTICLE
    /// </summary>
    public Task UpdateExpectedReimportReexportArticle(
        ExpectedReimportReexportArticleWhereUniqueInput uniqueId,
        ExpectedReimportReexportArticleUpdateInput updateDto
    );
}
