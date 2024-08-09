using Collection.APIs.Dtos;
using Collection.Infrastructure.Models;

namespace Collection.APIs.Extensions;

public static class AccountingsExtensions
{
    public static Accounting ToDto(this AccountingDbModel model)
    {
        return new Accounting
        {
            ApprovalId = model.ApprovalId,
            AttachmentId = model.AttachmentId,
            ContainerSize = model.ContainerSize,
            CreatedAt = model.CreatedAt,
            Crn = model.Crn,
            CustomsAreaCode = model.CustomsAreaCode,
            DeletionOn = model.DeletionOn,
            FinalModificationDateAndTime = model.FinalModificationDateAndTime,
            FinalModifierId = model.FinalModifierId,
            FinalUseCode = model.FinalUseCode,
            FirstRegistrantId = model.FirstRegistrantId,
            FirstRegistrationDateAndTime = model.FirstRegistrationDateAndTime,
            HandlingDate = model.HandlingDate,
            Id = model.Id,
            ItemName = model.ItemName,
            NumberOfPackages = model.NumberOfPackages,
            OfficeCode = model.OfficeCode,
            ReferenceFileRegistrationDate = model.ReferenceFileRegistrationDate,
            ReferenceNo = model.ReferenceNo,
            ReferenceNumberTypeCode = model.ReferenceNumberTypeCode,
            ReferenceNumberTypeName = model.ReferenceNumberTypeName,
            ServiceCode = model.ServiceCode,
            StockAccountingManagementNumber = model.StockAccountingManagementNumber,
            Storage = model.Storage,
            UpdatedAt = model.UpdatedAt,
            Weight = model.Weight,
        };
    }

    public static AccountingDbModel ToModel(
        this AccountingUpdateInput updateDto,
        AccountingWhereUniqueInput uniqueId
    )
    {
        var accounting = new AccountingDbModel
        {
            Id = uniqueId.Id,
            ApprovalId = updateDto.ApprovalId,
            AttachmentId = updateDto.AttachmentId,
            ContainerSize = updateDto.ContainerSize,
            Crn = updateDto.Crn,
            CustomsAreaCode = updateDto.CustomsAreaCode,
            DeletionOn = updateDto.DeletionOn,
            FinalModificationDateAndTime = updateDto.FinalModificationDateAndTime,
            FinalModifierId = updateDto.FinalModifierId,
            FinalUseCode = updateDto.FinalUseCode,
            FirstRegistrantId = updateDto.FirstRegistrantId,
            FirstRegistrationDateAndTime = updateDto.FirstRegistrationDateAndTime,
            HandlingDate = updateDto.HandlingDate,
            ItemName = updateDto.ItemName,
            NumberOfPackages = updateDto.NumberOfPackages,
            OfficeCode = updateDto.OfficeCode,
            ReferenceFileRegistrationDate = updateDto.ReferenceFileRegistrationDate,
            ReferenceNo = updateDto.ReferenceNo,
            ReferenceNumberTypeCode = updateDto.ReferenceNumberTypeCode,
            ReferenceNumberTypeName = updateDto.ReferenceNumberTypeName,
            ServiceCode = updateDto.ServiceCode,
            StockAccountingManagementNumber = updateDto.StockAccountingManagementNumber,
            Storage = updateDto.Storage,
            Weight = updateDto.Weight
        };

        if (updateDto.CreatedAt != null)
        {
            accounting.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.UpdatedAt != null)
        {
            accounting.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return accounting;
    }
}
