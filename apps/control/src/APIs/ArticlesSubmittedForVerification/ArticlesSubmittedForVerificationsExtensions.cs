using Control.APIs.Dtos;
using Control.Infrastructure.Models;

namespace Control.APIs.Extensions;

public static class ArticlesSubmittedForVerificationsExtensions
{
    public static ArticlesSubmittedForVerification ToDto(
        this ArticlesSubmittedForVerificationDbModel model
    )
    {
        return new ArticlesSubmittedForVerification
        {
            ArticleNumber = model.ArticleNumber,
            CommonVerifications = model.CommonVerifications?.Select(x => x.Id).ToList(),
            CreatedAt = model.CreatedAt,
            DateAndTimeOfFinalModification = model.DateAndTimeOfFinalModification,
            DateAndTimeOfInitialRecord = model.DateAndTimeOfInitialRecord,
            DeclaredAdditionalFeesAmountInNcyOfTheArticle =
                model.DeclaredAdditionalFeesAmountInNcyOfTheArticle,
            DeclaredAdditionalFeesAmountOfTheArticle =
                model.DeclaredAdditionalFeesAmountOfTheArticle,
            DeclaredAdditionalFeesCurrencyCodeOfTheArticle =
                model.DeclaredAdditionalFeesCurrencyCodeOfTheArticle,
            DeclaredAdditionalFeesExchangeRateOfTheArticle =
                model.DeclaredAdditionalFeesExchangeRateOfTheArticle,
            DeclaredApcCode = model.DeclaredApcCode,
            DeclaredCountryOfOriginCode = model.DeclaredCountryOfOriginCode,
            DeclaredDeductedAmountInNcyOfTheArticle = model.DeclaredDeductedAmountInNcyOfTheArticle,
            DeclaredDeductedAmountOfTheArticle = model.DeclaredDeductedAmountOfTheArticle,
            DeclaredDeductedCurrencyCodeOfTheArticle =
                model.DeclaredDeductedCurrencyCodeOfTheArticle,
            DeclaredDeductionExchangeRateOfTheArticle =
                model.DeclaredDeductionExchangeRateOfTheArticle,
            DeclaredEvaluationMethodCode = model.DeclaredEvaluationMethodCode,
            DeclaredFreightAmountInNcyOfTheArticle = model.DeclaredFreightAmountInNcyOfTheArticle,
            DeclaredFreightAmountOfTheArticle = model.DeclaredFreightAmountOfTheArticle,
            DeclaredFreightCurrencyCodeOfTheArticle = model.DeclaredFreightCurrencyCodeOfTheArticle,
            DeclaredFreightExchangeRateOfTheArticle = model.DeclaredFreightExchangeRateOfTheArticle,
            DeclaredGrossWeightOfTheArticle = model.DeclaredGrossWeightOfTheArticle,
            DeclaredInsuranceAmountInNcyOfTheArticle =
                model.DeclaredInsuranceAmountInNcyOfTheArticle,
            DeclaredInsuranceAmountOfTheArticle = model.DeclaredInsuranceAmountOfTheArticle,
            DeclaredInsuranceCurrencyCodeOfTheArticle =
                model.DeclaredInsuranceCurrencyCodeOfTheArticle,
            DeclaredInsuranceExchangeRateOfTheArticle =
                model.DeclaredInsuranceExchangeRateOfTheArticle,
            DeclaredInvoiceAmountInNcyOfTheArticle = model.DeclaredInvoiceAmountInNcyOfTheArticle,
            DeclaredInvoiceAmountInUsdOfTheArticle = model.DeclaredInvoiceAmountInUsdOfTheArticle,
            DeclaredInvoiceAmountOfTheArticle = model.DeclaredInvoiceAmountOfTheArticle,
            DeclaredInvoiceCurrencyCodeOfTheArticle = model.DeclaredInvoiceCurrencyCodeOfTheArticle,
            DeclaredInvoiceExchangeRateOfTheArticle = model.DeclaredInvoiceExchangeRateOfTheArticle,
            DeclaredNetWeightOfTheArticle = model.DeclaredNetWeightOfTheArticle,
            DeclaredPreferentialCode = model.DeclaredPreferentialCode,
            DeclaredShCode = model.DeclaredShCode,
            DeclaredTaxableBaseAmountInNcyOfTheArticle =
                model.DeclaredTaxableBaseAmountInNcyOfTheArticle,
            DeclaredTaxableBaseAmountInUsdOfTheArticle =
                model.DeclaredTaxableBaseAmountInUsdOfTheArticle,
            DeletedOn = model.DeletedOn,
            FinalModifierId = model.FinalModifierId,
            Id = model.Id,
            InitialRecorderId = model.InitialRecorderId,
            LiquidatedAdditionalFeesAmountInNcyOfTheArticle =
                model.LiquidatedAdditionalFeesAmountInNcyOfTheArticle,
            LiquidatedAdditionalFeesAmountOfTheArticle =
                model.LiquidatedAdditionalFeesAmountOfTheArticle,
            LiquidatedAdditionalFeesCurrencyCodeOfTheArticle =
                model.LiquidatedAdditionalFeesCurrencyCodeOfTheArticle,
            LiquidatedAdditionalFeesExchangeRateOfTheArticle =
                model.LiquidatedAdditionalFeesExchangeRateOfTheArticle,
            LiquidatedApcCode = model.LiquidatedApcCode,
            LiquidatedCountryOfOriginCode = model.LiquidatedCountryOfOriginCode,
            LiquidatedDeductedAmountInNcyOfTheArticle =
                model.LiquidatedDeductedAmountInNcyOfTheArticle,
            LiquidatedDeductedAmountOfTheArticle = model.LiquidatedDeductedAmountOfTheArticle,
            LiquidatedDeductedCurrencyCodeOfTheArticle =
                model.LiquidatedDeductedCurrencyCodeOfTheArticle,
            LiquidatedDeductionExchangeRateOfTheArticle =
                model.LiquidatedDeductionExchangeRateOfTheArticle,
            LiquidatedEvaluationMethodCode = model.LiquidatedEvaluationMethodCode,
            LiquidatedFreightAmountInNcyOfTheArticle =
                model.LiquidatedFreightAmountInNcyOfTheArticle,
            LiquidatedFreightAmountOfTheArticle = model.LiquidatedFreightAmountOfTheArticle,
            LiquidatedFreightCurrencyCodeOfTheArticle =
                model.LiquidatedFreightCurrencyCodeOfTheArticle,
            LiquidatedFreightExchangeRateOfTheArticle =
                model.LiquidatedFreightExchangeRateOfTheArticle,
            LiquidatedInsuranceAmountInNcyOfTheArticle =
                model.LiquidatedInsuranceAmountInNcyOfTheArticle,
            LiquidatedInsuranceAmountOfTheArticle = model.LiquidatedInsuranceAmountOfTheArticle,
            LiquidatedInsuranceCurrencyCodeOfTheArticle =
                model.LiquidatedInsuranceCurrencyCodeOfTheArticle,
            LiquidatedInsuranceExchangeRateOfTheArticle =
                model.LiquidatedInsuranceExchangeRateOfTheArticle,
            LiquidatedInvoiceAmountInNcyOfTheArticle =
                model.LiquidatedInvoiceAmountInNcyOfTheArticle,
            LiquidatedInvoiceAmountInUsdOfTheArticle =
                model.LiquidatedInvoiceAmountInUsdOfTheArticle,
            LiquidatedInvoiceAmountOfTheArticle = model.LiquidatedInvoiceAmountOfTheArticle,
            LiquidatedInvoiceCurrencyCodeOfTheArticle =
                model.LiquidatedInvoiceCurrencyCodeOfTheArticle,
            LiquidatedInvoiceExchangeRateOfTheArticle =
                model.LiquidatedInvoiceExchangeRateOfTheArticle,
            LiquidatedNetWeightOfTheArticle = model.LiquidatedNetWeightOfTheArticle,
            LiquidatedPreferentialCode = model.LiquidatedPreferentialCode,
            LiquidatedShCode = model.LiquidatedShCode,
            LiquidatedTaxableBaseAmountInNcyOfTheArticle =
                model.LiquidatedTaxableBaseAmountInNcyOfTheArticle,
            LiquidatedTaxableBaseAmountInUsdOfTheArticle =
                model.LiquidatedTaxableBaseAmountInUsdOfTheArticle,
            NumberOfTimesOfValueEvaluation = model.NumberOfTimesOfValueEvaluation,
            TaxesForVerification = model.TaxesForVerification?.Select(x => x.Id).ToList(),
            TotalLiquidatedWeightOfTheArticle = model.TotalLiquidatedWeightOfTheArticle,
            UpdatedAt = model.UpdatedAt,
        };
    }

