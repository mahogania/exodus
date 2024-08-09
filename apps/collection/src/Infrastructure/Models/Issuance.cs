using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Collection.Infrastructure.Models;

[Table("Issuances")]
public class IssuanceDbModel
{
    [StringLength(1000)]
    public string? CollectionNo { get; set; }

    [Required()]
    public DateTime CreatedAt { get; set; }

    [StringLength(1000)]
    public string? DeletionOn { get; set; }

    public DateTime? FinalModificationDateAndTime { get; set; }

    [StringLength(1000)]
    public string? FinalModifierId { get; set; }

    [StringLength(1000)]
    public string? FirstRegistrantId { get; set; }

    public DateTime? FirstRegistrationDateAndTime { get; set; }

    [Key()]
    [Required()]
    public string Id { get; set; }

    [StringLength(1000)]
    public string? IssuingPersonId { get; set; }

    [Range(-999999999, 999999999)]
    public double? NumberOfIssuances { get; set; }

    [StringLength(1000)]
    public string? OfficeCode { get; set; }

    public DateTime? PublicationDate { get; set; }

    [StringLength(1000)]
    public string? ServiceCode { get; set; }

    [Required()]
    public DateTime UpdatedAt { get; set; }
}
