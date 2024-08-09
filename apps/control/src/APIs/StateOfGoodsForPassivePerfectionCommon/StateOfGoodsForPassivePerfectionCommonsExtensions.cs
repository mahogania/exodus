using Clre.APIs.Dtos;
using Clre.Infrastructure.Models;

namespace Clre.APIs.Extensions;

public static class StateOfGoodsForPassivePerfectionCommonsExtensions
{
    public static StateOfGoodsForPassivePerfectionCommon ToDto(
        this StateOfGoodsForPassivePerfectionCommonDbModel model
    )
    {
        return new StateOfGoodsForPassivePerfectionCommon
        {
            CompanyAddress = model.CompanyAddress,
            CompanyName = model.CompanyName,
            CreatedAt = model.CreatedAt,
            CustomsCodeOfExportDeclaration = model.CustomsCodeOfExportDeclaration,
            CustomsCodeOfImportDeclaration = model.CustomsCodeOfImportDeclaration,
            DeletionOn = model.DeletionOn,
            DocumentCode = model.DocumentCode,
            EndDateOfGrantedDeadline = model.EndDateOfGrantedDeadline,
            FinalModificationDateAndTime = model.FinalModificationDateAndTime,
            FinalModifierSId = model.FinalModifierSId,
            FirstRecorderSId = model.FirstRecorderSId,
            FirstRegistrationDateAndTime = model.FirstRegistrationDateAndTime,
            Id = model.Id,
            NatureOfPassivePerfection = model.NatureOfPassivePerfection,
            PaymentBankAgencyCode = model.PaymentBankAgencyCode,
            PaymentBankCode = model.PaymentBankCode,
            PaymentModeCode = model.PaymentModeCode,
            ReasonsCitedInFavorOfTheOperation = model.ReasonsCitedInFavorOfTheOperation,
            RectificationFrequency = model.RectificationFrequency,
            RegimeRequestNumber = model.RegimeRequestNumber,
            SpecifyOtherPaymentMethods = model.SpecifyOtherPaymentMethods,
            StartDateOfGrantedDeadline = model.StartDateOfGrantedDeadline,
            TotalAmount = model.TotalAmount,
            TransactionValueCurrencyCode = model.TransactionValueCurrencyCode,
            UpdatedAt = model.UpdatedAt,
        };
    }

    public static StateOfGoodsForPassivePerfectionCommonDbModel ToModel(
        this StateOfGoodsForPassivePerfectionCommonUpdateInput updateDto,
        StateOfGoodsForPassivePerfectionCommonWhereUniqueInput uniqueId
    )
    {
        var stateOfGoodsForPassivePerfectionCommon =
            new StateOfGoodsForPassivePerfectionCommonDbModel
            {
                Id = uniqueId.Id,
                CompanyAddress = updateDto.CompanyAddress,
                CompanyName = updateDto.CompanyName,
                CustomsCodeOfExportDeclaration = updateDto.CustomsCodeOfExportDeclaration,
                CustomsCodeOfImportDeclaration = updateDto.CustomsCodeOfImportDeclaration,
                DeletionOn = updateDto.DeletionOn,
                DocumentCode = updateDto.DocumentCode,
                EndDateOfGrantedDeadline = updateDto.EndDateOfGrantedDeadline,
                FinalModificationDateAndTime = updateDto.FinalModificationDateAndTime,
                FinalModifierSId = updateDto.FinalModifierSId,
                FirstRecorderSId = updateDto.FirstRecorderSId,
                FirstRegistrationDateAndTime = updateDto.FirstRegistrationDateAndTime,
                NatureOfPassivePerfection = updateDto.NatureOfPassivePerfection,
                PaymentBankAgencyCode = updateDto.PaymentBankAgencyCode,
                PaymentBankCode = updateDto.PaymentBankCode,
                PaymentModeCode = updateDto.PaymentModeCode,
                ReasonsCitedInFavorOfTheOperation = updateDto.ReasonsCitedInFavorOfTheOperation,
                RectificationFrequency = updateDto.RectificationFrequency,
                RegimeRequestNumber = updateDto.RegimeRequestNumber,
                SpecifyOtherPaymentMethods = updateDto.SpecifyOtherPaymentMethods,
                StartDateOfGrantedDeadline = updateDto.StartDateOfGrantedDeadline,
                TotalAmount = updateDto.TotalAmount,
                TransactionValueCurrencyCode = updateDto.TransactionValueCurrencyCode
            };

        if (updateDto.CreatedAt != null)
        {
            stateOfGoodsForPassivePerfectionCommon.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.UpdatedAt != null)
        {
            stateOfGoodsForPassivePerfectionCommon.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return stateOfGoodsForPassivePerfectionCommon;
    }
}
