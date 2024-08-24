using Control.APIs.Common;
using Control.APIs.Dtos;

namespace Control.APIs;

public interface IArticleAssessmentsService
{
    /// <summary>
    /// Create one Article Assessment
    /// </summary>
    public Task<ArticleAssessment> CreateArticleAssessment(
        ArticleAssessmentCreateInput articleassessment
    );

    /// <summary>
    /// Delete one Article Assessment
    /// </summary>
    public Task DeleteArticleAssessment(ArticleAssessmentWhereUniqueInput uniqueId);

    /// <summary>
    /// Find many Assessment Articles
    /// </summary>
    public Task<List<ArticleAssessment>> ArticleAssessments(
        ArticleAssessmentFindManyArgs findManyArgs
    );

    /// <summary>
    /// Meta data about Article Assessment records
    /// </summary>
    public Task<MetadataDto> ArticleAssessmentsMeta(ArticleAssessmentFindManyArgs findManyArgs);

    /// <summary>
    /// Get one Article Assessment
    /// </summary>
    public Task<ArticleAssessment> ArticleAssessment(ArticleAssessmentWhereUniqueInput uniqueId);

    /// <summary>
    /// Update one Article Assessment
    /// </summary>
    public Task UpdateArticleAssessment(
        ArticleAssessmentWhereUniqueInput uniqueId,
        ArticleAssessmentUpdateInput updateDto
    );

    /// <summary>
    /// Get a Article record for Article Assessment
    /// </summary>
    public Task<Article> GetArticle(ArticleAssessmentWhereUniqueInput uniqueId);

    /// <summary>
    /// Get a COMMON DETAILED DECLARATION (CUSTOMS) VALUE ASSESSMENT record for Assessment Article
    /// </summary>
    public Task<ValueAssessment> GetValueAssessment(ArticleAssessmentWhereUniqueInput uniqueId);
}
