using Clre.APIs.Dtos;
using Clre.Infrastructure.Models;

namespace Clre.APIs.Extensions;

public static class DefinitiveExportGoodsFollowedByAndWithReimportationInTheStatesExtensions
{
    public static DefinitiveExportGoodsFollowedByAndWithReimportationInTheState ToDto(
        this DefinitiveExportGoodsFollowedByAndWithReimportationInTheStateDbModel model
    )
    {
        return new DefinitiveExportGoodsFollowedByAndWithReimportationInTheState
        {
            CommercialDesignationOfTheMaterials = model.CommercialDesignationOfTheMaterials,
            CreatedAt = model.CreatedAt,
            CurrencyCode = model.CurrencyCode,
            DateAndTimeOfFinalModification = model.DateAndTimeOfFinalModification,
            DateAndTimeOfFirstRegistration = model.DateAndTimeOfFirstRegistration,
            FinalModifierSId = model.FinalModifierSId,
            FirstRecorderSId = model.FirstRecorderSId,
            Id = model.Id,
            Identification = model.Identification,
            NumberOfTheArticleConcerned = model.NumberOfTheArticleConcerned,
            Origin = model.Origin,
            RectificationFrequency = model.RectificationFrequency,
            ReferenceSOfTheModelSOfTheArticleConcerned =
                model.ReferenceSOfTheModelSOfTheArticleConcerned,
            RequestNumberOfTheRegime = model.RequestNumberOfTheRegime,
            SequenceNumber = model.SequenceNumber,
            SptNumber = model.SptNumber,
            StorageLocation = model.StorageLocation,
            SuppressionOn = model.SuppressionOn,
            TechnicalDesignationOfTheMaterials = model.TechnicalDesignationOfTheMaterials,
            UnknownField = model.UnknownField,
            UpdatedAt = model.UpdatedAt,
            Value = model.Value,
            ValueInCurrencyOfTheGoods = model.ValueInCurrencyOfTheGoods,
        };
    }

    public static DefinitiveExportGoodsFollowedByAndWithReimportationInTheStateDbModel ToModel(
        this DefinitiveExportGoodsFollowedByAndWithReimportationInTheStateUpdateInput updateDto,
        DefinitiveExportGoodsFollowedByAndWithReimportationInTheStateWhereUniqueInput uniqueId
    )
    {
        var definitiveExportGoodsFollowedByAndWithReimportationInTheState =
            new DefinitiveExportGoodsFollowedByAndWithReimportationInTheStateDbModel
            {
                Id = uniqueId.Id,
                CommercialDesignationOfTheMaterials = updateDto.CommercialDesignationOfTheMaterials,
                CurrencyCode = updateDto.CurrencyCode,
                DateAndTimeOfFinalModification = updateDto.DateAndTimeOfFinalModification,
                DateAndTimeOfFirstRegistration = updateDto.DateAndTimeOfFirstRegistration,
                FinalModifierSId = updateDto.FinalModifierSId,
                FirstRecorderSId = updateDto.FirstRecorderSId,
                Identification = updateDto.Identification,
                NumberOfTheArticleConcerned = updateDto.NumberOfTheArticleConcerned,
                Origin = updateDto.Origin,
                RectificationFrequency = updateDto.RectificationFrequency,
                ReferenceSOfTheModelSOfTheArticleConcerned =
                    updateDto.ReferenceSOfTheModelSOfTheArticleConcerned,
                RequestNumberOfTheRegime = updateDto.RequestNumberOfTheRegime,
                SequenceNumber = updateDto.SequenceNumber,
                SptNumber = updateDto.SptNumber,
                StorageLocation = updateDto.StorageLocation,
                SuppressionOn = updateDto.SuppressionOn,
                TechnicalDesignationOfTheMaterials = updateDto.TechnicalDesignationOfTheMaterials,
                UnknownField = updateDto.UnknownField,
                Value = updateDto.Value,
                ValueInCurrencyOfTheGoods = updateDto.ValueInCurrencyOfTheGoods
            };

        if (updateDto.CreatedAt != null)
        {
            definitiveExportGoodsFollowedByAndWithReimportationInTheState.CreatedAt = updateDto
                .CreatedAt
                .Value;
        }
        if (updateDto.UpdatedAt != null)
        {
            definitiveExportGoodsFollowedByAndWithReimportationInTheState.UpdatedAt = updateDto
                .UpdatedAt
                .Value;
        }

        return definitiveExportGoodsFollowedByAndWithReimportationInTheState;
    }
}
