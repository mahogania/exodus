using Collection.APIs.Common;
using Collection.APIs.Dtos;

namespace Collection.APIs;

public interface IFineRequestsService
{
    /// <summary>
    ///     Create one FINE REQUEST
    /// </summary>
    public Task<FineRequest> CreateFineRequest(FineRequestCreateInput finerequest);

    /// <summary>
    ///     Delete one FINE REQUEST
    /// </summary>
    public Task DeleteFineRequest(FineRequestWhereUniqueInput uniqueId);

    /// <summary>
    ///     Find many FINE REQUESTS
    /// </summary>
    public Task<List<FineRequest>> FineRequests(FineRequestFindManyArgs findManyArgs);

    /// <summary>
    ///     Meta data about FINE REQUEST records
    /// </summary>
    public Task<MetadataDto> FineRequestsMeta(FineRequestFindManyArgs findManyArgs);

    /// <summary>
    ///     Get one FINE REQUEST
    /// </summary>
    public Task<FineRequest> FineRequest(FineRequestWhereUniqueInput uniqueId);

    /// <summary>
    ///     Update one FINE REQUEST
    /// </summary>
    public Task UpdateFineRequest(
        FineRequestWhereUniqueInput uniqueId,
        FineRequestUpdateInput updateDto
    );
}
