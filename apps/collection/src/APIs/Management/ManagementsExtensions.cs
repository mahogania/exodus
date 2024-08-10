using Collection.APIs.Dtos;
using Collection.Infrastructure.Models;

namespace Collection.APIs.Extensions;

public static class ManagementsExtensions
{
    public static Management ToDto(this ManagementDbModel model)
    {
        return new Management
        {
            AccountCode = model.AccountCode,
            AccountingServiceCode = model.AccountingServiceCode,
            CreatedAt = model.CreatedAt,
            DeletionOn = model.DeletionOn,
            ErrorDate = model.ErrorDate,
            FinalModificationDateAndTime = model.FinalModificationDateAndTime,
            FinalModifierId = model.FinalModifierId,
            FirstRegistrantId = model.FirstRegistrantId,
            FirstRegistrationDateAndTime = model.FirstRegistrationDateAndTime,
            Id = model.Id,
            OfficeCode = model.OfficeCode,
            OperationReason = model.OperationReason,
            OrderOperationNumber = model.OrderOperationNumber,
            ReferenceFileRegistrationDate = model.ReferenceFileRegistrationDate,
            ReferenceNo = model.ReferenceNo,
            ReferenceNumberTypeCode = model.ReferenceNumberTypeCode,
            ServiceCode = model.ServiceCode,
            UpdatedAt = model.UpdatedAt,
            WriterServiceCode = model.WriterServiceCode
        };
    }

    public static ManagementDbModel ToModel(
        this ManagementUpdateInput updateDto,
        ManagementWhereUniqueInput uniqueId
    )
    {
        var management = new ManagementDbModel
        {
            Id = uniqueId.Id,
            AccountCode = updateDto.AccountCode,
            AccountingServiceCode = updateDto.AccountingServiceCode,
            DeletionOn = updateDto.DeletionOn,
            ErrorDate = updateDto.ErrorDate,
            FinalModificationDateAndTime = updateDto.FinalModificationDateAndTime,
            FinalModifierId = updateDto.FinalModifierId,
            FirstRegistrantId = updateDto.FirstRegistrantId,
            FirstRegistrationDateAndTime = updateDto.FirstRegistrationDateAndTime,
            OfficeCode = updateDto.OfficeCode,
            OperationReason = updateDto.OperationReason,
            OrderOperationNumber = updateDto.OrderOperationNumber,
            ReferenceFileRegistrationDate = updateDto.ReferenceFileRegistrationDate,
            ReferenceNo = updateDto.ReferenceNo,
            ReferenceNumberTypeCode = updateDto.ReferenceNumberTypeCode,
            ServiceCode = updateDto.ServiceCode,
            WriterServiceCode = updateDto.WriterServiceCode
        };

        if (updateDto.CreatedAt != null) management.CreatedAt = updateDto.CreatedAt.Value;
        if (updateDto.UpdatedAt != null) management.UpdatedAt = updateDto.UpdatedAt.Value;

        return management;
    }
}
