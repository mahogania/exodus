using Control.APIs.Dtos;
using Control.Infrastructure.Models;

namespace Control.APIs.Extensions;

public static class ImportedGoodsInformationsExtensions
{
    public static ImportedGoodsInformation ToDto(this ImportedGoodsInformationDbModel model)
    {
        return new ImportedGoodsInformation
        {
            AmountOfPaidDutiesAndTaxes = model.AmountOfPaidDutiesAndTaxes,
            ApcCode = model.ApcCode,
            ApcLabel = model.ApcLabel,
            CommercialDesignationOfGoods = model.CommercialDesignationOfGoods,
            CountryOfOrigin = model.CountryOfOrigin,
            CreatedAt = model.CreatedAt,
            CurrencyCode = model.CurrencyCode,
            CustomsDeclarationCodeOfTheImportation = model.CustomsDeclarationCodeOfTheImportation,
            DateAndTimeOfFirstRegistration = model.DateAndTimeOfFirstRegistration,
            DateOfThePaymentOfDutiesAndTaxesReceipt = model.DateOfThePaymentOfDutiesAndTaxesReceipt,
            DeclarationStatus = model.DeclarationStatus,
            EpcCode = model.EpcCode,
            EpcLabel = model.EpcLabel,
            FinalModifierSId = model.FinalModifierSId,
            FirstRegistrantSId = model.FirstRegistrantSId,
            Id = model.Id,
            ImportationDeclarationNumber = model.ImportationDeclarationNumber,
            NumberOfArticles = model.NumberOfArticles,
            NumberOfThePaymentOfDutiesAndTaxesReceipt =
                model.NumberOfThePaymentOfDutiesAndTaxesReceipt,
            Quantity = model.Quantity,
            RectificationFrequency = model.RectificationFrequency,
            RegimeRequestNumber = model.RegimeRequestNumber,
            SequenceNumber = model.SequenceNumber,
            SuppressionOn = model.SuppressionOn,
            TechnicalDesignationOfGoods = model.TechnicalDesignationOfGoods,
            UpdatedAt = model.UpdatedAt,
            Value = model.Value
        };
    }

    public static ImportedGoodsInformationDbModel ToModel(
        this ImportedGoodsInformationUpdateInput updateDto,
        ImportedGoodsInformationWhereUniqueInput uniqueId
    )
    {
        var importedGoodsInformation = new ImportedGoodsInformationDbModel
        {
            Id = uniqueId.Id,
            AmountOfPaidDutiesAndTaxes = updateDto.AmountOfPaidDutiesAndTaxes,
            ApcCode = updateDto.ApcCode,
            ApcLabel = updateDto.ApcLabel,
            CommercialDesignationOfGoods = updateDto.CommercialDesignationOfGoods,
            CountryOfOrigin = updateDto.CountryOfOrigin,
            CurrencyCode = updateDto.CurrencyCode,
            CustomsDeclarationCodeOfTheImportation =
                updateDto.CustomsDeclarationCodeOfTheImportation,
            DateAndTimeOfFirstRegistration = updateDto.DateAndTimeOfFirstRegistration,
            DateOfThePaymentOfDutiesAndTaxesReceipt =
                updateDto.DateOfThePaymentOfDutiesAndTaxesReceipt,
            DeclarationStatus = updateDto.DeclarationStatus,
            EpcCode = updateDto.EpcCode,
            EpcLabel = updateDto.EpcLabel,
            FinalModifierSId = updateDto.FinalModifierSId,
            FirstRegistrantSId = updateDto.FirstRegistrantSId,
            ImportationDeclarationNumber = updateDto.ImportationDeclarationNumber,
            NumberOfArticles = updateDto.NumberOfArticles,
            NumberOfThePaymentOfDutiesAndTaxesReceipt =
                updateDto.NumberOfThePaymentOfDutiesAndTaxesReceipt,
            Quantity = updateDto.Quantity,
            RectificationFrequency = updateDto.RectificationFrequency,
            RegimeRequestNumber = updateDto.RegimeRequestNumber,
            SequenceNumber = updateDto.SequenceNumber,
            SuppressionOn = updateDto.SuppressionOn,
            TechnicalDesignationOfGoods = updateDto.TechnicalDesignationOfGoods,
            Value = updateDto.Value
        };

        if (updateDto.CreatedAt != null) importedGoodsInformation.CreatedAt = updateDto.CreatedAt.Value;
        if (updateDto.UpdatedAt != null) importedGoodsInformation.UpdatedAt = updateDto.UpdatedAt.Value;

        return importedGoodsInformation;
    }
}
