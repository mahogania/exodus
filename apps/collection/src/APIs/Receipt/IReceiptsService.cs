using Collection.APIs.Common;
using Collection.APIs.Dtos;

namespace Collection.APIs;

public interface IReceiptsService
{
    /// <summary>
    ///     Create one RECEIPT
    /// </summary>
    public Task<Receipt> CreateReceipt(ReceiptCreateInput receipt);

    /// <summary>
    ///     Delete one RECEIPT
    /// </summary>
    public Task DeleteReceipt(ReceiptWhereUniqueInput uniqueId);

    /// <summary>
    ///     Find many RECEIPTS
    /// </summary>
    public Task<List<Receipt>> Receipts(ReceiptFindManyArgs findManyArgs);

    /// <summary>
    ///     Meta data about RECEIPT records
    /// </summary>
    public Task<MetadataDto> ReceiptsMeta(ReceiptFindManyArgs findManyArgs);

    /// <summary>
    ///     Get one RECEIPT
    /// </summary>
    public Task<Receipt> Receipt(ReceiptWhereUniqueInput uniqueId);

    /// <summary>
    ///     Update one RECEIPT
    /// </summary>
    public Task UpdateReceipt(ReceiptWhereUniqueInput uniqueId, ReceiptUpdateInput updateDto);
}
