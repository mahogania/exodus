using Control.APIs.Dtos;
using Control.Infrastructure.Models;

namespace Control.APIs.Extensions;

public static class TemporaryAdmissionOfVehiclesExtensions
{
    public static TemporaryAdmissionOfVehicle ToDto(this TemporaryAdmissionOfVehicleDbModel model)
    {
        return new TemporaryAdmissionOfVehicle
        {
            CreatedAt = model.CreatedAt,
            DeletionOn = model.DeletionOn,
            EntryCustomsOfficeCode = model.EntryCustomsOfficeCode,
            FinalModificationDateAndTime = model.FinalModificationDateAndTime,
            FinalModifierSId = model.FinalModifierSId,
            FirstRecorderSId = model.FirstRecorderSId,
            FirstRegistrationDateAndTime = model.FirstRegistrationDateAndTime,
            Id = model.Id,
            ReImportationReExportationOfficeCode = model.ReImportationReExportationOfficeCode,
            RectificationFrequency = model.RectificationFrequency,
            RegimeRequestNumber = model.RegimeRequestNumber,
            RequestedDelayEndDate = model.RequestedDelayEndDate,
            RequestedDelayStartDate = model.RequestedDelayStartDate,
            UpdatedAt = model.UpdatedAt,
        };
    }

    public static TemporaryAdmissionOfVehicleDbModel ToModel(
        this TemporaryAdmissionOfVehicleUpdateInput updateDto,
        TemporaryAdmissionOfVehicleWhereUniqueInput uniqueId
    )
    {
        var temporaryAdmissionOfVehicle = new TemporaryAdmissionOfVehicleDbModel
        {
            Id = uniqueId.Id,
            DeletionOn = updateDto.DeletionOn,
            EntryCustomsOfficeCode = updateDto.EntryCustomsOfficeCode,
            FinalModificationDateAndTime = updateDto.FinalModificationDateAndTime,
            FinalModifierSId = updateDto.FinalModifierSId,
            FirstRecorderSId = updateDto.FirstRecorderSId,
            FirstRegistrationDateAndTime = updateDto.FirstRegistrationDateAndTime,
            ReImportationReExportationOfficeCode = updateDto.ReImportationReExportationOfficeCode,
            RectificationFrequency = updateDto.RectificationFrequency,
            RegimeRequestNumber = updateDto.RegimeRequestNumber,
            RequestedDelayEndDate = updateDto.RequestedDelayEndDate,
            RequestedDelayStartDate = updateDto.RequestedDelayStartDate
        };

        if (updateDto.CreatedAt != null)
        {
            temporaryAdmissionOfVehicle.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.UpdatedAt != null)
        {
            temporaryAdmissionOfVehicle.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return temporaryAdmissionOfVehicle;
    }
}
