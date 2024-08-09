using Collection.APIs.Dtos;
using Collection.Infrastructure.Models;

namespace Collection.APIs.Extensions;

public static class OthersItemsExtensions
{
    public static Others ToDto(this OthersDbModel model)
    {
        return new Others
        {
            AmountOfOtherChargeableFees = model.AmountOfOtherChargeableFees,
            AttachmentId = model.AttachmentId,
            CreatedAt = model.CreatedAt,
            DeletionOn = model.DeletionOn,
            FinalModificationDateAndTime = model.FinalModificationDateAndTime,
            FinalModifierId = model.FinalModifierId,
            FinancialManagerName = model.FinancialManagerName,
            FirstRegistrantId = model.FirstRegistrantId,
            FirstRegistrationDateAndTime = model.FirstRegistrationDateAndTime,
            Id = model.Id,
            NiuCategoryCode = model.NiuCategoryCode,
            NiuCategoryName = model.NiuCategoryName,
            NoticeNo = model.NoticeNo,
            OfficeCode = model.OfficeCode,
            ReferenceNo = model.ReferenceNo,
            ReferenceNumberTypeCode = model.ReferenceNumberTypeCode,
            ReferenceNumberTypeName = model.ReferenceNumberTypeName,
            RegistrationReasonContent = model.RegistrationReasonContent,
            ServiceCode = model.ServiceCode,
            TaxpayerIdentificationNo = model.TaxpayerIdentificationNo,
            UpdatedAt = model.UpdatedAt,
        };
    }

    public static OthersDbModel ToModel(
        this OthersUpdateInput updateDto,
        OthersWhereUniqueInput uniqueId
    )
    {
        var others = new OthersDbModel
        {
            Id = uniqueId.Id,
            AmountOfOtherChargeableFees = updateDto.AmountOfOtherChargeableFees,
            AttachmentId = updateDto.AttachmentId,
            DeletionOn = updateDto.DeletionOn,
            FinalModificationDateAndTime = updateDto.FinalModificationDateAndTime,
            FinalModifierId = updateDto.FinalModifierId,
            FinancialManagerName = updateDto.FinancialManagerName,
            FirstRegistrantId = updateDto.FirstRegistrantId,
            FirstRegistrationDateAndTime = updateDto.FirstRegistrationDateAndTime,
            NiuCategoryCode = updateDto.NiuCategoryCode,
            NiuCategoryName = updateDto.NiuCategoryName,
            NoticeNo = updateDto.NoticeNo,
            OfficeCode = updateDto.OfficeCode,
            ReferenceNo = updateDto.ReferenceNo,
            ReferenceNumberTypeCode = updateDto.ReferenceNumberTypeCode,
            ReferenceNumberTypeName = updateDto.ReferenceNumberTypeName,
            RegistrationReasonContent = updateDto.RegistrationReasonContent,
            ServiceCode = updateDto.ServiceCode,
            TaxpayerIdentificationNo = updateDto.TaxpayerIdentificationNo
        };

        if (updateDto.CreatedAt != null)
        {
            others.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.UpdatedAt != null)
        {
            others.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return others;
    }
}
