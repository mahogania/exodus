using Control.APIs.Dtos;
using Control.Infrastructure.Models;

namespace Control.APIs.Extensions;

public static class VerificationResultsExtensions
{
    public static VerificationResult ToDto(this VerificationResultDbModel model)
    {
        return new VerificationResult
        {
            CommonVerification = model.CommonVerificationId,
            CreatedAt = model.CreatedAt,
            DateAndTimeOfFinalModification = model.DateAndTimeOfFinalModification,
            DateAndTimeOfInitialRecord = model.DateAndTimeOfInitialRecord,
            DeletedOn = model.DeletedOn,
            FinalModifierId = model.FinalModifierId,
            Id = model.Id,
            InitialRecorderId = model.InitialRecorderId,
            InspectorId = model.InspectorId,
            UpdatedAt = model.UpdatedAt,
            VerificationCompletedOn = model.VerificationCompletedOn,
            VerificationResultContent = model.VerificationResultContent,
            VerificationResultDetails = model.VerificationResultDetails?.Select(x => x.Id).ToList(),
            VerificationResultRecordDate = model.VerificationResultRecordDate,
        };
    }

    public static VerificationResultDbModel ToModel(
        this VerificationResultUpdateInput updateDto,
        VerificationResultWhereUniqueInput uniqueId
    )
    {
        var verificationResult = new VerificationResultDbModel
        {
            Id = uniqueId.Id,
            DateAndTimeOfFinalModification = updateDto.DateAndTimeOfFinalModification,
            DateAndTimeOfInitialRecord = updateDto.DateAndTimeOfInitialRecord,
            DeletedOn = updateDto.DeletedOn,
            FinalModifierId = updateDto.FinalModifierId,
            InitialRecorderId = updateDto.InitialRecorderId,
            InspectorId = updateDto.InspectorId,
            VerificationCompletedOn = updateDto.VerificationCompletedOn,
            VerificationResultContent = updateDto.VerificationResultContent,
            VerificationResultRecordDate = updateDto.VerificationResultRecordDate
        };

        if (updateDto.CommonVerification != null)
        {
            verificationResult.CommonVerificationId = updateDto.CommonVerification;
        }
        if (updateDto.CreatedAt != null)
        {
            verificationResult.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.UpdatedAt != null)
        {
            verificationResult.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return verificationResult;
    }
}
