using Control.APIs.Dtos;
using Control.Infrastructure.Models;

namespace Control.APIs.Extensions;

public static class RequestForTirCarnetOfTheArticlesExtensions
{
    public static RequestForTirCarnetOfTheArticle ToDto(
        this RequestForTirCarnetOfTheArticleDbModel model
    )
    {
        return new RequestForTirCarnetOfTheArticle
        {
            ArticleSequenceNumber = model.ArticleSequenceNumber,
            CreatedAt = model.CreatedAt,
            DateAndTimeOfFinalModification = model.DateAndTimeOfFinalModification,
            DateAndTimeOfFirstRegistration = model.DateAndTimeOfFirstRegistration,
            DescCtn = model.DescCtn,
            FinalModifierSId = model.FinalModifierSId,
            FirstRegistrantSId = model.FirstRegistrantSId,
            Id = model.Id,
            PackageDescription = model.PackageDescription,
            Packaging = model.Packaging,
            SuppressionOn = model.SuppressionOn,
            TirRegistrationNumber = model.TirRegistrationNumber,
            UpdatedAt = model.UpdatedAt,
            Weight = model.Weight,
        };
    }

    public static RequestForTirCarnetOfTheArticleDbModel ToModel(
        this RequestForTirCarnetOfTheArticleUpdateInput updateDto,
        RequestForTirCarnetOfTheArticleWhereUniqueInput uniqueId
    )
    {
        var requestForTirCarnetOfTheArticle = new RequestForTirCarnetOfTheArticleDbModel
        {
            Id = uniqueId.Id,
            ArticleSequenceNumber = updateDto.ArticleSequenceNumber,
            DateAndTimeOfFinalModification = updateDto.DateAndTimeOfFinalModification,
            DateAndTimeOfFirstRegistration = updateDto.DateAndTimeOfFirstRegistration,
            DescCtn = updateDto.DescCtn,
            FinalModifierSId = updateDto.FinalModifierSId,
            FirstRegistrantSId = updateDto.FirstRegistrantSId,
            PackageDescription = updateDto.PackageDescription,
            Packaging = updateDto.Packaging,
            SuppressionOn = updateDto.SuppressionOn,
            TirRegistrationNumber = updateDto.TirRegistrationNumber,
            Weight = updateDto.Weight
        };

        if (updateDto.CreatedAt != null)
        {
            requestForTirCarnetOfTheArticle.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.UpdatedAt != null)
        {
            requestForTirCarnetOfTheArticle.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return requestForTirCarnetOfTheArticle;
    }
}
