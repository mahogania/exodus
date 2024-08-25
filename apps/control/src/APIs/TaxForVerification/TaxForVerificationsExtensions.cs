using Control.APIs.Dtos;
using Control.Infrastructure.Models;

namespace Control.APIs.Extensions;

public static class TaxForVerificationsExtensions
{
    public static TaxForVerification ToDto(this TaxForVerificationDbModel model)
    {
        return new TaxForVerification
        {
            ArticleNumber = model.ArticleNumber,
            ArticlesSubmittedForVerifications = model.ArticlesSubmittedForVerificationsId,
            BasicTaxAmount = model.BasicTaxAmount,
            BasicTaxRate = model.BasicTaxRate,
            BasicTaxableAmount = model.BasicTaxableAmount,
            CommonVerifications = model.CommonVerifications?.Select(x => x.Id).ToList(),
            CreatedAt = model.CreatedAt,
            DateAndTimeOfFinalModification = model.DateAndTimeOfFinalModification,
            DateAndTimeOfInitialRecord = model.DateAndTimeOfInitialRecord,
            DeletedOn = model.DeletedOn,
            ExemptedAmount = model.ExemptedAmount,
            ExemptedTaxRate = model.ExemptedTaxRate,
            ExemptionBaseAmount = model.ExemptionBaseAmount,
            ExemptionTypeCode = model.ExemptionTypeCode,
            FinalModifierId = model.FinalModifierId,
            Id = model.Id,
            InitialRecorderId = model.InitialRecorderId,
            NumberOfTimesOfValueEvaluation = model.NumberOfTimesOfValueEvaluation,
            PaidTaxAmount = model.PaidTaxAmount,
            PaymentTypeCode = model.PaymentTypeCode,
            SecurityDepositAfterExemption = model.SecurityDepositAfterExemption,
            TariffCategoryCode = model.TariffCategoryCode,
            TaxAmount = model.TaxAmount,
            TaxBaseAmount = model.TaxBaseAmount,
            TaxBenefitCode = model.TaxBenefitCode,
            TaxCode = model.TaxCode,
            TaxRate = model.TaxRate,
            UpdatedAt = model.UpdatedAt,
        };
    }

    public static TaxForVerificationDbModel ToModel(
        this TaxForVerificationUpdateInput updateDto,
        TaxForVerificationWhereUniqueInput uniqueId
    )
    {
        var taxForVerification = new TaxForVerificationDbModel
        {
            Id = uniqueId.Id,
            ArticleNumber = updateDto.ArticleNumber,
            BasicTaxAmount = updateDto.BasicTaxAmount,
            BasicTaxRate = updateDto.BasicTaxRate,
            BasicTaxableAmount = updateDto.BasicTaxableAmount,
            DateAndTimeOfFinalModification = updateDto.DateAndTimeOfFinalModification,
            DateAndTimeOfInitialRecord = updateDto.DateAndTimeOfInitialRecord,
            DeletedOn = updateDto.DeletedOn,
            ExemptedAmount = updateDto.ExemptedAmount,
            ExemptedTaxRate = updateDto.ExemptedTaxRate,
            ExemptionBaseAmount = updateDto.ExemptionBaseAmount,
            ExemptionTypeCode = updateDto.ExemptionTypeCode,
            FinalModifierId = updateDto.FinalModifierId,
            InitialRecorderId = updateDto.InitialRecorderId,
            NumberOfTimesOfValueEvaluation = updateDto.NumberOfTimesOfValueEvaluation,
            PaidTaxAmount = updateDto.PaidTaxAmount,
            PaymentTypeCode = updateDto.PaymentTypeCode,
            SecurityDepositAfterExemption = updateDto.SecurityDepositAfterExemption,
            TariffCategoryCode = updateDto.TariffCategoryCode,
            TaxAmount = updateDto.TaxAmount,
            TaxBaseAmount = updateDto.TaxBaseAmount,
            TaxBenefitCode = updateDto.TaxBenefitCode,
            TaxCode = updateDto.TaxCode,
            TaxRate = updateDto.TaxRate
        };

        if (updateDto.ArticlesSubmittedForVerifications != null)
        {
            taxForVerification.ArticlesSubmittedForVerificationsId =
                updateDto.ArticlesSubmittedForVerifications;
        }
        if (updateDto.CreatedAt != null)
        {
            taxForVerification.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.UpdatedAt != null)
        {
            taxForVerification.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return taxForVerification;
    }
}
