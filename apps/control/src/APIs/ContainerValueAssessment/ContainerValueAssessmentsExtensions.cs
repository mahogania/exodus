using Control.APIs.Dtos;
using Control.Infrastructure.Models;

namespace Control.APIs.Extensions;

public static class ContainerValueAssessmentsExtensions
{
    public static ContainerValueAssessment ToDto(this ContainerValueAssessmentDbModel model)
    {
        return new ContainerValueAssessment
        {
            CommonVerification = model.CommonVerificationId,
            ContainerNumber = model.ContainerNumber,
            ContainerSequenceNumber = model.ContainerSequenceNumber,
            ContainerStuffingStateCode = model.ContainerStuffingStateCode,
            ContainerTypeCode = model.ContainerTypeCode,
            CreatedAt = model.CreatedAt,
            DateAndTimeOfFinalModification = model.DateAndTimeOfFinalModification,
            DateAndTimeOfInitialRecord = model.DateAndTimeOfInitialRecord,
            DeletedOn = model.DeletedOn,
            FinalModifierId = model.FinalModifierId,
            Id = model.Id,
            InitialRecorderId = model.InitialRecorderId,
            SealNumber1 = model.SealNumber1,
            SealNumber2_24310 = model.SealNumber2_24310,
            SealNumber3 = model.SealNumber3,
            SealingPersonCode = model.SealingPersonCode,
            UpdatedAt = model.UpdatedAt,
        };
    }

    public static ContainerValueAssessmentDbModel ToModel(
        this ContainerValueAssessmentUpdateInput updateDto,
        ContainerValueAssessmentWhereUniqueInput uniqueId
    )
    {
        var containerValueAssessment = new ContainerValueAssessmentDbModel
        {
            Id = uniqueId.Id,
            ContainerNumber = updateDto.ContainerNumber,
            ContainerSequenceNumber = updateDto.ContainerSequenceNumber,
            ContainerStuffingStateCode = updateDto.ContainerStuffingStateCode,
            ContainerTypeCode = updateDto.ContainerTypeCode,
            DateAndTimeOfFinalModification = updateDto.DateAndTimeOfFinalModification,
            DateAndTimeOfInitialRecord = updateDto.DateAndTimeOfInitialRecord,
            DeletedOn = updateDto.DeletedOn,
            FinalModifierId = updateDto.FinalModifierId,
            InitialRecorderId = updateDto.InitialRecorderId,
            SealNumber1 = updateDto.SealNumber1,
            SealNumber2_24310 = updateDto.SealNumber2_24310,
            SealNumber3 = updateDto.SealNumber3,
            SealingPersonCode = updateDto.SealingPersonCode
        };

        if (updateDto.CommonVerification != null)
        {
            containerValueAssessment.CommonVerificationId = updateDto.CommonVerification;
        }
        if (updateDto.CreatedAt != null)
        {
            containerValueAssessment.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.UpdatedAt != null)
        {
            containerValueAssessment.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return containerValueAssessment;
    }
}
