using Traveler.APIs.Common;
using Traveler.APIs.Dtos;

namespace Traveler.APIs;

public interface IAppealsService
{
    /// <summary>
    /// Create one Appeal
    /// </summary>
    public Task<Appeal> CreateAppeal(AppealCreateInput appeal);

    /// <summary>
    /// Delete one Appeal
    /// </summary>
    public Task DeleteAppeal(AppealWhereUniqueInput uniqueId);

    /// <summary>
    /// Find many Appeals
    /// </summary>
    public Task<List<Appeal>> Appeals(AppealFindManyArgs findManyArgs);

    /// <summary>
    /// Meta data about Appeal records
    /// </summary>
    public Task<MetadataDto> AppealsMeta(AppealFindManyArgs findManyArgs);

    /// <summary>
    /// Get one Appeal
    /// </summary>
    public Task<Appeal> Appeal(AppealWhereUniqueInput uniqueId);

    /// <summary>
    /// Update one Appeal
    /// </summary>
    public Task UpdateAppeal(AppealWhereUniqueInput uniqueId, AppealUpdateInput updateDto);

    /// <summary>
    /// Get a General Bond Note record for Appeal
    /// </summary>
    public Task<GeneralBondNote> GetGeneralBondNote(AppealWhereUniqueInput uniqueId);

    /// <summary>
    /// Connect multiple GeneralTravelerInformationTpds records to Appeal
    /// </summary>
    public Task ConnectGeneralTravelerInformationTpds(
        AppealWhereUniqueInput uniqueId,
        GeneralTravelerInformationTpdWhereUniqueInput[] generalTravelerInformationTpdsId
    );

    /// <summary>
    /// Disconnect multiple GeneralTravelerInformationTpds records from Appeal
    /// </summary>
    public Task DisconnectGeneralTravelerInformationTpds(
        AppealWhereUniqueInput uniqueId,
        GeneralTravelerInformationTpdWhereUniqueInput[] generalTravelerInformationTpdsId
    );

    /// <summary>
    /// Find multiple GeneralTravelerInformationTpds records for Appeal
    /// </summary>
    public Task<List<GeneralTravelerInformationTpd>> FindGeneralTravelerInformationTpds(
        AppealWhereUniqueInput uniqueId,
        GeneralTravelerInformationTpdFindManyArgs GeneralTravelerInformationTpdFindManyArgs
    );

    /// <summary>
    /// Update multiple GeneralTravelerInformationTpds records for Appeal
    /// </summary>
    public Task UpdateGeneralTravelerInformationTpds(
        AppealWhereUniqueInput uniqueId,
        GeneralTravelerInformationTpdWhereUniqueInput[] generalTravelerInformationTpdsId
    );
}
