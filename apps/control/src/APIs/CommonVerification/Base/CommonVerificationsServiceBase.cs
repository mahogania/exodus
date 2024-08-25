using Control.APIs;
using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Control.APIs.Extensions;
using Control.Infrastructure;
using Control.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Control.APIs;

public abstract class CommonVerificationsServiceBase : ICommonVerificationsService
{
    protected readonly ControlDbContext _context;

    public CommonVerificationsServiceBase(ControlDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one Common Verification
    /// </summary>
    public async Task<CommonVerification> CreateCommonVerification(
        CommonVerificationCreateInput createDto
    )
    {
        var commonVerification = new CommonVerificationDbModel
        {
            AdditionalFeesAmountDeclared = createDto.AdditionalFeesAmountDeclared,
            AdditionalFeesAmountFinal = createDto.AdditionalFeesAmountFinal,
            AdditionalFeesAmountInNcyDeclared = createDto.AdditionalFeesAmountInNcyDeclared,
            AdditionalFeesAmountInNcyFinal = createDto.AdditionalFeesAmountInNcyFinal,
            AdditionalFeesCurrencyCodeDeclared = createDto.AdditionalFeesCurrencyCodeDeclared,
            AdditionalFeesCurrencyCodeFinal = createDto.AdditionalFeesCurrencyCodeFinal,
            AdditionalFeesExchangeRateDeclared = createDto.AdditionalFeesExchangeRateDeclared,
            AdditionalFeesExchangeRateFinal = createDto.AdditionalFeesExchangeRateFinal,
            AdditionalLiquidCommissions = createDto.AdditionalLiquidCommissions,
            AdditionalPayableFeesDeclared = createDto.AdditionalPayableFeesDeclared,
            CreatedAt = createDto.CreatedAt,
            DateAndTimeOfFinalModification = createDto.DateAndTimeOfFinalModification,
            DateAndTimeOfInitialRecord = createDto.DateAndTimeOfInitialRecord,
            DeductedAmountDeclared = createDto.DeductedAmountDeclared,
            DeductedAmountFinal = createDto.DeductedAmountFinal,
            DeductedAmountInCnyFinal = createDto.DeductedAmountInCnyFinal,
            DeductedAmountInNcyDeclared = createDto.DeductedAmountInNcyDeclared,
            DeductedCurrencyCodeDeclared = createDto.DeductedCurrencyCodeDeclared,
            DeductedCurrencyCodeFinal = createDto.DeductedCurrencyCodeFinal,
            DeductionExchangeRateDeclared = createDto.DeductionExchangeRateDeclared,
            DeductionExchangeRateFinal = createDto.DeductionExchangeRateFinal,
            DeletedOn = createDto.DeletedOn,
            EpcCodeDeclared = createDto.EpcCodeDeclared,
            EpcCodeFinal = createDto.EpcCodeFinal,
            FinalModifierId = createDto.FinalModifierId,
            FinalOn = createDto.FinalOn,
            FreightAmountDeclared = createDto.FreightAmountDeclared,
            FreightAmountFinal = createDto.FreightAmountFinal,
            FreightAmountInNcyDeclared = createDto.FreightAmountInNcyDeclared,
            FreightAmountInNcyFinal = createDto.FreightAmountInNcyFinal,
            FreightCurrencyCodeDeclared = createDto.FreightCurrencyCodeDeclared,
            FreightCurrencyCodeFinal = createDto.FreightCurrencyCodeFinal,
            FreightExchangeRateDeclared = createDto.FreightExchangeRateDeclared,
            FreightExchangeRateFinal = createDto.FreightExchangeRateFinal,
            ImporterIdentificationNumberDeclared = createDto.ImporterIdentificationNumberDeclared,
            ImporterIdentificationNumberFinal = createDto.ImporterIdentificationNumberFinal,
            ImporterIdentificationTypeCodeDeclared =
                createDto.ImporterIdentificationTypeCodeDeclared,
            ImporterIdentificationTypeCodeFinal = createDto.ImporterIdentificationTypeCodeFinal,
            InitialRecorderId = createDto.InitialRecorderId,
            InsuranceAmountDeclared = createDto.InsuranceAmountDeclared,
            InsuranceAmountFinal = createDto.InsuranceAmountFinal,
            InsuranceAmountInNcyDeclared = createDto.InsuranceAmountInNcyDeclared,
            InsuranceAmountInNcyFinal = createDto.InsuranceAmountInNcyFinal,
            InsuranceCurrencyCodeDeclared = createDto.InsuranceCurrencyCodeDeclared,
            InsuranceCurrencyCodeFinal = createDto.InsuranceCurrencyCodeFinal,
            InsuranceExchangeRateDeclared = createDto.InsuranceExchangeRateDeclared,
            InsuranceExchangeRateFinal = createDto.InsuranceExchangeRateFinal,
            InvalidSecurityAmountDeclared = createDto.InvalidSecurityAmountDeclared,
            InvalidSecurityAmountFinal = createDto.InvalidSecurityAmountFinal,
            InvoiceAmountDeclared = createDto.InvoiceAmountDeclared,
            InvoiceAmountFinal = createDto.InvoiceAmountFinal,
            InvoiceAmountInNcyDeclared = createDto.InvoiceAmountInNcyDeclared,
            InvoiceAmountInNcyFinal = createDto.InvoiceAmountInNcyFinal,
            InvoiceAmountInUsdFinal = createDto.InvoiceAmountInUsdFinal,
            InvoiceCurrencyCodeDeclared = createDto.InvoiceCurrencyCodeDeclared,
            InvoiceCurrencyCodeFinal = createDto.InvoiceCurrencyCodeFinal,
            InvoiceExchangeRateDeclared = createDto.InvoiceExchangeRateDeclared,
            InvoiceExchangeRateFinal = createDto.InvoiceExchangeRateFinal,
            NiuFinal = createDto.NiuFinal,
            ReducedValidSecurityAmountDeclared = createDto.ReducedValidSecurityAmountDeclared,
            ReducedValidSecurityAmountFinal = createDto.ReducedValidSecurityAmountFinal,
            ResultOfVerificationOfDetailedDeclaration =
                createDto.ResultOfVerificationOfDetailedDeclaration,
            TaxpayerIdentificationNumberDeclared = createDto.TaxpayerIdentificationNumberDeclared,
            TotalDeclaredTaxes = createDto.TotalDeclaredTaxes,
            TotalFinalTaxes = createDto.TotalFinalTaxes,
            TotalPaidTaxesDeclared = createDto.TotalPaidTaxesDeclared,
            TotalPaidTaxesFinal = createDto.TotalPaidTaxesFinal,
            TotalTaxableAmountInNcyDeclared = createDto.TotalTaxableAmountInNcyDeclared,
            TotalTaxableAmountInNcyFinal = createDto.TotalTaxableAmountInNcyFinal,
            TotalTaxableAmountInUsdDeclared = createDto.TotalTaxableAmountInUsdDeclared,
            TotalTaxableAmountInUsdFinal = createDto.TotalTaxableAmountInUsdFinal,
            UpdatedAt = createDto.UpdatedAt,
            ValidSecurityAmountDeclared = createDto.ValidSecurityAmountDeclared,
            ValidSecurityAmountFinal = createDto.ValidSecurityAmountFinal,
            ValueEvaluationStatusCode = createDto.ValueEvaluationStatusCode
        };

        if (createDto.Id != null)
        {
            commonVerification.Id = createDto.Id;
        }
        if (createDto.Appeal != null)
        {
            commonVerification.Appeal = await _context
                .Appeals.Where(appeal => createDto.Appeal.Id == appeal.Id)
                .FirstOrDefaultAsync();
        }

        if (createDto.ArticlesSubmittedForVerification != null)
        {
            commonVerification.ArticlesSubmittedForVerification = await _context
                .ArticlesSubmittedForVerifications.Where(articlesSubmittedForVerification =>
                    createDto.ArticlesSubmittedForVerification.Id
                    == articlesSubmittedForVerification.Id
                )
                .FirstOrDefaultAsync();
        }

        if (createDto.ContainerValueAssessments != null)
        {
            commonVerification.ContainerValueAssessments = await _context
                .ContainerValueAssessments.Where(containerValueAssessment =>
                    createDto
                        .ContainerValueAssessments.Select(t => t.Id)
                        .Contains(containerValueAssessment.Id)
                )
                .ToListAsync();
        }

        if (createDto.TaxesForVerification != null)
        {
            commonVerification.TaxesForVerification = await _context
                .TaxForVerifications.Where(taxForVerification =>
                    createDto.TaxesForVerification.Select(t => t.Id).Contains(taxForVerification.Id)
                )
                .ToListAsync();
        }

        if (createDto.VerificationResult != null)
        {
            commonVerification.VerificationResult = await _context
                .VerificationResults.Where(verificationResult =>
                    createDto.VerificationResult.Id == verificationResult.Id
                )
                .FirstOrDefaultAsync();
        }

        _context.CommonVerifications.Add(commonVerification);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<CommonVerificationDbModel>(commonVerification.Id);

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one Common Verification
    /// </summary>
    public async Task DeleteCommonVerification(CommonVerificationWhereUniqueInput uniqueId)
    {
        var commonVerification = await _context.CommonVerifications.FindAsync(uniqueId.Id);
        if (commonVerification == null)
        {
            throw new NotFoundException();
        }

        _context.CommonVerifications.Remove(commonVerification);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many Common Verification Of The Evaluation Of Values Of The Detailed Declarations
    /// </summary>
    public async Task<List<CommonVerification>> CommonVerifications(
        CommonVerificationFindManyArgs findManyArgs
    )
    {
        var commonVerifications = await _context
            .CommonVerifications.Include(x => x.Appeal)
            .Include(x => x.ArticlesSubmittedForVerification)
            .Include(x => x.TaxesForVerification)
            .Include(x => x.VerificationResult)
            .Include(x => x.ContainerValueAssessments)
            .ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return commonVerifications.ConvertAll(commonVerification => commonVerification.ToDto());
    }

    /// <summary>
    /// Meta data about Common Verification records
    /// </summary>
    public async Task<MetadataDto> CommonVerificationsMeta(
        CommonVerificationFindManyArgs findManyArgs
    )
    {
        var count = await _context.CommonVerifications.ApplyWhere(findManyArgs.Where).CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one Common Verification
    /// </summary>
    public async Task<CommonVerification> CommonVerification(
        CommonVerificationWhereUniqueInput uniqueId
    )
    {
        var commonVerifications = await this.CommonVerifications(
            new CommonVerificationFindManyArgs
            {
                Where = new CommonVerificationWhereInput { Id = uniqueId.Id }
            }
        );
        var commonVerification = commonVerifications.FirstOrDefault();
        if (commonVerification == null)
        {
            throw new NotFoundException();
        }

        return commonVerification;
    }

    /// <summary>
    /// Update one Common Verification
    /// </summary>
    public async Task UpdateCommonVerification(
        CommonVerificationWhereUniqueInput uniqueId,
        CommonVerificationUpdateInput updateDto
    )
    {
        var commonVerification = updateDto.ToModel(uniqueId);

        if (updateDto.TaxesForVerification != null)
        {
            commonVerification.TaxesForVerification = await _context
                .TaxForVerifications.Where(taxForVerification =>
                    updateDto.TaxesForVerification.Select(t => t).Contains(taxForVerification.Id)
                )
                .ToListAsync();
        }

        if (updateDto.ContainerValueAssessments != null)
        {
            commonVerification.ContainerValueAssessments = await _context
                .ContainerValueAssessments.Where(containerValueAssessment =>
                    updateDto
                        .ContainerValueAssessments.Select(t => t)
                        .Contains(containerValueAssessment.Id)
                )
                .ToListAsync();
        }

        _context.Entry(commonVerification).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!_context.CommonVerifications.Any(e => e.Id == commonVerification.Id))
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
    /// Get a Appeal record for Common Verification
    /// </summary>
    public async Task<Appeal> GetAppeal(CommonVerificationWhereUniqueInput uniqueId)
    {
        var commonVerification = await _context
            .CommonVerifications.Where(commonVerification => commonVerification.Id == uniqueId.Id)
            .Include(commonVerification => commonVerification.Appeal)
            .FirstOrDefaultAsync();
        if (commonVerification == null)
        {
            throw new NotFoundException();
        }
        return commonVerification.Appeal.ToDto();
    }

    /// <summary>
    /// Get a Articles Submitted For Verification record for Common Verification
    /// </summary>
    public async Task<ArticlesSubmittedForVerification> GetArticlesSubmittedForVerification(
        CommonVerificationWhereUniqueInput uniqueId
    )
    {
        var commonVerification = await _context
            .CommonVerifications.Where(commonVerification => commonVerification.Id == uniqueId.Id)
            .Include(commonVerification => commonVerification.ArticlesSubmittedForVerification)
            .FirstOrDefaultAsync();
        if (commonVerification == null)
        {
            throw new NotFoundException();
        }
        return commonVerification.ArticlesSubmittedForVerification.ToDto();
    }

    /// <summary>
    /// Connect multiple Container Value Assessments records to Common Verification
    /// </summary>
    public async Task ConnectContainerValueAssessments(
        CommonVerificationWhereUniqueInput uniqueId,
        ContainerValueAssessmentWhereUniqueInput[] containerValueAssessmentsId
    )
    {
        var parent = await _context
            .CommonVerifications.Include(x => x.ContainerValueAssessments)
            .FirstOrDefaultAsync(x => x.Id == uniqueId.Id);
        if (parent == null)
        {
            throw new NotFoundException();
        }

        var containerValueAssessments = await _context
            .ContainerValueAssessments.Where(t =>
                containerValueAssessmentsId.Select(x => x.Id).Contains(t.Id)
            )
            .ToListAsync();
        if (containerValueAssessments.Count == 0)
        {
            throw new NotFoundException();
        }

        var containerValueAssessmentsToConnect = containerValueAssessments.Except(
            parent.ContainerValueAssessments
        );

        foreach (var containerValueAssessment in containerValueAssessmentsToConnect)
        {
            parent.ContainerValueAssessments.Add(containerValueAssessment);
        }

        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Disconnect multiple Container Value Assessments records from Common Verification
    /// </summary>
    public async Task DisconnectContainerValueAssessments(
        CommonVerificationWhereUniqueInput uniqueId,
        ContainerValueAssessmentWhereUniqueInput[] containerValueAssessmentsId
    )
    {
        var parent = await _context
            .CommonVerifications.Include(x => x.ContainerValueAssessments)
            .FirstOrDefaultAsync(x => x.Id == uniqueId.Id);
        if (parent == null)
        {
            throw new NotFoundException();
        }

        var containerValueAssessments = await _context
            .ContainerValueAssessments.Where(t =>
                containerValueAssessmentsId.Select(x => x.Id).Contains(t.Id)
            )
            .ToListAsync();

        foreach (var containerValueAssessment in containerValueAssessments)
        {
            parent.ContainerValueAssessments?.Remove(containerValueAssessment);
        }
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find multiple Container Value Assessments records for Common Verification
    /// </summary>
    public async Task<List<ContainerValueAssessment>> FindContainerValueAssessments(
        CommonVerificationWhereUniqueInput uniqueId,
        ContainerValueAssessmentFindManyArgs commonVerificationFindManyArgs
    )
    {
        var containerValueAssessments = await _context
            .ContainerValueAssessments.Where(m => m.CommonVerificationId == uniqueId.Id)
            .ApplyWhere(commonVerificationFindManyArgs.Where)
            .ApplySkip(commonVerificationFindManyArgs.Skip)
            .ApplyTake(commonVerificationFindManyArgs.Take)
            .ApplyOrderBy(commonVerificationFindManyArgs.SortBy)
            .ToListAsync();

        return containerValueAssessments.Select(x => x.ToDto()).ToList();
    }

    /// <summary>
    /// Update multiple Container Value Assessments records for Common Verification
    /// </summary>
    public async Task UpdateContainerValueAssessments(
        CommonVerificationWhereUniqueInput uniqueId,
        ContainerValueAssessmentWhereUniqueInput[] containerValueAssessmentsId
    )
    {
        var commonVerification = await _context
            .CommonVerifications.Include(t => t.ContainerValueAssessments)
            .FirstOrDefaultAsync(x => x.Id == uniqueId.Id);
        if (commonVerification == null)
        {
            throw new NotFoundException();
        }

        var containerValueAssessments = await _context
            .ContainerValueAssessments.Where(a =>
                containerValueAssessmentsId.Select(x => x.Id).Contains(a.Id)
            )
            .ToListAsync();

        if (containerValueAssessments.Count == 0)
        {
            throw new NotFoundException();
        }

        commonVerification.ContainerValueAssessments = containerValueAssessments;
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Connect multiple Taxes For Verification records to Common Verification
    /// </summary>
    public async Task ConnectTaxesForVerification(
        CommonVerificationWhereUniqueInput uniqueId,
        TaxForVerificationWhereUniqueInput[] taxForVerificationsId
    )
    {
        var parent = await _context
            .CommonVerifications.Include(x => x.TaxesForVerification)
            .FirstOrDefaultAsync(x => x.Id == uniqueId.Id);
        if (parent == null)
        {
            throw new NotFoundException();
        }

        var taxForVerifications = await _context
            .TaxForVerifications.Where(t => taxForVerificationsId.Select(x => x.Id).Contains(t.Id))
            .ToListAsync();
        if (taxForVerifications.Count == 0)
        {
            throw new NotFoundException();
        }

        var taxForVerificationsToConnect = taxForVerifications.Except(parent.TaxesForVerification);

        foreach (var taxForVerification in taxForVerificationsToConnect)
        {
            parent.TaxesForVerification.Add(taxForVerification);
        }

        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Disconnect multiple Taxes For Verification records from Common Verification
    /// </summary>
    public async Task DisconnectTaxesForVerification(
        CommonVerificationWhereUniqueInput uniqueId,
        TaxForVerificationWhereUniqueInput[] taxForVerificationsId
    )
    {
        var parent = await _context
            .CommonVerifications.Include(x => x.TaxesForVerification)
            .FirstOrDefaultAsync(x => x.Id == uniqueId.Id);
        if (parent == null)
        {
            throw new NotFoundException();
        }

        var taxForVerifications = await _context
            .TaxesForVerification.Where(t => taxForVerificationsId.Select(x => x.Id).Contains(t.Id))
            .ToListAsync();

        foreach (var taxForVerification in taxForVerifications)
        {
            parent.TaxesForVerification?.Remove(taxForVerification);
        }
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find multiple Taxes For Verification records for Common Verification
    /// </summary>
    public async Task<List<TaxForVerification>> FindTaxesForVerification(
        CommonVerificationWhereUniqueInput uniqueId,
        TaxForVerificationFindManyArgs commonVerificationFindManyArgs
    )
    {
        var taxForVerifications = await _context
            .TaxForVerifications.Where(m => m.CommonVerificationsId == uniqueId.Id)
            .ApplyWhere(commonVerificationFindManyArgs.Where)
            .ApplySkip(commonVerificationFindManyArgs.Skip)
            .ApplyTake(commonVerificationFindManyArgs.Take)
            .ApplyOrderBy(commonVerificationFindManyArgs.SortBy)
            .ToListAsync();

        return taxForVerifications.Select(x => x.ToDto()).ToList();
    }

    /// <summary>
    /// Update multiple Taxes For Verification records for Common Verification
    /// </summary>
    public async Task UpdateTaxesForVerification(
        CommonVerificationWhereUniqueInput uniqueId,
        TaxForVerificationWhereUniqueInput[] taxForVerificationsId
    )
    {
        var commonVerification = await _context
            .CommonVerifications.Include(t => t.TaxesForVerification)
            .FirstOrDefaultAsync(x => x.Id == uniqueId.Id);
        if (commonVerification == null)
        {
            throw new NotFoundException();
        }

        var taxForVerifications = await _context
            .TaxForVerifications.Where(a => taxForVerificationsId.Select(x => x.Id).Contains(a.Id))
            .ToListAsync();

        if (taxForVerifications.Count == 0)
        {
            throw new NotFoundException();
        }

        commonVerification.TaxesForVerification = taxForVerifications;
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Get a Verification Result record for Common Verification
    /// </summary>
    public async Task<VerificationResult> GetVerificationResult(
        CommonVerificationWhereUniqueInput uniqueId
    )
    {
        var commonVerification = await _context
            .CommonVerifications.Where(commonVerification => commonVerification.Id == uniqueId.Id)
            .Include(commonVerification => commonVerification.VerificationResult)
            .FirstOrDefaultAsync();
        if (commonVerification == null)
        {
            throw new NotFoundException();
        }
        return commonVerification.VerificationResult.ToDto();
    }
}
