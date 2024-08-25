using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Control.APIs.Extensions;
using Control.Infrastructure;
using Control.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Control.APIs;

public abstract class CustomsDetailedDeclarationValueAssessmentArticlesServiceBase
    : ICustomsDetailedDeclarationValueAssessmentArticlesService
{
    protected readonly ControlDbContext _context;

    public CustomsDetailedDeclarationValueAssessmentArticlesServiceBase(ControlDbContext context)
    {
        _context = context;
    }

    /// <summary>
    ///     Create one CUSTOMS DETAILED DECLARATION VALUE ASSESSMENT ARTICLE
    /// </summary>
    public async Task<CustomsDetailedDeclarationValueAssessmentArticle>
        CreateCustomsDetailedDeclarationValueAssessmentArticle(
            CustomsDetailedDeclarationValueAssessmentArticleCreateInput createDto
        )
    {
        var customsDetailedDeclarationValueAssessmentArticle =
            new CustomsDetailedDeclarationValueAssessmentArticleDbModel
            {
                AmountDeductedOfTheArticle = createDto.AmountDeductedOfTheArticle,
                AmountNcyDeductedOfTheArticle = createDto.AmountNcyDeductedOfTheArticle,
                AmountNcyOfTheEvaluationOfValueOfTheArticle =
                    createDto.AmountNcyOfTheEvaluationOfValueOfTheArticle,
                AmountNcyOfTheFairValueOfTheArticle = createDto.AmountNcyOfTheFairValueOfTheArticle,
                AmountNcyOfTheFreightOfTheArticle = createDto.AmountNcyOfTheFreightOfTheArticle,
                AmountNcyOfTheInsuranceOfTheArticle = createDto.AmountNcyOfTheInsuranceOfTheArticle,
                AmountNcyOfTheInvoiceOfTheArticle = createDto.AmountNcyOfTheInvoiceOfTheArticle,
                AmountNcyOfTheOtherCostsOfTheArticle =
                    createDto.AmountNcyOfTheOtherCostsOfTheArticle,
                AmountNycOfTheTaxableBaseOfTheArticle =
                    createDto.AmountNycOfTheTaxableBaseOfTheArticle,
                AmountOfTheFreightOfTheArticle = createDto.AmountOfTheFreightOfTheArticle,
                AmountOfTheInsuranceOfTheArticle = createDto.AmountOfTheInsuranceOfTheArticle,
                AmountOfTheInvoiceOfTheArticle = createDto.AmountOfTheInvoiceOfTheArticle,
                AmountOfTheOtherCostsOfTheArticle = createDto.AmountOfTheOtherCostsOfTheArticle,
                AmountUsdOfTheEvaluationOfValueOfTheArticle =
                    createDto.AmountUsdOfTheEvaluationOfValueOfTheArticle,
                AmountUsdOfTheFairValueOfTheArticle = createDto.AmountUsdOfTheFairValueOfTheArticle,
                AmountUsdOfTheInvoiceOfTheArticle = createDto.AmountUsdOfTheInvoiceOfTheArticle,
                AmountUsdOfTheTaxableBaseOfTheArticle =
                    createDto.AmountUsdOfTheTaxableBaseOfTheArticle,
                ArticleNumber = createDto.ArticleNumber,
                BasicValueOfTheFairValueOfTheArticle =
                    createDto.BasicValueOfTheFairValueOfTheArticle,
                CreatedAt = createDto.CreatedAt,
                CurrencyCodeDeductedOfTheArticle = createDto.CurrencyCodeDeductedOfTheArticle,
                CurrencyCodeOfTheFairValueOfTheArticle =
                    createDto.CurrencyCodeOfTheFairValueOfTheArticle,
                CurrencyCodeOfTheFreightOfTheArticle =
                    createDto.CurrencyCodeOfTheFreightOfTheArticle,
                CurrencyCodeOfTheInsuranceOfTheArticle =
                    createDto.CurrencyCodeOfTheInsuranceOfTheArticle,
                CurrencyCodeOfTheInvoiceOfTheArticle =
                    createDto.CurrencyCodeOfTheInvoiceOfTheArticle,
                CurrencyCodeOfTheOtherCostsOfTheArticle =
                    createDto.CurrencyCodeOfTheOtherCostsOfTheArticle,
                DateAndTimeOfFinalModification = createDto.DateAndTimeOfFinalModification,
                DateAndTimeOfFirstRegistration = createDto.DateAndTimeOfFirstRegistration,
                ExchangeRateOfTheDeductionOfTheArticle =
                    createDto.ExchangeRateOfTheDeductionOfTheArticle,
                ExchangeRateOfTheFreightOfTheArticle =
                    createDto.ExchangeRateOfTheFreightOfTheArticle,
                ExchangeRateOfTheInsuranceOfTheArticle =
                    createDto.ExchangeRateOfTheInsuranceOfTheArticle,
                ExchangeRateOfTheInvoiceOfTheArticle =
                    createDto.ExchangeRateOfTheInvoiceOfTheArticle,
                ExchangeRateOfTheOtherCostsOfTheArticle =
                    createDto.ExchangeRateOfTheOtherCostsOfTheArticle,
                FinalModifierSId = createDto.FinalModifierSId,
                FirstRegistrantSId = createDto.FirstRegistrantSId,
                RectificationFrequency = createDto.RectificationFrequency,
                ReferenceNumber = createDto.ReferenceNumber,
                SuppressionOn = createDto.SuppressionOn,
                UnitAmountOfTheFairValueOfTheArticle =
                    createDto.UnitAmountOfTheFairValueOfTheArticle,
                UpdatedAt = createDto.UpdatedAt
            };

        if (createDto.Id != null) customsDetailedDeclarationValueAssessmentArticle.Id = createDto.Id;

        _context.CustomsDetailedDeclarationValueAssessmentArticles.Add(
            customsDetailedDeclarationValueAssessmentArticle
        );
        await _context.SaveChangesAsync();

        var result =
            await _context.FindAsync<CustomsDetailedDeclarationValueAssessmentArticleDbModel>(
                customsDetailedDeclarationValueAssessmentArticle.Id
            );

        if (result == null) throw new NotFoundException();

        return result.ToDto();
    }

    /// <summary>
    ///     Delete one CUSTOMS DETAILED DECLARATION VALUE ASSESSMENT ARTICLE
    /// </summary>
    public async Task DeleteCustomsDetailedDeclarationValueAssessmentArticle(
        CustomsDetailedDeclarationValueAssessmentArticleWhereUniqueInput uniqueId
    )
    {
        var customsDetailedDeclarationValueAssessmentArticle =
            await _context.CustomsDetailedDeclarationValueAssessmentArticles.FindAsync(uniqueId.Id);
        if (customsDetailedDeclarationValueAssessmentArticle == null) throw new NotFoundException();

        _context.CustomsDetailedDeclarationValueAssessmentArticles.Remove(
            customsDetailedDeclarationValueAssessmentArticle
        );
        await _context.SaveChangesAsync();
    }

    /// <summary>
    ///     Find many CUSTOMS DETAILED DECLARATION VALUE ASSESSMENT ARTICLES
    /// </summary>
    public async Task<
        List<CustomsDetailedDeclarationValueAssessmentArticle>
    > CustomsDetailedDeclarationValueAssessmentArticles(
        CustomsDetailedDeclarationValueAssessmentArticleFindManyArgs findManyArgs
    )
    {
        var customsDetailedDeclarationValueAssessmentArticles = await _context
            .CustomsDetailedDeclarationValueAssessmentArticles.ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return customsDetailedDeclarationValueAssessmentArticles.ConvertAll(
            customsDetailedDeclarationValueAssessmentArticle =>
                customsDetailedDeclarationValueAssessmentArticle.ToDto()
        );
    }

    /// <summary>
    ///     Meta data about CUSTOMS DETAILED DECLARATION VALUE ASSESSMENT ARTICLE records
    /// </summary>
    public async Task<MetadataDto> CustomsDetailedDeclarationValueAssessmentArticlesMeta(
        CustomsDetailedDeclarationValueAssessmentArticleFindManyArgs findManyArgs
    )
    {
        var count = await _context
            .CustomsDetailedDeclarationValueAssessmentArticles.ApplyWhere(findManyArgs.Where)
            .CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    ///     Get one CUSTOMS DETAILED DECLARATION VALUE ASSESSMENT ARTICLE
    /// </summary>
    public async Task<CustomsDetailedDeclarationValueAssessmentArticle>
        CustomsDetailedDeclarationValueAssessmentArticle(
            CustomsDetailedDeclarationValueAssessmentArticleWhereUniqueInput uniqueId
        )
    {
        var customsDetailedDeclarationValueAssessmentArticles =
            await CustomsDetailedDeclarationValueAssessmentArticles(
                new CustomsDetailedDeclarationValueAssessmentArticleFindManyArgs
                {
                    Where = new CustomsDetailedDeclarationValueAssessmentArticleWhereInput
                    {
                        Id = uniqueId.Id
                    }
                }
            );
        var customsDetailedDeclarationValueAssessmentArticle =
            customsDetailedDeclarationValueAssessmentArticles.FirstOrDefault();
        if (customsDetailedDeclarationValueAssessmentArticle == null) throw new NotFoundException();

        return customsDetailedDeclarationValueAssessmentArticle;
    }

    /// <summary>
    ///     Update one CUSTOMS DETAILED DECLARATION VALUE ASSESSMENT ARTICLE
    /// </summary>
    public async Task UpdateCustomsDetailedDeclarationValueAssessmentArticle(
        CustomsDetailedDeclarationValueAssessmentArticleWhereUniqueInput uniqueId,
        CustomsDetailedDeclarationValueAssessmentArticleUpdateInput updateDto
    )
    {
        var customsDetailedDeclarationValueAssessmentArticle = updateDto.ToModel(uniqueId);

        _context.Entry(customsDetailedDeclarationValueAssessmentArticle).State =
            EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (
                !_context.CustomsDetailedDeclarationValueAssessmentArticles.Any(e =>
                    e.Id == customsDetailedDeclarationValueAssessmentArticle.Id
                )
            )
                throw new NotFoundException();
            throw;
        }
    }
}
