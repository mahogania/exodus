using Control.APIs.Common;
using Control.APIs.Dtos;

namespace Control.APIs;

public interface IRequestForTirCarnetOfTheArticlesService
{
    /// <summary>
    /// Create one REQUEST FOR TIR CARNET OF THE ARTICLE
    /// </summary>
    public Task<RequestForTirCarnetOfTheArticle> CreateRequestForTirCarnetOfTheArticle(
        RequestForTirCarnetOfTheArticleCreateInput requestfortircarnetofthearticle
    );

    /// <summary>
    /// Delete one REQUEST FOR TIR CARNET OF THE ARTICLE
    /// </summary>
    public Task DeleteRequestForTirCarnetOfTheArticle(
        RequestForTirCarnetOfTheArticleWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Find many REQUEST FOR TIR CARNET OF THE ARTICLES
    /// </summary>
    public Task<List<RequestForTirCarnetOfTheArticle>> RequestForTirCarnetOfTheArticles(
        RequestForTirCarnetOfTheArticleFindManyArgs findManyArgs
    );

    /// <summary>
    /// Meta data about REQUEST FOR TIR CARNET OF THE ARTICLE records
    /// </summary>
    public Task<MetadataDto> RequestForTirCarnetOfTheArticlesMeta(
        RequestForTirCarnetOfTheArticleFindManyArgs findManyArgs
    );

    /// <summary>
    /// Get one REQUEST FOR TIR CARNET OF THE ARTICLE
    /// </summary>
    public Task<RequestForTirCarnetOfTheArticle> RequestForTirCarnetOfTheArticle(
        RequestForTirCarnetOfTheArticleWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Update one REQUEST FOR TIR CARNET OF THE ARTICLE
    /// </summary>
    public Task UpdateRequestForTirCarnetOfTheArticle(
        RequestForTirCarnetOfTheArticleWhereUniqueInput uniqueId,
        RequestForTirCarnetOfTheArticleUpdateInput updateDto
    );
}
