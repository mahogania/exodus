using Control.APIs.Dtos;
using Control.Infrastructure.Models;

namespace Control.APIs.Extensions;

public static class CustomsClearanceOfPostalGoodsItemsExtensions
{
    public static CustomsClearanceOfPostalGoods ToDto(
        this CustomsClearanceOfPostalGoodsDbModel model
    )
    {
        return new CustomsClearanceOfPostalGoods
        {
            ArrivalDate = model.ArrivalDate,
            AttachedFileId = model.AttachedFileId,
            BagIdentifier = model.BagIdentifier,
            CategoryCode = model.CategoryCode,
            CategoryOfTreatmentCode = model.CategoryOfTreatmentCode,
            CodeOfPostOfficeHandlingInternationalParcels =
                model.CodeOfPostOfficeHandlingInternationalParcels,
            CountryOfOriginCode = model.CountryOfOriginCode,
            CountryOfShipmentCode = model.CountryOfShipmentCode,
            CreatedAt = model.CreatedAt,
            CurrencyCodeForPostalPackageValue = model.CurrencyCodeForPostalPackageValue,
            CustomsOfficeCode = model.CustomsOfficeCode,
            DeclaredCurrencyCodeForInsurance = model.DeclaredCurrencyCodeForInsurance,
            DeclaredInsuranceAmount = model.DeclaredInsuranceAmount,
            DeletionOn = model.DeletionOn,
            DestinationRouting = model.DestinationRouting,
            FinalModificationDateAndTime = model.FinalModificationDateAndTime,
            FinalModifierSId = model.FinalModifierSId,
            FirstRecorderSId = model.FirstRecorderSId,
            FirstRegistrationDateAndTime = model.FirstRegistrationDateAndTime,
            FlightNumber = model.FlightNumber,
            GrossWeight = model.GrossWeight,
            Id = model.Id,
            ImportExportTypeCode = model.ImportExportTypeCode,
            MailClass = model.MailClass,
            ModeOfTransportCode = model.ModeOfTransportCode,
            NameOfOriginPostOffice = model.NameOfOriginPostOffice,
            NameOfPostOfficeHandlingInternationalParcels =
                model.NameOfPostOfficeHandlingInternationalParcels,
            Observations = model.Observations,
            OperationType = model.OperationType,
            OrdinaryCustomsClearanceOn = model.OrdinaryCustomsClearanceOn,
            OriginPost = model.OriginPost,
            PostalNumber = model.PostalNumber,
            PostalPackageCustomsClearanceRequestNumber =
                model.PostalPackageCustomsClearanceRequestNumber,
            PostalPackageValue = model.PostalPackageValue,
            ReceiverSEmail = model.ReceiverSEmail,
            ReceiverSId = model.ReceiverSId,
            ReceptionDateAlgerPort = model.ReceptionDateAlgerPort,
            RecipientAddressAddress1 = model.RecipientAddressAddress1,
            RecipientAddressAddress2 = model.RecipientAddressAddress2,
            RecipientAddressCity = model.RecipientAddressCity,
            RecipientAddressCountryCode = model.RecipientAddressCountryCode,
            RecipientSFixedPhoneNumber = model.RecipientSFixedPhoneNumber,
            RecipientSPostalCode = model.RecipientSPostalCode,
            RequestDate = model.RequestDate,
            RequesterSId = model.RequesterSId,
            ShipperSAddress = model.ShipperSAddress,
            ShipperSAddress_2 = model.ShipperSAddress_2,
            ShipperSCity = model.ShipperSCity,
            ShipperSEmail = model.ShipperSEmail,
            ShipperSId = model.ShipperSId,
            ShipperSName = model.ShipperSName,
            ShipperSPhoneNumber = model.ShipperSPhoneNumber,
            ShipperSPostalCode = model.ShipperSPostalCode,
            ShippingDate = model.ShippingDate,
            SimplifiedCustomsClearanceOn = model.SimplifiedCustomsClearanceOn,
            TotalTaxAmount = model.TotalTaxAmount,
            TransportDate = model.TransportDate,
            TreatmentCode = model.TreatmentCode,
            TreatmentStatusCode = model.TreatmentStatusCode,
            UpdatedAt = model.UpdatedAt
        };
    }

