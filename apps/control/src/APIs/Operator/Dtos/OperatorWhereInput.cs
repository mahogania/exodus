namespace Control.APIs.Dtos;

public class OperatorWhereInput
{
    public string? CommonDetailedDeclaration { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? DateAndTimeOfFinalModification { get; set; }

    public DateTime? DateAndTimeOfFirstRegistration { get; set; }

    public string? DeclarantSAddress { get; set; }

    public string? DeletionOn { get; set; }

    public string? ExporterSAddress { get; set; }

    public string? ExporterSEmail { get; set; }

    public string? FinalModifierSId { get; set; }

    public string? FirstRecorderSId { get; set; }

    public string? Id { get; set; }

    public string? ImporterSAddress { get; set; }

    public string? NameOfTheDeclarantSCompany { get; set; }

    public string? NameOfTheExporterSCompany { get; set; }

    public string? NameOfTheImporterSCompany { get; set; }

    public double? RectificationFrequency { get; set; }

    public string? ReferenceNumber { get; set; }

    public string? TaxpayerPhoneNumber { get; set; }

    public string? TaxpayerSAddress { get; set; }

    public string? TaxpayerSCompanyName { get; set; }

    public string? TaxpayerSEmail { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
