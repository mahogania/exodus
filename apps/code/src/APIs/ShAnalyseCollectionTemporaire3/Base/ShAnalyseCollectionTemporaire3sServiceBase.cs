using Code.APIs;
using Code.APIs.Common;
using Code.APIs.Dtos;
using Code.APIs.Errors;
using Code.APIs.Extensions;
using Code.Infrastructure;
using Code.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Code.APIs;

public abstract class ShAnalyseCollectionTemporaire3sServiceBase
    : IShAnalyseCollectionTemporaire3sService
{
    protected readonly CodeDbContext _context;

    public ShAnalyseCollectionTemporaire3sServiceBase(CodeDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one ShAnalyseCollectionTemporaire3
    /// </summary>
    public async Task<ShAnalyseCollectionTemporaire3> CreateShAnalyseCollectionTemporaire3(
        ShAnalyseCollectionTemporaire3CreateInput createDto
    )
    {
        var shAnalyseCollectionTemporaire3 = new ShAnalyseCollectionTemporaire3DbModel
        {
            CodeSh = createDto.CodeSh,
            CreatedAt = createDto.CreatedAt,
            DateHeureModificationFinale = createDto.DateHeureModificationFinale,
            DateHeurePremierEnregistrement = createDto.DateHeurePremierEnregistrement,
            ModificateurFinalId = createDto.ModificateurFinalId,
            PremierEnregistrantId = createDto.PremierEnregistrantId,
            PrixUnitaireNcyMinimum = createDto.PrixUnitaireNcyMinimum,
            PrixUnitaireNcyPlafonne = createDto.PrixUnitaireNcyPlafonne,
            PrixUnitaireUsdMinimum = createDto.PrixUnitaireUsdMinimum,
            PrixUnitaireUsdPlafonne = createDto.PrixUnitaireUsdPlafonne,
            SuppressionOn = createDto.SuppressionOn,
            UpdatedAt = createDto.UpdatedAt
        };

        if (createDto.Id != null)
        {
            shAnalyseCollectionTemporaire3.Id = createDto.Id;
        }

        _context.ShAnalyseCollectionTemporaire3s.Add(shAnalyseCollectionTemporaire3);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<ShAnalyseCollectionTemporaire3DbModel>(
            shAnalyseCollectionTemporaire3.Id
        );

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one ShAnalyseCollectionTemporaire3
    /// </summary>
    public async Task DeleteShAnalyseCollectionTemporaire3(
        ShAnalyseCollectionTemporaire3WhereUniqueInput uniqueId
    )
    {
        var shAnalyseCollectionTemporaire3 =
            await _context.ShAnalyseCollectionTemporaire3s.FindAsync(uniqueId.Id);
        if (shAnalyseCollectionTemporaire3 == null)
        {
            throw new NotFoundException();
        }

        _context.ShAnalyseCollectionTemporaire3s.Remove(shAnalyseCollectionTemporaire3);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many ShAnalyseCollectionTemporaire3s
    /// </summary>
    public async Task<List<ShAnalyseCollectionTemporaire3>> ShAnalyseCollectionTemporaire3s(
        ShAnalyseCollectionTemporaire3FindManyArgs findManyArgs
    )
    {
        var shAnalyseCollectionTemporaire3s = await _context
            .ShAnalyseCollectionTemporaire3s.ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return shAnalyseCollectionTemporaire3s.ConvertAll(shAnalyseCollectionTemporaire3 =>
            shAnalyseCollectionTemporaire3.ToDto()
        );
    }

    /// <summary>
    /// Meta data about ShAnalyseCollectionTemporaire3 records
    /// </summary>
    public async Task<MetadataDto> ShAnalyseCollectionTemporaire3sMeta(
        ShAnalyseCollectionTemporaire3FindManyArgs findManyArgs
    )
    {
        var count = await _context
            .ShAnalyseCollectionTemporaire3s.ApplyWhere(findManyArgs.Where)
            .CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one ShAnalyseCollectionTemporaire3
    /// </summary>
    public async Task<ShAnalyseCollectionTemporaire3> ShAnalyseCollectionTemporaire3(
        ShAnalyseCollectionTemporaire3WhereUniqueInput uniqueId
    )
    {
        var shAnalyseCollectionTemporaire3s = await this.ShAnalyseCollectionTemporaire3s(
            new ShAnalyseCollectionTemporaire3FindManyArgs
            {
                Where = new ShAnalyseCollectionTemporaire3WhereInput { Id = uniqueId.Id }
            }
        );
        var shAnalyseCollectionTemporaire3 = shAnalyseCollectionTemporaire3s.FirstOrDefault();
        if (shAnalyseCollectionTemporaire3 == null)
        {
            throw new NotFoundException();
        }

        return shAnalyseCollectionTemporaire3;
    }

    /// <summary>
    /// Update one ShAnalyseCollectionTemporaire3
    /// </summary>
    public async Task UpdateShAnalyseCollectionTemporaire3(
        ShAnalyseCollectionTemporaire3WhereUniqueInput uniqueId,
        ShAnalyseCollectionTemporaire3UpdateInput updateDto
    )
    {
        var shAnalyseCollectionTemporaire3 = updateDto.ToModel(uniqueId);

        _context.Entry(shAnalyseCollectionTemporaire3).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (
                !_context.ShAnalyseCollectionTemporaire3s.Any(e =>
                    e.Id == shAnalyseCollectionTemporaire3.Id
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
