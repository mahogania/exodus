namespace Collection.APIs.Dtos;

public class IssuanceWhereInput
{
    public string? CollectionNo { get; set; }

    public DateTime? CreatedAt { get; set; }

    public string? DeletionOn { get; set; }

    public DateTime? FinalModificationDateAndTime { get; set; }

    public string? FinalModifierId { get; set; }

    public string? FirstRegistrantId { get; set; }

    public DateTime? FirstRegistrationDateAndTime { get; set; }

    public string? Id { get; set; }

    public string? IssuingPersonId { get; set; }

    public double? NumberOfIssuances { get; set; }

    public string? OfficeCode { get; set; }

    public DateTime? PublicationDate { get; set; }

    public string? ServiceCode { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
