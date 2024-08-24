using Control.APIs;
using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Control.APIs.Extensions;
using Control.Infrastructure;
using Control.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Control.APIs;

public abstract class ArticleAssessmentsServiceBase : IArticleAssessmentsService
{
    protected readonly ControlDbContext _context;

    public ArticleAssessmentsServiceBase(ControlDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one Article Assessment
    /// </summary>
    public async Task<ArticleAssessment> CreateArticleAssessment(
        ArticleAssessmentCreateInput createDto
    )
    {
        var articleAssessment = new ArticleAssessmentDbModel
        {
            AmountDeductedOfTheArticle = createDto.AmountDeductedOfTheArticle,
            AmountNcyDeductedOfTheArticle = createDto.AmountNcyDeductedOfTheArticle,
            AmountNcyOfTheEvaluationOfValueOfTheArticle =
                createDto.AmountNcyOfTheEvaluationOfValueOfTheArticle,
            AmountNcyOfTheFairValueOfTheArticle = createDto.AmountNcyOfTheFairValueOfTheArticle,
            AmountNcyOfTheFreightOfTheArticle = createDto.AmountNcyOfTheFreightOfTheArticle,
            AmountNcyOfTheInsuranceOfTheArticle = createDto.AmountNcyOfTheInsuranceOfTheArticle,
            AmountNcyOfTheInvoiceOfTheArticle = createDto.AmountNcyOfTheInvoiceOfTheArticle,
            AmountNcyOfTheOtherCostsOfTheArticle = createDto.AmountNcyOfTheOtherCostsOfTheArticle,
            AmountNycOfTheTaxableBaseOfTheArticle = createDto.AmountNycOfTheTaxableBaseOfTheArticle,
            AmountOfTheFreightOfTheArticle = createDto.AmountOfTheFreightOfTheArticle,
            AmountOfTheInsuranceOfTheArticle = createDto.AmountOfTheInsuranceOfTheArticle,
            AmountOfTheInvoiceOfTheArticle = createDto.AmountOfTheInvoiceOfTheArticle,
            AmountOfTheOtherCostsOfTheArticle = createDto.AmountOfTheOtherCostsOfTheArticle,
            AmountUsdOfTheEvaluationOfValueOfTheArticle =
                createDto.AmountUsdOfTheEvaluationOfValueOfTheArticle,
            AmountUsdOfTheFairValueOfTheArticle = createDto.AmountUsdOfTheFairValueOfTheArticle,
            AmountUsdOfTheInvoiceOfTheArticle = createDto.AmountUsdOfTheInvoiceOfTheArticle,
            AmountUsdOfTheTaxableBaseOfTheArticle = createDto.AmountUsdOfTheTaxableBaseOfTheArticle,
            ArticleNumber = createDto.ArticleNumber,
            BasicValueOfTheFairValueOfTheArticle = createDto.BasicValueOfTheFairValueOfTheArticle,
            CreatedAt = createDto.CreatedAt,
            CurrencyCodeDeductedOfTheArticle = createDto.CurrencyCodeDeductedOfTheArticle,
            CurrencyCodeOfTheFairValueOfTheArticle =
                createDto.CurrencyCodeOfTheFairValueOfTheArticle,
            CurrencyCodeOfTheFreightOfTheArticle = createDto.CurrencyCodeOfTheFreightOfTheArticle,
            CurrencyCodeOfTheInsuranceOfTheArticle =
                createDto.CurrencyCodeOfTheInsuranceOfTheArticle,
            CurrencyCodeOfTheInvoiceOfTheArticle = createDto.CurrencyCodeOfTheInvoiceOfTheArticle,
            CurrencyCodeOfTheOtherCostsOfTheArticle =
                createDto.CurrencyCodeOfTheOtherCostsOfTheArticle,
            DateAndTimeOfFinalModification = createDto.DateAndTimeOfFinalModification,
            DateAndTimeOfFirstRegistration = createDto.DateAndTimeOfFirstRegistration,
            ExchangeRateOfTheDeductionOfTheArticle =
                createDto.ExchangeRateOfTheDeductionOfTheArticle,
            ExchangeRateOfTheFreightOfTheArticle = createDto.ExchangeRateOfTheFreightOfTheArticle,
            ExchangeRateOfTheInsuranceOfTheArticle =
                createDto.ExchangeRateOfTheInsuranceOfTheArticle,
            ExchangeRateOfTheInvoiceOfTheArticle = createDto.ExchangeRateOfTheInvoiceOfTheArticle,
            ExchangeRateOfTheOtherCostsOfTheArticle =
                createDto.ExchangeRateOfTheOtherCostsOfTheArticle,
            FinalModifierSId = createDto.FinalModifierSId,
            FirstRegistrantSId = createDto.FirstRegistrantSId,
            RectificationFrequency = createDto.RectificationFrequency,
            ReferenceNumber = createDto.ReferenceNumber,
            SuppressionOn = createDto.SuppressionOn,
            UnitAmountOfTheFairValueOfTheArticle = createDto.UnitAmountOfTheFairValueOfTheArticle,
            UpdatedAt = createDto.UpdatedAt
        };

        if (createDto.Id != null)
        {
            articleAssessment.Id = createDto.Id;
        }
        if (createDto.Article != null)
        {
            articleAssessment.Article = await _context
                .Articles.Where(article => createDto.Article.Id == article.Id)
                .FirstOrDefaultAsync();
        }

        if (createDto.ValueAssessment != null)
        {
            articleAssessment.ValueAssessment = await _context
                .ValueAssessments.Where(valueAssessment =>
                    createDto.ValueAssessment.Id == valueAssessment.Id
                )
                .FirstOrDefaultAsync();
        }

        _context.ArticleAssessments.Add(articleAssessment);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<ArticleAssessmentDbModel>(articleAssessment.Id);

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one Article Assessment
    /// </summary>
    public async Task DeleteArticleAssessment(ArticleAssessmentWhereUniqueInput uniqueId)
    {
        var articleAssessment = await _context.ArticleAssessments.FindAsync(uniqueId.Id);
        if (articleAssessment == null)
        {
            throw new NotFoundException();
        }

        _context.ArticleAssessments.Remove(articleAssessment);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many Assessment Articles
    /// </summary>
    public async Task<List<ArticleAssessment>> ArticleAssessments(
        ArticleAssessmentFindManyArgs findManyArgs
    )
    {
        var articleAssessments = await _context
            .ArticleAssessments.Include(x => x.Article)
            .Include(x => x.ValueAssessment)
            .ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return articleAssessments.ConvertAll(articleAssessment => articleAssessment.ToDto());
    }

    /// <summary>
    /// Meta data about Article Assessment records
    /// </summary>
    public async Task<MetadataDto> ArticleAssessmentsMeta(
        ArticleAssessmentFindManyArgs findManyArgs
    )
    {
        var count = await _context.ArticleAssessments.ApplyWhere(findManyArgs.Where).CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one Article Assessment
    /// </summary>
    public async Task<ArticleAssessment> ArticleAssessment(
        ArticleAssessmentWhereUniqueInput uniqueId
    )
    {
        var articleAssessments = await this.ArticleAssessments(
            new ArticleAssessmentFindManyArgs
            {
                Where = new ArticleAssessmentWhereInput { Id = uniqueId.Id }
            }
        );
        var articleAssessment = articleAssessments.FirstOrDefault();
        if (articleAssessment == null)
        {
            throw new NotFoundException();
        }

        return articleAssessment;
    }

    /// <summary>
    /// Update one Article Assessment
    /// </summary>
    public async Task UpdateArticleAssessment(
        ArticleAssessmentWhereUniqueInput uniqueId,
        ArticleAssessmentUpdateInput updateDto
    )
    {
        var articleAssessment = updateDto.ToModel(uniqueId);

        _context.Entry(articleAssessment).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!_context.ArticleAssessments.Any(e => e.Id == articleAssessment.Id))
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
    /// Get a Article record for Article Assessment
    /// </summary>
    public async Task<Article> GetArticle(ArticleAssessmentWhereUniqueInput uniqueId)
    {
        var articleAssessment = await _context
            .ArticleAssessments.Where(articleAssessment => articleAssessment.Id == uniqueId.Id)
            .Include(articleAssessment => articleAssessment.Article)
            .FirstOrDefaultAsync();
        if (articleAssessment == null)
        {
            throw new NotFoundException();
        }
        return articleAssessment.Article.ToDto();
    }

    /// <summary>
    /// Get a COMMON DETAILED DECLARATION (CUSTOMS) VALUE ASSESSMENT record for Assessment Article
    /// </summary>
    public async Task<ValueAssessment> GetValueAssessment(
        ArticleAssessmentWhereUniqueInput uniqueId
    )
    {
        var articleAssessment = await _context
            .ArticleAssessments.Where(articleAssessment => articleAssessment.Id == uniqueId.Id)
            .Include(articleAssessment => articleAssessment.ValueAssessment)
            .FirstOrDefaultAsync();
        if (articleAssessment == null)
        {
            throw new NotFoundException();
        }
        return articleAssessment.ValueAssessment.ToDto();
    }
}
