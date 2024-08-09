using Clre.APIs.Dtos;
using Clre.Infrastructure.Models;

namespace Clre.APIs.Extensions;

public static class CompensatoryProductsForPerfectionsExtensions
{
    public static CompensatoryProductsForPerfection ToDto(
        this CompensatoryProductsForPerfectionDbModel model
    )
    {
        return new CompensatoryProductsForPerfection
        {
            CommercialDesignationOfGoods = model.CommercialDesignationOfGoods,
            CountryOfExportation = model.CountryOfExportation,
            CreatedAt = model.CreatedAt,
            DeletionOn = model.DeletionOn,
            FinalModificationDateAndTime = model.FinalModificationDateAndTime,
            FinalModifierSId = model.FinalModifierSId,
            FirstRecorderSId = model.FirstRecorderSId,
            FirstRegistrationDateAndTime = model.FirstRegistrationDateAndTime,
            Id = model.Id,
            IntegrationRate = model.IntegrationRate,
            Origin = model.Origin,
            Quantity = model.Quantity,
            RealExporterOfGoods = model.RealExporterOfGoods,
            RectificationFrequency = model.RectificationFrequency,
            RegimeRequestNumber = model.RegimeRequestNumber,
            SequenceNumber = model.SequenceNumber,
            SptNumber = model.SptNumber,
            TechnicalDesignationOfGoods = model.TechnicalDesignationOfGoods,
            UpdatedAt = model.UpdatedAt,
        };
    }

    public static CompensatoryProductsForPerfectionDbModel ToModel(
        this CompensatoryProductsForPerfectionUpdateInput updateDto,
        CompensatoryProductsForPerfectionWhereUniqueInput uniqueId
    )
    {
        var compensatoryProductsForPerfection = new CompensatoryProductsForPerfectionDbModel
        {
            Id = uniqueId.Id,
            CommercialDesignationOfGoods = updateDto.CommercialDesignationOfGoods,
            CountryOfExportation = updateDto.CountryOfExportation,
            DeletionOn = updateDto.DeletionOn,
            FinalModificationDateAndTime = updateDto.FinalModificationDateAndTime,
            FinalModifierSId = updateDto.FinalModifierSId,
            FirstRecorderSId = updateDto.FirstRecorderSId,
            FirstRegistrationDateAndTime = updateDto.FirstRegistrationDateAndTime,
            IntegrationRate = updateDto.IntegrationRate,
            Origin = updateDto.Origin,
            Quantity = updateDto.Quantity,
            RealExporterOfGoods = updateDto.RealExporterOfGoods,
            RectificationFrequency = updateDto.RectificationFrequency,
            RegimeRequestNumber = updateDto.RegimeRequestNumber,
            SequenceNumber = updateDto.SequenceNumber,
            SptNumber = updateDto.SptNumber,
            TechnicalDesignationOfGoods = updateDto.TechnicalDesignationOfGoods
        };

        if (updateDto.CreatedAt != null)
        {
            compensatoryProductsForPerfection.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.UpdatedAt != null)
        {
            compensatoryProductsForPerfection.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return compensatoryProductsForPerfection;
    }
}
