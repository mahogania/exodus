using Control.APIs.Dtos;
using Control.Infrastructure.Models;

namespace Control.APIs.Extensions;

public static class RequestForCancellationOfTheDetailedDeclarationCustomsItemsExtensions
{
    public static RequestForCancellationOfTheDetailedDeclarationCustoms ToDto(
        this RequestForCancellationOfTheDetailedDeclarationCustomsDbModel model
    )
    {
        return new RequestForCancellationOfTheDetailedDeclarationCustoms
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
            SuppressionOn = model.SuppressionOn,
            UpdatedAt = model.UpdatedAt
        };
    }

    public static RequestForCancellationOfTheDetailedDeclarationCustomsDbModel ToModel(
        this RequestForCancellationOfTheDetailedDeclarationCustomsUpdateInput updateDto,
        RequestForCancellationOfTheDetailedDeclarationCustomsWhereUniqueInput uniqueId
    )
    {
        var requestForCancellationOfTheDetailedDeclarationCustoms =
            new RequestForCancellationOfTheDetailedDeclarationCustomsDbModel
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
            requestForCancellationOfTheDetailedDeclarationCustoms.CreatedAt = updateDto
                .CreatedAt
                .Value;
        if (updateDto.UpdatedAt != null)
            requestForCancellationOfTheDetailedDeclarationCustoms.UpdatedAt = updateDto
                .UpdatedAt
                .Value;

        return requestForCancellationOfTheDetailedDeclarationCustoms;
    }
}
