using Collection.APIs.Dtos;
using Collection.Infrastructure.Models;

namespace Collection.APIs.Extensions;

public static class PaymentsExtensions
{
    public static Payment ToDto(this PaymentDbModel model)
    {
        return new Payment
        {
            AccountCode = model.AccountCode,
            BankAgencyCode = model.BankAgencyCode,
            Cents = model.Cents,
            CheckNature = model.CheckNature,
            CheckType = model.CheckType,
            CollectionBankCode = model.CollectionBankCode,
            CollectionNo = model.CollectionNo,
            CreatedAt = model.CreatedAt,
            CreditInterest = model.CreditInterest,
            CustomsDutiesTotalAmountToPay = model.CustomsDutiesTotalAmountToPay,
            DeletionOn = model.DeletionOn,
            DetailSequenceNo = model.DetailSequenceNo,
            DueDate = model.DueDate,
            FeeAmount = model.FeeAmount,
            FinalModificationDateAndTime = model.FinalModificationDateAndTime,
            FinalModifierId = model.FinalModifierId,
            FinancialOfficerName = model.FinancialOfficerName,
            FirstRegistrantId = model.FirstRegistrantId,
            FirstRegistrationDateAndTime = model.FirstRegistrationDateAndTime,
            Id = model.Id,
            ImportDeclarationDate = model.ImportDeclarationDate,
            InspectionTaxCheckDate = model.InspectionTaxCheckDate,
            InspectionTaxCheckNumber = model.InspectionTaxCheckNumber,
            NiuCategoryCode = model.NiuCategoryCode,
            OfficeCode = model.OfficeCode,
            OrderNumber = model.OrderNumber,
            PaidAmount = model.PaidAmount,
            PaymentTypeCode = model.PaymentTypeCode,
            ServiceCode = model.ServiceCode,
            TaxpayerIdentificationNo = model.TaxpayerIdentificationNo,
            UpdatedAt = model.UpdatedAt,
        };
    }

    public static PaymentDbModel ToModel(
        this PaymentUpdateInput updateDto,
        PaymentWhereUniqueInput uniqueId
    )
    {
        var payment = new PaymentDbModel
        {
            Id = uniqueId.Id,
            AccountCode = updateDto.AccountCode,
            BankAgencyCode = updateDto.BankAgencyCode,
            Cents = updateDto.Cents,
            CheckNature = updateDto.CheckNature,
            CheckType = updateDto.CheckType,
            CollectionBankCode = updateDto.CollectionBankCode,
            CollectionNo = updateDto.CollectionNo,
            CreditInterest = updateDto.CreditInterest,
            CustomsDutiesTotalAmountToPay = updateDto.CustomsDutiesTotalAmountToPay,
            DeletionOn = updateDto.DeletionOn,
            DetailSequenceNo = updateDto.DetailSequenceNo,
            DueDate = updateDto.DueDate,
            FeeAmount = updateDto.FeeAmount,
            FinalModificationDateAndTime = updateDto.FinalModificationDateAndTime,
            FinalModifierId = updateDto.FinalModifierId,
            FinancialOfficerName = updateDto.FinancialOfficerName,
            FirstRegistrantId = updateDto.FirstRegistrantId,
            FirstRegistrationDateAndTime = updateDto.FirstRegistrationDateAndTime,
            ImportDeclarationDate = updateDto.ImportDeclarationDate,
            InspectionTaxCheckDate = updateDto.InspectionTaxCheckDate,
            InspectionTaxCheckNumber = updateDto.InspectionTaxCheckNumber,
            NiuCategoryCode = updateDto.NiuCategoryCode,
            OfficeCode = updateDto.OfficeCode,
            OrderNumber = updateDto.OrderNumber,
            PaidAmount = updateDto.PaidAmount,
            PaymentTypeCode = updateDto.PaymentTypeCode,
            ServiceCode = updateDto.ServiceCode,
            TaxpayerIdentificationNo = updateDto.TaxpayerIdentificationNo
        };

        if (updateDto.CreatedAt != null)
        {
            payment.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.UpdatedAt != null)
        {
            payment.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return payment;
    }
}
