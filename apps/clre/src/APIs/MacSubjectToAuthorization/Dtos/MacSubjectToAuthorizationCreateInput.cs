namespace Clre.APIs.Dtos;

public class MacSubjectToAuthorizationCreateInput
{
    public string? ApcCode { get; set; }

    public string? ApcLabel { get; set; }

    public string? ArticleNumber { get; set; }

    public string? CountryOfDestination { get; set; }

    public string? CountryOfOrigin { get; set; }

    public DateTime CreatedAt { get; set; }

    public string? CustomsOfficeForMacClearance { get; set; }

    public DateTime? DateAndTimeOfFinalModification { get; set; }

    public DateTime? DateAndTimeOfFirstRegistration { get; set; }

    public string? DeclarationOfficeCode { get; set; }

    public string? EpcCode { get; set; }

    public string? EpcLabel { get; set; }

    public string? FinalModifierSId { get; set; }

    public string? FirstRegistrantSId { get; set; }

    public string? Id { get; set; }

    public string? PreviousDeclarationDate { get; set; }

    public string? PreviousDeclarationNumber { get; set; }

    public string? ReasonForTheRequest { get; set; }

    public string? RecipientSupplier { get; set; }

    public double? RectificationFrequency { get; set; }

    public string? RegimeRequestNumber { get; set; }

    public string? SuppressionOn { get; set; }

    public DateTime UpdatedAt { get; set; }
}
