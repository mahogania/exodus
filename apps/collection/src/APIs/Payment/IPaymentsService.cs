using Collection.APIs.Common;
using Collection.APIs.Dtos;

namespace Collection.APIs;

public interface IPaymentsService
{
    /// <summary>
    /// Create one PAYMENT
    /// </summary>
    public Task<Payment> CreatePayment(PaymentCreateInput payment);

    /// <summary>
    /// Delete one PAYMENT
    /// </summary>
    public Task DeletePayment(PaymentWhereUniqueInput uniqueId);

    /// <summary>
    /// Find many PAYMENTS
    /// </summary>
    public Task<List<Payment>> Payments(PaymentFindManyArgs findManyArgs);

    /// <summary>
    /// Meta data about PAYMENT records
    /// </summary>
    public Task<MetadataDto> PaymentsMeta(PaymentFindManyArgs findManyArgs);

    /// <summary>
    /// Get one PAYMENT
    /// </summary>
    public Task<Payment> Payment(PaymentWhereUniqueInput uniqueId);

    /// <summary>
    /// Update one PAYMENT
    /// </summary>
    public Task UpdatePayment(PaymentWhereUniqueInput uniqueId, PaymentUpdateInput updateDto);
}
