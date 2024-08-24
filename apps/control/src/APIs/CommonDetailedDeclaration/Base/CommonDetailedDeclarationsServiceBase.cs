using Control.APIs;
using Control.Infrastructure;
using Control.APIs.Dtos;
using Control.Infrastructure.Models;
using Control.APIs.Errors;
using Control.APIs.Extensions;
using Control.APIs.Common;
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
    /// Create one Common Detailed Declaration
    /// </summary>
    public async Task<CommonDetailedDeclaration> CreateCommonDetailedDeclaration(CommonDetailedDeclarationCreateInput createDto)
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
            ManagementAndMonitoringClearancePeriod = createDto.ManagementAndMonitoringClearancePeriod,
            MeansOfTransportIdentificationNumber = createDto.MeansOfTransportIdentificationNumber,
            MeansOfTransportIdentificationNumberTypeCode = createDto.MeansOfTransportIdentificationNumberTypeCode,
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

        if (createDto.Id != null)
        {
            commonDetailedDeclaration.Id = createDto.Id;
        }
        if (createDto.Articles != null)
        {
            commonDetailedDeclaration.Articles = await _context
                .Articles.Where(article => createDto.Articles.Select(t => t.Id).Contains(article.Id))
                .ToListAsync();
        }

        if (createDto.ArticlesExpectedForReImportExport != null)
        {
            commonDetailedDeclaration.ArticlesExpectedForReImportExport = await _context
                .ExpectedReimportReexportArticles.Where(expectedReimportReexportArticle => createDto.ArticlesExpectedForReImportExport.Select(t => t.Id).Contains(expectedReimportReexportArticle.Id))
                .ToListAsync();
        }

        if (createDto.Assessment != null)
        {
            commonDetailedDeclaration.Assessment = await _context
                .ValueAssessments.Where(valueAssessment => createDto.Assessment.Id == valueAssessment.Id)
                .FirstOrDefaultAsync();
        }

        if (createDto.Changes != null)
        {
            commonDetailedDeclaration.Changes = await _context
                .ChangeInTheDetailedDeclarations.Where(changeInTheDetailedDeclaration => createDto.Changes.Select(t => t.Id).Contains(changeInTheDetailedDeclaration.Id))
                .ToListAsync();
        }

        if (createDto.Container != null)
        {
            commonDetailedDeclaration.Container = await _context
                .ContainerOfTheDetailedDeclarationCustomsItems.Where(containerOfTheDetailedDeclarationCustoms => createDto.Container.Id == containerOfTheDetailedDeclarationCustoms.Id)
                .FirstOrDefaultAsync();
        }

        if (createDto.Document != null)
        {
            commonDetailedDeclaration.Document = await _context
                .JointDocuments.Where(jointDocument => createDto.Document.Id == jointDocument.Id)
                .FirstOrDefaultAsync();
        }

        if (createDto.Operator != null)
        {
            commonDetailedDeclaration.Operator = await _context
                .Operators.Where(operator => createDto.Operator.Id == operator.Id)
                .FirstOrDefaultAsync();
        }

        if (createDto.ValueDeclaration != null)
        {
            commonDetailedDeclaration.ValueDeclaration = await _context
                .ValueDeclarations.Where(valueDeclaration => createDto.ValueDeclaration.Id == valueDeclaration.Id)
                .FirstOrDefaultAsync();
        }

        _context.CommonDetailedDeclarations.Add(commonDetailedDeclaration);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<CommonDetailedDeclarationDbModel>(commonDetailedDeclaration.Id);

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one Common Detailed Declaration
    /// </summary>
    public async Task DeleteCommonDetailedDeclaration(CommonDetailedDeclarationWhereUniqueInput uniqueId)
    {
        var commonDetailedDeclaration = await _context.CommonDetailedDeclarations.FindAsync(uniqueId.Id);
        if (commonDetailedDeclaration == null)
        {
            throw new NotFoundException();
        }

        _context.CommonDetailedDeclarations.Remove(commonDetailedDeclaration);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many COMMON DETAILED DECLARATIONS
    /// </summary>
    public async Task<List<CommonDetailedDeclaration>> CommonDetailedDeclarations(CommonDetailedDeclarationFindManyArgs findManyArgs)
    {
        var commonDetailedDeclarations = await _context
              .CommonDetailedDeclarations
      .Include(x => x.Articles).Include(x => x.Operator).Include(x => x.ValueDeclaration).Include(x => x.ArticlesExpectedForReImportExport).Include(x => x.Container).Include(x => x.Document).Include(x => x.Assessment).Include(x => x.Changes)
      .ApplyWhere(findManyArgs.Where)
      .ApplySkip(findManyArgs.Skip)
      .ApplyTake(findManyArgs.Take)
      .ApplyOrderBy(findManyArgs.SortBy)
      .ToListAsync();
        return commonDetailedDeclarations.ConvertAll(commonDetailedDeclaration => commonDetailedDeclaration.ToDto());
    }

    /// <summary>
    /// Meta data about Common Detailed Declaration records
    /// </summary>
    public async Task<MetadataDto> CommonDetailedDeclarationsMeta(CommonDetailedDeclarationFindManyArgs findManyArgs)
    {

        var count = await _context
    .CommonDetailedDeclarations
    .ApplyWhere(findManyArgs.Where)
    .CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one Common Detailed Declaration
    /// </summary>
    public async Task<CommonDetailedDeclaration> CommonDetailedDeclaration(CommonDetailedDeclarationWhereUniqueInput uniqueId)
    {
        var commonDetailedDeclarations = await this.CommonDetailedDeclarations(
                  new CommonDetailedDeclarationFindManyArgs { Where = new CommonDetailedDeclarationWhereInput { Id = uniqueId.Id } }
      );
        var commonDetailedDeclaration = commonDetailedDeclarations.FirstOrDefault();
        if (commonDetailedDeclaration == null)
        {
            throw new NotFoundException();
        }

        return commonDetailedDeclaration;
    }

    /// <summary>
    /// Update one Common Detailed Declaration
    /// </summary>
    public async Task UpdateCommonDetailedDeclaration(CommonDetailedDeclarationWhereUniqueInput uniqueId, CommonDetailedDeclarationUpdateInput updateDto)
    {
        var commonDetailedDeclaration = updateDto.ToModel(uniqueId);

        if (updateDto.Articles != null)
        {
            commonDetailedDeclaration.Articles = await _context
                .Articles.Where(article => updateDto.Articles.Select(t => t).Contains(article.Id))
                .ToListAsync();
        }

        if (updateDto.ArticlesExpectedForReImportExport != null)
        {
            commonDetailedDeclaration.ArticlesExpectedForReImportExport = await _context
                .ExpectedReimportReexportArticles.Where(expectedReimportReexportArticle => updateDto.ArticlesExpectedForReImportExport.Select(t => t).Contains(expectedReimportReexportArticle.Id))
                .ToListAsync();
        }

        if (updateDto.Changes != null)
        {
            commonDetailedDeclaration.Changes = await _context
                .ChangeInTheDetailedDeclarations.Where(changeInTheDetailedDeclaration => updateDto.Changes.Select(t => t).Contains(changeInTheDetailedDeclaration.Id))
                .ToListAsync();
        }

        _context.Entry(commonDetailedDeclaration).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!_context.CommonDetailedDeclarations.Any(e => e.Id == commonDetailedDeclaration.Id))
            {
                throw new NotFoundException();
            }
            else
            {
                throw;
            }
        }
    }

    /// <summary>
    /// Connect multiple Articles Expected for Re Import/Export records to COMMON DETAILED DECLARATION
    /// </summary>
    public async Task ConnectArticlesExpectedForReImportExport(CommonDetailedDeclarationWhereUniqueInput uniqueId, ExpectedReimportReexportArticleWhereUniqueInput[] expectedReimportReexportArticlesId)
    {
        var parent = await _context
              .CommonDetailedDeclarations.Include(x => x.ArticlesExpectedForReImportExport)
      .FirstOrDefaultAsync(x => x.Id == uniqueId.Id);
        if (parent == null)
        {
            throw new NotFoundException();
        }

        var expectedReimportReexportArticles = await _context
          .ExpectedReimportReexportArticles.Where(t => expectedReimportReexportArticlesId.Select(x => x.Id).Contains(t.Id))
          .ToListAsync();
        if (expectedReimportReexportArticles.Count == 0)
        {
            throw new NotFoundException();
        }

        var expectedReimportReexportArticlesToConnect = expectedReimportReexportArticles.Except(parent.ArticlesExpectedForReImportExport);

        foreach (var expectedReimportReexportArticle in expectedReimportReexportArticlesToConnect)
        {
            parent.ArticlesExpectedForReImportExport.Add(expectedReimportReexportArticle);
        }

        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Disconnect multiple Articles Expected for Re Import/Export records from COMMON DETAILED DECLARATION
    /// </summary>
    public async Task DisconnectArticlesExpectedForReImportExport(CommonDetailedDeclarationWhereUniqueInput uniqueId, ExpectedReimportReexportArticleWhereUniqueInput[] expectedReimportReexportArticlesId)
    {
        var parent = await _context
                                .CommonDetailedDeclarations.Include(x => x.ArticlesExpectedForReImportExport)
                        .FirstOrDefaultAsync(x => x.Id == uniqueId.Id);
        if (parent == null)
        {
            throw new NotFoundException();
        }

        var expectedReimportReexportArticles = await _context
          .ExpectedReimportReexportArticles.Where(t => expectedReimportReexportArticlesId.Select(x => x.Id).Contains(t.Id))
          .ToListAsync();

        foreach (var expectedReimportReexportArticle in expectedReimportReexportArticles)
        {
            parent.ArticlesExpectedForReImportExport?.Remove(expectedReimportReexportArticle);
        }
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find multiple Articles Expected for Re Import/Export records for COMMON DETAILED DECLARATION
    /// </summary>
    public async Task<List<ExpectedReimportReexportArticle>> FindArticlesExpectedForReImportExport(CommonDetailedDeclarationWhereUniqueInput uniqueId, ExpectedReimportReexportArticleFindManyArgs commonDetailedDeclarationFindManyArgs)
    {
        var expectedReimportReexportArticles = await _context
              .ExpectedReimportReexportArticles
      .Where(m => m.CommonDetailedDeclarationsId == uniqueId.Id)
      .ApplyWhere(commonDetailedDeclarationFindManyArgs.Where)
      .ApplySkip(commonDetailedDeclarationFindManyArgs.Skip)
      .ApplyTake(commonDetailedDeclarationFindManyArgs.Take)
      .ApplyOrderBy(commonDetailedDeclarationFindManyArgs.SortBy)
      .ToListAsync();

        return expectedReimportReexportArticles.Select(x => x.ToDto()).ToList();
    }

    /// <summary>
    /// Update multiple Articles Expected for Re Import/Export records for COMMON DETAILED DECLARATION
    /// </summary>
    public async Task UpdateArticlesExpectedForReImportExport(CommonDetailedDeclarationWhereUniqueInput uniqueId, ExpectedReimportReexportArticleWhereUniqueInput[] expectedReimportReexportArticlesId)
    {
        var commonDetailedDeclaration = await _context
                .CommonDetailedDeclarations.Include(t => t.ArticlesExpectedForReImportExport)
        .FirstOrDefaultAsync(x => x.Id == uniqueId.Id);
        if (commonDetailedDeclaration == null)
        {
            throw new NotFoundException();
        }

        var expectedReimportReexportArticles = await _context
          .ExpectedReimportReexportArticles.Where(a => expectedReimportReexportArticlesId.Select(x => x.Id).Contains(a.Id))
          .ToListAsync();

        if (expectedReimportReexportArticles.Count == 0)
        {
            throw new NotFoundException();
        }

        commonDetailedDeclaration.ArticlesExpectedForReImportExport = expectedReimportReexportArticles;
        await _context.SaveChangesAsync();
    }

}
