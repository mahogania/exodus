using Control.APIs;
using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Control.APIs.Extensions;
using Control.Infrastructure;
using Control.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Control.APIs;

public abstract class DetailedDeclarationTaxesServiceBase : IDetailedDeclarationTaxesService
{
    protected readonly ControlDbContext _context;

    public DetailedDeclarationTaxesServiceBase(ControlDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one Detailed Declaration Tax
    /// </summary>
    public async Task<DetailedDeclarationTax> CreateDetailedDeclarationTax(
        DetailedDeclarationTaxCreateInput createDto
    )
    {
        var detailedDeclarationTax = new DetailedDeclarationTaxDbModel
        {
            ArticleNumber = createDto.ArticleNumber,
            BasicTaxAmount = createDto.BasicTaxAmount,
            BasicTaxableBaseAmount = createDto.BasicTaxableBaseAmount,
            BasicTaxationRate = createDto.BasicTaxationRate,
            CautionAmountAfterExemptionOfGuarantee =
                createDto.CautionAmountAfterExemptionOfGuarantee,
            CreatedAt = createDto.CreatedAt,
            DateAndTimeOfFinalModification = createDto.DateAndTimeOfFinalModification,
            DateAndTimeOfFirstRegistration = createDto.DateAndTimeOfFirstRegistration,
            ExemptAmount = createDto.ExemptAmount,
            ExemptTaxationRate = createDto.ExemptTaxationRate,
            ExemptionBaseAmount = createDto.ExemptionBaseAmount,
            ExemptionTypeCode = createDto.ExemptionTypeCode,
            FinalModifierSId = createDto.FinalModifierSId,
            IdDuPremierEnregistrant = createDto.IdDuPremierEnregistrant,
            PaidTaxAmount = createDto.PaidTaxAmount,
            PaymentTypeCode = createDto.PaymentTypeCode,
            RectificationFrequency = createDto.RectificationFrequency,
            ReferenceNumber = createDto.ReferenceNumber,
            SuppressionOn = createDto.SuppressionOn,
            TariffCategoryCode = createDto.TariffCategoryCode,
            TaxAdvantageCode = createDto.TaxAdvantageCode,
            TaxAmount = createDto.TaxAmount,
            TaxCode = createDto.TaxCode,
            TaxableBaseAmount = createDto.TaxableBaseAmount,
            TaxationRate = createDto.TaxationRate,
            UpdatedAt = createDto.UpdatedAt
        };

        if (createDto.Id != null)
        {
            detailedDeclarationTax.Id = createDto.Id;
        }
        if (createDto.Article != null)
        {
            detailedDeclarationTax.Article = await _context
                .Articles.Where(article => createDto.Article.Id == article.Id)
                .FirstOrDefaultAsync();
        }

        _context.DetailedDeclarationTaxes.Add(detailedDeclarationTax);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<DetailedDeclarationTaxDbModel>(
            detailedDeclarationTax.Id
        );

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one Detailed Declaration Tax
    /// </summary>
    public async Task DeleteDetailedDeclarationTax(DetailedDeclarationTaxWhereUniqueInput uniqueId)
    {
        var detailedDeclarationTax = await _context.DetailedDeclarationTaxes.FindAsync(uniqueId.Id);
        if (detailedDeclarationTax == null)
        {
            throw new NotFoundException();
        }

        _context.DetailedDeclarationTaxes.Remove(detailedDeclarationTax);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many CUSTOMS DETAILED DECLARATION TAXES
    /// </summary>
    public async Task<List<DetailedDeclarationTax>> DetailedDeclarationTaxes(
        DetailedDeclarationTaxFindManyArgs findManyArgs
    )
    {
        var detailedDeclarationTaxes = await _context
            .DetailedDeclarationTaxes.Include(x => x.Article)
            .ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return detailedDeclarationTaxes.ConvertAll(detailedDeclarationTax =>
            detailedDeclarationTax.ToDto()
        );
    }

    /// <summary>
    /// Meta data about Detailed Declaration Tax records
    /// </summary>
    public async Task<MetadataDto> DetailedDeclarationTaxesMeta(
        DetailedDeclarationTaxFindManyArgs findManyArgs
    )
    {
        var count = await _context
            .DetailedDeclarationTaxes.ApplyWhere(findManyArgs.Where)
            .CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one Detailed Declaration Tax
    /// </summary>
    public async Task<DetailedDeclarationTax> DetailedDeclarationTax(
        DetailedDeclarationTaxWhereUniqueInput uniqueId
    )
    {
        var detailedDeclarationTaxes = await this.DetailedDeclarationTaxes(
            new DetailedDeclarationTaxFindManyArgs
            {
                Where = new DetailedDeclarationTaxWhereInput { Id = uniqueId.Id }
            }
        );
        var detailedDeclarationTax = detailedDeclarationTaxes.FirstOrDefault();
        if (detailedDeclarationTax == null)
        {
            throw new NotFoundException();
        }

        return detailedDeclarationTax;
    }

    /// <summary>
    /// Update one Detailed Declaration Tax
    /// </summary>
    public async Task UpdateDetailedDeclarationTax(
        DetailedDeclarationTaxWhereUniqueInput uniqueId,
        DetailedDeclarationTaxUpdateInput updateDto
    )
    {
        var detailedDeclarationTax = updateDto.ToModel(uniqueId);

        _context.Entry(detailedDeclarationTax).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!_context.DetailedDeclarationTaxes.Any(e => e.Id == detailedDeclarationTax.Id))
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
    /// Get a Article record for Detailed Declaration Tax
    /// </summary>
    public async Task<Article> GetArticle(DetailedDeclarationTaxWhereUniqueInput uniqueId)
    {
        var detailedDeclarationTax = await _context
            .DetailedDeclarationTaxes.Where(detailedDeclarationTax =>
                detailedDeclarationTax.Id == uniqueId.Id
            )
            .Include(detailedDeclarationTax => detailedDeclarationTax.Article)
            .FirstOrDefaultAsync();
        if (detailedDeclarationTax == null)
        {
            throw new NotFoundException();
        }
        return detailedDeclarationTax.Article.ToDto();
    }
}
