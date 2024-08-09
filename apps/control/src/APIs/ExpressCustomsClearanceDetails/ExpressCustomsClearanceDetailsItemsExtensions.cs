using Control.APIs.Dtos;
using Control.Infrastructure.Models;

namespace Control.APIs.Extensions;

public static class ExpressCustomsClearanceDetailsItemsExtensions
{
    public static ExpressCustomsClearanceDetails ToDto(
        this ExpressCustomsClearanceDetailsDbModel model
    )
    {
        return new ExpressCustomsClearanceDetails
        {
            BarcodeContent = model.BarcodeContent,
            BarcodeTransmissionDateAndTime = model.BarcodeTransmissionDateAndTime,
            CarrierCode = model.CarrierCode,
            CommercialDenomination = model.CommercialDenomination,
            CreatedAt = model.CreatedAt,
            CustomsClearanceCode = model.CustomsClearanceCode,
            CustomsNote = model.CustomsNote,
            DateAndTimeOfFinalModification = model.DateAndTimeOfFinalModification,
            DateAndTimeOfFirstRegistration = model.DateAndTimeOfFirstRegistration,
            ECommercialWebsite = model.ECommercialWebsite,
            ElectronicCommercialEnterpriseCertificationNumber =
                model.ElectronicCommercialEnterpriseCertificationNumber,
            ExpressCustomsClearanceRequestNumber = model.ExpressCustomsClearanceRequestNumber,
            ExpressCustomsClearanceTypeCode = model.ExpressCustomsClearanceTypeCode,
            ExpressOperatorCode = model.ExpressOperatorCode,
            FinalModifierSId = model.FinalModifierSId,
            GoodsValue = model.GoodsValue,
            HouseBlNumber = model.HouseBlNumber,
            Id = model.Id,
            IdDuPremierEnregistrant = model.IdDuPremierEnregistrant,
            MasterBlNumber = model.MasterBlNumber,
            OperationType = model.OperationType,
            OrdinaryCustomsClearanceOn = model.OrdinaryCustomsClearanceOn,
            PackageQuantity = model.PackageQuantity,
            ProcessingStatusCode = model.ProcessingStatusCode,
            PurposeTypeCode = model.PurposeTypeCode,
            Quantity = model.Quantity,
            RecipientSAddress = model.RecipientSAddress,
            RecipientSIdentificationCode = model.RecipientSIdentificationCode,
            RecipientSName = model.RecipientSName,
            RecipientSPhoneNumber = model.RecipientSPhoneNumber,
            RecipientSPostalCode = model.RecipientSPostalCode,
            SenderSAddress = model.SenderSAddress,
            SenderSName = model.SenderSName,
            SenderSPhoneNumber = model.SenderSPhoneNumber,
            SequenceNumber = model.SequenceNumber,
            ShCode = model.ShCode,
            ShippingCountryCode = model.ShippingCountryCode,
            SimpleCustomsDutyAmount = model.SimpleCustomsDutyAmount,
            SimplifiedCustomsClearanceOn = model.SimplifiedCustomsClearanceOn,
            Standards = model.Standards,
            SuppressionOn = model.SuppressionOn,
            UpdatedAt = model.UpdatedAt,
            Weight = model.Weight,
        };
    }

    public static ExpressCustomsClearanceDetailsDbModel ToModel(
        this ExpressCustomsClearanceDetailsUpdateInput updateDto,
        ExpressCustomsClearanceDetailsWhereUniqueInput uniqueId
    )
    {
        var expressCustomsClearanceDetails = new ExpressCustomsClearanceDetailsDbModel
        {
            Id = uniqueId.Id,
            BarcodeContent = updateDto.BarcodeContent,
            BarcodeTransmissionDateAndTime = updateDto.BarcodeTransmissionDateAndTime,
            CarrierCode = updateDto.CarrierCode,
            CommercialDenomination = updateDto.CommercialDenomination,
            CustomsClearanceCode = updateDto.CustomsClearanceCode,
            CustomsNote = updateDto.CustomsNote,
            DateAndTimeOfFinalModification = updateDto.DateAndTimeOfFinalModification,
            DateAndTimeOfFirstRegistration = updateDto.DateAndTimeOfFirstRegistration,
            ECommercialWebsite = updateDto.ECommercialWebsite,
            ElectronicCommercialEnterpriseCertificationNumber =
                updateDto.ElectronicCommercialEnterpriseCertificationNumber,
            ExpressCustomsClearanceRequestNumber = updateDto.ExpressCustomsClearanceRequestNumber,
            ExpressCustomsClearanceTypeCode = updateDto.ExpressCustomsClearanceTypeCode,
            ExpressOperatorCode = updateDto.ExpressOperatorCode,
            FinalModifierSId = updateDto.FinalModifierSId,
            GoodsValue = updateDto.GoodsValue,
            HouseBlNumber = updateDto.HouseBlNumber,
            IdDuPremierEnregistrant = updateDto.IdDuPremierEnregistrant,
            MasterBlNumber = updateDto.MasterBlNumber,
            OperationType = updateDto.OperationType,
            OrdinaryCustomsClearanceOn = updateDto.OrdinaryCustomsClearanceOn,
            PackageQuantity = updateDto.PackageQuantity,
            ProcessingStatusCode = updateDto.ProcessingStatusCode,
            PurposeTypeCode = updateDto.PurposeTypeCode,
            Quantity = updateDto.Quantity,
            RecipientSAddress = updateDto.RecipientSAddress,
            RecipientSIdentificationCode = updateDto.RecipientSIdentificationCode,
            RecipientSName = updateDto.RecipientSName,
            RecipientSPhoneNumber = updateDto.RecipientSPhoneNumber,
            RecipientSPostalCode = updateDto.RecipientSPostalCode,
            SenderSAddress = updateDto.SenderSAddress,
            SenderSName = updateDto.SenderSName,
            SenderSPhoneNumber = updateDto.SenderSPhoneNumber,
            SequenceNumber = updateDto.SequenceNumber,
            ShCode = updateDto.ShCode,
            ShippingCountryCode = updateDto.ShippingCountryCode,
            SimpleCustomsDutyAmount = updateDto.SimpleCustomsDutyAmount,
            SimplifiedCustomsClearanceOn = updateDto.SimplifiedCustomsClearanceOn,
            Standards = updateDto.Standards,
            SuppressionOn = updateDto.SuppressionOn,
            Weight = updateDto.Weight
        };

        if (updateDto.CreatedAt != null)
        {
            expressCustomsClearanceDetails.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.UpdatedAt != null)
        {
            expressCustomsClearanceDetails.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return expressCustomsClearanceDetails;
    }
}
