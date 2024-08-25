using Traveler.APIs.Common;
using Traveler.APIs.Dtos;

namespace Traveler.APIs;

public interface IImportDeclarationsService
{
    /// <summary>
    /// Create one ImportDeclaration
    /// </summary>
    public Task<ImportDeclaration> CreateImportDeclaration(
        ImportDeclarationCreateInput importdeclaration
    );

    /// <summary>
    /// Delete one ImportDeclaration
    /// </summary>
    public Task DeleteImportDeclaration(ImportDeclarationWhereUniqueInput uniqueId);

    /// <summary>
    /// Find many ImportDeclarations
    /// </summary>
    public Task<List<ImportDeclaration>> ImportDeclarations(
        ImportDeclarationFindManyArgs findManyArgs
    );

    /// <summary>
    /// Meta data about ImportDeclaration records
    /// </summary>
    public Task<MetadataDto> ImportDeclarationsMeta(ImportDeclarationFindManyArgs findManyArgs);

    /// <summary>
    /// Get one ImportDeclaration
    /// </summary>
    public Task<ImportDeclaration> ImportDeclaration(ImportDeclarationWhereUniqueInput uniqueId);

    /// <summary>
    /// Update one ImportDeclaration
    /// </summary>
    public Task UpdateImportDeclaration(
        ImportDeclarationWhereUniqueInput uniqueId,
        ImportDeclarationUpdateInput updateDto
    );

    /// <summary>
    /// Get a Baggage Control Article record for ImportDeclaration
    /// </summary>
    public Task<BaggageControlArticle> GetBaggageControlArticle(
        ImportDeclarationWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Connect multiple GeneralTravelerInformationTpds records to ImportDeclaration
    /// </summary>
    public Task ConnectGeneralTravelerInformationTpds(
        ImportDeclarationWhereUniqueInput uniqueId,
        GeneralTravelerInformationTpdWhereUniqueInput[] generalTravelerInformationTpdsId
    );

    /// <summary>
    /// Disconnect multiple GeneralTravelerInformationTpds records from ImportDeclaration
    /// </summary>
    public Task DisconnectGeneralTravelerInformationTpds(
        ImportDeclarationWhereUniqueInput uniqueId,
        GeneralTravelerInformationTpdWhereUniqueInput[] generalTravelerInformationTpdsId
    );

    /// <summary>
    /// Find multiple GeneralTravelerInformationTpds records for ImportDeclaration
    /// </summary>
    public Task<List<GeneralTravelerInformationTpd>> FindGeneralTravelerInformationTpds(
        ImportDeclarationWhereUniqueInput uniqueId,
        GeneralTravelerInformationTpdFindManyArgs GeneralTravelerInformationTpdFindManyArgs
    );

    /// <summary>
    /// Update multiple GeneralTravelerInformationTpds records for ImportDeclaration
    /// </summary>
    public Task UpdateGeneralTravelerInformationTpds(
        ImportDeclarationWhereUniqueInput uniqueId,
        GeneralTravelerInformationTpdWhereUniqueInput[] generalTravelerInformationTpdsId
    );

    /// <summary>
    /// Get a TPD Control record for ImportDeclaration
    /// </summary>
    public Task<TpdControl> GetTpdControl(ImportDeclarationWhereUniqueInput uniqueId);

    /// <summary>
    /// Get a TPD Entry and Exit History record for ImportDeclaration
    /// </summary>
    public Task<TpdEntryAndExitHistory> GetTpdEntryAndExitHistory(
        ImportDeclarationWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Get a Travelers Articles Entry Exit record for ImportDeclaration
    /// </summary>
    public Task<TravelersArticlesEntryExit> GetTravelersArticlesEntryExit(
        ImportDeclarationWhereUniqueInput uniqueId
    );
}
