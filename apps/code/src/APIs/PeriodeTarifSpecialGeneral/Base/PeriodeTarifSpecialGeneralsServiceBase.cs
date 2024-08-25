using Code.APIs;
using Code.APIs.Common;
using Code.APIs.Dtos;
using Code.APIs.Errors;
using Code.APIs.Extensions;
using Code.Infrastructure;
using Code.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Code.APIs;

public abstract class PeriodeTarifSpecialGeneralsServiceBase : IPeriodeTarifSpecialGeneralsService
{
    protected readonly CodeDbContext _context;

    public PeriodeTarifSpecialGeneralsServiceBase(CodeDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one PeriodeTarifSpecialGeneral
    /// </summary>
    public async Task<PeriodeTarifSpecialGeneral> CreatePeriodeTarifSpecialGeneral(
        PeriodeTarifSpecialGeneralCreateInput createDto
    )
    {
        var periodeTarifSpecialGeneral = new PeriodeTarifSpecialGeneralDbModel
        {
            CreatedAt = createDto.CreatedAt,
            DateDebutApplication = createDto.DateDebutApplication,
            DateFinApplication = createDto.DateFinApplication,
            UpdatedAt = createDto.UpdatedAt
        };

        if (createDto.Id != null)
        {
            periodeTarifSpecialGeneral.Id = createDto.Id;
        }

        _context.PeriodeTarifSpecialGenerals.Add(periodeTarifSpecialGeneral);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<PeriodeTarifSpecialGeneralDbModel>(
            periodeTarifSpecialGeneral.Id
        );

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one PeriodeTarifSpecialGeneral
    /// </summary>
    public async Task DeletePeriodeTarifSpecialGeneral(
        PeriodeTarifSpecialGeneralWhereUniqueInput uniqueId
    )
    {
        var periodeTarifSpecialGeneral = await _context.PeriodeTarifSpecialGenerals.FindAsync(
            uniqueId.Id
        );
        if (periodeTarifSpecialGeneral == null)
        {
            throw new NotFoundException();
        }

        _context.PeriodeTarifSpecialGenerals.Remove(periodeTarifSpecialGeneral);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many PeriodeTarifSpecialGenerals
    /// </summary>
    public async Task<List<PeriodeTarifSpecialGeneral>> PeriodeTarifSpecialGenerals(
        PeriodeTarifSpecialGeneralFindManyArgs findManyArgs
    )
    {
        var periodeTarifSpecialGenerals = await _context
            .PeriodeTarifSpecialGenerals.ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return periodeTarifSpecialGenerals.ConvertAll(periodeTarifSpecialGeneral =>
            periodeTarifSpecialGeneral.ToDto()
        );
    }

    /// <summary>
    /// Meta data about PeriodeTarifSpecialGeneral records
    /// </summary>
    public async Task<MetadataDto> PeriodeTarifSpecialGeneralsMeta(
        PeriodeTarifSpecialGeneralFindManyArgs findManyArgs
    )
    {
        var count = await _context
            .PeriodeTarifSpecialGenerals.ApplyWhere(findManyArgs.Where)
            .CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one PeriodeTarifSpecialGeneral
    /// </summary>
    public async Task<PeriodeTarifSpecialGeneral> PeriodeTarifSpecialGeneral(
        PeriodeTarifSpecialGeneralWhereUniqueInput uniqueId
    )
    {
        var periodeTarifSpecialGenerals = await this.PeriodeTarifSpecialGenerals(
            new PeriodeTarifSpecialGeneralFindManyArgs
            {
                Where = new PeriodeTarifSpecialGeneralWhereInput { Id = uniqueId.Id }
            }
        );
        var periodeTarifSpecialGeneral = periodeTarifSpecialGenerals.FirstOrDefault();
        if (periodeTarifSpecialGeneral == null)
        {
            throw new NotFoundException();
        }

        return periodeTarifSpecialGeneral;
    }

    /// <summary>
    /// Update one PeriodeTarifSpecialGeneral
    /// </summary>
    public async Task UpdatePeriodeTarifSpecialGeneral(
        PeriodeTarifSpecialGeneralWhereUniqueInput uniqueId,
        PeriodeTarifSpecialGeneralUpdateInput updateDto
    )
    {
        var periodeTarifSpecialGeneral = updateDto.ToModel(uniqueId);

        _context.Entry(periodeTarifSpecialGeneral).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (
                !_context.PeriodeTarifSpecialGenerals.Any(e =>
                    e.Id == periodeTarifSpecialGeneral.Id
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
