using Control.APIs.Common;
using Control.APIs.Dtos;

namespace Control.APIs;

public interface IAnalysisRequestsService
{
    /// <summary>
    /// Create one Analysis Request
    /// </summary>
    public Task<AnalysisRequest> CreateAnalysisRequest(AnalysisRequestCreateInput analysisrequest);

    /// <summary>
    /// Delete one Analysis Request
    /// </summary>
    public Task DeleteAnalysisRequest(AnalysisRequestWhereUniqueInput uniqueId);

    /// <summary>
    /// Find many Analysis Requests
    /// </summary>
    public Task<List<AnalysisRequest>> AnalysisRequests(AnalysisRequestFindManyArgs findManyArgs);

    /// <summary>
    /// Meta data about Analysis Request records
    /// </summary>
    public Task<MetadataDto> AnalysisRequestsMeta(AnalysisRequestFindManyArgs findManyArgs);

    /// <summary>
    /// Get one Analysis Request
    /// </summary>
    public Task<AnalysisRequest> AnalysisRequest(AnalysisRequestWhereUniqueInput uniqueId);

    /// <summary>
    /// Update one Analysis Request
    /// </summary>
    public Task UpdateAnalysisRequest(
        AnalysisRequestWhereUniqueInput uniqueId,
        AnalysisRequestUpdateInput updateDto
    );

    /// <summary>
    /// Get a Procedure record for Analysis Request
    /// </summary>
    public Task<Procedure> GetProcedure(AnalysisRequestWhereUniqueInput uniqueId);

    /// <summary>
    /// Get a Sample Requests record for Analysis Request
    /// </summary>
    public Task<SampleRequest> GetSampleRequests(AnalysisRequestWhereUniqueInput uniqueId);
}
