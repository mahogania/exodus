using Clre.APIs.Dtos;
using Clre.Infrastructure.Models;

namespace Clre.APIs.Extensions;

public static class RawMaterialOfTheDetailedDeclarationCustomsItemsExtensions
{
    public static RawMaterialOfTheDetailedDeclarationCustoms ToDto(
        this RawMaterialOfTheDetailedDeclarationCustomsDbModel model
    )
    {
        return new RawMaterialOfTheDetailedDeclarationCustoms
        {
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

    public static RawMaterialOfTheDetailedDeclarationCustomsDbModel ToModel(
        this RawMaterialOfTheDetailedDeclarationCustomsUpdateInput updateDto,
        RawMaterialOfTheDetailedDeclarationCustomsWhereUniqueInput uniqueId
    )
    {
        var rawMaterialOfTheDetailedDeclarationCustoms =
            new RawMaterialOfTheDetailedDeclarationCustomsDbModel
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

        if (updateDto.CreatedAt != null)
        {
            rawMaterialOfTheDetailedDeclarationCustoms.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.UpdatedAt != null)
        {
            rawMaterialOfTheDetailedDeclarationCustoms.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return rawMaterialOfTheDetailedDeclarationCustoms;
    }
}
