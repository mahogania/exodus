using Collection.APIs.Dtos;
using Collection.Infrastructure.Models;

namespace Collection.APIs.Extensions;

public static class CreditsExtensions
{
    public static Credit ToDto(this CreditDbModel model)
    {
        return new Credit
        {
            AdjustmentDate = model.AdjustmentDate,
            AgencyCode = model.AgencyCode,
            AssignedAccountant = model.AssignedAccountant,
            AttachmentId = model.AttachmentId,
            AuthorizingOfficerDesignation = model.AuthorizingOfficerDesignation,
            AuthorizingOfficerQuality = model.AuthorizingOfficerQuality,
            BankAccountNo = model.BankAccountNo,
            CreatedAt = model.CreatedAt,
            CustomsNote = model.CustomsNote,
            DeclarantCode = model.DeclarantCode,
            DeclarationNo = model.DeclarationNo,
            DeletionOn = model.DeletionOn,
            FinalModificationDateAndTime = model.FinalModificationDateAndTime,
            FinalModifierId = model.FinalModifierId,
            FirstRegistrantId = model.FirstRegistrantId,
            FirstRegistrationDateAndTime = model.FirstRegistrationDateAndTime,
            GuaranteeAmount = model.GuaranteeAmount,
            GuaranteeClosedOn = model.GuaranteeClosedOn,
            GuaranteeClosureDate = model.GuaranteeClosureDate,
            GuaranteeIssuanceNo = model.GuaranteeIssuanceNo,
            GuaranteeNo = model.GuaranteeNo,
            GuaranteeTypeCode = model.GuaranteeTypeCode,
            GuaranteeValidityStatusCode = model.GuaranteeValidityStatusCode,
            GuarantorOrganizationCode = model.GuarantorOrganizationCode,
            GuarantorOrganizationName = model.GuarantorOrganizationName,
            Id = model.Id,
            OfficeCode = model.OfficeCode,
            ProcessingStatusCode = model.ProcessingStatusCode,
            RegisteringPersonId = model.RegisteringPersonId,
            RegistrationDate = model.RegistrationDate,
            RejectionReason = model.RejectionReason,
            RejectionReasonContent = model.RejectionReasonContent,
            RequestDate = model.RequestDate,
            RequestNo = model.RequestNo,
            ServiceCode = model.ServiceCode,
            TaxIdentificationNumber = model.TaxIdentificationNumber,
            UnknownField = model.UnknownField,
            UpdatedAt = model.UpdatedAt,
            ValidityEndDate = model.ValidityEndDate,
            ValidityStartDate = model.ValidityStartDate,
        };
    }

    public static CreditDbModel ToModel(
        this CreditUpdateInput updateDto,
        CreditWhereUniqueInput uniqueId
    )
    {
        var credit = new CreditDbModel
        {
            Id = uniqueId.Id,
            AdjustmentDate = updateDto.AdjustmentDate,
            AgencyCode = updateDto.AgencyCode,
            AssignedAccountant = updateDto.AssignedAccountant,
            AttachmentId = updateDto.AttachmentId,
            AuthorizingOfficerDesignation = updateDto.AuthorizingOfficerDesignation,
            AuthorizingOfficerQuality = updateDto.AuthorizingOfficerQuality,
            BankAccountNo = updateDto.BankAccountNo,
            CustomsNote = updateDto.CustomsNote,
            DeclarantCode = updateDto.DeclarantCode,
            DeclarationNo = updateDto.DeclarationNo,
            DeletionOn = updateDto.DeletionOn,
            FinalModificationDateAndTime = updateDto.FinalModificationDateAndTime,
            FinalModifierId = updateDto.FinalModifierId,
            FirstRegistrantId = updateDto.FirstRegistrantId,
            FirstRegistrationDateAndTime = updateDto.FirstRegistrationDateAndTime,
            GuaranteeAmount = updateDto.GuaranteeAmount,
            GuaranteeClosedOn = updateDto.GuaranteeClosedOn,
            GuaranteeClosureDate = updateDto.GuaranteeClosureDate,
            GuaranteeIssuanceNo = updateDto.GuaranteeIssuanceNo,
            GuaranteeNo = updateDto.GuaranteeNo,
            GuaranteeTypeCode = updateDto.GuaranteeTypeCode,
            GuaranteeValidityStatusCode = updateDto.GuaranteeValidityStatusCode,
            GuarantorOrganizationCode = updateDto.GuarantorOrganizationCode,
            GuarantorOrganizationName = updateDto.GuarantorOrganizationName,
            OfficeCode = updateDto.OfficeCode,
            ProcessingStatusCode = updateDto.ProcessingStatusCode,
            RegisteringPersonId = updateDto.RegisteringPersonId,
            RegistrationDate = updateDto.RegistrationDate,
            RejectionReason = updateDto.RejectionReason,
            RejectionReasonContent = updateDto.RejectionReasonContent,
            RequestDate = updateDto.RequestDate,
            RequestNo = updateDto.RequestNo,
            ServiceCode = updateDto.ServiceCode,
            TaxIdentificationNumber = updateDto.TaxIdentificationNumber,
            UnknownField = updateDto.UnknownField,
            ValidityEndDate = updateDto.ValidityEndDate,
            ValidityStartDate = updateDto.ValidityStartDate
        };

        if (updateDto.CreatedAt != null)
        {
            credit.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.UpdatedAt != null)
        {
            credit.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return credit;
    }
}
