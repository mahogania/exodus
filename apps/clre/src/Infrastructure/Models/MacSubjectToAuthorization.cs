using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Clre.Infrastructure.Models;

[Table("MacSubjectToAuthorizations")]
public class MacSubjectToAuthorizationDbModel
{
    [StringLength(1000)]
    public string? ApcCode { get; set; }

    [StringLength(1000)]
    public string? ApcLabel { get; set; }

    [StringLength(1000)]
    public string? ArticleNumber { get; set; }

    [StringLength(1000)]
    public string? CountryOfDestination { get; set; }

    [StringLength(1000)]
    public string? CountryOfOrigin { get; set; }

    [Required()]
    public DateTime CreatedAt { get; set; }

    [StringLength(1000)]
    public string? CustomsOfficeForMacClearance { get; set; }

    public DateTime? DateAndTimeOfFinalModification { get; set; }

    public DateTime? DateAndTimeOfFirstRegistration { get; set; }

    [StringLength(1000)]
    public string? DeclarationOfficeCode { get; set; }

    [StringLength(1000)]
    public string? EpcCode { get; set; }

    [StringLength(1000)]
    public string? EpcLabel { get; set; }

    [StringLength(1000)]
    public string? FinalModifierSId { get; set; }

    [StringLength(1000)]
    public string? FirstRegistrantSId { get; set; }

    [Key()]
    [Required()]
    public string Id { get; set; }

    [StringLength(1000)]
    public string? PreviousDeclarationDate { get; set; }

    [StringLength(1000)]
    public string? PreviousDeclarationNumber { get; set; }

    [StringLength(1000)]
    public string? ReasonForTheRequest { get; set; }

    [StringLength(1000)]
    public string? RecipientSupplier { get; set; }

    [Range(-999999999, 999999999)]
    public double? RectificationFrequency { get; set; }

    [StringLength(1000)]
    public string? RegimeRequestNumber { get; set; }

    [StringLength(1000)]
    public string? SuppressionOn { get; set; }

    [Required()]
    public DateTime UpdatedAt { get; set; }
}
