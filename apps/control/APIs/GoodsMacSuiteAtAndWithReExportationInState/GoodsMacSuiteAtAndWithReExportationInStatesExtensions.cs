using Control.APIs.Dtos;
using Control.Infrastructure.Models;

namespace Control.APIs.Extensions;

public static class GoodsMacSuiteAtAndWithReExportationInStatesExtensions
{
    public static GoodsMacSuiteAtAndWithReExportationInState ToDto(
        this GoodsMacSuiteAtAndWithReExportationInStateDbModel model
    )
    {
        return new GoodsMacSuiteAtAndWithReExportationInState
        {
            CommercialDesignationOfMaterials = model.CommercialDesignationOfMaterials,
            ConcernedArticleNumber = model.ConcernedArticleNumber,
            CreatedAt = model.CreatedAt,
            CurrencyCode = model.CurrencyCode,
            CurrencyValueOfGoods = model.CurrencyValueOfGoods,
            DateAndTimeOfFinalModification = model.DateAndTimeOfFinalModification,
            DateAndTimeOfFirstRegistration = model.DateAndTimeOfFirstRegistration,
            FinalModifierSId = model.FinalModifierSId,
            FirstRegistrantSId = model.FirstRegistrantSId,
            Id = model.Id,
            Identification = model.Identification,
            Origin = model.Origin,
            RectificationFrequency = model.RectificationFrequency,
            ReferenceSOfTheConcernedArticleModelS = model.ReferenceSOfTheConcernedArticleModelS,
            RegimeRequestNumber = model.RegimeRequestNumber,
            SequenceNumber = model.SequenceNumber,
            SptNumber = model.SptNumber,
            StoragePlace = model.StoragePlace,
            SuppressionOn = model.SuppressionOn,
            TechnicalDesignationOfMaterials = model.TechnicalDesignationOfMaterials,
            UpdatedAt = model.UpdatedAt,
            Value = model.Value
        };
    }

    public static GoodsMacSuiteAtAndWithReExportationInStateDbModel ToModel(
        this GoodsMacSuiteAtAndWithReExportationInStateUpdateInput updateDto,
        GoodsMacSuiteAtAndWithReExportationInStateWhereUniqueInput uniqueId
    )
    {
        var goodsMacSuiteAtAndWithReExportationInState =
            new GoodsMacSuiteAtAndWithReExportationInStateDbModel
            {
                Id = uniqueId.Id,
                CommercialDesignationOfMaterials = updateDto.CommercialDesignationOfMaterials,
                ConcernedArticleNumber = updateDto.ConcernedArticleNumber,
                CurrencyCode = updateDto.CurrencyCode,
                CurrencyValueOfGoods = updateDto.CurrencyValueOfGoods,
                DateAndTimeOfFinalModification = updateDto.DateAndTimeOfFinalModification,
                DateAndTimeOfFirstRegistration = updateDto.DateAndTimeOfFirstRegistration,
                FinalModifierSId = updateDto.FinalModifierSId,
                FirstRegistrantSId = updateDto.FirstRegistrantSId,
                Identification = updateDto.Identification,
                Origin = updateDto.Origin,
                RectificationFrequency = updateDto.RectificationFrequency,
                ReferenceSOfTheConcernedArticleModelS =
                    updateDto.ReferenceSOfTheConcernedArticleModelS,
                RegimeRequestNumber = updateDto.RegimeRequestNumber,
                SequenceNumber = updateDto.SequenceNumber,
                SptNumber = updateDto.SptNumber,
                StoragePlace = updateDto.StoragePlace,
                SuppressionOn = updateDto.SuppressionOn,
                TechnicalDesignationOfMaterials = updateDto.TechnicalDesignationOfMaterials,
                Value = updateDto.Value
            };

        if (updateDto.CreatedAt != null)
            goodsMacSuiteAtAndWithReExportationInState.CreatedAt = updateDto.CreatedAt.Value;
        if (updateDto.UpdatedAt != null)
            goodsMacSuiteAtAndWithReExportationInState.UpdatedAt = updateDto.UpdatedAt.Value;

        return goodsMacSuiteAtAndWithReExportationInState;
    }
}
