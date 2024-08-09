using Collection.APIs.Common;
using Collection.APIs.Dtos;

namespace Collection.APIs;

public interface IVariousRequestsService
{
    /// <summary>
    /// Create one VARIOUS REQUEST
    /// </summary>
    public Task<VariousRequest> CreateVariousRequest(VariousRequestCreateInput variousrequest);

    /// <summary>
    /// Delete one VARIOUS REQUEST
    /// </summary>
    public Task DeleteVariousRequest(VariousRequestWhereUniqueInput uniqueId);

    /// <summary>
    /// Find many VARIOUS REQUESTS
    /// </summary>
    public Task<List<VariousRequest>> VariousRequests(VariousRequestFindManyArgs findManyArgs);

    /// <summary>
    /// Meta data about VARIOUS REQUEST records
    /// </summary>
    public Task<MetadataDto> VariousRequestsMeta(VariousRequestFindManyArgs findManyArgs);

    /// <summary>
    /// Get one VARIOUS REQUEST
    /// </summary>
    public Task<VariousRequest> VariousRequest(VariousRequestWhereUniqueInput uniqueId);

    /// <summary>
    /// Update one VARIOUS REQUEST
    /// </summary>
    public Task UpdateVariousRequest(
        VariousRequestWhereUniqueInput uniqueId,
        VariousRequestUpdateInput updateDto
    );
}
