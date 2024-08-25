using Code.APIs;
using Code.APIs.Common;
using Code.APIs.Dtos;
using Code.APIs.Errors;
using Code.APIs.Extensions;
using Code.Infrastructure;
using Code.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Code.APIs;

public abstract class ArticlePaysBeneficiaireAntiDumpingsServiceBase
    : IArticlePaysBeneficiaireAntiDumpingsService
{
    protected readonly CodeDbContext _context;

    public ArticlePaysBeneficiaireAntiDumpingsServiceBase(CodeDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one ArticlePaysBeneficiaireAntiDumping
    /// </summary>
    public async Task<ArticlePaysBeneficiaireAntiDumping> CreateArticlePaysBeneficiaireAntiDumping(
        ArticlePaysBeneficiaireAntiDumpingCreateInput createDto
    )
    {
        var articlePaysBeneficiaireAntiDumping = new ArticlePaysBeneficiaireAntiDumpingDbModel
        {
            CodeCategorieTarif = createDto.CodeCategorieTarif,
            CodePaysDroitsAntiDumping = createDto.CodePaysDroitsAntiDumping,
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
            articlePaysBeneficiaireAntiDumping.Id = createDto.Id;
        }

        _context.ArticlePaysBeneficiaireAntiDumpings.Add(articlePaysBeneficiaireAntiDumping);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<ArticlePaysBeneficiaireAntiDumpingDbModel>(
            articlePaysBeneficiaireAntiDumping.Id
        );

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one ArticlePaysBeneficiaireAntiDumping
    /// </summary>
    public async Task DeleteArticlePaysBeneficiaireAntiDumping(
        ArticlePaysBeneficiaireAntiDumpingWhereUniqueInput uniqueId
    )
    {
        var articlePaysBeneficiaireAntiDumping =
            await _context.ArticlePaysBeneficiaireAntiDumpings.FindAsync(uniqueId.Id);
        if (articlePaysBeneficiaireAntiDumping == null)
        {
            throw new NotFoundException();
        }

        _context.ArticlePaysBeneficiaireAntiDumpings.Remove(articlePaysBeneficiaireAntiDumping);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many ArticlePaysBeneficiaireAntiDumpings
    /// </summary>
    public async Task<List<ArticlePaysBeneficiaireAntiDumping>> ArticlePaysBeneficiaireAntiDumpings(
        ArticlePaysBeneficiaireAntiDumpingFindManyArgs findManyArgs
    )
    {
        var articlePaysBeneficiaireAntiDumpings = await _context
            .ArticlePaysBeneficiaireAntiDumpings.ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return articlePaysBeneficiaireAntiDumpings.ConvertAll(articlePaysBeneficiaireAntiDumping =>
            articlePaysBeneficiaireAntiDumping.ToDto()
        );
    }

    /// <summary>
    /// Meta data about ArticlePaysBeneficiaireAntiDumping records
    /// </summary>
    public async Task<MetadataDto> ArticlePaysBeneficiaireAntiDumpingsMeta(
        ArticlePaysBeneficiaireAntiDumpingFindManyArgs findManyArgs
    )
    {
        var count = await _context
            .ArticlePaysBeneficiaireAntiDumpings.ApplyWhere(findManyArgs.Where)
            .CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one ArticlePaysBeneficiaireAntiDumping
    /// </summary>
    public async Task<ArticlePaysBeneficiaireAntiDumping> ArticlePaysBeneficiaireAntiDumping(
        ArticlePaysBeneficiaireAntiDumpingWhereUniqueInput uniqueId
    )
    {
        var articlePaysBeneficiaireAntiDumpings = await this.ArticlePaysBeneficiaireAntiDumpings(
            new ArticlePaysBeneficiaireAntiDumpingFindManyArgs
            {
                Where = new ArticlePaysBeneficiaireAntiDumpingWhereInput { Id = uniqueId.Id }
            }
        );
        var articlePaysBeneficiaireAntiDumping =
            articlePaysBeneficiaireAntiDumpings.FirstOrDefault();
        if (articlePaysBeneficiaireAntiDumping == null)
        {
            throw new NotFoundException();
        }

        return articlePaysBeneficiaireAntiDumping;
    }

    /// <summary>
    /// Update one ArticlePaysBeneficiaireAntiDumping
    /// </summary>
    public async Task UpdateArticlePaysBeneficiaireAntiDumping(
        ArticlePaysBeneficiaireAntiDumpingWhereUniqueInput uniqueId,
        ArticlePaysBeneficiaireAntiDumpingUpdateInput updateDto
    )
    {
        var articlePaysBeneficiaireAntiDumping = updateDto.ToModel(uniqueId);

        _context.Entry(articlePaysBeneficiaireAntiDumping).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (
                !_context.ArticlePaysBeneficiaireAntiDumpings.Any(e =>
                    e.Id == articlePaysBeneficiaireAntiDumping.Id
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
