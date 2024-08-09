using Clre.APIs.Common;
using Clre.APIs.Dtos;

namespace Clre.APIs;

public interface ICommonDetailedDeclarationCustomsValueAssessmentsService
{
    /// <summary>
    /// Create one COMMON DETAILED DECLARATION (CUSTOMS) VALUE ASSESSMENT
    /// </summary>
    public Task<CommonDetailedDeclarationCustomsValueAssessment> CreateCommonDetailedDeclarationCustomsValueAssessment(
        CommonDetailedDeclarationCustomsValueAssessmentCreateInput commondetaileddeclarationcustomsvalueassessment
    );

    /// <summary>
    /// Delete one COMMON DETAILED DECLARATION (CUSTOMS) VALUE ASSESSMENT
    /// </summary>
    public Task DeleteCommonDetailedDeclarationCustomsValueAssessment(
        CommonDetailedDeclarationCustomsValueAssessmentWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Find many COMMON DETAILED DECLARATION (CUSTOMS) VALUE ASSESSMENTS
    /// </summary>
    public Task<
        List<CommonDetailedDeclarationCustomsValueAssessment>
    > CommonDetailedDeclarationCustomsValueAssessments(
        CommonDetailedDeclarationCustomsValueAssessmentFindManyArgs findManyArgs
    );

    /// <summary>
    /// Meta data about COMMON DETAILED DECLARATION (CUSTOMS) VALUE ASSESSMENT records
    /// </summary>
    public Task<MetadataDto> CommonDetailedDeclarationCustomsValueAssessmentsMeta(
        CommonDetailedDeclarationCustomsValueAssessmentFindManyArgs findManyArgs
    );

    /// <summary>
    /// Get one COMMON DETAILED DECLARATION (CUSTOMS) VALUE ASSESSMENT
    /// </summary>
    public Task<CommonDetailedDeclarationCustomsValueAssessment> CommonDetailedDeclarationCustomsValueAssessment(
        CommonDetailedDeclarationCustomsValueAssessmentWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Update one COMMON DETAILED DECLARATION (CUSTOMS) VALUE ASSESSMENT
    /// </summary>
    public Task UpdateCommonDetailedDeclarationCustomsValueAssessment(
        CommonDetailedDeclarationCustomsValueAssessmentWhereUniqueInput uniqueId,
        CommonDetailedDeclarationCustomsValueAssessmentUpdateInput updateDto
    );
}
