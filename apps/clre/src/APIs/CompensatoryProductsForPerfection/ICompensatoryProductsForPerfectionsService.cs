using Clre.APIs.Common;
using Clre.APIs.Dtos;

namespace Clre.APIs;

public interface ICompensatoryProductsForPerfectionsService
{
    /// <summary>
    /// Create one COMPENSATORY PRODUCTS FOR PERFECTION
    /// </summary>
    public Task<CompensatoryProductsForPerfection> CreateCompensatoryProductsForPerfection(
        CompensatoryProductsForPerfectionCreateInput compensatoryproductsforperfection
    );

    /// <summary>
    /// Delete one COMPENSATORY PRODUCTS FOR PERFECTION
    /// </summary>
    public Task DeleteCompensatoryProductsForPerfection(
        CompensatoryProductsForPerfectionWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Find many COMPENSATORY PRODUCTS FOR PERFECTIONS
    /// </summary>
    public Task<List<CompensatoryProductsForPerfection>> CompensatoryProductsForPerfections(
        CompensatoryProductsForPerfectionFindManyArgs findManyArgs
    );

    /// <summary>
    /// Meta data about COMPENSATORY PRODUCTS FOR PERFECTION records
    /// </summary>
    public Task<MetadataDto> CompensatoryProductsForPerfectionsMeta(
        CompensatoryProductsForPerfectionFindManyArgs findManyArgs
    );

    /// <summary>
    /// Get one COMPENSATORY PRODUCTS FOR PERFECTION
    /// </summary>
    public Task<CompensatoryProductsForPerfection> CompensatoryProductsForPerfection(
        CompensatoryProductsForPerfectionWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Update one COMPENSATORY PRODUCTS FOR PERFECTION
    /// </summary>
    public Task UpdateCompensatoryProductsForPerfection(
        CompensatoryProductsForPerfectionWhereUniqueInput uniqueId,
        CompensatoryProductsForPerfectionUpdateInput updateDto
    );
}
