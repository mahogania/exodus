using Criteria.APIs.Dtos;
using Criteria.Infrastructure.Models;

namespace Criteria.APIs.Extensions;

public static class InspectorQuotationStatsExtensions
{
    public static InspectorQuotationStat ToDto(this InspectorQuotationStatDbModel model)
    {
        return new InspectorQuotationStat
        {
            AffectationNumber = model.AffectationNumber,
            AgencyCode = model.AgencyCode,
            CreatedAt = model.CreatedAt,
            Id = model.Id,
            InspectorId = model.InspectorId,
            QuotationDate = model.QuotationDate,
            ServiceCode = model.ServiceCode,
            UpdatedAt = model.UpdatedAt,
        };
    }

    public static InspectorQuotationStatDbModel ToModel(
        this InspectorQuotationStatUpdateInput updateDto,
        InspectorQuotationStatWhereUniqueInput uniqueId
    )
    {
        var inspectorQuotationStat = new InspectorQuotationStatDbModel
        {
            Id = uniqueId.Id,
            AffectationNumber = updateDto.AffectationNumber
        };

        if (updateDto.AgencyCode != null)
        {
            inspectorQuotationStat.AgencyCode = updateDto.AgencyCode;
        }
        if (updateDto.CreatedAt != null)
        {
            inspectorQuotationStat.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.InspectorId != null)
        {
            inspectorQuotationStat.InspectorId = updateDto.InspectorId;
        }
        if (updateDto.QuotationDate != null)
        {
            inspectorQuotationStat.QuotationDate = updateDto.QuotationDate.Value;
        }
        if (updateDto.ServiceCode != null)
        {
            inspectorQuotationStat.ServiceCode = updateDto.ServiceCode;
        }
        if (updateDto.UpdatedAt != null)
        {
            inspectorQuotationStat.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return inspectorQuotationStat;
    }
}
