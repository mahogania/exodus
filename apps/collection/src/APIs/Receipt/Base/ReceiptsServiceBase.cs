using Collection.APIs.Common;
using Collection.APIs.Dtos;
using Collection.APIs.Errors;
using Collection.APIs.Extensions;
using Collection.Infrastructure;
using Collection.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Collection.APIs;

public abstract class ReceiptsServiceBase : IReceiptsService
{
    protected readonly CollectionDbContext _context;

    public ReceiptsServiceBase(CollectionDbContext context)
    {
        _context = context;
    }

    /// <summary>
    ///     Create one RECEIPT
    /// </summary>
    public async Task<Receipt> CreateReceipt(ReceiptCreateInput createDto)
    {
        var receipt = new ReceiptDbModel
        {
            CollectionNo = createDto.CollectionNo,
            CreatedAt = createDto.CreatedAt,
            DeletionOn = createDto.DeletionOn,
            FinalModificationDateAndTime = createDto.FinalModificationDateAndTime,
            FinalModifierId = createDto.FinalModifierId,
            FirstRegistrantId = createDto.FirstRegistrantId,
            FirstRegistrationDateAndTime = createDto.FirstRegistrationDateAndTime,
            NoticeNo = createDto.NoticeNo,
            NumberOfIssuances = createDto.NumberOfIssuances,
            UpdatedAt = createDto.UpdatedAt
        };

        if (createDto.Id != null) receipt.Id = createDto.Id;

        _context.Receipts.Add(receipt);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<ReceiptDbModel>(receipt.Id);

        if (result == null) throw new NotFoundException();

        return result.ToDto();
    }

    /// <summary>
    ///     Delete one RECEIPT
    /// </summary>
    public async Task DeleteReceipt(ReceiptWhereUniqueInput uniqueId)
    {
        var receipt = await _context.Receipts.FindAsync(uniqueId.Id);
        if (receipt == null) throw new NotFoundException();

        _context.Receipts.Remove(receipt);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    ///     Find many RECEIPTS
    /// </summary>
    public async Task<List<Receipt>> Receipts(ReceiptFindManyArgs findManyArgs)
    {
        var receipts = await _context
            .Receipts.ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return receipts.ConvertAll(receipt => receipt.ToDto());
    }

    /// <summary>
    ///     Meta data about RECEIPT records
    /// </summary>
    public async Task<MetadataDto> ReceiptsMeta(ReceiptFindManyArgs findManyArgs)
    {
        var count = await _context.Receipts.ApplyWhere(findManyArgs.Where).CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    ///     Get one RECEIPT
    /// </summary>
    public async Task<Receipt> Receipt(ReceiptWhereUniqueInput uniqueId)
    {
        var receipts = await Receipts(
            new ReceiptFindManyArgs { Where = new ReceiptWhereInput { Id = uniqueId.Id } }
        );
        var receipt = receipts.FirstOrDefault();
        if (receipt == null) throw new NotFoundException();

        return receipt;
    }

    /// <summary>
    ///     Update one RECEIPT
    /// </summary>
    public async Task UpdateReceipt(ReceiptWhereUniqueInput uniqueId, ReceiptUpdateInput updateDto)
    {
        var receipt = updateDto.ToModel(uniqueId);

        _context.Entry(receipt).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!_context.Receipts.Any(e => e.Id == receipt.Id))
                throw new NotFoundException();
            throw;
        }
    }
}
