using Criteria.APIs.Dtos;
using Criteria.Infrastructure.Models;

namespace Criteria.APIs.Extensions;

public static class InspectorRatingCriteriaDeclarationModelsExtensions
{
    public static InspectorRatingCriteriaDeclarationModel ToDto(
        this InspectorRatingCriteriaDeclarationModelDbModel model
    )
    {
        return new InspectorRatingCriteriaDeclarationModel
        {
            CreatedAt = model.CreatedAt,
            DeclarationTypeCode = model.DeclarationTypeCode,
            FieldSequenceNumber = model.FieldSequenceNumber,
            Id = model.Id,
            OfficeCode = model.OfficeCode,
            ServiceCode = model.ServiceCode,
            UpdatedAt = model.UpdatedAt,
        };
    }

    public static InspectorRatingCriteriaDeclarationModelDbModel ToModel(
        this InspectorRatingCriteriaDeclarationModelUpdateInput updateDto,
        InspectorRatingCriteriaDeclarationModelWhereUniqueInput uniqueId
    )
    {
        var inspectorRatingCriteriaDeclarationModel =
            new InspectorRatingCriteriaDeclarationModelDbModel
            {
                Id = uniqueId.Id,
                DeclarationTypeCode = updateDto.DeclarationTypeCode,
                FieldSequenceNumber = updateDto.FieldSequenceNumber,
                OfficeCode = updateDto.OfficeCode,
                ServiceCode = updateDto.ServiceCode
            };

        if (updateDto.CreatedAt != null)
        {
            inspectorRatingCriteriaDeclarationModel.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.UpdatedAt != null)
        {
            inspectorRatingCriteriaDeclarationModel.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return inspectorRatingCriteriaDeclarationModel;
    }
}
