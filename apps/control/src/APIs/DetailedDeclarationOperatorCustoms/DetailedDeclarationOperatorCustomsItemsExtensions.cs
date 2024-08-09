using Control.APIs.Dtos;
using Control.Infrastructure.Models;

namespace Control.APIs.Extensions;

public static class DetailedDeclarationOperatorCustomsItemsExtensions
{
    public static DetailedDeclarationOperatorCustoms ToDto(
        this DetailedDeclarationOperatorCustomsDbModel model
    )
    {
        return new DetailedDeclarationOperatorCustoms
        {
            CreatedAt = model.CreatedAt,
            DateAndTimeOfFinalModification = model.DateAndTimeOfFinalModification,
            DateAndTimeOfFirstRegistration = model.DateAndTimeOfFirstRegistration,
            DeclarantSAddress = model.DeclarantSAddress,
            DeletionOn = model.DeletionOn,
            ExporterSAddress = model.ExporterSAddress,
            ExporterSEmail = model.ExporterSEmail,
            FinalModifierSId = model.FinalModifierSId,
            FirstRecorderSId = model.FirstRecorderSId,
            Id = model.Id,
            ImporterSAddress = model.ImporterSAddress,
            NameOfTheDeclarantSCompany = model.NameOfTheDeclarantSCompany,
            NameOfTheExporterSCompany = model.NameOfTheExporterSCompany,
            NameOfTheImporterSCompany = model.NameOfTheImporterSCompany,
            RectificationFrequency = model.RectificationFrequency,
            ReferenceNumber = model.ReferenceNumber,
            TaxpayerPhoneNumber = model.TaxpayerPhoneNumber,
            TaxpayerSAddress = model.TaxpayerSAddress,
            TaxpayerSCompanyName = model.TaxpayerSCompanyName,
            TaxpayerSEmail = model.TaxpayerSEmail,
            UpdatedAt = model.UpdatedAt,
        };
    }

    public static DetailedDeclarationOperatorCustomsDbModel ToModel(
        this DetailedDeclarationOperatorCustomsUpdateInput updateDto,
        DetailedDeclarationOperatorCustomsWhereUniqueInput uniqueId
    )
    {
        var detailedDeclarationOperatorCustoms = new DetailedDeclarationOperatorCustomsDbModel
        {
            Id = uniqueId.Id,
            DateAndTimeOfFinalModification = updateDto.DateAndTimeOfFinalModification,
            DateAndTimeOfFirstRegistration = updateDto.DateAndTimeOfFirstRegistration,
            DeclarantSAddress = updateDto.DeclarantSAddress,
            DeletionOn = updateDto.DeletionOn,
            ExporterSAddress = updateDto.ExporterSAddress,
            ExporterSEmail = updateDto.ExporterSEmail,
            FinalModifierSId = updateDto.FinalModifierSId,
            FirstRecorderSId = updateDto.FirstRecorderSId,
            ImporterSAddress = updateDto.ImporterSAddress,
            NameOfTheDeclarantSCompany = updateDto.NameOfTheDeclarantSCompany,
            NameOfTheExporterSCompany = updateDto.NameOfTheExporterSCompany,
            NameOfTheImporterSCompany = updateDto.NameOfTheImporterSCompany,
            RectificationFrequency = updateDto.RectificationFrequency,
            ReferenceNumber = updateDto.ReferenceNumber,
            TaxpayerPhoneNumber = updateDto.TaxpayerPhoneNumber,
            TaxpayerSAddress = updateDto.TaxpayerSAddress,
            TaxpayerSCompanyName = updateDto.TaxpayerSCompanyName,
            TaxpayerSEmail = updateDto.TaxpayerSEmail
        };

        if (updateDto.CreatedAt != null)
        {
            detailedDeclarationOperatorCustoms.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.UpdatedAt != null)
        {
            detailedDeclarationOperatorCustoms.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return detailedDeclarationOperatorCustoms;
    }
}
