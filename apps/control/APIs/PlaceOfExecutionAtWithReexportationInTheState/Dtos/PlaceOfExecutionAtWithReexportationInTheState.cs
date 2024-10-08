namespace Control.APIs.Dtos;

public class PlaceOfExecutionAtWithReexportationInTheState
{
    public DateTime CreatedAt { get; set; }

    public DateTime? DateAndTimeOfFinalModification { get; set; }

    public DateTime? DateAndTimeOfFirstRegistration { get; set; }

    public string? ExecutionPlaces { get; set; }

    public string? FinalModifierSId { get; set; }

    public string? FirstRecorderSId { get; set; }

    public string Id { get; set; }

    public double? RectificationFrequency { get; set; }

    public string? RequestNumberOfTheRegime { get; set; }

    public double? SequenceNumber { get; set; }

    public string? SuppressionOn { get; set; }

    public DateTime UpdatedAt { get; set; }
}
