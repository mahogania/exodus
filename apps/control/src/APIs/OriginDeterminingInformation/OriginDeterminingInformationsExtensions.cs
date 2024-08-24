using Control.APIs.Dtos;
using Control.Infrastructure.Models;

namespace Control.APIs.Extensions;

public static class OriginDeterminingInformationsExtensions
{
    public static OriginDeterminingInformation ToDto(this OriginDeterminingInformationDbModel model)
    {
        return new OriginDeterminingInformation
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

    public static OriginDeterminingInformationDbModel ToModel(
        this OriginDeterminingInformationUpdateInput updateDto,
        OriginDeterminingInformationWhereUniqueInput uniqueId
    )
    {
        var originDeterminingInformation = new OriginDeterminingInformationDbModel
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
            originDeterminingInformation.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.UpdatedAt != null)
        {
            originDeterminingInformation.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return originDeterminingInformation;
    }
}