    public static ArticlesSubmittedForVerificationDbModel ToModel(
        this ArticlesSubmittedForVerificationUpdateInput updateDto,
        ArticlesSubmittedForVerificationWhereUniqueInput uniqueId
    )
    {
        var articlesSubmittedForVerification = new ArticlesSubmittedForVerificationDbModel
        {
            Id = uniqueId.Id,
            ArticleNumber = updateDto.ArticleNumber,
            DateAndTimeOfFinalModification = updateDto.DateAndTimeOfFinalModification,
            DateAndTimeOfInitialRecord = updateDto.DateAndTimeOfInitialRecord,
            DeclaredAdditionalFeesAmountInNcyOfTheArticle =
                updateDto.DeclaredAdditionalFeesAmountInNcyOfTheArticle,
            DeclaredAdditionalFeesAmountOfTheArticle =
                updateDto.DeclaredAdditionalFeesAmountOfTheArticle,
            DeclaredAdditionalFeesCurrencyCodeOfTheArticle =
                updateDto.DeclaredAdditionalFeesCurrencyCodeOfTheArticle,
            DeclaredAdditionalFeesExchangeRateOfTheArticle =
                updateDto.DeclaredAdditionalFeesExchangeRateOfTheArticle,
            DeclaredApcCode = updateDto.DeclaredApcCode,
            DeclaredCountryOfOriginCode = updateDto.DeclaredCountryOfOriginCode,
            DeclaredDeductedAmountInNcyOfTheArticle =
                updateDto.DeclaredDeductedAmountInNcyOfTheArticle,
            DeclaredDeductedAmountOfTheArticle = updateDto.DeclaredDeductedAmountOfTheArticle,
            DeclaredDeductedCurrencyCodeOfTheArticle =
                updateDto.DeclaredDeductedCurrencyCodeOfTheArticle,
            DeclaredDeductionExchangeRateOfTheArticle =
                updateDto.DeclaredDeductionExchangeRateOfTheArticle,
            DeclaredEvaluationMethodCode = updateDto.DeclaredEvaluationMethodCode,
            DeclaredFreightAmountInNcyOfTheArticle =
                updateDto.DeclaredFreightAmountInNcyOfTheArticle,
            DeclaredFreightAmountOfTheArticle = updateDto.DeclaredFreightAmountOfTheArticle,
            DeclaredFreightCurrencyCodeOfTheArticle =
                updateDto.DeclaredFreightCurrencyCodeOfTheArticle,
            DeclaredFreightExchangeRateOfTheArticle =
                updateDto.DeclaredFreightExchangeRateOfTheArticle,
            DeclaredGrossWeightOfTheArticle = updateDto.DeclaredGrossWeightOfTheArticle,
            DeclaredInsuranceAmountInNcyOfTheArticle =
                updateDto.DeclaredInsuranceAmountInNcyOfTheArticle,
            DeclaredInsuranceAmountOfTheArticle = updateDto.DeclaredInsuranceAmountOfTheArticle,
            DeclaredInsuranceCurrencyCodeOfTheArticle =
                updateDto.DeclaredInsuranceCurrencyCodeOfTheArticle,
            DeclaredInsuranceExchangeRateOfTheArticle =
                updateDto.DeclaredInsuranceExchangeRateOfTheArticle,
            DeclaredInvoiceAmountInNcyOfTheArticle =
                updateDto.DeclaredInvoiceAmountInNcyOfTheArticle,
            DeclaredInvoiceAmountInUsdOfTheArticle =
                updateDto.DeclaredInvoiceAmountInUsdOfTheArticle,
            DeclaredInvoiceAmountOfTheArticle = updateDto.DeclaredInvoiceAmountOfTheArticle,
            DeclaredInvoiceCurrencyCodeOfTheArticle =
                updateDto.DeclaredInvoiceCurrencyCodeOfTheArticle,
            DeclaredInvoiceExchangeRateOfTheArticle =
                updateDto.DeclaredInvoiceExchangeRateOfTheArticle,
            DeclaredNetWeightOfTheArticle = updateDto.DeclaredNetWeightOfTheArticle,
            DeclaredPreferentialCode = updateDto.DeclaredPreferentialCode,
            DeclaredShCode = updateDto.DeclaredShCode,
            DeclaredTaxableBaseAmountInNcyOfTheArticle =
                updateDto.DeclaredTaxableBaseAmountInNcyOfTheArticle,
            DeclaredTaxableBaseAmountInUsdOfTheArticle =
                updateDto.DeclaredTaxableBaseAmountInUsdOfTheArticle,
            DeletedOn = updateDto.DeletedOn,
            FinalModifierId = updateDto.FinalModifierId,
            InitialRecorderId = updateDto.InitialRecorderId,
            LiquidatedAdditionalFeesAmountInNcyOfTheArticle =
                updateDto.LiquidatedAdditionalFeesAmountInNcyOfTheArticle,
            LiquidatedAdditionalFeesAmountOfTheArticle =
                updateDto.LiquidatedAdditionalFeesAmountOfTheArticle,
            LiquidatedAdditionalFeesCurrencyCodeOfTheArticle =
                updateDto.LiquidatedAdditionalFeesCurrencyCodeOfTheArticle,
            LiquidatedAdditionalFeesExchangeRateOfTheArticle =
                updateDto.LiquidatedAdditionalFeesExchangeRateOfTheArticle,
            LiquidatedApcCode = updateDto.LiquidatedApcCode,
            LiquidatedCountryOfOriginCode = updateDto.LiquidatedCountryOfOriginCode,
            LiquidatedDeductedAmountInNcyOfTheArticle =
                updateDto.LiquidatedDeductedAmountInNcyOfTheArticle,
            LiquidatedDeductedAmountOfTheArticle = updateDto.LiquidatedDeductedAmountOfTheArticle,
            LiquidatedDeductedCurrencyCodeOfTheArticle =
                updateDto.LiquidatedDeductedCurrencyCodeOfTheArticle,
            LiquidatedDeductionExchangeRateOfTheArticle =
                updateDto.LiquidatedDeductionExchangeRateOfTheArticle,
            LiquidatedEvaluationMethodCode = updateDto.LiquidatedEvaluationMethodCode,
            LiquidatedFreightAmountInNcyOfTheArticle =
                updateDto.LiquidatedFreightAmountInNcyOfTheArticle,
            LiquidatedFreightAmountOfTheArticle = updateDto.LiquidatedFreightAmountOfTheArticle,
            LiquidatedFreightCurrencyCodeOfTheArticle =
                updateDto.LiquidatedFreightCurrencyCodeOfTheArticle,
            LiquidatedFreightExchangeRateOfTheArticle =
                updateDto.LiquidatedFreightExchangeRateOfTheArticle,
            LiquidatedInsuranceAmountInNcyOfTheArticle =
                updateDto.LiquidatedInsuranceAmountInNcyOfTheArticle,
            LiquidatedInsuranceAmountOfTheArticle = updateDto.LiquidatedInsuranceAmountOfTheArticle,
            LiquidatedInsuranceCurrencyCodeOfTheArticle =
                updateDto.LiquidatedInsuranceCurrencyCodeOfTheArticle,
            LiquidatedInsuranceExchangeRateOfTheArticle =
                updateDto.LiquidatedInsuranceExchangeRateOfTheArticle,
            LiquidatedInvoiceAmountInNcyOfTheArticle =
                updateDto.LiquidatedInvoiceAmountInNcyOfTheArticle,
            LiquidatedInvoiceAmountInUsdOfTheArticle =
                updateDto.LiquidatedInvoiceAmountInUsdOfTheArticle,
            LiquidatedInvoiceAmountOfTheArticle = updateDto.LiquidatedInvoiceAmountOfTheArticle,
            LiquidatedInvoiceCurrencyCodeOfTheArticle =
                updateDto.LiquidatedInvoiceCurrencyCodeOfTheArticle,
            LiquidatedInvoiceExchangeRateOfTheArticle =
                updateDto.LiquidatedInvoiceExchangeRateOfTheArticle,
            LiquidatedNetWeightOfTheArticle = updateDto.LiquidatedNetWeightOfTheArticle,
            LiquidatedPreferentialCode = updateDto.LiquidatedPreferentialCode,
            LiquidatedShCode = updateDto.LiquidatedShCode,
            LiquidatedTaxableBaseAmountInNcyOfTheArticle =
                updateDto.LiquidatedTaxableBaseAmountInNcyOfTheArticle,
            LiquidatedTaxableBaseAmountInUsdOfTheArticle =
                updateDto.LiquidatedTaxableBaseAmountInUsdOfTheArticle,
            NumberOfTimesOfValueEvaluation = updateDto.NumberOfTimesOfValueEvaluation,
            TotalLiquidatedWeightOfTheArticle = updateDto.TotalLiquidatedWeightOfTheArticle
        };

        if (updateDto.CreatedAt != null)
        {
            articlesSubmittedForVerification.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.UpdatedAt != null)
        {
            articlesSubmittedForVerification.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return articlesSubmittedForVerification;
    }
}
