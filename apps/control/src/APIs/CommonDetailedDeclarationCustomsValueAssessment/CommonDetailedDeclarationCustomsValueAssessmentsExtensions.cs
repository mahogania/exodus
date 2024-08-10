using Control.APIs.Dtos;
using Control.Infrastructure.Models;

namespace Control.APIs.Extensions;

public static class CommonDetailedDeclarationCustomsValueAssessmentsExtensions
{
    public static CommonDetailedDeclarationCustomsValueAssessment ToDto(
        this CommonDetailedDeclarationCustomsValueAssessmentDbModel model
    )
    {
        return new CommonDetailedDeclarationCustomsValueAssessment
        {
            CreatedAt = model.CreatedAt,
            Id = model.Id,
            UpdatedAt = model.UpdatedAt
        };
    }

    public static CommonDetailedDeclarationCustomsValueAssessmentDbModel ToModel(
        this CommonDetailedDeclarationCustomsValueAssessmentUpdateInput updateDto,
        CommonDetailedDeclarationCustomsValueAssessmentWhereUniqueInput uniqueId
    )
    {
        var commonDetailedDeclarationCustomsValueAssessment =
            new CommonDetailedDeclarationCustomsValueAssessmentDbModel { Id = uniqueId.Id };

        if (updateDto.CreatedAt != null)
            commonDetailedDeclarationCustomsValueAssessment.CreatedAt = updateDto.CreatedAt.Value;
        if (updateDto.UpdatedAt != null)
            commonDetailedDeclarationCustomsValueAssessment.UpdatedAt = updateDto.UpdatedAt.Value;

        return commonDetailedDeclarationCustomsValueAssessment;
    }
}
