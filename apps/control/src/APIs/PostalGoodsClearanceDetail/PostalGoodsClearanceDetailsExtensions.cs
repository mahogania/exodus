using Control.APIs.Dtos;
using Control.Infrastructure.Models;

namespace Control.APIs.Extensions;

public static class PostalGoodsClearanceDetailsExtensions
{
    public static PostalGoodsClearanceDetail ToDto(this PostalGoodsClearanceDetailDbModel model)
    {
        return new PostalGoodsClearanceDetail
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
            PostalGoodsClearance = model.PostalGoodsClearanceId,
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

    public static PostalGoodsClearanceDetailDbModel ToModel(
        this PostalGoodsClearanceDetailUpdateInput updateDto,
        PostalGoodsClearanceDetailWhereUniqueInput uniqueId
    )
    {
        var postalGoodsClearanceDetail = new PostalGoodsClearanceDetailDbModel
        {
            Id = uniqueId.Id,
            AmountNcyOfTheInvoiceOfTheArticle = updateDto.AmountNcyOfTheInvoiceOfTheArticle,
            AmountOfTheInvoiceOfTheArticle = updateDto.AmountOfTheInvoiceOfTheArticle,
            ArticleName = updateDto.ArticleName,
            ArticleNumber = updateDto.ArticleNumber,
            CountryCodeOfOrigin = updateDto.CountryCodeOfOrigin,
            CurrencyCodeOfTheInvoiceOfTheArticle = updateDto.CurrencyCodeOfTheInvoiceOfTheArticle,
            DateAndTimeOfFinalModification = updateDto.DateAndTimeOfFinalModification,
            DateAndTimeOfFirstRegistration = updateDto.DateAndTimeOfFirstRegistration,
            DeclaredInsuranceAmount = updateDto.DeclaredInsuranceAmount,
            ExchangeRateOfTheInvoiceOfTheArticle = updateDto.ExchangeRateOfTheInvoiceOfTheArticle,
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
            postalGoodsClearanceDetail.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.PostalGoodsClearance != null)
        {
            postalGoodsClearanceDetail.PostalGoodsClearanceId = updateDto.PostalGoodsClearance;
        }
        if (updateDto.UpdatedAt != null)
        {
            postalGoodsClearanceDetail.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return postalGoodsClearanceDetail;
    }
}
