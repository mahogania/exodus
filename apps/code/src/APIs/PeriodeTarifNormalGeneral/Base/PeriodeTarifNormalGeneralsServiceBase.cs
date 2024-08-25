using Code.APIs;
using Code.APIs.Common;
using Code.APIs.Dtos;
using Code.APIs.Errors;
using Code.APIs.Extensions;
using Code.Infrastructure;
using Code.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Code.APIs;

public abstract class PeriodeTarifNormalGeneralsServiceBase : IPeriodeTarifNormalGeneralsService
{
    protected readonly CodeDbContext _context;

    public PeriodeTarifNormalGeneralsServiceBase(CodeDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one PeriodeTarifNormalGeneral
    /// </summary>
    public async Task<PeriodeTarifNormalGeneral> CreatePeriodeTarifNormalGeneral(
        PeriodeTarifNormalGeneralCreateInput createDto
    )
    {
        var periodeTarifNormalGeneral = new PeriodeTarifNormalGeneralDbModel
        {
            CreatedAt = createDto.CreatedAt,
            DateDebutApplication = createDto.DateDebutApplication,
            DateFinApplication = createDto.DateFinApplication,
            DateHeureModificationFinale = createDto.DateHeureModificationFinale,
            DateHeurePremierEnregistrement = createDto.DateHeurePremierEnregistrement,
            ModificateurFinalId = createDto.ModificateurFinalId,
            PremierEnregistrantId = createDto.PremierEnregistrantId,
            SuppressionOn = createDto.SuppressionOn,
            UpdatedAt = createDto.UpdatedAt
        };

        if (createDto.Id != null)
        {
            periodeTarifNormalGeneral.Id = createDto.Id;
        }

        _context.PeriodeTarifNormalGenerals.Add(periodeTarifNormalGeneral);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<PeriodeTarifNormalGeneralDbModel>(
            periodeTarifNormalGeneral.Id
        );

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one PeriodeTarifNormalGeneral
    /// </summary>
    public async Task DeletePeriodeTarifNormalGeneral(
        PeriodeTarifNormalGeneralWhereUniqueInput uniqueId
    )
    {
        var periodeTarifNormalGeneral = await _context.PeriodeTarifNormalGenerals.FindAsync(
            uniqueId.Id
        );
        if (periodeTarifNormalGeneral == null)
        {
            throw new NotFoundException();
        }

        _context.PeriodeTarifNormalGenerals.Remove(periodeTarifNormalGeneral);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many PeriodeTarifNormalGenerals
    /// </summary>
    public async Task<List<PeriodeTarifNormalGeneral>> PeriodeTarifNormalGenerals(
        PeriodeTarifNormalGeneralFindManyArgs findManyArgs
    )
    {
        var periodeTarifNormalGenerals = await _context
            .PeriodeTarifNormalGenerals.ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return periodeTarifNormalGenerals.ConvertAll(periodeTarifNormalGeneral =>
            periodeTarifNormalGeneral.ToDto()
        );
    }

    /// <summary>
    /// Meta data about PeriodeTarifNormalGeneral records
    /// </summary>
    public async Task<MetadataDto> PeriodeTarifNormalGeneralsMeta(
        PeriodeTarifNormalGeneralFindManyArgs findManyArgs
    )
    {
        var count = await _context
            .PeriodeTarifNormalGenerals.ApplyWhere(findManyArgs.Where)
            .CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one PeriodeTarifNormalGeneral
    /// </summary>
    public async Task<PeriodeTarifNormalGeneral> PeriodeTarifNormalGeneral(
        PeriodeTarifNormalGeneralWhereUniqueInput uniqueId
    )
    {
        var periodeTarifNormalGenerals = await this.PeriodeTarifNormalGenerals(
            new PeriodeTarifNormalGeneralFindManyArgs
            {
                Where = new PeriodeTarifNormalGeneralWhereInput { Id = uniqueId.Id }
            }
        );
        var periodeTarifNormalGeneral = periodeTarifNormalGenerals.FirstOrDefault();
        if (periodeTarifNormalGeneral == null)
        {
            throw new NotFoundException();
        }

        return periodeTarifNormalGeneral;
    }

    /// <summary>
    /// Update one PeriodeTarifNormalGeneral
    /// </summary>
    public async Task UpdatePeriodeTarifNormalGeneral(
        PeriodeTarifNormalGeneralWhereUniqueInput uniqueId,
        PeriodeTarifNormalGeneralUpdateInput updateDto
    )
    {
        var periodeTarifNormalGeneral = updateDto.ToModel(uniqueId);

        _context.Entry(periodeTarifNormalGeneral).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!_context.PeriodeTarifNormalGenerals.Any(e => e.Id == periodeTarifNormalGeneral.Id))
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
