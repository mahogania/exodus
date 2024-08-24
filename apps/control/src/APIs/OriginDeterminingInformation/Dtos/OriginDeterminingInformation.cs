namespace Control.APIs.Dtos;

public class OriginDeterminingInformation
{
    public double? Amount { get; set; }

    public string? CountryOfOriginCode { get; set; }

    public DateTime CreatedAt { get; set; }

    public string? DeletionOn { get; set; }

    public DateTime? FinalModificationDateAndTime { get; set; }

    public string? FinalModifierSId { get; set; }

    public string? FirstRecorderSId { get; set; }

    public DateTime? FirstRegistrationDateAndTime { get; set; }

    public string Id { get; set; }

    public string? NameOfMaterialsUsed { get; set; }

    public double? OriginDeterminationSeriesNumber { get; set; }

    public string? RcoRequestNumber { get; set; }

    public double? RectificationFrequency { get; set; }

    public string? ShCode { get; set; }

    public DateTime UpdatedAt { get; set; }

    public double? Weight { get; set; }
}
