using Criteria.APIs.Common;
using Criteria.APIs.Dtos;

namespace Criteria.APIs;

public interface IInspectorQuotationModesService
{
    /// <summary>
    /// Create one Inspector Quotation Mode
    /// </summary>
    public Task<InspectorQuotationMode> CreateInspectorQuotationMode(
        InspectorQuotationModeCreateInput inspectorquotationmode
    );

    /// <summary>
    /// Delete one Inspector Quotation Mode
    /// </summary>
    public Task DeleteInspectorQuotationMode(InspectorQuotationModeWhereUniqueInput uniqueId);

    /// <summary>
    /// Find many Inspector Quotation Modes
    /// </summary>
    public Task<List<InspectorQuotationMode>> InspectorQuotationModes(
        InspectorQuotationModeFindManyArgs findManyArgs
    );

    /// <summary>
    /// Meta data about Inspector Quotation Mode records
    /// </summary>
    public Task<MetadataDto> InspectorQuotationModesMeta(
        InspectorQuotationModeFindManyArgs findManyArgs
    );

    /// <summary>
    /// Get one Inspector Quotation Mode
    /// </summary>
    public Task<InspectorQuotationMode> InspectorQuotationMode(
        InspectorQuotationModeWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Update one Inspector Quotation Mode
    /// </summary>
    public Task UpdateInspectorQuotationMode(
        InspectorQuotationModeWhereUniqueInput uniqueId,
        InspectorQuotationModeUpdateInput updateDto
    );
}
