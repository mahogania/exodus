using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Control.APIs.Extensions;
using Control.Infrastructure;
using Control.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Control.APIs;

public abstract class CommonDetailedDeclarationsServiceBase : ICommonDetailedDeclarationsService
{
    protected readonly ControlDbContext _context;

    public CommonDetailedDeclarationsServiceBase(ControlDbContext context)
    {
        _context = context;
    }

    /// <summary>
    ///     Create one COMMON DETAILED DECLARATION
    /// </summary>
    public async Task<CommonDetailedDeclaration> CreateCommonDetailedDeclaration(
        CommonDetailedDeclarationCreateInput createDto
    )
    {
        var commonDetailedDeclaration = new CommonDetailedDeclarationDbModel
        {
            ArrivalDate = createDto.ArrivalDate,
            BankAgencyCode = createDto.BankAgencyCode,
            BillOfLadingDate = createDto.BillOfLadingDate,
            BillOfLadingNumber = createDto.BillOfLadingNumber,
            ConditionCode_2 = createDto.ConditionCode_2,
            ContainerizedCargoOn = createDto.ContainerizedCargoOn,
            CreatedAt = createDto.CreatedAt,
            Crn = createDto.Crn,
            CustomsClearancePlanCode = createDto.CustomsClearancePlanCode,
            CustomsDeclarationSuppressionOn = createDto.CustomsDeclarationSuppressionOn,
            DateAndTimeOfFinalModification = createDto.DateAndTimeOfFinalModification,
            DateAndTimeOfFirstRegistration = createDto.DateAndTimeOfFirstRegistration,
            DeclarantCode = createDto.DeclarantCode,
            DeclarantSReservedFreeText = createDto.DeclarantSReservedFreeText,
            DeclarantsReservedFreeText = createDto.DeclarantsReservedFreeText,
            DeclarationFormCode = createDto.DeclarationFormCode,
            DeclarationOfficeCode = createDto.DeclarationOfficeCode,
            DeclarationTypeCode = createDto.DeclarationTypeCode,
            DeliveryConditionCode = createDto.DeliveryConditionCode,
            DeliveryLocationCode = createDto.DeliveryLocationCode,
            DestinationCountryCode = createDto.DestinationCountryCode,
            DetailedDeclarationNumber = createDto.DetailedDeclarationNumber,
            DomiciliationDate = createDto.DomiciliationDate,
            DomiciliationStatusCode = createDto.DomiciliationStatusCode,
            EntryAndExitOfficeCode = createDto.EntryAndExitOfficeCode,
            EpcCode = createDto.EpcCode,
            ExporterSCommercialRegistryNumber = createDto.ExporterSCommercialRegistryNumber,
            ExporterSIdentificationNumber = createDto.ExporterSIdentificationNumber,
            ExporterSIdentificationNumberTypeCode = createDto.ExporterSIdentificationNumberTypeCode,
            ExportersCommercialRegistryNumber = createDto.ExportersCommercialRegistryNumber,
            ExportersIdentificationNumber = createDto.ExportersIdentificationNumber,
            ExportersIdentificationNumberTypeCode = createDto.ExportersIdentificationNumberTypeCode,
            ExportingCountryCode = createDto.ExportingCountryCode,
            FinalModifierSId = createDto.FinalModifierSId,
            FinalModifiersId = createDto.FinalModifiersId,
            FinalOn = createDto.FinalOn,
            FinancingMode = createDto.FinancingMode,
            FirstRecorderSId = createDto.FirstRecorderSId,
            FirstRecordersId = createDto.FirstRecordersId,
            IdentificationNumberTypeCode = createDto.IdentificationNumberTypeCode,
            ImporterSCommercialRegistryNumber = createDto.ImporterSCommercialRegistryNumber,
            ImporterSIdentificationNumber = createDto.ImporterSIdentificationNumber,
            ImporterSIdentificationNumberTypeCode = createDto.ImporterSIdentificationNumberTypeCode,
            ImportersCommercialRegistryNumber = createDto.ImportersCommercialRegistryNumber,
            ImportersIdentificationNumber = createDto.ImportersIdentificationNumber,
            InitialDeclarationDate = createDto.InitialDeclarationDate,
            InvoiceIssuanceDate = createDto.InvoiceIssuanceDate,
            InvoiceNumber = createDto.InvoiceNumber,
            LoadingLocationCode = createDto.LoadingLocationCode,
            ManagementAndMonitoringClearancePeriod =
                createDto.ManagementAndMonitoringClearancePeriod,
            MeansOfTransportIdentificationNumber = createDto.MeansOfTransportIdentificationNumber,
            MeansOfTransportIdentificationNumberTypeCode =
                createDto.MeansOfTransportIdentificationNumberTypeCode,
            MeansOfTransportNationalityCode = createDto.MeansOfTransportNationalityCode,
            ModificationReasonCode = createDto.ModificationReasonCode,
            NumberOfContainers = createDto.NumberOfContainers,
            NumberOfItems = createDto.NumberOfItems,
            OperationType = createDto.OperationType,
            PartialCustomsClearanceTypeCode = createDto.PartialCustomsClearanceTypeCode,
            PaymentAccountNumber = createDto.PaymentAccountNumber,
            PaymentBankAgencyCode = createDto.PaymentBankAgencyCode,
            PaymentBankCode = createDto.PaymentBankCode,
            PaymentModeCode = createDto.PaymentModeCode,
            PreviousBondedWarehouseCode = createDto.PreviousBondedWarehouseCode,
            PreviousCustomsBondedWarehouseCode = createDto.PreviousCustomsBondedWarehouseCode,
            RecipientRegionCode = createDto.RecipientRegionCode,
            RectificationFrequency = createDto.RectificationFrequency,
            RectificationReason = createDto.RectificationReason,
            ReferenceNumber = createDto.ReferenceNumber,
            RegimeRequestNumber = createDto.RegimeRequestNumber,
            RequestDate = createDto.RequestDate,
            SeizedValueDeclarationOn = createDto.SeizedValueDeclarationOn,
            SelfLiquidationOn = createDto.SelfLiquidationOn,
            ServiceCode = createDto.ServiceCode,
            ShipName = createDto.ShipName,
            ShippingCountryCode = createDto.ShippingCountryCode,
            StorageLocationCode = createDto.StorageLocationCode,
            SuppressionOn = createDto.SuppressionOn,
            SystemUsageTime = createDto.SystemUsageTime,
            TaxIdentificationNumber = createDto.TaxIdentificationNumber,
            TaxpayerIdentificationNumber = createDto.TaxpayerIdentificationNumber,
            TaxpayerSCommercialRegistryNumber = createDto.TaxpayerSCommercialRegistryNumber,
            TaxpayerSIdentificationNumber = createDto.TaxpayerSIdentificationNumber,
            TaxpayersCommercialRegistryNumber = createDto.TaxpayersCommercialRegistryNumber,
            TaxpayersIdentificationNumber = createDto.TaxpayersIdentificationNumber,
            TotalGrossWeight = createDto.TotalGrossWeight,
            TotalNetWeight = createDto.TotalNetWeight,
            TotalNumberOfPackages = createDto.TotalNumberOfPackages,
            TransactionConditionCode_1 = createDto.TransactionConditionCode_1,
            TransactionConditionCode_2 = createDto.TransactionConditionCode_2,
            TransactionCountryCode = createDto.TransactionCountryCode,
            TravelerProcessingText = createDto.TravelerProcessingText,
            TravelerReferenceNumber = createDto.TravelerReferenceNumber,
            UnloadingDate = createDto.UnloadingDate,
            UnloadingLocationCode = createDto.UnloadingLocationCode,
            UpdatedAt = createDto.UpdatedAt,
            ValueDeclarationOn = createDto.ValueDeclarationOn,
            VehiclePickupOn = createDto.VehiclePickupOn
        };

        if (createDto.Id != null) commonDetailedDeclaration.Id = createDto.Id;

        _context.CommonDetailedDeclarations.Add(commonDetailedDeclaration);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<CommonDetailedDeclarationDbModel>(
            commonDetailedDeclaration.Id
        );

        if (result == null) throw new NotFoundException();

        return result.ToDto();
    }

