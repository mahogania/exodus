using Collection.APIs.Dtos;
using Collection.Infrastructure.Models;

namespace Collection.APIs.Extensions;

public static class CollectionsExtensions
{
    public static Collection ToDto(this CollectionDbModel model)
    {
        return new Collection
        {
            AttachmentFileId = model.AttachmentFileId,
            CollectedAmount = model.CollectedAmount,
            CollectionBankCode = model.CollectionBankCode,
            CollectionNo = model.CollectionNo,
            CollectionTypeCode = model.CollectionTypeCode,
            CreatedAt = model.CreatedAt,
            DeletionOn = model.DeletionOn,
            ExpenseCertificateNo = model.ExpenseCertificateNo,
            FinalModificationDateAndTime = model.FinalModificationDateAndTime,
            FinalModifierId = model.FinalModifierId,
            FirstRegistrantId = model.FirstRegistrantId,
            FirstRegistrationDateAndTime = model.FirstRegistrationDateAndTime,
            Id = model.Id,
            ManualRegistrationReasonContent = model.ManualRegistrationReasonContent,
            NoticeNo = model.NoticeNo,
            OfficeCode = model.OfficeCode,
            PaymentDate = model.PaymentDate,
            RegisteringPersonId = model.RegisteringPersonId,
            RegistrationDate = model.RegistrationDate,
            RegistrationSystemCategoryCode = model.RegistrationSystemCategoryCode,
            ServiceCode = model.ServiceCode,
            TaxpayerPhoneNo = model.TaxpayerPhoneNo,
            UpdatedAt = model.UpdatedAt
        };
    }

    public static CollectionDbModel ToModel(
        this CollectionUpdateInput updateDto,
        CollectionWhereUniqueInput uniqueId
    )
    {
        var collection = new CollectionDbModel
        {
            Id = uniqueId.Id,
            AttachmentFileId = updateDto.AttachmentFileId,
            CollectedAmount = updateDto.CollectedAmount,
            CollectionBankCode = updateDto.CollectionBankCode,
            CollectionNo = updateDto.CollectionNo,
            CollectionTypeCode = updateDto.CollectionTypeCode,
            DeletionOn = updateDto.DeletionOn,
            ExpenseCertificateNo = updateDto.ExpenseCertificateNo,
            FinalModificationDateAndTime = updateDto.FinalModificationDateAndTime,
            FinalModifierId = updateDto.FinalModifierId,
            FirstRegistrantId = updateDto.FirstRegistrantId,
            FirstRegistrationDateAndTime = updateDto.FirstRegistrationDateAndTime,
            ManualRegistrationReasonContent = updateDto.ManualRegistrationReasonContent,
            NoticeNo = updateDto.NoticeNo,
            OfficeCode = updateDto.OfficeCode,
            PaymentDate = updateDto.PaymentDate,
            RegisteringPersonId = updateDto.RegisteringPersonId,
            RegistrationDate = updateDto.RegistrationDate,
            RegistrationSystemCategoryCode = updateDto.RegistrationSystemCategoryCode,
            ServiceCode = updateDto.ServiceCode,
            TaxpayerPhoneNo = updateDto.TaxpayerPhoneNo
        };

        if (updateDto.CreatedAt != null) collection.CreatedAt = updateDto.CreatedAt.Value;
        if (updateDto.UpdatedAt != null) collection.UpdatedAt = updateDto.UpdatedAt.Value;

        return collection;
    }
}
