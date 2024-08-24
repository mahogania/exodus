using Control.APIs.Common;
using Control.APIs.Dtos;

namespace Control.APIs;

public interface IRcoDemandsService
{
    /// <summary>
    /// Create one RCO Demand
    /// </summary>
    public Task<RCODemand> CreateRcoDemand(RCODemandCreateInput rcodemand);

    /// <summary>
    /// Delete one RCO Demand
    /// </summary>
    public Task DeleteRcoDemand(RCODemandWhereUniqueInput uniqueId);

    /// <summary>
    /// Find many Demand for RCO | CLRES
    /// </summary>
    public Task<List<RCODemand>> RcoDemands(RCODemandFindManyArgs findManyArgs);

    /// <summary>
    /// Meta data about RCO Demand records
    /// </summary>
    public Task<MetadataDto> RcoDemandsMeta(RCODemandFindManyArgs findManyArgs);

    /// <summary>
    /// Get one RCO Demand
    /// </summary>
    public Task<RCODemand> RcoDemand(RCODemandWhereUniqueInput uniqueId);

    /// <summary>
    /// Update one RCO Demand
    /// </summary>
    public Task UpdateRcoDemand(RCODemandWhereUniqueInput uniqueId, RCODemandUpdateInput updateDto);
}
