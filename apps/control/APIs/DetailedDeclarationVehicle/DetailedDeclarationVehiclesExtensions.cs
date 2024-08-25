using Control.APIs.Dtos;
using Control.Infrastructure.Models;

namespace Control.APIs.Extensions;

public static class DetailedDeclarationVehiclesExtensions
{
    public static DetailedDeclarationVehicle ToDto(this DetailedDeclarationVehicleDbModel model)
    {
        return new DetailedDeclarationVehicle
        {
            ArticleNumber = model.ArticleNumber,
            Body = model.Body,
            ChassisNumber = model.ChassisNumber,
            ColorName = model.ColorName,
            CreatedAt = model.CreatedAt,
            CubicCapacity = model.CubicCapacity,
            DateAndTimeOfFinalModification = model.DateAndTimeOfFinalModification,
            DateAndTimeOfFirstRegistration = model.DateAndTimeOfFirstRegistration,
            DateOfEndOfInalienability = model.DateOfEndOfInalienability,
            DateOfFirstCirculation = model.DateOfFirstCirculation,
            DateOfRelease = model.DateOfRelease,
            DateOfStartOfInalienability = model.DateOfStartOfInalienability,
            DriverSAddress = model.DriverSAddress,
            DriverSName = model.DriverSName,
            DriverSZipCode = model.DriverSZipCode,
            Energy = model.Energy,
            FinalModifierSId = model.FinalModifierSId,
            FirstRegistrantSId = model.FirstRegistrantSId,
            Frame = model.Frame,
            Id = model.Id,
            Inalienability = model.Inalienability,
            LoadU = model.LoadU,
            ModelAndSpecificationNumber = model.ModelAndSpecificationNumber,
            NumberOfSeats = model.NumberOfSeats,
            Power = model.Power,
            RectificationFrequency = model.RectificationFrequency,
            ReferenceNumber = model.ReferenceNumber,
            RegistrationNumber = model.RegistrationNumber,
            SuppressionOn = model.SuppressionOn,
            TotalWeightC = model.TotalWeightC,
            TpdManagementNumber = model.TpdManagementNumber,
            UpdatedAt = model.UpdatedAt,
            VehicleManufacturerCode = model.VehicleManufacturerCode,
            VehicleModelCode = model.VehicleModelCode,
            VehicleType = model.VehicleType,
            VehicleTypeCode = model.VehicleTypeCode,
            YearOfManufacture = model.YearOfManufacture
        };
    }

    public static DetailedDeclarationVehicleDbModel ToModel(
        this DetailedDeclarationVehicleUpdateInput updateDto,
        DetailedDeclarationVehicleWhereUniqueInput uniqueId
    )
    {
        var detailedDeclarationVehicle = new DetailedDeclarationVehicleDbModel
        {
            Id = uniqueId.Id,
            ArticleNumber = updateDto.ArticleNumber,
            Body = updateDto.Body,
            ChassisNumber = updateDto.ChassisNumber,
            ColorName = updateDto.ColorName,
            CubicCapacity = updateDto.CubicCapacity,
            DateAndTimeOfFinalModification = updateDto.DateAndTimeOfFinalModification,
            DateAndTimeOfFirstRegistration = updateDto.DateAndTimeOfFirstRegistration,
            DateOfEndOfInalienability = updateDto.DateOfEndOfInalienability,
            DateOfFirstCirculation = updateDto.DateOfFirstCirculation,
            DateOfRelease = updateDto.DateOfRelease,
            DateOfStartOfInalienability = updateDto.DateOfStartOfInalienability,
            DriverSAddress = updateDto.DriverSAddress,
            DriverSName = updateDto.DriverSName,
            DriverSZipCode = updateDto.DriverSZipCode,
            Energy = updateDto.Energy,
            FinalModifierSId = updateDto.FinalModifierSId,
            FirstRegistrantSId = updateDto.FirstRegistrantSId,
            Frame = updateDto.Frame,
            Inalienability = updateDto.Inalienability,
            LoadU = updateDto.LoadU,
            ModelAndSpecificationNumber = updateDto.ModelAndSpecificationNumber,
            NumberOfSeats = updateDto.NumberOfSeats,
            Power = updateDto.Power,
            RectificationFrequency = updateDto.RectificationFrequency,
            ReferenceNumber = updateDto.ReferenceNumber,
            RegistrationNumber = updateDto.RegistrationNumber,
            SuppressionOn = updateDto.SuppressionOn,
            TotalWeightC = updateDto.TotalWeightC,
            TpdManagementNumber = updateDto.TpdManagementNumber,
            VehicleManufacturerCode = updateDto.VehicleManufacturerCode,
            VehicleModelCode = updateDto.VehicleModelCode,
            VehicleType = updateDto.VehicleType,
            VehicleTypeCode = updateDto.VehicleTypeCode,
            YearOfManufacture = updateDto.YearOfManufacture
        };

        if (updateDto.CreatedAt != null) detailedDeclarationVehicle.CreatedAt = updateDto.CreatedAt.Value;
        if (updateDto.UpdatedAt != null) detailedDeclarationVehicle.UpdatedAt = updateDto.UpdatedAt.Value;

        return detailedDeclarationVehicle;
    }
}
