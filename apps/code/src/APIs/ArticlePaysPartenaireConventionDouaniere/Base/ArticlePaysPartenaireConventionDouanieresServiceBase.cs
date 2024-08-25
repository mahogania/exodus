using Code.APIs;
using Code.APIs.Common;
using Code.APIs.Dtos;
using Code.APIs.Errors;
using Code.APIs.Extensions;
using Code.Infrastructure;
using Code.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Code.APIs;

public abstract class ArticlePaysPartenaireConventionDouanieresServiceBase
    : IArticlePaysPartenaireConventionDouanieresService
{
    protected readonly CodeDbContext _context;

    public ArticlePaysPartenaireConventionDouanieresServiceBase(CodeDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one ArticlePaysPartenaireConventionDouaniere
    /// </summary>
    public async Task<ArticlePaysPartenaireConventionDouaniere> CreateArticlePaysPartenaireConventionDouaniere(
        ArticlePaysPartenaireConventionDouaniereCreateInput createDto
    )
    {
        var articlePaysPartenaireConventionDouaniere =
            new ArticlePaysPartenaireConventionDouaniereDbModel
            {
                CodeCategorieTarif = createDto.CodeCategorieTarif,
                CodePaysPreferentiel = createDto.CodePaysPreferentiel,
                CodePreferentiel = createDto.CodePreferentiel,
                CodeSh = createDto.CodeSh,
                CreatedAt = createDto.CreatedAt,
                DateHeureModificationFinale = createDto.DateHeureModificationFinale,
                DateHeurePremierEnregistrement = createDto.DateHeurePremierEnregistrement,
                ModificateurFinalId = createDto.ModificateurFinalId,
                PremierEnregistrantId = createDto.PremierEnregistrantId,
                Sequence = createDto.Sequence,
                SuppressionOn = createDto.SuppressionOn,
                UpdatedAt = createDto.UpdatedAt
            };

        if (createDto.Id != null)
        {
            articlePaysPartenaireConventionDouaniere.Id = createDto.Id;
        }

        _context.ArticlePaysPartenaireConventionDouanieres.Add(
            articlePaysPartenaireConventionDouaniere
        );
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<ArticlePaysPartenaireConventionDouaniereDbModel>(
            articlePaysPartenaireConventionDouaniere.Id
        );

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one ArticlePaysPartenaireConventionDouaniere
    /// </summary>
    public async Task DeleteArticlePaysPartenaireConventionDouaniere(
        ArticlePaysPartenaireConventionDouaniereWhereUniqueInput uniqueId
    )
    {
        var articlePaysPartenaireConventionDouaniere =
            await _context.ArticlePaysPartenaireConventionDouanieres.FindAsync(uniqueId.Id);
        if (articlePaysPartenaireConventionDouaniere == null)
        {
            throw new NotFoundException();
        }

        _context.ArticlePaysPartenaireConventionDouanieres.Remove(
            articlePaysPartenaireConventionDouaniere
        );
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many ArticlePaysPartenaireConventionDouanieres
    /// </summary>
    public async Task<
        List<ArticlePaysPartenaireConventionDouaniere>
    > ArticlePaysPartenaireConventionDouanieres(
        ArticlePaysPartenaireConventionDouaniereFindManyArgs findManyArgs
    )
    {
        var articlePaysPartenaireConventionDouanieres = await _context
            .ArticlePaysPartenaireConventionDouanieres.ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return articlePaysPartenaireConventionDouanieres.ConvertAll(
            articlePaysPartenaireConventionDouaniere =>
                articlePaysPartenaireConventionDouaniere.ToDto()
        );
    }

    /// <summary>
    /// Meta data about ArticlePaysPartenaireConventionDouaniere records
    /// </summary>
    public async Task<MetadataDto> ArticlePaysPartenaireConventionDouanieresMeta(
        ArticlePaysPartenaireConventionDouaniereFindManyArgs findManyArgs
    )
    {
        var count = await _context
            .ArticlePaysPartenaireConventionDouanieres.ApplyWhere(findManyArgs.Where)
            .CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one ArticlePaysPartenaireConventionDouaniere
    /// </summary>
    public async Task<ArticlePaysPartenaireConventionDouaniere> ArticlePaysPartenaireConventionDouaniere(
        ArticlePaysPartenaireConventionDouaniereWhereUniqueInput uniqueId
    )
    {
        var articlePaysPartenaireConventionDouanieres =
            await this.ArticlePaysPartenaireConventionDouanieres(
                new ArticlePaysPartenaireConventionDouaniereFindManyArgs
                {
                    Where = new ArticlePaysPartenaireConventionDouaniereWhereInput
                    {
                        Id = uniqueId.Id
                    }
                }
            );
        var articlePaysPartenaireConventionDouaniere =
            articlePaysPartenaireConventionDouanieres.FirstOrDefault();
        if (articlePaysPartenaireConventionDouaniere == null)
        {
            throw new NotFoundException();
        }

        return articlePaysPartenaireConventionDouaniere;
    }

    /// <summary>
    /// Update one ArticlePaysPartenaireConventionDouaniere
    /// </summary>
    public async Task UpdateArticlePaysPartenaireConventionDouaniere(
        ArticlePaysPartenaireConventionDouaniereWhereUniqueInput uniqueId,
        ArticlePaysPartenaireConventionDouaniereUpdateInput updateDto
    )
    {
        var articlePaysPartenaireConventionDouaniere = updateDto.ToModel(uniqueId);

        _context.Entry(articlePaysPartenaireConventionDouaniere).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (
                !_context.ArticlePaysPartenaireConventionDouanieres.Any(e =>
                    e.Id == articlePaysPartenaireConventionDouaniere.Id
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
