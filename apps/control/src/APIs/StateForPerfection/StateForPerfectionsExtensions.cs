using Control.APIs.Dtos;
using Control.Infrastructure.Models;

namespace Control.APIs.Extensions;

public static class StateForPerfectionsExtensions
{
    public static StateForPerfection ToDto(this StateForPerfectionDbModel model)
    {
        return new StateForPerfection
        {
            AddressOfTheDomiciliaryBank = model.AddressOfTheDomiciliaryBank,
            CorporateNameOfTheDomiciliaryBank = model.CorporateNameOfTheDomiciliaryBank,
            CreatedAt = model.CreatedAt,
            CustomsOfficeAtExportation = model.CustomsOfficeAtExportation,
            CustomsOfficeAtImportation = model.CustomsOfficeAtImportation,
            DateAndTimeOfFinalModification = model.DateAndTimeOfFinalModification,
            DateAndTimeOfFirstRegistration = model.DateAndTimeOfFirstRegistration,
            FinalModifierSId = model.FinalModifierSId,
            FinancingModeOfTheOperation = model.FinancingModeOfTheOperation,
            FirstRegistrantSId = model.FirstRegistrantSId,
            Id = model.Id,
            NatureOfTheOperation = model.NatureOfTheOperation,
            RateOfLosses = model.RateOfLosses,
            RateOfNonRecoverableWaste = model.RateOfNonRecoverableWaste,
            RateOfQuantitiesOfExportedMaterials = model.RateOfQuantitiesOfExportedMaterials,
            RateOfQuantitiesOfExportedPackaging = model.RateOfQuantitiesOfExportedPackaging,
            RateOfQuantitiesOfForeignOriginMaterialsAcquiredOnTheForeignMarket =
                model.RateOfQuantitiesOfForeignOriginMaterialsAcquiredOnTheForeignMarket,
            RateOfRecoverableWaste = model.RateOfRecoverableWaste,
            RateOfWasteOnFinishedProducts = model.RateOfWasteOnFinishedProducts,
            RecipientSAddress = model.RecipientSAddress,
            RecipientSCorporateName = model.RecipientSCorporateName,
            RecipientSName = model.RecipientSName,
            RectificationFrequency = model.RectificationFrequency,
            RegimeRequestNumber = model.RegimeRequestNumber,
            RequestedEndDate = model.RequestedEndDate,
            RequestedStartDate = model.RequestedStartDate,
            SuppressionOn = model.SuppressionOn,
            TotalAmountForeseenForTransformationRepair =
                model.TotalAmountForeseenForTransformationRepair,
            TypeOfActivePerfectionSolicited = model.TypeOfActivePerfectionSolicited,
            UpdatedAt = model.UpdatedAt,
        };
    }

    public static StateForPerfectionDbModel ToModel(
        this StateForPerfectionUpdateInput updateDto,
        StateForPerfectionWhereUniqueInput uniqueId
    )
    {
        var stateForPerfection = new StateForPerfectionDbModel
        {
            Id = uniqueId.Id,
            AddressOfTheDomiciliaryBank = updateDto.AddressOfTheDomiciliaryBank,
            CorporateNameOfTheDomiciliaryBank = updateDto.CorporateNameOfTheDomiciliaryBank,
            CustomsOfficeAtExportation = updateDto.CustomsOfficeAtExportation,
            CustomsOfficeAtImportation = updateDto.CustomsOfficeAtImportation,
            DateAndTimeOfFinalModification = updateDto.DateAndTimeOfFinalModification,
            DateAndTimeOfFirstRegistration = updateDto.DateAndTimeOfFirstRegistration,
            FinalModifierSId = updateDto.FinalModifierSId,
            FinancingModeOfTheOperation = updateDto.FinancingModeOfTheOperation,
            FirstRegistrantSId = updateDto.FirstRegistrantSId,
            NatureOfTheOperation = updateDto.NatureOfTheOperation,
            RateOfLosses = updateDto.RateOfLosses,
            RateOfNonRecoverableWaste = updateDto.RateOfNonRecoverableWaste,
            RateOfQuantitiesOfExportedMaterials = updateDto.RateOfQuantitiesOfExportedMaterials,
            RateOfQuantitiesOfExportedPackaging = updateDto.RateOfQuantitiesOfExportedPackaging,
            RateOfQuantitiesOfForeignOriginMaterialsAcquiredOnTheForeignMarket =
                updateDto.RateOfQuantitiesOfForeignOriginMaterialsAcquiredOnTheForeignMarket,
            RateOfRecoverableWaste = updateDto.RateOfRecoverableWaste,
            RateOfWasteOnFinishedProducts = updateDto.RateOfWasteOnFinishedProducts,
            RecipientSAddress = updateDto.RecipientSAddress,
            RecipientSCorporateName = updateDto.RecipientSCorporateName,
            RecipientSName = updateDto.RecipientSName,
            RectificationFrequency = updateDto.RectificationFrequency,
            RegimeRequestNumber = updateDto.RegimeRequestNumber,
            RequestedEndDate = updateDto.RequestedEndDate,
            RequestedStartDate = updateDto.RequestedStartDate,
            SuppressionOn = updateDto.SuppressionOn,
            TotalAmountForeseenForTransformationRepair =
                updateDto.TotalAmountForeseenForTransformationRepair,
            TypeOfActivePerfectionSolicited = updateDto.TypeOfActivePerfectionSolicited
        };

        if (updateDto.CreatedAt != null)
        {
            stateForPerfection.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.UpdatedAt != null)
        {
            stateForPerfection.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return stateForPerfection;
    }
}
