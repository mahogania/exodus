using Control.APIs.Dtos;
using Control.Infrastructure.Models;

namespace Control.APIs.Extensions;

public static class PostalParcelSimplifiedClearancesExtensions
{
    public static PostalParcelSimplifiedClearance ToDto(
        this PostalParcelSimplifiedClearanceDbModel model
    )
    {
        return new PostalParcelSimplifiedClearance
        {
            AmountAndCurrencyCode = model.AmountAndCurrencyCode,
            ApplicationOfTheFreeTradeAgreementTariffOn =
                model.ApplicationOfTheFreeTradeAgreementTariffOn,
            ArrivalDate = model.ArrivalDate,
            AttachedFileId = model.AttachedFileId,
            CodeOfPaymentMethod = model.CodeOfPaymentMethod,
            CodeOfThePostOfficeHandlingInternationalParcels =
                model.CodeOfThePostOfficeHandlingInternationalParcels,
            CodeOfTypeOfArticlesSuspectedOfInfringingIntellectualPropertyRights =
                model.CodeOfTypeOfArticlesSuspectedOfInfringingIntellectualPropertyRights,
            CodeOfTypeOfDestruction = model.CodeOfTypeOfDestruction,
            CodeOfTypeOfReturn = model.CodeOfTypeOfReturn,
            CommercialName = model.CommercialName,
            ContentsOfOthers = model.ContentsOfOthers,
            CountryOfDispatchCode = model.CountryOfDispatchCode,
            CreatedAt = model.CreatedAt,
            CustomsClearanceNumber = model.CustomsClearanceNumber,
            CustomsOfficeCode = model.CustomsOfficeCode,
            CustomsSimplifiedClearanceRequestNumber = model.CustomsSimplifiedClearanceRequestNumber,
            DateAndTimeOfFinalModification = model.DateAndTimeOfFinalModification,
            DateAndTimeOfFirstRegistration = model.DateAndTimeOfFirstRegistration,
            DeclarantSCode = model.DeclarantSCode,
            DeclaredGoodsName = model.DeclaredGoodsName,
            FinalModifierSId = model.FinalModifierSId,
            FirstRecorderSId = model.FirstRecorderSId,
            GiftsOn = model.GiftsOn,
            GrossWeight = model.GrossWeight,
            Id = model.Id,
            NameOfThePostOfficeHandlingInternationalParcels =
                model.NameOfThePostOfficeHandlingInternationalParcels,
            OthersOn = model.OthersOn,
            PersonalCustomsClearanceNumber = model.PersonalCustomsClearanceNumber,
            PersonalPurchaseOn = model.PersonalPurchaseOn,
            PostalParcelNumber = model.PostalParcelNumber,
            Quantity = model.Quantity,
            ReasonsForArticlesSuspectedOfInfringingIntellectualPropertyRights =
                model.ReasonsForArticlesSuspectedOfInfringingIntellectualPropertyRights,
            RecipientSAddress = model.RecipientSAddress,
            RecipientSName = model.RecipientSName,
            RecipientSPhoneNumber = model.RecipientSPhoneNumber,
            RecipientSPostalCode = model.RecipientSPostalCode,
            ReintroductionOn = model.ReintroductionOn,
            RequestDate = model.RequestDate,
            ReturnOrDestructionOn = model.ReturnOrDestructionOn,
            SenderSName = model.SenderSName,
            Standards = model.Standards,
            StatusCodeOfProcessing = model.StatusCodeOfProcessing,
            SuppressionOn = model.SuppressionOn,
            UpdatedAt = model.UpdatedAt,
            ValueOfPostalParcels = model.ValueOfPostalParcels,
            Weight = model.Weight,
        };
    }

