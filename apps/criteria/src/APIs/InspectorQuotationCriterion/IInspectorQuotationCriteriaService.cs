using Criteria.APIs.Common;
using Criteria.APIs.Dtos;

namespace Criteria.APIs;

public interface IInspectorQuotationCriteriaService
{
    /// <summary>
    /// Create one Inspector Quotation Criterion
    /// </summary>
    public Task<InspectorQuotationCriterion> CreateInspectorQuotationCriterion(
        InspectorQuotationCriterionCreateInput inspectorquotationcriterion
    );

    /// <summary>
    /// Delete one Inspector Quotation Criterion
    /// </summary>
    public Task DeleteInspectorQuotationCriterion(
        InspectorQuotationCriterionWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Find many Inspector Quotation Criteria
    /// </summary>
    public Task<List<InspectorQuotationCriterion>> InspectorQuotationCriteria(
        InspectorQuotationCriterionFindManyArgs findManyArgs
    );

    /// <summary>
    /// Meta data about Inspector Quotation Criterion records
    /// </summary>
    public Task<MetadataDto> InspectorQuotationCriteriaMeta(
        InspectorQuotationCriterionFindManyArgs findManyArgs
    );

    /// <summary>
    /// Get one Inspector Quotation Criterion
    /// </summary>
    public Task<InspectorQuotationCriterion> InspectorQuotationCriterion(
        InspectorQuotationCriterionWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Update one Inspector Quotation Criterion
    /// </summary>
    public Task UpdateInspectorQuotationCriterion(
        InspectorQuotationCriterionWhereUniqueInput uniqueId,
        InspectorQuotationCriterionUpdateInput updateDto
    );
}
