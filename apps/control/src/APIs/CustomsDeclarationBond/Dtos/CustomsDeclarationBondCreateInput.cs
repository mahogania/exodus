namespace Control.APIs.Dtos;

public class CustomsDeclarationBondCreateInput
{
    public string? BondAccountNumber { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? DateAndTimeOfFinalModification { get; set; }

    public DateTime? DateAndTimeOfFirstRegistration { get; set; }

    public string? FinalModifierSId { get; set; }

    public string? FirstRecorderSId { get; set; }

    public string? Id { get; set; }

    public double? RectificationFrequency { get; set; }

    public string? ReferenceNumber { get; set; }

    public string? SuppressionOn { get; set; }

    public string? TypeOfBondCode { get; set; }

    public DateTime UpdatedAt { get; set; }
}
