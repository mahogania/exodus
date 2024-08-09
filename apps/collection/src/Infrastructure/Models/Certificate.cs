using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Collection.Infrastructure.Models;

[Table("Certificates")]
public class CertificateDbModel
{
    [StringLength(1000)]
    public string? AttachmentId { get; set; }

    [StringLength(1000)]
    public string? BatchNo { get; set; }

    [StringLength(1000)]
    public string? ChassisNo { get; set; }

    [Required()]
    public DateTime CreatedAt { get; set; }

    [StringLength(1000)]
    public string? DeletionOn { get; set; }

    public DateTime? FinalModificationDateAndTime { get; set; }

    [StringLength(1000)]
    public string? FinalModifierId { get; set; }

    [StringLength(1000)]
    public string? FirstRegistrantId { get; set; }

    [StringLength(1000)]
    public string? FirstRegistrationDate { get; set; }

    public DateTime? FirstRegistrationDateAndTime { get; set; }

    [Range(-999999999, 999999999)]
    public double? GrossWeight { get; set; }

    [Key()]
    [Required()]
    public string Id { get; set; }

    [Range(-999999999, 999999999)]
    public double? MaximumLoad { get; set; }

    [Range(-999999999, 999999999)]
    public double? NumberOfSeats { get; set; }

    [StringLength(1000)]
    public string? OfficeCode { get; set; }

    [StringLength(1000)]
    public string? RegistrationNo { get; set; }

    [StringLength(1000)]
    public string? RemarkContent { get; set; }

    [StringLength(1000)]
    public string? SaleCertificateNo { get; set; }

    [StringLength(1000)]
    public string? SalePvNo { get; set; }

    [StringLength(1000)]
    public string? ServiceCode { get; set; }

    [StringLength(1000)]
    public string? TransferDecisionNo { get; set; }

    [Required()]
    public DateTime UpdatedAt { get; set; }

    [StringLength(1000)]
    public string? VehicleBrandName { get; set; }

    [Range(-999999999, 999999999)]
    public double? VehicleCylinder { get; set; }

    [StringLength(1000)]
    public string? VehicleEnergy { get; set; }

    [StringLength(1000)]
    public string? VehicleModelName { get; set; }

    [Range(-999999999, 999999999)]
    public double? VehiclePower { get; set; }

    [StringLength(1000)]
    public string? VehicleType { get; set; }
}
