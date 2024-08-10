using Control.APIs.Dtos;
using Control.Infrastructure.Models;

namespace Control.APIs.Extensions;

public static class GoodsSubjectToAuthorizationsExtensions
{
    public static GoodsSubjectToAuthorization ToDto(this GoodsSubjectToAuthorizationDbModel model)
    {
        return new GoodsSubjectToAuthorization
        {
            CommercialDesignationOfMaterials = model.CommercialDesignationOfMaterials,
            CreatedAt = model.CreatedAt,
            CurrencyCode = model.CurrencyCode,
            DateAndTimeOfFinalModification = model.DateAndTimeOfFinalModification,
            DateAndTimeOfFirstRegistration = model.DateAndTimeOfFirstRegistration,
            DeletionOn = model.DeletionOn,
            FinalModifierSId = model.FinalModifierSId,
            FirstRecorderSId = model.FirstRecorderSId,
            Id = model.Id,
            Identification = model.Identification,
            NumberOfTheArticleConcerned = model.NumberOfTheArticleConcerned,
            Origin = model.Origin,
            Quantity = model.Quantity,
            RectificationFrequency = model.RectificationFrequency,
            ReferenceSOfTheModelSOfTheArticleConcerned =
                model.ReferenceSOfTheModelSOfTheArticleConcerned,
            RegimeRequestNumber = model.RegimeRequestNumber,
            SequenceNumber = model.SequenceNumber,
            SptNumber = model.SptNumber,
            TechnicalDesignationOfMaterials = model.TechnicalDesignationOfMaterials,
            UpdatedAt = model.UpdatedAt,
            Value = model.Value
        };
    }

    public static GoodsSubjectToAuthorizationDbModel ToModel(
        this GoodsSubjectToAuthorizationUpdateInput updateDto,
        GoodsSubjectToAuthorizationWhereUniqueInput uniqueId
    )
    {
        var goodsSubjectToAuthorization = new GoodsSubjectToAuthorizationDbModel
        {
            Id = uniqueId.Id,
            CommercialDesignationOfMaterials = updateDto.CommercialDesignationOfMaterials,
            CurrencyCode = updateDto.CurrencyCode,
            DateAndTimeOfFinalModification = updateDto.DateAndTimeOfFinalModification,
            DateAndTimeOfFirstRegistration = updateDto.DateAndTimeOfFirstRegistration,
            DeletionOn = updateDto.DeletionOn,
            FinalModifierSId = updateDto.FinalModifierSId,
            FirstRecorderSId = updateDto.FirstRecorderSId,
            Identification = updateDto.Identification,
            NumberOfTheArticleConcerned = updateDto.NumberOfTheArticleConcerned,
            Origin = updateDto.Origin,
            Quantity = updateDto.Quantity,
            RectificationFrequency = updateDto.RectificationFrequency,
            ReferenceSOfTheModelSOfTheArticleConcerned =
                updateDto.ReferenceSOfTheModelSOfTheArticleConcerned,
            RegimeRequestNumber = updateDto.RegimeRequestNumber,
            SequenceNumber = updateDto.SequenceNumber,
            SptNumber = updateDto.SptNumber,
            TechnicalDesignationOfMaterials = updateDto.TechnicalDesignationOfMaterials,
            Value = updateDto.Value
        };

        if (updateDto.CreatedAt != null) goodsSubjectToAuthorization.CreatedAt = updateDto.CreatedAt.Value;
        if (updateDto.UpdatedAt != null) goodsSubjectToAuthorization.UpdatedAt = updateDto.UpdatedAt.Value;

        return goodsSubjectToAuthorization;
    }
}
