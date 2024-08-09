using Collection.APIs.Dtos;
using Collection.Infrastructure.Models;

namespace Collection.APIs.Extensions;

public static class RemovalOrdersExtensions
{
    public static RemovalOrder ToDto(this RemovalOrderDbModel model)
    {
        return new RemovalOrder
        {
            ArticlePackageQuantity = model.ArticlePackageQuantity,
            ArticlePackageUnitCode = model.ArticlePackageUnitCode,
            AttachedFileId = model.AttachedFileId,
            CreatedAt = model.CreatedAt,
            Crn = model.Crn,
            CustomsZoneCode = model.CustomsZoneCode,
            DeclarantCode = model.DeclarantCode,
            DeclarantName = model.DeclarantName,
            DeletionFlag = model.DeletionFlag,
            ExporterIdentificationNumber = model.ExporterIdentificationNumber,
            ExporterIdentificationNumberTypeCode = model.ExporterIdentificationNumberTypeCode,
            ExporterName = model.ExporterName,
            FinalModificationDateAndTime = model.FinalModificationDateAndTime,
            FinalModifierId = model.FinalModifierId,
            FirstRegistrantId = model.FirstRegistrantId,
            FirstRegistrationDateAndTime = model.FirstRegistrationDateAndTime,
            Forwarder = model.Forwarder,
            Id = model.Id,
            ImporterIdentificationNumber = model.ImporterIdentificationNumber,
            ImporterIdentificationNumberTypeCode = model.ImporterIdentificationNumberTypeCode,
            ImporterName = model.ImporterName,
            NoticeNumber = model.NoticeNumber,
            NumberOfTimesRemovalOrderPrinted = model.NumberOfTimesRemovalOrderPrinted,
            OfficeCode = model.OfficeCode,
            PaymentDate = model.PaymentDate,
            ProcessingStatusCode = model.ProcessingStatusCode,
            ReceiptNumber = model.ReceiptNumber,
            ReferenceDate = model.ReferenceDate,
            ReferenceNumber = model.ReferenceNumber,
            ReferenceNumberTypeCode = model.ReferenceNumberTypeCode,
            RegistrationDate = model.RegistrationDate,
            RemarksContent = model.RemarksContent,
            RemovalOrderNumber = model.RemovalOrderNumber,
            ServiceCode = model.ServiceCode,
            UpdatedAt = model.UpdatedAt,
        };
    }

    public static RemovalOrderDbModel ToModel(
        this RemovalOrderUpdateInput updateDto,
        RemovalOrderWhereUniqueInput uniqueId
    )
    {
        var removalOrder = new RemovalOrderDbModel
        {
            Id = uniqueId.Id,
            ArticlePackageQuantity = updateDto.ArticlePackageQuantity,
            ArticlePackageUnitCode = updateDto.ArticlePackageUnitCode,
            AttachedFileId = updateDto.AttachedFileId,
            Crn = updateDto.Crn,
            CustomsZoneCode = updateDto.CustomsZoneCode,
            DeclarantCode = updateDto.DeclarantCode,
            DeclarantName = updateDto.DeclarantName,
            DeletionFlag = updateDto.DeletionFlag,
            ExporterIdentificationNumber = updateDto.ExporterIdentificationNumber,
            ExporterIdentificationNumberTypeCode = updateDto.ExporterIdentificationNumberTypeCode,
            ExporterName = updateDto.ExporterName,
            FinalModificationDateAndTime = updateDto.FinalModificationDateAndTime,
            FinalModifierId = updateDto.FinalModifierId,
            FirstRegistrantId = updateDto.FirstRegistrantId,
            FirstRegistrationDateAndTime = updateDto.FirstRegistrationDateAndTime,
            Forwarder = updateDto.Forwarder,
            ImporterIdentificationNumber = updateDto.ImporterIdentificationNumber,
            ImporterIdentificationNumberTypeCode = updateDto.ImporterIdentificationNumberTypeCode,
            ImporterName = updateDto.ImporterName,
            NoticeNumber = updateDto.NoticeNumber,
            NumberOfTimesRemovalOrderPrinted = updateDto.NumberOfTimesRemovalOrderPrinted,
            OfficeCode = updateDto.OfficeCode,
            PaymentDate = updateDto.PaymentDate,
            ProcessingStatusCode = updateDto.ProcessingStatusCode,
            ReceiptNumber = updateDto.ReceiptNumber,
            ReferenceDate = updateDto.ReferenceDate,
            ReferenceNumber = updateDto.ReferenceNumber,
            ReferenceNumberTypeCode = updateDto.ReferenceNumberTypeCode,
            RegistrationDate = updateDto.RegistrationDate,
            RemarksContent = updateDto.RemarksContent,
            RemovalOrderNumber = updateDto.RemovalOrderNumber,
            ServiceCode = updateDto.ServiceCode
        };

        if (updateDto.CreatedAt != null)
        {
            removalOrder.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.UpdatedAt != null)
        {
            removalOrder.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return removalOrder;
    }
}
