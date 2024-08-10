using Control.APIs.Dtos;
using Control.Infrastructure.Models;

namespace Control.APIs.Extensions;

public static class DetailsOfGoodsForPassivePerfectionsExtensions
{
    public static DetailsOfGoodsForPassivePerfection ToDto(
        this DetailsOfGoodsForPassivePerfectionDbModel model
    )
    {
        return new DetailsOfGoodsForPassivePerfection
        {
            BrandName = model.BrandName,
            CreatedAt = model.CreatedAt,
            DateAndTimeOfFinalModification = model.DateAndTimeOfFinalModification,
            DateAndTimeOfFirstRegistration = model.DateAndTimeOfFirstRegistration,
            DeclaredGoodsNames = model.DeclaredGoodsNames,
            DocumentCode = model.DocumentCode,
            FinalModifierSId = model.FinalModifierSId,
            FirstRegistrantSId = model.FirstRegistrantSId,
            GoodsValue = model.GoodsValue,
            Id = model.Id,
            ImportExportTypeCode = model.ImportExportTypeCode,
            NatureOfGoodsCode = model.NatureOfGoodsCode,
            RectificationFrequency = model.RectificationFrequency,
            RegimeRequestNumber = model.RegimeRequestNumber,
            SequenceNumber = model.SequenceNumber,
            ShCode = model.ShCode,
            StorageLocation = model.StorageLocation,
            StorageLocationUnitCode = model.StorageLocationUnitCode,
            SuppressionOn = model.SuppressionOn,
            TechnicalName = model.TechnicalName,
            TransactionValueCurrencyCode = model.TransactionValueCurrencyCode,
            UpdatedAt = model.UpdatedAt
        };
    }

    public static DetailsOfGoodsForPassivePerfectionDbModel ToModel(
        this DetailsOfGoodsForPassivePerfectionUpdateInput updateDto,
        DetailsOfGoodsForPassivePerfectionWhereUniqueInput uniqueId
    )
    {
        var detailsOfGoodsForPassivePerfection = new DetailsOfGoodsForPassivePerfectionDbModel
        {
            Id = uniqueId.Id,
            BrandName = updateDto.BrandName,
            DateAndTimeOfFinalModification = updateDto.DateAndTimeOfFinalModification,
            DateAndTimeOfFirstRegistration = updateDto.DateAndTimeOfFirstRegistration,
            DeclaredGoodsNames = updateDto.DeclaredGoodsNames,
            DocumentCode = updateDto.DocumentCode,
            FinalModifierSId = updateDto.FinalModifierSId,
            FirstRegistrantSId = updateDto.FirstRegistrantSId,
            GoodsValue = updateDto.GoodsValue,
            ImportExportTypeCode = updateDto.ImportExportTypeCode,
            NatureOfGoodsCode = updateDto.NatureOfGoodsCode,
            RectificationFrequency = updateDto.RectificationFrequency,
            RegimeRequestNumber = updateDto.RegimeRequestNumber,
            SequenceNumber = updateDto.SequenceNumber,
            ShCode = updateDto.ShCode,
            StorageLocation = updateDto.StorageLocation,
            StorageLocationUnitCode = updateDto.StorageLocationUnitCode,
            SuppressionOn = updateDto.SuppressionOn,
            TechnicalName = updateDto.TechnicalName,
            TransactionValueCurrencyCode = updateDto.TransactionValueCurrencyCode
        };

        if (updateDto.CreatedAt != null) detailsOfGoodsForPassivePerfection.CreatedAt = updateDto.CreatedAt.Value;
        if (updateDto.UpdatedAt != null) detailsOfGoodsForPassivePerfection.UpdatedAt = updateDto.UpdatedAt.Value;

        return detailsOfGoodsForPassivePerfection;
    }
}
