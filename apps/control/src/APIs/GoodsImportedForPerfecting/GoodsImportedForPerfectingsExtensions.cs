using Control.APIs.Dtos;
using Control.Infrastructure.Models;

namespace Control.APIs.Extensions;

public static class GoodsImportedForPerfectingsExtensions
{
    public static GoodsImportedForPerfecting ToDto(this GoodsImportedForPerfectingDbModel model)
    {
        return new GoodsImportedForPerfecting
        {
            AddressOfTheExporterOwnerOfGoodsToTransformRepair =
                model.AddressOfTheExporterOwnerOfGoodsToTransformRepair,
            AnotherUnknownField = model.AnotherUnknownField,
            CommercialDesignationOfGoods = model.CommercialDesignationOfGoods,
            CommercialDesignationOfGoodsToCompensate =
                model.CommercialDesignationOfGoodsToCompensate,
            CompensationOfAtAccounts = model.CompensationOfAtAccounts,
            CreatedAt = model.CreatedAt,
            CurrencyCode = model.CurrencyCode,
            DateAndTimeOfFinalModification = model.DateAndTimeOfFinalModification,
            DateAndTimeOfFirstRegistration = model.DateAndTimeOfFirstRegistration,
            DeletionOn = model.DeletionOn,
            FinalModifierSId = model.FinalModifierSId,
            FirstRecorderSId = model.FirstRecorderSId,
            Id = model.Id,
            LegalStatusOfImportedGoods = model.LegalStatusOfImportedGoods,
            NameAndTradeNameOfTheExporterOwnerOfGoodsToTransformRepair =
                model.NameAndTradeNameOfTheExporterOwnerOfGoodsToTransformRepair,
            Origin = model.Origin,
            Quantity = model.Quantity,
            QuantityOfGoodsToCompensate = model.QuantityOfGoodsToCompensate,
            RectificationFrequency = model.RectificationFrequency,
            RegimeRequestNumber = model.RegimeRequestNumber,
            SequenceNumber = model.SequenceNumber,
            ShorterOrigin = model.ShorterOrigin,
            SptNumber = model.SptNumber,
            TechnicalDesignationOfGoods = model.TechnicalDesignationOfGoods,
            TechnicalDesignationOfGoodsToCompensate = model.TechnicalDesignationOfGoodsToCompensate,
            UnknownField = model.UnknownField,
            UpdatedAt = model.UpdatedAt,
            ValueInCurrency = model.ValueInCurrency,
        };
    }

    public static GoodsImportedForPerfectingDbModel ToModel(
        this GoodsImportedForPerfectingUpdateInput updateDto,
        GoodsImportedForPerfectingWhereUniqueInput uniqueId
    )
    {
        var goodsImportedForPerfecting = new GoodsImportedForPerfectingDbModel
        {
            Id = uniqueId.Id,
            AddressOfTheExporterOwnerOfGoodsToTransformRepair =
                updateDto.AddressOfTheExporterOwnerOfGoodsToTransformRepair,
            AnotherUnknownField = updateDto.AnotherUnknownField,
            CommercialDesignationOfGoods = updateDto.CommercialDesignationOfGoods,
            CommercialDesignationOfGoodsToCompensate =
                updateDto.CommercialDesignationOfGoodsToCompensate,
            CompensationOfAtAccounts = updateDto.CompensationOfAtAccounts,
            CurrencyCode = updateDto.CurrencyCode,
            DateAndTimeOfFinalModification = updateDto.DateAndTimeOfFinalModification,
            DateAndTimeOfFirstRegistration = updateDto.DateAndTimeOfFirstRegistration,
            DeletionOn = updateDto.DeletionOn,
            FinalModifierSId = updateDto.FinalModifierSId,
            FirstRecorderSId = updateDto.FirstRecorderSId,
            LegalStatusOfImportedGoods = updateDto.LegalStatusOfImportedGoods,
            NameAndTradeNameOfTheExporterOwnerOfGoodsToTransformRepair =
                updateDto.NameAndTradeNameOfTheExporterOwnerOfGoodsToTransformRepair,
            Origin = updateDto.Origin,
            Quantity = updateDto.Quantity,
            QuantityOfGoodsToCompensate = updateDto.QuantityOfGoodsToCompensate,
            RectificationFrequency = updateDto.RectificationFrequency,
            RegimeRequestNumber = updateDto.RegimeRequestNumber,
            SequenceNumber = updateDto.SequenceNumber,
            ShorterOrigin = updateDto.ShorterOrigin,
            SptNumber = updateDto.SptNumber,
            TechnicalDesignationOfGoods = updateDto.TechnicalDesignationOfGoods,
            TechnicalDesignationOfGoodsToCompensate =
                updateDto.TechnicalDesignationOfGoodsToCompensate,
            UnknownField = updateDto.UnknownField,
            ValueInCurrency = updateDto.ValueInCurrency
        };

        if (updateDto.CreatedAt != null)
        {
            goodsImportedForPerfecting.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.UpdatedAt != null)
        {
            goodsImportedForPerfecting.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return goodsImportedForPerfecting;
    }
}
