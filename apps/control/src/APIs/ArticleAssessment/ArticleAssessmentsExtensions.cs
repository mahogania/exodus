using Control.APIs.Dtos;
using Control.Infrastructure.Models;

namespace Control.APIs.Extensions;

public static class ArticleAssessmentsExtensions
{
    public static ArticleAssessment ToDto(this ArticleAssessmentDbModel model)
    {
        return new ArticleAssessment
        {
            AmountDeductedOfTheArticle = model.AmountDeductedOfTheArticle,
            AmountNcyDeductedOfTheArticle = model.AmountNcyDeductedOfTheArticle,
            AmountNcyOfTheEvaluationOfValueOfTheArticle =
                model.AmountNcyOfTheEvaluationOfValueOfTheArticle,
            AmountNcyOfTheFairValueOfTheArticle = model.AmountNcyOfTheFairValueOfTheArticle,
            AmountNcyOfTheFreightOfTheArticle = model.AmountNcyOfTheFreightOfTheArticle,
            AmountNcyOfTheInsuranceOfTheArticle = model.AmountNcyOfTheInsuranceOfTheArticle,
            AmountNcyOfTheInvoiceOfTheArticle = model.AmountNcyOfTheInvoiceOfTheArticle,
            AmountNcyOfTheOtherCostsOfTheArticle = model.AmountNcyOfTheOtherCostsOfTheArticle,
            AmountNycOfTheTaxableBaseOfTheArticle = model.AmountNycOfTheTaxableBaseOfTheArticle,
            AmountOfTheFreightOfTheArticle = model.AmountOfTheFreightOfTheArticle,
            AmountOfTheInsuranceOfTheArticle = model.AmountOfTheInsuranceOfTheArticle,
            AmountOfTheInvoiceOfTheArticle = model.AmountOfTheInvoiceOfTheArticle,
            AmountOfTheOtherCostsOfTheArticle = model.AmountOfTheOtherCostsOfTheArticle,
            AmountUsdOfTheEvaluationOfValueOfTheArticle =
                model.AmountUsdOfTheEvaluationOfValueOfTheArticle,
            AmountUsdOfTheFairValueOfTheArticle = model.AmountUsdOfTheFairValueOfTheArticle,
            AmountUsdOfTheInvoiceOfTheArticle = model.AmountUsdOfTheInvoiceOfTheArticle,
            AmountUsdOfTheTaxableBaseOfTheArticle = model.AmountUsdOfTheTaxableBaseOfTheArticle,
            Article = model.ArticleId,
            ArticleNumber = model.ArticleNumber,
            BasicValueOfTheFairValueOfTheArticle = model.BasicValueOfTheFairValueOfTheArticle,
            CreatedAt = model.CreatedAt,
            CurrencyCodeDeductedOfTheArticle = model.CurrencyCodeDeductedOfTheArticle,
            CurrencyCodeOfTheFairValueOfTheArticle = model.CurrencyCodeOfTheFairValueOfTheArticle,
            CurrencyCodeOfTheFreightOfTheArticle = model.CurrencyCodeOfTheFreightOfTheArticle,
            CurrencyCodeOfTheInsuranceOfTheArticle = model.CurrencyCodeOfTheInsuranceOfTheArticle,
            CurrencyCodeOfTheInvoiceOfTheArticle = model.CurrencyCodeOfTheInvoiceOfTheArticle,
            CurrencyCodeOfTheOtherCostsOfTheArticle = model.CurrencyCodeOfTheOtherCostsOfTheArticle,
            DateAndTimeOfFinalModification = model.DateAndTimeOfFinalModification,
            DateAndTimeOfFirstRegistration = model.DateAndTimeOfFirstRegistration,
            ExchangeRateOfTheDeductionOfTheArticle = model.ExchangeRateOfTheDeductionOfTheArticle,
            ExchangeRateOfTheFreightOfTheArticle = model.ExchangeRateOfTheFreightOfTheArticle,
            ExchangeRateOfTheInsuranceOfTheArticle = model.ExchangeRateOfTheInsuranceOfTheArticle,
            ExchangeRateOfTheInvoiceOfTheArticle = model.ExchangeRateOfTheInvoiceOfTheArticle,
            ExchangeRateOfTheOtherCostsOfTheArticle = model.ExchangeRateOfTheOtherCostsOfTheArticle,
            FinalModifierSId = model.FinalModifierSId,
            FirstRegistrantSId = model.FirstRegistrantSId,
            Id = model.Id,
            RectificationFrequency = model.RectificationFrequency,
            ReferenceNumber = model.ReferenceNumber,
            SuppressionOn = model.SuppressionOn,
            UnitAmountOfTheFairValueOfTheArticle = model.UnitAmountOfTheFairValueOfTheArticle,
            UpdatedAt = model.UpdatedAt,
            ValueAssessment = model.ValueAssessmentId,
        };
    }

