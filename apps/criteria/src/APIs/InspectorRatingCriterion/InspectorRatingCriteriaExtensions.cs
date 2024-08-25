using Criteria.APIs.Dtos;
using Criteria.Infrastructure.Models;

namespace Criteria.APIs.Extensions;

public static class InspectorRatingCriteriaExtensions
{
    public static InspectorRatingCriterion ToDto(this InspectorRatingCriterionDbModel model)
    {
        return new InspectorRatingCriterion
        {
            AgencyCode = model.AgencyCode,
            ApplicationPriority = model.ApplicationPriority,
            CreatedAt = model.CreatedAt,
            EndApcCode = model.EndApcCode,
            EndFieldShCode = model.EndFieldShCode,
            Id = model.Id,
            InspectorRatingCriteriaDeclarationModel = model
                .InspectorRatingCriteriaDeclarationModel?.Select(x => x.Id)
                .ToList(),
            InspectorRatingCriteriaInspector = model
                .InspectorRatingCriteriaInspector?.Select(x => x.Id)
                .ToList(),
            ServiceCode = model.ServiceCode,
            StartApcCode = model.StartApcCode,
            StartFieldShCode = model.StartFieldShCode,
            UpdatedAt = model.UpdatedAt,
        };
    }

    public static InspectorRatingCriterionDbModel ToModel(
        this InspectorRatingCriterionUpdateInput updateDto,
        InspectorRatingCriterionWhereUniqueInput uniqueId
    )
    {
        var inspectorRatingCriterion = new InspectorRatingCriterionDbModel
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
            inspectorRatingCriterion.AgencyCode = updateDto.AgencyCode;
        }
        if (updateDto.CreatedAt != null)
        {
            inspectorRatingCriterion.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.ServiceCode != null)
        {
            inspectorRatingCriterion.ServiceCode = updateDto.ServiceCode;
        }
        if (updateDto.UpdatedAt != null)
        {
            inspectorRatingCriterion.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return inspectorRatingCriterion;
    }
}
