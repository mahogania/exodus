using Criteria.APIs.Dtos;
using Criteria.Infrastructure.Models;

namespace Criteria.APIs.Extensions;

public static class ServiceQuotationCriteriaExtensions
{
    public static ServiceQuotationCriterion ToDto(this ServiceQuotationCriterionDbModel model)
    {
        return new ServiceQuotationCriterion
        {
            AgencyCode = model.AgencyCode,
            CreatedAt = model.CreatedAt,
            CriterionContent = model.CriterionContent,
            EndApplicationDate = model.EndApplicationDate,
            Id = model.Id,
            StartApplicationDate = model.StartApplicationDate,
            UpdatedAt = model.UpdatedAt,
        };
    }

    public static ServiceQuotationCriterionDbModel ToModel(
        this ServiceQuotationCriterionUpdateInput updateDto,
        ServiceQuotationCriterionWhereUniqueInput uniqueId
    )
    {
        var serviceQuotationCriterion = new ServiceQuotationCriterionDbModel
        {
            Id = uniqueId.Id,
            CriterionContent = updateDto.CriterionContent,
            EndApplicationDate = updateDto.EndApplicationDate,
            StartApplicationDate = updateDto.StartApplicationDate
        };

        if (updateDto.AgencyCode != null)
        {
            serviceQuotationCriterion.AgencyCode = updateDto.AgencyCode;
        }
        if (updateDto.CreatedAt != null)
        {
            serviceQuotationCriterion.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.UpdatedAt != null)
        {
            serviceQuotationCriterion.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return serviceQuotationCriterion;
    }
}
