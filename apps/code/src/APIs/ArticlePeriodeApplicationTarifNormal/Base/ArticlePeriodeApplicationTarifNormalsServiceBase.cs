using Code.APIs;
using Code.APIs.Common;
using Code.APIs.Dtos;
using Code.APIs.Errors;
using Code.APIs.Extensions;
using Code.Infrastructure;
using Code.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Code.APIs;

public abstract class ArticlePeriodeApplicationTarifNormalsServiceBase
    : IArticlePeriodeApplicationTarifNormalsService
{
    protected readonly CodeDbContext _context;

    public ArticlePeriodeApplicationTarifNormalsServiceBase(CodeDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one ArticlePeriodeApplicationTarifNormal
    /// </summary>
    public async Task<ArticlePeriodeApplicationTarifNormal> CreateArticlePeriodeApplicationTarifNormal(
        ArticlePeriodeApplicationTarifNormalCreateInput createDto
    )
    {
        var articlePeriodeApplicationTarifNormal = new ArticlePeriodeApplicationTarifNormalDbModel
        {
            CodeSh = createDto.CodeSh,
            CreatedAt = createDto.CreatedAt,
            DateDebutApplication = createDto.DateDebutApplication,
            DateFinApplication = createDto.DateFinApplication,
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
            articlePeriodeApplicationTarifNormal.Id = createDto.Id;
        }

        _context.ArticlePeriodeApplicationTarifNormals.Add(articlePeriodeApplicationTarifNormal);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<ArticlePeriodeApplicationTarifNormalDbModel>(
            articlePeriodeApplicationTarifNormal.Id
        );

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one ArticlePeriodeApplicationTarifNormal
    /// </summary>
    public async Task DeleteArticlePeriodeApplicationTarifNormal(
        ArticlePeriodeApplicationTarifNormalWhereUniqueInput uniqueId
    )
    {
        var articlePeriodeApplicationTarifNormal =
            await _context.ArticlePeriodeApplicationTarifNormals.FindAsync(uniqueId.Id);
        if (articlePeriodeApplicationTarifNormal == null)
        {
            throw new NotFoundException();
        }

        _context.ArticlePeriodeApplicationTarifNormals.Remove(articlePeriodeApplicationTarifNormal);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many ArticlePeriodeApplicationTarifNormals
    /// </summary>
    public async Task<
        List<ArticlePeriodeApplicationTarifNormal>
    > ArticlePeriodeApplicationTarifNormals(
        ArticlePeriodeApplicationTarifNormalFindManyArgs findManyArgs
    )
    {
        var articlePeriodeApplicationTarifNormals = await _context
            .ArticlePeriodeApplicationTarifNormals.ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return articlePeriodeApplicationTarifNormals.ConvertAll(
            articlePeriodeApplicationTarifNormal => articlePeriodeApplicationTarifNormal.ToDto()
        );
    }

    /// <summary>
    /// Meta data about ArticlePeriodeApplicationTarifNormal records
    /// </summary>
    public async Task<MetadataDto> ArticlePeriodeApplicationTarifNormalsMeta(
        ArticlePeriodeApplicationTarifNormalFindManyArgs findManyArgs
    )
    {
        var count = await _context
            .ArticlePeriodeApplicationTarifNormals.ApplyWhere(findManyArgs.Where)
            .CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one ArticlePeriodeApplicationTarifNormal
    /// </summary>
    public async Task<ArticlePeriodeApplicationTarifNormal> ArticlePeriodeApplicationTarifNormal(
        ArticlePeriodeApplicationTarifNormalWhereUniqueInput uniqueId
    )
    {
        var articlePeriodeApplicationTarifNormals =
            await this.ArticlePeriodeApplicationTarifNormals(
                new ArticlePeriodeApplicationTarifNormalFindManyArgs
                {
                    Where = new ArticlePeriodeApplicationTarifNormalWhereInput { Id = uniqueId.Id }
                }
            );
        var articlePeriodeApplicationTarifNormal =
            articlePeriodeApplicationTarifNormals.FirstOrDefault();
        if (articlePeriodeApplicationTarifNormal == null)
        {
            throw new NotFoundException();
        }

        return articlePeriodeApplicationTarifNormal;
    }

    /// <summary>
    /// Update one ArticlePeriodeApplicationTarifNormal
    /// </summary>
    public async Task UpdateArticlePeriodeApplicationTarifNormal(
        ArticlePeriodeApplicationTarifNormalWhereUniqueInput uniqueId,
        ArticlePeriodeApplicationTarifNormalUpdateInput updateDto
    )
    {
        var articlePeriodeApplicationTarifNormal = updateDto.ToModel(uniqueId);

        _context.Entry(articlePeriodeApplicationTarifNormal).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (
                !_context.ArticlePeriodeApplicationTarifNormals.Any(e =>
                    e.Id == articlePeriodeApplicationTarifNormal.Id
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
