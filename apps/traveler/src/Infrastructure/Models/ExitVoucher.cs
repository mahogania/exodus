using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Traveler.Infrastructure.Models;

[Table("ExitVouchers")]
public class ExitVoucherDbModel
{
    [Required()]
    public DateTime CreatedAt { get; set; }

    [StringLength(1000)]
    public string? DeletionOn { get; set; }

    [StringLength(1000)]
    public string? ExitRequestDate { get; set; }

    [Range(-999999999, 999999999)]
    public double? ExitVoucherSerialNumber { get; set; }

    public DateTime? FinalModificationDateAndTime { get; set; }

    public DateTime? FirstRegistrationDateAndTime { get; set; }

    public List<GeneralTravelerInformationTpdDbModel>? GeneralTravelerInformationTpds { get; set; } =
        new List<GeneralTravelerInformationTpdDbModel>();

    [Key()]
    [Required()]
    public string Id { get; set; }

    [StringLength(1000)]
    public string? OfficeCode { get; set; }

    [StringLength(1000)]
    public string? ReferenceNumber { get; set; }

    [Required()]
    public DateTime UpdatedAt { get; set; }

    [StringLength(1000)]
    public string? VerifierId { get; set; }
}