    /// <summary>
    ///     Delete one COMMON DETAILED DECLARATION
    /// </summary>
    public async Task DeleteCommonDetailedDeclaration(
        CommonDetailedDeclarationWhereUniqueInput uniqueId
    )
    {
        var commonDetailedDeclaration = await _context.CommonDetailedDeclarations.FindAsync(
            uniqueId.Id
        );
        if (commonDetailedDeclaration == null) throw new NotFoundException();

        _context.CommonDetailedDeclarations.Remove(commonDetailedDeclaration);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    ///     Find many COMMON DETAILED DECLARATIONS
    /// </summary>
    public async Task<List<CommonDetailedDeclaration>> CommonDetailedDeclarations(
        CommonDetailedDeclarationFindManyArgs findManyArgs
    )
    {
        var commonDetailedDeclarations = await _context
            .CommonDetailedDeclarations.ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return commonDetailedDeclarations.ConvertAll(commonDetailedDeclaration =>
            commonDetailedDeclaration.ToDto()
        );
    }

    /// <summary>
    ///     Meta data about COMMON DETAILED DECLARATION records
    /// </summary>
    public async Task<MetadataDto> CommonDetailedDeclarationsMeta(
        CommonDetailedDeclarationFindManyArgs findManyArgs
    )
    {
        var count = await _context
            .CommonDetailedDeclarations.ApplyWhere(findManyArgs.Where)
            .CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    ///     Get one COMMON DETAILED DECLARATION
    /// </summary>
    public async Task<CommonDetailedDeclaration> CommonDetailedDeclaration(
        CommonDetailedDeclarationWhereUniqueInput uniqueId
    )
    {
        var commonDetailedDeclarations = await CommonDetailedDeclarations(
            new CommonDetailedDeclarationFindManyArgs
            {
                Where = new CommonDetailedDeclarationWhereInput { Id = uniqueId.Id }
            }
        );
        var commonDetailedDeclaration = commonDetailedDeclarations.FirstOrDefault();
        if (commonDetailedDeclaration == null) throw new NotFoundException();

        return commonDetailedDeclaration;
    }

    /// <summary>
    ///     Update one COMMON DETAILED DECLARATION
    /// </summary>
    public async Task UpdateCommonDetailedDeclaration(
        CommonDetailedDeclarationWhereUniqueInput uniqueId,
        CommonDetailedDeclarationUpdateInput updateDto
    )
    {
        var commonDetailedDeclaration = updateDto.ToModel(uniqueId);

        _context.Entry(commonDetailedDeclaration).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!_context.CommonDetailedDeclarations.Any(e => e.Id == commonDetailedDeclaration.Id))
                throw new NotFoundException();
            throw;
        }
    }
}
