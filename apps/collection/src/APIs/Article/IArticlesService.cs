using Collection.APIs.Common;
using Collection.APIs.Dtos;

namespace Collection.APIs;

public interface IArticlesService
{
    /// <summary>
    ///     Create one ARTICLE
    /// </summary>
    public Task<Article> CreateArticle(ArticleCreateInput article);

    /// <summary>
    ///     Delete one ARTICLE
    /// </summary>
    public Task DeleteArticle(ArticleWhereUniqueInput uniqueId);

    /// <summary>
    ///     Find many ARTICLES
    /// </summary>
    public Task<List<Article>> Articles(ArticleFindManyArgs findManyArgs);

    /// <summary>
    ///     Meta data about ARTICLE records
    /// </summary>
    public Task<MetadataDto> ArticlesMeta(ArticleFindManyArgs findManyArgs);

    /// <summary>
    ///     Get one ARTICLE
    /// </summary>
    public Task<Article> Article(ArticleWhereUniqueInput uniqueId);

    /// <summary>
    ///     Update one ARTICLE
    /// </summary>
    public Task UpdateArticle(ArticleWhereUniqueInput uniqueId, ArticleUpdateInput updateDto);
}
