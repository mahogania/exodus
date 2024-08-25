namespace Control.APIs.Dtos;

public class RawMaterialOfTheDetailedDeclarationCustomsUpdateInput
{
    public string? ArticleNumber { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? DateAndTimeOfFinalModification { get; set; }

    public DateTime? DateAndTimeOfFirstRegistration { get; set; }

    public string? FinalModifierSId { get; set; }

    public string? FirstRegistrantSId { get; set; }

    public string? Id { get; set; }

    public double? MaterialRawSequenceNumber { get; set; }

    public double? NetWeight { get; set; }

    public string? PartialClearanceTypeCode { get; set; }

    public string? PreviousArticleNumber { get; set; }

    public string? PreviousDetailedDeclarationNumber { get; set; }

    public string? PreviousShCode { get; set; }

    public string? PreviousSpecificCodeOfTheMerchandiseClassification { get; set; }

    public double? Quantity { get; set; }

    public string? QuantityUnitCode { get; set; }

    public double? RectificationFrequency { get; set; }

    public string? ReferenceNumber { get; set; }

    public string? SuppressionOn { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
