using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Clre.Infrastructure.Models;

[Table("CommonRegimeRequests")]
public class CommonRegimeRequestDbModel
{
    [StringLength(1000)]
    public string? ApcCode { get; set; }

    [StringLength(1000)]
    public string? AttachedFileId { get; set; }

    [StringLength(1000)]
    public string? ComplementaryRequestContent { get; set; }

    [StringLength(1000)]
    public string? ComplementaryRequestResponseContent { get; set; }

    [Required()]
    public DateTime CreatedAt { get; set; }

    [StringLength(1000)]
    public string? CustomsOfficeCode { get; set; }

    public DateTime? DateAndTimeOfFinalModification { get; set; }

    public DateTime? DateAndTimeOfFirstRegistration { get; set; }

    [StringLength(1000)]
    public string? DeclarantCode { get; set; }

    [StringLength(1000)]
    public string? DeletionOn { get; set; }

    [StringLength(1000)]
    public string? DocumentCode { get; set; }

    [StringLength(1000)]
    public string? EpcCode { get; set; }

    [StringLength(1000)]
    public string? FinalModifierSId { get; set; }

    [StringLength(1000)]
    public string? FinalOn { get; set; }

    [StringLength(1000)]
    public string? FirstRecorderSId { get; set; }

    [Key()]
    [Required()]
    public string Id { get; set; }

    [StringLength(1000)]
    public string? ProcessingStatusCode { get; set; }

    [Range(-999999999, 999999999)]
    public double? RectificationFrequency { get; set; }

    [StringLength(1000)]
    public string? RegimeRequestContent { get; set; }

    [StringLength(1000)]
    public string? RegimeRequestNumber { get; set; }

    [StringLength(1000)]
    public string? RegimeRequestTitle { get; set; }

    [StringLength(1000)]
    public string? RegimeValidationDate { get; set; }

    [StringLength(1000)]
    public string? RequestDate { get; set; }

    [Required()]
    public DateTime UpdatedAt { get; set; }
}
