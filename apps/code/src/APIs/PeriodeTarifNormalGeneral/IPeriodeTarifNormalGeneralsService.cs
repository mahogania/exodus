using Code.APIs.Common;
using Code.APIs.Dtos;

namespace Code.APIs;

public interface IPeriodeTarifNormalGeneralsService
{
    /// <summary>
    /// Create one PeriodeTarifNormalGeneral
    /// </summary>
    public Task<PeriodeTarifNormalGeneral> CreatePeriodeTarifNormalGeneral(
        PeriodeTarifNormalGeneralCreateInput periodetarifnormalgeneral
    );

    /// <summary>
    /// Delete one PeriodeTarifNormalGeneral
    /// </summary>
    public Task DeletePeriodeTarifNormalGeneral(PeriodeTarifNormalGeneralWhereUniqueInput uniqueId);

    /// <summary>
    /// Find many PeriodeTarifNormalGenerals
    /// </summary>
    public Task<List<PeriodeTarifNormalGeneral>> PeriodeTarifNormalGenerals(
        PeriodeTarifNormalGeneralFindManyArgs findManyArgs
    );

    /// <summary>
    /// Meta data about PeriodeTarifNormalGeneral records
    /// </summary>
    public Task<MetadataDto> PeriodeTarifNormalGeneralsMeta(
        PeriodeTarifNormalGeneralFindManyArgs findManyArgs
    );

    /// <summary>
    /// Get one PeriodeTarifNormalGeneral
    /// </summary>
    public Task<PeriodeTarifNormalGeneral> PeriodeTarifNormalGeneral(
        PeriodeTarifNormalGeneralWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Update one PeriodeTarifNormalGeneral
    /// </summary>
    public Task UpdatePeriodeTarifNormalGeneral(
        PeriodeTarifNormalGeneralWhereUniqueInput uniqueId,
        PeriodeTarifNormalGeneralUpdateInput updateDto
    );
}
