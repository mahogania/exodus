using Control.APIs.Dtos;
using Control.Infrastructure.Models;

namespace Control.APIs.Extensions;

public static class VerificationResultDetailsExtensions
{
    public static VerificationResultDetail ToDto(this VerificationResultDetailDbModel model)
    {
        return new VerificationResultDetail
        {
            AlignmentOrder = model.AlignmentOrder,
            CreatedAt = model.CreatedAt,
            DateAndTimeOfFinalModification = model.DateAndTimeOfFinalModification,
            DateAndTimeOfInitialRecord = model.DateAndTimeOfInitialRecord,
            DeletedOn = model.DeletedOn,
            FinalModifierId = model.FinalModifierId,
            Id = model.Id,
            InitialRecorderId = model.InitialRecorderId,
            UpdatedAt = model.UpdatedAt,
            VerificationResult = model.VerificationResultId,
            VerificationResultCode = model.VerificationResultCode,
        };
    }

    public static VerificationResultDetailDbModel ToModel(
        this VerificationResultDetailUpdateInput updateDto,
        VerificationResultDetailWhereUniqueInput uniqueId
    )
    {
        var verificationResultDetail = new VerificationResultDetailDbModel
        {
            Id = uniqueId.Id,
            AlignmentOrder = updateDto.AlignmentOrder,
            DateAndTimeOfFinalModification = updateDto.DateAndTimeOfFinalModification,
            DateAndTimeOfInitialRecord = updateDto.DateAndTimeOfInitialRecord,
            DeletedOn = updateDto.DeletedOn,
            FinalModifierId = updateDto.FinalModifierId,
            InitialRecorderId = updateDto.InitialRecorderId,
            VerificationResultCode = updateDto.VerificationResultCode
        };

        if (updateDto.CreatedAt != null)
        {
            verificationResultDetail.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.UpdatedAt != null)
        {
            verificationResultDetail.UpdatedAt = updateDto.UpdatedAt.Value;
        }
        if (updateDto.VerificationResult != null)
        {
            verificationResultDetail.VerificationResultId = updateDto.VerificationResult;
        }

        return verificationResultDetail;
    }
}
