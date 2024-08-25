using Control.APIs.Dtos;
using Control.Infrastructure.Models;

namespace Control.APIs.Extensions;

public static class PlaceOfExecutionAndWithReImportationInStatesExtensions
{
    public static PlaceOfExecutionAndWithReImportationInState ToDto(
        this PlaceOfExecutionAndWithReImportationInStateDbModel model
    )
    {
        return new PlaceOfExecutionAndWithReImportationInState
        {
            CreatedAt = model.CreatedAt,
            DateAndTimeOfFinalModification = model.DateAndTimeOfFinalModification,
            DateAndTimeOfFirstRegistration = model.DateAndTimeOfFirstRegistration,
            ExecutionPlaces = model.ExecutionPlaces,
            FinalModifierSId = model.FinalModifierSId,
            FirstRegistrantSId = model.FirstRegistrantSId,
            Id = model.Id,
            RectificationFrequency = model.RectificationFrequency,
            RegimeRequestNumber = model.RegimeRequestNumber,
            SequenceNumber = model.SequenceNumber,
            SuppressionOn = model.SuppressionOn,
            UpdatedAt = model.UpdatedAt
        };
    }

    public static PlaceOfExecutionAndWithReImportationInStateDbModel ToModel(
        this PlaceOfExecutionAndWithReImportationInStateUpdateInput updateDto,
        PlaceOfExecutionAndWithReImportationInStateWhereUniqueInput uniqueId
    )
    {
        var placeOfExecutionAndWithReImportationInState =
            new PlaceOfExecutionAndWithReImportationInStateDbModel
            {
                Id = uniqueId.Id,
                DateAndTimeOfFinalModification = updateDto.DateAndTimeOfFinalModification,
                DateAndTimeOfFirstRegistration = updateDto.DateAndTimeOfFirstRegistration,
                ExecutionPlaces = updateDto.ExecutionPlaces,
                FinalModifierSId = updateDto.FinalModifierSId,
                FirstRegistrantSId = updateDto.FirstRegistrantSId,
                RectificationFrequency = updateDto.RectificationFrequency,
                RegimeRequestNumber = updateDto.RegimeRequestNumber,
                SequenceNumber = updateDto.SequenceNumber,
                SuppressionOn = updateDto.SuppressionOn
            };

        if (updateDto.CreatedAt != null)
            placeOfExecutionAndWithReImportationInState.CreatedAt = updateDto.CreatedAt.Value;
        if (updateDto.UpdatedAt != null)
            placeOfExecutionAndWithReImportationInState.UpdatedAt = updateDto.UpdatedAt.Value;

        return placeOfExecutionAndWithReImportationInState;
    }
}
