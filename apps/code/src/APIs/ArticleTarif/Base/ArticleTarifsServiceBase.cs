using Code.APIs;
using Code.APIs.Common;
using Code.APIs.Dtos;
using Code.APIs.Errors;
using Code.APIs.Extensions;
using Code.Infrastructure;
using Code.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Code.APIs;

public abstract class ArticleTarifsServiceBase : IArticleTarifsService
{
    protected readonly CodeDbContext _context;

    public ArticleTarifsServiceBase(CodeDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one ArticleTarif
    /// </summary>
    public async Task<ArticleTarif> CreateArticleTarif(ArticleTarifCreateInput createDto)
    {
        var articleTarif = new ArticleTarifDbModel
        {
            CodeCategorieTarif = createDto.CodeCategorieTarif,
            CodeProduitNeufEtUsage = createDto.CodeProduitNeufEtUsage,
            CodeSh = createDto.CodeSh,
            CodeTypeTarif = createDto.CodeTypeTarif,
            CreatedAt = createDto.CreatedAt,
            DateHeureModificationFinale = createDto.DateHeureModificationFinale,
            DateHeurePremierEnregistrement = createDto.DateHeurePremierEnregistrement,
            DetailsDroitsAdValoremCommeBaseTaxable =
                createDto.DetailsDroitsAdValoremCommeBaseTaxable,
            DetailsDroitsSpecifiquesCommeBaseTaxable =
                createDto.DetailsDroitsSpecifiquesCommeBaseTaxable,
            DetailsTarifAdValorem = createDto.DetailsTarifAdValorem,
            DetailsTarifSpecifique = createDto.DetailsTarifSpecifique,
            ModificateurFinalId = createDto.ModificateurFinalId,
            PremierEnregistrantId = createDto.PremierEnregistrantId,
            Sequence = createDto.Sequence,
            SuppressionOn = createDto.SuppressionOn,
            UpdatedAt = createDto.UpdatedAt,
            UtiliseOn = createDto.UtiliseOn
        };

        if (createDto.Id != null)
        {
            articleTarif.Id = createDto.Id;
        }

        _context.ArticleTarifs.Add(articleTarif);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<ArticleTarifDbModel>(articleTarif.Id);

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one ArticleTarif
    /// </summary>
    public async Task DeleteArticleTarif(ArticleTarifWhereUniqueInput uniqueId)
    {
        var articleTarif = await _context.ArticleTarifs.FindAsync(uniqueId.Id);
        if (articleTarif == null)
        {
            throw new NotFoundException();
        }

        _context.ArticleTarifs.Remove(articleTarif);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many ArticleTarifs
    /// </summary>
    public async Task<List<ArticleTarif>> ArticleTarifs(ArticleTarifFindManyArgs findManyArgs)
    {
        var articleTarifs = await _context
            .ArticleTarifs.ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return articleTarifs.ConvertAll(articleTarif => articleTarif.ToDto());
    }

    /// <summary>
    /// Meta data about ArticleTarif records
    /// </summary>
    public async Task<MetadataDto> ArticleTarifsMeta(ArticleTarifFindManyArgs findManyArgs)
    {
        var count = await _context.ArticleTarifs.ApplyWhere(findManyArgs.Where).CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one ArticleTarif
    /// </summary>
    public async Task<ArticleTarif> ArticleTarif(ArticleTarifWhereUniqueInput uniqueId)
    {
        var articleTarifs = await this.ArticleTarifs(
            new ArticleTarifFindManyArgs { Where = new ArticleTarifWhereInput { Id = uniqueId.Id } }
        );
        var articleTarif = articleTarifs.FirstOrDefault();
        if (articleTarif == null)
        {
            throw new NotFoundException();
        }

        return articleTarif;
    }

    /// <summary>
    /// Update one ArticleTarif
    /// </summary>
    public async Task UpdateArticleTarif(
        ArticleTarifWhereUniqueInput uniqueId,
        ArticleTarifUpdateInput updateDto
    )
    {
        var articleTarif = updateDto.ToModel(uniqueId);

        _context.Entry(articleTarif).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!_context.ArticleTarifs.Any(e => e.Id == articleTarif.Id))
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
