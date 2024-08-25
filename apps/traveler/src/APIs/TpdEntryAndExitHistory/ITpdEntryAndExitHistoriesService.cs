using Traveler.APIs.Common;
using Traveler.APIs.Dtos;

namespace Traveler.APIs;

public interface ITpdEntryAndExitHistoriesService
{
    /// <summary>
    /// Create one TpdEntryAndExitHistory
    /// </summary>
    public Task<TpdEntryAndExitHistory> CreateTpdEntryAndExitHistory(
        TpdEntryAndExitHistoryCreateInput tpdentryandexithistory
    );

    /// <summary>
    /// Delete one TpdEntryAndExitHistory
    /// </summary>
    public Task DeleteTpdEntryAndExitHistory(TpdEntryAndExitHistoryWhereUniqueInput uniqueId);

    /// <summary>
    /// Find many TpdEntryAndExitHistories
    /// </summary>
    public Task<List<TpdEntryAndExitHistory>> TpdEntryAndExitHistories(
        TpdEntryAndExitHistoryFindManyArgs findManyArgs
    );

    /// <summary>
    /// Meta data about TpdEntryAndExitHistory records
    /// </summary>
    public Task<MetadataDto> TpdEntryAndExitHistoriesMeta(
        TpdEntryAndExitHistoryFindManyArgs findManyArgs
    );

    /// <summary>
    /// Get one TpdEntryAndExitHistory
    /// </summary>
    public Task<TpdEntryAndExitHistory> TpdEntryAndExitHistory(
        TpdEntryAndExitHistoryWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Update one TpdEntryAndExitHistory
    /// </summary>
    public Task UpdateTpdEntryAndExitHistory(
        TpdEntryAndExitHistoryWhereUniqueInput uniqueId,
        TpdEntryAndExitHistoryUpdateInput updateDto
    );

    /// <summary>
    /// Connect multiple GeneralTravelerInformationTpds records to TpdEntryAndExitHistory
    /// </summary>
    public Task ConnectGeneralTravelerInformationTpds(
        TpdEntryAndExitHistoryWhereUniqueInput uniqueId,
        GeneralTravelerInformationTpdWhereUniqueInput[] generalTravelerInformationTpdsId
    );

    /// <summary>
    /// Disconnect multiple GeneralTravelerInformationTpds records from TpdEntryAndExitHistory
    /// </summary>
    public Task DisconnectGeneralTravelerInformationTpds(
        TpdEntryAndExitHistoryWhereUniqueInput uniqueId,
        GeneralTravelerInformationTpdWhereUniqueInput[] generalTravelerInformationTpdsId
    );

    /// <summary>
    /// Find multiple GeneralTravelerInformationTpds records for TpdEntryAndExitHistory
    /// </summary>
    public Task<List<GeneralTravelerInformationTpd>> FindGeneralTravelerInformationTpds(
        TpdEntryAndExitHistoryWhereUniqueInput uniqueId,
        GeneralTravelerInformationTpdFindManyArgs GeneralTravelerInformationTpdFindManyArgs
    );

    /// <summary>
    /// Update multiple GeneralTravelerInformationTpds records for TpdEntryAndExitHistory
    /// </summary>
    public Task UpdateGeneralTravelerInformationTpds(
        TpdEntryAndExitHistoryWhereUniqueInput uniqueId,
        GeneralTravelerInformationTpdWhereUniqueInput[] generalTravelerInformationTpdsId
    );

    /// <summary>
    /// Connect multiple ImportDeclarations records to TpdEntryAndExitHistory
    /// </summary>
    public Task ConnectImportDeclarations(
        TpdEntryAndExitHistoryWhereUniqueInput uniqueId,
        ImportDeclarationWhereUniqueInput[] importDeclarationsId
    );

    /// <summary>
    /// Disconnect multiple ImportDeclarations records from TpdEntryAndExitHistory
    /// </summary>
    public Task DisconnectImportDeclarations(
        TpdEntryAndExitHistoryWhereUniqueInput uniqueId,
        ImportDeclarationWhereUniqueInput[] importDeclarationsId
    );

    /// <summary>
    /// Find multiple ImportDeclarations records for TpdEntryAndExitHistory
    /// </summary>
    public Task<List<ImportDeclaration>> FindImportDeclarations(
        TpdEntryAndExitHistoryWhereUniqueInput uniqueId,
        ImportDeclarationFindManyArgs ImportDeclarationFindManyArgs
    );

    /// <summary>
    /// Update multiple ImportDeclarations records for TpdEntryAndExitHistory
    /// </summary>
    public Task UpdateImportDeclarations(
        TpdEntryAndExitHistoryWhereUniqueInput uniqueId,
        ImportDeclarationWhereUniqueInput[] importDeclarationsId
    );
}
