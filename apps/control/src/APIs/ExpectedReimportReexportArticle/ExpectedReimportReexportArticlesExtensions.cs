using Control.APIs.Dtos;
using Control.Infrastructure.Models;

namespace Control.APIs.Extensions;

public static class ExpectedReimportReexportArticlesExtensions
{
    public static ExpectedReimportReexportArticle ToDto(
        this ExpectedReimportReexportArticleDbModel model
    )
    {
        return new ExpectedReimportReexportArticle
        {
            ArticleGrossWeight = model.ArticleGrossWeight,
            ArticleName = model.ArticleName,
            ArticleNetWeight = model.ArticleNetWeight,
            CommonDetailedDeclarations = model.CommonDetailedDeclarationsId,
            CreatedAt = model.CreatedAt,
            DateAndTimeOfFinalModification = model.DateAndTimeOfFinalModification,
            DateAndTimeOfFirstRegistration = model.DateAndTimeOfFirstRegistration,
            ExpectedArticleNumber = model.ExpectedArticleNumber,
            FinalModifierSId = model.FinalModifierSId,
            Id = model.Id,
            IdDuPremierEnregistrant = model.IdDuPremierEnregistrant,
            Key = model.Key,
            OriginCountryCode = model.OriginCountryCode,
            Quantity = model.Quantity,
            QuantityUnitCode = model.QuantityUnitCode,
            RectificationFrequency = model.RectificationFrequency,
            ReferenceNumber = model.ReferenceNumber,
            ShCode = model.ShCode,
            SpecificGoodsClassificationCode = model.SpecificGoodsClassificationCode,
            SuppressionOn = model.SuppressionOn,
            TransactionArticleName = model.TransactionArticleName,
            UpdatedAt = model.UpdatedAt,
        };
    }

    public static ExpectedReimportReexportArticleDbModel ToModel(
        this ExpectedReimportReexportArticleUpdateInput updateDto,
        ExpectedReimportReexportArticleWhereUniqueInput uniqueId
    )
    {
        var expectedReimportReexportArticle = new ExpectedReimportReexportArticleDbModel
        {
            Id = uniqueId.Id,
            ArticleGrossWeight = updateDto.ArticleGrossWeight,
            ArticleName = updateDto.ArticleName,
            ArticleNetWeight = updateDto.ArticleNetWeight,
            DateAndTimeOfFinalModification = updateDto.DateAndTimeOfFinalModification,
            DateAndTimeOfFirstRegistration = updateDto.DateAndTimeOfFirstRegistration,
            ExpectedArticleNumber = updateDto.ExpectedArticleNumber,
            FinalModifierSId = updateDto.FinalModifierSId,
            IdDuPremierEnregistrant = updateDto.IdDuPremierEnregistrant,
            Key = updateDto.Key,
            OriginCountryCode = updateDto.OriginCountryCode,
            Quantity = updateDto.Quantity,
            QuantityUnitCode = updateDto.QuantityUnitCode,
            RectificationFrequency = updateDto.RectificationFrequency,
            ReferenceNumber = updateDto.ReferenceNumber,
            ShCode = updateDto.ShCode,
            SpecificGoodsClassificationCode = updateDto.SpecificGoodsClassificationCode,
            SuppressionOn = updateDto.SuppressionOn,
            TransactionArticleName = updateDto.TransactionArticleName
        };

        if (updateDto.CommonDetailedDeclarations != null)
        {
            expectedReimportReexportArticle.CommonDetailedDeclarationsId =
                updateDto.CommonDetailedDeclarations;
        }
        if (updateDto.CreatedAt != null)
        {
            expectedReimportReexportArticle.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.UpdatedAt != null)
        {
            expectedReimportReexportArticle.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return expectedReimportReexportArticle;
    }
}
