using Control.APIs;
using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Control.APIs.Extensions;
using Control.Infrastructure;
using Control.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Control.APIs;

public abstract class ArticlesSubmittedForVerificationsServiceBase
    : IArticlesSubmittedForVerificationsService
{
    protected readonly ControlDbContext _context;

    public ArticlesSubmittedForVerificationsServiceBase(ControlDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one Articles Submitted For Verification
    /// </summary>
    public async Task<ArticlesSubmittedForVerification> CreateArticlesSubmittedForVerification(
        ArticlesSubmittedForVerificationCreateInput createDto
    )
    {
        var articlesSubmittedForVerification = new ArticlesSubmittedForVerificationDbModel
        {
            ArticleNumber = createDto.ArticleNumber,
            CreatedAt = createDto.CreatedAt,
            DateAndTimeOfFinalModification = createDto.DateAndTimeOfFinalModification,
            DateAndTimeOfInitialRecord = createDto.DateAndTimeOfInitialRecord,
            DeclaredAdditionalFeesAmountInNcyOfTheArticle =
                createDto.DeclaredAdditionalFeesAmountInNcyOfTheArticle,
            DeclaredAdditionalFeesAmountOfTheArticle =
                createDto.DeclaredAdditionalFeesAmountOfTheArticle,
            DeclaredAdditionalFeesCurrencyCodeOfTheArticle =
                createDto.DeclaredAdditionalFeesCurrencyCodeOfTheArticle,
            DeclaredAdditionalFeesExchangeRateOfTheArticle =
                createDto.DeclaredAdditionalFeesExchangeRateOfTheArticle,
            DeclaredApcCode = createDto.DeclaredApcCode,
            DeclaredCountryOfOriginCode = createDto.DeclaredCountryOfOriginCode,
            DeclaredDeductedAmountInNcyOfTheArticle =
                createDto.DeclaredDeductedAmountInNcyOfTheArticle,
            DeclaredDeductedAmountOfTheArticle = createDto.DeclaredDeductedAmountOfTheArticle,
            DeclaredDeductedCurrencyCodeOfTheArticle =
                createDto.DeclaredDeductedCurrencyCodeOfTheArticle,
            DeclaredDeductionExchangeRateOfTheArticle =
                createDto.DeclaredDeductionExchangeRateOfTheArticle,
            DeclaredEvaluationMethodCode = createDto.DeclaredEvaluationMethodCode,
            DeclaredFreightAmountInNcyOfTheArticle =
                createDto.DeclaredFreightAmountInNcyOfTheArticle,
            DeclaredFreightAmountOfTheArticle = createDto.DeclaredFreightAmountOfTheArticle,
            DeclaredFreightCurrencyCodeOfTheArticle =
                createDto.DeclaredFreightCurrencyCodeOfTheArticle,
            DeclaredFreightExchangeRateOfTheArticle =
                createDto.DeclaredFreightExchangeRateOfTheArticle,
            DeclaredGrossWeightOfTheArticle = createDto.DeclaredGrossWeightOfTheArticle,
            DeclaredInsuranceAmountInNcyOfTheArticle =
                createDto.DeclaredInsuranceAmountInNcyOfTheArticle,
            DeclaredInsuranceAmountOfTheArticle = createDto.DeclaredInsuranceAmountOfTheArticle,
            DeclaredInsuranceCurrencyCodeOfTheArticle =
                createDto.DeclaredInsuranceCurrencyCodeOfTheArticle,
            DeclaredInsuranceExchangeRateOfTheArticle =
                createDto.DeclaredInsuranceExchangeRateOfTheArticle,
            DeclaredInvoiceAmountInNcyOfTheArticle =
                createDto.DeclaredInvoiceAmountInNcyOfTheArticle,
            DeclaredInvoiceAmountInUsdOfTheArticle =
                createDto.DeclaredInvoiceAmountInUsdOfTheArticle,
            DeclaredInvoiceAmountOfTheArticle = createDto.DeclaredInvoiceAmountOfTheArticle,
            DeclaredInvoiceCurrencyCodeOfTheArticle =
                createDto.DeclaredInvoiceCurrencyCodeOfTheArticle,
            DeclaredInvoiceExchangeRateOfTheArticle =
                createDto.DeclaredInvoiceExchangeRateOfTheArticle,
            DeclaredNetWeightOfTheArticle = createDto.DeclaredNetWeightOfTheArticle,
            DeclaredPreferentialCode = createDto.DeclaredPreferentialCode,
            DeclaredShCode = createDto.DeclaredShCode,
            DeclaredTaxableBaseAmountInNcyOfTheArticle =
                createDto.DeclaredTaxableBaseAmountInNcyOfTheArticle,
            DeclaredTaxableBaseAmountInUsdOfTheArticle =
                createDto.DeclaredTaxableBaseAmountInUsdOfTheArticle,
            DeletedOn = createDto.DeletedOn,
            FinalModifierId = createDto.FinalModifierId,
            InitialRecorderId = createDto.InitialRecorderId,
            LiquidatedAdditionalFeesAmountInNcyOfTheArticle =
                createDto.LiquidatedAdditionalFeesAmountInNcyOfTheArticle,
            LiquidatedAdditionalFeesAmountOfTheArticle =
                createDto.LiquidatedAdditionalFeesAmountOfTheArticle,
            LiquidatedAdditionalFeesCurrencyCodeOfTheArticle =
                createDto.LiquidatedAdditionalFeesCurrencyCodeOfTheArticle,
            LiquidatedAdditionalFeesExchangeRateOfTheArticle =
                createDto.LiquidatedAdditionalFeesExchangeRateOfTheArticle,
            LiquidatedApcCode = createDto.LiquidatedApcCode,
            LiquidatedCountryOfOriginCode = createDto.LiquidatedCountryOfOriginCode,
            LiquidatedDeductedAmountInNcyOfTheArticle =
                createDto.LiquidatedDeductedAmountInNcyOfTheArticle,
            LiquidatedDeductedAmountOfTheArticle = createDto.LiquidatedDeductedAmountOfTheArticle,
            LiquidatedDeductedCurrencyCodeOfTheArticle =
                createDto.LiquidatedDeductedCurrencyCodeOfTheArticle,
            LiquidatedDeductionExchangeRateOfTheArticle =
                createDto.LiquidatedDeductionExchangeRateOfTheArticle,
            LiquidatedEvaluationMethodCode = createDto.LiquidatedEvaluationMethodCode,
            LiquidatedFreightAmountInNcyOfTheArticle =
                createDto.LiquidatedFreightAmountInNcyOfTheArticle,
            LiquidatedFreightAmountOfTheArticle = createDto.LiquidatedFreightAmountOfTheArticle,
            LiquidatedFreightCurrencyCodeOfTheArticle =
                createDto.LiquidatedFreightCurrencyCodeOfTheArticle,
            LiquidatedFreightExchangeRateOfTheArticle =
                createDto.LiquidatedFreightExchangeRateOfTheArticle,
            LiquidatedInsuranceAmountInNcyOfTheArticle =
                createDto.LiquidatedInsuranceAmountInNcyOfTheArticle,
            LiquidatedInsuranceAmountOfTheArticle = createDto.LiquidatedInsuranceAmountOfTheArticle,
            LiquidatedInsuranceCurrencyCodeOfTheArticle =
                createDto.LiquidatedInsuranceCurrencyCodeOfTheArticle,
            LiquidatedInsuranceExchangeRateOfTheArticle =
                createDto.LiquidatedInsuranceExchangeRateOfTheArticle,
            LiquidatedInvoiceAmountInNcyOfTheArticle =
                createDto.LiquidatedInvoiceAmountInNcyOfTheArticle,
            LiquidatedInvoiceAmountInUsdOfTheArticle =
                createDto.LiquidatedInvoiceAmountInUsdOfTheArticle,
            LiquidatedInvoiceAmountOfTheArticle = createDto.LiquidatedInvoiceAmountOfTheArticle,
            LiquidatedInvoiceCurrencyCodeOfTheArticle =
                createDto.LiquidatedInvoiceCurrencyCodeOfTheArticle,
            LiquidatedInvoiceExchangeRateOfTheArticle =
                createDto.LiquidatedInvoiceExchangeRateOfTheArticle,
            LiquidatedNetWeightOfTheArticle = createDto.LiquidatedNetWeightOfTheArticle,
            LiquidatedPreferentialCode = createDto.LiquidatedPreferentialCode,
            LiquidatedShCode = createDto.LiquidatedShCode,
            LiquidatedTaxableBaseAmountInNcyOfTheArticle =
                createDto.LiquidatedTaxableBaseAmountInNcyOfTheArticle,
            LiquidatedTaxableBaseAmountInUsdOfTheArticle =
                createDto.LiquidatedTaxableBaseAmountInUsdOfTheArticle,
            NumberOfTimesOfValueEvaluation = createDto.NumberOfTimesOfValueEvaluation,
            TotalLiquidatedWeightOfTheArticle = createDto.TotalLiquidatedWeightOfTheArticle,
            UpdatedAt = createDto.UpdatedAt
        };

        if (createDto.Id != null)
        {
            articlesSubmittedForVerification.Id = createDto.Id;
        }
        if (createDto.CommonVerifications != null)
        {
            articlesSubmittedForVerification.CommonVerifications = await _context
                .CommonVerifications.Where(commonVerification =>
                    createDto.CommonVerifications.Select(t => t.Id).Contains(commonVerification.Id)
                )
                .ToListAsync();
        }

        if (createDto.ModelValueEvaluationVerifications != null)
        {
            articlesSubmittedForVerification.ModelValueEvaluationVerifications = await _context
                .ModelValueEvaluationVerifications.Where(modelValueEvaluationVerification =>
                    createDto
                        .ModelValueEvaluationVerifications.Select(t => t.Id)
                        .Contains(modelValueEvaluationVerification.Id)
                )
                .ToListAsync();
        }

        if (createDto.TaxesForVerification != null)
        {
            articlesSubmittedForVerification.TaxesForVerification = await _context
                .TaxForVerifications.Where(taxForVerification =>
                    createDto.TaxesForVerification.Select(t => t.Id).Contains(taxForVerification.Id)
                )
                .ToListAsync();
        }

        _context.ArticlesSubmittedForVerifications.Add(articlesSubmittedForVerification);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<ArticlesSubmittedForVerificationDbModel>(
            articlesSubmittedForVerification.Id
        );

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one Articles Submitted For Verification
    /// </summary>
    public async Task DeleteArticlesSubmittedForVerification(
        ArticlesSubmittedForVerificationWhereUniqueInput uniqueId
    )
    {
        var articlesSubmittedForVerification =
            await _context.ArticlesSubmittedForVerifications.FindAsync(uniqueId.Id);
        if (articlesSubmittedForVerification == null)
        {
            throw new NotFoundException();
        }

        _context.ArticlesSubmittedForVerifications.Remove(articlesSubmittedForVerification);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many Articles Submitted For Verifications
    /// </summary>
    public async Task<List<ArticlesSubmittedForVerification>> ArticlesSubmittedForVerifications(
        ArticlesSubmittedForVerificationFindManyArgs findManyArgs
    )
    {
        var articlesSubmittedForVerifications = await _context
            .ArticlesSubmittedForVerifications.Include(x => x.CommonVerifications)
            .Include(x => x.TaxesForVerification)
            .Include(x => x.ModelValueEvaluationVerifications)
            .ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return articlesSubmittedForVerifications.ConvertAll(articlesSubmittedForVerification =>
            articlesSubmittedForVerification.ToDto()
        );
    }

    /// <summary>
    /// Meta data about Articles Submitted For Verification records
    /// </summary>
    public async Task<MetadataDto> ArticlesSubmittedForVerificationsMeta(
        ArticlesSubmittedForVerificationFindManyArgs findManyArgs
    )
    {
        var count = await _context
            .ArticlesSubmittedForVerifications.ApplyWhere(findManyArgs.Where)
            .CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one Articles Submitted For Verification
    /// </summary>
    public async Task<ArticlesSubmittedForVerification> ArticlesSubmittedForVerification(
        ArticlesSubmittedForVerificationWhereUniqueInput uniqueId
    )
    {
        var articlesSubmittedForVerifications = await this.ArticlesSubmittedForVerifications(
            new ArticlesSubmittedForVerificationFindManyArgs
            {
                Where = new ArticlesSubmittedForVerificationWhereInput { Id = uniqueId.Id }
            }
        );
        var articlesSubmittedForVerification = articlesSubmittedForVerifications.FirstOrDefault();
        if (articlesSubmittedForVerification == null)
        {
            throw new NotFoundException();
        }

        return articlesSubmittedForVerification;
    }

    /// <summary>
    /// Update one Articles Submitted For Verification
    /// </summary>
    public async Task UpdateArticlesSubmittedForVerification(
        ArticlesSubmittedForVerificationWhereUniqueInput uniqueId,
        ArticlesSubmittedForVerificationUpdateInput updateDto
    )
    {
        var articlesSubmittedForVerification = updateDto.ToModel(uniqueId);

        if (updateDto.CommonVerifications != null)
        {
            articlesSubmittedForVerification.CommonVerifications = await _context
                .CommonVerifications.Where(commonVerification =>
                    updateDto.CommonVerifications.Select(t => t).Contains(commonVerification.Id)
                )
                .ToListAsync();
        }

        if (updateDto.TaxesForVerification != null)
        {
            articlesSubmittedForVerification.TaxesForVerification = await _context
                .TaxForVerifications.Where(taxForVerification =>
                    updateDto.TaxesForVerification.Select(t => t).Contains(taxForVerification.Id)
                )
                .ToListAsync();
        }

        if (updateDto.ModelValueEvaluationVerifications != null)
        {
            articlesSubmittedForVerification.ModelValueEvaluationVerifications = await _context
                .ModelValueEvaluationVerifications.Where(modelValueEvaluationVerification =>
                    updateDto
                        .ModelValueEvaluationVerifications.Select(t => t)
                        .Contains(modelValueEvaluationVerification.Id)
                )
                .ToListAsync();
        }

        _context.Entry(articlesSubmittedForVerification).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (
                !_context.ArticlesSubmittedForVerifications.Any(e =>
                    e.Id == articlesSubmittedForVerification.Id
                )
            )
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
    /// Connect multiple Common Verification records to Articles Submitted For Verification
    /// </summary>
    public async Task ConnectCommonVerification(
        ArticlesSubmittedForVerificationWhereUniqueInput uniqueId,
        CommonVerificationWhereUniqueInput[] commonVerificationsId
    )
    {
        var parent = await _context
            .ArticlesSubmittedForVerifications.Include(x => x.CommonVerifications)
            .FirstOrDefaultAsync(x => x.Id == uniqueId.Id);
        if (parent == null)
        {
            throw new NotFoundException();
        }

        var commonVerifications = await _context
            .CommonVerifications.Where(t => commonVerificationsId.Select(x => x.Id).Contains(t.Id))
            .ToListAsync();
        if (commonVerifications.Count == 0)
        {
            throw new NotFoundException();
        }

        var commonVerificationsToConnect = commonVerifications.Except(parent.CommonVerifications);

        foreach (var commonVerification in commonVerificationsToConnect)
        {
            parent.CommonVerifications.Add(commonVerification);
        }

        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Disconnect multiple Common Verification records from Articles Submitted For Verification
    /// </summary>
    public async Task DisconnectCommonVerification(
        ArticlesSubmittedForVerificationWhereUniqueInput uniqueId,
        CommonVerificationWhereUniqueInput[] commonVerificationsId
    )
    {
        var parent = await _context
            .ArticlesSubmittedForVerifications.Include(x => x.CommonVerifications)
            .FirstOrDefaultAsync(x => x.Id == uniqueId.Id);
        if (parent == null)
        {
            throw new NotFoundException();
        }

        var commonVerifications = await _context
            .CommonVerifications.Where(t => commonVerificationsId.Select(x => x.Id).Contains(t.Id))
            .ToListAsync();

        foreach (var commonVerification in commonVerifications)
        {
            parent.CommonVerifications?.Remove(commonVerification);
        }
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find multiple Common Verification records for Articles Submitted For Verification
    /// </summary>
    public async Task<List<CommonVerification>> FindCommonVerification(
        ArticlesSubmittedForVerificationWhereUniqueInput uniqueId,
        CommonVerificationFindManyArgs articlesSubmittedForVerificationFindManyArgs
    )
    {
        var commonVerifications = await _context
            .CommonVerifications.Where(m => m.ArticlesSubmittedForVerificationId == uniqueId.Id)
            .ApplyWhere(articlesSubmittedForVerificationFindManyArgs.Where)
            .ApplySkip(articlesSubmittedForVerificationFindManyArgs.Skip)
            .ApplyTake(articlesSubmittedForVerificationFindManyArgs.Take)
            .ApplyOrderBy(articlesSubmittedForVerificationFindManyArgs.SortBy)
            .ToListAsync();

        return commonVerifications.Select(x => x.ToDto()).ToList();
    }

    /// <summary>
    /// Update multiple Common Verification records for Articles Submitted For Verification
    /// </summary>
    public async Task UpdateCommonVerification(
        ArticlesSubmittedForVerificationWhereUniqueInput uniqueId,
        CommonVerificationWhereUniqueInput[] commonVerificationsId
    )
    {
        var articlesSubmittedForVerification = await _context
            .ArticlesSubmittedForVerifications.Include(t => t.CommonVerifications)
            .FirstOrDefaultAsync(x => x.Id == uniqueId.Id);
        if (articlesSubmittedForVerification == null)
        {
            throw new NotFoundException();
        }

        var commonVerifications = await _context
            .CommonVerifications.Where(a => commonVerificationsId.Select(x => x.Id).Contains(a.Id))
            .ToListAsync();

        if (commonVerifications.Count == 0)
        {
            throw new NotFoundException();
        }

        articlesSubmittedForVerification.CommonVerifications = commonVerifications;
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Connect multiple Model Value Evaluation Verifications records to Articles Submitted For Verification
    /// </summary>
    public async Task ConnectModelValueEvaluationVerifications(
        ArticlesSubmittedForVerificationWhereUniqueInput uniqueId,
        ModelValueEvaluationVerificationWhereUniqueInput[] modelValueEvaluationVerificationsId
    )
    {
        var parent = await _context
            .ArticlesSubmittedForVerifications.Include(x => x.ModelValueEvaluationVerifications)
            .FirstOrDefaultAsync(x => x.Id == uniqueId.Id);
        if (parent == null)
        {
            throw new NotFoundException();
        }

        var modelValueEvaluationVerifications = await _context
            .ModelValueEvaluationVerifications.Where(t =>
                modelValueEvaluationVerificationsId.Select(x => x.Id).Contains(t.Id)
            )
            .ToListAsync();
        if (modelValueEvaluationVerifications.Count == 0)
        {
            throw new NotFoundException();
        }

        var modelValueEvaluationVerificationsToConnect = modelValueEvaluationVerifications.Except(
            parent.ModelValueEvaluationVerifications
        );

        foreach (var modelValueEvaluationVerification in modelValueEvaluationVerificationsToConnect)
        {
            parent.ModelValueEvaluationVerifications.Add(modelValueEvaluationVerification);
        }

        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Disconnect multiple Model Value Evaluation Verifications records from Articles Submitted For Verification
    /// </summary>
    public async Task DisconnectModelValueEvaluationVerifications(
        ArticlesSubmittedForVerificationWhereUniqueInput uniqueId,
        ModelValueEvaluationVerificationWhereUniqueInput[] modelValueEvaluationVerificationsId
    )
    {
        var parent = await _context
            .ArticlesSubmittedForVerifications.Include(x => x.ModelValueEvaluationVerifications)
            .FirstOrDefaultAsync(x => x.Id == uniqueId.Id);
        if (parent == null)
        {
            throw new NotFoundException();
        }

        var modelValueEvaluationVerifications = await _context
            .ModelValueEvaluationVerifications.Where(t =>
                modelValueEvaluationVerificationsId.Select(x => x.Id).Contains(t.Id)
            )
            .ToListAsync();

        foreach (var modelValueEvaluationVerification in modelValueEvaluationVerifications)
        {
            parent.ModelValueEvaluationVerifications?.Remove(modelValueEvaluationVerification);
        }
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find multiple Model Value Evaluation Verifications records for Articles Submitted For Verification
    /// </summary>
    public async Task<List<ModelValueEvaluationVerification>> FindModelValueEvaluationVerifications(
        ArticlesSubmittedForVerificationWhereUniqueInput uniqueId,
        ModelValueEvaluationVerificationFindManyArgs articlesSubmittedForVerificationFindManyArgs
    )
    {
        var modelValueEvaluationVerifications = await _context
            .ModelValueEvaluationVerifications.Where(m =>
                m.ArticlesSubmittedForVerificationId == uniqueId.Id
            )
            .ApplyWhere(articlesSubmittedForVerificationFindManyArgs.Where)
            .ApplySkip(articlesSubmittedForVerificationFindManyArgs.Skip)
            .ApplyTake(articlesSubmittedForVerificationFindManyArgs.Take)
            .ApplyOrderBy(articlesSubmittedForVerificationFindManyArgs.SortBy)
            .ToListAsync();

        return modelValueEvaluationVerifications.Select(x => x.ToDto()).ToList();
    }

    /// <summary>
    /// Update multiple Model Value Evaluation Verifications records for Articles Submitted For Verification
    /// </summary>
    public async Task UpdateModelValueEvaluationVerifications(
        ArticlesSubmittedForVerificationWhereUniqueInput uniqueId,
        ModelValueEvaluationVerificationWhereUniqueInput[] modelValueEvaluationVerificationsId
    )
    {
        var articlesSubmittedForVerification = await _context
            .ArticlesSubmittedForVerifications.Include(t => t.ModelValueEvaluationVerifications)
            .FirstOrDefaultAsync(x => x.Id == uniqueId.Id);
        if (articlesSubmittedForVerification == null)
        {
            throw new NotFoundException();
        }

        var modelValueEvaluationVerifications = await _context
            .ModelValueEvaluationVerifications.Where(a =>
                modelValueEvaluationVerificationsId.Select(x => x.Id).Contains(a.Id)
            )
            .ToListAsync();

        if (modelValueEvaluationVerifications.Count == 0)
        {
            throw new NotFoundException();
        }

        articlesSubmittedForVerification.ModelValueEvaluationVerifications =
            modelValueEvaluationVerifications;
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Connect multiple Taxes For Verification records to Articles Submitted For Verification
    /// </summary>
    public async Task ConnectTaxesForVerification(
        ArticlesSubmittedForVerificationWhereUniqueInput uniqueId,
        TaxForVerificationWhereUniqueInput[] taxForVerificationsId
    )
    {
        var parent = await _context
            .ArticlesSubmittedForVerifications.Include(x => x.TaxesForVerification)
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
    /// Disconnect multiple Taxes For Verification records from Articles Submitted For Verification
    /// </summary>
    public async Task DisconnectTaxesForVerification(
        ArticlesSubmittedForVerificationWhereUniqueInput uniqueId,
        TaxForVerificationWhereUniqueInput[] taxForVerificationsId
    )
    {
        var parent = await _context
            .ArticlesSubmittedForVerifications.Include(x => x.TaxesForVerification)
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
    /// Find multiple Taxes For Verification records for Articles Submitted For Verification
    /// </summary>
    public async Task<List<TaxForVerification>> FindTaxesForVerification(
        ArticlesSubmittedForVerificationWhereUniqueInput uniqueId,
        TaxForVerificationFindManyArgs articlesSubmittedForVerificationFindManyArgs
    )
    {
        var taxForVerifications = await _context
            .TaxForVerifications.Where(m => m.ArticlesSubmittedForVerificationsId == uniqueId.Id)
            .ApplyWhere(articlesSubmittedForVerificationFindManyArgs.Where)
            .ApplySkip(articlesSubmittedForVerificationFindManyArgs.Skip)
            .ApplyTake(articlesSubmittedForVerificationFindManyArgs.Take)
            .ApplyOrderBy(articlesSubmittedForVerificationFindManyArgs.SortBy)
            .ToListAsync();

        return taxForVerifications.Select(x => x.ToDto()).ToList();
    }

    /// <summary>
    /// Update multiple Taxes For Verification records for Articles Submitted For Verification
    /// </summary>
    public async Task UpdateTaxesForVerification(
        ArticlesSubmittedForVerificationWhereUniqueInput uniqueId,
        TaxForVerificationWhereUniqueInput[] taxForVerificationsId
    )
    {
        var articlesSubmittedForVerification = await _context
            .ArticlesSubmittedForVerifications.Include(t => t.TaxesForVerification)
            .FirstOrDefaultAsync(x => x.Id == uniqueId.Id);
        if (articlesSubmittedForVerification == null)
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

        articlesSubmittedForVerification.TaxesForVerification = taxForVerifications;
        await _context.SaveChangesAsync();
    }
}
