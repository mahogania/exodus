using Control.APIs.Dtos;
using Control.Infrastructure.Models;

namespace Control.APIs.Extensions;

public static class TemporaryAdmissionForPerfectionsExtensions
{
    public static TemporaryAdmissionForPerfection ToDto(
        this TemporaryAdmissionForPerfectionDbModel model
    )
    {
        return new TemporaryAdmissionForPerfection
        {
            ActivePerfectionRepairPerformedByThirdParty =
                model.ActivePerfectionRepairPerformedByThirdParty,
            Address = model.Address,
            ApcCode = model.ApcCode,
            Applicant = model.Applicant,
            ApplicantNature = model.ApplicantNature,
            CessionDecisionDeliveryDate = model.CessionDecisionDeliveryDate,
            CessionDecisionNumber = model.CessionDecisionNumber,
            CommerceRegistryNumber = model.CommerceRegistryNumber,
            ContributionRate = model.ContributionRate,
            CreatedAt = model.CreatedAt,
            DateAndTimeOfFinalModification = model.DateAndTimeOfFinalModification,
            DateAndTimeOfFirstRegistration = model.DateAndTimeOfFirstRegistration,
            DeletionOn = model.DeletionOn,
            DomiciliaryBankAddress = model.DomiciliaryBankAddress,
            DomiciliaryBankLegalName = model.DomiciliaryBankLegalName,
            EndDateOfRegimeAuthorization = model.EndDateOfRegimeAuthorization,
            EpcCode = model.EpcCode,
            EstablishmentAddress = model.EstablishmentAddress,
            ExportCustomsOffice = model.ExportCustomsOffice,
            ExportOperationPaymentMode = model.ExportOperationPaymentMode,
            FinalModifierSId = model.FinalModifierSId,
            FinishedProductWasteRate = model.FinishedProductWasteRate,
            FirstRecorderSId = model.FirstRecorderSId,
            ForeignOriginMaterialQuantitiesRateAcquiredOnNationalMarket =
                model.ForeignOriginMaterialQuantitiesRateAcquiredOnNationalMarket,
            GoodsFromAnotherRde = model.GoodsFromAnotherRde,
            Id = model.Id,
            ImportCustomsOffice = model.ImportCustomsOffice,
            ImportOperationFinancingMode = model.ImportOperationFinancingMode,
            ImportedMaterialQuantitiesRate = model.ImportedMaterialQuantitiesRate,
            ImportedPackagingQuantitiesRate = model.ImportedPackagingQuantitiesRate,
            LocalAddress = model.LocalAddress,
            LossRate = model.LossRate,
            NameAndLegalNameOfThirdParty = model.NameAndLegalNameOfThirdParty,
            NameLegalNameOfEstablishmentWhereImportedGoodsMustBeTransformedRepaired =
                model.NameLegalNameOfEstablishmentWhereImportedGoodsMustBeTransformedRepaired,
            NameLegalNameOfEstablishmentWhereImportedGoodsMustBeTransformedRepairedByThirdParty =
                model.NameLegalNameOfEstablishmentWhereImportedGoodsMustBeTransformedRepairedByThirdParty,
            NationalOriginMaterialQuantitiesRate = model.NationalOriginMaterialQuantitiesRate,
            NatureOfOperation = model.NatureOfOperation,
            NatureOfOperationPerformedByThirdParty = model.NatureOfOperationPerformedByThirdParty,
            Nif = model.Nif,
            NifStatus = model.NifStatus,
            NonRecoverableWasteRate = model.NonRecoverableWasteRate,
            PlannedTotalAmountForTransformationRepair =
                model.PlannedTotalAmountForTransformationRepair,
            RcStatus = model.RcStatus,
            RecoverableWasteRate = model.RecoverableWasteRate,
            RectificationFrequency = model.RectificationFrequency,
            RegimeAuthorizationNumber = model.RegimeAuthorizationNumber,
            RequestRegimeNumber = model.RequestRegimeNumber,
            RequestedActivePerfectionType = model.RequestedActivePerfectionType,
            RequestedAuthorizationType = model.RequestedAuthorizationType,
            RequestedEndDate = model.RequestedEndDate,
            RequestedStartDate = model.RequestedStartDate,
            StartDateOfRegimeAuthorization = model.StartDateOfRegimeAuthorization,
            TransferWithMaintenanceOfRegime = model.TransferWithMaintenanceOfRegime,
            UpdatedAt = model.UpdatedAt,
        };
    }

