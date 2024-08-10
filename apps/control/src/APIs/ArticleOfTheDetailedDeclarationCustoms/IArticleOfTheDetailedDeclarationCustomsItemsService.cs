using Control.APIs.Common;
using Control.APIs.Dtos;

namespace Control.APIs;

public interface IArticleOfTheDetailedDeclarationCustomsItemsService
{
    /// <summary>
    ///     Create one ARTICLE OF THE DETAILED DECLARATION (CUSTOMS)
    /// </summary>
    public Task<ArticleOfTheDetailedDeclarationCustoms> CreateArticleOfTheDetailedDeclarationCustoms(
        ArticleOfTheDetailedDeclarationCustomsCreateInput articleofthedetaileddeclarationcustoms
    );

    /// <summary>
    ///     Delete one ARTICLE OF THE DETAILED DECLARATION (CUSTOMS)
    /// </summary>
    public Task DeleteArticleOfTheDetailedDeclarationCustoms(
        ArticleOfTheDetailedDeclarationCustomsWhereUniqueInput uniqueId
    );

    /// <summary>
    ///     Find many ARTICLE OF THE DETAILED DECLARATION (CUSTOMS)s
    /// </summary>
    public Task<
        List<ArticleOfTheDetailedDeclarationCustoms>
    > ArticleOfTheDetailedDeclarationCustomsItems(
        ArticleOfTheDetailedDeclarationCustomsFindManyArgs findManyArgs
    );

    /// <summary>
    ///     Meta data about ARTICLE OF THE DETAILED DECLARATION (CUSTOMS) records
    /// </summary>
    public Task<MetadataDto> ArticleOfTheDetailedDeclarationCustomsItemsMeta(
        ArticleOfTheDetailedDeclarationCustomsFindManyArgs findManyArgs
    );

    /// <summary>
    ///     Get one ARTICLE OF THE DETAILED DECLARATION (CUSTOMS)
    /// </summary>
    public Task<ArticleOfTheDetailedDeclarationCustoms> ArticleOfTheDetailedDeclarationCustoms(
        ArticleOfTheDetailedDeclarationCustomsWhereUniqueInput uniqueId
    );

    /// <summary>
    ///     Update one ARTICLE OF THE DETAILED DECLARATION (CUSTOMS)
    /// </summary>
    public Task UpdateArticleOfTheDetailedDeclarationCustoms(
        ArticleOfTheDetailedDeclarationCustomsWhereUniqueInput uniqueId,
        ArticleOfTheDetailedDeclarationCustomsUpdateInput updateDto
    );
}
