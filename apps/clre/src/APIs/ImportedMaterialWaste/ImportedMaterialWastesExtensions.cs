using Clre.APIs.Dtos;
using Clre.Infrastructure.Models;

namespace Clre.APIs.Extensions;

public static class ImportedMaterialWastesExtensions
{
    public static ImportedMaterialWaste ToDto(this ImportedMaterialWasteDbModel model)
    {
        return new ImportedMaterialWaste
        {
            CreatedAt = model.CreatedAt,
            DateAndTimeOfFinalModification = model.DateAndTimeOfFinalModification,
            DateAndTimeOfFirstRegistration = model.DateAndTimeOfFirstRegistration,
            FinalModifierSId = model.FinalModifierSId,
            FirstRegistrantSId = model.FirstRegistrantSId,
            Id = model.Id,
            LossRate = model.LossRate,
            NonRecoverableWasteRate = model.NonRecoverableWasteRate,
            RateOfWasteOnFinishedProducts = model.RateOfWasteOnFinishedProducts,
            RecoverableWasteRate = model.RecoverableWasteRate,
            RectificationFrequency = model.RectificationFrequency,
            RequestNumberOfRegime = model.RequestNumberOfRegime,
            SequenceNumber = model.SequenceNumber,
            SuppressionOn = model.SuppressionOn,
            UpdatedAt = model.UpdatedAt,
        };
    }

    public static ImportedMaterialWasteDbModel ToModel(
        this ImportedMaterialWasteUpdateInput updateDto,
        ImportedMaterialWasteWhereUniqueInput uniqueId
    )
    {
        var importedMaterialWaste = new ImportedMaterialWasteDbModel
        {
            Id = uniqueId.Id,
            DateAndTimeOfFinalModification = updateDto.DateAndTimeOfFinalModification,
            DateAndTimeOfFirstRegistration = updateDto.DateAndTimeOfFirstRegistration,
            FinalModifierSId = updateDto.FinalModifierSId,
            FirstRegistrantSId = updateDto.FirstRegistrantSId,
            LossRate = updateDto.LossRate,
            NonRecoverableWasteRate = updateDto.NonRecoverableWasteRate,
            RateOfWasteOnFinishedProducts = updateDto.RateOfWasteOnFinishedProducts,
            RecoverableWasteRate = updateDto.RecoverableWasteRate,
            RectificationFrequency = updateDto.RectificationFrequency,
            RequestNumberOfRegime = updateDto.RequestNumberOfRegime,
            SequenceNumber = updateDto.SequenceNumber,
            SuppressionOn = updateDto.SuppressionOn
        };

        if (updateDto.CreatedAt != null)
        {
            importedMaterialWaste.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.UpdatedAt != null)
        {
            importedMaterialWaste.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return importedMaterialWaste;
    }
}
