using Control.APIs.Dtos;
using Control.Infrastructure.Models;

namespace Control.APIs.Extensions;

public static class ValueDeclarationsExtensions
{
    public static ValueDeclaration ToDto(this ValueDeclarationDbModel model)
    {
        return new ValueDeclaration
        {
            AdditionalCostOfMediationAmount = model.AdditionalCostOfMediationAmount,
            AdditionalCostOfOtherFeesForLoadingAtTheImportPort =
                model.AdditionalCostOfOtherFeesForLoadingAtTheImportPort,
            AdditionalCostOfOtherFeesForTechnologicalDesign =
                model.AdditionalCostOfOtherFeesForTechnologicalDesign,
            AdditionalCostOfOtherToolFees = model.AdditionalCostOfOtherToolFees,
            AdditionalCostOfPurchaseCommissionOn = model.AdditionalCostOfPurchaseCommissionOn,
            AdditionalCostOfSalesCommissionOn = model.AdditionalCostOfSalesCommissionOn,
            AdditionalCostOfTheAmountOfFreightFromTheImportPort =
                model.AdditionalCostOfTheAmountOfFreightFromTheImportPort,
            AdditionalCostOfTheAmountOfInsuranceFromTheImportPort =
                model.AdditionalCostOfTheAmountOfInsuranceFromTheImportPort,
            AdditionalCostOfTheCostOfComponentsOfTheMaterials =
                model.AdditionalCostOfTheCostOfComponentsOfTheMaterials,
            AdditionalCostOfTheCostOfConsumableGoods =
                model.AdditionalCostOfTheCostOfConsumableGoods,
            AdditionalCostOfTheCostOfPackagesAndContainers =
                model.AdditionalCostOfTheCostOfPackagesAndContainers,
            AdditionalCostOfTheCostOfProcessing = model.AdditionalCostOfTheCostOfProcessing,
            AdditionalCostOfTheLicenseFee = model.AdditionalCostOfTheLicenseFee,
            AdditionalCostOfTheSellerSProfitAmount = model.AdditionalCostOfTheSellerSProfitAmount,
            AdditionalCostOfTransportCost = model.AdditionalCostOfTransportCost,
            BaseForCalculatingIndirectAmount = model.BaseForCalculatingIndirectAmount,
            BaseForCalculatingTotalAmount = model.BaseForCalculatingTotalAmount,
            BaseForCalculatingTransactionalValue = model.BaseForCalculatingTransactionalValue,
            BuyerSIdentificationNumber = model.BuyerSIdentificationNumber,
            CommonDetailedDeclarations = model.CommonDetailedDeclarations?.ToDto(),
            ComplementaryObservation = model.ComplementaryObservation,
            ContractConclusionDate = model.ContractConclusionDate,
            ContractNumber = model.ContractNumber,
            CreatedAt = model.CreatedAt,
            DateAndTimeOfFinalModification = model.DateAndTimeOfFinalModification,
            DateAndTimeOfFirstRegistration = model.DateAndTimeOfFirstRegistration,
            DateOfIssuanceOfTheInvoice = model.DateOfIssuanceOfTheInvoice,
            DateOfIssuanceOfTheOfficialLetterOfPreliminaryDecision =
                model.DateOfIssuanceOfTheOfficialLetterOfPreliminaryDecision,
            DeclarantSName = model.DeclarantSName,
            DeclarationDate = model.DeclarationDate,
            DeclaredStatisticalValue = model.DeclaredStatisticalValue,
            DeductedAmountOfCustomsDutiesOfTheExportingCountry =
                model.DeductedAmountOfCustomsDutiesOfTheExportingCountry,
            DeductedOtherFees = model.DeductedOtherFees,
            DeductedOtherServices = model.DeductedOtherServices,
            DeductedTotalAmount = model.DeductedTotalAmount,
            DeductedTransportCost = model.DeductedTransportCost,
            DeliveryConditionCode = model.DeliveryConditionCode,
            FinalModifierSId = model.FinalModifierSId,
            FirstRecorderSId = model.FirstRecorderSId,
            Id = model.Id,
            InvoiceNumber = model.InvoiceNumber,
            NumberOfTheOfficialLetterOfPreliminaryDecision =
                model.NumberOfTheOfficialLetterOfPreliminaryDecision,
            OtherExplanations = model.OtherExplanations,
            PlaceOfDeclarationName = model.PlaceOfDeclarationName,
            Question_1On = model.Question_1On,
            Question_2On = model.Question_2On,
            Question_3On = model.Question_3On,
            Question_4On = model.Question_4On,
            Question_5On = model.Question_5On,
            Question_6On = model.Question_6On,
            Question_7On = model.Question_7On,
            Question_8On = model.Question_8On,
            RectificationFrequency = model.RectificationFrequency,
            ReferenceNumber = model.ReferenceNumber,
            SellerSIdentificationNumber = model.SellerSIdentificationNumber,
            SpecifyTheNatureOfTheRestrictions = model.SpecifyTheNatureOfTheRestrictions,
            SuppressionOn = model.SuppressionOn,
            TotalDeductedAmountOfAdditionalCosts = model.TotalDeductedAmountOfAdditionalCosts,
            UpdatedAt = model.UpdatedAt,
        };
    }

