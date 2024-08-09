using Clre.APIs.Dtos;
using Clre.Infrastructure.Models;

namespace Clre.APIs.Extensions;

public static class DetailsOfTheCustomsClearanceOfPostalGoodsItemsExtensions
{
    public static DetailsOfTheCustomsClearanceOfPostalGoods ToDto(
        this DetailsOfTheCustomsClearanceOfPostalGoodsDbModel model
    )
    {
        return new DetailsOfTheCustomsClearanceOfPostalGoods
        {
            AmountNcyOfTheInvoiceOfTheArticle = model.AmountNcyOfTheInvoiceOfTheArticle,
            AmountOfTheInvoiceOfTheArticle = model.AmountOfTheInvoiceOfTheArticle,
            ArticleName = model.ArticleName,
            ArticleNumber = model.ArticleNumber,
            CountryCodeOfOrigin = model.CountryCodeOfOrigin,
            CreatedAt = model.CreatedAt,
            CurrencyCodeOfTheInvoiceOfTheArticle = model.CurrencyCodeOfTheInvoiceOfTheArticle,
            DateAndTimeOfFinalModification = model.DateAndTimeOfFinalModification,
            DateAndTimeOfFirstRegistration = model.DateAndTimeOfFirstRegistration,
            DeclaredInsuranceAmount = model.DeclaredInsuranceAmount,
            ExchangeRateOfTheInvoiceOfTheArticle = model.ExchangeRateOfTheInvoiceOfTheArticle,
            FinalModifierSId = model.FinalModifierSId,
            FirstRegistrantSId = model.FirstRegistrantSId,
            Id = model.Id,
            LiquidatedShCode = model.LiquidatedShCode,
            NetWeightOfTheArticle = model.NetWeightOfTheArticle,
            Quantity = model.Quantity,
            RequestNumberOfTheCustomsClearanceOfPostalParcels =
                model.RequestNumberOfTheCustomsClearanceOfPostalParcels,
            RevisedDescriptionOfTheArticle = model.RevisedDescriptionOfTheArticle,
            SequenceNumber = model.SequenceNumber,
            ShCode = model.ShCode,
            SuppressionOn = model.SuppressionOn,
            TotalWeightKg = model.TotalWeightKg,
            UpdatedAt = model.UpdatedAt,
        };
    }

    public static DetailsOfTheCustomsClearanceOfPostalGoodsDbModel ToModel(
        this DetailsOfTheCustomsClearanceOfPostalGoodsUpdateInput updateDto,
        DetailsOfTheCustomsClearanceOfPostalGoodsWhereUniqueInput uniqueId
    )
    {
        var detailsOfTheCustomsClearanceOfPostalGoods =
            new DetailsOfTheCustomsClearanceOfPostalGoodsDbModel
            {
                Id = uniqueId.Id,
                AmountNcyOfTheInvoiceOfTheArticle = updateDto.AmountNcyOfTheInvoiceOfTheArticle,
                AmountOfTheInvoiceOfTheArticle = updateDto.AmountOfTheInvoiceOfTheArticle,
                ArticleName = updateDto.ArticleName,
                ArticleNumber = updateDto.ArticleNumber,
                CountryCodeOfOrigin = updateDto.CountryCodeOfOrigin,
                CurrencyCodeOfTheInvoiceOfTheArticle =
                    updateDto.CurrencyCodeOfTheInvoiceOfTheArticle,
                DateAndTimeOfFinalModification = updateDto.DateAndTimeOfFinalModification,
                DateAndTimeOfFirstRegistration = updateDto.DateAndTimeOfFirstRegistration,
                DeclaredInsuranceAmount = updateDto.DeclaredInsuranceAmount,
                ExchangeRateOfTheInvoiceOfTheArticle =
                    updateDto.ExchangeRateOfTheInvoiceOfTheArticle,
                FinalModifierSId = updateDto.FinalModifierSId,
                FirstRegistrantSId = updateDto.FirstRegistrantSId,
                LiquidatedShCode = updateDto.LiquidatedShCode,
                NetWeightOfTheArticle = updateDto.NetWeightOfTheArticle,
                Quantity = updateDto.Quantity,
                RequestNumberOfTheCustomsClearanceOfPostalParcels =
                    updateDto.RequestNumberOfTheCustomsClearanceOfPostalParcels,
                RevisedDescriptionOfTheArticle = updateDto.RevisedDescriptionOfTheArticle,
                SequenceNumber = updateDto.SequenceNumber,
                ShCode = updateDto.ShCode,
                SuppressionOn = updateDto.SuppressionOn,
                TotalWeightKg = updateDto.TotalWeightKg
            };

        if (updateDto.CreatedAt != null)
        {
            detailsOfTheCustomsClearanceOfPostalGoods.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.UpdatedAt != null)
        {
            detailsOfTheCustomsClearanceOfPostalGoods.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return detailsOfTheCustomsClearanceOfPostalGoods;
    }
}