    public static TemporaryAdmissionForPerfectionDbModel ToModel(
        this TemporaryAdmissionForPerfectionUpdateInput updateDto,
        TemporaryAdmissionForPerfectionWhereUniqueInput uniqueId
    )
    {
        var temporaryAdmissionForPerfection = new TemporaryAdmissionForPerfectionDbModel
        {
            Id = uniqueId.Id,
            ActivePerfectionRepairPerformedByThirdParty =
                updateDto.ActivePerfectionRepairPerformedByThirdParty,
            Address = updateDto.Address,
            ApcCode = updateDto.ApcCode,
            Applicant = updateDto.Applicant,
            ApplicantNature = updateDto.ApplicantNature,
            CessionDecisionDeliveryDate = updateDto.CessionDecisionDeliveryDate,
            CessionDecisionNumber = updateDto.CessionDecisionNumber,
            CommerceRegistryNumber = updateDto.CommerceRegistryNumber,
            ContributionRate = updateDto.ContributionRate,
            DateAndTimeOfFinalModification = updateDto.DateAndTimeOfFinalModification,
            DateAndTimeOfFirstRegistration = updateDto.DateAndTimeOfFirstRegistration,
            DeletionOn = updateDto.DeletionOn,
            DomiciliaryBankAddress = updateDto.DomiciliaryBankAddress,
            DomiciliaryBankLegalName = updateDto.DomiciliaryBankLegalName,
            EndDateOfRegimeAuthorization = updateDto.EndDateOfRegimeAuthorization,
            EpcCode = updateDto.EpcCode,
            EstablishmentAddress = updateDto.EstablishmentAddress,
            ExportCustomsOffice = updateDto.ExportCustomsOffice,
            ExportOperationPaymentMode = updateDto.ExportOperationPaymentMode,
            FinalModifierSId = updateDto.FinalModifierSId,
            FinishedProductWasteRate = updateDto.FinishedProductWasteRate,
            FirstRecorderSId = updateDto.FirstRecorderSId,
            ForeignOriginMaterialQuantitiesRateAcquiredOnNationalMarket =
                updateDto.ForeignOriginMaterialQuantitiesRateAcquiredOnNationalMarket,
            GoodsFromAnotherRde = updateDto.GoodsFromAnotherRde,
            ImportCustomsOffice = updateDto.ImportCustomsOffice,
            ImportOperationFinancingMode = updateDto.ImportOperationFinancingMode,
            ImportedMaterialQuantitiesRate = updateDto.ImportedMaterialQuantitiesRate,
            ImportedPackagingQuantitiesRate = updateDto.ImportedPackagingQuantitiesRate,
            LocalAddress = updateDto.LocalAddress,
            LossRate = updateDto.LossRate,
            NameAndLegalNameOfThirdParty = updateDto.NameAndLegalNameOfThirdParty,
            NameLegalNameOfEstablishmentWhereImportedGoodsMustBeTransformedRepaired =
                updateDto.NameLegalNameOfEstablishmentWhereImportedGoodsMustBeTransformedRepaired,
            NameLegalNameOfEstablishmentWhereImportedGoodsMustBeTransformedRepairedByThirdParty =
                updateDto.NameLegalNameOfEstablishmentWhereImportedGoodsMustBeTransformedRepairedByThirdParty,
            NationalOriginMaterialQuantitiesRate = updateDto.NationalOriginMaterialQuantitiesRate,
            NatureOfOperation = updateDto.NatureOfOperation,
            NatureOfOperationPerformedByThirdParty =
                updateDto.NatureOfOperationPerformedByThirdParty,
            Nif = updateDto.Nif,
            NifStatus = updateDto.NifStatus,
            NonRecoverableWasteRate = updateDto.NonRecoverableWasteRate,
            PlannedTotalAmountForTransformationRepair =
                updateDto.PlannedTotalAmountForTransformationRepair,
            RcStatus = updateDto.RcStatus,
            RecoverableWasteRate = updateDto.RecoverableWasteRate,
            RectificationFrequency = updateDto.RectificationFrequency,
            RegimeAuthorizationNumber = updateDto.RegimeAuthorizationNumber,
            RequestRegimeNumber = updateDto.RequestRegimeNumber,
            RequestedActivePerfectionType = updateDto.RequestedActivePerfectionType,
            RequestedAuthorizationType = updateDto.RequestedAuthorizationType,
            RequestedEndDate = updateDto.RequestedEndDate,
            RequestedStartDate = updateDto.RequestedStartDate,
            StartDateOfRegimeAuthorization = updateDto.StartDateOfRegimeAuthorization,
            TransferWithMaintenanceOfRegime = updateDto.TransferWithMaintenanceOfRegime
        };

        if (updateDto.CreatedAt != null)
        {
            temporaryAdmissionForPerfection.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.UpdatedAt != null)
        {
            temporaryAdmissionForPerfection.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return temporaryAdmissionForPerfection;
    }
}
