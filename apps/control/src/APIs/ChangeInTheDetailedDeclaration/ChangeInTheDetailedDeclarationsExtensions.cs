using Control.APIs.Dtos;
using Control.Infrastructure.Models;

namespace Control.APIs.Extensions;

public static class ChangeInTheDetailedDeclarationsExtensions
{
    public static ChangeInTheDetailedDeclaration ToDto(
        this ChangeInTheDetailedDeclarationDbModel model
    )
    {
        return new ChangeInTheDetailedDeclaration
        {
            CommonDetailedDeclaration = model.CommonDetailedDeclarationId,
            CreatedAt = model.CreatedAt,
            DateAndTimeOfFinalModification = model.DateAndTimeOfFinalModification,
            DateAndTimeOfFirstRegistration = model.DateAndTimeOfFirstRegistration,
            DateAndTimeOfTreatmentDecision = model.DateAndTimeOfTreatmentDecision,
            DeletionOn = model.DeletionOn,
            ExecutionCodeByStatusTreatment = model.ExecutionCodeByStatusTreatment,
            FinalModifierId = model.FinalModifierId,
            FirstRegistrantId = model.FirstRegistrantId,
            Id = model.Id,
            StatusTreatmentCode = model.StatusTreatmentCode,
            TreatmentStatusContent = model.TreatmentStatusContent,
            UpdatedAt = model.UpdatedAt,
        };
    }

    public static ChangeInTheDetailedDeclarationDbModel ToModel(
        this ChangeInTheDetailedDeclarationUpdateInput updateDto,
        ChangeInTheDetailedDeclarationWhereUniqueInput uniqueId
    )
    {
        var changeInTheDetailedDeclaration = new ChangeInTheDetailedDeclarationDbModel
        {
            Id = uniqueId.Id,
            DateAndTimeOfFinalModification = updateDto.DateAndTimeOfFinalModification,
            DateAndTimeOfFirstRegistration = updateDto.DateAndTimeOfFirstRegistration,
            DateAndTimeOfTreatmentDecision = updateDto.DateAndTimeOfTreatmentDecision,
            DeletionOn = updateDto.DeletionOn,
            ExecutionCodeByStatusTreatment = updateDto.ExecutionCodeByStatusTreatment,
            FinalModifierId = updateDto.FinalModifierId,
            FirstRegistrantId = updateDto.FirstRegistrantId,
            StatusTreatmentCode = updateDto.StatusTreatmentCode,
            TreatmentStatusContent = updateDto.TreatmentStatusContent
        };

        if (updateDto.CommonDetailedDeclaration != null)
        {
            changeInTheDetailedDeclaration.CommonDetailedDeclarationId =
                updateDto.CommonDetailedDeclaration;
        }
        if (updateDto.CreatedAt != null)
        {
            changeInTheDetailedDeclaration.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.UpdatedAt != null)
        {
            changeInTheDetailedDeclaration.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return changeInTheDetailedDeclaration;
    }
}
