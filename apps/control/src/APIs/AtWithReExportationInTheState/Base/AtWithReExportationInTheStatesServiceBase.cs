using Clre.APIs;
using Clre.APIs.Common;
using Clre.APIs.Dtos;
using Clre.APIs.Errors;
using Clre.APIs.Extensions;
using Clre.Infrastructure;
using Clre.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Clre.APIs;

public abstract class AtWithReExportationInTheStatesServiceBase
    : IAtWithReExportationInTheStatesService
{
    protected readonly ClreDbContext _context;

    public AtWithReExportationInTheStatesServiceBase(ClreDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one AT WITH RE-EXPORTATION IN THE STATE
    /// </summary>
    public async Task<AtWithReExportationInTheState> CreateAtWithReExportationInTheState(
        AtWithReExportationInTheStateCreateInput createDto
    )
    {
        var atWithReExportationInTheState = new AtWithReExportationInTheStateDbModel
        {
            CreatedAt = createDto.CreatedAt,
            UpdatedAt = createDto.UpdatedAt
        };

        if (createDto.Id != null)
        {
            atWithReExportationInTheState.Id = createDto.Id;
        }

        _context.AtWithReExportationInTheStates.Add(atWithReExportationInTheState);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<AtWithReExportationInTheStateDbModel>(
            atWithReExportationInTheState.Id
        );

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one AT WITH RE-EXPORTATION IN THE STATE
    /// </summary>
    public async Task DeleteAtWithReExportationInTheState(
        AtWithReExportationInTheStateWhereUniqueInput uniqueId
    )
    {
        var atWithReExportationInTheState = await _context.AtWithReExportationInTheStates.FindAsync(
            uniqueId.Id
        );
        if (atWithReExportationInTheState == null)
        {
            throw new NotFoundException();
        }

        _context.AtWithReExportationInTheStates.Remove(atWithReExportationInTheState);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many AT WITH RE-EXPORTATION IN THE STATES
    /// </summary>
    public async Task<List<AtWithReExportationInTheState>> AtWithReExportationInTheStates(
        AtWithReExportationInTheStateFindManyArgs findManyArgs
    )
    {
        var atWithReExportationInTheStates = await _context
            .AtWithReExportationInTheStates.ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return atWithReExportationInTheStates.ConvertAll(atWithReExportationInTheState =>
            atWithReExportationInTheState.ToDto()
        );
    }

    /// <summary>
    /// Meta data about AT WITH RE-EXPORTATION IN THE STATE records
    /// </summary>
    public async Task<MetadataDto> AtWithReExportationInTheStatesMeta(
        AtWithReExportationInTheStateFindManyArgs findManyArgs
    )
    {
        var count = await _context
            .AtWithReExportationInTheStates.ApplyWhere(findManyArgs.Where)
            .CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one AT WITH RE-EXPORTATION IN THE STATE
    /// </summary>
    public async Task<AtWithReExportationInTheState> AtWithReExportationInTheState(
        AtWithReExportationInTheStateWhereUniqueInput uniqueId
    )
    {
        var atWithReExportationInTheStates = await this.AtWithReExportationInTheStates(
            new AtWithReExportationInTheStateFindManyArgs
            {
                Where = new AtWithReExportationInTheStateWhereInput { Id = uniqueId.Id }
            }
        );
        var atWithReExportationInTheState = atWithReExportationInTheStates.FirstOrDefault();
        if (atWithReExportationInTheState == null)
        {
            throw new NotFoundException();
        }

        return atWithReExportationInTheState;
    }

    /// <summary>
    /// Update one AT WITH RE-EXPORTATION IN THE STATE
    /// </summary>
    public async Task UpdateAtWithReExportationInTheState(
        AtWithReExportationInTheStateWhereUniqueInput uniqueId,
        AtWithReExportationInTheStateUpdateInput updateDto
    )
    {
        var atWithReExportationInTheState = updateDto.ToModel(uniqueId);

        _context.Entry(atWithReExportationInTheState).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (
                !_context.AtWithReExportationInTheStates.Any(e =>
                    e.Id == atWithReExportationInTheState.Id
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
