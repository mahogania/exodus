namespace Control.APIs.Dtos;

public class DetailsOfTheCustomsClearanceOfPostalGoods
{
    public double? AmountNcyOfTheInvoiceOfTheArticle { get; set; }

    public double? AmountOfTheInvoiceOfTheArticle { get; set; }

    public string? ArticleName { get; set; }

    public string? ArticleNumber { get; set; }

    public string? CountryCodeOfOrigin { get; set; }

    public DateTime CreatedAt { get; set; }

    public string? CurrencyCodeOfTheInvoiceOfTheArticle { get; set; }

    public DateTime? DateAndTimeOfFinalModification { get; set; }

    public DateTime? DateAndTimeOfFirstRegistration { get; set; }

    public double? DeclaredInsuranceAmount { get; set; }

    public double? ExchangeRateOfTheInvoiceOfTheArticle { get; set; }

    public string? FinalModifierSId { get; set; }

    public string? FirstRegistrantSId { get; set; }

    public string Id { get; set; }

    public string? LiquidatedShCode { get; set; }

    public double? NetWeightOfTheArticle { get; set; }

    public double? Quantity { get; set; }

    public string? RequestNumberOfTheCustomsClearanceOfPostalParcels { get; set; }

    public string? RevisedDescriptionOfTheArticle { get; set; }

    public double? SequenceNumber { get; set; }

    public string? ShCode { get; set; }

    public string? SuppressionOn { get; set; }

    public double? TotalWeightKg { get; set; }

    public DateTime UpdatedAt { get; set; }
}
