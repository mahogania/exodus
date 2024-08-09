using Clre.APIs.Common;
using Clre.APIs.Dtos;

namespace Clre.APIs;

public interface IDemandForRcoClresService
{
    /// <summary>
    /// Create one Demand for RCO | CLRE
    /// </summary>
    public Task<DemandForRcoClre> CreateDemandForRcoClre(
        DemandForRcoClreCreateInput demandforrcoclre
    );

    /// <summary>
    /// Delete one Demand for RCO | CLRE
    /// </summary>
    public Task DeleteDemandForRcoClre(DemandForRcoClreWhereUniqueInput uniqueId);

    /// <summary>
    /// Find many Demand for RCO | CLRES
    /// </summary>
    public Task<List<DemandForRcoClre>> DemandForRcoClres(
        DemandForRcoClreFindManyArgs findManyArgs
    );

    /// <summary>
    /// Meta data about Demand for RCO | CLRE records
    /// </summary>
    public Task<MetadataDto> DemandForRcoClresMeta(DemandForRcoClreFindManyArgs findManyArgs);

    /// <summary>
    /// Get one Demand for RCO | CLRE
    /// </summary>
    public Task<DemandForRcoClre> DemandForRcoClre(DemandForRcoClreWhereUniqueInput uniqueId);

    /// <summary>
    /// Update one Demand for RCO | CLRE
    /// </summary>
    public Task UpdateDemandForRcoClre(
        DemandForRcoClreWhereUniqueInput uniqueId,
        DemandForRcoClreUpdateInput updateDto
    );
}
