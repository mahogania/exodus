namespace Collection.APIs.Dtos;

public class CodeUpdateInput
{
    public double? CappedAmount { get; set; }

    public DateTime? CreatedAt { get; set; }

    public string? DeletionOn { get; set; }

    public DateTime? FinalModificationDateAndTime { get; set; }

    public string? FinalModifierId { get; set; }

    public string? FineRelatedTaxCode { get; set; }

    public string? FirstRegistrantId { get; set; }

    public DateTime? FirstRegistrationDateAndTime { get; set; }

    public double? FloorAmount { get; set; }

    public string? Id { get; set; }

    public string? InfractionCode { get; set; }

    public string? InfractionCodeDescription { get; set; }

    public string? InfractionCodeDetails { get; set; }

    public string? InfractionCodeLabel { get; set; }

    public string? OperationTypeCode { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public string? UsedOn { get; set; }
}
