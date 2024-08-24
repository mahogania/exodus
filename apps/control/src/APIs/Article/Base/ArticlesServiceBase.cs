using Control.APIs;
using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Control.APIs.Extensions;
using Control.Infrastructure;
using Control.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Control.APIs;

public abstract class ArticlesServiceBase : IArticlesService
{
    protected readonly ControlDbContext _context;

    public ArticlesServiceBase(ControlDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one Article
    /// </summary>
    public async Task<Article> CreateArticle(ArticleCreateInput createDto)
    {
        var article = new ArticleDbModel
        {
            ApcCode = createDto.ApcCode,
            ArticleName = createDto.ArticleName,
            ArticleNumber = createDto.ArticleNumber,
            ArticlePackageUnitCode = createDto.ArticlePackageUnitCode,
            BrandName = createDto.BrandName,
            CountryOfOriginCode = createDto.CountryOfOriginCode,
            CreatedAt = createDto.CreatedAt,
            DateAndTimeOfFinalModification = createDto.DateAndTimeOfFinalModification,
            DateAndTimeOfFirstRegistration = createDto.DateAndTimeOfFirstRegistration,
            DeletionOn = createDto.DeletionOn,
            EndDateOfApcApproval = createDto.EndDateOfApcApproval,
            FinalModifierSId = createDto.FinalModifierSId,
            FirstRecorderSId = createDto.FirstRecorderSId,
            GrossWeightOfTheArticle = createDto.GrossWeightOfTheArticle,
            Key = createDto.Key,
            ManagementAndMonitoringClearanceExpiryPeriod =
                createDto.ManagementAndMonitoringClearanceExpiryPeriod,
            ManagementOfShCodeExtractCodes = createDto.ManagementOfShCodeExtractCodes,
            NetWeightOfTheArticle = createDto.NetWeightOfTheArticle,
            NewAndUsedProductCode = createDto.NewAndUsedProductCode,
            NumberOfArticlePackages = createDto.NumberOfArticlePackages,
            OilTankNumber = createDto.OilTankNumber,
            ParcelDescription = createDto.ParcelDescription,
            ParcelShippingMarkNumber = createDto.ParcelShippingMarkNumber,
            PartialClearanceTypeCode = createDto.PartialClearanceTypeCode,
            PreferentialCode = createDto.PreferentialCode,
            PreviousArticleNumber = createDto.PreviousArticleNumber,
            PreviousDetailedDeclarationDate = createDto.PreviousDetailedDeclarationDate,
            PreviousDetailedDeclarationNumber = createDto.PreviousDetailedDeclarationNumber,
            ProhibitedProductCode = createDto.ProhibitedProductCode,
            Quantity = createDto.Quantity,
            QuantityUnitCode = createDto.QuantityUnitCode,
            QuotaAuthorizationNumber = createDto.QuotaAuthorizationNumber,
            RectificationFrequency = createDto.RectificationFrequency,
            ReferenceNumber = createDto.ReferenceNumber,
            RequestRegimeNumber = createDto.RequestRegimeNumber,
            RtcDecisionAuthorizationNumber = createDto.RtcDecisionAuthorizationNumber,
            ShCode = createDto.ShCode,
            SpecificCodeForClassificationOfGoods = createDto.SpecificCodeForClassificationOfGoods,
            StartDateOfApcApproval = createDto.StartDateOfApcApproval,
            StatisticalValue = createDto.StatisticalValue,
            SuperiorArticleNumber = createDto.SuperiorArticleNumber,
            TaxationQuantity = createDto.TaxationQuantity,
            TaxationUnit = createDto.TaxationUnit,
            TransactionArticleName = createDto.TransactionArticleName,
            UpdatedAt = createDto.UpdatedAt,
            ValueAssessmentMethodCode = createDto.ValueAssessmentMethodCode,
            VehicleOn = createDto.VehicleOn,
            WarrantyExemptionAuthorizationNumber = createDto.WarrantyExemptionAuthorizationNumber
        };

        if (createDto.Id != null)
        {
            article.Id = createDto.Id;
        }
        if (createDto.ArticleAssessments != null)
        {
            article.ArticleAssessments = await _context
                .ArticleAssessments.Where(articleAssessment =>
                    createDto.ArticleAssessments.Select(t => t.Id).Contains(articleAssessment.Id)
                )
                .ToListAsync();
        }

        if (createDto.CommonDetailedDeclaration != null)
        {
            article.CommonDetailedDeclaration = await _context
                .CommonDetailedDeclarations.Where(commonDetailedDeclaration =>
                    createDto.CommonDetailedDeclaration.Id == commonDetailedDeclaration.Id
                )
                .FirstOrDefaultAsync();
        }

        if (createDto.Model != null)
        {
            article.Model = await _context
                .ModelofDetailedDeclarations.Where(modelofDetailedDeclaration =>
                    createDto.Model.Select(t => t.Id).Contains(modelofDetailedDeclaration.Id)
                )
                .ToListAsync();
        }

        if (createDto.RawMaterials != null)
        {
            article.RawMaterials = await _context
                .RawMaterials.Where(rawMaterial =>
                    createDto.RawMaterials.Select(t => t.Id).Contains(rawMaterial.Id)
                )
                .ToListAsync();
        }

        if (createDto.Tax != null)
        {
            article.Tax = await _context
                .DetailedDeclarationTaxes.Where(detailedDeclarationTax =>
                    createDto.Tax.Id == detailedDeclarationTax.Id
                )
                .FirstOrDefaultAsync();
        }

        if (createDto.Vehicle != null)
        {
            article.Vehicle = await _context
                .Vehicles.Where(vehicle => createDto.Vehicle.Id == vehicle.Id)
                .FirstOrDefaultAsync();
        }

        _context.Articles.Add(article);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<ArticleDbModel>(article.Id);

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one Article
    /// </summary>
    public async Task DeleteArticle(ArticleWhereUniqueInput uniqueId)
    {
        var article = await _context.Articles.FindAsync(uniqueId.Id);
        if (article == null)
        {
            throw new NotFoundException();
        }

        _context.Articles.Remove(article);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many Articles of the Detailed Declaration
    /// </summary>
    public async Task<List<Article>> Articles(ArticleFindManyArgs findManyArgs)
    {
        var articles = await _context
            .Articles.Include(x => x.CommonDetailedDeclaration)
            .Include(x => x.Tax)
            .Include(x => x.RawMaterials)
            .Include(x => x.Model)
            .Include(x => x.Vehicle)
            .Include(x => x.ArticleAssessments)
            .ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return articles.ConvertAll(article => article.ToDto());
    }

    /// <summary>
    /// Meta data about Article records
    /// </summary>
    public async Task<MetadataDto> ArticlesMeta(ArticleFindManyArgs findManyArgs)
    {
        var count = await _context.Articles.ApplyWhere(findManyArgs.Where).CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one Article
    /// </summary>
    public async Task<Article> Article(ArticleWhereUniqueInput uniqueId)
    {
        var articles = await this.Articles(
            new ArticleFindManyArgs { Where = new ArticleWhereInput { Id = uniqueId.Id } }
        );
        var article = articles.FirstOrDefault();
        if (article == null)
        {
            throw new NotFoundException();
        }

        return article;
    }

    /// <summary>
    /// Update one Article
    /// </summary>
    public async Task UpdateArticle(ArticleWhereUniqueInput uniqueId, ArticleUpdateInput updateDto)
    {
        var article = updateDto.ToModel(uniqueId);

        if (updateDto.RawMaterials != null)
        {
            article.RawMaterials = await _context
                .RawMaterials.Where(rawMaterial =>
                    updateDto.RawMaterials.Select(t => t).Contains(rawMaterial.Id)
                )
                .ToListAsync();
        }

        if (updateDto.Model != null)
        {
            article.Model = await _context
                .ModelofDetailedDeclarations.Where(modelofDetailedDeclaration =>
                    updateDto.Model.Select(t => t).Contains(modelofDetailedDeclaration.Id)
                )
                .ToListAsync();
        }

        if (updateDto.ArticleAssessments != null)
        {
            article.ArticleAssessments = await _context
                .ArticleAssessments.Where(articleAssessment =>
                    updateDto.ArticleAssessments.Select(t => t).Contains(articleAssessment.Id)
                )
                .ToListAsync();
        }

        _context.Entry(article).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!_context.Articles.Any(e => e.Id == article.Id))
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
    /// Connect multiple Article Assessments records to Article
    /// </summary>
    public async Task ConnectArticleAssessments(
        ArticleWhereUniqueInput uniqueId,
        ArticleAssessmentWhereUniqueInput[] articleAssessmentsId
    )
    {
        var parent = await _context
            .Articles.Include(x => x.ArticleAssessments)
            .FirstOrDefaultAsync(x => x.Id == uniqueId.Id);
        if (parent == null)
        {
            throw new NotFoundException();
        }

        var articleAssessments = await _context
            .ArticleAssessments.Where(t => articleAssessmentsId.Select(x => x.Id).Contains(t.Id))
            .ToListAsync();
        if (articleAssessments.Count == 0)
        {
            throw new NotFoundException();
        }

        var articleAssessmentsToConnect = articleAssessments.Except(parent.ArticleAssessments);

        foreach (var articleAssessment in articleAssessmentsToConnect)
        {
            parent.ArticleAssessments.Add(articleAssessment);
        }

        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Disconnect multiple Article Assessments records from Article
    /// </summary>
    public async Task DisconnectArticleAssessments(
        ArticleWhereUniqueInput uniqueId,
        ArticleAssessmentWhereUniqueInput[] articleAssessmentsId
    )
    {
        var parent = await _context
            .Articles.Include(x => x.ArticleAssessments)
            .FirstOrDefaultAsync(x => x.Id == uniqueId.Id);
        if (parent == null)
        {
            throw new NotFoundException();
        }

        var articleAssessments = await _context
            .ArticleAssessments.Where(t => articleAssessmentsId.Select(x => x.Id).Contains(t.Id))
            .ToListAsync();

        foreach (var articleAssessment in articleAssessments)
        {
            parent.ArticleAssessments?.Remove(articleAssessment);
        }
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find multiple Article Assessments records for Article
    /// </summary>
    public async Task<List<ArticleAssessment>> FindArticleAssessments(
        ArticleWhereUniqueInput uniqueId,
        ArticleAssessmentFindManyArgs articleFindManyArgs
    )
    {
        var articleAssessments = await _context
            .ArticleAssessments.Where(m => m.ArticleId == uniqueId.Id)
            .ApplyWhere(articleFindManyArgs.Where)
            .ApplySkip(articleFindManyArgs.Skip)
            .ApplyTake(articleFindManyArgs.Take)
            .ApplyOrderBy(articleFindManyArgs.SortBy)
            .ToListAsync();

        return articleAssessments.Select(x => x.ToDto()).ToList();
    }

    /// <summary>
    /// Update multiple Article Assessments records for Article
    /// </summary>
    public async Task UpdateArticleAssessments(
        ArticleWhereUniqueInput uniqueId,
        ArticleAssessmentWhereUniqueInput[] articleAssessmentsId
    )
    {
        var article = await _context
            .Articles.Include(t => t.ArticleAssessments)
            .FirstOrDefaultAsync(x => x.Id == uniqueId.Id);
        if (article == null)
        {
            throw new NotFoundException();
        }

        var articleAssessments = await _context
            .ArticleAssessments.Where(a => articleAssessmentsId.Select(x => x.Id).Contains(a.Id))
            .ToListAsync();

        if (articleAssessments.Count == 0)
        {
            throw new NotFoundException();
        }

        article.ArticleAssessments = articleAssessments;
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Get a COMMON DETAILED DECLARATION record for ARTICLE OF THE DETAILED DECLARATION (CUSTOMS)
    /// </summary>
    public async Task<CommonDetailedDeclaration> GetCommonDetailedDeclaration(
        ArticleWhereUniqueInput uniqueId
    )
    {
        var article = await _context
            .Articles.Where(article => article.Id == uniqueId.Id)
            .Include(article => article.CommonDetailedDeclaration)
            .FirstOrDefaultAsync();
        if (article == null)
        {
            throw new NotFoundException();
        }
        return article.CommonDetailedDeclaration.ToDto();
    }

    /// <summary>
    /// Get a Tax record for Article
    /// </summary>
    public async Task<DetailedDeclarationTax> GetTax(ArticleWhereUniqueInput uniqueId)
    {
        var article = await _context
            .Articles.Where(article => article.Id == uniqueId.Id)
            .Include(article => article.Tax)
            .FirstOrDefaultAsync();
        if (article == null)
        {
            throw new NotFoundException();
        }
        return article.Tax.ToDto();
    }
}
