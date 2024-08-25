using Criteria.APIs.Dtos;
using Criteria.Infrastructure.Models;

namespace Criteria.APIs.Extensions;

public static class InspectorRatingCriteriaInspectorsExtensions
{
    public static InspectorRatingCriteriaInspector ToDto(
        this InspectorRatingCriteriaInspectorDbModel model
    )
    {
        return new InspectorRatingCriteriaInspector
        {
            CreatedAt = model.CreatedAt,
            FieldSequenceNumber = model.FieldSequenceNumber,
            Id = model.Id,
            InspectorId = model.InspectorId,
            InspectorRatingCriteria = model.InspectorRatingCriteriaId,
            OfficeCode = model.OfficeCode,
            ServiceCode = model.ServiceCode,
            UpdatedAt = model.UpdatedAt,
        };
    }

    public static InspectorRatingCriteriaInspectorDbModel ToModel(
        this InspectorRatingCriteriaInspectorUpdateInput updateDto,
        InspectorRatingCriteriaInspectorWhereUniqueInput uniqueId
    )
    {
        var inspectorRatingCriteriaInspector = new InspectorRatingCriteriaInspectorDbModel
        {
            Id = uniqueId.Id,
            FieldSequenceNumber = updateDto.FieldSequenceNumber,
            InspectorId = updateDto.InspectorId,
            OfficeCode = updateDto.OfficeCode,
            ServiceCode = updateDto.ServiceCode
        };

        if (updateDto.CreatedAt != null)
        {
            inspectorRatingCriteriaInspector.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.InspectorRatingCriteria != null)
        {
            inspectorRatingCriteriaInspector.InspectorRatingCriteriaId =
                updateDto.InspectorRatingCriteria;
        }
        if (updateDto.UpdatedAt != null)
        {
            inspectorRatingCriteriaInspector.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return inspectorRatingCriteriaInspector;
    }
}
