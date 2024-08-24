using Traveler.APIs.Dtos;
using Traveler.Infrastructure.Models;

namespace Traveler.APIs.Extensions;

public static class InspectorRatingModificationHistoriesExtensions
{
    public static InspectorRatingModificationHistory ToDto(
        this InspectorRatingModificationHistoryDbModel model
    )
    {
        return new InspectorRatingModificationHistory
        {
            AuditorClassificationCode = model.AuditorClassificationCode,
            CreatedAt = model.CreatedAt,
            DistributionContent = model.DistributionContent,
            DistributionReasonCode = model.DistributionReasonCode,
            ExaminerIdAfterModification = model.ExaminerIdAfterModification,
            ExaminerIdBeforeChange = model.ExaminerIdBeforeChange,
            FinalModificationDateAndTime = model.FinalModificationDateAndTime,
            FirstRegistrationDateAndTime = model.FirstRegistrationDateAndTime,
            GeneralTravelerInformationTpds = model
                .GeneralTravelerInformationTpds?.Select(x => x.Id)
                .ToList(),
            HistorySequenceNumber = model.HistorySequenceNumber,
            Id = model.Id,
            ReferenceNumber = model.ReferenceNumber,
            UpdatedAt = model.UpdatedAt,
        };
    }

    public static InspectorRatingModificationHistoryDbModel ToModel(
        this InspectorRatingModificationHistoryUpdateInput updateDto,
        InspectorRatingModificationHistoryWhereUniqueInput uniqueId
    )
    {
        var inspectorRatingModificationHistory = new InspectorRatingModificationHistoryDbModel
        {
            Id = uniqueId.Id,
            AuditorClassificationCode = updateDto.AuditorClassificationCode,
            DistributionContent = updateDto.DistributionContent,
            DistributionReasonCode = updateDto.DistributionReasonCode,
            ExaminerIdAfterModification = updateDto.ExaminerIdAfterModification,
            ExaminerIdBeforeChange = updateDto.ExaminerIdBeforeChange,
            FinalModificationDateAndTime = updateDto.FinalModificationDateAndTime,
            FirstRegistrationDateAndTime = updateDto.FirstRegistrationDateAndTime,
            HistorySequenceNumber = updateDto.HistorySequenceNumber,
            ReferenceNumber = updateDto.ReferenceNumber
        };

        if (updateDto.CreatedAt != null)
        {
            inspectorRatingModificationHistory.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.UpdatedAt != null)
        {
            inspectorRatingModificationHistory.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return inspectorRatingModificationHistory;
    }
}
