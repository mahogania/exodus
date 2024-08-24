using Control.APIs.Dtos;
using Control.Infrastructure.Models;

namespace Control.APIs.Extensions;

public static class CommonDetailedDeclarationsExtensions
{
    public static CommonDetailedDeclaration ToDto(this CommonDetailedDeclarationDbModel model)
    {
        return new CommonDetailedDeclaration
        {
            ArrivalDate = model.ArrivalDate,
            Articles = model.Articles?.Select(x => x.Id).ToList(),
            ArticlesExpectedForReImportExport = model
                .ArticlesExpectedForReImportExport?.Select(x => x.Id)
                .ToList(),
            Assessment = model.AssessmentId,
            BankAgencyCode = model.BankAgencyCode,
            BillOfLadingDate = model.BillOfLadingDate,
            BillOfLadingNumber = model.BillOfLadingNumber,
            ConditionCode_2 = model.ConditionCode_2,
            Container = model.ContainerId,
            ContainerizedCargoOn = model.ContainerizedCargoOn,
            CreatedAt = model.CreatedAt,
            Crn = model.Crn,
            CustomsClearancePlanCode = model.CustomsClearancePlanCode,
            CustomsDeclarationSuppressionOn = model.CustomsDeclarationSuppressionOn,
            DateAndTimeOfFinalModification = model.DateAndTimeOfFinalModification,
            DateAndTimeOfFirstRegistration = model.DateAndTimeOfFirstRegistration,
            DeclarantCode = model.DeclarantCode,
            DeclarantSReservedFreeText = model.DeclarantSReservedFreeText,
            DeclarantsReservedFreeText = model.DeclarantsReservedFreeText,
            DeclarationFormCode = model.DeclarationFormCode,
            DeclarationOfficeCode = model.DeclarationOfficeCode,
            DeclarationTypeCode = model.DeclarationTypeCode,
            DeliveryConditionCode = model.DeliveryConditionCode,
            DeliveryLocationCode = model.DeliveryLocationCode,
            DestinationCountryCode = model.DestinationCountryCode,
            DetailedDeclarationNumber = model.DetailedDeclarationNumber,
            Document = model.DocumentId,
            DomiciliationDate = model.DomiciliationDate,
            DomiciliationStatusCode = model.DomiciliationStatusCode,
            EntryAndExitOfficeCode = model.EntryAndExitOfficeCode,
            EpcCode = model.EpcCode,
            ExporterSCommercialRegistryNumber = model.ExporterSCommercialRegistryNumber,
            ExporterSIdentificationNumber = model.ExporterSIdentificationNumber,
            ExporterSIdentificationNumberTypeCode = model.ExporterSIdentificationNumberTypeCode,
            ExportersCommercialRegistryNumber = model.ExportersCommercialRegistryNumber,
            ExportersIdentificationNumber = model.ExportersIdentificationNumber,
            ExportersIdentificationNumberTypeCode = model.ExportersIdentificationNumberTypeCode,
            ExportingCountryCode = model.ExportingCountryCode,
            FinalModifierSId = model.FinalModifierSId,
            FinalModifiersId = model.FinalModifiersId,
            FinalOn = model.FinalOn,
            FinancingMode = model.FinancingMode,
            FirstRecorderSId = model.FirstRecorderSId,
            FirstRecordersId = model.FirstRecordersId,
            Id = model.Id,
            IdentificationNumberTypeCode = model.IdentificationNumberTypeCode,
            ImporterSCommercialRegistryNumber = model.ImporterSCommercialRegistryNumber,
            ImporterSIdentificationNumber = model.ImporterSIdentificationNumber,
            ImporterSIdentificationNumberTypeCode = model.ImporterSIdentificationNumberTypeCode,
            ImportersCommercialRegistryNumber = model.ImportersCommercialRegistryNumber,
            ImportersIdentificationNumber = model.ImportersIdentificationNumber,
            InitialDeclarationDate = model.InitialDeclarationDate,
            InvoiceIssuanceDate = model.InvoiceIssuanceDate,
            InvoiceNumber = model.InvoiceNumber,
            Journal = model.Journal?.ToDto(),
            LoadingLocationCode = model.LoadingLocationCode,
            ManagementAndMonitoringClearancePeriod = model.ManagementAndMonitoringClearancePeriod,
            MeansOfTransportIdentificationNumber = model.MeansOfTransportIdentificationNumber,
            MeansOfTransportIdentificationNumberTypeCode =
                model.MeansOfTransportIdentificationNumberTypeCode,
            MeansOfTransportNationalityCode = model.MeansOfTransportNationalityCode,
            ModificationReasonCode = model.ModificationReasonCode,
            NumberOfContainers = model.NumberOfContainers,
            NumberOfItems = model.NumberOfItems,
            OperationType = model.OperationType,
            Operator = model.OperatorId,
            PartialCustomsClearanceTypeCode = model.PartialCustomsClearanceTypeCode,
            PaymentAccountNumber = model.PaymentAccountNumber,
            PaymentBankAgencyCode = model.PaymentBankAgencyCode,
            PaymentBankCode = model.PaymentBankCode,
            PaymentModeCode = model.PaymentModeCode,
            PreviousBondedWarehouseCode = model.PreviousBondedWarehouseCode,
            PreviousCustomsBondedWarehouseCode = model.PreviousCustomsBondedWarehouseCode,
            RecipientRegionCode = model.RecipientRegionCode,
            RectificationFrequency = model.RectificationFrequency,
            RectificationReason = model.RectificationReason,
            ReferenceNumber = model.ReferenceNumber,
            RegimeRequestNumber = model.RegimeRequestNumber,
            RequestDate = model.RequestDate,
            SeizedValueDeclarationOn = model.SeizedValueDeclarationOn,
            SelfLiquidationOn = model.SelfLiquidationOn,
            ServiceCode = model.ServiceCode,
            ShipName = model.ShipName,
            ShippingCountryCode = model.ShippingCountryCode,
            StorageLocationCode = model.StorageLocationCode,
            SuppressionOn = model.SuppressionOn,
            SystemUsageTime = model.SystemUsageTime,
            TaxIdentificationNumber = model.TaxIdentificationNumber,
            TaxpayerIdentificationNumber = model.TaxpayerIdentificationNumber,
            TaxpayerSCommercialRegistryNumber = model.TaxpayerSCommercialRegistryNumber,
            TaxpayerSIdentificationNumber = model.TaxpayerSIdentificationNumber,
            TaxpayersCommercialRegistryNumber = model.TaxpayersCommercialRegistryNumber,
            TaxpayersIdentificationNumber = model.TaxpayersIdentificationNumber,
            TotalGrossWeight = model.TotalGrossWeight,
            TotalNetWeight = model.TotalNetWeight,
            TotalNumberOfPackages = model.TotalNumberOfPackages,
            TransactionConditionCode_1 = model.TransactionConditionCode_1,
            TransactionConditionCode_2 = model.TransactionConditionCode_2,
            TransactionCountryCode = model.TransactionCountryCode,
            TravelerProcessingText = model.TravelerProcessingText,
            TravelerReferenceNumber = model.TravelerReferenceNumber,
            UnloadingDate = model.UnloadingDate,
            UnloadingLocationCode = model.UnloadingLocationCode,
            UpdatedAt = model.UpdatedAt,
            ValueDeclaration = model.ValueDeclarationId,
            ValueDeclarationOn = model.ValueDeclarationOn,
            VehiclePickupOn = model.VehiclePickupOn,
        };
    }

