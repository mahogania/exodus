using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Collection.Infrastructure.Models;

[Table("ManageRecklessBidders")]
public class ManageRecklessBidderDbModel
{
    [StringLength(1000)] public string? BidderIdentificationNo { get; set; }

    [StringLength(1000)] public string? BidderIdentificationNoTypeCode { get; set; }

    [StringLength(1000)] public string? BidderName { get; set; }

    [Required] public DateTime CreatedAt { get; set; }

    [StringLength(1000)] public string? DeletionOn { get; set; }

    [Range(-999999999, 999999999)] public double? DetailSequenceNo { get; set; }

    public DateTime? FinalModificationDateAndTime { get; set; }

    [StringLength(1000)] public string? FinalModifierId { get; set; }

    [StringLength(1000)] public string? FirstRegistrantId { get; set; }

    public DateTime? FirstRegistrationDateAndTime { get; set; }

    [Key] [Required] public string Id { get; set; }

    [StringLength(1000)] public string? LotNo { get; set; }

    [StringLength(1000)] public string? OfficeCode { get; set; }

    [StringLength(1000)] public string? RegistrationPersonIdentifier { get; set; }

    [StringLength(1000)] public string? RemarkContent { get; set; }

    [StringLength(1000)] public string? SalePvNo { get; set; }

    [StringLength(1000)] public string? ServiceCode { get; set; }

    [Required] public DateTime UpdatedAt { get; set; }
}
