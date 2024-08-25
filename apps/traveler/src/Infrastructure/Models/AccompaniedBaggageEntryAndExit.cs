using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Traveler.Infrastructure.Models;

[Table("AccompaniedBaggageEntryAndExits")]
public class AccompaniedBaggageEntryAndExitDbModel
{
    [StringLength(1000)]
    public string? BaggageNumber { get; set; }

    [Required()]
    public DateTime CreatedAt { get; set; }

    [StringLength(1000)]
    public string? DeletionOn { get; set; }

    [StringLength(1000)]
    public string? DepositBulletinNumber { get; set; }

    [StringLength(1000)]
    public string? EntryAndExitCategoryCode { get; set; }

    [StringLength(1000)]
    public string? ExitRequestDate { get; set; }

    [StringLength(1000)]
    public string? ExitRequestTypeCode { get; set; }

    public DateTime? FinalModificationDateAndTime { get; set; }

    public DateTime? FirstRegistrationDateAndTime { get; set; }

    public List<GeneralTravelerInformationTpdDbModel>? GeneralTravelerInformationTpds { get; set; } =
        new List<GeneralTravelerInformationTpdDbModel>();

    [Key()]
    [Required()]
    public string Id { get; set; }

    [StringLength(1000)]
    public string? OfficerId { get; set; }

    [StringLength(1000)]
    public string? PersonalEffectsClearanceNumber { get; set; }

    [StringLength(1000)]
    public string? RemovalDate { get; set; }

    [Range(-999999999, 999999999)]
    public double? StockQuantity { get; set; }

    [Range(-999999999, 999999999)]
    public double? StockWeight { get; set; }

    [StringLength(1000)]
    public string? TravelerName { get; set; }

    [Required()]
    public DateTime UpdatedAt { get; set; }
}
