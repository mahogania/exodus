using Clre.APIs.Dtos;
using Clre.Infrastructure.Models;

namespace Clre.APIs.Extensions;

public static class ForeignOperatorRequestsExtensions
{
    public static ForeignOperatorRequest ToDto(this ForeignOperatorRequestDbModel model)
    {
        return new ForeignOperatorRequest
        {
            CreatedAt = model.CreatedAt,
            DateAndTimeOfFinalModification = model.DateAndTimeOfFinalModification,
            DateAndTimeOfFirstRegistration = model.DateAndTimeOfFirstRegistration,
            DeletionOn = model.DeletionOn,
            FinalModifierSId = model.FinalModifierSId,
            FirstRecorderSId = model.FirstRecorderSId,
            ForeignOperatorAddress = model.ForeignOperatorAddress,
            ForeignOperatorCityCode = model.ForeignOperatorCityCode,
            ForeignOperatorCode = model.ForeignOperatorCode,
            ForeignOperatorCompanyName = model.ForeignOperatorCompanyName,
            ForeignOperatorCountryCode = model.ForeignOperatorCountryCode,
            ForeignOperatorEmail = model.ForeignOperatorEmail,
            ForeignOperatorPhoneNumber = model.ForeignOperatorPhoneNumber,
            ForeignOperatorRepresentativeName = model.ForeignOperatorRepresentativeName,
            ForeignOperatorRequestNumber = model.ForeignOperatorRequestNumber,
            Id = model.Id,
            ProcessingDate = model.ProcessingDate,
            ProcessingStatusCode = model.ProcessingStatusCode,
            RequestDate = model.RequestDate,
            RequestReasonContent = model.RequestReasonContent,
            RequestTypeCode = model.RequestTypeCode,
            RequestingPersonId = model.RequestingPersonId,
            UpdatedAt = model.UpdatedAt,
            VerificationOpinionContent = model.VerificationOpinionContent,
        };
    }

    public static ForeignOperatorRequestDbModel ToModel(
        this ForeignOperatorRequestUpdateInput updateDto,
        ForeignOperatorRequestWhereUniqueInput uniqueId
    )
    {
        var foreignOperatorRequest = new ForeignOperatorRequestDbModel
        {
            Id = uniqueId.Id,
            DateAndTimeOfFinalModification = updateDto.DateAndTimeOfFinalModification,
            DateAndTimeOfFirstRegistration = updateDto.DateAndTimeOfFirstRegistration,
            DeletionOn = updateDto.DeletionOn,
            FinalModifierSId = updateDto.FinalModifierSId,
            FirstRecorderSId = updateDto.FirstRecorderSId,
            ForeignOperatorAddress = updateDto.ForeignOperatorAddress,
            ForeignOperatorCityCode = updateDto.ForeignOperatorCityCode,
            ForeignOperatorCode = updateDto.ForeignOperatorCode,
            ForeignOperatorCompanyName = updateDto.ForeignOperatorCompanyName,
            ForeignOperatorCountryCode = updateDto.ForeignOperatorCountryCode,
            ForeignOperatorEmail = updateDto.ForeignOperatorEmail,
            ForeignOperatorPhoneNumber = updateDto.ForeignOperatorPhoneNumber,
            ForeignOperatorRepresentativeName = updateDto.ForeignOperatorRepresentativeName,
            ForeignOperatorRequestNumber = updateDto.ForeignOperatorRequestNumber,
            ProcessingDate = updateDto.ProcessingDate,
            ProcessingStatusCode = updateDto.ProcessingStatusCode,
            RequestDate = updateDto.RequestDate,
            RequestReasonContent = updateDto.RequestReasonContent,
            RequestTypeCode = updateDto.RequestTypeCode,
            RequestingPersonId = updateDto.RequestingPersonId,
            VerificationOpinionContent = updateDto.VerificationOpinionContent
        };

        if (updateDto.CreatedAt != null)
        {
            foreignOperatorRequest.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.UpdatedAt != null)
        {
            foreignOperatorRequest.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return foreignOperatorRequest;
    }
}
