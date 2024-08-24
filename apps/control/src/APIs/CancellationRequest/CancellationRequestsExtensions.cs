using Control.APIs.Dtos;
using Control.Infrastructure.Models;

namespace Control.APIs.Extensions;

public static class CancellationRequestsExtensions
{
    public static CancellationRequest ToDto(this CancellationRequestDbModel model)
    {
        return new CancellationRequest
        {
            CancellationContent = model.CancellationContent,
            CancellationReasonCode = model.CancellationReasonCode,
            CreatedAt = model.CreatedAt,
            DateAndTimeOfFinalModification = model.DateAndTimeOfFinalModification,
            DateAndTimeOfFirstRegistration = model.DateAndTimeOfFirstRegistration,
            DateOfRequestForCancellation = model.DateOfRequestForCancellation,
            FinalOn = model.FinalOn,
            FirstRegistrantSId = model.FirstRegistrantSId,
            Id = model.Id,
            IdOfTheAttachedFile = model.IdOfTheAttachedFile,
            NumberOfCancellations = model.NumberOfCancellations,
            ProcessingStatusCode = model.ProcessingStatusCode,
            ReferenceNumber = model.ReferenceNumber,
            Request = model.RequestId,
            SuppressionOn = model.SuppressionOn,
            UpdatedAt = model.UpdatedAt,
        };
    }

    public static CancellationRequestDbModel ToModel(
        this CancellationRequestUpdateInput updateDto,
        CancellationRequestWhereUniqueInput uniqueId
    )
    {
        var cancellationRequest = new CancellationRequestDbModel
        {
            Id = uniqueId.Id,
            CancellationContent = updateDto.CancellationContent,
            CancellationReasonCode = updateDto.CancellationReasonCode,
            DateAndTimeOfFinalModification = updateDto.DateAndTimeOfFinalModification,
            DateAndTimeOfFirstRegistration = updateDto.DateAndTimeOfFirstRegistration,
            DateOfRequestForCancellation = updateDto.DateOfRequestForCancellation,
            FinalOn = updateDto.FinalOn,
            FirstRegistrantSId = updateDto.FirstRegistrantSId,
            IdOfTheAttachedFile = updateDto.IdOfTheAttachedFile,
            NumberOfCancellations = updateDto.NumberOfCancellations,
            ProcessingStatusCode = updateDto.ProcessingStatusCode,
            ReferenceNumber = updateDto.ReferenceNumber,
            SuppressionOn = updateDto.SuppressionOn
        };

        if (updateDto.CreatedAt != null)
        {
            cancellationRequest.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.Request != null)
        {
            cancellationRequest.RequestId = updateDto.Request;
        }
        if (updateDto.UpdatedAt != null)
        {
            cancellationRequest.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return cancellationRequest;
    }
}
