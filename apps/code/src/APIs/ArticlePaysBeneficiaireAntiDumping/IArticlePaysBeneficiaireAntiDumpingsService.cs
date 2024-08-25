using Code.APIs.Common;
using Code.APIs.Dtos;

namespace Code.APIs;

public interface IArticlePaysBeneficiaireAntiDumpingsService
{
    /// <summary>
    /// Create one ArticlePaysBeneficiaireAntiDumping
    /// </summary>
    public Task<ArticlePaysBeneficiaireAntiDumping> CreateArticlePaysBeneficiaireAntiDumping(
        ArticlePaysBeneficiaireAntiDumpingCreateInput articlepaysbeneficiaireantidumping
    );

    /// <summary>
    /// Delete one ArticlePaysBeneficiaireAntiDumping
    /// </summary>
    public Task DeleteArticlePaysBeneficiaireAntiDumping(
        ArticlePaysBeneficiaireAntiDumpingWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Find many ArticlePaysBeneficiaireAntiDumpings
    /// </summary>
    public Task<List<ArticlePaysBeneficiaireAntiDumping>> ArticlePaysBeneficiaireAntiDumpings(
        ArticlePaysBeneficiaireAntiDumpingFindManyArgs findManyArgs
    );

    /// <summary>
    /// Meta data about ArticlePaysBeneficiaireAntiDumping records
    /// </summary>
    public Task<MetadataDto> ArticlePaysBeneficiaireAntiDumpingsMeta(
        ArticlePaysBeneficiaireAntiDumpingFindManyArgs findManyArgs
    );

    /// <summary>
    /// Get one ArticlePaysBeneficiaireAntiDumping
    /// </summary>
    public Task<ArticlePaysBeneficiaireAntiDumping> ArticlePaysBeneficiaireAntiDumping(
        ArticlePaysBeneficiaireAntiDumpingWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Update one ArticlePaysBeneficiaireAntiDumping
    /// </summary>
    public Task UpdateArticlePaysBeneficiaireAntiDumping(
        ArticlePaysBeneficiaireAntiDumpingWhereUniqueInput uniqueId,
        ArticlePaysBeneficiaireAntiDumpingUpdateInput updateDto
    );
}
