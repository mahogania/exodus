using Control.APIs.Dtos;
using Control.Infrastructure.Models;

namespace Control.APIs.Extensions;

public static class OperatorsExtensions
{
    public static Operator ToDto(this OperatorDbModel model)
    {
        return new Operator
        {
            CommonDetailedDeclaration = model.CommonDetailedDeclaration?.ToDto(),
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

    public static OperatorDbModel ToModel(this OperatorUpdateInput updateDto, OperatorWhereUniqueInput uniqueId)
    {
        var operator = new OperatorDbModel
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
     operator.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.UpdatedAt != null)
        {
     operator.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return operator;
    }

}
