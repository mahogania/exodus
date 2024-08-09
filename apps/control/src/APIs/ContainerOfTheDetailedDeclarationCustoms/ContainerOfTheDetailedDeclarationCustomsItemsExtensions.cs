using Control.APIs.Dtos;
using Control.Infrastructure.Models;

namespace Control.APIs.Extensions;

public static class ContainerOfTheDetailedDeclarationCustomsItemsExtensions
{
    public static ContainerOfTheDetailedDeclarationCustoms ToDto(
        this ContainerOfTheDetailedDeclarationCustomsDbModel model
    )
    {
        return new ContainerOfTheDetailedDeclarationCustoms
        {
            ContainerNumber = model.ContainerNumber,
            ContainerPackingStateCode = model.ContainerPackingStateCode,
            ContainerSequenceNumber = model.ContainerSequenceNumber,
            ContainerTypeCode = model.ContainerTypeCode,
            CreatedAt = model.CreatedAt,
            DateAndTimeOfFinalModification = model.DateAndTimeOfFinalModification,
            DateAndTimeOfFirstRegistration = model.DateAndTimeOfFirstRegistration,
            FinalModifierSId = model.FinalModifierSId,
            FirstRegistrantSId = model.FirstRegistrantSId,
            GoodsVerified = model.GoodsVerified,
            Id = model.Id,
            RectificationFrequency = model.RectificationFrequency,
            ReferenceNumber = model.ReferenceNumber,
            SealNumber_1 = model.SealNumber_1,
            SealNumber_2 = model.SealNumber_2,
            SealNumber_3 = model.SealNumber_3,
            Sealer_1 = model.Sealer_1,
            Sealer_2 = model.Sealer_2,
            Sealer_3 = model.Sealer_3,
            SealingPersonCode = model.SealingPersonCode,
            SuppressionOn = model.SuppressionOn,
            UpdatedAt = model.UpdatedAt,
        };
    }

    public static ContainerOfTheDetailedDeclarationCustomsDbModel ToModel(
        this ContainerOfTheDetailedDeclarationCustomsUpdateInput updateDto,
        ContainerOfTheDetailedDeclarationCustomsWhereUniqueInput uniqueId
    )
    {
        var containerOfTheDetailedDeclarationCustoms =
            new ContainerOfTheDetailedDeclarationCustomsDbModel
            {
                Id = uniqueId.Id,
                ContainerNumber = updateDto.ContainerNumber,
                ContainerPackingStateCode = updateDto.ContainerPackingStateCode,
                ContainerSequenceNumber = updateDto.ContainerSequenceNumber,
                ContainerTypeCode = updateDto.ContainerTypeCode,
                DateAndTimeOfFinalModification = updateDto.DateAndTimeOfFinalModification,
                DateAndTimeOfFirstRegistration = updateDto.DateAndTimeOfFirstRegistration,
                FinalModifierSId = updateDto.FinalModifierSId,
                FirstRegistrantSId = updateDto.FirstRegistrantSId,
                GoodsVerified = updateDto.GoodsVerified,
                RectificationFrequency = updateDto.RectificationFrequency,
                ReferenceNumber = updateDto.ReferenceNumber,
                SealNumber_1 = updateDto.SealNumber_1,
                SealNumber_2 = updateDto.SealNumber_2,
                SealNumber_3 = updateDto.SealNumber_3,
                Sealer_1 = updateDto.Sealer_1,
                Sealer_2 = updateDto.Sealer_2,
                Sealer_3 = updateDto.Sealer_3,
                SealingPersonCode = updateDto.SealingPersonCode,
                SuppressionOn = updateDto.SuppressionOn
            };

        if (updateDto.CreatedAt != null)
        {
            containerOfTheDetailedDeclarationCustoms.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.UpdatedAt != null)
        {
            containerOfTheDetailedDeclarationCustoms.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return containerOfTheDetailedDeclarationCustoms;
    }
}
