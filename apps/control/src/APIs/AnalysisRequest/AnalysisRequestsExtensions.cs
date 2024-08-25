using Control.APIs.Dtos;
using Control.Infrastructure.Models;

namespace Control.APIs.Extensions;

public static class AnalysisRequestsExtensions
{
    public static AnalysisRequest ToDto(this AnalysisRequestDbModel model)
    {
        return new AnalysisRequest
        {
            AnalysisExpertiseRequestNumber = model.AnalysisExpertiseRequestNumber,
            ArticleNumber = model.ArticleNumber,
            AttachedFileId = model.AttachedFileId,
            ControlInstitutionName = model.ControlInstitutionName,
            ControlProcessingDateTime = model.ControlProcessingDateTime,
            CreatedAt = model.CreatedAt,
            DetailedDeclarationNumber = model.DetailedDeclarationNumber,
            Id = model.Id,
            InspectorName = model.InspectorName,
            NotificationOn = model.NotificationOn,
            Procedure = model.ProcedureId,
            ProcessingStatusCode = model.ProcessingStatusCode,
            RequestContents = model.RequestContents,
            RequestDate = model.RequestDate,
            RequestTypeCode = model.RequestTypeCode,
            RequesterId = model.RequesterId,
            SampleRequests = model.SampleRequests?.ToDto(),
            SealNumber = model.SealNumber,
            UpdatedAt = model.UpdatedAt,
            VerificationResultCode = model.VerificationResultCode,
            VerificationResultContents = model.VerificationResultContents,
        };
    }

    public static AnalysisRequestDbModel ToModel(
        this AnalysisRequestUpdateInput updateDto,
        AnalysisRequestWhereUniqueInput uniqueId
    )
    {
        var analysisRequest = new AnalysisRequestDbModel
        {
            Id = uniqueId.Id,
            AnalysisExpertiseRequestNumber = updateDto.AnalysisExpertiseRequestNumber,
            ArticleNumber = updateDto.ArticleNumber,
            AttachedFileId = updateDto.AttachedFileId,
            ControlInstitutionName = updateDto.ControlInstitutionName,
            ControlProcessingDateTime = updateDto.ControlProcessingDateTime,
            DetailedDeclarationNumber = updateDto.DetailedDeclarationNumber,
            InspectorName = updateDto.InspectorName,
            NotificationOn = updateDto.NotificationOn,
            ProcessingStatusCode = updateDto.ProcessingStatusCode,
            RequestContents = updateDto.RequestContents,
            RequestDate = updateDto.RequestDate,
            RequestTypeCode = updateDto.RequestTypeCode,
            RequesterId = updateDto.RequesterId,
            SealNumber = updateDto.SealNumber,
            VerificationResultCode = updateDto.VerificationResultCode,
            VerificationResultContents = updateDto.VerificationResultContents
        };

        if (updateDto.CreatedAt != null)
        {
            analysisRequest.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.Procedure != null)
        {
            analysisRequest.ProcedureId = updateDto.Procedure;
        }
        if (updateDto.UpdatedAt != null)
        {
            analysisRequest.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return analysisRequest;
    }
}
