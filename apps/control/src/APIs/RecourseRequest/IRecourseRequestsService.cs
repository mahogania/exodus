using Control.APIs.Common;
using Control.APIs.Dtos;

namespace Control.APIs;

public interface IRecourseRequestsService
{
    /// <summary>
    /// Create one Recourse Request
    /// </summary>
    public Task<RecourseRequest> CreateRecourseRequest(RecourseRequestCreateInput recourserequest);

    /// <summary>
    /// Delete one Recourse Request
    /// </summary>
    public Task DeleteRecourseRequest(RecourseRequestWhereUniqueInput uniqueId);

    /// <summary>
    /// Find many REQUEST FOR RECOURSES
    /// </summary>
    public Task<List<RecourseRequest>> RecourseRequests(RecourseRequestFindManyArgs findManyArgs);

    /// <summary>
    /// Meta data about Recourse Request records
    /// </summary>
    public Task<MetadataDto> RecourseRequestsMeta(RecourseRequestFindManyArgs findManyArgs);

    /// <summary>
    /// Get one Recourse Request
    /// </summary>
    public Task<RecourseRequest> RecourseRequest(RecourseRequestWhereUniqueInput uniqueId);

    /// <summary>
    /// Update one Recourse Request
    /// </summary>
    public Task UpdateRecourseRequest(
        RecourseRequestWhereUniqueInput uniqueId,
        RecourseRequestUpdateInput updateDto
    );

    /// <summary>
    /// Get a Journal record for Recourse Request
    /// </summary>
    public Task<Procedure> GetJournal(RecourseRequestWhereUniqueInput uniqueId);
}
