using Criteria.APIs.Dtos;
using Criteria.Infrastructure.Models;

namespace Criteria.APIs.Extensions;

public static class InspectorQuotationCriteriaExtensions
{
    public static InspectorQuotationCriterion ToDto(this InspectorQuotationCriterionDbModel model)
    {
        return new InspectorQuotationCriterion
        {
            AgencyCode = model.AgencyCode,
            ApplicationPriority = model.ApplicationPriority,
            CreatedAt = model.CreatedAt,
            EndApcCode = model.EndApcCode,
            EndFieldShCode = model.EndFieldShCode,
            Id = model.Id,
            ServiceCode = model.ServiceCode,
            StartApcCode = model.StartApcCode,
            StartFieldShCode = model.StartFieldShCode,
            UpdatedAt = model.UpdatedAt,
        };
    }

    public static InspectorQuotationCriterionDbModel ToModel(
        this InspectorQuotationCriterionUpdateInput updateDto,
        InspectorQuotationCriterionWhereUniqueInput uniqueId
    )
    {
        var inspectorQuotationCriterion = new InspectorQuotationCriterionDbModel
        {
            Id = uniqueId.Id,
            ApplicationPriority = updateDto.ApplicationPriority,
            EndApcCode = updateDto.EndApcCode,
            EndFieldShCode = updateDto.EndFieldShCode,
            StartApcCode = updateDto.StartApcCode,
            StartFieldShCode = updateDto.StartFieldShCode
        };

        if (updateDto.AgencyCode != null)
        {
            inspectorQuotationCriterion.AgencyCode = updateDto.AgencyCode;
        }
        if (updateDto.CreatedAt != null)
        {
            inspectorQuotationCriterion.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.ServiceCode != null)
        {
            inspectorQuotationCriterion.ServiceCode = updateDto.ServiceCode;
        }
        if (updateDto.UpdatedAt != null)
        {
            inspectorQuotationCriterion.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return inspectorQuotationCriterion;
    }
}
