using Collection.APIs.Common;
using Collection.APIs.Dtos;

namespace Collection.APIs;

public interface IFineRequestHistoriesService
{
    /// <summary>
    /// Create one FINE REQUEST HISTORY
    /// </summary>
    public Task<FineRequestHistory> CreateFineRequestHistory(
        FineRequestHistoryCreateInput finerequesthistory
    );

    /// <summary>
    /// Delete one FINE REQUEST HISTORY
    /// </summary>
    public Task DeleteFineRequestHistory(FineRequestHistoryWhereUniqueInput uniqueId);

    /// <summary>
    /// Find many FINE REQUEST HISTORIES
    /// </summary>
    public Task<List<FineRequestHistory>> FineRequestHistories(
        FineRequestHistoryFindManyArgs findManyArgs
    );

    /// <summary>
    /// Meta data about FINE REQUEST HISTORY records
    /// </summary>
    public Task<MetadataDto> FineRequestHistoriesMeta(FineRequestHistoryFindManyArgs findManyArgs);

    /// <summary>
    /// Get one FINE REQUEST HISTORY
    /// </summary>
    public Task<FineRequestHistory> FineRequestHistory(FineRequestHistoryWhereUniqueInput uniqueId);

    /// <summary>
    /// Update one FINE REQUEST HISTORY
    /// </summary>
    public Task UpdateFineRequestHistory(
        FineRequestHistoryWhereUniqueInput uniqueId,
        FineRequestHistoryUpdateInput updateDto
    );
}
