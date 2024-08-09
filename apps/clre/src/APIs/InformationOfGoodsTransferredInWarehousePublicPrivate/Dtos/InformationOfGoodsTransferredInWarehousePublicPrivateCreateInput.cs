namespace Clre.APIs.Dtos;

public class InformationOfGoodsTransferredInWarehousePublicPrivateCreateInput
{
    public string? CommercialDesignationOfGoods { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? DateAndTimeOfFinalModification { get; set; }

    public DateTime? DateAndTimeOfFirstRegistration { get; set; }

    public string? FinalModifierSId { get; set; }

    public string? FirstRegistrantSId { get; set; }

    public string? Id { get; set; }

    public string? NumberOfTheConcernedArticle { get; set; }

    public string? Origin { get; set; }

    public double? Quantity { get; set; }

    public double? RectificationFrequency { get; set; }

    public string? ReferencesOfTheConcernedArticleModelS { get; set; }

    public string? RegimeRequestNumber { get; set; }

    public double? SequenceNumber { get; set; }

    public string? SptNumber { get; set; }

    public string? SuppressionOn { get; set; }

    public string? TechnicalDesignationOfGoods { get; set; }

    public DateTime UpdatedAt { get; set; }

    public double? Value { get; set; }
}
