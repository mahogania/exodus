using Collection.APIs.Common;
using Collection.APIs.Dtos;

namespace Collection.APIs;

public interface IDepositsService
{
    /// <summary>
    ///     Create one DEPOSIT
    /// </summary>
    public Task<Deposit> CreateDeposit(DepositCreateInput deposit);

    /// <summary>
    ///     Delete one DEPOSIT
    /// </summary>
    public Task DeleteDeposit(DepositWhereUniqueInput uniqueId);

    /// <summary>
    ///     Find many DEPOSITS
    /// </summary>
    public Task<List<Deposit>> Deposits(DepositFindManyArgs findManyArgs);

    /// <summary>
    ///     Meta data about DEPOSIT records
    /// </summary>
    public Task<MetadataDto> DepositsMeta(DepositFindManyArgs findManyArgs);

    /// <summary>
    ///     Get one DEPOSIT
    /// </summary>
    public Task<Deposit> Deposit(DepositWhereUniqueInput uniqueId);

    /// <summary>
    ///     Update one DEPOSIT
    /// </summary>
    public Task UpdateDeposit(DepositWhereUniqueInput uniqueId, DepositUpdateInput updateDto);
}
