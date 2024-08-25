using Control.APIs.Dtos;
using Control.Infrastructure.Models;

namespace Control.APIs.Extensions;

public static class DetailOfRequestForCertificateOfOriginsExtensions
{
    public static DetailOfRequestForCertificateOfOrigin ToDto(
        this DetailOfRequestForCertificateOfOriginDbModel model
    )
    {
        return new DetailOfRequestForCertificateOfOrigin
        {
            BrandName = model.BrandName,
            CertificateOfOriginRequestNumber = model.CertificateOfOriginRequestNumber,
            CreatedAt = model.CreatedAt,
            Crn = model.Crn,
            DateAndTimeOfFinalModification = model.DateAndTimeOfFinalModification,
            DateAndTimeOfFirstRegistration = model.DateAndTimeOfFirstRegistration,
            DescriptionOfTheMerchandise = model.DescriptionOfTheMerchandise,
            FinalModifierSId = model.FinalModifierSId,
            FirstRegistrantSId = model.FirstRegistrantSId,
            Id = model.Id,
            InvoiceRefInvoice = model.InvoiceRefInvoice,
            Quantity = model.Quantity,
            QuantityOfThePackage = model.QuantityOfThePackage,
            QuantityUnitCode = model.QuantityUnitCode,
            RectificationFrequency = model.RectificationFrequency,
            SequenceNumber = model.SequenceNumber,
            ShCode = model.ShCode,
            Standards = model.Standards,
            SuppressionOn = model.SuppressionOn,
            TradeName = model.TradeName,
            TypeOfPackagingCode = model.TypeOfPackagingCode,
            UpdatedAt = model.UpdatedAt,
            Weight = model.Weight,
            WeightUnit = model.WeightUnit
        };
    }

    public static DetailOfRequestForCertificateOfOriginDbModel ToModel(
        this DetailOfRequestForCertificateOfOriginUpdateInput updateDto,
        DetailOfRequestForCertificateOfOriginWhereUniqueInput uniqueId
    )
    {
        var detailOfRequestForCertificateOfOrigin = new DetailOfRequestForCertificateOfOriginDbModel
        {
            Id = uniqueId.Id,
            BrandName = updateDto.BrandName,
            CertificateOfOriginRequestNumber = updateDto.CertificateOfOriginRequestNumber,
            Crn = updateDto.Crn,
            DateAndTimeOfFinalModification = updateDto.DateAndTimeOfFinalModification,
            DateAndTimeOfFirstRegistration = updateDto.DateAndTimeOfFirstRegistration,
            DescriptionOfTheMerchandise = updateDto.DescriptionOfTheMerchandise,
            FinalModifierSId = updateDto.FinalModifierSId,
            FirstRegistrantSId = updateDto.FirstRegistrantSId,
            InvoiceRefInvoice = updateDto.InvoiceRefInvoice,
            Quantity = updateDto.Quantity,
            QuantityOfThePackage = updateDto.QuantityOfThePackage,
            QuantityUnitCode = updateDto.QuantityUnitCode,
            RectificationFrequency = updateDto.RectificationFrequency,
            SequenceNumber = updateDto.SequenceNumber,
            ShCode = updateDto.ShCode,
            Standards = updateDto.Standards,
            SuppressionOn = updateDto.SuppressionOn,
            TradeName = updateDto.TradeName,
            TypeOfPackagingCode = updateDto.TypeOfPackagingCode,
            Weight = updateDto.Weight,
            WeightUnit = updateDto.WeightUnit
        };

        if (updateDto.CreatedAt != null) detailOfRequestForCertificateOfOrigin.CreatedAt = updateDto.CreatedAt.Value;
        if (updateDto.UpdatedAt != null) detailOfRequestForCertificateOfOrigin.UpdatedAt = updateDto.UpdatedAt.Value;

        return detailOfRequestForCertificateOfOrigin;
    }
}
