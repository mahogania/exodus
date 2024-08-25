using Code.APIs.Common;
using Code.APIs.Dtos;

namespace Code.APIs;

public interface ITarifGeneralsService
{
    /// <summary>
    /// Create one TarifGeneral
    /// </summary>
    public Task<TarifGeneral> CreateTarifGeneral(TarifGeneralCreateInput tarifgeneral);

    /// <summary>
    /// Delete one TarifGeneral
    /// </summary>
    public Task DeleteTarifGeneral(TarifGeneralWhereUniqueInput uniqueId);

    /// <summary>
    /// Find many TarifGenerals
    /// </summary>
    public Task<List<TarifGeneral>> TarifGenerals(TarifGeneralFindManyArgs findManyArgs);

    /// <summary>
    /// Meta data about TarifGeneral records
    /// </summary>
    public Task<MetadataDto> TarifGeneralsMeta(TarifGeneralFindManyArgs findManyArgs);

    /// <summary>
    /// Get one TarifGeneral
    /// </summary>
    public Task<TarifGeneral> TarifGeneral(TarifGeneralWhereUniqueInput uniqueId);

    /// <summary>
    /// Update one TarifGeneral
    /// </summary>
    public Task UpdateTarifGeneral(
        TarifGeneralWhereUniqueInput uniqueId,
        TarifGeneralUpdateInput updateDto
    );
}
