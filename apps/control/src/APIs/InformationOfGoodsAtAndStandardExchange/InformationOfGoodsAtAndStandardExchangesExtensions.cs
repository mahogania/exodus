using Control.APIs.Dtos;
using Control.Infrastructure.Models;

namespace Control.APIs.Extensions;

public static class InformationOfGoodsAtAndStandardExchangesExtensions
{
    public static InformationOfGoodsAtAndStandardExchange ToDto(
        this InformationOfGoodsAtAndStandardExchangeDbModel model
    )
    {
        return new InformationOfGoodsAtAndStandardExchange
        {
            AddressOfTheSupplierRecipientOfTheGoods = model.AddressOfTheSupplierRecipientOfTheGoods,
            CommercialDesignationOfMaterials = model.CommercialDesignationOfMaterials,
            CreatedAt = model.CreatedAt,
            CurrencyCode = model.CurrencyCode,
            DateAndTimeOfFinalModification = model.DateAndTimeOfFinalModification,
            DateAndTimeOfFirstRegistration = model.DateAndTimeOfFirstRegistration,
            FinalModifierSId = model.FinalModifierSId,
            FirstRegistrantSId = model.FirstRegistrantSId,
            Id = model.Id,
            Identification = model.Identification,
            NameAndBusinessNameOfTheSupplierRecipientOfTheGoods =
                model.NameAndBusinessNameOfTheSupplierRecipientOfTheGoods,
            Origin = model.Origin,
            ProvenanceDestination = model.ProvenanceDestination,
            Quantity = model.Quantity,
            RectificationFrequency = model.RectificationFrequency,
            RegimeRequestNumber = model.RegimeRequestNumber,
            SequenceNumber = model.SequenceNumber,
            SptNumber = model.SptNumber,
            SuppressionOn = model.SuppressionOn,
            TechnicalDesignationOfMaterials = model.TechnicalDesignationOfMaterials,
            UpdatedAt = model.UpdatedAt,
            Value = model.Value
        };
    }

    public static InformationOfGoodsAtAndStandardExchangeDbModel ToModel(
        this InformationOfGoodsAtAndStandardExchangeUpdateInput updateDto,
        InformationOfGoodsAtAndStandardExchangeWhereUniqueInput uniqueId
    )
    {
        var informationOfGoodsAtAndStandardExchange =
            new InformationOfGoodsAtAndStandardExchangeDbModel
            {
                Id = uniqueId.Id,
                AddressOfTheSupplierRecipientOfTheGoods =
                    updateDto.AddressOfTheSupplierRecipientOfTheGoods,
                CommercialDesignationOfMaterials = updateDto.CommercialDesignationOfMaterials,
                CurrencyCode = updateDto.CurrencyCode,
                DateAndTimeOfFinalModification = updateDto.DateAndTimeOfFinalModification,
                DateAndTimeOfFirstRegistration = updateDto.DateAndTimeOfFirstRegistration,
                FinalModifierSId = updateDto.FinalModifierSId,
                FirstRegistrantSId = updateDto.FirstRegistrantSId,
                Identification = updateDto.Identification,
                NameAndBusinessNameOfTheSupplierRecipientOfTheGoods =
                    updateDto.NameAndBusinessNameOfTheSupplierRecipientOfTheGoods,
                Origin = updateDto.Origin,
                ProvenanceDestination = updateDto.ProvenanceDestination,
                Quantity = updateDto.Quantity,
                RectificationFrequency = updateDto.RectificationFrequency,
                RegimeRequestNumber = updateDto.RegimeRequestNumber,
                SequenceNumber = updateDto.SequenceNumber,
                SptNumber = updateDto.SptNumber,
                SuppressionOn = updateDto.SuppressionOn,
                TechnicalDesignationOfMaterials = updateDto.TechnicalDesignationOfMaterials,
                Value = updateDto.Value
            };

        if (updateDto.CreatedAt != null) informationOfGoodsAtAndStandardExchange.CreatedAt = updateDto.CreatedAt.Value;
        if (updateDto.UpdatedAt != null) informationOfGoodsAtAndStandardExchange.UpdatedAt = updateDto.UpdatedAt.Value;

        return informationOfGoodsAtAndStandardExchange;
    }
}
