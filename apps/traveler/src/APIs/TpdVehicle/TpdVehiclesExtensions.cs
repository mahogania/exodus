using Traveler.APIs.Dtos;
using Traveler.Infrastructure.Models;

namespace Traveler.APIs.Extensions;

public static class TpdVehiclesExtensions
{
    public static TpdVehicle ToDto(this TpdVehicleDbModel model)
    {
        return new TpdVehicle
        {
            ChassisNumber = model.ChassisNumber,
            CreatedAt = model.CreatedAt,
            DeletionOn = model.DeletionOn,
            EngineCapacity = model.EngineCapacity,
            FinalModificationDateAndTime = model.FinalModificationDateAndTime,
            FirstRegistrationDate = model.FirstRegistrationDate,
            FirstRegistrationDateAndTime = model.FirstRegistrationDateAndTime,
            GeneralTravelerInformationTpds = model
                .GeneralTravelerInformationTpds?.Select(x => x.Id)
                .ToList(),
            Gvw = model.Gvw,
            Id = model.Id,
            NumberOfSeats = model.NumberOfSeats,
            Payload = model.Payload,
            ProvisionalTpdNumber = model.ProvisionalTpdNumber,
            TpdVehicleBodyCode = model.TpdVehicleBodyCode,
            TpdVehicleBrandCode = model.TpdVehicleBrandCode,
            TpdVehicleColorCode = model.TpdVehicleColorCode,
            TpdVehicleEnergyCode = model.TpdVehicleEnergyCode,
            TpdVehicleGenreCode = model.TpdVehicleGenreCode,
            TpdVehicleTypeCode = model.TpdVehicleTypeCode,
            UpdatedAt = model.UpdatedAt,
            VehicleManufacturerCode = model.VehicleManufacturerCode,
            VehicleModelCode = model.VehicleModelCode,
            VehiclePower = model.VehiclePower,
            VehicleRegistrationNumber = model.VehicleRegistrationNumber,
        };
    }

    public static TpdVehicleDbModel ToModel(
        this TpdVehicleUpdateInput updateDto,
        TpdVehicleWhereUniqueInput uniqueId
    )
    {
        var tpdVehicle = new TpdVehicleDbModel
        {
            Id = uniqueId.Id,
            ChassisNumber = updateDto.ChassisNumber,
            DeletionOn = updateDto.DeletionOn,
            EngineCapacity = updateDto.EngineCapacity,
            FinalModificationDateAndTime = updateDto.FinalModificationDateAndTime,
            FirstRegistrationDate = updateDto.FirstRegistrationDate,
            FirstRegistrationDateAndTime = updateDto.FirstRegistrationDateAndTime,
            Gvw = updateDto.Gvw,
            NumberOfSeats = updateDto.NumberOfSeats,
            Payload = updateDto.Payload,
            ProvisionalTpdNumber = updateDto.ProvisionalTpdNumber,
            TpdVehicleBodyCode = updateDto.TpdVehicleBodyCode,
            TpdVehicleBrandCode = updateDto.TpdVehicleBrandCode,
            TpdVehicleColorCode = updateDto.TpdVehicleColorCode,
            TpdVehicleEnergyCode = updateDto.TpdVehicleEnergyCode,
            TpdVehicleGenreCode = updateDto.TpdVehicleGenreCode,
            TpdVehicleTypeCode = updateDto.TpdVehicleTypeCode,
            VehicleManufacturerCode = updateDto.VehicleManufacturerCode,
            VehicleModelCode = updateDto.VehicleModelCode,
            VehiclePower = updateDto.VehiclePower,
            VehicleRegistrationNumber = updateDto.VehicleRegistrationNumber
        };

        if (updateDto.CreatedAt != null)
        {
            tpdVehicle.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.UpdatedAt != null)
        {
            tpdVehicle.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return tpdVehicle;
    }
}
