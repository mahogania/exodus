using Control.APIs.Dtos;
using Control.Infrastructure.Models;

namespace Control.APIs.Extensions;

public static class RawMaterialsExtensions
{
    public static RawMaterial ToDto(this RawMaterialDbModel model)
    {
        return new RawMaterial
        {
            Article = model.ArticleId,
            ArticleNumber = model.ArticleNumber,
            CreatedAt = model.CreatedAt,
            DateAndTimeOfFinalModification = model.DateAndTimeOfFinalModification,
            DateAndTimeOfFirstRegistration = model.DateAndTimeOfFirstRegistration,
            FinalModifierSId = model.FinalModifierSId,
            FirstRegistrantSId = model.FirstRegistrantSId,
            Id = model.Id,
            MaterialRawSequenceNumber = model.MaterialRawSequenceNumber,
            NetWeight = model.NetWeight,
            PartialClearanceTypeCode = model.PartialClearanceTypeCode,
            PreviousArticleNumber = model.PreviousArticleNumber,
            PreviousDetailedDeclarationNumber = model.PreviousDetailedDeclarationNumber,
            PreviousShCode = model.PreviousShCode,
            PreviousSpecificCodeOfTheMerchandiseClassification =
                model.PreviousSpecificCodeOfTheMerchandiseClassification,
            Quantity = model.Quantity,
            QuantityUnitCode = model.QuantityUnitCode,
            RectificationFrequency = model.RectificationFrequency,
            ReferenceNumber = model.ReferenceNumber,
            SuppressionOn = model.SuppressionOn,
            UpdatedAt = model.UpdatedAt,
        };
    }

    public static RawMaterialDbModel ToModel(
        this RawMaterialUpdateInput updateDto,
        RawMaterialWhereUniqueInput uniqueId
    )
    {
        var rawMaterial = new RawMaterialDbModel
        {
            Id = uniqueId.Id,
            ArticleNumber = updateDto.ArticleNumber,
            DateAndTimeOfFinalModification = updateDto.DateAndTimeOfFinalModification,
            DateAndTimeOfFirstRegistration = updateDto.DateAndTimeOfFirstRegistration,
            FinalModifierSId = updateDto.FinalModifierSId,
            FirstRegistrantSId = updateDto.FirstRegistrantSId,
            MaterialRawSequenceNumber = updateDto.MaterialRawSequenceNumber,
            NetWeight = updateDto.NetWeight,
            PartialClearanceTypeCode = updateDto.PartialClearanceTypeCode,
            PreviousArticleNumber = updateDto.PreviousArticleNumber,
            PreviousDetailedDeclarationNumber = updateDto.PreviousDetailedDeclarationNumber,
            PreviousShCode = updateDto.PreviousShCode,
            PreviousSpecificCodeOfTheMerchandiseClassification =
                updateDto.PreviousSpecificCodeOfTheMerchandiseClassification,
            Quantity = updateDto.Quantity,
            QuantityUnitCode = updateDto.QuantityUnitCode,
            RectificationFrequency = updateDto.RectificationFrequency,
            ReferenceNumber = updateDto.ReferenceNumber,
            SuppressionOn = updateDto.SuppressionOn
        };

        if (updateDto.Article != null)
        {
            rawMaterial.ArticleId = updateDto.Article;
        }
        if (updateDto.CreatedAt != null)
        {
            rawMaterial.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.UpdatedAt != null)
        {
            rawMaterial.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return rawMaterial;
    }
}
