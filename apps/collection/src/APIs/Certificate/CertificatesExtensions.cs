using Collection.APIs.Dtos;
using Collection.Infrastructure.Models;

namespace Collection.APIs.Extensions;

public static class CertificatesExtensions
{
    public static Certificate ToDto(this CertificateDbModel model)
    {
        return new Certificate
        {
            AttachmentId = model.AttachmentId,
            BatchNo = model.BatchNo,
            ChassisNo = model.ChassisNo,
            CreatedAt = model.CreatedAt,
            DeletionOn = model.DeletionOn,
            FinalModificationDateAndTime = model.FinalModificationDateAndTime,
            FinalModifierId = model.FinalModifierId,
            FirstRegistrantId = model.FirstRegistrantId,
            FirstRegistrationDate = model.FirstRegistrationDate,
            FirstRegistrationDateAndTime = model.FirstRegistrationDateAndTime,
            GrossWeight = model.GrossWeight,
            Id = model.Id,
            MaximumLoad = model.MaximumLoad,
            NumberOfSeats = model.NumberOfSeats,
            OfficeCode = model.OfficeCode,
            RegistrationNo = model.RegistrationNo,
            RemarkContent = model.RemarkContent,
            SaleCertificateNo = model.SaleCertificateNo,
            SalePvNo = model.SalePvNo,
            ServiceCode = model.ServiceCode,
            TransferDecisionNo = model.TransferDecisionNo,
            UpdatedAt = model.UpdatedAt,
            VehicleBrandName = model.VehicleBrandName,
            VehicleCylinder = model.VehicleCylinder,
            VehicleEnergy = model.VehicleEnergy,
            VehicleModelName = model.VehicleModelName,
            VehiclePower = model.VehiclePower,
            VehicleType = model.VehicleType,
        };
    }

    public static CertificateDbModel ToModel(
        this CertificateUpdateInput updateDto,
        CertificateWhereUniqueInput uniqueId
    )
    {
        var certificate = new CertificateDbModel
        {
            Id = uniqueId.Id,
            AttachmentId = updateDto.AttachmentId,
            BatchNo = updateDto.BatchNo,
            ChassisNo = updateDto.ChassisNo,
            DeletionOn = updateDto.DeletionOn,
            FinalModificationDateAndTime = updateDto.FinalModificationDateAndTime,
            FinalModifierId = updateDto.FinalModifierId,
            FirstRegistrantId = updateDto.FirstRegistrantId,
            FirstRegistrationDate = updateDto.FirstRegistrationDate,
            FirstRegistrationDateAndTime = updateDto.FirstRegistrationDateAndTime,
            GrossWeight = updateDto.GrossWeight,
            MaximumLoad = updateDto.MaximumLoad,
            NumberOfSeats = updateDto.NumberOfSeats,
            OfficeCode = updateDto.OfficeCode,
            RegistrationNo = updateDto.RegistrationNo,
            RemarkContent = updateDto.RemarkContent,
            SaleCertificateNo = updateDto.SaleCertificateNo,
            SalePvNo = updateDto.SalePvNo,
            ServiceCode = updateDto.ServiceCode,
            TransferDecisionNo = updateDto.TransferDecisionNo,
            VehicleBrandName = updateDto.VehicleBrandName,
            VehicleCylinder = updateDto.VehicleCylinder,
            VehicleEnergy = updateDto.VehicleEnergy,
            VehicleModelName = updateDto.VehicleModelName,
            VehiclePower = updateDto.VehiclePower,
            VehicleType = updateDto.VehicleType
        };

        if (updateDto.CreatedAt != null)
        {
            certificate.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.UpdatedAt != null)
        {
            certificate.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return certificate;
    }
}
