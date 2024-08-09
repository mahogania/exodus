using Clre.APIs.Dtos;
using Clre.Infrastructure.Models;

namespace Clre.APIs.Extensions;

public static class CustomsDetailedDeclarationTaxesExtensions
{
    public static CustomsDetailedDeclarationTax ToDto(
        this CustomsDetailedDeclarationTaxDbModel model
    )
    {
        return new CustomsDetailedDeclarationTax
        {
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

    public static CustomsDetailedDeclarationTaxDbModel ToModel(
        this CustomsDetailedDeclarationTaxUpdateInput updateDto,
        CustomsDetailedDeclarationTaxWhereUniqueInput uniqueId
    )
    {
        var customsDetailedDeclarationTax = new CustomsDetailedDeclarationTaxDbModel
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
            customsDetailedDeclarationTax.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.UpdatedAt != null)
        {
            customsDetailedDeclarationTax.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return customsDetailedDeclarationTax;
    }
}
