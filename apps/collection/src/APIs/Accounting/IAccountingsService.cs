using Collection.APIs.Common;
using Collection.APIs.Dtos;

namespace Collection.APIs;

public interface IAccountingsService
{
    /// <summary>
    ///     Create one ACCOUNTING
    /// </summary>
    public Task<Accounting> CreateAccounting(AccountingCreateInput accounting);

    /// <summary>
    ///     Delete one ACCOUNTING
    /// </summary>
    public Task DeleteAccounting(AccountingWhereUniqueInput uniqueId);

    /// <summary>
    ///     Find many ACCOUNTINGS
    /// </summary>
    public Task<List<Accounting>> Accountings(AccountingFindManyArgs findManyArgs);

    /// <summary>
    ///     Meta data about ACCOUNTING records
    /// </summary>
    public Task<MetadataDto> AccountingsMeta(AccountingFindManyArgs findManyArgs);

    /// <summary>
    ///     Get one ACCOUNTING
    /// </summary>
    public Task<Accounting> Accounting(AccountingWhereUniqueInput uniqueId);

    /// <summary>
    ///     Update one ACCOUNTING
    /// </summary>
    public Task UpdateAccounting(
        AccountingWhereUniqueInput uniqueId,
        AccountingUpdateInput updateDto
    );
}