    public static ArticleAssessmentDbModel ToModel(
        this ArticleAssessmentUpdateInput updateDto,
        ArticleAssessmentWhereUniqueInput uniqueId
    )
    {
        var articleAssessment = new ArticleAssessmentDbModel
        {
            Id = uniqueId.Id,
            AmountDeductedOfTheArticle = updateDto.AmountDeductedOfTheArticle,
            AmountNcyDeductedOfTheArticle = updateDto.AmountNcyDeductedOfTheArticle,
            AmountNcyOfTheEvaluationOfValueOfTheArticle =
                updateDto.AmountNcyOfTheEvaluationOfValueOfTheArticle,
            AmountNcyOfTheFairValueOfTheArticle = updateDto.AmountNcyOfTheFairValueOfTheArticle,
            AmountNcyOfTheFreightOfTheArticle = updateDto.AmountNcyOfTheFreightOfTheArticle,
            AmountNcyOfTheInsuranceOfTheArticle = updateDto.AmountNcyOfTheInsuranceOfTheArticle,
            AmountNcyOfTheInvoiceOfTheArticle = updateDto.AmountNcyOfTheInvoiceOfTheArticle,
            AmountNcyOfTheOtherCostsOfTheArticle = updateDto.AmountNcyOfTheOtherCostsOfTheArticle,
            AmountNycOfTheTaxableBaseOfTheArticle = updateDto.AmountNycOfTheTaxableBaseOfTheArticle,
            AmountOfTheFreightOfTheArticle = updateDto.AmountOfTheFreightOfTheArticle,
            AmountOfTheInsuranceOfTheArticle = updateDto.AmountOfTheInsuranceOfTheArticle,
            AmountOfTheInvoiceOfTheArticle = updateDto.AmountOfTheInvoiceOfTheArticle,
            AmountOfTheOtherCostsOfTheArticle = updateDto.AmountOfTheOtherCostsOfTheArticle,
            AmountUsdOfTheEvaluationOfValueOfTheArticle =
                updateDto.AmountUsdOfTheEvaluationOfValueOfTheArticle,
            AmountUsdOfTheFairValueOfTheArticle = updateDto.AmountUsdOfTheFairValueOfTheArticle,
            AmountUsdOfTheInvoiceOfTheArticle = updateDto.AmountUsdOfTheInvoiceOfTheArticle,
            AmountUsdOfTheTaxableBaseOfTheArticle = updateDto.AmountUsdOfTheTaxableBaseOfTheArticle,
            ArticleNumber = updateDto.ArticleNumber,
            BasicValueOfTheFairValueOfTheArticle = updateDto.BasicValueOfTheFairValueOfTheArticle,
            CurrencyCodeDeductedOfTheArticle = updateDto.CurrencyCodeDeductedOfTheArticle,
            CurrencyCodeOfTheFairValueOfTheArticle =
                updateDto.CurrencyCodeOfTheFairValueOfTheArticle,
            CurrencyCodeOfTheFreightOfTheArticle = updateDto.CurrencyCodeOfTheFreightOfTheArticle,
            CurrencyCodeOfTheInsuranceOfTheArticle =
                updateDto.CurrencyCodeOfTheInsuranceOfTheArticle,
            CurrencyCodeOfTheInvoiceOfTheArticle = updateDto.CurrencyCodeOfTheInvoiceOfTheArticle,
            CurrencyCodeOfTheOtherCostsOfTheArticle =
                updateDto.CurrencyCodeOfTheOtherCostsOfTheArticle,
            DateAndTimeOfFinalModification = updateDto.DateAndTimeOfFinalModification,
            DateAndTimeOfFirstRegistration = updateDto.DateAndTimeOfFirstRegistration,
            ExchangeRateOfTheDeductionOfTheArticle =
                updateDto.ExchangeRateOfTheDeductionOfTheArticle,
            ExchangeRateOfTheFreightOfTheArticle = updateDto.ExchangeRateOfTheFreightOfTheArticle,
            ExchangeRateOfTheInsuranceOfTheArticle =
                updateDto.ExchangeRateOfTheInsuranceOfTheArticle,
            ExchangeRateOfTheInvoiceOfTheArticle = updateDto.ExchangeRateOfTheInvoiceOfTheArticle,
            ExchangeRateOfTheOtherCostsOfTheArticle =
                updateDto.ExchangeRateOfTheOtherCostsOfTheArticle,
            FinalModifierSId = updateDto.FinalModifierSId,
            FirstRegistrantSId = updateDto.FirstRegistrantSId,
            RectificationFrequency = updateDto.RectificationFrequency,
            ReferenceNumber = updateDto.ReferenceNumber,
            SuppressionOn = updateDto.SuppressionOn,
            UnitAmountOfTheFairValueOfTheArticle = updateDto.UnitAmountOfTheFairValueOfTheArticle
        };

        if (updateDto.Article != null)
        {
            articleAssessment.ArticleId = updateDto.Article;
        }
        if (updateDto.CreatedAt != null)
        {
            articleAssessment.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.UpdatedAt != null)
        {
            articleAssessment.UpdatedAt = updateDto.UpdatedAt.Value;
        }
        if (updateDto.ValueAssessment != null)
        {
            articleAssessment.ValueAssessmentId = updateDto.ValueAssessment;
        }

        return articleAssessment;
    }
}
