using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Traveler.Infrastructure.Models;

[Table("TpdVehicles")]
public class TpdVehicleDbModel
{
    [StringLength(1000)]
    public string? ChassisNumber { get; set; }

    [Required()]
    public DateTime CreatedAt { get; set; }

    [StringLength(1000)]
    public string? DeletionOn { get; set; }

    [StringLength(1000)]
    public string? EngineCapacity { get; set; }

    public DateTime? FinalModificationDateAndTime { get; set; }

    [StringLength(1000)]
    public string? FirstRegistrationDate { get; set; }

    public DateTime? FirstRegistrationDateAndTime { get; set; }

    public List<GeneralTravelerInformationTpdDbModel>? GeneralTravelerInformationTpds { get; set; } =
        new List<GeneralTravelerInformationTpdDbModel>();

    [Range(-999999999, 999999999)]
    public double? Gvw { get; set; }

    [Key()]
    [Required()]
    public string Id { get; set; }

    [Range(-999999999, 999999999)]
    public int? NumberOfSeats { get; set; }

    [Range(-999999999, 999999999)]
    public double? Payload { get; set; }

    [StringLength(1000)]
    public string? ProvisionalTpdNumber { get; set; }

    [StringLength(1000)]
    public string? TpdVehicleBodyCode { get; set; }

    [StringLength(1000)]
    public string? TpdVehicleBrandCode { get; set; }

    [StringLength(1000)]
    public string? TpdVehicleColorCode { get; set; }

    [StringLength(1000)]
    public string? TpdVehicleEnergyCode { get; set; }

    [StringLength(1000)]
    public string? TpdVehicleGenreCode { get; set; }

    [StringLength(1000)]
    public string? TpdVehicleTypeCode { get; set; }

    [Required()]
    public DateTime UpdatedAt { get; set; }

    [StringLength(1000)]
    public string? VehicleManufacturerCode { get; set; }

    [StringLength(1000)]
    public string? VehicleModelCode { get; set; }

    [Range(-999999999, 999999999)]
    public double? VehiclePower { get; set; }

    [StringLength(1000)]
    public string? VehicleRegistrationNumber { get; set; }
}
