using Traveler.APIs.Common;
using Traveler.APIs.Dtos;

namespace Traveler.APIs;

public interface IInspectorRatingModificationHistoriesService
{
    /// <summary>
    /// Create one InspectorRatingModificationHistory
    /// </summary>
    public Task<InspectorRatingModificationHistory> CreateInspectorRatingModificationHistory(
        InspectorRatingModificationHistoryCreateInput inspectorratingmodificationhistory
    );

    /// <summary>
    /// Delete one InspectorRatingModificationHistory
    /// </summary>
    public Task DeleteInspectorRatingModificationHistory(
        InspectorRatingModificationHistoryWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Find many InspectorRatingModificationHistories
    /// </summary>
    public Task<List<InspectorRatingModificationHistory>> InspectorRatingModificationHistories(
        InspectorRatingModificationHistoryFindManyArgs findManyArgs
    );

    /// <summary>
    /// Meta data about InspectorRatingModificationHistory records
    /// </summary>
    public Task<MetadataDto> InspectorRatingModificationHistoriesMeta(
        InspectorRatingModificationHistoryFindManyArgs findManyArgs
    );

    /// <summary>
    /// Get one InspectorRatingModificationHistory
    /// </summary>
    public Task<InspectorRatingModificationHistory> InspectorRatingModificationHistory(
        InspectorRatingModificationHistoryWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Update one InspectorRatingModificationHistory
    /// </summary>
    public Task UpdateInspectorRatingModificationHistory(
        InspectorRatingModificationHistoryWhereUniqueInput uniqueId,
        InspectorRatingModificationHistoryUpdateInput updateDto
    );

    /// <summary>
    /// Connect multiple GeneralTravelerInformationTpds records to InspectorRatingModificationHistory
    /// </summary>
    public Task ConnectGeneralTravelerInformationTpds(
        InspectorRatingModificationHistoryWhereUniqueInput uniqueId,
        GeneralTravelerInformationTpdWhereUniqueInput[] generalTravelerInformationTpdsId
    );

    /// <summary>
    /// Disconnect multiple GeneralTravelerInformationTpds records from InspectorRatingModificationHistory
    /// </summary>
    public Task DisconnectGeneralTravelerInformationTpds(
        InspectorRatingModificationHistoryWhereUniqueInput uniqueId,
        GeneralTravelerInformationTpdWhereUniqueInput[] generalTravelerInformationTpdsId
    );

    /// <summary>
    /// Find multiple GeneralTravelerInformationTpds records for InspectorRatingModificationHistory
    /// </summary>
    public Task<List<GeneralTravelerInformationTpd>> FindGeneralTravelerInformationTpds(
        InspectorRatingModificationHistoryWhereUniqueInput uniqueId,
        GeneralTravelerInformationTpdFindManyArgs GeneralTravelerInformationTpdFindManyArgs
    );

    /// <summary>
    /// Update multiple GeneralTravelerInformationTpds records for InspectorRatingModificationHistory
    /// </summary>
    public Task UpdateGeneralTravelerInformationTpds(
        InspectorRatingModificationHistoryWhereUniqueInput uniqueId,
        GeneralTravelerInformationTpdWhereUniqueInput[] generalTravelerInformationTpdsId
    );
}
