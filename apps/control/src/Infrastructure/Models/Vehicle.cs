using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Control.Infrastructure.Models;

[Table("Vehicles")]
public class VehicleDbModel
{
    [StringLength(1000)]
    public string? ArticleNumber { get; set; }

    public ArticleDbModel? Articles { get; set; } = null;

    [StringLength(1000)]
    public string? Body { get; set; }

    [StringLength(1000)]
    public string? ChassisNumber { get; set; }

    [StringLength(1000)]
    public string? ColorName { get; set; }

    [Required()]
    public DateTime CreatedAt { get; set; }

    [StringLength(1000)]
    public string? CubicCapacity { get; set; }

    public DateTime? DateAndTimeOfFinalModification { get; set; }

    public DateTime? DateAndTimeOfFirstRegistration { get; set; }

    [StringLength(1000)]
    public string? DateOfEndOfInalienability { get; set; }

    [StringLength(1000)]
    public string? DateOfFirstCirculation { get; set; }

    [StringLength(1000)]
    public string? DateOfRelease { get; set; }

    [StringLength(1000)]
    public string? DateOfStartOfInalienability { get; set; }

    [StringLength(1000)]
    public string? DriverSAddress { get; set; }

    [StringLength(1000)]
    public string? DriverSName { get; set; }

    [StringLength(1000)]
    public string? DriverSZipCode { get; set; }

    [StringLength(1000)]
    public string? Energy { get; set; }

    [StringLength(1000)]
    public string? FinalModifierSId { get; set; }

    [StringLength(1000)]
    public string? FirstRegistrantSId { get; set; }

    [StringLength(1000)]
    public string? Frame { get; set; }

    [Key()]
    [Required()]
    public string Id { get; set; }

    [StringLength(1000)]
    public string? Inalienability { get; set; }

    [StringLength(1000)]
    public string? LoadU { get; set; }

    [StringLength(1000)]
    public string? ModelAndSpecificationNumber { get; set; }

    [Range(-999999999, 999999999)]
    public double? NumberOfSeats { get; set; }

    [StringLength(1000)]
    public string? Power { get; set; }

    [Range(-999999999, 999999999)]
    public double? RectificationFrequency { get; set; }

    [StringLength(1000)]
    public string? ReferenceNumber { get; set; }

    [StringLength(1000)]
    public string? RegistrationNumber { get; set; }

    [StringLength(1000)]
    public string? SuppressionOn { get; set; }

    [StringLength(1000)]
    public string? TotalWeightC { get; set; }

    [StringLength(1000)]
    public string? TpdManagementNumber { get; set; }

    [Required()]
    public DateTime UpdatedAt { get; set; }

    [StringLength(1000)]
    public string? VehicleManufacturerCode { get; set; }

    [StringLength(1000)]
    public string? VehicleModelCode { get; set; }

    [StringLength(1000)]
    public string? VehicleType { get; set; }

    [StringLength(1000)]
    public string? VehicleTypeCode { get; set; }

    [StringLength(1000)]
    public string? YearOfManufacture { get; set; }
}
