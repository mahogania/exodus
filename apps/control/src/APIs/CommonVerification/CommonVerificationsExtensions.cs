using Control.APIs.Dtos;
using Control.Infrastructure.Models;

namespace Control.APIs.Extensions;

public static class CommonVerificationsExtensions
{
    public static CommonVerification ToDto(this CommonVerificationDbModel model)
    {
        return new CommonVerification
        {
            AdditionalFeesAmountDeclared = model.AdditionalFeesAmountDeclared,
            AdditionalFeesAmountFinal = model.AdditionalFeesAmountFinal,
            AdditionalFeesAmountInNcyDeclared = model.AdditionalFeesAmountInNcyDeclared,
            AdditionalFeesAmountInNcyFinal = model.AdditionalFeesAmountInNcyFinal,
            AdditionalFeesCurrencyCodeDeclared = model.AdditionalFeesCurrencyCodeDeclared,
            AdditionalFeesCurrencyCodeFinal = model.AdditionalFeesCurrencyCodeFinal,
            AdditionalFeesExchangeRateDeclared = model.AdditionalFeesExchangeRateDeclared,
            AdditionalFeesExchangeRateFinal = model.AdditionalFeesExchangeRateFinal,
            AdditionalLiquidCommissions = model.AdditionalLiquidCommissions,
            AdditionalPayableFeesDeclared = model.AdditionalPayableFeesDeclared,
            Appeal = model.AppealId,
            ArticlesSubmittedForVerification = model.ArticlesSubmittedForVerificationId,
            ContainerValueAssessments = model.ContainerValueAssessments?.Select(x => x.Id).ToList(),
            CreatedAt = model.CreatedAt,
            DateAndTimeOfFinalModification = model.DateAndTimeOfFinalModification,
            DateAndTimeOfInitialRecord = model.DateAndTimeOfInitialRecord,
            DeductedAmountDeclared = model.DeductedAmountDeclared,
            DeductedAmountFinal = model.DeductedAmountFinal,
            DeductedAmountInCnyFinal = model.DeductedAmountInCnyFinal,
            DeductedAmountInNcyDeclared = model.DeductedAmountInNcyDeclared,
            DeductedCurrencyCodeDeclared = model.DeductedCurrencyCodeDeclared,
            DeductedCurrencyCodeFinal = model.DeductedCurrencyCodeFinal,
            DeductionExchangeRateDeclared = model.DeductionExchangeRateDeclared,
            DeductionExchangeRateFinal = model.DeductionExchangeRateFinal,
            DeletedOn = model.DeletedOn,
            EpcCodeDeclared = model.EpcCodeDeclared,
            EpcCodeFinal = model.EpcCodeFinal,
            FinalModifierId = model.FinalModifierId,
            FinalOn = model.FinalOn,
            FreightAmountDeclared = model.FreightAmountDeclared,
            FreightAmountFinal = model.FreightAmountFinal,
            FreightAmountInNcyDeclared = model.FreightAmountInNcyDeclared,
            FreightAmountInNcyFinal = model.FreightAmountInNcyFinal,
            FreightCurrencyCodeDeclared = model.FreightCurrencyCodeDeclared,
            FreightCurrencyCodeFinal = model.FreightCurrencyCodeFinal,
            FreightExchangeRateDeclared = model.FreightExchangeRateDeclared,
            FreightExchangeRateFinal = model.FreightExchangeRateFinal,
            Id = model.Id,
            ImporterIdentificationNumberDeclared = model.ImporterIdentificationNumberDeclared,
            ImporterIdentificationNumberFinal = model.ImporterIdentificationNumberFinal,
            ImporterIdentificationTypeCodeDeclared = model.ImporterIdentificationTypeCodeDeclared,
            ImporterIdentificationTypeCodeFinal = model.ImporterIdentificationTypeCodeFinal,
            InitialRecorderId = model.InitialRecorderId,
            InsuranceAmountDeclared = model.InsuranceAmountDeclared,
            InsuranceAmountFinal = model.InsuranceAmountFinal,
            InsuranceAmountInNcyDeclared = model.InsuranceAmountInNcyDeclared,
            InsuranceAmountInNcyFinal = model.InsuranceAmountInNcyFinal,
            InsuranceCurrencyCodeDeclared = model.InsuranceCurrencyCodeDeclared,
            InsuranceCurrencyCodeFinal = model.InsuranceCurrencyCodeFinal,
            InsuranceExchangeRateDeclared = model.InsuranceExchangeRateDeclared,
            InsuranceExchangeRateFinal = model.InsuranceExchangeRateFinal,
            InvalidSecurityAmountDeclared = model.InvalidSecurityAmountDeclared,
            InvalidSecurityAmountFinal = model.InvalidSecurityAmountFinal,
            InvoiceAmountDeclared = model.InvoiceAmountDeclared,
            InvoiceAmountFinal = model.InvoiceAmountFinal,
            InvoiceAmountInNcyDeclared = model.InvoiceAmountInNcyDeclared,
            InvoiceAmountInNcyFinal = model.InvoiceAmountInNcyFinal,
            InvoiceAmountInUsdFinal = model.InvoiceAmountInUsdFinal,
            InvoiceCurrencyCodeDeclared = model.InvoiceCurrencyCodeDeclared,
            InvoiceCurrencyCodeFinal = model.InvoiceCurrencyCodeFinal,
            InvoiceExchangeRateDeclared = model.InvoiceExchangeRateDeclared,
            InvoiceExchangeRateFinal = model.InvoiceExchangeRateFinal,
            NiuFinal = model.NiuFinal,
            ReducedValidSecurityAmountDeclared = model.ReducedValidSecurityAmountDeclared,
            ReducedValidSecurityAmountFinal = model.ReducedValidSecurityAmountFinal,
            ResultOfVerificationOfDetailedDeclaration =
                model.ResultOfVerificationOfDetailedDeclaration,
            TaxesForVerification = model.TaxesForVerification?.Select(x => x.Id).ToList(),
            TaxpayerIdentificationNumberDeclared = model.TaxpayerIdentificationNumberDeclared,
            TotalDeclaredTaxes = model.TotalDeclaredTaxes,
            TotalFinalTaxes = model.TotalFinalTaxes,
            TotalPaidTaxesDeclared = model.TotalPaidTaxesDeclared,
            TotalPaidTaxesFinal = model.TotalPaidTaxesFinal,
            TotalTaxableAmountInNcyDeclared = model.TotalTaxableAmountInNcyDeclared,
            TotalTaxableAmountInNcyFinal = model.TotalTaxableAmountInNcyFinal,
            TotalTaxableAmountInUsdDeclared = model.TotalTaxableAmountInUsdDeclared,
            TotalTaxableAmountInUsdFinal = model.TotalTaxableAmountInUsdFinal,
            UpdatedAt = model.UpdatedAt,
            ValidSecurityAmountDeclared = model.ValidSecurityAmountDeclared,
            ValidSecurityAmountFinal = model.ValidSecurityAmountFinal,
            ValueEvaluationStatusCode = model.ValueEvaluationStatusCode,
            VerificationResult = model.VerificationResult?.ToDto(),
        };
    }

