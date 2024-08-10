using Collection.APIs.Common;
using Collection.APIs.Dtos;

namespace Collection.APIs;

public interface IFinesService
{
    /// <summary>
    ///     Create one FINE
    /// </summary>
    public Task<Fine> CreateFine(FineCreateInput fine);

    /// <summary>
    ///     Delete one FINE
    /// </summary>
    public Task DeleteFine(FineWhereUniqueInput uniqueId);

    /// <summary>
    ///     Find many FINES
    /// </summary>
    public Task<List<Fine>> Fines(FineFindManyArgs findManyArgs);

    /// <summary>
    ///     Meta data about FINE records
    /// </summary>
    public Task<MetadataDto> FinesMeta(FineFindManyArgs findManyArgs);

    /// <summary>
    ///     Get one FINE
    /// </summary>
    public Task<Fine> Fine(FineWhereUniqueInput uniqueId);

    /// <summary>
    ///     Update one FINE
    /// </summary>
    public Task UpdateFine(FineWhereUniqueInput uniqueId, FineUpdateInput updateDto);
}
