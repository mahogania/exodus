using Collection.APIs.Common;
using Collection.APIs.Dtos;

namespace Collection.APIs;

public interface ICautionsService
{
    /// <summary>
    ///     Create one CAUTION
    /// </summary>
    public Task<Caution> CreateCaution(CautionCreateInput caution);

    /// <summary>
    ///     Delete one CAUTION
    /// </summary>
    public Task DeleteCaution(CautionWhereUniqueInput uniqueId);

    /// <summary>
    ///     Find many CAUTIONS
    /// </summary>
    public Task<List<Caution>> Cautions(CautionFindManyArgs findManyArgs);

    /// <summary>
    ///     Meta data about CAUTION records
    /// </summary>
    public Task<MetadataDto> CautionsMeta(CautionFindManyArgs findManyArgs);

    /// <summary>
    ///     Get one CAUTION
    /// </summary>
    public Task<Caution> Caution(CautionWhereUniqueInput uniqueId);

    /// <summary>
    ///     Update one CAUTION
    /// </summary>
    public Task UpdateCaution(CautionWhereUniqueInput uniqueId, CautionUpdateInput updateDto);
}
