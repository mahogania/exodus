using Control.APIs.Dtos;
using Control.Infrastructure.Models;

namespace Control.APIs.Extensions;

public static class FinalExportFollowedByReimportationInTheStatesExtensions
{
    public static FinalExportFollowedByReimportationInTheState ToDto(
        this FinalExportFollowedByReimportationInTheStateDbModel model
    )
    {
        return new FinalExportFollowedByReimportationInTheState
        {
            ApcCode = model.ApcCode,
            ContentOfTheRequestReason = model.ContentOfTheRequestReason,
            CreatedAt = model.CreatedAt,
            CustomsClearanceOfficeForFinalExportFollowedByEt =
                model.CustomsClearanceOfficeForFinalExportFollowedByEt,
            CustomsDeclarationOffice = model.CustomsDeclarationOffice,
            DateAndTimeOfFinalModification = model.DateAndTimeOfFinalModification,
            DateAndTimeOfFirstRegistration = model.DateAndTimeOfFirstRegistration,
            DateOfEtDeclaration = model.DateOfEtDeclaration,
            EpcCode = model.EpcCode,
            EtDeclarationNumber = model.EtDeclarationNumber,
            ExecutionPlaces = model.ExecutionPlaces,
            ExpiryDate = model.ExpiryDate,
            FinalModifierSId = model.FinalModifierSId,
            FirstRegistrantSId = model.FirstRegistrantSId,
            Id = model.Id,
            LabelApc = model.LabelApc,
            LabelEpc = model.LabelEpc,
            NumberOfArticles = model.NumberOfArticles,
            RectificationFrequency = model.RectificationFrequency,
            RegimeRequestNumber = model.RegimeRequestNumber,
            SuppressionOn = model.SuppressionOn,
            UpdatedAt = model.UpdatedAt
        };
    }

    public static FinalExportFollowedByReimportationInTheStateDbModel ToModel(
        this FinalExportFollowedByReimportationInTheStateUpdateInput updateDto,
        FinalExportFollowedByReimportationInTheStateWhereUniqueInput uniqueId
    )
    {
        var finalExportFollowedByReimportationInTheState =
            new FinalExportFollowedByReimportationInTheStateDbModel
            {
                Id = uniqueId.Id,
                ApcCode = updateDto.ApcCode,
                ContentOfTheRequestReason = updateDto.ContentOfTheRequestReason,
                CustomsClearanceOfficeForFinalExportFollowedByEt =
                    updateDto.CustomsClearanceOfficeForFinalExportFollowedByEt,
                CustomsDeclarationOffice = updateDto.CustomsDeclarationOffice,
                DateAndTimeOfFinalModification = updateDto.DateAndTimeOfFinalModification,
                DateAndTimeOfFirstRegistration = updateDto.DateAndTimeOfFirstRegistration,
                DateOfEtDeclaration = updateDto.DateOfEtDeclaration,
                EpcCode = updateDto.EpcCode,
                EtDeclarationNumber = updateDto.EtDeclarationNumber,
                ExecutionPlaces = updateDto.ExecutionPlaces,
                ExpiryDate = updateDto.ExpiryDate,
                FinalModifierSId = updateDto.FinalModifierSId,
                FirstRegistrantSId = updateDto.FirstRegistrantSId,
                LabelApc = updateDto.LabelApc,
                LabelEpc = updateDto.LabelEpc,
                NumberOfArticles = updateDto.NumberOfArticles,
                RectificationFrequency = updateDto.RectificationFrequency,
                RegimeRequestNumber = updateDto.RegimeRequestNumber,
                SuppressionOn = updateDto.SuppressionOn
            };

        if (updateDto.CreatedAt != null)
            finalExportFollowedByReimportationInTheState.CreatedAt = updateDto.CreatedAt.Value;
        if (updateDto.UpdatedAt != null)
            finalExportFollowedByReimportationInTheState.UpdatedAt = updateDto.UpdatedAt.Value;

        return finalExportFollowedByReimportationInTheState;
    }
}
