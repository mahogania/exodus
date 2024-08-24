using Control.APIs.Common;
using Control.APIs.Dtos;

namespace Control.APIs;

public interface IValueAssessmentsService
{
    /// <summary>
    /// Create one Value Assessment
    /// </summary>
    public Task<ValueAssessment> CreateValueAssessment(ValueAssessmentCreateInput valueassessment);

    /// <summary>
    /// Delete one Value Assessment
    /// </summary>
    public Task DeleteValueAssessment(ValueAssessmentWhereUniqueInput uniqueId);

    /// <summary>
    /// Find many Value Assessments
    /// </summary>
    public Task<List<ValueAssessment>> ValueAssessments(ValueAssessmentFindManyArgs findManyArgs);

    /// <summary>
    /// Meta data about Value Assessment records
    /// </summary>
    public Task<MetadataDto> ValueAssessmentsMeta(ValueAssessmentFindManyArgs findManyArgs);

    /// <summary>
    /// Get one Value Assessment
    /// </summary>
    public Task<ValueAssessment> ValueAssessment(ValueAssessmentWhereUniqueInput uniqueId);

    /// <summary>
    /// Update one Value Assessment
    /// </summary>
    public Task UpdateValueAssessment(
        ValueAssessmentWhereUniqueInput uniqueId,
        ValueAssessmentUpdateInput updateDto
    );

    /// <summary>
    /// Connect multiple Articles records to Value Assessment
    /// </summary>
    public Task ConnectArticles(
        ValueAssessmentWhereUniqueInput uniqueId,
        ArticleAssessmentWhereUniqueInput[] articleAssessmentsId
    );

    /// <summary>
    /// Disconnect multiple Articles records from Value Assessment
    /// </summary>
    public Task DisconnectArticles(
        ValueAssessmentWhereUniqueInput uniqueId,
        ArticleAssessmentWhereUniqueInput[] articleAssessmentsId
    );

    /// <summary>
    /// Find multiple Articles records for Value Assessment
    /// </summary>
    public Task<List<ArticleAssessment>> FindArticles(
        ValueAssessmentWhereUniqueInput uniqueId,
        ArticleAssessmentFindManyArgs ArticleAssessmentFindManyArgs
    );

    /// <summary>
    /// Update multiple Articles records for Value Assessment
    /// </summary>
    public Task UpdateArticles(
        ValueAssessmentWhereUniqueInput uniqueId,
        ArticleAssessmentWhereUniqueInput[] articleAssessmentsId
    );

    /// <summary>
    /// Get a Common Detailed Declarations record for COMMON DETAILED DECLARATION (CUSTOMS) VALUE ASSESSMENT
    /// </summary>
    public Task<CommonDetailedDeclaration> GetCommonDetailedDeclarations(
        ValueAssessmentWhereUniqueInput uniqueId
    );
}
