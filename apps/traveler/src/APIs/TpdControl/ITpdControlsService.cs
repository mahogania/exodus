using Traveler.APIs.Common;
using Traveler.APIs.Dtos;

namespace Traveler.APIs;

public interface ITpdControlsService
{
    /// <summary>
    /// Create one TpdControl
    /// </summary>
    public Task<TpdControl> CreateTpdControl(TpdControlCreateInput tpdcontrol);

    /// <summary>
    /// Delete one TpdControl
    /// </summary>
    public Task DeleteTpdControl(TpdControlWhereUniqueInput uniqueId);

    /// <summary>
    /// Find many TpdControls
    /// </summary>
    public Task<List<TpdControl>> TpdControls(TpdControlFindManyArgs findManyArgs);

    /// <summary>
    /// Meta data about TpdControl records
    /// </summary>
    public Task<MetadataDto> TpdControlsMeta(TpdControlFindManyArgs findManyArgs);

    /// <summary>
    /// Get one TpdControl
    /// </summary>
    public Task<TpdControl> TpdControl(TpdControlWhereUniqueInput uniqueId);

    /// <summary>
    /// Update one TpdControl
    /// </summary>
    public Task UpdateTpdControl(
        TpdControlWhereUniqueInput uniqueId,
        TpdControlUpdateInput updateDto
    );

    /// <summary>
    /// Get a Baggage Control Article record for TpdControl
    /// </summary>
    public Task<BaggageControlArticle> GetBaggageControlArticle(
        TpdControlWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Connect multiple GeneralTravelerInformationTpds records to TpdControl
    /// </summary>
    public Task ConnectGeneralTravelerInformationTpds(
        TpdControlWhereUniqueInput uniqueId,
        GeneralTravelerInformationTpdWhereUniqueInput[] generalTravelerInformationTpdsId
    );

    /// <summary>
    /// Disconnect multiple GeneralTravelerInformationTpds records from TpdControl
    /// </summary>
    public Task DisconnectGeneralTravelerInformationTpds(
        TpdControlWhereUniqueInput uniqueId,
        GeneralTravelerInformationTpdWhereUniqueInput[] generalTravelerInformationTpdsId
    );

    /// <summary>
    /// Find multiple GeneralTravelerInformationTpds records for TpdControl
    /// </summary>
    public Task<List<GeneralTravelerInformationTpd>> FindGeneralTravelerInformationTpds(
        TpdControlWhereUniqueInput uniqueId,
        GeneralTravelerInformationTpdFindManyArgs GeneralTravelerInformationTpdFindManyArgs
    );

    /// <summary>
    /// Update multiple GeneralTravelerInformationTpds records for TpdControl
    /// </summary>
    public Task UpdateGeneralTravelerInformationTpds(
        TpdControlWhereUniqueInput uniqueId,
        GeneralTravelerInformationTpdWhereUniqueInput[] generalTravelerInformationTpdsId
    );

    /// <summary>
    /// Connect multiple ImportDeclarations records to TpdControl
    /// </summary>
    public Task ConnectImportDeclarations(
        TpdControlWhereUniqueInput uniqueId,
        ImportDeclarationWhereUniqueInput[] importDeclarationsId
    );

    /// <summary>
    /// Disconnect multiple ImportDeclarations records from TpdControl
    /// </summary>
    public Task DisconnectImportDeclarations(
        TpdControlWhereUniqueInput uniqueId,
        ImportDeclarationWhereUniqueInput[] importDeclarationsId
    );

    /// <summary>
    /// Find multiple ImportDeclarations records for TpdControl
    /// </summary>
    public Task<List<ImportDeclaration>> FindImportDeclarations(
        TpdControlWhereUniqueInput uniqueId,
        ImportDeclarationFindManyArgs ImportDeclarationFindManyArgs
    );

    /// <summary>
    /// Update multiple ImportDeclarations records for TpdControl
    /// </summary>
    public Task UpdateImportDeclarations(
        TpdControlWhereUniqueInput uniqueId,
        ImportDeclarationWhereUniqueInput[] importDeclarationsId
    );
}
