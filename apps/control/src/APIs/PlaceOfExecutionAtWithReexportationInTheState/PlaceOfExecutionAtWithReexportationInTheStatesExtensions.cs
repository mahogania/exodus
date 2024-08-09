using Control.APIs.Dtos;
using Control.Infrastructure.Models;

namespace Control.APIs.Extensions;

public static class PlaceOfExecutionAtWithReexportationInTheStatesExtensions
{
    public static PlaceOfExecutionAtWithReexportationInTheState ToDto(
        this PlaceOfExecutionAtWithReexportationInTheStateDbModel model
    )
    {
        return new PlaceOfExecutionAtWithReexportationInTheState
        {
            CreatedAt = model.CreatedAt,
            DateAndTimeOfFinalModification = model.DateAndTimeOfFinalModification,
            DateAndTimeOfFirstRegistration = model.DateAndTimeOfFirstRegistration,
            ExecutionPlaces = model.ExecutionPlaces,
            FinalModifierSId = model.FinalModifierSId,
            FirstRecorderSId = model.FirstRecorderSId,
            Id = model.Id,
            RectificationFrequency = model.RectificationFrequency,
            RequestNumberOfTheRegime = model.RequestNumberOfTheRegime,
            SequenceNumber = model.SequenceNumber,
            SuppressionOn = model.SuppressionOn,
            UpdatedAt = model.UpdatedAt,
        };
    }

    public static PlaceOfExecutionAtWithReexportationInTheStateDbModel ToModel(
        this PlaceOfExecutionAtWithReexportationInTheStateUpdateInput updateDto,
        PlaceOfExecutionAtWithReexportationInTheStateWhereUniqueInput uniqueId
    )
    {
        var placeOfExecutionAtWithReexportationInTheState =
            new PlaceOfExecutionAtWithReexportationInTheStateDbModel
            {
                Id = uniqueId.Id,
                DateAndTimeOfFinalModification = updateDto.DateAndTimeOfFinalModification,
                DateAndTimeOfFirstRegistration = updateDto.DateAndTimeOfFirstRegistration,
                ExecutionPlaces = updateDto.ExecutionPlaces,
                FinalModifierSId = updateDto.FinalModifierSId,
                FirstRecorderSId = updateDto.FirstRecorderSId,
                RectificationFrequency = updateDto.RectificationFrequency,
                RequestNumberOfTheRegime = updateDto.RequestNumberOfTheRegime,
                SequenceNumber = updateDto.SequenceNumber,
                SuppressionOn = updateDto.SuppressionOn
            };

        if (updateDto.CreatedAt != null)
        {
            placeOfExecutionAtWithReexportationInTheState.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.UpdatedAt != null)
        {
            placeOfExecutionAtWithReexportationInTheState.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return placeOfExecutionAtWithReexportationInTheState;
    }
}
