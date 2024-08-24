using Control.APIs.Dtos;
using Control.Infrastructure.Models;

namespace Control.APIs.Extensions;

public static class CommonOriginCertificateRequestsExtensions
{
    public static CommonOriginCertificateRequest ToDto(
        this CommonOriginCertificateRequestDbModel model
    )
    {
        return new CommonOriginCertificateRequest
        {
            AttachedFileId = model.AttachedFileId,
            AuthorizedExporterSAuthorizationNumber = model.AuthorizedExporterSAuthorizationNumber,
            CertificateOfOriginNumber = model.CertificateOfOriginNumber,
            CertificateOfOriginRequestNumber = model.CertificateOfOriginRequestNumber,
            CodeOfTheGrossWeightUnit = model.CodeOfTheGrossWeightUnit,
            CreatedAt = model.CreatedAt,
            CustomsOfficeCode = model.CustomsOfficeCode,
            DateAndTimeOfFinalModification = model.DateAndTimeOfFinalModification,
            DateAndTimeOfFirstRegistration = model.DateAndTimeOfFirstRegistration,
            DeclarantSAddress = model.DeclarantSAddress,
            DeclarantSCode = model.DeclarantSCode,
            DeclarantSName = model.DeclarantSName,
            DepartureDate = model.DepartureDate,
            DestinationCountryCode = model.DestinationCountryCode,
            Details = model.Details?.Select(x => x.Id).ToList(),
            ExporterSAddress = model.ExporterSAddress,
            ExporterSCountryCode = model.ExporterSCountryCode,
            ExporterSName = model.ExporterSName,
            ExporterSTin = model.ExporterSTin,
            FinalModifierSId = model.FinalModifierSId,
            FirstRegistrantSId = model.FirstRegistrantSId,
            FreeTextReservedForTheDeclarant = model.FreeTextReservedForTheDeclarant,
            GrossWeight = model.GrossWeight,
            Id = model.Id,
            IssuanceDate = model.IssuanceDate,
            IssuingOrganizationOfTheCertificateOfOrigin =
                model.IssuingOrganizationOfTheCertificateOfOrigin,
            MeansOfTransportNumber = model.MeansOfTransportNumber,
            MeansOfTransportTypeCode = model.MeansOfTransportTypeCode,
            OriginCountryCode = model.OriginCountryCode,
            PreferentialCode = model.PreferentialCode,
            ProcessingStatusCode = model.ProcessingStatusCode,
            RecipientSAddress = model.RecipientSAddress,
            RecipientSName = model.RecipientSName,
            RectificationFrequency = model.RectificationFrequency,
            RemarkContent = model.RemarkContent,
            RequestDate = model.RequestDate,
            SuppressionOn = model.SuppressionOn,
            TinOfTheDestination = model.TinOfTheDestination,
            UpdatedAt = model.UpdatedAt,
        };
    }

    public static CommonOriginCertificateRequestDbModel ToModel(
        this CommonOriginCertificateRequestUpdateInput updateDto,
        CommonOriginCertificateRequestWhereUniqueInput uniqueId
    )
    {
        var commonOriginCertificateRequest = new CommonOriginCertificateRequestDbModel
        {
            Id = uniqueId.Id,
            AttachedFileId = updateDto.AttachedFileId,
            AuthorizedExporterSAuthorizationNumber =
                updateDto.AuthorizedExporterSAuthorizationNumber,
            CertificateOfOriginNumber = updateDto.CertificateOfOriginNumber,
            CertificateOfOriginRequestNumber = updateDto.CertificateOfOriginRequestNumber,
            CodeOfTheGrossWeightUnit = updateDto.CodeOfTheGrossWeightUnit,
            CustomsOfficeCode = updateDto.CustomsOfficeCode,
            DateAndTimeOfFinalModification = updateDto.DateAndTimeOfFinalModification,
            DateAndTimeOfFirstRegistration = updateDto.DateAndTimeOfFirstRegistration,
            DeclarantSAddress = updateDto.DeclarantSAddress,
            DeclarantSCode = updateDto.DeclarantSCode,
            DeclarantSName = updateDto.DeclarantSName,
            DepartureDate = updateDto.DepartureDate,
            DestinationCountryCode = updateDto.DestinationCountryCode,
            ExporterSAddress = updateDto.ExporterSAddress,
            ExporterSCountryCode = updateDto.ExporterSCountryCode,
            ExporterSName = updateDto.ExporterSName,
            ExporterSTin = updateDto.ExporterSTin,
            FinalModifierSId = updateDto.FinalModifierSId,
            FirstRegistrantSId = updateDto.FirstRegistrantSId,
            FreeTextReservedForTheDeclarant = updateDto.FreeTextReservedForTheDeclarant,
            GrossWeight = updateDto.GrossWeight,
            IssuanceDate = updateDto.IssuanceDate,
            IssuingOrganizationOfTheCertificateOfOrigin =
                updateDto.IssuingOrganizationOfTheCertificateOfOrigin,
            MeansOfTransportNumber = updateDto.MeansOfTransportNumber,
            MeansOfTransportTypeCode = updateDto.MeansOfTransportTypeCode,
            OriginCountryCode = updateDto.OriginCountryCode,
            PreferentialCode = updateDto.PreferentialCode,
            ProcessingStatusCode = updateDto.ProcessingStatusCode,
            RecipientSAddress = updateDto.RecipientSAddress,
            RecipientSName = updateDto.RecipientSName,
            RectificationFrequency = updateDto.RectificationFrequency,
            RemarkContent = updateDto.RemarkContent,
            RequestDate = updateDto.RequestDate,
            SuppressionOn = updateDto.SuppressionOn,
            TinOfTheDestination = updateDto.TinOfTheDestination
        };

        if (updateDto.CreatedAt != null)
        {
            commonOriginCertificateRequest.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.UpdatedAt != null)
        {
            commonOriginCertificateRequest.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return commonOriginCertificateRequest;
    }
}
