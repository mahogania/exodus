using Control.APIs.Dtos;
using Control.Infrastructure.Models;

namespace Control.APIs.Extensions;

public static class ValueAssessmentsExtensions
{
    public static ValueAssessment ToDto(this ValueAssessmentDbModel model)
    {
        return new ValueAssessment
        {
            Articles = model.Articles?.Select(x => x.Id).ToList(),
            CommonDetailedDeclarations = model.CommonDetailedDeclarations?.ToDto(),
            CreatedAt = model.CreatedAt,
            Id = model.Id,
            UpdatedAt = model.UpdatedAt,
        };
    }

    public static ValueAssessmentDbModel ToModel(
        this ValueAssessmentUpdateInput updateDto,
        ValueAssessmentWhereUniqueInput uniqueId
    )
    {
        var valueAssessment = new ValueAssessmentDbModel { Id = uniqueId.Id };

        if (updateDto.CreatedAt != null)
        {
            valueAssessment.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.UpdatedAt != null)
        {
            valueAssessment.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return valueAssessment;
    }
}
