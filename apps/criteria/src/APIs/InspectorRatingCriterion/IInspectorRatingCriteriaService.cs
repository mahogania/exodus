using Criteria.APIs.Common;
using Criteria.APIs.Dtos;

namespace Criteria.APIs;

public interface IInspectorRatingCriteriaService
{
    /// <summary>
    /// Create one Inspector Quotation Criterion
    /// </summary>
    public Task<InspectorRatingCriterion> CreateInspectorRatingCriterion(
        InspectorRatingCriterionCreateInput inspectorratingcriterion
    );

    /// <summary>
    /// Delete one Inspector Quotation Criterion
    /// </summary>
    public Task DeleteInspectorRatingCriterion(InspectorRatingCriterionWhereUniqueInput uniqueId);

    /// <summary>
    /// Find many Inspector Rating Criteria
    /// </summary>
    public Task<List<InspectorRatingCriterion>> InspectorRatingCriteria(
        InspectorRatingCriterionFindManyArgs findManyArgs
    );

    /// <summary>
    /// Meta data about Inspector Quotation Criterion records
    /// </summary>
    public Task<MetadataDto> InspectorRatingCriteriaMeta(
        InspectorRatingCriterionFindManyArgs findManyArgs
    );

    /// <summary>
    /// Get one Inspector Quotation Criterion
    /// </summary>
    public Task<InspectorRatingCriterion> InspectorRatingCriterion(
        InspectorRatingCriterionWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Update one Inspector Quotation Criterion
    /// </summary>
    public Task UpdateInspectorRatingCriterion(
        InspectorRatingCriterionWhereUniqueInput uniqueId,
        InspectorRatingCriterionUpdateInput updateDto
    );

    /// <summary>
    /// Connect multiple  Inspector Rating Criteria Declaration Model  records to Inspector Quotation Criterion
    /// </summary>
    public Task ConnectInspectorRatingCriteriaDeclarationModel(
        InspectorRatingCriterionWhereUniqueInput uniqueId,
        InspectorRatingCriteriaDeclarationModelWhereUniqueInput[] inspectorRatingCriteriaDeclarationModelsId
    );

    /// <summary>
    /// Disconnect multiple  Inspector Rating Criteria Declaration Model  records from Inspector Quotation Criterion
    /// </summary>
    public Task DisconnectInspectorRatingCriteriaDeclarationModel(
        InspectorRatingCriterionWhereUniqueInput uniqueId,
        InspectorRatingCriteriaDeclarationModelWhereUniqueInput[] inspectorRatingCriteriaDeclarationModelsId
    );

    /// <summary>
    /// Find multiple  Inspector Rating Criteria Declaration Model  records for Inspector Quotation Criterion
    /// </summary>
    public Task<
        List<InspectorRatingCriteriaDeclarationModel>
    > FindInspectorRatingCriteriaDeclarationModel(
        InspectorRatingCriterionWhereUniqueInput uniqueId,
        InspectorRatingCriteriaDeclarationModelFindManyArgs InspectorRatingCriteriaDeclarationModelFindManyArgs
    );

    /// <summary>
    /// Update multiple  Inspector Rating Criteria Declaration Model  records for Inspector Quotation Criterion
    /// </summary>
    public Task UpdateInspectorRatingCriteriaDeclarationModel(
        InspectorRatingCriterionWhereUniqueInput uniqueId,
        InspectorRatingCriteriaDeclarationModelWhereUniqueInput[] inspectorRatingCriteriaDeclarationModelsId
    );

    /// <summary>
    /// Connect multiple Inspector Rating Criteria Inspector records to Inspector Quotation Criterion
    /// </summary>
    public Task ConnectInspectorRatingCriteriaInspector(
        InspectorRatingCriterionWhereUniqueInput uniqueId,
        InspectorRatingCriteriaInspectorWhereUniqueInput[] inspectorRatingCriteriaInspectorsId
    );

    /// <summary>
    /// Disconnect multiple Inspector Rating Criteria Inspector records from Inspector Quotation Criterion
    /// </summary>
    public Task DisconnectInspectorRatingCriteriaInspector(
        InspectorRatingCriterionWhereUniqueInput uniqueId,
        InspectorRatingCriteriaInspectorWhereUniqueInput[] inspectorRatingCriteriaInspectorsId
    );

    /// <summary>
    /// Find multiple Inspector Rating Criteria Inspector records for Inspector Quotation Criterion
    /// </summary>
    public Task<List<InspectorRatingCriteriaInspector>> FindInspectorRatingCriteriaInspector(
        InspectorRatingCriterionWhereUniqueInput uniqueId,
        InspectorRatingCriteriaInspectorFindManyArgs InspectorRatingCriteriaInspectorFindManyArgs
    );

    /// <summary>
    /// Update multiple Inspector Rating Criteria Inspector records for Inspector Quotation Criterion
    /// </summary>
    public Task UpdateInspectorRatingCriteriaInspector(
        InspectorRatingCriterionWhereUniqueInput uniqueId,
        InspectorRatingCriteriaInspectorWhereUniqueInput[] inspectorRatingCriteriaInspectorsId
    );
}
