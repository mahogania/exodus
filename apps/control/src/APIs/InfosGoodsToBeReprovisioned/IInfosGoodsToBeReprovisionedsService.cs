using Control.APIs.Common;
using Control.APIs.Dtos;

namespace Control.APIs;

public interface IInfosGoodsToBeReprovisionedsService
{
    /// <summary>
    /// Create one INFOS GOODS TO BE REPROVISIONED
    /// </summary>
    public Task<InfosGoodsToBeReprovisioned> CreateInfosGoodsToBeReprovisioned(
        InfosGoodsToBeReprovisionedCreateInput infosgoodstobereprovisioned
    );

    /// <summary>
    /// Delete one INFOS GOODS TO BE REPROVISIONED
    /// </summary>
    public Task DeleteInfosGoodsToBeReprovisioned(
        InfosGoodsToBeReprovisionedWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Find many INFOS GOODS TO BE REPROVISIONEDS
    /// </summary>
    public Task<List<InfosGoodsToBeReprovisioned>> InfosGoodsToBeReprovisioneds(
        InfosGoodsToBeReprovisionedFindManyArgs findManyArgs
    );

    /// <summary>
    /// Meta data about INFOS GOODS TO BE REPROVISIONED records
    /// </summary>
    public Task<MetadataDto> InfosGoodsToBeReprovisionedsMeta(
        InfosGoodsToBeReprovisionedFindManyArgs findManyArgs
    );

    /// <summary>
    /// Get one INFOS GOODS TO BE REPROVISIONED
    /// </summary>
    public Task<InfosGoodsToBeReprovisioned> InfosGoodsToBeReprovisioned(
        InfosGoodsToBeReprovisionedWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Update one INFOS GOODS TO BE REPROVISIONED
    /// </summary>
    public Task UpdateInfosGoodsToBeReprovisioned(
        InfosGoodsToBeReprovisionedWhereUniqueInput uniqueId,
        InfosGoodsToBeReprovisionedUpdateInput updateDto
    );
}
