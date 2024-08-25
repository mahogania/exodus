using Traveler.APIs.Common;
using Traveler.APIs.Dtos;

namespace Traveler.APIs;

public interface IBaggageControlArticlesService
{
    /// <summary>
    /// Create one BaggageControlArticle
    /// </summary>
    public Task<BaggageControlArticle> CreateBaggageControlArticle(
        BaggageControlArticleCreateInput baggagecontrolarticle
    );

    /// <summary>
    /// Delete one BaggageControlArticle
    /// </summary>
    public Task DeleteBaggageControlArticle(BaggageControlArticleWhereUniqueInput uniqueId);

    /// <summary>
    /// Find many BaggageControlArticles
    /// </summary>
    public Task<List<BaggageControlArticle>> BaggageControlArticles(
        BaggageControlArticleFindManyArgs findManyArgs
    );

    /// <summary>
    /// Meta data about BaggageControlArticle records
    /// </summary>
    public Task<MetadataDto> BaggageControlArticlesMeta(
        BaggageControlArticleFindManyArgs findManyArgs
    );

    /// <summary>
    /// Get one BaggageControlArticle
    /// </summary>
    public Task<BaggageControlArticle> BaggageControlArticle(
        BaggageControlArticleWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Update one BaggageControlArticle
    /// </summary>
    public Task UpdateBaggageControlArticle(
        BaggageControlArticleWhereUniqueInput uniqueId,
        BaggageControlArticleUpdateInput updateDto
    );

    /// <summary>
    /// Connect multiple GeneralTravelerInformationTpds records to BaggageControlArticle
    /// </summary>
    public Task ConnectGeneralTravelerInformationTpds(
        BaggageControlArticleWhereUniqueInput uniqueId,
        GeneralTravelerInformationTpdWhereUniqueInput[] generalTravelerInformationTpdsId
    );

    /// <summary>
    /// Disconnect multiple GeneralTravelerInformationTpds records from BaggageControlArticle
    /// </summary>
    public Task DisconnectGeneralTravelerInformationTpds(
        BaggageControlArticleWhereUniqueInput uniqueId,
        GeneralTravelerInformationTpdWhereUniqueInput[] generalTravelerInformationTpdsId
    );

    /// <summary>
    /// Find multiple GeneralTravelerInformationTpds records for BaggageControlArticle
    /// </summary>
    public Task<List<GeneralTravelerInformationTpd>> FindGeneralTravelerInformationTpds(
        BaggageControlArticleWhereUniqueInput uniqueId,
        GeneralTravelerInformationTpdFindManyArgs GeneralTravelerInformationTpdFindManyArgs
    );

    /// <summary>
    /// Update multiple GeneralTravelerInformationTpds records for BaggageControlArticle
    /// </summary>
    public Task UpdateGeneralTravelerInformationTpds(
        BaggageControlArticleWhereUniqueInput uniqueId,
        GeneralTravelerInformationTpdWhereUniqueInput[] generalTravelerInformationTpdsId
    );

    /// <summary>
    /// Connect multiple ImportDeclarations records to BaggageControlArticle
    /// </summary>
    public Task ConnectImportDeclarations(
        BaggageControlArticleWhereUniqueInput uniqueId,
        ImportDeclarationWhereUniqueInput[] importDeclarationsId
    );

    /// <summary>
    /// Disconnect multiple ImportDeclarations records from BaggageControlArticle
    /// </summary>
    public Task DisconnectImportDeclarations(
        BaggageControlArticleWhereUniqueInput uniqueId,
        ImportDeclarationWhereUniqueInput[] importDeclarationsId
    );

    /// <summary>
    /// Find multiple ImportDeclarations records for BaggageControlArticle
    /// </summary>
    public Task<List<ImportDeclaration>> FindImportDeclarations(
        BaggageControlArticleWhereUniqueInput uniqueId,
        ImportDeclarationFindManyArgs ImportDeclarationFindManyArgs
    );

    /// <summary>
    /// Update multiple ImportDeclarations records for BaggageControlArticle
    /// </summary>
    public Task UpdateImportDeclarations(
        BaggageControlArticleWhereUniqueInput uniqueId,
        ImportDeclarationWhereUniqueInput[] importDeclarationsId
    );

    /// <summary>
    /// Connect multiple TpdControls records to BaggageControlArticle
    /// </summary>
    public Task ConnectTpdControls(
        BaggageControlArticleWhereUniqueInput uniqueId,
        TpdControlWhereUniqueInput[] tpdControlsId
    );

    /// <summary>
    /// Disconnect multiple TpdControls records from BaggageControlArticle
    /// </summary>
    public Task DisconnectTpdControls(
        BaggageControlArticleWhereUniqueInput uniqueId,
        TpdControlWhereUniqueInput[] tpdControlsId
    );

    /// <summary>
    /// Find multiple TpdControls records for BaggageControlArticle
    /// </summary>
    public Task<List<TpdControl>> FindTpdControls(
        BaggageControlArticleWhereUniqueInput uniqueId,
        TpdControlFindManyArgs TpdControlFindManyArgs
    );

    /// <summary>
    /// Update multiple TpdControls records for BaggageControlArticle
    /// </summary>
    public Task UpdateTpdControls(
        BaggageControlArticleWhereUniqueInput uniqueId,
        TpdControlWhereUniqueInput[] tpdControlsId
    );
}
