using Collection.APIs.Common;
using Collection.APIs.Dtos;

namespace Collection.APIs;

public interface IDistributionsService
{
    /// <summary>
    ///     Create one DISTRIBUTION
    /// </summary>
    public Task<Distribution> CreateDistribution(DistributionCreateInput distribution);

    /// <summary>
    ///     Delete one DISTRIBUTION
    /// </summary>
    public Task DeleteDistribution(DistributionWhereUniqueInput uniqueId);

    /// <summary>
    ///     Find many DISTRIBUTIONS
    /// </summary>
    public Task<List<Distribution>> Distributions(DistributionFindManyArgs findManyArgs);

    /// <summary>
    ///     Meta data about DISTRIBUTION records
    /// </summary>
    public Task<MetadataDto> DistributionsMeta(DistributionFindManyArgs findManyArgs);

    /// <summary>
    ///     Get one DISTRIBUTION
    /// </summary>
    public Task<Distribution> Distribution(DistributionWhereUniqueInput uniqueId);

    /// <summary>
    ///     Update one DISTRIBUTION
    /// </summary>
    public Task UpdateDistribution(
        DistributionWhereUniqueInput uniqueId,
        DistributionUpdateInput updateDto
    );
}
