using Collection.APIs.Dtos;
using Collection.Infrastructure.Models;

namespace Collection.APIs.Extensions;

public static class ArticlesExtensions
{
    public static Article ToDto(this ArticleDbModel model)
    {
        return new Article
        {
            ArticleSequenceNo = model.ArticleSequenceNo,
            CreatedAt = model.CreatedAt,
            DeletionOn = model.DeletionOn,
            DestructionMinutesNumber = model.DestructionMinutesNumber,
            FinalModificationDateAndTime = model.FinalModificationDateAndTime,
            FinalModifierId = model.FinalModifierId,
            FirstRegistrantId = model.FirstRegistrantId,
            FirstRegistrationDateAndTime = model.FirstRegistrationDateAndTime,
            Id = model.Id,
            UpdatedAt = model.UpdatedAt
        };
    }

    public static ArticleDbModel ToModel(
        this ArticleUpdateInput updateDto,
        ArticleWhereUniqueInput uniqueId
    )
    {
        var article = new ArticleDbModel
        {
            Id = uniqueId.Id,
            ArticleSequenceNo = updateDto.ArticleSequenceNo,
            DeletionOn = updateDto.DeletionOn,
            DestructionMinutesNumber = updateDto.DestructionMinutesNumber,
            FinalModificationDateAndTime = updateDto.FinalModificationDateAndTime,
            FinalModifierId = updateDto.FinalModifierId,
            FirstRegistrantId = updateDto.FirstRegistrantId,
            FirstRegistrationDateAndTime = updateDto.FirstRegistrationDateAndTime
        };

        if (updateDto.CreatedAt != null) article.CreatedAt = updateDto.CreatedAt.Value;
        if (updateDto.UpdatedAt != null) article.UpdatedAt = updateDto.UpdatedAt.Value;

        return article;
    }
}
