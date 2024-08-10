using Collection.APIs.Dtos;
using Collection.Infrastructure.Models;

namespace Collection.APIs.Extensions;

public static class ManagementOfAccountingAccountsByPaymentNoticeTypesExtensions
{
    public static ManagementOfAccountingAccountsByPaymentNoticeType ToDto(
        this ManagementOfAccountingAccountsByPaymentNoticeTypeDbModel model
    )
    {
        return new ManagementOfAccountingAccountsByPaymentNoticeType
        {
            AccountCode = model.AccountCode,
            AlignmentOrder = model.AlignmentOrder,
            ApplicationStartDate = model.ApplicationStartDate,
            AuxiliaryJournalDesignation = model.AuxiliaryJournalDesignation,
            BalanceSheetCategoryCode = model.BalanceSheetCategoryCode,
            CreatedAt = model.CreatedAt,
            DeletionOn = model.DeletionOn,
            DetailSequenceNo = model.DetailSequenceNo,
            FinalModificationDateAndTime = model.FinalModificationDateAndTime,
            FinalModifierId = model.FinalModifierId,
            FirstRegistrantId = model.FirstRegistrantId,
            FirstRegistrationDateAndTime = model.FirstRegistrationDateAndTime,
            Id = model.Id,
            NoticeTypeCode = model.NoticeTypeCode,
            PartialOrParticularDistribution = model.PartialOrParticularDistribution,
            ReasonCodeByPaymentNoticeType = model.ReasonCodeByPaymentNoticeType,
            UpdatedAt = model.UpdatedAt
        };
    }

    public static ManagementOfAccountingAccountsByPaymentNoticeTypeDbModel ToModel(
        this ManagementOfAccountingAccountsByPaymentNoticeTypeUpdateInput updateDto,
        ManagementOfAccountingAccountsByPaymentNoticeTypeWhereUniqueInput uniqueId
    )
    {
        var managementOfAccountingAccountsByPaymentNoticeType =
            new ManagementOfAccountingAccountsByPaymentNoticeTypeDbModel
            {
                Id = uniqueId.Id,
                AccountCode = updateDto.AccountCode,
                AlignmentOrder = updateDto.AlignmentOrder,
                ApplicationStartDate = updateDto.ApplicationStartDate,
                AuxiliaryJournalDesignation = updateDto.AuxiliaryJournalDesignation,
                BalanceSheetCategoryCode = updateDto.BalanceSheetCategoryCode,
                DeletionOn = updateDto.DeletionOn,
                DetailSequenceNo = updateDto.DetailSequenceNo,
                FinalModificationDateAndTime = updateDto.FinalModificationDateAndTime,
                FinalModifierId = updateDto.FinalModifierId,
                FirstRegistrantId = updateDto.FirstRegistrantId,
                FirstRegistrationDateAndTime = updateDto.FirstRegistrationDateAndTime,
                NoticeTypeCode = updateDto.NoticeTypeCode,
                PartialOrParticularDistribution = updateDto.PartialOrParticularDistribution,
                ReasonCodeByPaymentNoticeType = updateDto.ReasonCodeByPaymentNoticeType
            };

        if (updateDto.CreatedAt != null)
            managementOfAccountingAccountsByPaymentNoticeType.CreatedAt = updateDto.CreatedAt.Value;
        if (updateDto.UpdatedAt != null)
            managementOfAccountingAccountsByPaymentNoticeType.UpdatedAt = updateDto.UpdatedAt.Value;

        return managementOfAccountingAccountsByPaymentNoticeType;
    }
}
