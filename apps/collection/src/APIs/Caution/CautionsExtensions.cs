using Collection.APIs.Dtos;
using Collection.Infrastructure.Models;

namespace Collection.APIs.Extensions;

public static class CautionsExtensions
{
    public static Caution ToDto(this CautionDbModel model)
    {
        return new Caution
        {
            AdjustmentDate = model.AdjustmentDate,
            AssigningAccountant = model.AssigningAccountant,
            AttachedFileId = model.AttachedFileId,
            BankAccountNumber = model.BankAccountNumber,
            BankAgencyCode = model.BankAgencyCode,
            BankCode = model.BankCode,
            CautionAmount = model.CautionAmount,
            CautionClosureDate = model.CautionClosureDate,
            CautionDeliveryNumber = model.CautionDeliveryNumber,
            CautionNumber = model.CautionNumber,
            CautionTypeCode = model.CautionTypeCode,
            CautionValidityEndDate = model.CautionValidityEndDate,
            CautionValidityStartDate = model.CautionValidityStartDate,
            CautionValidityStatusCode = model.CautionValidityStatusCode,
            CompanyAddress = model.CompanyAddress,
            CompanyName = model.CompanyName,
            CreatedAt = model.CreatedAt,
            CustomsNote = model.CustomsNote,
            DateOfCautionReleaseCertificateDelivery = model.DateOfCautionReleaseCertificateDelivery,
            DeclarantCode = model.DeclarantCode,
            DeclarationDate = model.DeclarationDate,
            FinalModificationDateAndTime = model.FinalModificationDateAndTime,
            FinalModifierId = model.FinalModifierId,
            FirstRegistrationDateAndTime = model.FirstRegistrationDateAndTime,
            GuarantorOrganizationCode = model.GuarantorOrganizationCode,
            GuarantorOrganizationName = model.GuarantorOrganizationName,
            Id = model.Id,
            OfficeCode = model.OfficeCode,
            OrderGiverDesignation = model.OrderGiverDesignation,
            OrderGiverQuality = model.OrderGiverQuality,
            PersonInChargeOfCautionReleaseCertificateDeliveryCode =
                model.PersonInChargeOfCautionReleaseCertificateDeliveryCode,
            PersonRegisteringId = model.PersonRegisteringId,
            PrincipalObligated = model.PrincipalObligated,
            ProcessingStatusCode = model.ProcessingStatusCode,
            RejectYesNo = model.RejectYesNo,
            RejectionReason = model.RejectionReason,
            RepresentativeLastName = model.RepresentativeLastName,
            RequestDate = model.RequestDate,
            RequestNumber = model.RequestNumber,
            ServiceCode = model.ServiceCode,
            SuspensionReason = model.SuspensionReason,
            TaxIdentificationNumber = model.TaxIdentificationNumber,
            UpdatedAt = model.UpdatedAt,
        };
    }

    public static CautionDbModel ToModel(
        this CautionUpdateInput updateDto,
        CautionWhereUniqueInput uniqueId
    )
    {
        var caution = new CautionDbModel
        {
            Id = uniqueId.Id,
            AdjustmentDate = updateDto.AdjustmentDate,
            AssigningAccountant = updateDto.AssigningAccountant,
            AttachedFileId = updateDto.AttachedFileId,
            BankAccountNumber = updateDto.BankAccountNumber,
            BankAgencyCode = updateDto.BankAgencyCode,
            BankCode = updateDto.BankCode,
            CautionAmount = updateDto.CautionAmount,
            CautionClosureDate = updateDto.CautionClosureDate,
            CautionDeliveryNumber = updateDto.CautionDeliveryNumber,
            CautionNumber = updateDto.CautionNumber,
            CautionTypeCode = updateDto.CautionTypeCode,
            CautionValidityEndDate = updateDto.CautionValidityEndDate,
            CautionValidityStartDate = updateDto.CautionValidityStartDate,
            CautionValidityStatusCode = updateDto.CautionValidityStatusCode,
            CompanyAddress = updateDto.CompanyAddress,
            CompanyName = updateDto.CompanyName,
            CustomsNote = updateDto.CustomsNote,
            DateOfCautionReleaseCertificateDelivery =
                updateDto.DateOfCautionReleaseCertificateDelivery,
            DeclarantCode = updateDto.DeclarantCode,
            DeclarationDate = updateDto.DeclarationDate,
            FinalModificationDateAndTime = updateDto.FinalModificationDateAndTime,
            FinalModifierId = updateDto.FinalModifierId,
            FirstRegistrationDateAndTime = updateDto.FirstRegistrationDateAndTime,
            GuarantorOrganizationCode = updateDto.GuarantorOrganizationCode,
            GuarantorOrganizationName = updateDto.GuarantorOrganizationName,
            OfficeCode = updateDto.OfficeCode,
            OrderGiverDesignation = updateDto.OrderGiverDesignation,
            OrderGiverQuality = updateDto.OrderGiverQuality,
            PersonInChargeOfCautionReleaseCertificateDeliveryCode =
                updateDto.PersonInChargeOfCautionReleaseCertificateDeliveryCode,
            PersonRegisteringId = updateDto.PersonRegisteringId,
            PrincipalObligated = updateDto.PrincipalObligated,
            ProcessingStatusCode = updateDto.ProcessingStatusCode,
            RejectYesNo = updateDto.RejectYesNo,
            RejectionReason = updateDto.RejectionReason,
            RepresentativeLastName = updateDto.RepresentativeLastName,
            RequestDate = updateDto.RequestDate,
            RequestNumber = updateDto.RequestNumber,
            ServiceCode = updateDto.ServiceCode,
            SuspensionReason = updateDto.SuspensionReason,
            TaxIdentificationNumber = updateDto.TaxIdentificationNumber
        };

        if (updateDto.CreatedAt != null)
        {
            caution.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.UpdatedAt != null)
        {
            caution.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return caution;
    }
}
