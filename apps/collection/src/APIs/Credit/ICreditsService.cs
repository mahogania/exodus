using Collection.APIs.Common;
using Collection.APIs.Dtos;

namespace Collection.APIs;

public interface ICreditsService
{
    /// <summary>
    ///     Create one CREDIT
    /// </summary>
    public Task<Credit> CreateCredit(CreditCreateInput credit);

    /// <summary>
    ///     Delete one CREDIT
    /// </summary>
    public Task DeleteCredit(CreditWhereUniqueInput uniqueId);

    /// <summary>
    ///     Find many CREDITS
    /// </summary>
    public Task<List<Credit>> Credits(CreditFindManyArgs findManyArgs);

    /// <summary>
    ///     Meta data about CREDIT records
    /// </summary>
    public Task<MetadataDto> CreditsMeta(CreditFindManyArgs findManyArgs);

    /// <summary>
    ///     Get one CREDIT
    /// </summary>
    public Task<Credit> Credit(CreditWhereUniqueInput uniqueId);

    /// <summary>
    ///     Update one CREDIT
    /// </summary>
    public Task UpdateCredit(CreditWhereUniqueInput uniqueId, CreditUpdateInput updateDto);
}
