namespace Collection.APIs.Dtos;

public class FineRequestHistoryWhereInput
{
    public double? AlignmentOrder { get; set; }

    public double? CappedAmount { get; set; }

    public DateTime? CreatedAt { get; set; }

    public string? DeletionOn { get; set; }

    public DateTime? FinalModificationDateAndTime { get; set; }

    public string? FinalModifierId { get; set; }

    public double? FineAmount { get; set; }

    public string? FineImpositionRequestNo { get; set; }

    public string? FineRelatedTaxCode { get; set; }

    public string? FirstRegistrantId { get; set; }

    public DateTime? FirstRegistrationDateAndTime { get; set; }

    public double? FloorAmount { get; set; }

    public string? Id { get; set; }

    public string? InfractionCode { get; set; }

    public string? OperationTypeCode { get; set; }

    public double? RequestOrderNumber { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