    public static CommonDetailedDeclarationDbModel ToModel(
        this CommonDetailedDeclarationUpdateInput updateDto,
        CommonDetailedDeclarationWhereUniqueInput uniqueId
    )
    {
        var commonDetailedDeclaration = new CommonDetailedDeclarationDbModel
        {
            Id = uniqueId.Id,
            ArrivalDate = updateDto.ArrivalDate,
            BankAgencyCode = updateDto.BankAgencyCode,
            BillOfLadingDate = updateDto.BillOfLadingDate,
            BillOfLadingNumber = updateDto.BillOfLadingNumber,
            ConditionCode_2 = updateDto.ConditionCode_2,
            ContainerizedCargoOn = updateDto.ContainerizedCargoOn,
            Crn = updateDto.Crn,
            CustomsClearancePlanCode = updateDto.CustomsClearancePlanCode,
            CustomsDeclarationSuppressionOn = updateDto.CustomsDeclarationSuppressionOn,
            DateAndTimeOfFinalModification = updateDto.DateAndTimeOfFinalModification,
            DateAndTimeOfFirstRegistration = updateDto.DateAndTimeOfFirstRegistration,
            DeclarantCode = updateDto.DeclarantCode,
            DeclarantSReservedFreeText = updateDto.DeclarantSReservedFreeText,
            DeclarantsReservedFreeText = updateDto.DeclarantsReservedFreeText,
            DeclarationFormCode = updateDto.DeclarationFormCode,
            DeclarationOfficeCode = updateDto.DeclarationOfficeCode,
            DeclarationTypeCode = updateDto.DeclarationTypeCode,
            DeliveryConditionCode = updateDto.DeliveryConditionCode,
            DeliveryLocationCode = updateDto.DeliveryLocationCode,
            DestinationCountryCode = updateDto.DestinationCountryCode,
            DetailedDeclarationNumber = updateDto.DetailedDeclarationNumber,
            DomiciliationDate = updateDto.DomiciliationDate,
            DomiciliationStatusCode = updateDto.DomiciliationStatusCode,
            EntryAndExitOfficeCode = updateDto.EntryAndExitOfficeCode,
            EpcCode = updateDto.EpcCode,
            ExporterSCommercialRegistryNumber = updateDto.ExporterSCommercialRegistryNumber,
            ExporterSIdentificationNumber = updateDto.ExporterSIdentificationNumber,
            ExporterSIdentificationNumberTypeCode = updateDto.ExporterSIdentificationNumberTypeCode,
            ExportersCommercialRegistryNumber = updateDto.ExportersCommercialRegistryNumber,
            ExportersIdentificationNumber = updateDto.ExportersIdentificationNumber,
            ExportersIdentificationNumberTypeCode = updateDto.ExportersIdentificationNumberTypeCode,
            ExportingCountryCode = updateDto.ExportingCountryCode,
            FinalModifierSId = updateDto.FinalModifierSId,
            FinalModifiersId = updateDto.FinalModifiersId,
            FinalOn = updateDto.FinalOn,
            FinancingMode = updateDto.FinancingMode,
            FirstRecorderSId = updateDto.FirstRecorderSId,
            FirstRecordersId = updateDto.FirstRecordersId,
            IdentificationNumberTypeCode = updateDto.IdentificationNumberTypeCode,
            ImporterSCommercialRegistryNumber = updateDto.ImporterSCommercialRegistryNumber,
            ImporterSIdentificationNumber = updateDto.ImporterSIdentificationNumber,
            ImporterSIdentificationNumberTypeCode = updateDto.ImporterSIdentificationNumberTypeCode,
            ImportersCommercialRegistryNumber = updateDto.ImportersCommercialRegistryNumber,
            ImportersIdentificationNumber = updateDto.ImportersIdentificationNumber,
            InitialDeclarationDate = updateDto.InitialDeclarationDate,
            InvoiceIssuanceDate = updateDto.InvoiceIssuanceDate,
            InvoiceNumber = updateDto.InvoiceNumber,
            LoadingLocationCode = updateDto.LoadingLocationCode,
            ManagementAndMonitoringClearancePeriod =
                updateDto.ManagementAndMonitoringClearancePeriod,
            MeansOfTransportIdentificationNumber = updateDto.MeansOfTransportIdentificationNumber,
            MeansOfTransportIdentificationNumberTypeCode =
                updateDto.MeansOfTransportIdentificationNumberTypeCode,
            MeansOfTransportNationalityCode = updateDto.MeansOfTransportNationalityCode,
            ModificationReasonCode = updateDto.ModificationReasonCode,
            NumberOfContainers = updateDto.NumberOfContainers,
            NumberOfItems = updateDto.NumberOfItems,
            OperationType = updateDto.OperationType,
            PartialCustomsClearanceTypeCode = updateDto.PartialCustomsClearanceTypeCode,
            PaymentAccountNumber = updateDto.PaymentAccountNumber,
            PaymentBankAgencyCode = updateDto.PaymentBankAgencyCode,
            PaymentBankCode = updateDto.PaymentBankCode,
            PaymentModeCode = updateDto.PaymentModeCode,
            PreviousBondedWarehouseCode = updateDto.PreviousBondedWarehouseCode,
            PreviousCustomsBondedWarehouseCode = updateDto.PreviousCustomsBondedWarehouseCode,
            RecipientRegionCode = updateDto.RecipientRegionCode,
            RectificationFrequency = updateDto.RectificationFrequency,
            RectificationReason = updateDto.RectificationReason,
            ReferenceNumber = updateDto.ReferenceNumber,
            RegimeRequestNumber = updateDto.RegimeRequestNumber,
            RequestDate = updateDto.RequestDate,
            SeizedValueDeclarationOn = updateDto.SeizedValueDeclarationOn,
            SelfLiquidationOn = updateDto.SelfLiquidationOn,
            ServiceCode = updateDto.ServiceCode,
            ShipName = updateDto.ShipName,
            ShippingCountryCode = updateDto.ShippingCountryCode,
            StorageLocationCode = updateDto.StorageLocationCode,
            SuppressionOn = updateDto.SuppressionOn,
            SystemUsageTime = updateDto.SystemUsageTime,
            TaxIdentificationNumber = updateDto.TaxIdentificationNumber,
            TaxpayerIdentificationNumber = updateDto.TaxpayerIdentificationNumber,
            TaxpayerSCommercialRegistryNumber = updateDto.TaxpayerSCommercialRegistryNumber,
            TaxpayerSIdentificationNumber = updateDto.TaxpayerSIdentificationNumber,
            TaxpayersCommercialRegistryNumber = updateDto.TaxpayersCommercialRegistryNumber,
            TaxpayersIdentificationNumber = updateDto.TaxpayersIdentificationNumber,
            TotalGrossWeight = updateDto.TotalGrossWeight,
            TotalNetWeight = updateDto.TotalNetWeight,
            TotalNumberOfPackages = updateDto.TotalNumberOfPackages,
            TransactionConditionCode_1 = updateDto.TransactionConditionCode_1,
            TransactionConditionCode_2 = updateDto.TransactionConditionCode_2,
            TransactionCountryCode = updateDto.TransactionCountryCode,
            TravelerProcessingText = updateDto.TravelerProcessingText,
            TravelerReferenceNumber = updateDto.TravelerReferenceNumber,
            UnloadingDate = updateDto.UnloadingDate,
            UnloadingLocationCode = updateDto.UnloadingLocationCode,
            ValueDeclarationOn = updateDto.ValueDeclarationOn,
            VehiclePickupOn = updateDto.VehiclePickupOn
        };

        if (updateDto.Assessment != null)
        {
            commonDetailedDeclaration.AssessmentId = updateDto.Assessment;
        }
        if (updateDto.Container != null)
        {
            commonDetailedDeclaration.ContainerId = updateDto.Container;
        }
        if (updateDto.CreatedAt != null)
        {
            commonDetailedDeclaration.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.Document != null)
        {
            commonDetailedDeclaration.DocumentId = updateDto.Document;
        }
        if (updateDto.Operator != null)
        {
            commonDetailedDeclaration.OperatorId = updateDto.Operator;
        }
        if (updateDto.UpdatedAt != null)
        {
            commonDetailedDeclaration.UpdatedAt = updateDto.UpdatedAt.Value;
        }
        if (updateDto.ValueDeclaration != null)
        {
            commonDetailedDeclaration.ValueDeclarationId = updateDto.ValueDeclaration;
        }

        return commonDetailedDeclaration;
    }
}
