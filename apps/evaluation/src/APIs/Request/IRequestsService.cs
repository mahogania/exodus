using Evaluation.APIs.Common;
using Evaluation.APIs.Dtos;

namespace Evaluation.APIs;

public interface IRequestsService
{
    /// <summary>
    /// Create one Request
    /// </summary>
    public Task<Request> CreateRequest(RequestCreateInput request);

    /// <summary>
    /// Delete one Request
    /// </summary>
    public Task DeleteRequest(RequestWhereUniqueInput uniqueId);

    /// <summary>
    /// Find many Requests
    /// </summary>
    public Task<List<Request>> Requests(RequestFindManyArgs findManyArgs);

    /// <summary>
    /// Meta data about Request records
    /// </summary>
    public Task<MetadataDto> RequestsMeta(RequestFindManyArgs findManyArgs);

    /// <summary>
    /// Get one Request
    /// </summary>
    public Task<Request> Request(RequestWhereUniqueInput uniqueId);

    /// <summary>
    /// Update one Request
    /// </summary>
    public Task UpdateRequest(RequestWhereUniqueInput uniqueId, RequestUpdateInput updateDto);
}
