using Code.APIs;
using Code.APIs.Common;
using Code.APIs.Dtos;
using Code.APIs.Errors;
using Code.APIs.Extensions;
using Code.Infrastructure;
using Code.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Code.APIs;

public abstract class PaysPreferentielsServiceBase : IPaysPreferentielsService
{
    protected readonly CodeDbContext _context;

    public PaysPreferentielsServiceBase(CodeDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one PaysPreferentiel
    /// </summary>
    public async Task<PaysPreferentiel> CreatePaysPreferentiel(
        PaysPreferentielCreateInput createDto
    )
    {
        var paysPreferentiel = new PaysPreferentielDbModel
        {
            CodeDePays = createDto.CodeDePays,
            CodePreferentiel = createDto.CodePreferentiel,
            CreatedAt = createDto.CreatedAt,
            DateDebutApplicationPreference = createDto.DateDebutApplicationPreference,
            DateFinApplicationConvention = createDto.DateFinApplicationConvention,
            DateHeureModificationFinale = createDto.DateHeureModificationFinale,
            DateHeurePremierEnregistrement = createDto.DateHeurePremierEnregistrement,
            ModificateurFinalId = createDto.ModificateurFinalId,
            PremierEnregistrantId = createDto.PremierEnregistrantId,
            SuppressionOn = createDto.SuppressionOn,
            UpdatedAt = createDto.UpdatedAt,
            UtiliseOn = createDto.UtiliseOn
        };

        if (createDto.Id != null)
        {
            paysPreferentiel.Id = createDto.Id;
        }

        _context.PaysPreferentiels.Add(paysPreferentiel);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<PaysPreferentielDbModel>(paysPreferentiel.Id);

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one PaysPreferentiel
    /// </summary>
    public async Task DeletePaysPreferentiel(PaysPreferentielWhereUniqueInput uniqueId)
    {
        var paysPreferentiel = await _context.PaysPreferentiels.FindAsync(uniqueId.Id);
        if (paysPreferentiel == null)
        {
            throw new NotFoundException();
        }

        _context.PaysPreferentiels.Remove(paysPreferentiel);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many PaysPreferentiels
    /// </summary>
    public async Task<List<PaysPreferentiel>> PaysPreferentiels(
        PaysPreferentielFindManyArgs findManyArgs
    )
    {
        var paysPreferentiels = await _context
            .PaysPreferentiels.ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return paysPreferentiels.ConvertAll(paysPreferentiel => paysPreferentiel.ToDto());
    }

    /// <summary>
    /// Meta data about PaysPreferentiel records
    /// </summary>
    public async Task<MetadataDto> PaysPreferentielsMeta(PaysPreferentielFindManyArgs findManyArgs)
    {
        var count = await _context.PaysPreferentiels.ApplyWhere(findManyArgs.Where).CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one PaysPreferentiel
    /// </summary>
    public async Task<PaysPreferentiel> PaysPreferentiel(PaysPreferentielWhereUniqueInput uniqueId)
    {
        var paysPreferentiels = await this.PaysPreferentiels(
            new PaysPreferentielFindManyArgs
            {
                Where = new PaysPreferentielWhereInput { Id = uniqueId.Id }
            }
        );
        var paysPreferentiel = paysPreferentiels.FirstOrDefault();
        if (paysPreferentiel == null)
        {
            throw new NotFoundException();
        }

        return paysPreferentiel;
    }

    /// <summary>
    /// Update one PaysPreferentiel
    /// </summary>
    public async Task UpdatePaysPreferentiel(
        PaysPreferentielWhereUniqueInput uniqueId,
        PaysPreferentielUpdateInput updateDto
    )
    {
        var paysPreferentiel = updateDto.ToModel(uniqueId);

        _context.Entry(paysPreferentiel).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!_context.PaysPreferentiels.Any(e => e.Id == paysPreferentiel.Id))
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
