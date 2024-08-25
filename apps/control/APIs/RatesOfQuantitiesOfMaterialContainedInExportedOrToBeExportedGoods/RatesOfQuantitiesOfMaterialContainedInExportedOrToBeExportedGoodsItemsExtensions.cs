using Control.APIs.Dtos;
using Control.Infrastructure.Models;

namespace Control.APIs.Extensions;

public static class RatesOfQuantitiesOfMaterialContainedInExportedOrToBeExportedGoodsItemsExtensions
{
    public static RatesOfQuantitiesOfMaterialContainedInExportedOrToBeExportedGoods ToDto(
        this RatesOfQuantitiesOfMaterialContainedInExportedOrToBeExportedGoodsDbModel model
    )
    {
        return new RatesOfQuantitiesOfMaterialContainedInExportedOrToBeExportedGoods
        {
            CreatedAt = model.CreatedAt,
            DateAndTimeOfFinalModification = model.DateAndTimeOfFinalModification,
            DateAndTimeOfFirstRegistration = model.DateAndTimeOfFirstRegistration,
            FinalModifierSId = model.FinalModifierSId,
            FirstRegistrantSId = model.FirstRegistrantSId,
            Id = model.Id,
            RatesOfQuantitiesOfForeignOriginMaterialsAcquiredOnTheNationalMarket =
                model.RatesOfQuantitiesOfForeignOriginMaterialsAcquiredOnTheNationalMarket,
            RatesOfQuantitiesOfImportedMaterials = model.RatesOfQuantitiesOfImportedMaterials,
            RatesOfQuantitiesOfImportedPackaging = model.RatesOfQuantitiesOfImportedPackaging,
            RatesOfQuantitiesOfNationalOriginMaterials =
                model.RatesOfQuantitiesOfNationalOriginMaterials,
            RectificationFrequency = model.RectificationFrequency,
            RegimeRequestNumber = model.RegimeRequestNumber,
            SequenceNumber = model.SequenceNumber,
            SuppressionOn = model.SuppressionOn,
            UpdatedAt = model.UpdatedAt
        };
    }

    public static RatesOfQuantitiesOfMaterialContainedInExportedOrToBeExportedGoodsDbModel ToModel(
        this RatesOfQuantitiesOfMaterialContainedInExportedOrToBeExportedGoodsUpdateInput updateDto,
        RatesOfQuantitiesOfMaterialContainedInExportedOrToBeExportedGoodsWhereUniqueInput uniqueId
    )
    {
        var ratesOfQuantitiesOfMaterialContainedInExportedOrToBeExportedGoods =
            new RatesOfQuantitiesOfMaterialContainedInExportedOrToBeExportedGoodsDbModel
            {
                Id = uniqueId.Id,
                DateAndTimeOfFinalModification = updateDto.DateAndTimeOfFinalModification,
                DateAndTimeOfFirstRegistration = updateDto.DateAndTimeOfFirstRegistration,
                FinalModifierSId = updateDto.FinalModifierSId,
                FirstRegistrantSId = updateDto.FirstRegistrantSId,
                RatesOfQuantitiesOfForeignOriginMaterialsAcquiredOnTheNationalMarket =
                    updateDto.RatesOfQuantitiesOfForeignOriginMaterialsAcquiredOnTheNationalMarket,
                RatesOfQuantitiesOfImportedMaterials =
                    updateDto.RatesOfQuantitiesOfImportedMaterials,
                RatesOfQuantitiesOfImportedPackaging =
                    updateDto.RatesOfQuantitiesOfImportedPackaging,
                RatesOfQuantitiesOfNationalOriginMaterials =
                    updateDto.RatesOfQuantitiesOfNationalOriginMaterials,
                RectificationFrequency = updateDto.RectificationFrequency,
                RegimeRequestNumber = updateDto.RegimeRequestNumber,
                SequenceNumber = updateDto.SequenceNumber,
                SuppressionOn = updateDto.SuppressionOn
            };

        if (updateDto.CreatedAt != null)
            ratesOfQuantitiesOfMaterialContainedInExportedOrToBeExportedGoods.CreatedAt = updateDto
                .CreatedAt
                .Value;
        if (updateDto.UpdatedAt != null)
            ratesOfQuantitiesOfMaterialContainedInExportedOrToBeExportedGoods.UpdatedAt = updateDto
                .UpdatedAt
                .Value;

        return ratesOfQuantitiesOfMaterialContainedInExportedOrToBeExportedGoods;
    }
}
