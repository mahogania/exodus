using Traveler.APIs.Common;
using Traveler.APIs.Dtos;

namespace Traveler.APIs;

public interface ITravelersArticlesEntryExitsService
{
    /// <summary>
    /// Create one TravelersArticlesEntryExit
    /// </summary>
    public Task<TravelersArticlesEntryExit> CreateTravelersArticlesEntryExit(
        TravelersArticlesEntryExitCreateInput travelersarticlesentryexit
    );

    /// <summary>
    /// Delete one TravelersArticlesEntryExit
    /// </summary>
    public Task DeleteTravelersArticlesEntryExit(
        TravelersArticlesEntryExitWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Find many TravelersArticlesEntryExits
    /// </summary>
    public Task<List<TravelersArticlesEntryExit>> TravelersArticlesEntryExits(
        TravelersArticlesEntryExitFindManyArgs findManyArgs
    );

    /// <summary>
    /// Meta data about TravelersArticlesEntryExit records
    /// </summary>
    public Task<MetadataDto> TravelersArticlesEntryExitsMeta(
        TravelersArticlesEntryExitFindManyArgs findManyArgs
    );

    /// <summary>
    /// Get one TravelersArticlesEntryExit
    /// </summary>
    public Task<TravelersArticlesEntryExit> TravelersArticlesEntryExit(
        TravelersArticlesEntryExitWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Update one TravelersArticlesEntryExit
    /// </summary>
    public Task UpdateTravelersArticlesEntryExit(
        TravelersArticlesEntryExitWhereUniqueInput uniqueId,
        TravelersArticlesEntryExitUpdateInput updateDto
    );

    /// <summary>
    /// Connect multiple GeneralTravelerInformationTpds records to TravelersArticlesEntryExit
    /// </summary>
    public Task ConnectGeneralTravelerInformationTpds(
        TravelersArticlesEntryExitWhereUniqueInput uniqueId,
        GeneralTravelerInformationTpdWhereUniqueInput[] generalTravelerInformationTpdsId
    );

    /// <summary>
    /// Disconnect multiple GeneralTravelerInformationTpds records from TravelersArticlesEntryExit
    /// </summary>
    public Task DisconnectGeneralTravelerInformationTpds(
        TravelersArticlesEntryExitWhereUniqueInput uniqueId,
        GeneralTravelerInformationTpdWhereUniqueInput[] generalTravelerInformationTpdsId
    );

    /// <summary>
    /// Find multiple GeneralTravelerInformationTpds records for TravelersArticlesEntryExit
    /// </summary>
    public Task<List<GeneralTravelerInformationTpd>> FindGeneralTravelerInformationTpds(
        TravelersArticlesEntryExitWhereUniqueInput uniqueId,
        GeneralTravelerInformationTpdFindManyArgs GeneralTravelerInformationTpdFindManyArgs
    );

    /// <summary>
    /// Update multiple GeneralTravelerInformationTpds records for TravelersArticlesEntryExit
    /// </summary>
    public Task UpdateGeneralTravelerInformationTpds(
        TravelersArticlesEntryExitWhereUniqueInput uniqueId,
        GeneralTravelerInformationTpdWhereUniqueInput[] generalTravelerInformationTpdsId
    );

    /// <summary>
    /// Connect multiple ImportDeclarations records to TravelersArticlesEntryExit
    /// </summary>
    public Task ConnectImportDeclarations(
        TravelersArticlesEntryExitWhereUniqueInput uniqueId,
        ImportDeclarationWhereUniqueInput[] importDeclarationsId
    );

    /// <summary>
    /// Disconnect multiple ImportDeclarations records from TravelersArticlesEntryExit
    /// </summary>
    public Task DisconnectImportDeclarations(
        TravelersArticlesEntryExitWhereUniqueInput uniqueId,
        ImportDeclarationWhereUniqueInput[] importDeclarationsId
    );

    /// <summary>
    /// Find multiple ImportDeclarations records for TravelersArticlesEntryExit
    /// </summary>
    public Task<List<ImportDeclaration>> FindImportDeclarations(
        TravelersArticlesEntryExitWhereUniqueInput uniqueId,
        ImportDeclarationFindManyArgs ImportDeclarationFindManyArgs
    );

    /// <summary>
    /// Update multiple ImportDeclarations records for TravelersArticlesEntryExit
    /// </summary>
    public Task UpdateImportDeclarations(
        TravelersArticlesEntryExitWhereUniqueInput uniqueId,
        ImportDeclarationWhereUniqueInput[] importDeclarationsId
    );
}
