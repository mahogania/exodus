using Clre.APIs.Common;
using Clre.APIs.Dtos;

namespace Clre.APIs;

public interface ICustomsDetailedDeclarationTaxesService
{
    /// <summary>
    /// Create one CUSTOMS DETAILED DECLARATION TAX
    /// </summary>
    public Task<CustomsDetailedDeclarationTax> CreateCustomsDetailedDeclarationTax(
        CustomsDetailedDeclarationTaxCreateInput customsdetaileddeclarationtax
    );

    /// <summary>
    /// Delete one CUSTOMS DETAILED DECLARATION TAX
    /// </summary>
    public Task DeleteCustomsDetailedDeclarationTax(
        CustomsDetailedDeclarationTaxWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Find many CUSTOMS DETAILED DECLARATION TAXES
    /// </summary>
    public Task<List<CustomsDetailedDeclarationTax>> CustomsDetailedDeclarationTaxes(
        CustomsDetailedDeclarationTaxFindManyArgs findManyArgs
    );

    /// <summary>
    /// Meta data about CUSTOMS DETAILED DECLARATION TAX records
    /// </summary>
    public Task<MetadataDto> CustomsDetailedDeclarationTaxesMeta(
        CustomsDetailedDeclarationTaxFindManyArgs findManyArgs
    );

    /// <summary>
    /// Get one CUSTOMS DETAILED DECLARATION TAX
    /// </summary>
    public Task<CustomsDetailedDeclarationTax> CustomsDetailedDeclarationTax(
        CustomsDetailedDeclarationTaxWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Update one CUSTOMS DETAILED DECLARATION TAX
    /// </summary>
    public Task UpdateCustomsDetailedDeclarationTax(
        CustomsDetailedDeclarationTaxWhereUniqueInput uniqueId,
        CustomsDetailedDeclarationTaxUpdateInput updateDto
    );
}
