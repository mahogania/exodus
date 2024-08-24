using Control.APIs.Dtos;
using Control.Infrastructure.Models;

namespace Control.APIs.Extensions;

public static class ReplenishmentsExtensions
{
    public static Replenishment ToDto(this ReplenishmentDbModel model)
    {
        return new Replenishment
        {
            ApcCode = model.ApcCode,
            CreatedAt = model.CreatedAt,
            CustomsClearanceOfficeForReplenishmentInDutyFree =
                model.CustomsClearanceOfficeForReplenishmentInDutyFree,
            CustomsClearanceOfficeOfDeclaration = model.CustomsClearanceOfficeOfDeclaration,
            DateAndTimeOfFinalModification = model.DateAndTimeOfFinalModification,
            DateAndTimeOfFirstRegistration = model.DateAndTimeOfFirstRegistration,
            DateOfDau = model.DateOfDau,
            DeclarationStatus = model.DeclarationStatus,
            EpcCode = model.EpcCode,
            EpcLabel = model.EpcLabel,
            ExportDeclarationNumber = model.ExportDeclarationNumber,
            FinalModifierSId = model.FinalModifierSId,
            FirstRegistrantSId = model.FirstRegistrantSId,
            Id = model.Id,
            RectificationFrequency = model.RectificationFrequency,
            RegimeRequestNumber = model.RegimeRequestNumber,
            RequestTypeCode = model.RequestTypeCode,
            RequestedEndDate = model.RequestedEndDate,
            RequestedStartDate = model.RequestedStartDate,
            SuppressionOn = model.SuppressionOn,
            UpdatedAt = model.UpdatedAt,
        };
    }

    public static ReplenishmentDbModel ToModel(
        this ReplenishmentUpdateInput updateDto,
        ReplenishmentWhereUniqueInput uniqueId
    )
    {
        var replenishment = new ReplenishmentDbModel
        {
            Id = uniqueId.Id,
            ApcCode = updateDto.ApcCode,
            CustomsClearanceOfficeForReplenishmentInDutyFree =
                updateDto.CustomsClearanceOfficeForReplenishmentInDutyFree,
            CustomsClearanceOfficeOfDeclaration = updateDto.CustomsClearanceOfficeOfDeclaration,
            DateAndTimeOfFinalModification = updateDto.DateAndTimeOfFinalModification,
            DateAndTimeOfFirstRegistration = updateDto.DateAndTimeOfFirstRegistration,
            DateOfDau = updateDto.DateOfDau,
            DeclarationStatus = updateDto.DeclarationStatus,
            EpcCode = updateDto.EpcCode,
            EpcLabel = updateDto.EpcLabel,
            ExportDeclarationNumber = updateDto.ExportDeclarationNumber,
            FinalModifierSId = updateDto.FinalModifierSId,
            FirstRegistrantSId = updateDto.FirstRegistrantSId,
            RectificationFrequency = updateDto.RectificationFrequency,
            RegimeRequestNumber = updateDto.RegimeRequestNumber,
            RequestTypeCode = updateDto.RequestTypeCode,
            RequestedEndDate = updateDto.RequestedEndDate,
            RequestedStartDate = updateDto.RequestedStartDate,
            SuppressionOn = updateDto.SuppressionOn
        };

        if (updateDto.CreatedAt != null)
        {
            replenishment.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.UpdatedAt != null)
        {
            replenishment.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return replenishment;
    }
}
