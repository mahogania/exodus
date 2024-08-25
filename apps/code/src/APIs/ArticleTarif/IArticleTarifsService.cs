using Code.APIs.Common;
using Code.APIs.Dtos;

namespace Code.APIs;

public interface IArticleTarifsService
{
    /// <summary>
    /// Create one ArticleTarif
    /// </summary>
    public Task<ArticleTarif> CreateArticleTarif(ArticleTarifCreateInput articletarif);

    /// <summary>
    /// Delete one ArticleTarif
    /// </summary>
    public Task DeleteArticleTarif(ArticleTarifWhereUniqueInput uniqueId);

    /// <summary>
    /// Find many ArticleTarifs
    /// </summary>
    public Task<List<ArticleTarif>> ArticleTarifs(ArticleTarifFindManyArgs findManyArgs);

    /// <summary>
    /// Meta data about ArticleTarif records
    /// </summary>
    public Task<MetadataDto> ArticleTarifsMeta(ArticleTarifFindManyArgs findManyArgs);

    /// <summary>
    /// Get one ArticleTarif
    /// </summary>
    public Task<ArticleTarif> ArticleTarif(ArticleTarifWhereUniqueInput uniqueId);

    /// <summary>
    /// Update one ArticleTarif
    /// </summary>
    public Task UpdateArticleTarif(
        ArticleTarifWhereUniqueInput uniqueId,
        ArticleTarifUpdateInput updateDto
    );
}
