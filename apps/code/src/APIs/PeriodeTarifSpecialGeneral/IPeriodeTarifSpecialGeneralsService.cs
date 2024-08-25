using Code.APIs.Common;
using Code.APIs.Dtos;

namespace Code.APIs;

public interface IPeriodeTarifSpecialGeneralsService
{
    /// <summary>
    /// Create one PeriodeTarifSpecialGeneral
    /// </summary>
    public Task<PeriodeTarifSpecialGeneral> CreatePeriodeTarifSpecialGeneral(
        PeriodeTarifSpecialGeneralCreateInput periodetarifspecialgeneral
    );

    /// <summary>
    /// Delete one PeriodeTarifSpecialGeneral
    /// </summary>
    public Task DeletePeriodeTarifSpecialGeneral(
        PeriodeTarifSpecialGeneralWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Find many PeriodeTarifSpecialGenerals
    /// </summary>
    public Task<List<PeriodeTarifSpecialGeneral>> PeriodeTarifSpecialGenerals(
        PeriodeTarifSpecialGeneralFindManyArgs findManyArgs
    );

    /// <summary>
    /// Meta data about PeriodeTarifSpecialGeneral records
    /// </summary>
    public Task<MetadataDto> PeriodeTarifSpecialGeneralsMeta(
        PeriodeTarifSpecialGeneralFindManyArgs findManyArgs
    );

    /// <summary>
    /// Get one PeriodeTarifSpecialGeneral
    /// </summary>
    public Task<PeriodeTarifSpecialGeneral> PeriodeTarifSpecialGeneral(
        PeriodeTarifSpecialGeneralWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Update one PeriodeTarifSpecialGeneral
    /// </summary>
    public Task UpdatePeriodeTarifSpecialGeneral(
        PeriodeTarifSpecialGeneralWhereUniqueInput uniqueId,
        PeriodeTarifSpecialGeneralUpdateInput updateDto
    );
}
