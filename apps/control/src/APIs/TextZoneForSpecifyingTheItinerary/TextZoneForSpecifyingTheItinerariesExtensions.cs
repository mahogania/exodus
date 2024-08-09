using Clre.APIs.Dtos;
using Clre.Infrastructure.Models;

namespace Clre.APIs.Extensions;

public static class TextZoneForSpecifyingTheItinerariesExtensions
{
    public static TextZoneForSpecifyingTheItinerary ToDto(
        this TextZoneForSpecifyingTheItineraryDbModel model
    )
    {
        return new TextZoneForSpecifyingTheItinerary
        {
            CityName = model.CityName,
            CountryCode = model.CountryCode,
            CreatedAt = model.CreatedAt,
            DateAndTimeOfFinalModification = model.DateAndTimeOfFinalModification,
            DateAndTimeOfFirstRegistration = model.DateAndTimeOfFirstRegistration,
            DepartureDestinationCode = model.DepartureDestinationCode,
            FinalModifierSId = model.FinalModifierSId,
            FirstRegistrantSId = model.FirstRegistrantSId,
            Id = model.Id,
            SequenceNumber = model.SequenceNumber,
            SuppressionOn = model.SuppressionOn,
            TirRegistrationNumber = model.TirRegistrationNumber,
            UpdatedAt = model.UpdatedAt,
        };
    }

    public static TextZoneForSpecifyingTheItineraryDbModel ToModel(
        this TextZoneForSpecifyingTheItineraryUpdateInput updateDto,
        TextZoneForSpecifyingTheItineraryWhereUniqueInput uniqueId
    )
    {
        var textZoneForSpecifyingTheItinerary = new TextZoneForSpecifyingTheItineraryDbModel
        {
            Id = uniqueId.Id,
            CityName = updateDto.CityName,
            CountryCode = updateDto.CountryCode,
            DateAndTimeOfFinalModification = updateDto.DateAndTimeOfFinalModification,
            DateAndTimeOfFirstRegistration = updateDto.DateAndTimeOfFirstRegistration,
            DepartureDestinationCode = updateDto.DepartureDestinationCode,
            FinalModifierSId = updateDto.FinalModifierSId,
            FirstRegistrantSId = updateDto.FirstRegistrantSId,
            SequenceNumber = updateDto.SequenceNumber,
            SuppressionOn = updateDto.SuppressionOn,
            TirRegistrationNumber = updateDto.TirRegistrationNumber
        };

        if (updateDto.CreatedAt != null)
        {
            textZoneForSpecifyingTheItinerary.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.UpdatedAt != null)
        {
            textZoneForSpecifyingTheItinerary.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return textZoneForSpecifyingTheItinerary;
    }
}
