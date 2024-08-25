using Control.APIs.Common;
using Control.APIs.Dtos;

namespace Control.APIs;

public interface ISampleRequestsService
{
    /// <summary>
    /// Create one Sample Request
    /// </summary>
    public Task<SampleRequest> CreateSampleRequest(SampleRequestCreateInput samplerequest);

    /// <summary>
    /// Delete one Sample Request
    /// </summary>
    public Task DeleteSampleRequest(SampleRequestWhereUniqueInput uniqueId);

    /// <summary>
    /// Find many Sample Requests
    /// </summary>
    public Task<List<SampleRequest>> SampleRequests(SampleRequestFindManyArgs findManyArgs);

    /// <summary>
    /// Meta data about Sample Request records
    /// </summary>
    public Task<MetadataDto> SampleRequestsMeta(SampleRequestFindManyArgs findManyArgs);

    /// <summary>
    /// Get one Sample Request
    /// </summary>
    public Task<SampleRequest> SampleRequest(SampleRequestWhereUniqueInput uniqueId);

    /// <summary>
    /// Update one Sample Request
    /// </summary>
    public Task UpdateSampleRequest(
        SampleRequestWhereUniqueInput uniqueId,
        SampleRequestUpdateInput updateDto
    );

    /// <summary>
    /// Get a Analysis Request record for Sample Request
    /// </summary>
    public Task<AnalysisRequest> GetAnalysisRequest(SampleRequestWhereUniqueInput uniqueId);

    /// <summary>
    /// Get a article record for Sample Request
    /// </summary>
    public Task<Article> GetArticle(SampleRequestWhereUniqueInput uniqueId);
}
