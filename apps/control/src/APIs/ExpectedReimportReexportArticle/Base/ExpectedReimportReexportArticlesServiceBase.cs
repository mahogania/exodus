using Control.APIs;
using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Control.APIs.Extensions;
using Control.Infrastructure;
using Control.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Control.APIs;

public abstract class ExpectedReimportReexportArticlesServiceBase
    : IExpectedReimportReexportArticlesService
{
    protected readonly ControlDbContext _context;

    public ExpectedReimportReexportArticlesServiceBase(ControlDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one EXPECTED REIMPORT/REEXPORT ARTICLE
    /// </summary>
    public async Task<ExpectedReimportReexportArticle> CreateExpectedReimportReexportArticle(
        ExpectedReimportReexportArticleCreateInput createDto
    )
    {
        var expectedReimportReexportArticle = new ExpectedReimportReexportArticleDbModel
        {
            ArticleGrossWeight = createDto.ArticleGrossWeight,
            ArticleName = createDto.ArticleName,
            ArticleNetWeight = createDto.ArticleNetWeight,
            CreatedAt = createDto.CreatedAt,
            DateAndTimeOfFinalModification = createDto.DateAndTimeOfFinalModification,
            DateAndTimeOfFirstRegistration = createDto.DateAndTimeOfFirstRegistration,
            ExpectedArticleNumber = createDto.ExpectedArticleNumber,
            FinalModifierSId = createDto.FinalModifierSId,
            IdDuPremierEnregistrant = createDto.IdDuPremierEnregistrant,
            Key = createDto.Key,
            OriginCountryCode = createDto.OriginCountryCode,
            Quantity = createDto.Quantity,
            QuantityUnitCode = createDto.QuantityUnitCode,
            RectificationFrequency = createDto.RectificationFrequency,
            ReferenceNumber = createDto.ReferenceNumber,
            ShCode = createDto.ShCode,
            SpecificGoodsClassificationCode = createDto.SpecificGoodsClassificationCode,
            SuppressionOn = createDto.SuppressionOn,
            TransactionArticleName = createDto.TransactionArticleName,
            UpdatedAt = createDto.UpdatedAt
        };

        if (createDto.Id != null)
        {
            expectedReimportReexportArticle.Id = createDto.Id;
        }

        _context.ExpectedReimportReexportArticles.Add(expectedReimportReexportArticle);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<ExpectedReimportReexportArticleDbModel>(
            expectedReimportReexportArticle.Id
        );

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one EXPECTED REIMPORT/REEXPORT ARTICLE
    /// </summary>
    public async Task DeleteExpectedReimportReexportArticle(
        ExpectedReimportReexportArticleWhereUniqueInput uniqueId
    )
    {
        var expectedReimportReexportArticle =
            await _context.ExpectedReimportReexportArticles.FindAsync(uniqueId.Id);
        if (expectedReimportReexportArticle == null)
        {
            throw new NotFoundException();
        }

        _context.ExpectedReimportReexportArticles.Remove(expectedReimportReexportArticle);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many EXPECTED REIMPORT/REEXPORT ARTICLES
    /// </summary>
    public async Task<List<ExpectedReimportReexportArticle>> ExpectedReimportReexportArticles(
        ExpectedReimportReexportArticleFindManyArgs findManyArgs
    )
    {
        var expectedReimportReexportArticles = await _context
            .ExpectedReimportReexportArticles.ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return expectedReimportReexportArticles.ConvertAll(expectedReimportReexportArticle =>
            expectedReimportReexportArticle.ToDto()
        );
    }

    /// <summary>
    /// Meta data about EXPECTED REIMPORT/REEXPORT ARTICLE records
    /// </summary>
    public async Task<MetadataDto> ExpectedReimportReexportArticlesMeta(
        ExpectedReimportReexportArticleFindManyArgs findManyArgs
    )
    {
        var count = await _context
            .ExpectedReimportReexportArticles.ApplyWhere(findManyArgs.Where)
            .CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one EXPECTED REIMPORT/REEXPORT ARTICLE
    /// </summary>
    public async Task<ExpectedReimportReexportArticle> ExpectedReimportReexportArticle(
        ExpectedReimportReexportArticleWhereUniqueInput uniqueId
    )
    {
        var expectedReimportReexportArticles = await this.ExpectedReimportReexportArticles(
            new ExpectedReimportReexportArticleFindManyArgs
            {
                Where = new ExpectedReimportReexportArticleWhereInput { Id = uniqueId.Id }
            }
        );
        var expectedReimportReexportArticle = expectedReimportReexportArticles.FirstOrDefault();
        if (expectedReimportReexportArticle == null)
        {
            throw new NotFoundException();
        }

        return expectedReimportReexportArticle;
    }

    /// <summary>
    /// Update one EXPECTED REIMPORT/REEXPORT ARTICLE
    /// </summary>
    public async Task UpdateExpectedReimportReexportArticle(
        ExpectedReimportReexportArticleWhereUniqueInput uniqueId,
        ExpectedReimportReexportArticleUpdateInput updateDto
    )
    {
        var expectedReimportReexportArticle = updateDto.ToModel(uniqueId);

        _context.Entry(expectedReimportReexportArticle).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (
                !_context.ExpectedReimportReexportArticles.Any(e =>
                    e.Id == expectedReimportReexportArticle.Id
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
}
