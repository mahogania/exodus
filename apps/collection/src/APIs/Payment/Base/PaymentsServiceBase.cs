using Collection.APIs.Common;
using Collection.APIs.Dtos;
using Collection.APIs.Errors;
using Collection.APIs.Extensions;
using Collection.Infrastructure;
using Collection.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Collection.APIs;

public abstract class PaymentsServiceBase : IPaymentsService
{
    protected readonly CollectionDbContext _context;

    public PaymentsServiceBase(CollectionDbContext context)
    {
        _context = context;
    }

    /// <summary>
    ///     Create one PAYMENT
    /// </summary>
    public async Task<Payment> CreatePayment(PaymentCreateInput createDto)
    {
        var payment = new PaymentDbModel
        {
            AccountCode = createDto.AccountCode,
            BankAgencyCode = createDto.BankAgencyCode,
            Cents = createDto.Cents,
            CheckNature = createDto.CheckNature,
            CheckType = createDto.CheckType,
            CollectionBankCode = createDto.CollectionBankCode,
            CollectionNo = createDto.CollectionNo,
            CreatedAt = createDto.CreatedAt,
            CreditInterest = createDto.CreditInterest,
            CustomsDutiesTotalAmountToPay = createDto.CustomsDutiesTotalAmountToPay,
            DeletionOn = createDto.DeletionOn,
            DetailSequenceNo = createDto.DetailSequenceNo,
            DueDate = createDto.DueDate,
            FeeAmount = createDto.FeeAmount,
            FinalModificationDateAndTime = createDto.FinalModificationDateAndTime,
            FinalModifierId = createDto.FinalModifierId,
            FinancialOfficerName = createDto.FinancialOfficerName,
            FirstRegistrantId = createDto.FirstRegistrantId,
            FirstRegistrationDateAndTime = createDto.FirstRegistrationDateAndTime,
            ImportDeclarationDate = createDto.ImportDeclarationDate,
            InspectionTaxCheckDate = createDto.InspectionTaxCheckDate,
            InspectionTaxCheckNumber = createDto.InspectionTaxCheckNumber,
            NiuCategoryCode = createDto.NiuCategoryCode,
            OfficeCode = createDto.OfficeCode,
            OrderNumber = createDto.OrderNumber,
            PaidAmount = createDto.PaidAmount,
            PaymentTypeCode = createDto.PaymentTypeCode,
            ServiceCode = createDto.ServiceCode,
            TaxpayerIdentificationNo = createDto.TaxpayerIdentificationNo,
            UpdatedAt = createDto.UpdatedAt
        };

        if (createDto.Id != null) payment.Id = createDto.Id;

        _context.Payments.Add(payment);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<PaymentDbModel>(payment.Id);

        if (result == null) throw new NotFoundException();

        return result.ToDto();
    }

    /// <summary>
    ///     Delete one PAYMENT
    /// </summary>
    public async Task DeletePayment(PaymentWhereUniqueInput uniqueId)
    {
        var payment = await _context.Payments.FindAsync(uniqueId.Id);
        if (payment == null) throw new NotFoundException();

        _context.Payments.Remove(payment);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    ///     Find many PAYMENTS
    /// </summary>
    public async Task<List<Payment>> Payments(PaymentFindManyArgs findManyArgs)
    {
        var payments = await _context
            .Payments.ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return payments.ConvertAll(payment => payment.ToDto());
    }

    /// <summary>
    ///     Meta data about PAYMENT records
    /// </summary>
    public async Task<MetadataDto> PaymentsMeta(PaymentFindManyArgs findManyArgs)
    {
        var count = await _context.Payments.ApplyWhere(findManyArgs.Where).CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    ///     Get one PAYMENT
    /// </summary>
    public async Task<Payment> Payment(PaymentWhereUniqueInput uniqueId)
    {
        var payments = await Payments(
            new PaymentFindManyArgs { Where = new PaymentWhereInput { Id = uniqueId.Id } }
        );
        var payment = payments.FirstOrDefault();
        if (payment == null) throw new NotFoundException();

        return payment;
    }

    /// <summary>
    ///     Update one PAYMENT
    /// </summary>
    public async Task UpdatePayment(PaymentWhereUniqueInput uniqueId, PaymentUpdateInput updateDto)
    {
        var payment = updateDto.ToModel(uniqueId);

        _context.Entry(payment).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!_context.Payments.Any(e => e.Id == payment.Id))
                throw new NotFoundException();
            throw;
        }
    }
}
