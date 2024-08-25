using Control.APIs.Common;
using Control.APIs.Dtos;

namespace Control.APIs;

public interface ICustomsDetailedDeclarationValueAssessmentArticlesService
{
    /// <summary>
    ///     Create one CUSTOMS DETAILED DECLARATION VALUE ASSESSMENT ARTICLE
    /// </summary>
    public Task<CustomsDetailedDeclarationValueAssessmentArticle>
        CreateCustomsDetailedDeclarationValueAssessmentArticle(
            CustomsDetailedDeclarationValueAssessmentArticleCreateInput customsdetaileddeclarationvalueassessmentarticle
        );

    /// <summary>
    ///     Delete one CUSTOMS DETAILED DECLARATION VALUE ASSESSMENT ARTICLE
    /// </summary>
    public Task DeleteCustomsDetailedDeclarationValueAssessmentArticle(
        CustomsDetailedDeclarationValueAssessmentArticleWhereUniqueInput uniqueId
    );

    /// <summary>
    ///     Find many CUSTOMS DETAILED DECLARATION VALUE ASSESSMENT ARTICLES
    /// </summary>
    public Task<
        List<CustomsDetailedDeclarationValueAssessmentArticle>
    > CustomsDetailedDeclarationValueAssessmentArticles(
        CustomsDetailedDeclarationValueAssessmentArticleFindManyArgs findManyArgs
    );

    /// <summary>
    ///     Meta data about CUSTOMS DETAILED DECLARATION VALUE ASSESSMENT ARTICLE records
    /// </summary>
    public Task<MetadataDto> CustomsDetailedDeclarationValueAssessmentArticlesMeta(
        CustomsDetailedDeclarationValueAssessmentArticleFindManyArgs findManyArgs
    );

    /// <summary>
    ///     Get one CUSTOMS DETAILED DECLARATION VALUE ASSESSMENT ARTICLE
    /// </summary>
    public Task<CustomsDetailedDeclarationValueAssessmentArticle> CustomsDetailedDeclarationValueAssessmentArticle(
        CustomsDetailedDeclarationValueAssessmentArticleWhereUniqueInput uniqueId
    );

    /// <summary>
    ///     Update one CUSTOMS DETAILED DECLARATION VALUE ASSESSMENT ARTICLE
    /// </summary>
    public Task UpdateCustomsDetailedDeclarationValueAssessmentArticle(
        CustomsDetailedDeclarationValueAssessmentArticleWhereUniqueInput uniqueId,
        CustomsDetailedDeclarationValueAssessmentArticleUpdateInput updateDto
    );
}
