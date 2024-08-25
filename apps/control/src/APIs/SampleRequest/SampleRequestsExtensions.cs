using Control.APIs.Dtos;
using Control.Infrastructure.Models;

namespace Control.APIs.Extensions;

public static class SampleRequestsExtensions
{
    public static SampleRequest ToDto(this SampleRequestDbModel model)
    {
        return new SampleRequest
        {
            AnalysisExpertiseRequestId = model.AnalysisExpertiseRequestId,
            AnalysisRequest = model.AnalysisRequestId,
            Article = model.ArticleId,
            ArticleName = model.ArticleName,
            CreatedAt = model.CreatedAt,
            DeclarantCode = model.DeclarantCode,
            DeclarantPresence = model.DeclarantPresence,
            DetailedDeclarationId = model.DetailedDeclarationId,
            Id = model.Id,
            Quantity = model.Quantity,
            RequestTypeId = model.RequestTypeId,
            RestitutedSampleQuantity = model.RestitutedSampleQuantity,
            RestitutedSampleWeight = model.RestitutedSampleWeight,
            SampleCollectionDate = model.SampleCollectionDate,
            SampleCollectionEndDate = model.SampleCollectionEndDate,
            SampleCollectionStartDate = model.SampleCollectionStartDate,
            SampleDescription = model.SampleDescription,
            SampleRequestDate = model.SampleRequestDate,
            SampleRestitution = model.SampleRestitution,
            SampleRestitutionConfirmation = model.SampleRestitutionConfirmation,
            SampleRestitutionDate = model.SampleRestitutionDate,
            SuspicionResultsContents = model.SuspicionResultsContents,
            UpdatedAt = model.UpdatedAt,
            Weight = model.Weight,
        };
    }

    public static SampleRequestDbModel ToModel(
        this SampleRequestUpdateInput updateDto,
        SampleRequestWhereUniqueInput uniqueId
    )
    {
        var sampleRequest = new SampleRequestDbModel
        {
            Id = uniqueId.Id,
            AnalysisExpertiseRequestId = updateDto.AnalysisExpertiseRequestId,
            ArticleName = updateDto.ArticleName,
            DeclarantCode = updateDto.DeclarantCode,
            DeclarantPresence = updateDto.DeclarantPresence,
            DetailedDeclarationId = updateDto.DetailedDeclarationId,
            Quantity = updateDto.Quantity,
            RequestTypeId = updateDto.RequestTypeId,
            RestitutedSampleQuantity = updateDto.RestitutedSampleQuantity,
            RestitutedSampleWeight = updateDto.RestitutedSampleWeight,
            SampleCollectionDate = updateDto.SampleCollectionDate,
            SampleCollectionEndDate = updateDto.SampleCollectionEndDate,
            SampleCollectionStartDate = updateDto.SampleCollectionStartDate,
            SampleDescription = updateDto.SampleDescription,
            SampleRequestDate = updateDto.SampleRequestDate,
            SampleRestitution = updateDto.SampleRestitution,
            SampleRestitutionConfirmation = updateDto.SampleRestitutionConfirmation,
            SampleRestitutionDate = updateDto.SampleRestitutionDate,
            SuspicionResultsContents = updateDto.SuspicionResultsContents,
            Weight = updateDto.Weight
        };

        if (updateDto.AnalysisRequest != null)
        {
            sampleRequest.AnalysisRequestId = updateDto.AnalysisRequest;
        }
        if (updateDto.Article != null)
        {
            sampleRequest.ArticleId = updateDto.Article;
        }
        if (updateDto.CreatedAt != null)
        {
            sampleRequest.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.UpdatedAt != null)
        {
            sampleRequest.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return sampleRequest;
    }
}
