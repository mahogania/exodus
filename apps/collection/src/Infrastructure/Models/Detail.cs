using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Collection.Infrastructure.Models;

[Table("Details")]
public class DetailDbModel
{
    [StringLength(1000)] public string? AttachmentId { get; set; }

    [StringLength(1000)] public string? ChassisNo { get; set; }

    [StringLength(1000)] public string? ContainerNo { get; set; }

    [Required] public DateTime CreatedAt { get; set; }

    [StringLength(1000)] public string? DeletionOn { get; set; }

    [Range(-999999999, 999999999)] public double? EstimatedAuctionSalePrice { get; set; }

    public DateTime? FinalModificationDateAndTime { get; set; }

    [StringLength(1000)] public string? FinalModifierId { get; set; }

    [StringLength(1000)] public string? FinalUseCode { get; set; }

    [StringLength(1000)] public string? FirstCirculationDate { get; set; }

    [StringLength(1000)] public string? FirstRegistrantId { get; set; }

    public DateTime? FirstRegistrationDateAndTime { get; set; }

    [Range(-999999999, 999999999)] public double? GrossWeight { get; set; }

    [Key] [Required] public string Id { get; set; }

    [Range(-999999999, 999999999)] public double? ItemSequenceNumber { get; set; }

    [Range(-999999999, 999999999)] public double? MaximumLoad { get; set; }

    [StringLength(1000)] public string? MerchandiseDescription { get; set; }

    [Range(-999999999, 999999999)] public double? NumberOfSeats { get; set; }

    [Range(-999999999, 999999999)] public double? Quantity { get; set; }

    [StringLength(1000)] public string? ReferenceNumberTypeCode { get; set; }

    [StringLength(1000)] public string? ReferenceNumberTypeName { get; set; }

    [StringLength(1000)] public string? RegistrationDate { get; set; }

    [StringLength(1000)] public string? RegistrationNumber { get; set; }

    [StringLength(1000)] public string? RemarkContent { get; set; }

    [StringLength(1000)] public string? StockAccountingManagementNumber { get; set; }

    [Required] public DateTime UpdatedAt { get; set; }

    [StringLength(1000)] public string? VehicleBrandName { get; set; }

    [Range(-999999999, 999999999)] public double? VehicleCylinder { get; set; }

    [StringLength(1000)] public string? VehicleEnergy { get; set; }

    [StringLength(1000)] public string? VehicleModelName { get; set; }

    [StringLength(1000)] public string? VehicleOn { get; set; }

    [Range(-999999999, 999999999)] public double? VehiclePower { get; set; }

    [StringLength(1000)] public string? VehicleType { get; set; }
}
