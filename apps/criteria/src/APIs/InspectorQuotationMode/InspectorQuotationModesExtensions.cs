using Criteria.APIs.Dtos;
using Criteria.Infrastructure.Models;

namespace Criteria.APIs.Extensions;

public static class InspectorQuotationModesExtensions
{
    public static InspectorQuotationMode ToDto(this InspectorQuotationModeDbModel model)
    {
        return new InspectorQuotationMode
        {
            AgencyCode = model.AgencyCode,
            CreatedAt = model.CreatedAt,
            DeclarationTypeCode = model.DeclarationTypeCode,
            Id = model.Id,
            QuotationModeType = model.QuotationModeType,
            ServiceCode = model.ServiceCode,
            UpdatedAt = model.UpdatedAt,
        };
    }

    public static InspectorQuotationModeDbModel ToModel(
        this InspectorQuotationModeUpdateInput updateDto,
        InspectorQuotationModeWhereUniqueInput uniqueId
    )
    {
        var inspectorQuotationMode = new InspectorQuotationModeDbModel
        {
            Id = uniqueId.Id,
            QuotationModeType = updateDto.QuotationModeType
        };

        if (updateDto.AgencyCode != null)
        {
            inspectorQuotationMode.AgencyCode = updateDto.AgencyCode;
        }
        if (updateDto.CreatedAt != null)
        {
            inspectorQuotationMode.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.DeclarationTypeCode != null)
        {
            inspectorQuotationMode.DeclarationTypeCode = updateDto.DeclarationTypeCode;
        }
        if (updateDto.ServiceCode != null)
        {
            inspectorQuotationMode.ServiceCode = updateDto.ServiceCode;
        }
        if (updateDto.UpdatedAt != null)
        {
            inspectorQuotationMode.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return inspectorQuotationMode;
    }
}
