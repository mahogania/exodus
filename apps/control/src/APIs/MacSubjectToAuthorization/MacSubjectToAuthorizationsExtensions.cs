using Control.APIs.Dtos;
using Control.Infrastructure.Models;

namespace Control.APIs.Extensions;

public static class MacSubjectToAuthorizationsExtensions
{
    public static MacSubjectToAuthorization ToDto(this MacSubjectToAuthorizationDbModel model)
    {
        return new MacSubjectToAuthorization
        {
            ApcCode = model.ApcCode,
            ApcLabel = model.ApcLabel,
            ArticleNumber = model.ArticleNumber,
            CountryOfDestination = model.CountryOfDestination,
            CountryOfOrigin = model.CountryOfOrigin,
            CreatedAt = model.CreatedAt,
            CustomsOfficeForMacClearance = model.CustomsOfficeForMacClearance,
            DateAndTimeOfFinalModification = model.DateAndTimeOfFinalModification,
            DateAndTimeOfFirstRegistration = model.DateAndTimeOfFirstRegistration,
            DeclarationOfficeCode = model.DeclarationOfficeCode,
            EpcCode = model.EpcCode,
            EpcLabel = model.EpcLabel,
            FinalModifierSId = model.FinalModifierSId,
            FirstRegistrantSId = model.FirstRegistrantSId,
            Id = model.Id,
            PreviousDeclarationDate = model.PreviousDeclarationDate,
            PreviousDeclarationNumber = model.PreviousDeclarationNumber,
            ReasonForTheRequest = model.ReasonForTheRequest,
            RecipientSupplier = model.RecipientSupplier,
            RectificationFrequency = model.RectificationFrequency,
            RegimeRequestNumber = model.RegimeRequestNumber,
            SuppressionOn = model.SuppressionOn,
            UpdatedAt = model.UpdatedAt
        };
    }

    public static MacSubjectToAuthorizationDbModel ToModel(
        this MacSubjectToAuthorizationUpdateInput updateDto,
        MacSubjectToAuthorizationWhereUniqueInput uniqueId
    )
    {
        var macSubjectToAuthorization = new MacSubjectToAuthorizationDbModel
        {
            Id = uniqueId.Id,
            ApcCode = updateDto.ApcCode,
            ApcLabel = updateDto.ApcLabel,
            ArticleNumber = updateDto.ArticleNumber,
            CountryOfDestination = updateDto.CountryOfDestination,
            CountryOfOrigin = updateDto.CountryOfOrigin,
            CustomsOfficeForMacClearance = updateDto.CustomsOfficeForMacClearance,
            DateAndTimeOfFinalModification = updateDto.DateAndTimeOfFinalModification,
            DateAndTimeOfFirstRegistration = updateDto.DateAndTimeOfFirstRegistration,
            DeclarationOfficeCode = updateDto.DeclarationOfficeCode,
            EpcCode = updateDto.EpcCode,
            EpcLabel = updateDto.EpcLabel,
            FinalModifierSId = updateDto.FinalModifierSId,
            FirstRegistrantSId = updateDto.FirstRegistrantSId,
            PreviousDeclarationDate = updateDto.PreviousDeclarationDate,
            PreviousDeclarationNumber = updateDto.PreviousDeclarationNumber,
            ReasonForTheRequest = updateDto.ReasonForTheRequest,
            RecipientSupplier = updateDto.RecipientSupplier,
            RectificationFrequency = updateDto.RectificationFrequency,
            RegimeRequestNumber = updateDto.RegimeRequestNumber,
            SuppressionOn = updateDto.SuppressionOn
        };

        if (updateDto.CreatedAt != null) macSubjectToAuthorization.CreatedAt = updateDto.CreatedAt.Value;
        if (updateDto.UpdatedAt != null) macSubjectToAuthorization.UpdatedAt = updateDto.UpdatedAt.Value;

        return macSubjectToAuthorization;
    }
}
