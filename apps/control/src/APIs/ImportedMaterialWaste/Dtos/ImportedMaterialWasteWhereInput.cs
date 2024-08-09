namespace Control.APIs.Dtos;

public class ImportedMaterialWasteWhereInput
{
    public DateTime? CreatedAt { get; set; }

    public DateTime? DateAndTimeOfFinalModification { get; set; }

    public DateTime? DateAndTimeOfFirstRegistration { get; set; }

    public string? FinalModifierSId { get; set; }

    public string? FirstRegistrantSId { get; set; }

    public string? Id { get; set; }

    public double? LossRate { get; set; }

    public double? NonRecoverableWasteRate { get; set; }

    public double? RateOfWasteOnFinishedProducts { get; set; }

    public double? RecoverableWasteRate { get; set; }

    public double? RectificationFrequency { get; set; }

    public string? RequestNumberOfRegime { get; set; }

    public double? SequenceNumber { get; set; }

    public string? SuppressionOn { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
