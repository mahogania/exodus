using Criteria.APIs.Common;
using Criteria.APIs.Dtos;

namespace Criteria.APIs;

public interface IInspectorQuotationStatsService
{
    /// <summary>
    /// Create one Inspector Quotation Stat
    /// </summary>
    public Task<InspectorQuotationStat> CreateInspectorQuotationStat(
        InspectorQuotationStatCreateInput inspectorquotationstat
    );

    /// <summary>
    /// Delete one Inspector Quotation Stat
    /// </summary>
    public Task DeleteInspectorQuotationStat(InspectorQuotationStatWhereUniqueInput uniqueId);

    /// <summary>
    /// Find many Inspector Quotation Stats
    /// </summary>
    public Task<List<InspectorQuotationStat>> InspectorQuotationStats(
        InspectorQuotationStatFindManyArgs findManyArgs
    );

    /// <summary>
    /// Meta data about Inspector Quotation Stat records
    /// </summary>
    public Task<MetadataDto> InspectorQuotationStatsMeta(
        InspectorQuotationStatFindManyArgs findManyArgs
    );

    /// <summary>
    /// Get one Inspector Quotation Stat
    /// </summary>
    public Task<InspectorQuotationStat> InspectorQuotationStat(
        InspectorQuotationStatWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Update one Inspector Quotation Stat
    /// </summary>
    public Task UpdateInspectorQuotationStat(
        InspectorQuotationStatWhereUniqueInput uniqueId,
        InspectorQuotationStatUpdateInput updateDto
    );
}
