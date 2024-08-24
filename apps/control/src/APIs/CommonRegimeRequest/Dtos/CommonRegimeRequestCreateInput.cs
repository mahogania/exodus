namespace Control.APIs.Dtos;

public class CommonRegimeRequestCreateInput
{
    public string? ApcCode { get; set; }

    public string? AttachedFileId { get; set; }

    public string? ComplementaryRequestContent { get; set; }

    public string? ComplementaryRequestResponseContent { get; set; }

    public DateTime CreatedAt { get; set; }

    public string? CustomsOfficeCode { get; set; }

    public DateTime? DateAndTimeOfFinalModification { get; set; }

    public DateTime? DateAndTimeOfFirstRegistration { get; set; }

    public string? DeclarantCode { get; set; }

    public string? DeletionOn { get; set; }

    public string? DocumentCode { get; set; }

    public string? EpcCode { get; set; }

    public string? FinalModifierSId { get; set; }

    public string? FinalOn { get; set; }

    public string? FirstRecorderSId { get; set; }

    public string? Id { get; set; }

    public Journal? Journal { get; set; }

    public string? ProcessingStatusCode { get; set; }

    public double? RectificationFrequency { get; set; }

    public string? RegimeRequestContent { get; set; }

    public string? RegimeRequestNumber { get; set; }

    public string? RegimeRequestTitle { get; set; }

    public string? RegimeValidationDate { get; set; }

    public string? RequestDate { get; set; }

    public DateTime UpdatedAt { get; set; }
}
