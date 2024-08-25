using Control.APIs.Dtos;
using Control.Infrastructure.Models;

namespace Control.APIs.Extensions;

public static class ReimportedGoodsForPerfectingsExtensions
{
    public static ReimportedGoodsForPerfecting ToDto(this ReimportedGoodsForPerfectingDbModel model)
    {
        return new ReimportedGoodsForPerfecting
        {
            CommercialDesignationOfGoods = model.CommercialDesignationOfGoods,
            CountryOfImportation = model.CountryOfImportation,
            CreatedAt = model.CreatedAt,
            CurrencyCode = model.CurrencyCode,
            DateAndTimeOfFinalModification = model.DateAndTimeOfFinalModification,
            DateAndTimeOfFirstRegistration = model.DateAndTimeOfFirstRegistration,
            DeletionOn = model.DeletionOn,
            FinalModifierSId = model.FinalModifierSId,
            FirstRecorderSId = model.FirstRecorderSId,
            FobValue = model.FobValue,
            Id = model.Id,
            NatureOfGoodsRemainingOutsideTheCustomsTerritory =
                model.NatureOfGoodsRemainingOutsideTheCustomsTerritory,
            Origin = model.Origin,
            Quantity = model.Quantity,
            QuantityOfEachGoodRemainingOutsideTheCustomsTerritory =
                model.QuantityOfEachGoodRemainingOutsideTheCustomsTerritory,
            RectificationFrequency = model.RectificationFrequency,
            RegimeRequestNumber = model.RegimeRequestNumber,
            SequenceNumber = model.SequenceNumber,
            SptNumber = model.SptNumber,
            TechnicalDesignationOfGoods = model.TechnicalDesignationOfGoods,
            UpdatedAt = model.UpdatedAt
        };
    }

    public static ReimportedGoodsForPerfectingDbModel ToModel(
        this ReimportedGoodsForPerfectingUpdateInput updateDto,
        ReimportedGoodsForPerfectingWhereUniqueInput uniqueId
    )
    {
        var reimportedGoodsForPerfecting = new ReimportedGoodsForPerfectingDbModel
        {
            Id = uniqueId.Id,
            CommercialDesignationOfGoods = updateDto.CommercialDesignationOfGoods,
            CountryOfImportation = updateDto.CountryOfImportation,
            CurrencyCode = updateDto.CurrencyCode,
            DateAndTimeOfFinalModification = updateDto.DateAndTimeOfFinalModification,
            DateAndTimeOfFirstRegistration = updateDto.DateAndTimeOfFirstRegistration,
            DeletionOn = updateDto.DeletionOn,
            FinalModifierSId = updateDto.FinalModifierSId,
            FirstRecorderSId = updateDto.FirstRecorderSId,
            FobValue = updateDto.FobValue,
            NatureOfGoodsRemainingOutsideTheCustomsTerritory =
                updateDto.NatureOfGoodsRemainingOutsideTheCustomsTerritory,
            Origin = updateDto.Origin,
            Quantity = updateDto.Quantity,
            QuantityOfEachGoodRemainingOutsideTheCustomsTerritory =
                updateDto.QuantityOfEachGoodRemainingOutsideTheCustomsTerritory,
            RectificationFrequency = updateDto.RectificationFrequency,
            RegimeRequestNumber = updateDto.RegimeRequestNumber,
            SequenceNumber = updateDto.SequenceNumber,
            SptNumber = updateDto.SptNumber,
            TechnicalDesignationOfGoods = updateDto.TechnicalDesignationOfGoods
        };

        if (updateDto.CreatedAt != null) reimportedGoodsForPerfecting.CreatedAt = updateDto.CreatedAt.Value;
        if (updateDto.UpdatedAt != null) reimportedGoodsForPerfecting.UpdatedAt = updateDto.UpdatedAt.Value;

        return reimportedGoodsForPerfecting;
    }
}
