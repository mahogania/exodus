using Code.APIs.Common;
using Code.APIs.Dtos;

namespace Code.APIs;

public interface IArticlePaysPartenaireConventionDouanieresService
{
    /// <summary>
    /// Create one ArticlePaysPartenaireConventionDouaniere
    /// </summary>
    public Task<ArticlePaysPartenaireConventionDouaniere> CreateArticlePaysPartenaireConventionDouaniere(
        ArticlePaysPartenaireConventionDouaniereCreateInput articlepayspartenaireconventiondouaniere
    );

    /// <summary>
    /// Delete one ArticlePaysPartenaireConventionDouaniere
    /// </summary>
    public Task DeleteArticlePaysPartenaireConventionDouaniere(
        ArticlePaysPartenaireConventionDouaniereWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Find many ArticlePaysPartenaireConventionDouanieres
    /// </summary>
    public Task<
        List<ArticlePaysPartenaireConventionDouaniere>
    > ArticlePaysPartenaireConventionDouanieres(
        ArticlePaysPartenaireConventionDouaniereFindManyArgs findManyArgs
    );

    /// <summary>
    /// Meta data about ArticlePaysPartenaireConventionDouaniere records
    /// </summary>
    public Task<MetadataDto> ArticlePaysPartenaireConventionDouanieresMeta(
        ArticlePaysPartenaireConventionDouaniereFindManyArgs findManyArgs
    );

    /// <summary>
    /// Get one ArticlePaysPartenaireConventionDouaniere
    /// </summary>
    public Task<ArticlePaysPartenaireConventionDouaniere> ArticlePaysPartenaireConventionDouaniere(
        ArticlePaysPartenaireConventionDouaniereWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Update one ArticlePaysPartenaireConventionDouaniere
    /// </summary>
    public Task UpdateArticlePaysPartenaireConventionDouaniere(
        ArticlePaysPartenaireConventionDouaniereWhereUniqueInput uniqueId,
        ArticlePaysPartenaireConventionDouaniereUpdateInput updateDto
    );
}
