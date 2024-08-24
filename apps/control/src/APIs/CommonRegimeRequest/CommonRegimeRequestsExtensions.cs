using Control.APIs.Dtos;
using Control.Infrastructure.Models;

namespace Control.APIs.Extensions;

public static class CommonRegimeRequestsExtensions
{
    public static CommonRegimeRequest ToDto(this CommonRegimeRequestDbModel model)
    {
        return new CommonRegimeRequest
        {
            ApcCode = model.ApcCode,
            AttachedFileId = model.AttachedFileId,
            ComplementaryRequestContent = model.ComplementaryRequestContent,
            ComplementaryRequestResponseContent = model.ComplementaryRequestResponseContent,
            CreatedAt = model.CreatedAt,
            CustomsOfficeCode = model.CustomsOfficeCode,
            DateAndTimeOfFinalModification = model.DateAndTimeOfFinalModification,
            DateAndTimeOfFirstRegistration = model.DateAndTimeOfFirstRegistration,
            DeclarantCode = model.DeclarantCode,
            DeletionOn = model.DeletionOn,
            DocumentCode = model.DocumentCode,
            EpcCode = model.EpcCode,
            FinalModifierSId = model.FinalModifierSId,
            FinalOn = model.FinalOn,
            FirstRecorderSId = model.FirstRecorderSId,
            Id = model.Id,
            Journal = model.JournalId,
            ProcessingStatusCode = model.ProcessingStatusCode,
            RectificationFrequency = model.RectificationFrequency,
            RegimeRequestContent = model.RegimeRequestContent,
            RegimeRequestNumber = model.RegimeRequestNumber,
            RegimeRequestTitle = model.RegimeRequestTitle,
            RegimeValidationDate = model.RegimeValidationDate,
            RequestDate = model.RequestDate,
            UpdatedAt = model.UpdatedAt,
        };
    }

    public static CommonRegimeRequestDbModel ToModel(
        this CommonRegimeRequestUpdateInput updateDto,
        CommonRegimeRequestWhereUniqueInput uniqueId
    )
    {
        var commonRegimeRequest = new CommonRegimeRequestDbModel
        {
            Id = uniqueId.Id,
            ApcCode = updateDto.ApcCode,
            AttachedFileId = updateDto.AttachedFileId,
            ComplementaryRequestContent = updateDto.ComplementaryRequestContent,
            ComplementaryRequestResponseContent = updateDto.ComplementaryRequestResponseContent,
            CustomsOfficeCode = updateDto.CustomsOfficeCode,
            DateAndTimeOfFinalModification = updateDto.DateAndTimeOfFinalModification,
            DateAndTimeOfFirstRegistration = updateDto.DateAndTimeOfFirstRegistration,
            DeclarantCode = updateDto.DeclarantCode,
            DeletionOn = updateDto.DeletionOn,
            DocumentCode = updateDto.DocumentCode,
            EpcCode = updateDto.EpcCode,
            FinalModifierSId = updateDto.FinalModifierSId,
            FinalOn = updateDto.FinalOn,
            FirstRecorderSId = updateDto.FirstRecorderSId,
            ProcessingStatusCode = updateDto.ProcessingStatusCode,
            RectificationFrequency = updateDto.RectificationFrequency,
            RegimeRequestContent = updateDto.RegimeRequestContent,
            RegimeRequestNumber = updateDto.RegimeRequestNumber,
            RegimeRequestTitle = updateDto.RegimeRequestTitle,
            RegimeValidationDate = updateDto.RegimeValidationDate,
            RequestDate = updateDto.RequestDate
        };

        if (updateDto.CreatedAt != null)
        {
            commonRegimeRequest.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.Journal != null)
        {
            commonRegimeRequest.JournalId = updateDto.Journal;
        }
        if (updateDto.UpdatedAt != null)
        {
            commonRegimeRequest.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return commonRegimeRequest;
    }
}
