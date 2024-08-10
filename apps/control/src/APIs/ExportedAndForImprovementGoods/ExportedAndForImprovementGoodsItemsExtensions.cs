using Control.APIs.Dtos;
using Control.Infrastructure.Models;

namespace Control.APIs.Extensions;

public static class ExportedAndForImprovementGoodsItemsExtensions
{
    public static ExportedAndForImprovementGoods ToDto(
        this ExportedAndForImprovementGoodsDbModel model
    )
    {
        return new ExportedAndForImprovementGoods
        {
            CommercialDesignationOfTheGoods = model.CommercialDesignationOfTheGoods,
            CreatedAt = model.CreatedAt,
            CurrencyCode = model.CurrencyCode,
            DateAndTimeOfFinalModification = model.DateAndTimeOfFinalModification,
            DateAndTimeOfFirstRegistration = model.DateAndTimeOfFirstRegistration,
            FinalModifierSId = model.FinalModifierSId,
            FirstRegistrantSId = model.FirstRegistrantSId,
            Id = model.Id,
            Origin = model.Origin,
            Quantity = model.Quantity,
            RectificationFrequency = model.RectificationFrequency,
            RegimeRequestNumber = model.RegimeRequestNumber,
            SequenceNumber = model.SequenceNumber,
            SptNumber = model.SptNumber,
            SuppressionOn = model.SuppressionOn,
            TechnicalDesignationOfTheGoods = model.TechnicalDesignationOfTheGoods,
            UpdatedAt = model.UpdatedAt,
            Value = model.Value
        };
    }

    public static ExportedAndForImprovementGoodsDbModel ToModel(
        this ExportedAndForImprovementGoodsUpdateInput updateDto,
        ExportedAndForImprovementGoodsWhereUniqueInput uniqueId
    )
    {
        var exportedAndForImprovementGoods = new ExportedAndForImprovementGoodsDbModel
        {
            Id = uniqueId.Id,
            CommercialDesignationOfTheGoods = updateDto.CommercialDesignationOfTheGoods,
            CurrencyCode = updateDto.CurrencyCode,
            DateAndTimeOfFinalModification = updateDto.DateAndTimeOfFinalModification,
            DateAndTimeOfFirstRegistration = updateDto.DateAndTimeOfFirstRegistration,
            FinalModifierSId = updateDto.FinalModifierSId,
            FirstRegistrantSId = updateDto.FirstRegistrantSId,
            Origin = updateDto.Origin,
            Quantity = updateDto.Quantity,
            RectificationFrequency = updateDto.RectificationFrequency,
            RegimeRequestNumber = updateDto.RegimeRequestNumber,
            SequenceNumber = updateDto.SequenceNumber,
            SptNumber = updateDto.SptNumber,
            SuppressionOn = updateDto.SuppressionOn,
            TechnicalDesignationOfTheGoods = updateDto.TechnicalDesignationOfTheGoods,
            Value = updateDto.Value
        };

        if (updateDto.CreatedAt != null) exportedAndForImprovementGoods.CreatedAt = updateDto.CreatedAt.Value;
        if (updateDto.UpdatedAt != null) exportedAndForImprovementGoods.UpdatedAt = updateDto.UpdatedAt.Value;

        return exportedAndForImprovementGoods;
    }
}
