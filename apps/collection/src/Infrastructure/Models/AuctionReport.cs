using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Collection.Infrastructure.Models;

[Table("AuctionReports")]
public class AuctionReportDbModel
{
    [StringLength(1000)] public string? Address { get; set; }

    [StringLength(1000)] public string? AmountInWords { get; set; }

    [StringLength(1000)] public string? AttachedFileId { get; set; }

    [StringLength(1000)] public string? AuctionDate { get; set; }

    [StringLength(1000)] public string? AuctionDateAndTime { get; set; }

    [StringLength(1000)] public string? AuctionLocation { get; set; }

    [StringLength(1000)] public string? AuctionValidationOfficerId { get; set; }

    [StringLength(1000)] public string? BuyerIdentificationNumber { get; set; }

    [StringLength(1000)] public string? BuyerIdentificationTypeCode { get; set; }

    [StringLength(1000)] public string? BuyerName { get; set; }

    [StringLength(1000)] public string? CommercialRegisterNumber { get; set; }

    [StringLength(1000)] public string? ContainerNumber { get; set; }

    [Required] public DateTime CreatedAt { get; set; }

    [StringLength(1000)] public string? DeletionFlag { get; set; }

    public DateTime? FinalModificationDateAndTime { get; set; }

    [StringLength(1000)] public string? FinalModifierId { get; set; }

    [StringLength(1000)] public string? FirstRegistrantId { get; set; }

    public DateTime? FirstRegistrationDateAndTime { get; set; }

    [Key] [Required] public string Id { get; set; }

    [StringLength(1000)] public string? InventoryManagementNumber { get; set; }

    [Range(-999999999, 999999999)] public double? ItemSequenceNumber { get; set; }

    [StringLength(1000)] public string? LotNumber { get; set; }

    [StringLength(1000)] public string? MerchandiseDescription { get; set; }

    [Range(-999999999, 999999999)] public double? NetProceeds { get; set; }

    [StringLength(1000)] public string? OfficeCode { get; set; }

    [Range(-999999999, 999999999)] public double? Quantity { get; set; }

    [StringLength(1000)] public string? ReceiptDate { get; set; }

    [StringLength(1000)] public string? ReceiptNumber { get; set; }

    [StringLength(1000)] public string? RegistrationDate { get; set; }

    [Range(-999999999, 999999999)] public double? RegistrationFee { get; set; }

    [StringLength(1000)] public string? RemarksContent { get; set; }

    [StringLength(1000)] public string? SaleReportNumber { get; set; }

    [StringLength(1000)] public string? ServiceCode { get; set; }

    [Range(-999999999, 999999999)] public double? TotalAmount { get; set; }

    [Required] public DateTime UpdatedAt { get; set; }
}
