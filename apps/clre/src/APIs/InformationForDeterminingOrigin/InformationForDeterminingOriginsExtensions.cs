using Clre.APIs.Dtos;
using Clre.Infrastructure.Models;

namespace Clre.APIs.Extensions;

public static class InformationForDeterminingOriginsExtensions
{
    public static InformationForDeterminingOrigin ToDto(
        this InformationForDeterminingOriginDbModel model
    )
    {
        return new InformationForDeterminingOrigin
        {
            Amount = model.Amount,
            CountryOfOriginCode = model.CountryOfOriginCode,
            CreatedAt = model.CreatedAt,
            DeletionOn = model.DeletionOn,
            FinalModificationDateAndTime = model.FinalModificationDateAndTime,
            FinalModifierSId = model.FinalModifierSId,
            FirstRecorderSId = model.FirstRecorderSId,
            FirstRegistrationDateAndTime = model.FirstRegistrationDateAndTime,
            Id = model.Id,
            NameOfMaterialsUsed = model.NameOfMaterialsUsed,
            OriginDeterminationSeriesNumber = model.OriginDeterminationSeriesNumber,
            RcoRequestNumber = model.RcoRequestNumber,
            RectificationFrequency = model.RectificationFrequency,
            ShCode = model.ShCode,
            UpdatedAt = model.UpdatedAt,
            Weight = model.Weight,
        };
    }

    public static InformationForDeterminingOriginDbModel ToModel(
        this InformationForDeterminingOriginUpdateInput updateDto,
        InformationForDeterminingOriginWhereUniqueInput uniqueId
    )
    {
        var informationForDeterminingOrigin = new InformationForDeterminingOriginDbModel
        {
            Id = uniqueId.Id,
            Amount = updateDto.Amount,
            CountryOfOriginCode = updateDto.CountryOfOriginCode,
            DeletionOn = updateDto.DeletionOn,
            FinalModificationDateAndTime = updateDto.FinalModificationDateAndTime,
            FinalModifierSId = updateDto.FinalModifierSId,
            FirstRecorderSId = updateDto.FirstRecorderSId,
            FirstRegistrationDateAndTime = updateDto.FirstRegistrationDateAndTime,
            NameOfMaterialsUsed = updateDto.NameOfMaterialsUsed,
            OriginDeterminationSeriesNumber = updateDto.OriginDeterminationSeriesNumber,
            RcoRequestNumber = updateDto.RcoRequestNumber,
            RectificationFrequency = updateDto.RectificationFrequency,
            ShCode = updateDto.ShCode,
            Weight = updateDto.Weight
        };

        if (updateDto.CreatedAt != null)
        {
            informationForDeterminingOrigin.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.UpdatedAt != null)
        {
            informationForDeterminingOrigin.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return informationForDeterminingOrigin;
    }
}
