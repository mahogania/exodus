using Clre.APIs.Dtos;
using Clre.Infrastructure.Models;

namespace Clre.APIs.Extensions;

public static class DirectImportationExportationsExtensions
{
    public static DirectImportationExportation ToDto(this DirectImportationExportationDbModel model)
    {
        return new DirectImportationExportation
        {
            CargoStatus = model.CargoStatus,
            CodeOfTheReimportationReexportationOffice =
                model.CodeOfTheReimportationReexportationOffice,
            ContentsOfTheClearanceObjective = model.ContentsOfTheClearanceObjective,
            ContractReferenceCode = model.ContractReferenceCode,
            CreatedAt = model.CreatedAt,
            DeletionOn = model.DeletionOn,
            DocumentCode = model.DocumentCode,
            EndDateOfImportationExportation = model.EndDateOfImportationExportation,
            EndDateOfTheClearancePeriod = model.EndDateOfTheClearancePeriod,
            FinalModificationDateAndTime = model.FinalModificationDateAndTime,
            FinalModifierSId = model.FinalModifierSId,
            FirstRecorderSId = model.FirstRecorderSId,
            FirstRegistrationDateAndTime = model.FirstRegistrationDateAndTime,
            Id = model.Id,
            ImportationExportationTypeCode = model.ImportationExportationTypeCode,
            RealizationName = model.RealizationName,
            RectificationFrequency = model.RectificationFrequency,
            RegimeRequestNumber = model.RegimeRequestNumber,
            ReservedSuites = model.ReservedSuites,
            RightsAndTaxes = model.RightsAndTaxes,
            StartDateOfImportationExportation = model.StartDateOfImportationExportation,
            StartDateOfTheClearancePeriod = model.StartDateOfTheClearancePeriod,
            UpdatedAt = model.UpdatedAt,
        };
    }

    public static DirectImportationExportationDbModel ToModel(
        this DirectImportationExportationUpdateInput updateDto,
        DirectImportationExportationWhereUniqueInput uniqueId
    )
    {
        var directImportationExportation = new DirectImportationExportationDbModel
        {
            Id = uniqueId.Id,
            CargoStatus = updateDto.CargoStatus,
            CodeOfTheReimportationReexportationOffice =
                updateDto.CodeOfTheReimportationReexportationOffice,
            ContentsOfTheClearanceObjective = updateDto.ContentsOfTheClearanceObjective,
            ContractReferenceCode = updateDto.ContractReferenceCode,
            DeletionOn = updateDto.DeletionOn,
            DocumentCode = updateDto.DocumentCode,
            EndDateOfImportationExportation = updateDto.EndDateOfImportationExportation,
            EndDateOfTheClearancePeriod = updateDto.EndDateOfTheClearancePeriod,
            FinalModificationDateAndTime = updateDto.FinalModificationDateAndTime,
            FinalModifierSId = updateDto.FinalModifierSId,
            FirstRecorderSId = updateDto.FirstRecorderSId,
            FirstRegistrationDateAndTime = updateDto.FirstRegistrationDateAndTime,
            ImportationExportationTypeCode = updateDto.ImportationExportationTypeCode,
            RealizationName = updateDto.RealizationName,
            RectificationFrequency = updateDto.RectificationFrequency,
            RegimeRequestNumber = updateDto.RegimeRequestNumber,
            ReservedSuites = updateDto.ReservedSuites,
            RightsAndTaxes = updateDto.RightsAndTaxes,
            StartDateOfImportationExportation = updateDto.StartDateOfImportationExportation,
            StartDateOfTheClearancePeriod = updateDto.StartDateOfTheClearancePeriod
        };

        if (updateDto.CreatedAt != null)
        {
            directImportationExportation.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.UpdatedAt != null)
        {
            directImportationExportation.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return directImportationExportation;
    }
}
