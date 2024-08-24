using Control.APIs.Common;
using Control.APIs.Dtos;

namespace Control.APIs;

public interface IDetailedDeclarationTaxesService
{
    /// <summary>
    /// Create one Detailed Declaration Tax
    /// </summary>
    public Task<DetailedDeclarationTax> CreateDetailedDeclarationTax(
        DetailedDeclarationTaxCreateInput detaileddeclarationtax
    );

    /// <summary>
    /// Delete one Detailed Declaration Tax
    /// </summary>
    public Task DeleteDetailedDeclarationTax(DetailedDeclarationTaxWhereUniqueInput uniqueId);

    /// <summary>
    /// Find many CUSTOMS DETAILED DECLARATION TAXES
    /// </summary>
    public Task<List<DetailedDeclarationTax>> DetailedDeclarationTaxes(
        DetailedDeclarationTaxFindManyArgs findManyArgs
    );

    /// <summary>
    /// Meta data about Detailed Declaration Tax records
    /// </summary>
    public Task<MetadataDto> DetailedDeclarationTaxesMeta(
        DetailedDeclarationTaxFindManyArgs findManyArgs
    );

    /// <summary>
    /// Get one Detailed Declaration Tax
    /// </summary>
    public Task<DetailedDeclarationTax> DetailedDeclarationTax(
        DetailedDeclarationTaxWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Update one Detailed Declaration Tax
    /// </summary>
    public Task UpdateDetailedDeclarationTax(
        DetailedDeclarationTaxWhereUniqueInput uniqueId,
        DetailedDeclarationTaxUpdateInput updateDto
    );

    /// <summary>
    /// Get a Article record for Detailed Declaration Tax
    /// </summary>
    public Task<Article> GetArticle(DetailedDeclarationTaxWhereUniqueInput uniqueId);
}
