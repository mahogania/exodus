using Collection.APIs.Common;
using Collection.APIs.Dtos;
using Collection.APIs.Errors;
using Collection.APIs.Extensions;
using Collection.Infrastructure;
using Collection.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Collection.APIs;

public abstract class DepositsServiceBase : IDepositsService
{
    protected readonly CollectionDbContext _context;

    public DepositsServiceBase(CollectionDbContext context)
    {
        _context = context;
    }

    /// <summary>
    ///     Create one DEPOSIT
    /// </summary>
    public async Task<Deposit> CreateDeposit(DepositCreateInput createDto)
    {
        var deposit = new DepositDbModel
        {
            AmountUsed = createDto.AmountUsed,
            CreatedAt = createDto.CreatedAt,
            DeletionOn = createDto.DeletionOn,
            DepositCeiling = createDto.DepositCeiling,
            FinalModificationDateAndTime = createDto.FinalModificationDateAndTime,
            FinalModifierId = createDto.FinalModifierId,
            FirstRegistrantId = createDto.FirstRegistrantId,
            FirstRegistrationDateAndTime = createDto.FirstRegistrationDateAndTime,
            NumberOfTimesUsed = createDto.NumberOfTimesUsed,
            ReferenceNo = createDto.ReferenceNo,
            ReferenceNumberTypeCode = createDto.ReferenceNumberTypeCode,
            RequestNo = createDto.RequestNo,
            UpdatedAt = createDto.UpdatedAt,
            UsageMoment = createDto.UsageMoment
        };

        if (createDto.Id != null) deposit.Id = createDto.Id;

        _context.Deposits.Add(deposit);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<DepositDbModel>(deposit.Id);

        if (result == null) throw new NotFoundException();

        return result.ToDto();
    }

    /// <summary>
    ///     Delete one DEPOSIT
    /// </summary>
    public async Task DeleteDeposit(DepositWhereUniqueInput uniqueId)
    {
        var deposit = await _context.Deposits.FindAsync(uniqueId.Id);
        if (deposit == null) throw new NotFoundException();

        _context.Deposits.Remove(deposit);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    ///     Find many DEPOSITS
    /// </summary>
    public async Task<List<Deposit>> Deposits(DepositFindManyArgs findManyArgs)
    {
        var deposits = await _context
            .Deposits.ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return deposits.ConvertAll(deposit => deposit.ToDto());
    }

    /// <summary>
    ///     Meta data about DEPOSIT records
    /// </summary>
    public async Task<MetadataDto> DepositsMeta(DepositFindManyArgs findManyArgs)
    {
        var count = await _context.Deposits.ApplyWhere(findManyArgs.Where).CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    ///     Get one DEPOSIT
    /// </summary>
    public async Task<Deposit> Deposit(DepositWhereUniqueInput uniqueId)
    {
        var deposits = await Deposits(
            new DepositFindManyArgs { Where = new DepositWhereInput { Id = uniqueId.Id } }
        );
        var deposit = deposits.FirstOrDefault();
        if (deposit == null) throw new NotFoundException();

        return deposit;
    }

    /// <summary>
    ///     Update one DEPOSIT
    /// </summary>
    public async Task UpdateDeposit(DepositWhereUniqueInput uniqueId, DepositUpdateInput updateDto)
    {
        var deposit = updateDto.ToModel(uniqueId);

        _context.Entry(deposit).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!_context.Deposits.Any(e => e.Id == deposit.Id))
                throw new NotFoundException();
            throw;
        }
    }
}
