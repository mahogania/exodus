namespace Control.APIs.Dtos;

public class TextZoneForSpecifyingTheItinerary
{
    public string? CityName { get; set; }

    public string? CountryCode { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? DateAndTimeOfFinalModification { get; set; }

    public DateTime? DateAndTimeOfFirstRegistration { get; set; }

    public string? DepartureDestinationCode { get; set; }

    public string? FinalModifierSId { get; set; }

    public string? FirstRegistrantSId { get; set; }

    public string Id { get; set; }

    public double? SequenceNumber { get; set; }

    public string? SuppressionOn { get; set; }

    public string? TirRegistrationNumber { get; set; }

    public DateTime UpdatedAt { get; set; }
}
