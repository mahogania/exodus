using Clre.APIs;
using Clre.APIs.Common;
using Clre.APIs.Dtos;
using Clre.APIs.Errors;
using Clre.APIs.Extensions;
using Clre.Infrastructure;
using Clre.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Clre.APIs;

public abstract class ArticleOfTheDetailedDeclarationCustomsItemsServiceBase
    : IArticleOfTheDetailedDeclarationCustomsItemsService
{
    protected readonly ClreDbContext _context;

    public ArticleOfTheDetailedDeclarationCustomsItemsServiceBase(ClreDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one ARTICLE OF THE DETAILED DECLARATION (CUSTOMS)
    /// </summary>
    public async Task<ArticleOfTheDetailedDeclarationCustoms> CreateArticleOfTheDetailedDeclarationCustoms(
        ArticleOfTheDetailedDeclarationCustomsCreateInput createDto
    )
    {
        var articleOfTheDetailedDeclarationCustoms =
            new ArticleOfTheDetailedDeclarationCustomsDbModel
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
                SpecificCodeForClassificationOfGoods =
                    createDto.SpecificCodeForClassificationOfGoods,
                StartDateOfApcApproval = createDto.StartDateOfApcApproval,
                StatisticalValue = createDto.StatisticalValue,
                SuperiorArticleNumber = createDto.SuperiorArticleNumber,
                TaxationQuantity = createDto.TaxationQuantity,
                TaxationUnit = createDto.TaxationUnit,
                TransactionArticleName = createDto.TransactionArticleName,
                UpdatedAt = createDto.UpdatedAt,
                ValueAssessmentMethodCode = createDto.ValueAssessmentMethodCode,
                VehicleOn = createDto.VehicleOn,
                WarrantyExemptionAuthorizationNumber =
                    createDto.WarrantyExemptionAuthorizationNumber
            };

        if (createDto.Id != null)
        {
            articleOfTheDetailedDeclarationCustoms.Id = createDto.Id;
        }

        _context.ArticleOfTheDetailedDeclarationCustomsItems.Add(
            articleOfTheDetailedDeclarationCustoms
        );
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<ArticleOfTheDetailedDeclarationCustomsDbModel>(
            articleOfTheDetailedDeclarationCustoms.Id
        );

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one ARTICLE OF THE DETAILED DECLARATION (CUSTOMS)
    /// </summary>
    public async Task DeleteArticleOfTheDetailedDeclarationCustoms(
        ArticleOfTheDetailedDeclarationCustomsWhereUniqueInput uniqueId
    )
    {
        var articleOfTheDetailedDeclarationCustoms =
            await _context.ArticleOfTheDetailedDeclarationCustomsItems.FindAsync(uniqueId.Id);
        if (articleOfTheDetailedDeclarationCustoms == null)
        {
            throw new NotFoundException();
        }

        _context.ArticleOfTheDetailedDeclarationCustomsItems.Remove(
            articleOfTheDetailedDeclarationCustoms
        );
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many ARTICLE OF THE DETAILED DECLARATION (CUSTOMS)s
    /// </summary>
    public async Task<
        List<ArticleOfTheDetailedDeclarationCustoms>
    > ArticleOfTheDetailedDeclarationCustomsItems(
        ArticleOfTheDetailedDeclarationCustomsFindManyArgs findManyArgs
    )
    {
        var articleOfTheDetailedDeclarationCustomsItems = await _context
            .ArticleOfTheDetailedDeclarationCustomsItems.ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return articleOfTheDetailedDeclarationCustomsItems.ConvertAll(
            articleOfTheDetailedDeclarationCustoms => articleOfTheDetailedDeclarationCustoms.ToDto()
        );
    }

    /// <summary>
    /// Meta data about ARTICLE OF THE DETAILED DECLARATION (CUSTOMS) records
    /// </summary>
    public async Task<MetadataDto> ArticleOfTheDetailedDeclarationCustomsItemsMeta(
        ArticleOfTheDetailedDeclarationCustomsFindManyArgs findManyArgs
    )
    {
        var count = await _context
            .ArticleOfTheDetailedDeclarationCustomsItems.ApplyWhere(findManyArgs.Where)
            .CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one ARTICLE OF THE DETAILED DECLARATION (CUSTOMS)
    /// </summary>
    public async Task<ArticleOfTheDetailedDeclarationCustoms> ArticleOfTheDetailedDeclarationCustoms(
        ArticleOfTheDetailedDeclarationCustomsWhereUniqueInput uniqueId
    )
    {
        var articleOfTheDetailedDeclarationCustomsItems =
            await this.ArticleOfTheDetailedDeclarationCustomsItems(
                new ArticleOfTheDetailedDeclarationCustomsFindManyArgs
                {
                    Where = new ArticleOfTheDetailedDeclarationCustomsWhereInput
                    {
                        Id = uniqueId.Id
                    }
                }
            );
        var articleOfTheDetailedDeclarationCustoms =
            articleOfTheDetailedDeclarationCustomsItems.FirstOrDefault();
        if (articleOfTheDetailedDeclarationCustoms == null)
        {
            throw new NotFoundException();
        }

        return articleOfTheDetailedDeclarationCustoms;
    }

    /// <summary>
    /// Update one ARTICLE OF THE DETAILED DECLARATION (CUSTOMS)
    /// </summary>
    public async Task UpdateArticleOfTheDetailedDeclarationCustoms(
        ArticleOfTheDetailedDeclarationCustomsWhereUniqueInput uniqueId,
        ArticleOfTheDetailedDeclarationCustomsUpdateInput updateDto
    )
    {
        var articleOfTheDetailedDeclarationCustoms = updateDto.ToModel(uniqueId);

        _context.Entry(articleOfTheDetailedDeclarationCustoms).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (
                !_context.ArticleOfTheDetailedDeclarationCustomsItems.Any(e =>
                    e.Id == articleOfTheDetailedDeclarationCustoms.Id
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
