using Clre.APIs;
using Clre.APIs.Common;
using Clre.APIs.Dtos;
using Clre.APIs.Errors;
using Clre.APIs.Extensions;
using Clre.Infrastructure;
using Clre.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Clre.APIs;

public abstract class DetailsOfTheCustomsClearanceOfPostalGoodsItemsServiceBase
    : IDetailsOfTheCustomsClearanceOfPostalGoodsItemsService
{
    protected readonly ClreDbContext _context;

    public DetailsOfTheCustomsClearanceOfPostalGoodsItemsServiceBase(ClreDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one DETAILS OF THE CUSTOMS CLEARANCE OF POSTAL GOODS
    /// </summary>
    public async Task<DetailsOfTheCustomsClearanceOfPostalGoods> CreateDetailsOfTheCustomsClearanceOfPostalGoods(
        DetailsOfTheCustomsClearanceOfPostalGoodsCreateInput createDto
    )
    {
        var detailsOfTheCustomsClearanceOfPostalGoods =
            new DetailsOfTheCustomsClearanceOfPostalGoodsDbModel
            {
                AmountNcyOfTheInvoiceOfTheArticle = createDto.AmountNcyOfTheInvoiceOfTheArticle,
                AmountOfTheInvoiceOfTheArticle = createDto.AmountOfTheInvoiceOfTheArticle,
                ArticleName = createDto.ArticleName,
                ArticleNumber = createDto.ArticleNumber,
                CountryCodeOfOrigin = createDto.CountryCodeOfOrigin,
                CreatedAt = createDto.CreatedAt,
                CurrencyCodeOfTheInvoiceOfTheArticle =
                    createDto.CurrencyCodeOfTheInvoiceOfTheArticle,
                DateAndTimeOfFinalModification = createDto.DateAndTimeOfFinalModification,
                DateAndTimeOfFirstRegistration = createDto.DateAndTimeOfFirstRegistration,
                DeclaredInsuranceAmount = createDto.DeclaredInsuranceAmount,
                ExchangeRateOfTheInvoiceOfTheArticle =
                    createDto.ExchangeRateOfTheInvoiceOfTheArticle,
                FinalModifierSId = createDto.FinalModifierSId,
                FirstRegistrantSId = createDto.FirstRegistrantSId,
                LiquidatedShCode = createDto.LiquidatedShCode,
                NetWeightOfTheArticle = createDto.NetWeightOfTheArticle,
                Quantity = createDto.Quantity,
                RequestNumberOfTheCustomsClearanceOfPostalParcels =
                    createDto.RequestNumberOfTheCustomsClearanceOfPostalParcels,
                RevisedDescriptionOfTheArticle = createDto.RevisedDescriptionOfTheArticle,
                SequenceNumber = createDto.SequenceNumber,
                ShCode = createDto.ShCode,
                SuppressionOn = createDto.SuppressionOn,
                TotalWeightKg = createDto.TotalWeightKg,
                UpdatedAt = createDto.UpdatedAt
            };

        if (createDto.Id != null)
        {
            detailsOfTheCustomsClearanceOfPostalGoods.Id = createDto.Id;
        }

        _context.DetailsOfTheCustomsClearanceOfPostalGoodsItems.Add(
            detailsOfTheCustomsClearanceOfPostalGoods
        );
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<DetailsOfTheCustomsClearanceOfPostalGoodsDbModel>(
            detailsOfTheCustomsClearanceOfPostalGoods.Id
        );

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one DETAILS OF THE CUSTOMS CLEARANCE OF POSTAL GOODS
    /// </summary>
    public async Task DeleteDetailsOfTheCustomsClearanceOfPostalGoods(
        DetailsOfTheCustomsClearanceOfPostalGoodsWhereUniqueInput uniqueId
    )
    {
        var detailsOfTheCustomsClearanceOfPostalGoods =
            await _context.DetailsOfTheCustomsClearanceOfPostalGoodsItems.FindAsync(uniqueId.Id);
        if (detailsOfTheCustomsClearanceOfPostalGoods == null)
        {
            throw new NotFoundException();
        }

        _context.DetailsOfTheCustomsClearanceOfPostalGoodsItems.Remove(
            detailsOfTheCustomsClearanceOfPostalGoods
        );
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many DETAILS OF THE CUSTOMS CLEARANCE OF POSTAL GOODSItems
    /// </summary>
    public async Task<
        List<DetailsOfTheCustomsClearanceOfPostalGoods>
    > DetailsOfTheCustomsClearanceOfPostalGoodsItems(
        DetailsOfTheCustomsClearanceOfPostalGoodsFindManyArgs findManyArgs
    )
    {
        var detailsOfTheCustomsClearanceOfPostalGoodsItems = await _context
            .DetailsOfTheCustomsClearanceOfPostalGoodsItems.ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return detailsOfTheCustomsClearanceOfPostalGoodsItems.ConvertAll(
            detailsOfTheCustomsClearanceOfPostalGoods =>
                detailsOfTheCustomsClearanceOfPostalGoods.ToDto()
        );
    }

    /// <summary>
    /// Meta data about DETAILS OF THE CUSTOMS CLEARANCE OF POSTAL GOODS records
    /// </summary>
    public async Task<MetadataDto> DetailsOfTheCustomsClearanceOfPostalGoodsItemsMeta(
        DetailsOfTheCustomsClearanceOfPostalGoodsFindManyArgs findManyArgs
    )
    {
        var count = await _context
            .DetailsOfTheCustomsClearanceOfPostalGoodsItems.ApplyWhere(findManyArgs.Where)
            .CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one DETAILS OF THE CUSTOMS CLEARANCE OF POSTAL GOODS
    /// </summary>
    public async Task<DetailsOfTheCustomsClearanceOfPostalGoods> DetailsOfTheCustomsClearanceOfPostalGoods(
        DetailsOfTheCustomsClearanceOfPostalGoodsWhereUniqueInput uniqueId
    )
    {
        var detailsOfTheCustomsClearanceOfPostalGoodsItems =
            await this.DetailsOfTheCustomsClearanceOfPostalGoodsItems(
                new DetailsOfTheCustomsClearanceOfPostalGoodsFindManyArgs
                {
                    Where = new DetailsOfTheCustomsClearanceOfPostalGoodsWhereInput
                    {
                        Id = uniqueId.Id
                    }
                }
            );
        var detailsOfTheCustomsClearanceOfPostalGoods =
            detailsOfTheCustomsClearanceOfPostalGoodsItems.FirstOrDefault();
        if (detailsOfTheCustomsClearanceOfPostalGoods == null)
        {
            throw new NotFoundException();
        }

        return detailsOfTheCustomsClearanceOfPostalGoods;
    }

    /// <summary>
    /// Update one DETAILS OF THE CUSTOMS CLEARANCE OF POSTAL GOODS
    /// </summary>
    public async Task UpdateDetailsOfTheCustomsClearanceOfPostalGoods(
        DetailsOfTheCustomsClearanceOfPostalGoodsWhereUniqueInput uniqueId,
        DetailsOfTheCustomsClearanceOfPostalGoodsUpdateInput updateDto
    )
    {
        var detailsOfTheCustomsClearanceOfPostalGoods = updateDto.ToModel(uniqueId);

        _context.Entry(detailsOfTheCustomsClearanceOfPostalGoods).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (
                !_context.DetailsOfTheCustomsClearanceOfPostalGoodsItems.Any(e =>
                    e.Id == detailsOfTheCustomsClearanceOfPostalGoods.Id
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
