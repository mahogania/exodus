using Code.APIs;
using Code.APIs.Common;
using Code.APIs.Dtos;
using Code.APIs.Errors;
using Code.APIs.Extensions;
using Code.Infrastructure;
using Code.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Code.APIs;

public abstract class ShAnalyseCollectionTemporaire2sServiceBase
    : IShAnalyseCollectionTemporaire2sService
{
    protected readonly CodeDbContext _context;

    public ShAnalyseCollectionTemporaire2sServiceBase(CodeDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one ShAnalyseCollectionTemporaire2
    /// </summary>
    public async Task<ShAnalyseCollectionTemporaire2> CreateShAnalyseCollectionTemporaire2(
        ShAnalyseCollectionTemporaire2CreateInput createDto
    )
    {
        var shAnalyseCollectionTemporaire2 = new ShAnalyseCollectionTemporaire2DbModel
        {
            ClassementGroupesPrixNcyUnitaires = createDto.ClassementGroupesPrixNcyUnitaires,
            ClassementGroupesPrixUsdUnitaires = createDto.ClassementGroupesPrixUsdUnitaires,
            CodeSh = createDto.CodeSh,
            CreatedAt = createDto.CreatedAt,
            DateHeureModificationFinale = createDto.DateHeureModificationFinale,
            DateHeurePremierEnregistrement = createDto.DateHeurePremierEnregistrement,
            ModificateurFinalId = createDto.ModificateurFinalId,
            PremierEnregistrantId = createDto.PremierEnregistrantId,
            PrixNcyUnitaire = createDto.PrixNcyUnitaire,
            PrixUsdUnitaire = createDto.PrixUsdUnitaire,
            SuppressionOn = createDto.SuppressionOn,
            UpdatedAt = createDto.UpdatedAt
        };

        if (createDto.Id != null)
        {
            shAnalyseCollectionTemporaire2.Id = createDto.Id;
        }

        _context.ShAnalyseCollectionTemporaire2s.Add(shAnalyseCollectionTemporaire2);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<ShAnalyseCollectionTemporaire2DbModel>(
            shAnalyseCollectionTemporaire2.Id
        );

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one ShAnalyseCollectionTemporaire2
    /// </summary>
    public async Task DeleteShAnalyseCollectionTemporaire2(
        ShAnalyseCollectionTemporaire2WhereUniqueInput uniqueId
    )
    {
        var shAnalyseCollectionTemporaire2 =
            await _context.ShAnalyseCollectionTemporaire2s.FindAsync(uniqueId.Id);
        if (shAnalyseCollectionTemporaire2 == null)
        {
            throw new NotFoundException();
        }

        _context.ShAnalyseCollectionTemporaire2s.Remove(shAnalyseCollectionTemporaire2);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many ShAnalyseCollectionTemporaire2s
    /// </summary>
    public async Task<List<ShAnalyseCollectionTemporaire2>> ShAnalyseCollectionTemporaire2s(
        ShAnalyseCollectionTemporaire2FindManyArgs findManyArgs
    )
    {
        var shAnalyseCollectionTemporaire2s = await _context
            .ShAnalyseCollectionTemporaire2s.ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return shAnalyseCollectionTemporaire2s.ConvertAll(shAnalyseCollectionTemporaire2 =>
            shAnalyseCollectionTemporaire2.ToDto()
        );
    }

    /// <summary>
    /// Meta data about ShAnalyseCollectionTemporaire2 records
    /// </summary>
    public async Task<MetadataDto> ShAnalyseCollectionTemporaire2sMeta(
        ShAnalyseCollectionTemporaire2FindManyArgs findManyArgs
    )
    {
        var count = await _context
            .ShAnalyseCollectionTemporaire2s.ApplyWhere(findManyArgs.Where)
            .CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one ShAnalyseCollectionTemporaire2
    /// </summary>
    public async Task<ShAnalyseCollectionTemporaire2> ShAnalyseCollectionTemporaire2(
        ShAnalyseCollectionTemporaire2WhereUniqueInput uniqueId
    )
    {
        var shAnalyseCollectionTemporaire2s = await this.ShAnalyseCollectionTemporaire2s(
            new ShAnalyseCollectionTemporaire2FindManyArgs
            {
                Where = new ShAnalyseCollectionTemporaire2WhereInput { Id = uniqueId.Id }
            }
        );
        var shAnalyseCollectionTemporaire2 = shAnalyseCollectionTemporaire2s.FirstOrDefault();
        if (shAnalyseCollectionTemporaire2 == null)
        {
            throw new NotFoundException();
        }

        return shAnalyseCollectionTemporaire2;
    }

    /// <summary>
    /// Update one ShAnalyseCollectionTemporaire2
    /// </summary>
    public async Task UpdateShAnalyseCollectionTemporaire2(
        ShAnalyseCollectionTemporaire2WhereUniqueInput uniqueId,
        ShAnalyseCollectionTemporaire2UpdateInput updateDto
    )
    {
        var shAnalyseCollectionTemporaire2 = updateDto.ToModel(uniqueId);

        _context.Entry(shAnalyseCollectionTemporaire2).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (
                !_context.ShAnalyseCollectionTemporaire2s.Any(e =>
                    e.Id == shAnalyseCollectionTemporaire2.Id
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
