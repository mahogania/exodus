namespace Control.APIs.Dtos;

public class GoodsSubjectToAuthorizationCreateInput
{
    public string? CommercialDesignationOfMaterials { get; set; }

    public DateTime CreatedAt { get; set; }

    public string? CurrencyCode { get; set; }

    public DateTime? DateAndTimeOfFinalModification { get; set; }

    public DateTime? DateAndTimeOfFirstRegistration { get; set; }

    public string? DeletionOn { get; set; }

    public string? FinalModifierSId { get; set; }

    public string? FirstRecorderSId { get; set; }

    public string? Id { get; set; }

    public string? Identification { get; set; }

    public string? NumberOfTheArticleConcerned { get; set; }

    public string? Origin { get; set; }

    public double? Quantity { get; set; }

    public double? RectificationFrequency { get; set; }

    public string? ReferenceSOfTheModelSOfTheArticleConcerned { get; set; }

    public string? RegimeRequestNumber { get; set; }

    public double? SequenceNumber { get; set; }

    public string? SptNumber { get; set; }

    public string? TechnicalDesignationOfMaterials { get; set; }

    public DateTime UpdatedAt { get; set; }

    public double? Value { get; set; }
}
