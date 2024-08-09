using Collection.APIs.Dtos;
using Collection.Infrastructure.Models;

namespace Collection.APIs.Extensions;

public static class OrdersExtensions
{
    public static Order ToDto(this OrderDbModel model)
    {
        return new Order
        {
            AccountCode = model.AccountCode,
            ApprovalId = model.ApprovalId,
            AttachmentId = model.AttachmentId,
            BankAccountNo = model.BankAccountNo,
            CollectionNo = model.CollectionNo,
            CreatedAt = model.CreatedAt,
            DeletionOn = model.DeletionOn,
            DraftingServiceCode = model.DraftingServiceCode,
            FinalModificationDateAndTime = model.FinalModificationDateAndTime,
            FinalModifierId = model.FinalModifierId,
            FinancialOfficerName = model.FinancialOfficerName,
            FirstRegistrantId = model.FirstRegistrantId,
            FirstRegistrationDateAndTime = model.FirstRegistrationDateAndTime,
            Id = model.Id,
            ImputationAccountCode = model.ImputationAccountCode,
            NiuCategoryCode = model.NiuCategoryCode,
            OfficeCode = model.OfficeCode,
            OperationPeriodYearMonth = model.OperationPeriodYearMonth,
            OperationSourceCode = model.OperationSourceCode,
            PaidAmount = model.PaidAmount,
            PaymentOrderClassificationCode = model.PaymentOrderClassificationCode,
            PaymentOrderDate = model.PaymentOrderDate,
            PaymentOrderNo = model.PaymentOrderNo,
            PaymentTypeCode = model.PaymentTypeCode,
            ReceiptDate = model.ReceiptDate,
            ReceiptNo = model.ReceiptNo,
            ReferenceDate = model.ReferenceDate,
            ReferenceNo = model.ReferenceNo,
            ReferenceNumberTypeCode = model.ReferenceNumberTypeCode,
            RegisteringPersonId = model.RegisteringPersonId,
            ServiceCode = model.ServiceCode,
            TaxpayerIdentificationNo = model.TaxpayerIdentificationNo,
            UpdatedAt = model.UpdatedAt,
        };
    }

    public static OrderDbModel ToModel(
        this OrderUpdateInput updateDto,
        OrderWhereUniqueInput uniqueId
    )
    {
        var order = new OrderDbModel
        {
            Id = uniqueId.Id,
            AccountCode = updateDto.AccountCode,
            ApprovalId = updateDto.ApprovalId,
            AttachmentId = updateDto.AttachmentId,
            BankAccountNo = updateDto.BankAccountNo,
            CollectionNo = updateDto.CollectionNo,
            DeletionOn = updateDto.DeletionOn,
            DraftingServiceCode = updateDto.DraftingServiceCode,
            FinalModificationDateAndTime = updateDto.FinalModificationDateAndTime,
            FinalModifierId = updateDto.FinalModifierId,
            FinancialOfficerName = updateDto.FinancialOfficerName,
            FirstRegistrantId = updateDto.FirstRegistrantId,
            FirstRegistrationDateAndTime = updateDto.FirstRegistrationDateAndTime,
            ImputationAccountCode = updateDto.ImputationAccountCode,
            NiuCategoryCode = updateDto.NiuCategoryCode,
            OfficeCode = updateDto.OfficeCode,
            OperationPeriodYearMonth = updateDto.OperationPeriodYearMonth,
            OperationSourceCode = updateDto.OperationSourceCode,
            PaidAmount = updateDto.PaidAmount,
            PaymentOrderClassificationCode = updateDto.PaymentOrderClassificationCode,
            PaymentOrderDate = updateDto.PaymentOrderDate,
            PaymentOrderNo = updateDto.PaymentOrderNo,
            PaymentTypeCode = updateDto.PaymentTypeCode,
            ReceiptDate = updateDto.ReceiptDate,
            ReceiptNo = updateDto.ReceiptNo,
            ReferenceDate = updateDto.ReferenceDate,
            ReferenceNo = updateDto.ReferenceNo,
            ReferenceNumberTypeCode = updateDto.ReferenceNumberTypeCode,
            RegisteringPersonId = updateDto.RegisteringPersonId,
            ServiceCode = updateDto.ServiceCode,
            TaxpayerIdentificationNo = updateDto.TaxpayerIdentificationNo
        };

        if (updateDto.CreatedAt != null)
        {
            order.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.UpdatedAt != null)
        {
            order.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return order;
    }
}