    public static PostalParcelSimplifiedClearanceDbModel ToModel(
        this PostalParcelSimplifiedClearanceUpdateInput updateDto,
        PostalParcelSimplifiedClearanceWhereUniqueInput uniqueId
    )
    {
        var postalParcelSimplifiedClearance = new PostalParcelSimplifiedClearanceDbModel
        {
            Id = uniqueId.Id,
            AmountAndCurrencyCode = updateDto.AmountAndCurrencyCode,
            ApplicationOfTheFreeTradeAgreementTariffOn =
                updateDto.ApplicationOfTheFreeTradeAgreementTariffOn,
            ArrivalDate = updateDto.ArrivalDate,
            AttachedFileId = updateDto.AttachedFileId,
            CodeOfPaymentMethod = updateDto.CodeOfPaymentMethod,
            CodeOfThePostOfficeHandlingInternationalParcels =
                updateDto.CodeOfThePostOfficeHandlingInternationalParcels,
            CodeOfTypeOfArticlesSuspectedOfInfringingIntellectualPropertyRights =
                updateDto.CodeOfTypeOfArticlesSuspectedOfInfringingIntellectualPropertyRights,
            CodeOfTypeOfDestruction = updateDto.CodeOfTypeOfDestruction,
            CodeOfTypeOfReturn = updateDto.CodeOfTypeOfReturn,
            CommercialName = updateDto.CommercialName,
            ContentsOfOthers = updateDto.ContentsOfOthers,
            CountryOfDispatchCode = updateDto.CountryOfDispatchCode,
            CustomsClearanceNumber = updateDto.CustomsClearanceNumber,
            CustomsOfficeCode = updateDto.CustomsOfficeCode,
            CustomsSimplifiedClearanceRequestNumber =
                updateDto.CustomsSimplifiedClearanceRequestNumber,
            DateAndTimeOfFinalModification = updateDto.DateAndTimeOfFinalModification,
            DateAndTimeOfFirstRegistration = updateDto.DateAndTimeOfFirstRegistration,
            DeclarantSCode = updateDto.DeclarantSCode,
            DeclaredGoodsName = updateDto.DeclaredGoodsName,
            FinalModifierSId = updateDto.FinalModifierSId,
            FirstRecorderSId = updateDto.FirstRecorderSId,
            GiftsOn = updateDto.GiftsOn,
            GrossWeight = updateDto.GrossWeight,
            NameOfThePostOfficeHandlingInternationalParcels =
                updateDto.NameOfThePostOfficeHandlingInternationalParcels,
            OthersOn = updateDto.OthersOn,
            PersonalCustomsClearanceNumber = updateDto.PersonalCustomsClearanceNumber,
            PersonalPurchaseOn = updateDto.PersonalPurchaseOn,
            PostalParcelNumber = updateDto.PostalParcelNumber,
            Quantity = updateDto.Quantity,
            ReasonsForArticlesSuspectedOfInfringingIntellectualPropertyRights =
                updateDto.ReasonsForArticlesSuspectedOfInfringingIntellectualPropertyRights,
            RecipientSAddress = updateDto.RecipientSAddress,
            RecipientSName = updateDto.RecipientSName,
            RecipientSPhoneNumber = updateDto.RecipientSPhoneNumber,
            RecipientSPostalCode = updateDto.RecipientSPostalCode,
            ReintroductionOn = updateDto.ReintroductionOn,
            RequestDate = updateDto.RequestDate,
            ReturnOrDestructionOn = updateDto.ReturnOrDestructionOn,
            SenderSName = updateDto.SenderSName,
            Standards = updateDto.Standards,
            StatusCodeOfProcessing = updateDto.StatusCodeOfProcessing,
            SuppressionOn = updateDto.SuppressionOn,
            ValueOfPostalParcels = updateDto.ValueOfPostalParcels,
            Weight = updateDto.Weight
        };

        if (updateDto.CreatedAt != null)
        {
            postalParcelSimplifiedClearance.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.UpdatedAt != null)
        {
            postalParcelSimplifiedClearance.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return postalParcelSimplifiedClearance;
    }
}
