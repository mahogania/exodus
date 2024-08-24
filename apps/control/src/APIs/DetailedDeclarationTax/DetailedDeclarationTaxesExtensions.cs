using Control.APIs.Dtos;
using Control.Infrastructure.Models;

namespace Control.APIs.Extensions;

public static class DetailedDeclarationTaxesExtensions
{
    public static DetailedDeclarationTax ToDto(this DetailedDeclarationTaxDbModel model)
    {
        return new DetailedDeclarationTax
        {
            Article = model.Article?.ToDto(),
            ArticleNumber = model.ArticleNumber,
            BasicTaxAmount = model.BasicTaxAmount,
            BasicTaxableBaseAmount = model.BasicTaxableBaseAmount,
            BasicTaxationRate = model.BasicTaxationRate,
            CautionAmountAfterExemptionOfGuarantee = model.CautionAmountAfterExemptionOfGuarantee,
            CreatedAt = model.CreatedAt,
            DateAndTimeOfFinalModification = model.DateAndTimeOfFinalModification,
            DateAndTimeOfFirstRegistration = model.DateAndTimeOfFirstRegistration,
            ExemptAmount = model.ExemptAmount,
            ExemptTaxationRate = model.ExemptTaxationRate,
            ExemptionBaseAmount = model.ExemptionBaseAmount,
            ExemptionTypeCode = model.ExemptionTypeCode,
            FinalModifierSId = model.FinalModifierSId,
            Id = model.Id,
            IdDuPremierEnregistrant = model.IdDuPremierEnregistrant,
            PaidTaxAmount = model.PaidTaxAmount,
            PaymentTypeCode = model.PaymentTypeCode,
            RectificationFrequency = model.RectificationFrequency,
            ReferenceNumber = model.ReferenceNumber,
            SuppressionOn = model.SuppressionOn,
            TariffCategoryCode = model.TariffCategoryCode,
            TaxAdvantageCode = model.TaxAdvantageCode,
            TaxAmount = model.TaxAmount,
            TaxCode = model.TaxCode,
            TaxableBaseAmount = model.TaxableBaseAmount,
            TaxationRate = model.TaxationRate,
            UpdatedAt = model.UpdatedAt,
        };
    }

    public static DetailedDeclarationTaxDbModel ToModel(
        this DetailedDeclarationTaxUpdateInput updateDto,
        DetailedDeclarationTaxWhereUniqueInput uniqueId
    )
    {
        var detailedDeclarationTax = new DetailedDeclarationTaxDbModel
        {
            Id = uniqueId.Id,
            ArticleNumber = updateDto.ArticleNumber,
            BasicTaxAmount = updateDto.BasicTaxAmount,
            BasicTaxableBaseAmount = updateDto.BasicTaxableBaseAmount,
            BasicTaxationRate = updateDto.BasicTaxationRate,
            CautionAmountAfterExemptionOfGuarantee =
                updateDto.CautionAmountAfterExemptionOfGuarantee,
            DateAndTimeOfFinalModification = updateDto.DateAndTimeOfFinalModification,
            DateAndTimeOfFirstRegistration = updateDto.DateAndTimeOfFirstRegistration,
            ExemptAmount = updateDto.ExemptAmount,
            ExemptTaxationRate = updateDto.ExemptTaxationRate,
            ExemptionBaseAmount = updateDto.ExemptionBaseAmount,
            ExemptionTypeCode = updateDto.ExemptionTypeCode,
            FinalModifierSId = updateDto.FinalModifierSId,
            IdDuPremierEnregistrant = updateDto.IdDuPremierEnregistrant,
            PaidTaxAmount = updateDto.PaidTaxAmount,
            PaymentTypeCode = updateDto.PaymentTypeCode,
            RectificationFrequency = updateDto.RectificationFrequency,
            ReferenceNumber = updateDto.ReferenceNumber,
            SuppressionOn = updateDto.SuppressionOn,
            TariffCategoryCode = updateDto.TariffCategoryCode,
            TaxAdvantageCode = updateDto.TaxAdvantageCode,
            TaxAmount = updateDto.TaxAmount,
            TaxCode = updateDto.TaxCode,
            TaxableBaseAmount = updateDto.TaxableBaseAmount,
            TaxationRate = updateDto.TaxationRate
        };

        if (updateDto.CreatedAt != null)
        {
            detailedDeclarationTax.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.UpdatedAt != null)
        {
            detailedDeclarationTax.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return detailedDeclarationTax;
    }
}
