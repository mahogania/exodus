using Code.APIs.Common;
using Code.APIs.Dtos;

namespace Code.APIs;

public interface IArticlePeriodeApplicationTarifSpecialsService
{
    /// <summary>
    /// Create one ArticlePeriodeApplicationTarifSpecial
    /// </summary>
    public Task<ArticlePeriodeApplicationTarifSpecial> CreateArticlePeriodeApplicationTarifSpecial(
        ArticlePeriodeApplicationTarifSpecialCreateInput articleperiodeapplicationtarifspecial
    );

    /// <summary>
    /// Delete one ArticlePeriodeApplicationTarifSpecial
    /// </summary>
    public Task DeleteArticlePeriodeApplicationTarifSpecial(
        ArticlePeriodeApplicationTarifSpecialWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Find many ArticlePeriodeApplicationTarifSpecials
    /// </summary>
    public Task<List<ArticlePeriodeApplicationTarifSpecial>> ArticlePeriodeApplicationTarifSpecials(
        ArticlePeriodeApplicationTarifSpecialFindManyArgs findManyArgs
    );

    /// <summary>
    /// Meta data about ArticlePeriodeApplicationTarifSpecial records
    /// </summary>
    public Task<MetadataDto> ArticlePeriodeApplicationTarifSpecialsMeta(
        ArticlePeriodeApplicationTarifSpecialFindManyArgs findManyArgs
    );

    /// <summary>
    /// Get one ArticlePeriodeApplicationTarifSpecial
    /// </summary>
    public Task<ArticlePeriodeApplicationTarifSpecial> ArticlePeriodeApplicationTarifSpecial(
        ArticlePeriodeApplicationTarifSpecialWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Update one ArticlePeriodeApplicationTarifSpecial
    /// </summary>
    public Task UpdateArticlePeriodeApplicationTarifSpecial(
        ArticlePeriodeApplicationTarifSpecialWhereUniqueInput uniqueId,
        ArticlePeriodeApplicationTarifSpecialUpdateInput updateDto
    );
}
