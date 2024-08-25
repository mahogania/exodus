namespace Traveler.APIs.Dtos;

public class TpdVehicleCreateInput
{
    public string? ChassisNumber { get; set; }

    public DateTime CreatedAt { get; set; }

    public string? DeletionOn { get; set; }

    public string? EngineCapacity { get; set; }

    public DateTime? FinalModificationDateAndTime { get; set; }

    public string? FirstRegistrationDate { get; set; }

    public DateTime? FirstRegistrationDateAndTime { get; set; }

    public List<GeneralTravelerInformationTpd>? GeneralTravelerInformationTpds { get; set; }

    public double? Gvw { get; set; }

    public string? Id { get; set; }

    public int? NumberOfSeats { get; set; }

    public double? Payload { get; set; }

    public string? ProvisionalTpdNumber { get; set; }

    public string? TpdVehicleBodyCode { get; set; }

    public string? TpdVehicleBrandCode { get; set; }

    public string? TpdVehicleColorCode { get; set; }

    public string? TpdVehicleEnergyCode { get; set; }

    public string? TpdVehicleGenreCode { get; set; }

    public string? TpdVehicleTypeCode { get; set; }

    public DateTime UpdatedAt { get; set; }

    public string? VehicleManufacturerCode { get; set; }

    public string? VehicleModelCode { get; set; }

    public double? VehiclePower { get; set; }

    public string? VehicleRegistrationNumber { get; set; }
}
