using Clre.APIs.Dtos;
using Clre.Infrastructure.Models;

namespace Clre.APIs.Extensions;

public static class MacSuiteAtWithReexportationInTheStatesExtensions
{
    public static MacSuiteAtWithReexportationInTheState ToDto(
        this MacSuiteAtWithReexportationInTheStateDbModel model
    )
    {
        return new MacSuiteAtWithReexportationInTheState
        {
            ApcCode = model.ApcCode,
            ApcLabel = model.ApcLabel,
            AtDeclarationDate = model.AtDeclarationDate,
            AtDeclarationNumber = model.AtDeclarationNumber,
            BusinessRegisterNumber = model.BusinessRegisterNumber,
            ContentOfTheRequestReason = model.ContentOfTheRequestReason,
            CreatedAt = model.CreatedAt,
            CustomsClearanceOfficeForMac = model.CustomsClearanceOfficeForMac,
            CustomsDeclarationOffice = model.CustomsDeclarationOffice,
            DateAndTimeOfFinalModification = model.DateAndTimeOfFinalModification,
            DateAndTimeOfFirstRegistration = model.DateAndTimeOfFirstRegistration,
            DueDate = model.DueDate,
            EpcCode = model.EpcCode,
            EpcLabel = model.EpcLabel,
            ExecutionPlaces = model.ExecutionPlaces,
            FinalModifierSId = model.FinalModifierSId,
            FirstRegistrantSId = model.FirstRegistrantSId,
            Id = model.Id,
            Importer = model.Importer,
            Nif = model.Nif,
            NifStatus = model.NifStatus,
            NumberOfArticles = model.NumberOfArticles,
            RcStatus = model.RcStatus,
            RectificationFrequency = model.RectificationFrequency,
            RegimeRequestNumber = model.RegimeRequestNumber,
            SuppressionOn = model.SuppressionOn,
            UpdatedAt = model.UpdatedAt,
        };
    }

    public static MacSuiteAtWithReexportationInTheStateDbModel ToModel(
        this MacSuiteAtWithReexportationInTheStateUpdateInput updateDto,
        MacSuiteAtWithReexportationInTheStateWhereUniqueInput uniqueId
    )
    {
        var macSuiteAtWithReexportationInTheState = new MacSuiteAtWithReexportationInTheStateDbModel
        {
            Id = uniqueId.Id,
            ApcCode = updateDto.ApcCode,
            ApcLabel = updateDto.ApcLabel,
            AtDeclarationDate = updateDto.AtDeclarationDate,
            AtDeclarationNumber = updateDto.AtDeclarationNumber,
            BusinessRegisterNumber = updateDto.BusinessRegisterNumber,
            ContentOfTheRequestReason = updateDto.ContentOfTheRequestReason,
            CustomsClearanceOfficeForMac = updateDto.CustomsClearanceOfficeForMac,
            CustomsDeclarationOffice = updateDto.CustomsDeclarationOffice,
            DateAndTimeOfFinalModification = updateDto.DateAndTimeOfFinalModification,
            DateAndTimeOfFirstRegistration = updateDto.DateAndTimeOfFirstRegistration,
            DueDate = updateDto.DueDate,
            EpcCode = updateDto.EpcCode,
            EpcLabel = updateDto.EpcLabel,
            ExecutionPlaces = updateDto.ExecutionPlaces,
            FinalModifierSId = updateDto.FinalModifierSId,
            FirstRegistrantSId = updateDto.FirstRegistrantSId,
            Importer = updateDto.Importer,
            Nif = updateDto.Nif,
            NifStatus = updateDto.NifStatus,
            NumberOfArticles = updateDto.NumberOfArticles,
            RcStatus = updateDto.RcStatus,
            RectificationFrequency = updateDto.RectificationFrequency,
            RegimeRequestNumber = updateDto.RegimeRequestNumber,
            SuppressionOn = updateDto.SuppressionOn
        };

        if (updateDto.CreatedAt != null)
        {
            macSuiteAtWithReexportationInTheState.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.UpdatedAt != null)
        {
            macSuiteAtWithReexportationInTheState.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return macSuiteAtWithReexportationInTheState;
    }
}
