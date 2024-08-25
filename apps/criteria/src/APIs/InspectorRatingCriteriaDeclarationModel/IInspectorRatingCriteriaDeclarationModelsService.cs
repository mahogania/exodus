using Criteria.APIs.Common;
using Criteria.APIs.Dtos;

namespace Criteria.APIs;

public interface IInspectorRatingCriteriaDeclarationModelsService
{
    /// <summary>
    /// Create one Inspector Rating Criteria Declaration Model
    /// </summary>
    public Task<InspectorRatingCriteriaDeclarationModel> CreateInspectorRatingCriteriaDeclarationModel(
        InspectorRatingCriteriaDeclarationModelCreateInput inspectorratingcriteriadeclarationmodel
    );

    /// <summary>
    /// Delete one Inspector Rating Criteria Declaration Model
    /// </summary>
    public Task DeleteInspectorRatingCriteriaDeclarationModel(
        InspectorRatingCriteriaDeclarationModelWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Find many Inspector Rating Criteria Declaration Models
    /// </summary>
    public Task<
        List<InspectorRatingCriteriaDeclarationModel>
    > InspectorRatingCriteriaDeclarationModels(
        InspectorRatingCriteriaDeclarationModelFindManyArgs findManyArgs
    );

    /// <summary>
    /// Meta data about Inspector Rating Criteria Declaration Model records
    /// </summary>
    public Task<MetadataDto> InspectorRatingCriteriaDeclarationModelsMeta(
        InspectorRatingCriteriaDeclarationModelFindManyArgs findManyArgs
    );

    /// <summary>
    /// Get one Inspector Rating Criteria Declaration Model
    /// </summary>
    public Task<InspectorRatingCriteriaDeclarationModel> InspectorRatingCriteriaDeclarationModel(
        InspectorRatingCriteriaDeclarationModelWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Update one Inspector Rating Criteria Declaration Model
    /// </summary>
    public Task UpdateInspectorRatingCriteriaDeclarationModel(
        InspectorRatingCriteriaDeclarationModelWhereUniqueInput uniqueId,
        InspectorRatingCriteriaDeclarationModelUpdateInput updateDto
    );

    /// <summary>
    /// Get a Inspector Rating Criteria record for Inspector Rating Criteria Declaration Model
    /// </summary>
    public Task<InspectorRatingCriterion> GetInspectorRatingCriteria(
        InspectorRatingCriteriaDeclarationModelWhereUniqueInput uniqueId
    );
}
