using Traveler.APIs.Common;
using Traveler.APIs.Dtos;

namespace Traveler.APIs;

public interface ITravelerSearchHistoriesService
{
    /// <summary>
    /// Create one TravelerSearchHistory
    /// </summary>
    public Task<TravelerSearchHistory> CreateTravelerSearchHistory(
        TravelerSearchHistoryCreateInput travelersearchhistory
    );

    /// <summary>
    /// Delete one TravelerSearchHistory
    /// </summary>
    public Task DeleteTravelerSearchHistory(TravelerSearchHistoryWhereUniqueInput uniqueId);

    /// <summary>
    /// Find many TravelerSearchHistories
    /// </summary>
    public Task<List<TravelerSearchHistory>> TravelerSearchHistories(
        TravelerSearchHistoryFindManyArgs findManyArgs
    );

    /// <summary>
    /// Meta data about TravelerSearchHistory records
    /// </summary>
    public Task<MetadataDto> TravelerSearchHistoriesMeta(
        TravelerSearchHistoryFindManyArgs findManyArgs
    );

    /// <summary>
    /// Get one TravelerSearchHistory
    /// </summary>
    public Task<TravelerSearchHistory> TravelerSearchHistory(
        TravelerSearchHistoryWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Update one TravelerSearchHistory
    /// </summary>
    public Task UpdateTravelerSearchHistory(
        TravelerSearchHistoryWhereUniqueInput uniqueId,
        TravelerSearchHistoryUpdateInput updateDto
    );

    /// <summary>
    /// Connect multiple GeneralTravelerInformationTpds records to TravelerSearchHistory
    /// </summary>
    public Task ConnectGeneralTravelerInformationTpds(
        TravelerSearchHistoryWhereUniqueInput uniqueId,
        GeneralTravelerInformationTpdWhereUniqueInput[] generalTravelerInformationTpdsId
    );

    /// <summary>
    /// Disconnect multiple GeneralTravelerInformationTpds records from TravelerSearchHistory
    /// </summary>
    public Task DisconnectGeneralTravelerInformationTpds(
        TravelerSearchHistoryWhereUniqueInput uniqueId,
        GeneralTravelerInformationTpdWhereUniqueInput[] generalTravelerInformationTpdsId
    );

    /// <summary>
    /// Find multiple GeneralTravelerInformationTpds records for TravelerSearchHistory
    /// </summary>
    public Task<List<GeneralTravelerInformationTpd>> FindGeneralTravelerInformationTpds(
        TravelerSearchHistoryWhereUniqueInput uniqueId,
        GeneralTravelerInformationTpdFindManyArgs GeneralTravelerInformationTpdFindManyArgs
    );

    /// <summary>
    /// Update multiple GeneralTravelerInformationTpds records for TravelerSearchHistory
    /// </summary>
    public Task UpdateGeneralTravelerInformationTpds(
        TravelerSearchHistoryWhereUniqueInput uniqueId,
        GeneralTravelerInformationTpdWhereUniqueInput[] generalTravelerInformationTpdsId
    );
}
