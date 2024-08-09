namespace Clre.APIs.Dtos;

public class RequestForTirCarnetOfTheArticle
{
    public double? ArticleSequenceNumber { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? DateAndTimeOfFinalModification { get; set; }

    public DateTime? DateAndTimeOfFirstRegistration { get; set; }

    public string? DescCtn { get; set; }

    public string? FinalModifierSId { get; set; }

    public string? FirstRegistrantSId { get; set; }

    public string Id { get; set; }

    public string? PackageDescription { get; set; }

    public string? Packaging { get; set; }

    public string? SuppressionOn { get; set; }

    public string? TirRegistrationNumber { get; set; }

    public DateTime UpdatedAt { get; set; }

    public double? Weight { get; set; }
}
