using Control.APIs.Dtos;
using Control.Infrastructure.Models;

namespace Control.APIs.Extensions;

public static class StateWithReImportationInTheStatesExtensions
{
    public static StateWithReImportationInTheState ToDto(
        this StateWithReImportationInTheStateDbModel model
    )
    {
        return new StateWithReImportationInTheState
        {
            Address = model.Address,
            ContractObject = model.ContractObject,
            ContractReference = model.ContractReference,
            CreatedAt = model.CreatedAt,
            CustomsOfficeForReImportationIndicative = model.CustomsOfficeForReImportationIndicative,
            DateAndTimeOfFinalModification = model.DateAndTimeOfFinalModification,
            DateAndTimeOfFirstRegistration = model.DateAndTimeOfFirstRegistration,
            ExportingCountryCode = model.ExportingCountryCode,
            FinalModifierSId = model.FinalModifierSId,
            FirstRegistrantSId = model.FirstRegistrantSId,
            ForeignRecipient = model.ForeignRecipient,
            Id = model.Id,
            RectificationFrequency = model.RectificationFrequency,
            RegimeRequestNumber = model.RegimeRequestNumber,
            RequestedEndDateOfTemporaryExport = model.RequestedEndDateOfTemporaryExport,
            RequestedStartDateOfTemporaryExport = model.RequestedStartDateOfTemporaryExport,
            SuppressionOn = model.SuppressionOn,
            UnknownFieldOne = model.UnknownFieldOne,
            UnknownFieldTwo = model.UnknownFieldTwo,
            UpdatedAt = model.UpdatedAt
        };
    }

    public static StateWithReImportationInTheStateDbModel ToModel(
        this StateWithReImportationInTheStateUpdateInput updateDto,
        StateWithReImportationInTheStateWhereUniqueInput uniqueId
    )
    {
        var stateWithReImportationInTheState = new StateWithReImportationInTheStateDbModel
        {
            Id = uniqueId.Id,
            Address = updateDto.Address,
            ContractObject = updateDto.ContractObject,
            ContractReference = updateDto.ContractReference,
            CustomsOfficeForReImportationIndicative =
                updateDto.CustomsOfficeForReImportationIndicative,
            DateAndTimeOfFinalModification = updateDto.DateAndTimeOfFinalModification,
            DateAndTimeOfFirstRegistration = updateDto.DateAndTimeOfFirstRegistration,
            ExportingCountryCode = updateDto.ExportingCountryCode,
            FinalModifierSId = updateDto.FinalModifierSId,
            FirstRegistrantSId = updateDto.FirstRegistrantSId,
            ForeignRecipient = updateDto.ForeignRecipient,
            RectificationFrequency = updateDto.RectificationFrequency,
            RegimeRequestNumber = updateDto.RegimeRequestNumber,
            RequestedEndDateOfTemporaryExport = updateDto.RequestedEndDateOfTemporaryExport,
            RequestedStartDateOfTemporaryExport = updateDto.RequestedStartDateOfTemporaryExport,
            SuppressionOn = updateDto.SuppressionOn,
            UnknownFieldOne = updateDto.UnknownFieldOne,
            UnknownFieldTwo = updateDto.UnknownFieldTwo
        };

        if (updateDto.CreatedAt != null) stateWithReImportationInTheState.CreatedAt = updateDto.CreatedAt.Value;
        if (updateDto.UpdatedAt != null) stateWithReImportationInTheState.UpdatedAt = updateDto.UpdatedAt.Value;

        return stateWithReImportationInTheState;
    }
}
