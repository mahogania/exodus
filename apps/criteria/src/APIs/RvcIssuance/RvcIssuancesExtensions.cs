using Criteria.APIs.Dtos;
using Criteria.Infrastructure.Models;

namespace Criteria.APIs.Extensions;

public static class RvcIssuancesExtensions
{
    public static RvcIssuance ToDto(this RvcIssuanceDbModel model)
    {
        return new RvcIssuance
        {
            AttachmentFileId = model.AttachmentFileId,
            BlNumber = model.BlNumber,
            CreatedAt = model.CreatedAt,
            DeclaredNcyFobAmount = model.DeclaredNcyFobAmount,
            DeclaredNcyFreightAmount = model.DeclaredNcyFreightAmount,
            DeclaredNcyInsuranceAmount = model.DeclaredNcyInsuranceAmount,
            DeclaredNcyOtherChargesAmount = model.DeclaredNcyOtherChargesAmount,
            DeclaredNcyTotalTaxableBaseAmount = model.DeclaredNcyTotalTaxableBaseAmount,
            DeliveryConditionCode = model.DeliveryConditionCode,
            ExporterAddress = model.ExporterAddress,
            ExporterCompanyName = model.ExporterCompanyName,
            ExporterCountryCode = model.ExporterCountryCode,
            ExporterIdentificationNumber = model.ExporterIdentificationNumber,
            Id = model.Id,
            ImporterAddress = model.ImporterAddress,
            ImporterCompanyName = model.ImporterCompanyName,
            ImporterIdentificationNumber = model.ImporterIdentificationNumber,
            InvoiceAmount = model.InvoiceAmount,
            InvoiceCurrencyCode = model.InvoiceCurrencyCode,
            InvoiceIssueDate = model.InvoiceIssueDate,
            InvoiceNumber = model.InvoiceNumber,
            IssueDate = model.IssueDate,
            LiquidNcyFobAmount = model.LiquidNcyFobAmount,
            LiquidNcyFreightAmount = model.LiquidNcyFreightAmount,
            LiquidNcyInsuranceAmount = model.LiquidNcyInsuranceAmount,
            LiquidNcyOtherChargesAmount = model.LiquidNcyOtherChargesAmount,
            LiquidNcyTotalTaxableBaseAmount = model.LiquidNcyTotalTaxableBaseAmount,
            PackageUnitCode = model.PackageUnitCode,
            RecipientCountryCode = model.RecipientCountryCode,
            ReportNumber = model.ReportNumber,
            RvcNumber = model.RvcNumber,
            TotalGrossWeight = model.TotalGrossWeight,
            TotalNetWeight = model.TotalNetWeight,
            TotalNumberOfPackages = model.TotalNumberOfPackages,
            UpdatedAt = model.UpdatedAt,
        };
    }

    public static RvcIssuanceDbModel ToModel(
        this RvcIssuanceUpdateInput updateDto,
        RvcIssuanceWhereUniqueInput uniqueId
    )
    {
        var rvcIssuance = new RvcIssuanceDbModel
        {
            Id = uniqueId.Id,
            AttachmentFileId = updateDto.AttachmentFileId,
            BlNumber = updateDto.BlNumber,
            DeclaredNcyFobAmount = updateDto.DeclaredNcyFobAmount,
            DeclaredNcyFreightAmount = updateDto.DeclaredNcyFreightAmount,
            DeclaredNcyInsuranceAmount = updateDto.DeclaredNcyInsuranceAmount,
            DeclaredNcyOtherChargesAmount = updateDto.DeclaredNcyOtherChargesAmount,
            DeclaredNcyTotalTaxableBaseAmount = updateDto.DeclaredNcyTotalTaxableBaseAmount,
            DeliveryConditionCode = updateDto.DeliveryConditionCode,
            ExporterAddress = updateDto.ExporterAddress,
            ExporterCompanyName = updateDto.ExporterCompanyName,
            ExporterCountryCode = updateDto.ExporterCountryCode,
            ExporterIdentificationNumber = updateDto.ExporterIdentificationNumber,
            ImporterAddress = updateDto.ImporterAddress,
            ImporterCompanyName = updateDto.ImporterCompanyName,
            ImporterIdentificationNumber = updateDto.ImporterIdentificationNumber,
            InvoiceAmount = updateDto.InvoiceAmount,
            InvoiceCurrencyCode = updateDto.InvoiceCurrencyCode,
            InvoiceIssueDate = updateDto.InvoiceIssueDate,
            InvoiceNumber = updateDto.InvoiceNumber,
            IssueDate = updateDto.IssueDate,
            LiquidNcyFobAmount = updateDto.LiquidNcyFobAmount,
            LiquidNcyFreightAmount = updateDto.LiquidNcyFreightAmount,
            LiquidNcyInsuranceAmount = updateDto.LiquidNcyInsuranceAmount,
            LiquidNcyOtherChargesAmount = updateDto.LiquidNcyOtherChargesAmount,
            LiquidNcyTotalTaxableBaseAmount = updateDto.LiquidNcyTotalTaxableBaseAmount,
            PackageUnitCode = updateDto.PackageUnitCode,
            RecipientCountryCode = updateDto.RecipientCountryCode,
            ReportNumber = updateDto.ReportNumber,
            RvcNumber = updateDto.RvcNumber,
            TotalGrossWeight = updateDto.TotalGrossWeight,
            TotalNetWeight = updateDto.TotalNetWeight,
            TotalNumberOfPackages = updateDto.TotalNumberOfPackages
        };

        if (updateDto.CreatedAt != null)
        {
            rvcIssuance.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.UpdatedAt != null)
        {
            rvcIssuance.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return rvcIssuance;
    }
}
