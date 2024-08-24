using Traveler.APIs.Dtos;
using Traveler.Infrastructure.Models;

namespace Traveler.APIs.Extensions;

public static class TpdControlsExtensions
{
    public static TpdControl ToDto(this TpdControlDbModel model)
    {
        return new TpdControl
        {
            ApprovalId = model.ApprovalId,
            ApprovalProcessStatusCode = model.ApprovalProcessStatusCode,
            BaggageControlArticle = model.BaggageControlArticleId,
            ControlResult = model.ControlResult,
            ControlResultRegistrationDateTime = model.ControlResultRegistrationDateTime,
            ControlStatus = model.ControlStatus,
            ControlTypeCode = model.ControlTypeCode,
            CreatedAt = model.CreatedAt,
            DeletionOn = model.DeletionOn,
            FinalModificationDateAndTime = model.FinalModificationDateAndTime,
            FirstRegistrationDateAndTime = model.FirstRegistrationDateAndTime,
            GeneralTravelerInformationTpds = model
                .GeneralTravelerInformationTpds?.Select(x => x.Id)
                .ToList(),
            Id = model.Id,
            ImportDeclarations = model.ImportDeclarations?.Select(x => x.Id).ToList(),
            InspectorId = model.InspectorId,
            JudgmentOrder = model.JudgmentOrder,
            TpdNumber = model.TpdNumber,
            UpdatedAt = model.UpdatedAt,
            VerificationResultCode = model.VerificationResultCode,
            VerificationResultContent = model.VerificationResultContent,
        };
    }

    public static TpdControlDbModel ToModel(
        this TpdControlUpdateInput updateDto,
        TpdControlWhereUniqueInput uniqueId
    )
    {
        var tpdControl = new TpdControlDbModel
        {
            Id = uniqueId.Id,
            ApprovalId = updateDto.ApprovalId,
            ApprovalProcessStatusCode = updateDto.ApprovalProcessStatusCode,
            ControlResult = updateDto.ControlResult,
            ControlResultRegistrationDateTime = updateDto.ControlResultRegistrationDateTime,
            ControlStatus = updateDto.ControlStatus,
            ControlTypeCode = updateDto.ControlTypeCode,
            DeletionOn = updateDto.DeletionOn,
            FinalModificationDateAndTime = updateDto.FinalModificationDateAndTime,
            FirstRegistrationDateAndTime = updateDto.FirstRegistrationDateAndTime,
            InspectorId = updateDto.InspectorId,
            JudgmentOrder = updateDto.JudgmentOrder,
            TpdNumber = updateDto.TpdNumber,
            VerificationResultCode = updateDto.VerificationResultCode,
            VerificationResultContent = updateDto.VerificationResultContent
        };

        if (updateDto.BaggageControlArticle != null)
        {
            tpdControl.BaggageControlArticleId = updateDto.BaggageControlArticle;
        }
        if (updateDto.CreatedAt != null)
        {
            tpdControl.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.UpdatedAt != null)
        {
            tpdControl.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return tpdControl;
    }
}
