using Control.APIs.Dtos;
using Control.Infrastructure.Models;

namespace Control.APIs.Extensions;

public static class CustomsDeclarationBondsExtensions
{
    public static CustomsDeclarationBond ToDto(this CustomsDeclarationBondDbModel model)
    {
        return new CustomsDeclarationBond
        {
            BondAccountNumber = model.BondAccountNumber,
            CreatedAt = model.CreatedAt,
            DateAndTimeOfFinalModification = model.DateAndTimeOfFinalModification,
            DateAndTimeOfFirstRegistration = model.DateAndTimeOfFirstRegistration,
            FinalModifierSId = model.FinalModifierSId,
            FirstRecorderSId = model.FirstRecorderSId,
            Id = model.Id,
            RectificationFrequency = model.RectificationFrequency,
            ReferenceNumber = model.ReferenceNumber,
            SuppressionOn = model.SuppressionOn,
            TypeOfBondCode = model.TypeOfBondCode,
            UpdatedAt = model.UpdatedAt,
        };
    }

    public static CustomsDeclarationBondDbModel ToModel(
        this CustomsDeclarationBondUpdateInput updateDto,
        CustomsDeclarationBondWhereUniqueInput uniqueId
    )
    {
        var customsDeclarationBond = new CustomsDeclarationBondDbModel
        {
            Id = uniqueId.Id,
            BondAccountNumber = updateDto.BondAccountNumber,
            DateAndTimeOfFinalModification = updateDto.DateAndTimeOfFinalModification,
            DateAndTimeOfFirstRegistration = updateDto.DateAndTimeOfFirstRegistration,
            FinalModifierSId = updateDto.FinalModifierSId,
            FirstRecorderSId = updateDto.FirstRecorderSId,
            RectificationFrequency = updateDto.RectificationFrequency,
            ReferenceNumber = updateDto.ReferenceNumber,
            SuppressionOn = updateDto.SuppressionOn,
            TypeOfBondCode = updateDto.TypeOfBondCode
        };

        if (updateDto.CreatedAt != null)
        {
            customsDeclarationBond.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.UpdatedAt != null)
        {
            customsDeclarationBond.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return customsDeclarationBond;
    }
}
