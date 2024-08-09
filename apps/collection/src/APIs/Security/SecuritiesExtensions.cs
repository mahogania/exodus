using Collection.APIs.Dtos;
using Collection.Infrastructure.Models;

namespace Collection.APIs.Extensions;

public static class SecuritiesExtensions
{
    public static Security ToDto(this SecurityDbModel model)
    {
        return new Security
        {
            AdjustmentDate = model.AdjustmentDate,
            AssignedAccountant = model.AssignedAccountant,
            AuthorizingOfficerSCapacity = model.AuthorizingOfficerSCapacity,
            AuthorizingOfficerSDesignation = model.AuthorizingOfficerSDesignation,
            BankAccountNumber = model.BankAccountNumber,
            BankBranchCode = model.BankBranchCode,
            BankCode = model.BankCode,
            CompanyAddress = model.CompanyAddress,
            CompanyName = model.CompanyName,
            CreatedAt = model.CreatedAt,
            CustomsNote = model.CustomsNote,
            DeclarationDate = model.DeclarationDate,
            FinalModificationDateAndTime = model.FinalModificationDateAndTime,
            FinalModifierId = model.FinalModifierId,
            FirstRegistrationDateAndTime = model.FirstRegistrationDateAndTime,
            GuarantorOrganizationCode = model.GuarantorOrganizationCode,
            GuarantorOrganizationName = model.GuarantorOrganizationName,
            Id = model.Id,
            OfficeCode = model.OfficeCode,
            PrincipalObligor = model.PrincipalObligor,
            RegisteringPersonId = model.RegisteringPersonId,
            RejectYesNo = model.RejectYesNo,
            RejectionReason = model.RejectionReason,
            RepresentativeSLastName = model.RepresentativeSLastName,
            RequestDate = model.RequestDate,
            RequestNumber = model.RequestNumber,
            SecurityAmount = model.SecurityAmount,
            SecurityClosureDate = model.SecurityClosureDate,
            SecurityIssuanceNumber = model.SecurityIssuanceNumber,
            SecurityReleaseCertificateIssuanceDate = model.SecurityReleaseCertificateIssuanceDate,
            SecurityTypeCode = model.SecurityTypeCode,
            SecurityValidityStatusCode = model.SecurityValidityStatusCode,
            ServiceCode = model.ServiceCode,
            SuspensionReason = model.SuspensionReason,
            TaxIdentificationNumber = model.TaxIdentificationNumber,
            UpdatedAt = model.UpdatedAt,
            ValidityEndDate = model.ValidityEndDate,
            ValidityStartDate = model.ValidityStartDate,
        };
    }

    public static SecurityDbModel ToModel(
        this SecurityUpdateInput updateDto,
        SecurityWhereUniqueInput uniqueId
    )
    {
        var security = new SecurityDbModel
        {
            Id = uniqueId.Id,
            AdjustmentDate = updateDto.AdjustmentDate,
            AssignedAccountant = updateDto.AssignedAccountant,
            AuthorizingOfficerSCapacity = updateDto.AuthorizingOfficerSCapacity,
            AuthorizingOfficerSDesignation = updateDto.AuthorizingOfficerSDesignation,
            BankAccountNumber = updateDto.BankAccountNumber,
            BankBranchCode = updateDto.BankBranchCode,
            BankCode = updateDto.BankCode,
            CompanyAddress = updateDto.CompanyAddress,
            CompanyName = updateDto.CompanyName,
            CustomsNote = updateDto.CustomsNote,
            DeclarationDate = updateDto.DeclarationDate,
            FinalModificationDateAndTime = updateDto.FinalModificationDateAndTime,
            FinalModifierId = updateDto.FinalModifierId,
            FirstRegistrationDateAndTime = updateDto.FirstRegistrationDateAndTime,
            GuarantorOrganizationCode = updateDto.GuarantorOrganizationCode,
            GuarantorOrganizationName = updateDto.GuarantorOrganizationName,
            OfficeCode = updateDto.OfficeCode,
            PrincipalObligor = updateDto.PrincipalObligor,
            RegisteringPersonId = updateDto.RegisteringPersonId,
            RejectYesNo = updateDto.RejectYesNo,
            RejectionReason = updateDto.RejectionReason,
            RepresentativeSLastName = updateDto.RepresentativeSLastName,
            RequestDate = updateDto.RequestDate,
            RequestNumber = updateDto.RequestNumber,
            SecurityAmount = updateDto.SecurityAmount,
            SecurityClosureDate = updateDto.SecurityClosureDate,
            SecurityIssuanceNumber = updateDto.SecurityIssuanceNumber,
            SecurityReleaseCertificateIssuanceDate =
                updateDto.SecurityReleaseCertificateIssuanceDate,
            SecurityTypeCode = updateDto.SecurityTypeCode,
            SecurityValidityStatusCode = updateDto.SecurityValidityStatusCode,
            ServiceCode = updateDto.ServiceCode,
            SuspensionReason = updateDto.SuspensionReason,
            TaxIdentificationNumber = updateDto.TaxIdentificationNumber,
            ValidityEndDate = updateDto.ValidityEndDate,
            ValidityStartDate = updateDto.ValidityStartDate
        };

        if (updateDto.CreatedAt != null)
        {
            security.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.UpdatedAt != null)
        {
            security.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return security;
    }
}
