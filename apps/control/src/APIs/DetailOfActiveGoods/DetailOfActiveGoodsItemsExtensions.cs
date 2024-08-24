using Control.APIs.Dtos;
using Control.Infrastructure.Models;

namespace Control.APIs.Extensions;

public static class DetailOfActiveGoodsItemsExtensions
{
    public static DetailOfActiveGoods ToDto(this DetailOfActiveGoodsDbModel model)
    {
        return new DetailOfActiveGoods
        {
            BrandName = model.BrandName,
            CodeOfImportExportType = model.CodeOfImportExportType,
            CommonActiveGoodsRequest = model.CommonActiveGoodsRequestId,
            CountryOfOriginCode = model.CountryOfOriginCode,
            CountryOfShipmentCode = model.CountryOfShipmentCode,
            CreatedAt = model.CreatedAt,
            DateAndTimeOfFinalModification = model.DateAndTimeOfFinalModification,
            DateAndTimeOfFirstRegistration = model.DateAndTimeOfFirstRegistration,
            DeletionOn = model.DeletionOn,
            DocumentCode = model.DocumentCode,
            FinalModifierSId = model.FinalModifierSId,
            FirstRecorderSId = model.FirstRecorderSId,
            GoodsValue = model.GoodsValue,
            Id = model.Id,
            RectificationFrequency = model.RectificationFrequency,
            RegimeRequestNumber = model.RegimeRequestNumber,
            SequenceNumber = model.SequenceNumber,
            ShCode = model.ShCode,
            StorageLocation = model.StorageLocation,
            StorageLocationUnitCode = model.StorageLocationUnitCode,
            TransactionValueCurrencyCode = model.TransactionValueCurrencyCode,
            UpdatedAt = model.UpdatedAt,
        };
    }

    public static DetailOfActiveGoodsDbModel ToModel(
        this DetailOfActiveGoodsUpdateInput updateDto,
        DetailOfActiveGoodsWhereUniqueInput uniqueId
    )
    {
        var detailOfActiveGoods = new DetailOfActiveGoodsDbModel
        {
            Id = uniqueId.Id,
            BrandName = updateDto.BrandName,
            CodeOfImportExportType = updateDto.CodeOfImportExportType,
            CountryOfOriginCode = updateDto.CountryOfOriginCode,
            CountryOfShipmentCode = updateDto.CountryOfShipmentCode,
            DateAndTimeOfFinalModification = updateDto.DateAndTimeOfFinalModification,
            DateAndTimeOfFirstRegistration = updateDto.DateAndTimeOfFirstRegistration,
            DeletionOn = updateDto.DeletionOn,
            DocumentCode = updateDto.DocumentCode,
            FinalModifierSId = updateDto.FinalModifierSId,
            FirstRecorderSId = updateDto.FirstRecorderSId,
            GoodsValue = updateDto.GoodsValue,
            RectificationFrequency = updateDto.RectificationFrequency,
            RegimeRequestNumber = updateDto.RegimeRequestNumber,
            SequenceNumber = updateDto.SequenceNumber,
            ShCode = updateDto.ShCode,
            StorageLocation = updateDto.StorageLocation,
            StorageLocationUnitCode = updateDto.StorageLocationUnitCode,
            TransactionValueCurrencyCode = updateDto.TransactionValueCurrencyCode
        };

        if (updateDto.CommonActiveGoodsRequest != null)
        {
            detailOfActiveGoods.CommonActiveGoodsRequestId = updateDto.CommonActiveGoodsRequest;
        }
        if (updateDto.CreatedAt != null)
        {
            detailOfActiveGoods.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.UpdatedAt != null)
        {
            detailOfActiveGoods.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return detailOfActiveGoods;
    }
}
