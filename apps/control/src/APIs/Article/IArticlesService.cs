using Control.APIs.Common;
using Control.APIs.Dtos;

namespace Control.APIs;

public interface IArticlesService
{
    /// <summary>
    /// Create one Article
    /// </summary>
    public Task<Article> CreateArticle(ArticleCreateInput article);

    /// <summary>
    /// Delete one Article
    /// </summary>
    public Task DeleteArticle(ArticleWhereUniqueInput uniqueId);

    /// <summary>
    /// Find many Articles of the Detailed Declaration
    /// </summary>
    public Task<List<Article>> Articles(ArticleFindManyArgs findManyArgs);

    /// <summary>
    /// Meta data about Article records
    /// </summary>
    public Task<MetadataDto> ArticlesMeta(ArticleFindManyArgs findManyArgs);

    /// <summary>
    /// Get one Article
    /// </summary>
    public Task<Article> Article(ArticleWhereUniqueInput uniqueId);

    /// <summary>
    /// Update one Article
    /// </summary>
    public Task UpdateArticle(ArticleWhereUniqueInput uniqueId, ArticleUpdateInput updateDto);

    /// <summary>
    /// Connect multiple Article Assessments records to Article
    /// </summary>
    public Task ConnectArticleAssessments(
        ArticleWhereUniqueInput uniqueId,
        ArticleAssessmentWhereUniqueInput[] articleAssessmentsId
    );

    /// <summary>
    /// Disconnect multiple Article Assessments records from Article
    /// </summary>
    public Task DisconnectArticleAssessments(
        ArticleWhereUniqueInput uniqueId,
        ArticleAssessmentWhereUniqueInput[] articleAssessmentsId
    );

    /// <summary>
    /// Find multiple Article Assessments records for Article
    /// </summary>
    public Task<List<ArticleAssessment>> FindArticleAssessments(
        ArticleWhereUniqueInput uniqueId,
        ArticleAssessmentFindManyArgs ArticleAssessmentFindManyArgs
    );

    /// <summary>
    /// Update multiple Article Assessments records for Article
    /// </summary>
    public Task UpdateArticleAssessments(
        ArticleWhereUniqueInput uniqueId,
        ArticleAssessmentWhereUniqueInput[] articleAssessmentsId
    );

    /// <summary>
    /// Get a COMMON DETAILED DECLARATION record for ARTICLE OF THE DETAILED DECLARATION (CUSTOMS)
    /// </summary>
    public Task<CommonDetailedDeclaration> GetCommonDetailedDeclaration(
        ArticleWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Connect multiple Sample Requests records to Article
    /// </summary>
    public Task ConnectSampleRequests(
        ArticleWhereUniqueInput uniqueId,
        SampleRequestWhereUniqueInput[] sampleRequestsId
    );

    /// <summary>
    /// Disconnect multiple Sample Requests records from Article
    /// </summary>
    public Task DisconnectSampleRequests(
        ArticleWhereUniqueInput uniqueId,
        SampleRequestWhereUniqueInput[] sampleRequestsId
    );

    /// <summary>
    /// Find multiple Sample Requests records for Article
    /// </summary>
    public Task<List<SampleRequest>> FindSampleRequests(
        ArticleWhereUniqueInput uniqueId,
        SampleRequestFindManyArgs SampleRequestFindManyArgs
    );

    /// <summary>
    /// Update multiple Sample Requests records for Article
    /// </summary>
    public Task UpdateSampleRequests(
        ArticleWhereUniqueInput uniqueId,
        SampleRequestWhereUniqueInput[] sampleRequestsId
    );

    /// <summary>
    /// Get a Tax record for Article
    /// </summary>
    public Task<DetailedDeclarationTax> GetTax(ArticleWhereUniqueInput uniqueId);
}
