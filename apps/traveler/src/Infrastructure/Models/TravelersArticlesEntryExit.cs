using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Traveler.Infrastructure.Models;

[Table("TravelersArticlesEntryExits")]
public class TravelersArticlesEntryExitDbModel
{
    [Required()]
    public DateTime CreatedAt { get; set; }

    [StringLength(1000)]
    public string? DeletionOn { get; set; }

    [Range(-999999999, 999999999)]
    public double? DepositedArticleSerialNumber { get; set; }

    [StringLength(1000)]
    public string? EntryAndExitCategoryCode { get; set; }

    [Range(-999999999, 999999999)]
    public double? ExitedWeight { get; set; }

    public DateTime? FinalModificationDateAndTime { get; set; }

    public DateTime? FirstRegistrationDateAndTime { get; set; }

    public List<GeneralTravelerInformationTpdDbModel>? GeneralTravelerInformationTpds { get; set; } =
        new List<GeneralTravelerInformationTpdDbModel>();

    [Key()]
    [Required()]
    public string Id { get; set; }

    public List<ImportDeclarationDbModel>? ImportDeclarations { get; set; } =
        new List<ImportDeclarationDbModel>();

    [StringLength(1000)]
    public string? QuantityUnitCode { get; set; }

    [StringLength(1000)]
    public string? RemovalVoucherNumber { get; set; }

    [StringLength(1000)]
    public string? SectorCode { get; set; }

    [Range(-999999999, 999999999)]
    public double? StockQuantity { get; set; }

    [Range(-999999999, 999999999)]
    public double? StockWeight { get; set; }

    [StringLength(1000)]
    public string? TravelerName { get; set; }

    [Required()]
    public DateTime UpdatedAt { get; set; }

    [StringLength(1000)]
    public string? WeightUnit { get; set; }
}
