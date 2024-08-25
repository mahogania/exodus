using Code.APIs;
using Code.APIs.Common;
using Code.APIs.Dtos;
using Code.APIs.Errors;
using Code.APIs.Extensions;
using Code.Infrastructure;
using Code.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Code.APIs;

public abstract class ArticlePeriodeApplicationTarifSpecialsServiceBase
    : IArticlePeriodeApplicationTarifSpecialsService
{
    protected readonly CodeDbContext _context;

    public ArticlePeriodeApplicationTarifSpecialsServiceBase(CodeDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one ArticlePeriodeApplicationTarifSpecial
    /// </summary>
    public async Task<ArticlePeriodeApplicationTarifSpecial> CreateArticlePeriodeApplicationTarifSpecial(
        ArticlePeriodeApplicationTarifSpecialCreateInput createDto
    )
    {
        var articlePeriodeApplicationTarifSpecial = new ArticlePeriodeApplicationTarifSpecialDbModel
        {
            CodeCategorieTarif = createDto.CodeCategorieTarif,
            CodeSh = createDto.CodeSh,
            CreatedAt = createDto.CreatedAt,
            DateDebutApplication = createDto.DateDebutApplication,
            DateFinApplication = createDto.DateFinApplication,
            Sequence = createDto.Sequence,
            UpdatedAt = createDto.UpdatedAt
        };

        if (createDto.Id != null)
        {
            articlePeriodeApplicationTarifSpecial.Id = createDto.Id;
        }

        _context.ArticlePeriodeApplicationTarifSpecials.Add(articlePeriodeApplicationTarifSpecial);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<ArticlePeriodeApplicationTarifSpecialDbModel>(
            articlePeriodeApplicationTarifSpecial.Id
        );

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one ArticlePeriodeApplicationTarifSpecial
    /// </summary>
    public async Task DeleteArticlePeriodeApplicationTarifSpecial(
        ArticlePeriodeApplicationTarifSpecialWhereUniqueInput uniqueId
    )
    {
        var articlePeriodeApplicationTarifSpecial =
            await _context.ArticlePeriodeApplicationTarifSpecials.FindAsync(uniqueId.Id);
        if (articlePeriodeApplicationTarifSpecial == null)
        {
            throw new NotFoundException();
        }

        _context.ArticlePeriodeApplicationTarifSpecials.Remove(
            articlePeriodeApplicationTarifSpecial
        );
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many ArticlePeriodeApplicationTarifSpecials
    /// </summary>
    public async Task<
        List<ArticlePeriodeApplicationTarifSpecial>
    > ArticlePeriodeApplicationTarifSpecials(
        ArticlePeriodeApplicationTarifSpecialFindManyArgs findManyArgs
    )
    {
        var articlePeriodeApplicationTarifSpecials = await _context
            .ArticlePeriodeApplicationTarifSpecials.ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return articlePeriodeApplicationTarifSpecials.ConvertAll(
            articlePeriodeApplicationTarifSpecial => articlePeriodeApplicationTarifSpecial.ToDto()
        );
    }

    /// <summary>
    /// Meta data about ArticlePeriodeApplicationTarifSpecial records
    /// </summary>
    public async Task<MetadataDto> ArticlePeriodeApplicationTarifSpecialsMeta(
        ArticlePeriodeApplicationTarifSpecialFindManyArgs findManyArgs
    )
    {
        var count = await _context
            .ArticlePeriodeApplicationTarifSpecials.ApplyWhere(findManyArgs.Where)
            .CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one ArticlePeriodeApplicationTarifSpecial
    /// </summary>
    public async Task<ArticlePeriodeApplicationTarifSpecial> ArticlePeriodeApplicationTarifSpecial(
        ArticlePeriodeApplicationTarifSpecialWhereUniqueInput uniqueId
    )
    {
        var articlePeriodeApplicationTarifSpecials =
            await this.ArticlePeriodeApplicationTarifSpecials(
                new ArticlePeriodeApplicationTarifSpecialFindManyArgs
                {
                    Where = new ArticlePeriodeApplicationTarifSpecialWhereInput { Id = uniqueId.Id }
                }
            );
        var articlePeriodeApplicationTarifSpecial =
            articlePeriodeApplicationTarifSpecials.FirstOrDefault();
        if (articlePeriodeApplicationTarifSpecial == null)
        {
            throw new NotFoundException();
        }

        return articlePeriodeApplicationTarifSpecial;
    }

    /// <summary>
    /// Update one ArticlePeriodeApplicationTarifSpecial
    /// </summary>
    public async Task UpdateArticlePeriodeApplicationTarifSpecial(
        ArticlePeriodeApplicationTarifSpecialWhereUniqueInput uniqueId,
        ArticlePeriodeApplicationTarifSpecialUpdateInput updateDto
    )
    {
        var articlePeriodeApplicationTarifSpecial = updateDto.ToModel(uniqueId);

        _context.Entry(articlePeriodeApplicationTarifSpecial).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (
                !_context.ArticlePeriodeApplicationTarifSpecials.Any(e =>
                    e.Id == articlePeriodeApplicationTarifSpecial.Id
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
