using Collection.APIs.Dtos;
using Collection.Infrastructure.Models;

namespace Collection.APIs.Extensions;

public static class DistributionsExtensions
{
    public static Distribution ToDto(this DistributionDbModel model)
    {
        return new Distribution
        {
            AccountCode = model.AccountCode,
            CollectedAmount = model.CollectedAmount,
            CollectionNo = model.CollectionNo,
            CreatedAt = model.CreatedAt,
            DebitOrCreditDesignationCode = model.DebitOrCreditDesignationCode,
            DeletionOn = model.DeletionOn,
            FinalModificationDateAndTime = model.FinalModificationDateAndTime,
            FinalModifierId = model.FinalModifierId,
            FirstRegistrantId = model.FirstRegistrantId,
            FirstRegistrationDateAndTime = model.FirstRegistrationDateAndTime,
            Id = model.Id,
            NoticeNo = model.NoticeNo,
            NoticeTypeCode = model.NoticeTypeCode,
            NotificationDate = model.NotificationDate,
            OfficeCode = model.OfficeCode,
            PaymentDate = model.PaymentDate,
            ProcessingOn = model.ProcessingOn,
            ServiceCode = model.ServiceCode,
            TaxCode = model.TaxCode,
            UpdatedAt = model.UpdatedAt
        };
    }

    public static DistributionDbModel ToModel(
        this DistributionUpdateInput updateDto,
        DistributionWhereUniqueInput uniqueId
    )
    {
        var distribution = new DistributionDbModel
        {
            Id = uniqueId.Id,
            AccountCode = updateDto.AccountCode,
            CollectedAmount = updateDto.CollectedAmount,
            CollectionNo = updateDto.CollectionNo,
            DebitOrCreditDesignationCode = updateDto.DebitOrCreditDesignationCode,
            DeletionOn = updateDto.DeletionOn,
            FinalModificationDateAndTime = updateDto.FinalModificationDateAndTime,
            FinalModifierId = updateDto.FinalModifierId,
            FirstRegistrantId = updateDto.FirstRegistrantId,
            FirstRegistrationDateAndTime = updateDto.FirstRegistrationDateAndTime,
            NoticeNo = updateDto.NoticeNo,
            NoticeTypeCode = updateDto.NoticeTypeCode,
            NotificationDate = updateDto.NotificationDate,
            OfficeCode = updateDto.OfficeCode,
            PaymentDate = updateDto.PaymentDate,
            ProcessingOn = updateDto.ProcessingOn,
            ServiceCode = updateDto.ServiceCode,
            TaxCode = updateDto.TaxCode
        };

        if (updateDto.CreatedAt != null) distribution.CreatedAt = updateDto.CreatedAt.Value;
        if (updateDto.UpdatedAt != null) distribution.UpdatedAt = updateDto.UpdatedAt.Value;

        return distribution;
    }
}
