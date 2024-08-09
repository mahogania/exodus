namespace Collection.APIs.Dtos;

public class AppealUpdateInput
{
    public string? AttachedFileId { get; set; }

    public DateTime? CreatedAt { get; set; }

    public string? DeletionFlag { get; set; }

    public DateTime? FinalModificationDateAndTime { get; set; }

    public string? FinalModifierId { get; set; }

    public string? FineImpositionRequestNumber { get; set; }

    public string? FirstRegistrantId { get; set; }

    public DateTime? FirstRegistrationDateAndTime { get; set; }

    public string? Id { get; set; }

    public double? NumberOfOpinions { get; set; }

    public string? OfficeCode { get; set; }

    public string? OpinionContent { get; set; }

    public DateTime? RegistrationDateAndTime { get; set; }

    public string? ResponseContent { get; set; }

    public string? ServiceCode { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
