using Control.APIs.Common;
using Control.APIs.Dtos;

namespace Control.APIs;

public interface ICustomsDeclarationBondsService
{
    /// <summary>
    ///     Create one CUSTOMS DECLARATION BOND
    /// </summary>
    public Task<CustomsDeclarationBond> CreateCustomsDeclarationBond(
        CustomsDeclarationBondCreateInput customsdeclarationbond
    );

    /// <summary>
    ///     Delete one CUSTOMS DECLARATION BOND
    /// </summary>
    public Task DeleteCustomsDeclarationBond(CustomsDeclarationBondWhereUniqueInput uniqueId);

    /// <summary>
    ///     Find many CUSTOMS DECLARATION BONDS
    /// </summary>
    public Task<List<CustomsDeclarationBond>> CustomsDeclarationBonds(
        CustomsDeclarationBondFindManyArgs findManyArgs
    );

    /// <summary>
    ///     Meta data about CUSTOMS DECLARATION BOND records
    /// </summary>
    public Task<MetadataDto> CustomsDeclarationBondsMeta(
        CustomsDeclarationBondFindManyArgs findManyArgs
    );

    /// <summary>
    ///     Get one CUSTOMS DECLARATION BOND
    /// </summary>
    public Task<CustomsDeclarationBond> CustomsDeclarationBond(
        CustomsDeclarationBondWhereUniqueInput uniqueId
    );

    /// <summary>
    ///     Update one CUSTOMS DECLARATION BOND
    /// </summary>
    public Task UpdateCustomsDeclarationBond(
        CustomsDeclarationBondWhereUniqueInput uniqueId,
        CustomsDeclarationBondUpdateInput updateDto
    );
}
