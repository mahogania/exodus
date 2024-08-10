using Control.APIs.Common;
using Control.APIs.Dtos;

namespace Control.APIs;

public interface IDetailedDeclarationOperatorCustomsItemsService
{
    /// <summary>
    ///     Create one DETAILED DECLARATION OPERATOR (CUSTOMS)
    /// </summary>
    public Task<DetailedDeclarationOperatorCustoms> CreateDetailedDeclarationOperatorCustoms(
        DetailedDeclarationOperatorCustomsCreateInput detaileddeclarationoperatorcustoms
    );

    /// <summary>
    ///     Delete one DETAILED DECLARATION OPERATOR (CUSTOMS)
    /// </summary>
    public Task DeleteDetailedDeclarationOperatorCustoms(
        DetailedDeclarationOperatorCustomsWhereUniqueInput uniqueId
    );

    /// <summary>
    ///     Find many DETAILED DECLARATION OPERATOR (CUSTOMS)s
    /// </summary>
    public Task<List<DetailedDeclarationOperatorCustoms>> DetailedDeclarationOperatorCustomsItems(
        DetailedDeclarationOperatorCustomsFindManyArgs findManyArgs
    );

    /// <summary>
    ///     Meta data about DETAILED DECLARATION OPERATOR (CUSTOMS) records
    /// </summary>
    public Task<MetadataDto> DetailedDeclarationOperatorCustomsItemsMeta(
        DetailedDeclarationOperatorCustomsFindManyArgs findManyArgs
    );

    /// <summary>
    ///     Get one DETAILED DECLARATION OPERATOR (CUSTOMS)
    /// </summary>
    public Task<DetailedDeclarationOperatorCustoms> DetailedDeclarationOperatorCustoms(
        DetailedDeclarationOperatorCustomsWhereUniqueInput uniqueId
    );

    /// <summary>
    ///     Update one DETAILED DECLARATION OPERATOR (CUSTOMS)
    /// </summary>
    public Task UpdateDetailedDeclarationOperatorCustoms(
        DetailedDeclarationOperatorCustomsWhereUniqueInput uniqueId,
        DetailedDeclarationOperatorCustomsUpdateInput updateDto
    );
}
