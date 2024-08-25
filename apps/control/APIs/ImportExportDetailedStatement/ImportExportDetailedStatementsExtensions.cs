using Control.APIs.Dtos;
using Control.Infrastructure.Models;

namespace Control.APIs.Extensions;

public static class ImportExportDetailedStatementsExtensions
{
    public static ImportExportDetailedStatement ToDto(
        this ImportExportDetailedStatementDbModel model
    )
    {
        return new ImportExportDetailedStatement
        {
            Amount = model.Amount,
            BrandName = model.BrandName,
            CreatedAt = model.CreatedAt,
            DateAndTimeOfFinalModification = model.DateAndTimeOfFinalModification,
            DateAndTimeOfFirstRegistration = model.DateAndTimeOfFirstRegistration,
            DocumentCode = model.DocumentCode,
            FinalModifierSId = model.FinalModifierSId,
            FirstRegistrantSId = model.FirstRegistrantSId,
            Id = model.Id,
            ImportExportTypeCode = model.ImportExportTypeCode,
            OriginCountryCode = model.OriginCountryCode,
            Quantity = model.Quantity,
            QuantityUnitCode = model.QuantityUnitCode,
            RectificationFrequency = model.RectificationFrequency,
            RegimeRequestNumber = model.RegimeRequestNumber,
            SequenceNumber = model.SequenceNumber,
            ShCode = model.ShCode,
            SuppressionOn = model.SuppressionOn,
            TechniqueName = model.TechniqueName,
            UpdatedAt = model.UpdatedAt
        };
    }

    public static ImportExportDetailedStatementDbModel ToModel(
        this ImportExportDetailedStatementUpdateInput updateDto,
        ImportExportDetailedStatementWhereUniqueInput uniqueId
    )
    {
        var importExportDetailedStatement = new ImportExportDetailedStatementDbModel
        {
            Id = uniqueId.Id,
            Amount = updateDto.Amount,
            BrandName = updateDto.BrandName,
            DateAndTimeOfFinalModification = updateDto.DateAndTimeOfFinalModification,
            DateAndTimeOfFirstRegistration = updateDto.DateAndTimeOfFirstRegistration,
            DocumentCode = updateDto.DocumentCode,
            FinalModifierSId = updateDto.FinalModifierSId,
            FirstRegistrantSId = updateDto.FirstRegistrantSId,
            ImportExportTypeCode = updateDto.ImportExportTypeCode,
            OriginCountryCode = updateDto.OriginCountryCode,
            Quantity = updateDto.Quantity,
            QuantityUnitCode = updateDto.QuantityUnitCode,
            RectificationFrequency = updateDto.RectificationFrequency,
            RegimeRequestNumber = updateDto.RegimeRequestNumber,
            SequenceNumber = updateDto.SequenceNumber,
            ShCode = updateDto.ShCode,
            SuppressionOn = updateDto.SuppressionOn,
            TechniqueName = updateDto.TechniqueName
        };

        if (updateDto.CreatedAt != null) importExportDetailedStatement.CreatedAt = updateDto.CreatedAt.Value;
        if (updateDto.UpdatedAt != null) importExportDetailedStatement.UpdatedAt = updateDto.UpdatedAt.Value;

        return importExportDetailedStatement;
    }
}
