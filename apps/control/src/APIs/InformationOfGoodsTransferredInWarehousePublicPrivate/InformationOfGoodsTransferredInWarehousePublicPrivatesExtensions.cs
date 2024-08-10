using Control.APIs.Dtos;
using Control.Infrastructure.Models;

namespace Control.APIs.Extensions;

public static class InformationOfGoodsTransferredInWarehousePublicPrivatesExtensions
{
    public static InformationOfGoodsTransferredInWarehousePublicPrivate ToDto(
        this InformationOfGoodsTransferredInWarehousePublicPrivateDbModel model
    )
    {
        return new InformationOfGoodsTransferredInWarehousePublicPrivate
        {
            CommercialDesignationOfGoods = model.CommercialDesignationOfGoods,
            CreatedAt = model.CreatedAt,
            DateAndTimeOfFinalModification = model.DateAndTimeOfFinalModification,
            DateAndTimeOfFirstRegistration = model.DateAndTimeOfFirstRegistration,
            FinalModifierSId = model.FinalModifierSId,
            FirstRegistrantSId = model.FirstRegistrantSId,
            Id = model.Id,
            NumberOfTheConcernedArticle = model.NumberOfTheConcernedArticle,
            Origin = model.Origin,
            Quantity = model.Quantity,
            RectificationFrequency = model.RectificationFrequency,
            ReferencesOfTheConcernedArticleModelS = model.ReferencesOfTheConcernedArticleModelS,
            RegimeRequestNumber = model.RegimeRequestNumber,
            SequenceNumber = model.SequenceNumber,
            SptNumber = model.SptNumber,
            SuppressionOn = model.SuppressionOn,
            TechnicalDesignationOfGoods = model.TechnicalDesignationOfGoods,
            UpdatedAt = model.UpdatedAt,
            Value = model.Value
        };
    }

    public static InformationOfGoodsTransferredInWarehousePublicPrivateDbModel ToModel(
        this InformationOfGoodsTransferredInWarehousePublicPrivateUpdateInput updateDto,
        InformationOfGoodsTransferredInWarehousePublicPrivateWhereUniqueInput uniqueId
    )
    {
        var informationOfGoodsTransferredInWarehousePublicPrivate =
            new InformationOfGoodsTransferredInWarehousePublicPrivateDbModel
            {
                Id = uniqueId.Id,
                CommercialDesignationOfGoods = updateDto.CommercialDesignationOfGoods,
                DateAndTimeOfFinalModification = updateDto.DateAndTimeOfFinalModification,
                DateAndTimeOfFirstRegistration = updateDto.DateAndTimeOfFirstRegistration,
                FinalModifierSId = updateDto.FinalModifierSId,
                FirstRegistrantSId = updateDto.FirstRegistrantSId,
                NumberOfTheConcernedArticle = updateDto.NumberOfTheConcernedArticle,
                Origin = updateDto.Origin,
                Quantity = updateDto.Quantity,
                RectificationFrequency = updateDto.RectificationFrequency,
                ReferencesOfTheConcernedArticleModelS =
                    updateDto.ReferencesOfTheConcernedArticleModelS,
                RegimeRequestNumber = updateDto.RegimeRequestNumber,
                SequenceNumber = updateDto.SequenceNumber,
                SptNumber = updateDto.SptNumber,
                SuppressionOn = updateDto.SuppressionOn,
                TechnicalDesignationOfGoods = updateDto.TechnicalDesignationOfGoods,
                Value = updateDto.Value
            };

        if (updateDto.CreatedAt != null)
            informationOfGoodsTransferredInWarehousePublicPrivate.CreatedAt = updateDto
                .CreatedAt
                .Value;
        if (updateDto.UpdatedAt != null)
            informationOfGoodsTransferredInWarehousePublicPrivate.UpdatedAt = updateDto
                .UpdatedAt
                .Value;

        return informationOfGoodsTransferredInWarehousePublicPrivate;
    }
}
