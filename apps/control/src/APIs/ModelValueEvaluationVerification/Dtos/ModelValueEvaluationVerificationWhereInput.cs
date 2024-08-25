namespace Control.APIs.Dtos;

public class ModelValueEvaluationVerificationWhereInput
{
    public string? ArticleNumber { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? DateAndTimeOfFinalModification { get; set; }

    public DateTime? DateAndTimeOfInitialRecord { get; set; }

    public double? DeclaredInvoicePrice { get; set; }

    public double? DeclaredQuantity { get; set; }

    public string? DeclaredQuantityUnitCode { get; set; }

    public double? DeclaredUnitPrice { get; set; }

    public DateTime? DeletedOn { get; set; }

    public string? FinalModifierId { get; set; }

    public string? Id { get; set; }

    public string? InitialRecorderId { get; set; }

    public double? LiquidatedInvoicePrice { get; set; }

    public double? LiquidatedQuantity { get; set; }

    public string? LiquidatedQuantityUnitCode { get; set; }

    public double? LiquidatedUnitPrice { get; set; }

    public string? ModelAndSpecificationNumber { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public string? ValueEvaluationContent { get; set; }
}
