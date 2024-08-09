using Clre.APIs.Dtos;
using Clre.Infrastructure.Models;

namespace Clre.APIs.Extensions;

public static class DetailsOfAtGoodsForActivePerfectingsExtensions
{
    public static DetailsOfAtGoodsForActivePerfecting ToDto(
        this DetailsOfAtGoodsForActivePerfectingDbModel model
    )
    {
        return new DetailsOfAtGoodsForActivePerfecting
        {
            BrandName = model.BrandName,
            CodeOfImportExportType = model.CodeOfImportExportType,
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

    public static DetailsOfAtGoodsForActivePerfectingDbModel ToModel(
        this DetailsOfAtGoodsForActivePerfectingUpdateInput updateDto,
        DetailsOfAtGoodsForActivePerfectingWhereUniqueInput uniqueId
    )
    {
        var detailsOfAtGoodsForActivePerfecting = new DetailsOfAtGoodsForActivePerfectingDbModel
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

        if (updateDto.CreatedAt != null)
        {
            detailsOfAtGoodsForActivePerfecting.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.UpdatedAt != null)
        {
            detailsOfAtGoodsForActivePerfecting.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return detailsOfAtGoodsForActivePerfecting;
    }
}
