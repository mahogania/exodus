using Code.APIs.Common;
using Code.APIs.Dtos;

namespace Code.APIs;

public interface IArticlePeriodeApplicationTarifNormalsService
{
    /// <summary>
    /// Create one ArticlePeriodeApplicationTarifNormal
    /// </summary>
    public Task<ArticlePeriodeApplicationTarifNormal> CreateArticlePeriodeApplicationTarifNormal(
        ArticlePeriodeApplicationTarifNormalCreateInput articleperiodeapplicationtarifnormal
    );

    /// <summary>
    /// Delete one ArticlePeriodeApplicationTarifNormal
    /// </summary>
    public Task DeleteArticlePeriodeApplicationTarifNormal(
        ArticlePeriodeApplicationTarifNormalWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Find many ArticlePeriodeApplicationTarifNormals
    /// </summary>
    public Task<List<ArticlePeriodeApplicationTarifNormal>> ArticlePeriodeApplicationTarifNormals(
        ArticlePeriodeApplicationTarifNormalFindManyArgs findManyArgs
    );

    /// <summary>
    /// Meta data about ArticlePeriodeApplicationTarifNormal records
    /// </summary>
    public Task<MetadataDto> ArticlePeriodeApplicationTarifNormalsMeta(
        ArticlePeriodeApplicationTarifNormalFindManyArgs findManyArgs
    );

    /// <summary>
    /// Get one ArticlePeriodeApplicationTarifNormal
    /// </summary>
    public Task<ArticlePeriodeApplicationTarifNormal> ArticlePeriodeApplicationTarifNormal(
        ArticlePeriodeApplicationTarifNormalWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Update one ArticlePeriodeApplicationTarifNormal
    /// </summary>
    public Task UpdateArticlePeriodeApplicationTarifNormal(
        ArticlePeriodeApplicationTarifNormalWhereUniqueInput uniqueId,
        ArticlePeriodeApplicationTarifNormalUpdateInput updateDto
    );
}