    public static CommonVerificationDbModel ToModel(
        this CommonVerificationUpdateInput updateDto,
        CommonVerificationWhereUniqueInput uniqueId
    )
    {
        var commonVerification = new CommonVerificationDbModel
        {
            Id = uniqueId.Id,
            AdditionalFeesAmountDeclared = updateDto.AdditionalFeesAmountDeclared,
            AdditionalFeesAmountFinal = updateDto.AdditionalFeesAmountFinal,
            AdditionalFeesAmountInNcyDeclared = updateDto.AdditionalFeesAmountInNcyDeclared,
            AdditionalFeesAmountInNcyFinal = updateDto.AdditionalFeesAmountInNcyFinal,
            AdditionalFeesCurrencyCodeDeclared = updateDto.AdditionalFeesCurrencyCodeDeclared,
            AdditionalFeesCurrencyCodeFinal = updateDto.AdditionalFeesCurrencyCodeFinal,
            AdditionalFeesExchangeRateDeclared = updateDto.AdditionalFeesExchangeRateDeclared,
            AdditionalFeesExchangeRateFinal = updateDto.AdditionalFeesExchangeRateFinal,
            AdditionalLiquidCommissions = updateDto.AdditionalLiquidCommissions,
            AdditionalPayableFeesDeclared = updateDto.AdditionalPayableFeesDeclared,
            DateAndTimeOfFinalModification = updateDto.DateAndTimeOfFinalModification,
            DateAndTimeOfInitialRecord = updateDto.DateAndTimeOfInitialRecord,
            DeductedAmountDeclared = updateDto.DeductedAmountDeclared,
            DeductedAmountFinal = updateDto.DeductedAmountFinal,
            DeductedAmountInCnyFinal = updateDto.DeductedAmountInCnyFinal,
            DeductedAmountInNcyDeclared = updateDto.DeductedAmountInNcyDeclared,
            DeductedCurrencyCodeDeclared = updateDto.DeductedCurrencyCodeDeclared,
            DeductedCurrencyCodeFinal = updateDto.DeductedCurrencyCodeFinal,
            DeductionExchangeRateDeclared = updateDto.DeductionExchangeRateDeclared,
            DeductionExchangeRateFinal = updateDto.DeductionExchangeRateFinal,
            DeletedOn = updateDto.DeletedOn,
            EpcCodeDeclared = updateDto.EpcCodeDeclared,
            EpcCodeFinal = updateDto.EpcCodeFinal,
            FinalModifierId = updateDto.FinalModifierId,
            FinalOn = updateDto.FinalOn,
            FreightAmountDeclared = updateDto.FreightAmountDeclared,
            FreightAmountFinal = updateDto.FreightAmountFinal,
            FreightAmountInNcyDeclared = updateDto.FreightAmountInNcyDeclared,
            FreightAmountInNcyFinal = updateDto.FreightAmountInNcyFinal,
            FreightCurrencyCodeDeclared = updateDto.FreightCurrencyCodeDeclared,
            FreightCurrencyCodeFinal = updateDto.FreightCurrencyCodeFinal,
            FreightExchangeRateDeclared = updateDto.FreightExchangeRateDeclared,
            FreightExchangeRateFinal = updateDto.FreightExchangeRateFinal,
            ImporterIdentificationNumberDeclared = updateDto.ImporterIdentificationNumberDeclared,
            ImporterIdentificationNumberFinal = updateDto.ImporterIdentificationNumberFinal,
            ImporterIdentificationTypeCodeDeclared =
                updateDto.ImporterIdentificationTypeCodeDeclared,
            ImporterIdentificationTypeCodeFinal = updateDto.ImporterIdentificationTypeCodeFinal,
            InitialRecorderId = updateDto.InitialRecorderId,
            InsuranceAmountDeclared = updateDto.InsuranceAmountDeclared,
            InsuranceAmountFinal = updateDto.InsuranceAmountFinal,
            InsuranceAmountInNcyDeclared = updateDto.InsuranceAmountInNcyDeclared,
            InsuranceAmountInNcyFinal = updateDto.InsuranceAmountInNcyFinal,
            InsuranceCurrencyCodeDeclared = updateDto.InsuranceCurrencyCodeDeclared,
            InsuranceCurrencyCodeFinal = updateDto.InsuranceCurrencyCodeFinal,
            InsuranceExchangeRateDeclared = updateDto.InsuranceExchangeRateDeclared,
            InsuranceExchangeRateFinal = updateDto.InsuranceExchangeRateFinal,
            InvalidSecurityAmountDeclared = updateDto.InvalidSecurityAmountDeclared,
            InvalidSecurityAmountFinal = updateDto.InvalidSecurityAmountFinal,
            InvoiceAmountDeclared = updateDto.InvoiceAmountDeclared,
            InvoiceAmountFinal = updateDto.InvoiceAmountFinal,
            InvoiceAmountInNcyDeclared = updateDto.InvoiceAmountInNcyDeclared,
            InvoiceAmountInNcyFinal = updateDto.InvoiceAmountInNcyFinal,
            InvoiceAmountInUsdFinal = updateDto.InvoiceAmountInUsdFinal,
            InvoiceCurrencyCodeDeclared = updateDto.InvoiceCurrencyCodeDeclared,
            InvoiceCurrencyCodeFinal = updateDto.InvoiceCurrencyCodeFinal,
            InvoiceExchangeRateDeclared = updateDto.InvoiceExchangeRateDeclared,
            InvoiceExchangeRateFinal = updateDto.InvoiceExchangeRateFinal,
            NiuFinal = updateDto.NiuFinal,
            ReducedValidSecurityAmountDeclared = updateDto.ReducedValidSecurityAmountDeclared,
            ReducedValidSecurityAmountFinal = updateDto.ReducedValidSecurityAmountFinal,
            ResultOfVerificationOfDetailedDeclaration =
                updateDto.ResultOfVerificationOfDetailedDeclaration,
            TaxpayerIdentificationNumberDeclared = updateDto.TaxpayerIdentificationNumberDeclared,
            TotalDeclaredTaxes = updateDto.TotalDeclaredTaxes,
            TotalFinalTaxes = updateDto.TotalFinalTaxes,
            TotalPaidTaxesDeclared = updateDto.TotalPaidTaxesDeclared,
            TotalPaidTaxesFinal = updateDto.TotalPaidTaxesFinal,
            TotalTaxableAmountInNcyDeclared = updateDto.TotalTaxableAmountInNcyDeclared,
            TotalTaxableAmountInNcyFinal = updateDto.TotalTaxableAmountInNcyFinal,
            TotalTaxableAmountInUsdDeclared = updateDto.TotalTaxableAmountInUsdDeclared,
            TotalTaxableAmountInUsdFinal = updateDto.TotalTaxableAmountInUsdFinal,
            ValidSecurityAmountDeclared = updateDto.ValidSecurityAmountDeclared,
            ValidSecurityAmountFinal = updateDto.ValidSecurityAmountFinal,
            ValueEvaluationStatusCode = updateDto.ValueEvaluationStatusCode
        };

        if (updateDto.Appeal != null)
        {
            commonVerification.AppealId = updateDto.Appeal;
        }
        if (updateDto.ArticlesSubmittedForVerification != null)
        {
            commonVerification.ArticlesSubmittedForVerificationId =
                updateDto.ArticlesSubmittedForVerification;
        }
        if (updateDto.CreatedAt != null)
        {
            commonVerification.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.UpdatedAt != null)
        {
            commonVerification.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return commonVerification;
    }
}
