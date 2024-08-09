using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Control.Infrastructure.Models;

[Table("WarehouseTransferPublicPrivates")]
public class WarehouseTransferPublicPrivateDbModel
{
    [StringLength(1000)]
    public string? Address { get; set; }

    [StringLength(1000)]
    public string? ApcCode { get; set; }

    [Required()]
    public DateTime CreatedAt { get; set; }

    [StringLength(1000)]
    public string? CustomsClearanceOfficeOfDeclaration { get; set; }

    [StringLength(1000)]
    public string? CustomsClearanceOfficeOfTheOperation { get; set; }

    public DateTime? DateAndTimeOfFinalModification { get; set; }

    public DateTime? DateAndTimeOfFirstRegistration { get; set; }

    [StringLength(1000)]
    public string? DeclarationDate { get; set; }

    [StringLength(1000)]
    public string? DeclarationNumber { get; set; }

    [StringLength(1000)]
    public string? DesignationOfTheSubCustomsZone { get; set; }

    [StringLength(1000)]
    public string? EpcCode { get; set; }

    [StringLength(1000)]
    public string? ExpiryDate { get; set; }

    [StringLength(1000)]
    public string? FinalModifierSId { get; set; }

    [StringLength(1000)]
    public string? FirstRegistrantSId { get; set; }

    [Key()]
    [Required()]
    public string Id { get; set; }

    [StringLength(1000)]
    public string? ImporterSAddress { get; set; }

    [StringLength(1000)]
    public string? ImporterSName { get; set; }

    [StringLength(1000)]
    public string? LabelApc { get; set; }

    [StringLength(1000)]
    public string? LabelEpc { get; set; }

    [StringLength(1000)]
    public string? NameAndBusinessName { get; set; }

    [StringLength(1000)]
    public string? Nif { get; set; }

    [StringLength(1000)]
    public string? NifStatus { get; set; }

    [Range(-999999999, 999999999)]
    public double? NumberOfArticles { get; set; }

    [StringLength(1000)]
    public string? NumberOfTheImporterSTradeRegister { get; set; }

    [StringLength(1000)]
    public string? PurposeOfTheRequest { get; set; }

    [StringLength(1000)]
    public string? RcStatus { get; set; }

    [StringLength(1000)]
    public string? ReasonForTheRequest { get; set; }

    [Range(-999999999, 999999999)]
    public double? RectificationFrequency { get; set; }

    [StringLength(1000)]
    public string? RequestNumberOfRegime { get; set; }

    [StringLength(1000)]
    public string? RequestedEndDate { get; set; }

    [StringLength(1000)]
    public string? RequestedStartDate { get; set; }

    [StringLength(1000)]
    public string? SuppressionOn { get; set; }

    [StringLength(1000)]
    public string? TradeRegisterNumberOfTheImporter { get; set; }

    [StringLength(1000)]
    public string? TypeOfTheSubCustomsZone { get; set; }

    [Required()]
    public DateTime UpdatedAt { get; set; }
}
