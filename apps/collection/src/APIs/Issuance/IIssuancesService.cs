using Collection.APIs.Common;
using Collection.APIs.Dtos;

namespace Collection.APIs;

public interface IIssuancesService
{
    /// <summary>
    /// Create one ISSUANCE
    /// </summary>
    public Task<Issuance> CreateIssuance(IssuanceCreateInput issuance);

    /// <summary>
    /// Delete one ISSUANCE
    /// </summary>
    public Task DeleteIssuance(IssuanceWhereUniqueInput uniqueId);

    /// <summary>
    /// Find many ISSUANCES
    /// </summary>
    public Task<List<Issuance>> Issuances(IssuanceFindManyArgs findManyArgs);

    /// <summary>
    /// Meta data about ISSUANCE records
    /// </summary>
    public Task<MetadataDto> IssuancesMeta(IssuanceFindManyArgs findManyArgs);

    /// <summary>
    /// Get one ISSUANCE
    /// </summary>
    public Task<Issuance> Issuance(IssuanceWhereUniqueInput uniqueId);

    /// <summary>
    /// Update one ISSUANCE
    /// </summary>
    public Task UpdateIssuance(IssuanceWhereUniqueInput uniqueId, IssuanceUpdateInput updateDto);
}
