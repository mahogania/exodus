using Fret.APIs.Common;
using Fret.APIs.Dtos;

namespace Fret.APIs;

public interface ITrainsService
{
    /// <summary>
    /// Create one Train
    /// </summary>
    public Task<Train> CreateTrain(TrainCreateInput train);

    /// <summary>
    /// Delete one Train
    /// </summary>
    public Task DeleteTrain(TrainWhereUniqueInput uniqueId);

    /// <summary>
    /// Find many Trains
    /// </summary>
    public Task<List<Train>> Trains(TrainFindManyArgs findManyArgs);

    /// <summary>
    /// Meta data about Train records
    /// </summary>
    public Task<MetadataDto> TrainsMeta(TrainFindManyArgs findManyArgs);

    /// <summary>
    /// Get one Train
    /// </summary>
    public Task<Train> Train(TrainWhereUniqueInput uniqueId);

    /// <summary>
    /// Update one Train
    /// </summary>
    public Task UpdateTrain(TrainWhereUniqueInput uniqueId, TrainUpdateInput updateDto);
}
