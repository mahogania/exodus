using Clre.APIs.Dtos;
using Clre.Infrastructure.Models;

namespace Clre.APIs.Extensions;

public static class InfosGoodsToBeReprovisionedsExtensions
{
    public static InfosGoodsToBeReprovisioned ToDto(this InfosGoodsToBeReprovisionedDbModel model)
    {
        return new InfosGoodsToBeReprovisioned
        {
            CommercialDesignationOfGoods = model.CommercialDesignationOfGoods,
            CreatedAt = model.CreatedAt,
            DateAndTimeOfFinalModification = model.DateAndTimeOfFinalModification,
            DateAndTimeOfFirstRegistration = model.DateAndTimeOfFirstRegistration,
            FinalModifierSId = model.FinalModifierSId,
            FirstRegistrantSId = model.FirstRegistrantSId,
            Id = model.Id,
            NatureOfTheGoods = model.NatureOfTheGoods,
            NumberOfTheConcernedArticle = model.NumberOfTheConcernedArticle,
            Origin = model.Origin,
            ProposedMeansForTheQuantitativeAndTechnicalControlOfEquivalence =
                model.ProposedMeansForTheQuantitativeAndTechnicalControlOfEquivalence,
            Provenance = model.Provenance,
            QuantityIncludingNonRecoverableWaste = model.QuantityIncludingNonRecoverableWaste,
            RectificationFrequency = model.RectificationFrequency,
            ReferencesOfTheConcernedArticleModelS = model.ReferencesOfTheConcernedArticleModelS,
            RegimeRequestNumber = model.RegimeRequestNumber,
            SequenceNumber = model.SequenceNumber,
            SptNumber = model.SptNumber,
            SuppressionOn = model.SuppressionOn,
            TechnicalCharacteristics = model.TechnicalCharacteristics,
            TechnicalDesignationOfGoods = model.TechnicalDesignationOfGoods,
            UpdatedAt = model.UpdatedAt,
        };
    }

    public static InfosGoodsToBeReprovisionedDbModel ToModel(
        this InfosGoodsToBeReprovisionedUpdateInput updateDto,
        InfosGoodsToBeReprovisionedWhereUniqueInput uniqueId
    )
    {
        var infosGoodsToBeReprovisioned = new InfosGoodsToBeReprovisionedDbModel
        {
            Id = uniqueId.Id,
            CommercialDesignationOfGoods = updateDto.CommercialDesignationOfGoods,
            DateAndTimeOfFinalModification = updateDto.DateAndTimeOfFinalModification,
            DateAndTimeOfFirstRegistration = updateDto.DateAndTimeOfFirstRegistration,
            FinalModifierSId = updateDto.FinalModifierSId,
            FirstRegistrantSId = updateDto.FirstRegistrantSId,
            NatureOfTheGoods = updateDto.NatureOfTheGoods,
            NumberOfTheConcernedArticle = updateDto.NumberOfTheConcernedArticle,
            Origin = updateDto.Origin,
            ProposedMeansForTheQuantitativeAndTechnicalControlOfEquivalence =
                updateDto.ProposedMeansForTheQuantitativeAndTechnicalControlOfEquivalence,
            Provenance = updateDto.Provenance,
            QuantityIncludingNonRecoverableWaste = updateDto.QuantityIncludingNonRecoverableWaste,
            RectificationFrequency = updateDto.RectificationFrequency,
            ReferencesOfTheConcernedArticleModelS = updateDto.ReferencesOfTheConcernedArticleModelS,
            RegimeRequestNumber = updateDto.RegimeRequestNumber,
            SequenceNumber = updateDto.SequenceNumber,
            SptNumber = updateDto.SptNumber,
            SuppressionOn = updateDto.SuppressionOn,
            TechnicalCharacteristics = updateDto.TechnicalCharacteristics,
            TechnicalDesignationOfGoods = updateDto.TechnicalDesignationOfGoods
        };

        if (updateDto.CreatedAt != null)
        {
            infosGoodsToBeReprovisioned.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.UpdatedAt != null)
        {
            infosGoodsToBeReprovisioned.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return infosGoodsToBeReprovisioned;
    }
}
