using Control.APIs.Dtos;
using Control.Infrastructure.Models;

namespace Control.APIs.Extensions;

public static class ValueAssessmentsExtensions
{
    public static ValueAssessment ToDto(this ValueAssessmentDbModel model)
    {
        return new ValueAssessment
        {
            Articles = model.Articles?.Select(x => x.Id).ToList(),
            CommonDetailedDeclarations = model.CommonDetailedDeclarations?.ToDto(),
            CreatedAt = model.CreatedAt,
            DeductedAmount = model.DeductedAmount,
            DeductionCurrencyCode = model.DeductionCurrencyCode,
            DeductionExchangeRate = model.DeductionExchangeRate,
            DeductionNcyAmount = model.DeductionNcyAmount,
            FinalModificationDateTime = model.FinalModificationDateTime,
            FinalModifierId = model.FinalModifierId,
            FirstRecorderId = model.FirstRecorderId,
            FirstRecordingDateTime = model.FirstRecordingDateTime,
            FreightAmount = model.FreightAmount,
            FreightCurrencyCode = model.FreightCurrencyCode,
            FreightExchangeRate = model.FreightExchangeRate,
            FreightNcyAmount = model.FreightNcyAmount,
            Id = model.Id,
            InsuranceAmount = model.InsuranceAmount,
            InsuranceCurrencyCode = model.InsuranceCurrencyCode,
            InsuranceExchangeRate = model.InsuranceExchangeRate,
            InsuranceNcyAmount = model.InsuranceNcyAmount,
            InvoiceAmount = model.InvoiceAmount,
            InvoiceExchangeRate = model.InvoiceExchangeRate,
            InvoiceNcyAmount = model.InvoiceNcyAmount,
            InvoiceUsdAmount = model.InvoiceUsdAmount,
            OtherCostsAmount = model.OtherCostsAmount,
            OtherCostsCurrencyCode = model.OtherCostsCurrencyCode,
            OtherCostsExchangeRate = model.OtherCostsExchangeRate,
            OtherCostsNcyAmount = model.OtherCostsNcyAmount,
            SuppressionOn = model.SuppressionOn,
            TotalTaxableBaseNcyTotal = model.TotalTaxableBaseNcyTotal,
            TotalTaxableBaseUsdTotal = model.TotalTaxableBaseUsdTotal,
            TotalValueAssessmentNcyAmount = model.TotalValueAssessmentNcyAmount,
            TotalValueAssessmentUsdAmount = model.TotalValueAssessmentUsdAmount,
            UpdatedAt = model.UpdatedAt,
        };
    }

    public static ValueAssessmentDbModel ToModel(
        this ValueAssessmentUpdateInput updateDto,
        ValueAssessmentWhereUniqueInput uniqueId
    )
    {
        var valueAssessment = new ValueAssessmentDbModel
        {
            Id = uniqueId.Id,
            DeductedAmount = updateDto.DeductedAmount,
            DeductionCurrencyCode = updateDto.DeductionCurrencyCode,
            DeductionExchangeRate = updateDto.DeductionExchangeRate,
            DeductionNcyAmount = updateDto.DeductionNcyAmount,
            FinalModificationDateTime = updateDto.FinalModificationDateTime,
            FinalModifierId = updateDto.FinalModifierId,
            FirstRecorderId = updateDto.FirstRecorderId,
            FirstRecordingDateTime = updateDto.FirstRecordingDateTime,
            FreightAmount = updateDto.FreightAmount,
            FreightCurrencyCode = updateDto.FreightCurrencyCode,
            FreightExchangeRate = updateDto.FreightExchangeRate,
            FreightNcyAmount = updateDto.FreightNcyAmount,
            InsuranceAmount = updateDto.InsuranceAmount,
            InsuranceCurrencyCode = updateDto.InsuranceCurrencyCode,
            InsuranceExchangeRate = updateDto.InsuranceExchangeRate,
            InsuranceNcyAmount = updateDto.InsuranceNcyAmount,
            InvoiceAmount = updateDto.InvoiceAmount,
            InvoiceExchangeRate = updateDto.InvoiceExchangeRate,
            InvoiceNcyAmount = updateDto.InvoiceNcyAmount,
            InvoiceUsdAmount = updateDto.InvoiceUsdAmount,
            OtherCostsAmount = updateDto.OtherCostsAmount,
            OtherCostsCurrencyCode = updateDto.OtherCostsCurrencyCode,
            OtherCostsExchangeRate = updateDto.OtherCostsExchangeRate,
            OtherCostsNcyAmount = updateDto.OtherCostsNcyAmount,
            SuppressionOn = updateDto.SuppressionOn,
            TotalTaxableBaseNcyTotal = updateDto.TotalTaxableBaseNcyTotal,
            TotalTaxableBaseUsdTotal = updateDto.TotalTaxableBaseUsdTotal,
            TotalValueAssessmentNcyAmount = updateDto.TotalValueAssessmentNcyAmount,
            TotalValueAssessmentUsdAmount = updateDto.TotalValueAssessmentUsdAmount
        };

        if (updateDto.CreatedAt != null)
        {
            valueAssessment.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.UpdatedAt != null)
        {
            valueAssessment.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return valueAssessment;
    }
}
