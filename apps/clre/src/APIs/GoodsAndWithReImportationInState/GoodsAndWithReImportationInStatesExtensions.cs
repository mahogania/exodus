using Clre.APIs.Dtos;
using Clre.Infrastructure.Models;

namespace Clre.APIs.Extensions;

public static class GoodsAndWithReImportationInStatesExtensions
{
    public static GoodsAndWithReImportationInState ToDto(
        this GoodsAndWithReImportationInStateDbModel model
    )
    {
        return new GoodsAndWithReImportationInState
        {
            CommercialDesignationOfGoods = model.CommercialDesignationOfGoods,
            CreatedAt = model.CreatedAt,
            CurrencyCode = model.CurrencyCode,
            DateAndTimeOfFinalModification = model.DateAndTimeOfFinalModification,
            DateAndTimeOfFirstRegistration = model.DateAndTimeOfFirstRegistration,
            FinalModifierSId = model.FinalModifierSId,
            FirstRegistrantSId = model.FirstRegistrantSId,
            Id = model.Id,
            Identification = model.Identification,
            Origin = model.Origin,
            Quantity = model.Quantity,
            RectificationFrequency = model.RectificationFrequency,
            RegimeRequestNumber = model.RegimeRequestNumber,
            SequenceNumber = model.SequenceNumber,
            SptNumber = model.SptNumber,
            StateOfTheGoodsAtTheTimeOfExportation = model.StateOfTheGoodsAtTheTimeOfExportation,
            SuppressionOn = model.SuppressionOn,
            TechnicalDesignationOfGoods = model.TechnicalDesignationOfGoods,
            UpdatedAt = model.UpdatedAt,
            Value = model.Value,
        };
    }

    public static GoodsAndWithReImportationInStateDbModel ToModel(
        this GoodsAndWithReImportationInStateUpdateInput updateDto,
        GoodsAndWithReImportationInStateWhereUniqueInput uniqueId
    )
    {
        var goodsAndWithReImportationInState = new GoodsAndWithReImportationInStateDbModel
        {
            Id = uniqueId.Id,
            CommercialDesignationOfGoods = updateDto.CommercialDesignationOfGoods,
            CurrencyCode = updateDto.CurrencyCode,
            DateAndTimeOfFinalModification = updateDto.DateAndTimeOfFinalModification,
            DateAndTimeOfFirstRegistration = updateDto.DateAndTimeOfFirstRegistration,
            FinalModifierSId = updateDto.FinalModifierSId,
            FirstRegistrantSId = updateDto.FirstRegistrantSId,
            Identification = updateDto.Identification,
            Origin = updateDto.Origin,
            Quantity = updateDto.Quantity,
            RectificationFrequency = updateDto.RectificationFrequency,
            RegimeRequestNumber = updateDto.RegimeRequestNumber,
            SequenceNumber = updateDto.SequenceNumber,
            SptNumber = updateDto.SptNumber,
            StateOfTheGoodsAtTheTimeOfExportation = updateDto.StateOfTheGoodsAtTheTimeOfExportation,
            SuppressionOn = updateDto.SuppressionOn,
            TechnicalDesignationOfGoods = updateDto.TechnicalDesignationOfGoods,
            Value = updateDto.Value
        };

        if (updateDto.CreatedAt != null)
        {
            goodsAndWithReImportationInState.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.UpdatedAt != null)
        {
            goodsAndWithReImportationInState.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return goodsAndWithReImportationInState;
    }
}
