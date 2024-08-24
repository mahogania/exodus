using Control.APIs.Dtos;
using Control.Infrastructure.Models;

namespace Control.APIs.Extensions;

public static class ItinerariesExtensions
{
    public static Itinerary ToDto(this ItineraryDbModel model)
    {
        return new Itinerary
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

    public static ItineraryDbModel ToModel(
        this ItineraryUpdateInput updateDto,
        ItineraryWhereUniqueInput uniqueId
    )
    {
        var itinerary = new ItineraryDbModel
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
            itinerary.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.UpdatedAt != null)
        {
            itinerary.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return itinerary;
    }
}
