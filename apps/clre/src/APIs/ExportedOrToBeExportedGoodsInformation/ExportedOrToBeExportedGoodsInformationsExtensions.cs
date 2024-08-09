using Clre.APIs.Dtos;
using Clre.Infrastructure.Models;

namespace Clre.APIs.Extensions;

public static class ExportedOrToBeExportedGoodsInformationsExtensions
{
    public static ExportedOrToBeExportedGoodsInformation ToDto(
        this ExportedOrToBeExportedGoodsInformationDbModel model
    )
    {
        return new ExportedOrToBeExportedGoodsInformation
        {
            ArticleNumber = model.ArticleNumber,
            CommercialDesignationOfTheGoods = model.CommercialDesignationOfTheGoods,
            CreatedAt = model.CreatedAt,
            CurrencyCode = model.CurrencyCode,
            DateAndTimeOfFinalModification = model.DateAndTimeOfFinalModification,
            DateAndTimeOfFirstRegistration = model.DateAndTimeOfFirstRegistration,
            DestinationCountry = model.DestinationCountry,
            FinalModifierSId = model.FinalModifierSId,
            FirstRegistrantSId = model.FirstRegistrantSId,
            Id = model.Id,
            Quantity = model.Quantity,
            RectificationFrequency = model.RectificationFrequency,
            RegimeRequestNumber = model.RegimeRequestNumber,
            SequenceNumber = model.SequenceNumber,
            SptNumber = model.SptNumber,
            SuppressionOn = model.SuppressionOn,
            TechnicalDesignationOfTheGoods = model.TechnicalDesignationOfTheGoods,
            UpdatedAt = model.UpdatedAt,
            Value = model.Value,
        };
    }

    public static ExportedOrToBeExportedGoodsInformationDbModel ToModel(
        this ExportedOrToBeExportedGoodsInformationUpdateInput updateDto,
        ExportedOrToBeExportedGoodsInformationWhereUniqueInput uniqueId
    )
    {
        var exportedOrToBeExportedGoodsInformation =
            new ExportedOrToBeExportedGoodsInformationDbModel
            {
                Id = uniqueId.Id,
                ArticleNumber = updateDto.ArticleNumber,
                CommercialDesignationOfTheGoods = updateDto.CommercialDesignationOfTheGoods,
                CurrencyCode = updateDto.CurrencyCode,
                DateAndTimeOfFinalModification = updateDto.DateAndTimeOfFinalModification,
                DateAndTimeOfFirstRegistration = updateDto.DateAndTimeOfFirstRegistration,
                DestinationCountry = updateDto.DestinationCountry,
                FinalModifierSId = updateDto.FinalModifierSId,
                FirstRegistrantSId = updateDto.FirstRegistrantSId,
                Quantity = updateDto.Quantity,
                RectificationFrequency = updateDto.RectificationFrequency,
                RegimeRequestNumber = updateDto.RegimeRequestNumber,
                SequenceNumber = updateDto.SequenceNumber,
                SptNumber = updateDto.SptNumber,
                SuppressionOn = updateDto.SuppressionOn,
                TechnicalDesignationOfTheGoods = updateDto.TechnicalDesignationOfTheGoods,
                Value = updateDto.Value
            };

        if (updateDto.CreatedAt != null)
        {
            exportedOrToBeExportedGoodsInformation.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.UpdatedAt != null)
        {
            exportedOrToBeExportedGoodsInformation.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return exportedOrToBeExportedGoodsInformation;
    }
}