    public static ValueDeclarationDbModel ToModel(
        this ValueDeclarationUpdateInput updateDto,
        ValueDeclarationWhereUniqueInput uniqueId
    )
    {
        var valueDeclaration = new ValueDeclarationDbModel
        {
            Id = uniqueId.Id,
            AdditionalCostOfMediationAmount = updateDto.AdditionalCostOfMediationAmount,
            AdditionalCostOfOtherFeesForLoadingAtTheImportPort =
                updateDto.AdditionalCostOfOtherFeesForLoadingAtTheImportPort,
            AdditionalCostOfOtherFeesForTechnologicalDesign =
                updateDto.AdditionalCostOfOtherFeesForTechnologicalDesign,
            AdditionalCostOfOtherToolFees = updateDto.AdditionalCostOfOtherToolFees,
            AdditionalCostOfPurchaseCommissionOn = updateDto.AdditionalCostOfPurchaseCommissionOn,
            AdditionalCostOfSalesCommissionOn = updateDto.AdditionalCostOfSalesCommissionOn,
            AdditionalCostOfTheAmountOfFreightFromTheImportPort =
                updateDto.AdditionalCostOfTheAmountOfFreightFromTheImportPort,
            AdditionalCostOfTheAmountOfInsuranceFromTheImportPort =
                updateDto.AdditionalCostOfTheAmountOfInsuranceFromTheImportPort,
            AdditionalCostOfTheCostOfComponentsOfTheMaterials =
                updateDto.AdditionalCostOfTheCostOfComponentsOfTheMaterials,
            AdditionalCostOfTheCostOfConsumableGoods =
                updateDto.AdditionalCostOfTheCostOfConsumableGoods,
            AdditionalCostOfTheCostOfPackagesAndContainers =
                updateDto.AdditionalCostOfTheCostOfPackagesAndContainers,
            AdditionalCostOfTheCostOfProcessing = updateDto.AdditionalCostOfTheCostOfProcessing,
            AdditionalCostOfTheLicenseFee = updateDto.AdditionalCostOfTheLicenseFee,
            AdditionalCostOfTheSellerSProfitAmount =
                updateDto.AdditionalCostOfTheSellerSProfitAmount,
            AdditionalCostOfTransportCost = updateDto.AdditionalCostOfTransportCost,
            BaseForCalculatingIndirectAmount = updateDto.BaseForCalculatingIndirectAmount,
            BaseForCalculatingTotalAmount = updateDto.BaseForCalculatingTotalAmount,
            BaseForCalculatingTransactionalValue = updateDto.BaseForCalculatingTransactionalValue,
            BuyerSIdentificationNumber = updateDto.BuyerSIdentificationNumber,
            ComplementaryObservation = updateDto.ComplementaryObservation,
            ContractConclusionDate = updateDto.ContractConclusionDate,
            ContractNumber = updateDto.ContractNumber,
            DateAndTimeOfFinalModification = updateDto.DateAndTimeOfFinalModification,
            DateAndTimeOfFirstRegistration = updateDto.DateAndTimeOfFirstRegistration,
            DateOfIssuanceOfTheInvoice = updateDto.DateOfIssuanceOfTheInvoice,
            DateOfIssuanceOfTheOfficialLetterOfPreliminaryDecision =
                updateDto.DateOfIssuanceOfTheOfficialLetterOfPreliminaryDecision,
            DeclarantSName = updateDto.DeclarantSName,
            DeclarationDate = updateDto.DeclarationDate,
            DeclaredStatisticalValue = updateDto.DeclaredStatisticalValue,
            DeductedAmountOfCustomsDutiesOfTheExportingCountry =
                updateDto.DeductedAmountOfCustomsDutiesOfTheExportingCountry,
            DeductedOtherFees = updateDto.DeductedOtherFees,
            DeductedOtherServices = updateDto.DeductedOtherServices,
            DeductedTotalAmount = updateDto.DeductedTotalAmount,
            DeductedTransportCost = updateDto.DeductedTransportCost,
            DeliveryConditionCode = updateDto.DeliveryConditionCode,
            FinalModifierSId = updateDto.FinalModifierSId,
            FirstRecorderSId = updateDto.FirstRecorderSId,
            InvoiceNumber = updateDto.InvoiceNumber,
            NumberOfTheOfficialLetterOfPreliminaryDecision =
                updateDto.NumberOfTheOfficialLetterOfPreliminaryDecision,
            OtherExplanations = updateDto.OtherExplanations,
            PlaceOfDeclarationName = updateDto.PlaceOfDeclarationName,
            Question_1On = updateDto.Question_1On,
            Question_2On = updateDto.Question_2On,
            Question_3On = updateDto.Question_3On,
            Question_4On = updateDto.Question_4On,
            Question_5On = updateDto.Question_5On,
            Question_6On = updateDto.Question_6On,
            Question_7On = updateDto.Question_7On,
            Question_8On = updateDto.Question_8On,
            RectificationFrequency = updateDto.RectificationFrequency,
            ReferenceNumber = updateDto.ReferenceNumber,
            SellerSIdentificationNumber = updateDto.SellerSIdentificationNumber,
            SpecifyTheNatureOfTheRestrictions = updateDto.SpecifyTheNatureOfTheRestrictions,
            SuppressionOn = updateDto.SuppressionOn,
            TotalDeductedAmountOfAdditionalCosts = updateDto.TotalDeductedAmountOfAdditionalCosts
        };

        if (updateDto.CreatedAt != null)
        {
            valueDeclaration.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.UpdatedAt != null)
        {
            valueDeclaration.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return valueDeclaration;
    }
}
