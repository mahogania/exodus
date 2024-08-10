using Collection.APIs.Common;
using Collection.APIs.Dtos;
using Collection.APIs.Errors;
using Collection.APIs.Extensions;
using Collection.Infrastructure;
using Collection.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Collection.APIs;

public abstract class OrdersServiceBase : IOrdersService
{
    protected readonly CollectionDbContext _context;

    public OrdersServiceBase(CollectionDbContext context)
    {
        _context = context;
    }

    /// <summary>
    ///     Create one ORDER
    /// </summary>
    public async Task<Order> CreateOrder(OrderCreateInput createDto)
    {
        var order = new OrderDbModel
        {
            AccountCode = createDto.AccountCode,
            ApprovalId = createDto.ApprovalId,
            AttachmentId = createDto.AttachmentId,
            BankAccountNo = createDto.BankAccountNo,
            CollectionNo = createDto.CollectionNo,
            CreatedAt = createDto.CreatedAt,
            DeletionOn = createDto.DeletionOn,
            DraftingServiceCode = createDto.DraftingServiceCode,
            FinalModificationDateAndTime = createDto.FinalModificationDateAndTime,
            FinalModifierId = createDto.FinalModifierId,
            FinancialOfficerName = createDto.FinancialOfficerName,
            FirstRegistrantId = createDto.FirstRegistrantId,
            FirstRegistrationDateAndTime = createDto.FirstRegistrationDateAndTime,
            ImputationAccountCode = createDto.ImputationAccountCode,
            NiuCategoryCode = createDto.NiuCategoryCode,
            OfficeCode = createDto.OfficeCode,
            OperationPeriodYearMonth = createDto.OperationPeriodYearMonth,
            OperationSourceCode = createDto.OperationSourceCode,
            PaidAmount = createDto.PaidAmount,
            PaymentOrderClassificationCode = createDto.PaymentOrderClassificationCode,
            PaymentOrderDate = createDto.PaymentOrderDate,
            PaymentOrderNo = createDto.PaymentOrderNo,
            PaymentTypeCode = createDto.PaymentTypeCode,
            ReceiptDate = createDto.ReceiptDate,
            ReceiptNo = createDto.ReceiptNo,
            ReferenceDate = createDto.ReferenceDate,
            ReferenceNo = createDto.ReferenceNo,
            ReferenceNumberTypeCode = createDto.ReferenceNumberTypeCode,
            RegisteringPersonId = createDto.RegisteringPersonId,
            ServiceCode = createDto.ServiceCode,
            TaxpayerIdentificationNo = createDto.TaxpayerIdentificationNo,
            UpdatedAt = createDto.UpdatedAt
        };

        if (createDto.Id != null) order.Id = createDto.Id;

        _context.Orders.Add(order);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<OrderDbModel>(order.Id);

        if (result == null) throw new NotFoundException();

        return result.ToDto();
    }

    /// <summary>
    ///     Delete one ORDER
    /// </summary>
    public async Task DeleteOrder(OrderWhereUniqueInput uniqueId)
    {
        var order = await _context.Orders.FindAsync(uniqueId.Id);
        if (order == null) throw new NotFoundException();

        _context.Orders.Remove(order);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    ///     Find many ORDERS
    /// </summary>
    public async Task<List<Order>> Orders(OrderFindManyArgs findManyArgs)
    {
        var orders = await _context
            .Orders.ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return orders.ConvertAll(order => order.ToDto());
    }

    /// <summary>
    ///     Meta data about ORDER records
    /// </summary>
    public async Task<MetadataDto> OrdersMeta(OrderFindManyArgs findManyArgs)
    {
        var count = await _context.Orders.ApplyWhere(findManyArgs.Where).CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    ///     Get one ORDER
    /// </summary>
    public async Task<Order> Order(OrderWhereUniqueInput uniqueId)
    {
        var orders = await Orders(
            new OrderFindManyArgs { Where = new OrderWhereInput { Id = uniqueId.Id } }
        );
        var order = orders.FirstOrDefault();
        if (order == null) throw new NotFoundException();

        return order;
    }

    /// <summary>
    ///     Update one ORDER
    /// </summary>
    public async Task UpdateOrder(OrderWhereUniqueInput uniqueId, OrderUpdateInput updateDto)
    {
        var order = updateDto.ToModel(uniqueId);

        _context.Entry(order).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!_context.Orders.Any(e => e.Id == order.Id))
                throw new NotFoundException();
            throw;
        }
    }
}
