using Criteria.APIs.Common;
using Criteria.APIs.Dtos;

namespace Criteria.APIs;

public interface IServiceQuotationCriteriaService
{
    /// <summary>
    /// Create one Service Quotation Criterion
    /// </summary>
    public Task<ServiceQuotationCriterion> CreateServiceQuotationCriterion(
        ServiceQuotationCriterionCreateInput servicequotationcriterion
    );

    /// <summary>
    /// Delete one Service Quotation Criterion
    /// </summary>
    public Task DeleteServiceQuotationCriterion(ServiceQuotationCriterionWhereUniqueInput uniqueId);

    /// <summary>
    /// Find many Service Quotation Criteria
    /// </summary>
    public Task<List<ServiceQuotationCriterion>> ServiceQuotationCriteria(
        ServiceQuotationCriterionFindManyArgs findManyArgs
    );

    /// <summary>
    /// Meta data about Service Quotation Criterion records
    /// </summary>
    public Task<MetadataDto> ServiceQuotationCriteriaMeta(
        ServiceQuotationCriterionFindManyArgs findManyArgs
    );

    /// <summary>
    /// Get one Service Quotation Criterion
    /// </summary>
    public Task<ServiceQuotationCriterion> ServiceQuotationCriterion(
        ServiceQuotationCriterionWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Update one Service Quotation Criterion
    /// </summary>
    public Task UpdateServiceQuotationCriterion(
        ServiceQuotationCriterionWhereUniqueInput uniqueId,
        ServiceQuotationCriterionUpdateInput updateDto
    );
}
