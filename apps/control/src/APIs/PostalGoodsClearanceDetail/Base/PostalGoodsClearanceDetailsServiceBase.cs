using Control.APIs;
using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Control.APIs.Extensions;
using Control.Infrastructure;
using Control.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Control.APIs;

public abstract class PostalGoodsClearanceDetailsServiceBase : IPostalGoodsClearanceDetailsService
{
    protected readonly ControlDbContext _context;

    public PostalGoodsClearanceDetailsServiceBase(ControlDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one Postal Goods Clearance Detail
    /// </summary>
    public async Task<PostalGoodsClearanceDetail> CreatePostalGoodsClearanceDetail(
        PostalGoodsClearanceDetailCreateInput createDto
    )
    {
        var postalGoodsClearanceDetail = new PostalGoodsClearanceDetailDbModel
        {
            AmountNcyOfTheInvoiceOfTheArticle = createDto.AmountNcyOfTheInvoiceOfTheArticle,
            AmountOfTheInvoiceOfTheArticle = createDto.AmountOfTheInvoiceOfTheArticle,
            ArticleName = createDto.ArticleName,
            ArticleNumber = createDto.ArticleNumber,
            CountryCodeOfOrigin = createDto.CountryCodeOfOrigin,
            CreatedAt = createDto.CreatedAt,
            CurrencyCodeOfTheInvoiceOfTheArticle = createDto.CurrencyCodeOfTheInvoiceOfTheArticle,
            DateAndTimeOfFinalModification = createDto.DateAndTimeOfFinalModification,
            DateAndTimeOfFirstRegistration = createDto.DateAndTimeOfFirstRegistration,
            DeclaredInsuranceAmount = createDto.DeclaredInsuranceAmount,
            ExchangeRateOfTheInvoiceOfTheArticle = createDto.ExchangeRateOfTheInvoiceOfTheArticle,
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
            postalGoodsClearanceDetail.Id = createDto.Id;
        }
        if (createDto.PostalGoodsClearance != null)
        {
            postalGoodsClearanceDetail.PostalGoodsClearance = await _context
                .PostalGoodsClearances.Where(postalGoodsClearance =>
                    createDto.PostalGoodsClearance.Id == postalGoodsClearance.Id
                )
                .FirstOrDefaultAsync();
        }

        _context.PostalGoodsClearanceDetails.Add(postalGoodsClearanceDetail);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<PostalGoodsClearanceDetailDbModel>(
            postalGoodsClearanceDetail.Id
        );

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one Postal Goods Clearance Detail
    /// </summary>
    public async Task DeletePostalGoodsClearanceDetail(
        PostalGoodsClearanceDetailWhereUniqueInput uniqueId
    )
    {
        var postalGoodsClearanceDetail = await _context.PostalGoodsClearanceDetails.FindAsync(
            uniqueId.Id
        );
        if (postalGoodsClearanceDetail == null)
        {
            throw new NotFoundException();
        }

        _context.PostalGoodsClearanceDetails.Remove(postalGoodsClearanceDetail);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many DETAILS OF THE CUSTOMS CLEARANCE OF POSTAL GOODSItems
    /// </summary>
    public async Task<List<PostalGoodsClearanceDetail>> PostalGoodsClearanceDetails(
        PostalGoodsClearanceDetailFindManyArgs findManyArgs
    )
    {
        var postalGoodsClearanceDetails = await _context
            .PostalGoodsClearanceDetails.Include(x => x.PostalGoodsClearance)
            .ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return postalGoodsClearanceDetails.ConvertAll(postalGoodsClearanceDetail =>
            postalGoodsClearanceDetail.ToDto()
        );
    }

    /// <summary>
    /// Meta data about Postal Goods Clearance Detail records
    /// </summary>
    public async Task<MetadataDto> PostalGoodsClearanceDetailsMeta(
        PostalGoodsClearanceDetailFindManyArgs findManyArgs
    )
    {
        var count = await _context
            .PostalGoodsClearanceDetails.ApplyWhere(findManyArgs.Where)
            .CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one Postal Goods Clearance Detail
    /// </summary>
    public async Task<PostalGoodsClearanceDetail> PostalGoodsClearanceDetail(
        PostalGoodsClearanceDetailWhereUniqueInput uniqueId
    )
    {
        var postalGoodsClearanceDetails = await this.PostalGoodsClearanceDetails(
            new PostalGoodsClearanceDetailFindManyArgs
            {
                Where = new PostalGoodsClearanceDetailWhereInput { Id = uniqueId.Id }
            }
        );
        var postalGoodsClearanceDetail = postalGoodsClearanceDetails.FirstOrDefault();
        if (postalGoodsClearanceDetail == null)
        {
            throw new NotFoundException();
        }

        return postalGoodsClearanceDetail;
    }

    /// <summary>
    /// Update one Postal Goods Clearance Detail
    /// </summary>
    public async Task UpdatePostalGoodsClearanceDetail(
        PostalGoodsClearanceDetailWhereUniqueInput uniqueId,
        PostalGoodsClearanceDetailUpdateInput updateDto
    )
    {
        var postalGoodsClearanceDetail = updateDto.ToModel(uniqueId);

        _context.Entry(postalGoodsClearanceDetail).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (
                !_context.PostalGoodsClearanceDetails.Any(e =>
                    e.Id == postalGoodsClearanceDetail.Id
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
    /// Get a Postal Goods Clearance record for Postal Goods Clearance Detail
    /// </summary>
    public async Task<PostalGoodsClearance> GetPostalGoodsClearance(
        PostalGoodsClearanceDetailWhereUniqueInput uniqueId
    )
    {
        var postalGoodsClearanceDetail = await _context
            .PostalGoodsClearanceDetails.Where(postalGoodsClearanceDetail =>
                postalGoodsClearanceDetail.Id == uniqueId.Id
            )
            .Include(postalGoodsClearanceDetail => postalGoodsClearanceDetail.PostalGoodsClearance)
            .FirstOrDefaultAsync();
        if (postalGoodsClearanceDetail == null)
        {
            throw new NotFoundException();
        }
        return postalGoodsClearanceDetail.PostalGoodsClearance.ToDto();
    }
}
