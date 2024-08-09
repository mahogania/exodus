using Collection.APIs.Dtos;
using Collection.Infrastructure.Models;

namespace Collection.APIs.Extensions;

public static class DetailsExtensions
{
    public static Detail ToDto(this DetailDbModel model)
    {
        return new Detail
        {
            AttachmentId = model.AttachmentId,
            ChassisNo = model.ChassisNo,
            ContainerNo = model.ContainerNo,
            CreatedAt = model.CreatedAt,
            DeletionOn = model.DeletionOn,
            EstimatedAuctionSalePrice = model.EstimatedAuctionSalePrice,
            FinalModificationDateAndTime = model.FinalModificationDateAndTime,
            FinalModifierId = model.FinalModifierId,
            FinalUseCode = model.FinalUseCode,
            FirstCirculationDate = model.FirstCirculationDate,
            FirstRegistrantId = model.FirstRegistrantId,
            FirstRegistrationDateAndTime = model.FirstRegistrationDateAndTime,
            GrossWeight = model.GrossWeight,
            Id = model.Id,
            ItemSequenceNumber = model.ItemSequenceNumber,
            MaximumLoad = model.MaximumLoad,
            MerchandiseDescription = model.MerchandiseDescription,
            NumberOfSeats = model.NumberOfSeats,
            Quantity = model.Quantity,
            ReferenceNumberTypeCode = model.ReferenceNumberTypeCode,
            ReferenceNumberTypeName = model.ReferenceNumberTypeName,
            RegistrationDate = model.RegistrationDate,
            RegistrationNumber = model.RegistrationNumber,
            RemarkContent = model.RemarkContent,
            StockAccountingManagementNumber = model.StockAccountingManagementNumber,
            UpdatedAt = model.UpdatedAt,
            VehicleBrandName = model.VehicleBrandName,
            VehicleCylinder = model.VehicleCylinder,
            VehicleEnergy = model.VehicleEnergy,
            VehicleModelName = model.VehicleModelName,
            VehicleOn = model.VehicleOn,
            VehiclePower = model.VehiclePower,
            VehicleType = model.VehicleType,
        };
    }

    public static DetailDbModel ToModel(
        this DetailUpdateInput updateDto,
        DetailWhereUniqueInput uniqueId
    )
    {
        var detail = new DetailDbModel
        {
            Id = uniqueId.Id,
            AttachmentId = updateDto.AttachmentId,
            ChassisNo = updateDto.ChassisNo,
            ContainerNo = updateDto.ContainerNo,
            DeletionOn = updateDto.DeletionOn,
            EstimatedAuctionSalePrice = updateDto.EstimatedAuctionSalePrice,
            FinalModificationDateAndTime = updateDto.FinalModificationDateAndTime,
            FinalModifierId = updateDto.FinalModifierId,
            FinalUseCode = updateDto.FinalUseCode,
            FirstCirculationDate = updateDto.FirstCirculationDate,
            FirstRegistrantId = updateDto.FirstRegistrantId,
            FirstRegistrationDateAndTime = updateDto.FirstRegistrationDateAndTime,
            GrossWeight = updateDto.GrossWeight,
            ItemSequenceNumber = updateDto.ItemSequenceNumber,
            MaximumLoad = updateDto.MaximumLoad,
            MerchandiseDescription = updateDto.MerchandiseDescription,
            NumberOfSeats = updateDto.NumberOfSeats,
            Quantity = updateDto.Quantity,
            ReferenceNumberTypeCode = updateDto.ReferenceNumberTypeCode,
            ReferenceNumberTypeName = updateDto.ReferenceNumberTypeName,
            RegistrationDate = updateDto.RegistrationDate,
            RegistrationNumber = updateDto.RegistrationNumber,
            RemarkContent = updateDto.RemarkContent,
            StockAccountingManagementNumber = updateDto.StockAccountingManagementNumber,
            VehicleBrandName = updateDto.VehicleBrandName,
            VehicleCylinder = updateDto.VehicleCylinder,
            VehicleEnergy = updateDto.VehicleEnergy,
            VehicleModelName = updateDto.VehicleModelName,
            VehicleOn = updateDto.VehicleOn,
            VehiclePower = updateDto.VehiclePower,
            VehicleType = updateDto.VehicleType
        };

        if (updateDto.CreatedAt != null)
        {
            detail.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.UpdatedAt != null)
        {
            detail.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return detail;
    }
}
