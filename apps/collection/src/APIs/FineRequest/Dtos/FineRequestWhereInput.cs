namespace Collection.APIs.Dtos;

public class FineRequestWhereInput
{
    public double? AlignmentOrder { get; set; }

    public DateTime? CreatedAt { get; set; }

    public string? DeletionOn { get; set; }

    public DateTime? FinalModificationDateAndTime { get; set; }

    public string? FinalModifierId { get; set; }

    public double? FineAmount { get; set; }

    public string? FineImpositionRequestNumber { get; set; }

    public string? FineRelatedTaxCode { get; set; }

    public string? FirstRegistrantId { get; set; }

    public DateTime? FirstRegistrationDateAndTime { get; set; }

    public string? Id { get; set; }

    public string? InfractionCode { get; set; }

    public double? MaximumAmount { get; set; }

    public double? MinimumAmount { get; set; }

    public string? OperationTypeCode { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