    public static CustomsClearanceOfPostalGoodsDbModel ToModel(
        this CustomsClearanceOfPostalGoodsUpdateInput updateDto,
        CustomsClearanceOfPostalGoodsWhereUniqueInput uniqueId
    )
    {
        var customsClearanceOfPostalGoods = new CustomsClearanceOfPostalGoodsDbModel
        {
            Id = uniqueId.Id,
            ArrivalDate = updateDto.ArrivalDate,
            AttachedFileId = updateDto.AttachedFileId,
            BagIdentifier = updateDto.BagIdentifier,
            CategoryCode = updateDto.CategoryCode,
            CategoryOfTreatmentCode = updateDto.CategoryOfTreatmentCode,
            CodeOfPostOfficeHandlingInternationalParcels =
                updateDto.CodeOfPostOfficeHandlingInternationalParcels,
            CountryOfOriginCode = updateDto.CountryOfOriginCode,
            CountryOfShipmentCode = updateDto.CountryOfShipmentCode,
            CurrencyCodeForPostalPackageValue = updateDto.CurrencyCodeForPostalPackageValue,
            CustomsOfficeCode = updateDto.CustomsOfficeCode,
            DeclaredCurrencyCodeForInsurance = updateDto.DeclaredCurrencyCodeForInsurance,
            DeclaredInsuranceAmount = updateDto.DeclaredInsuranceAmount,
            DeletionOn = updateDto.DeletionOn,
            DestinationRouting = updateDto.DestinationRouting,
            FinalModificationDateAndTime = updateDto.FinalModificationDateAndTime,
            FinalModifierSId = updateDto.FinalModifierSId,
            FirstRecorderSId = updateDto.FirstRecorderSId,
            FirstRegistrationDateAndTime = updateDto.FirstRegistrationDateAndTime,
            FlightNumber = updateDto.FlightNumber,
            GrossWeight = updateDto.GrossWeight,
            ImportExportTypeCode = updateDto.ImportExportTypeCode,
            MailClass = updateDto.MailClass,
            ModeOfTransportCode = updateDto.ModeOfTransportCode,
            NameOfOriginPostOffice = updateDto.NameOfOriginPostOffice,
            NameOfPostOfficeHandlingInternationalParcels =
                updateDto.NameOfPostOfficeHandlingInternationalParcels,
            Observations = updateDto.Observations,
            OperationType = updateDto.OperationType,
            OrdinaryCustomsClearanceOn = updateDto.OrdinaryCustomsClearanceOn,
            OriginPost = updateDto.OriginPost,
            PostalNumber = updateDto.PostalNumber,
            PostalPackageCustomsClearanceRequestNumber =
                updateDto.PostalPackageCustomsClearanceRequestNumber,
            PostalPackageValue = updateDto.PostalPackageValue,
            ReceiverSEmail = updateDto.ReceiverSEmail,
            ReceiverSId = updateDto.ReceiverSId,
            ReceptionDateAlgerPort = updateDto.ReceptionDateAlgerPort,
            RecipientAddressAddress1 = updateDto.RecipientAddressAddress1,
            RecipientAddressAddress2 = updateDto.RecipientAddressAddress2,
            RecipientAddressCity = updateDto.RecipientAddressCity,
            RecipientAddressCountryCode = updateDto.RecipientAddressCountryCode,
            RecipientSFixedPhoneNumber = updateDto.RecipientSFixedPhoneNumber,
            RecipientSPostalCode = updateDto.RecipientSPostalCode,
            RequestDate = updateDto.RequestDate,
            RequesterSId = updateDto.RequesterSId,
            ShipperSAddress = updateDto.ShipperSAddress,
            ShipperSAddress_2 = updateDto.ShipperSAddress_2,
            ShipperSCity = updateDto.ShipperSCity,
            ShipperSEmail = updateDto.ShipperSEmail,
            ShipperSId = updateDto.ShipperSId,
            ShipperSName = updateDto.ShipperSName,
            ShipperSPhoneNumber = updateDto.ShipperSPhoneNumber,
            ShipperSPostalCode = updateDto.ShipperSPostalCode,
            ShippingDate = updateDto.ShippingDate,
            SimplifiedCustomsClearanceOn = updateDto.SimplifiedCustomsClearanceOn,
            TotalTaxAmount = updateDto.TotalTaxAmount,
            TransportDate = updateDto.TransportDate,
            TreatmentCode = updateDto.TreatmentCode,
            TreatmentStatusCode = updateDto.TreatmentStatusCode
        };

        if (updateDto.CreatedAt != null) customsClearanceOfPostalGoods.CreatedAt = updateDto.CreatedAt.Value;
        if (updateDto.UpdatedAt != null) customsClearanceOfPostalGoods.UpdatedAt = updateDto.UpdatedAt.Value;

        return customsClearanceOfPostalGoods;
    }
}
