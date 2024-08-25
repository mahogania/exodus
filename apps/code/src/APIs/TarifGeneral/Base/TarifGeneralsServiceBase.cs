using Code.APIs;
using Code.APIs.Common;
using Code.APIs.Dtos;
using Code.APIs.Errors;
using Code.APIs.Extensions;
using Code.Infrastructure;
using Code.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Code.APIs;

public abstract class TarifGeneralsServiceBase : ITarifGeneralsService
{
    protected readonly CodeDbContext _context;

    public TarifGeneralsServiceBase(CodeDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one TarifGeneral
    /// </summary>
    public async Task<TarifGeneral> CreateTarifGeneral(TarifGeneralCreateInput createDto)
    {
        var tarifGeneral = new TarifGeneralDbModel
        {
            CodeCategorieTarif = createDto.CodeCategorieTarif,
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
            tarifGeneral.Id = createDto.Id;
        }

        _context.TarifGenerals.Add(tarifGeneral);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<TarifGeneralDbModel>(tarifGeneral.Id);

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one TarifGeneral
    /// </summary>
    public async Task DeleteTarifGeneral(TarifGeneralWhereUniqueInput uniqueId)
    {
        var tarifGeneral = await _context.TarifGenerals.FindAsync(uniqueId.Id);
        if (tarifGeneral == null)
        {
            throw new NotFoundException();
        }

        _context.TarifGenerals.Remove(tarifGeneral);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many TarifGenerals
    /// </summary>
    public async Task<List<TarifGeneral>> TarifGenerals(TarifGeneralFindManyArgs findManyArgs)
    {
        var tarifGenerals = await _context
            .TarifGenerals.ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return tarifGenerals.ConvertAll(tarifGeneral => tarifGeneral.ToDto());
    }

    /// <summary>
    /// Meta data about TarifGeneral records
    /// </summary>
    public async Task<MetadataDto> TarifGeneralsMeta(TarifGeneralFindManyArgs findManyArgs)
    {
        var count = await _context.TarifGenerals.ApplyWhere(findManyArgs.Where).CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one TarifGeneral
    /// </summary>
    public async Task<TarifGeneral> TarifGeneral(TarifGeneralWhereUniqueInput uniqueId)
    {
        var tarifGenerals = await this.TarifGenerals(
            new TarifGeneralFindManyArgs { Where = new TarifGeneralWhereInput { Id = uniqueId.Id } }
        );
        var tarifGeneral = tarifGenerals.FirstOrDefault();
        if (tarifGeneral == null)
        {
            throw new NotFoundException();
        }

        return tarifGeneral;
    }

    /// <summary>
    /// Update one TarifGeneral
    /// </summary>
    public async Task UpdateTarifGeneral(
        TarifGeneralWhereUniqueInput uniqueId,
        TarifGeneralUpdateInput updateDto
    )
    {
        var tarifGeneral = updateDto.ToModel(uniqueId);

        _context.Entry(tarifGeneral).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!_context.TarifGenerals.Any(e => e.Id == tarifGeneral.Id))
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
