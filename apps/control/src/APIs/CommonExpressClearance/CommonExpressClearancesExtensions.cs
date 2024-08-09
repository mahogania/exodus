using Control.APIs.Dtos;
using Control.Infrastructure.Models;

namespace Control.APIs.Extensions;

public static class CommonExpressClearancesExtensions
{
    public static CommonExpressClearance ToDto(this CommonExpressClearanceDbModel model)
    {
        return new CommonExpressClearance
        {
            ArrivalDate = model.ArrivalDate,
            AttachedFileId = model.AttachedFileId,
            CountryOfLoadingCode = model.CountryOfLoadingCode,
            CreatedAt = model.CreatedAt,
            CustomsOfficeCode = model.CustomsOfficeCode,
            DeletionOn = model.DeletionOn,
            ExpressClearanceRequestNumber = model.ExpressClearanceRequestNumber,
            ExpressOperatorCode = model.ExpressOperatorCode,
            ExpressOperatorName = model.ExpressOperatorName,
            FinalModificationDateAndTime = model.FinalModificationDateAndTime,
            FinalModifierSId = model.FinalModifierSId,
            FirstRecorderSId = model.FirstRecorderSId,
            FirstRegistrationDateAndTime = model.FirstRegistrationDateAndTime,
            Id = model.Id,
            MasterBlNumber = model.MasterBlNumber,
            RequestDate = model.RequestDate,
            ShipName = model.ShipName,
            TransmissionTypeCode = model.TransmissionTypeCode,
            TreatmentStatusCode = model.TreatmentStatusCode,
            UpdatedAt = model.UpdatedAt,
        };
    }

    public static CommonExpressClearanceDbModel ToModel(
        this CommonExpressClearanceUpdateInput updateDto,
        CommonExpressClearanceWhereUniqueInput uniqueId
    )
    {
        var commonExpressClearance = new CommonExpressClearanceDbModel
        {
            Id = uniqueId.Id,
            ArrivalDate = updateDto.ArrivalDate,
            AttachedFileId = updateDto.AttachedFileId,
            CountryOfLoadingCode = updateDto.CountryOfLoadingCode,
            CustomsOfficeCode = updateDto.CustomsOfficeCode,
            DeletionOn = updateDto.DeletionOn,
            ExpressClearanceRequestNumber = updateDto.ExpressClearanceRequestNumber,
            ExpressOperatorCode = updateDto.ExpressOperatorCode,
            ExpressOperatorName = updateDto.ExpressOperatorName,
            FinalModificationDateAndTime = updateDto.FinalModificationDateAndTime,
            FinalModifierSId = updateDto.FinalModifierSId,
            FirstRecorderSId = updateDto.FirstRecorderSId,
            FirstRegistrationDateAndTime = updateDto.FirstRegistrationDateAndTime,
            MasterBlNumber = updateDto.MasterBlNumber,
            RequestDate = updateDto.RequestDate,
            ShipName = updateDto.ShipName,
            TransmissionTypeCode = updateDto.TransmissionTypeCode,
            TreatmentStatusCode = updateDto.TreatmentStatusCode
        };

        if (updateDto.CreatedAt != null)
        {
            commonExpressClearance.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.UpdatedAt != null)
        {
            commonExpressClearance.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return commonExpressClearance;
    }
}
