using Evaluation.APIs;
using Evaluation.APIs.Common;
using Evaluation.APIs.Dtos;
using Evaluation.APIs.Errors;
using Evaluation.APIs.Extensions;
using Evaluation.Infrastructure;
using Evaluation.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Evaluation.APIs;

public abstract class ItemsServiceBase : IItemsService
{
    protected readonly EvaluationDbContext _context;

    public ItemsServiceBase(EvaluationDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one Item
    /// </summary>
    public async Task<Item> CreateItem(ItemCreateInput createDto)
    {
        var item = new ItemDbModel
        {
            CodeDeDeviseDDuitDeLArticle = createDto.CodeDeDeviseDDuitDeLArticle,
            CodeDeDeviseDeLAssuranceDeLArticle = createDto.CodeDeDeviseDeLAssuranceDeLArticle,
            CodeDeDeviseDeLaFactureDeLArticle = createDto.CodeDeDeviseDeLaFactureDeLArticle,
            CodeDeDeviseDeLaValeurMercurialeDeLArticle =
                createDto.CodeDeDeviseDeLaValeurMercurialeDeLArticle,
            CodeDeDeviseDesAutresFraisDeLArticle = createDto.CodeDeDeviseDesAutresFraisDeLArticle,
            CodeDeDeviseDuFretDeLArticle = createDto.CodeDeDeviseDuFretDeLArticle,
            CodeDeTypeDeLaValeurMercurialeDeLArticle =
                createDto.CodeDeTypeDeLaValeurMercurialeDeLArticle,
            CreatedAt = createDto.CreatedAt,
            DateEtHeureDeModificationFinale = createDto.DateEtHeureDeModificationFinale,
            DateEtHeureDePremierEnregistrement = createDto.DateEtHeureDePremierEnregistrement,
            FrQuenceDeRectification = createDto.FrQuenceDeRectification,
            IdDuModificateurFinal = createDto.IdDuModificateurFinal,
            IdDuPremierEnregistrant = createDto.IdDuPremierEnregistrant,
            MontantDDuitDeLArticle = createDto.MontantDDuitDeLArticle,
            MontantDeLAssuranceDeLArticle = createDto.MontantDeLAssuranceDeLArticle,
            MontantDeLaFactureDeLArticle = createDto.MontantDeLaFactureDeLArticle,
            MontantDesAutresFraisDeLArticle = createDto.MontantDesAutresFraisDeLArticle,
            MontantDuFretDeLArticle = createDto.MontantDuFretDeLArticle,
            MontantNcyDDuitDeLArticle = createDto.MontantNcyDDuitDeLArticle,
            MontantNcyDeLAssuranceDeLArticle = createDto.MontantNcyDeLAssuranceDeLArticle,
            MontantNcyDeLValuationDeValeurDeLArticle =
                createDto.MontantNcyDeLValuationDeValeurDeLArticle,
            MontantNcyDeLaFactureDeLArticle = createDto.MontantNcyDeLaFactureDeLArticle,
            MontantNcyDeLaValeurBoursiReDeLArticle =
                createDto.MontantNcyDeLaValeurBoursiReDeLArticle,
            MontantNcyDesAutresFraisDeLArticle = createDto.MontantNcyDesAutresFraisDeLArticle,
            MontantNcyDuFretDeLArticle = createDto.MontantNcyDuFretDeLArticle,
            MontantNycDeLaBaseTaxableDeLArticle = createDto.MontantNycDeLaBaseTaxableDeLArticle,
            MontantUnitaireDeLaValeurBoursiReDeLArticle =
                createDto.MontantUnitaireDeLaValeurBoursiReDeLArticle,
            MontantUsdDeLValuationDeValeurDeLArticle =
                createDto.MontantUsdDeLValuationDeValeurDeLArticle,
            MontantUsdDeLaBaseTaxableDeLArticle = createDto.MontantUsdDeLaBaseTaxableDeLArticle,
            MontantUsdDeLaFactureDeLArticle = createDto.MontantUsdDeLaFactureDeLArticle,
            MontantUsdDeLaValeurBoursiReDeLArticle =
                createDto.MontantUsdDeLaValeurBoursiReDeLArticle,
            NDArticle = createDto.NDArticle,
            NDeRfRence = createDto.NDeRfRence,
            SuppressionOn = createDto.SuppressionOn,
            TauxDeChangeDeLAssuranceDeLArticle = createDto.TauxDeChangeDeLAssuranceDeLArticle,
            TauxDeChangeDeLaDDuctionDeLArticle = createDto.TauxDeChangeDeLaDDuctionDeLArticle,
            TauxDeChangeDeLaFactureDeLArticle = createDto.TauxDeChangeDeLaFactureDeLArticle,
            TauxDeChangeDesAutresFraisDeLArticle = createDto.TauxDeChangeDesAutresFraisDeLArticle,
            TauxDeChangeDuFretDeLArticle = createDto.TauxDeChangeDuFretDeLArticle,
            UpdatedAt = createDto.UpdatedAt,
            ValeurBasiqueDeLaValeurBoursiReDeLArticle =
                createDto.ValeurBasiqueDeLaValeurBoursiReDeLArticle
        };

        if (createDto.Id != null)
        {
            item.Id = createDto.Id;
        }

        _context.Items.Add(item);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<ItemDbModel>(item.Id);

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one Item
    /// </summary>
    public async Task DeleteItem(ItemWhereUniqueInput uniqueId)
    {
        var item = await _context.Items.FindAsync(uniqueId.Id);
        if (item == null)
        {
            throw new NotFoundException();
        }

        _context.Items.Remove(item);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many Items
    /// </summary>
    public async Task<List<Item>> Items(ItemFindManyArgs findManyArgs)
    {
        var items = await _context
            .Items.ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return items.ConvertAll(item => item.ToDto());
    }

    /// <summary>
    /// Meta data about Item records
    /// </summary>
    public async Task<MetadataDto> ItemsMeta(ItemFindManyArgs findManyArgs)
    {
        var count = await _context.Items.ApplyWhere(findManyArgs.Where).CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one Item
    /// </summary>
    public async Task<Item> Item(ItemWhereUniqueInput uniqueId)
    {
        var items = await this.Items(
            new ItemFindManyArgs { Where = new ItemWhereInput { Id = uniqueId.Id } }
        );
        var item = items.FirstOrDefault();
        if (item == null)
        {
            throw new NotFoundException();
        }

        return item;
    }

    /// <summary>
    /// Update one Item
    /// </summary>
    public async Task UpdateItem(ItemWhereUniqueInput uniqueId, ItemUpdateInput updateDto)
    {
        var item = updateDto.ToModel(uniqueId);

        _context.Entry(item).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!_context.Items.Any(e => e.Id == item.Id))
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
