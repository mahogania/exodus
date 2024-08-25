using Criteria.APIs.Common;
using Criteria.APIs.Dtos;

namespace Criteria.APIs;

public interface IInspectorRatingCriteriaInspectorsService
{
    /// <summary>
    /// Create one Inspector Rating Criteria Inspector
    /// </summary>
    public Task<InspectorRatingCriteriaInspector> CreateInspectorRatingCriteriaInspector(
        InspectorRatingCriteriaInspectorCreateInput inspectorratingcriteriainspector
    );

    /// <summary>
    /// Delete one Inspector Rating Criteria Inspector
    /// </summary>
    public Task DeleteInspectorRatingCriteriaInspector(
        InspectorRatingCriteriaInspectorWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Find many Inspector Rating Criteria Inspectors
    /// </summary>
    public Task<List<InspectorRatingCriteriaInspector>> InspectorRatingCriteriaInspectors(
        InspectorRatingCriteriaInspectorFindManyArgs findManyArgs
    );

    /// <summary>
    /// Meta data about Inspector Rating Criteria Inspector records
    /// </summary>
    public Task<MetadataDto> InspectorRatingCriteriaInspectorsMeta(
        InspectorRatingCriteriaInspectorFindManyArgs findManyArgs
    );

    /// <summary>
    /// Get one Inspector Rating Criteria Inspector
    /// </summary>
    public Task<InspectorRatingCriteriaInspector> InspectorRatingCriteriaInspector(
        InspectorRatingCriteriaInspectorWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Update one Inspector Rating Criteria Inspector
    /// </summary>
    public Task UpdateInspectorRatingCriteriaInspector(
        InspectorRatingCriteriaInspectorWhereUniqueInput uniqueId,
        InspectorRatingCriteriaInspectorUpdateInput updateDto
    );

    /// <summary>
    /// Get a Inspector Rating Criteria record for Inspector Rating Criteria Inspector
    /// </summary>
    public Task<InspectorRatingCriterion> GetInspectorRatingCriteria(
        InspectorRatingCriteriaInspectorWhereUniqueInput uniqueId
    );
}
