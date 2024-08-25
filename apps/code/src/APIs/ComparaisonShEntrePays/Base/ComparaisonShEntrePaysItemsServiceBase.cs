using Code.APIs;
using Code.APIs.Common;
using Code.APIs.Dtos;
using Code.APIs.Errors;
using Code.APIs.Extensions;
using Code.Infrastructure;
using Code.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Code.APIs;

public abstract class ComparaisonShEntrePaysItemsServiceBase : IComparaisonShEntrePaysItemsService
{
    protected readonly CodeDbContext _context;

    public ComparaisonShEntrePaysItemsServiceBase(CodeDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one ComparaisonShEntrePays
    /// </summary>
    public async Task<ComparaisonShEntrePays> CreateComparaisonShEntrePays(
        ComparaisonShEntrePaysCreateInput createDto
    )
    {
        var comparaisonShEntrePays = new ComparaisonShEntrePaysDbModel
        {
            CodeEmetteurSh = createDto.CodeEmetteurSh,
            CodeSh = createDto.CodeSh,
            CreatedAt = createDto.CreatedAt,
            DateHeureModificationFinale = createDto.DateHeureModificationFinale,
            DateHeurePremierEnregistrement = createDto.DateHeurePremierEnregistrement,
            DescriptionSh = createDto.DescriptionSh,
            ModificateurFinalId = createDto.ModificateurFinalId,
            PremierEnregistrantId = createDto.PremierEnregistrantId,
            SuppressionOn = createDto.SuppressionOn,
            UpdatedAt = createDto.UpdatedAt
        };

        if (createDto.Id != null)
        {
            comparaisonShEntrePays.Id = createDto.Id;
        }

        _context.ComparaisonShEntrePaysItems.Add(comparaisonShEntrePays);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<ComparaisonShEntrePaysDbModel>(
            comparaisonShEntrePays.Id
        );

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one ComparaisonShEntrePays
    /// </summary>
    public async Task DeleteComparaisonShEntrePays(ComparaisonShEntrePaysWhereUniqueInput uniqueId)
    {
        var comparaisonShEntrePays = await _context.ComparaisonShEntrePaysItems.FindAsync(
            uniqueId.Id
        );
        if (comparaisonShEntrePays == null)
        {
            throw new NotFoundException();
        }

        _context.ComparaisonShEntrePaysItems.Remove(comparaisonShEntrePays);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many ComparaisonShEntrePaysItems
    /// </summary>
    public async Task<List<ComparaisonShEntrePays>> ComparaisonShEntrePaysItems(
        ComparaisonShEntrePaysFindManyArgs findManyArgs
    )
    {
        var comparaisonShEntrePaysItems = await _context
            .ComparaisonShEntrePaysItems.ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return comparaisonShEntrePaysItems.ConvertAll(comparaisonShEntrePays =>
            comparaisonShEntrePays.ToDto()
        );
    }

    /// <summary>
    /// Meta data about ComparaisonShEntrePays records
    /// </summary>
    public async Task<MetadataDto> ComparaisonShEntrePaysItemsMeta(
        ComparaisonShEntrePaysFindManyArgs findManyArgs
    )
    {
        var count = await _context
            .ComparaisonShEntrePaysItems.ApplyWhere(findManyArgs.Where)
            .CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one ComparaisonShEntrePays
    /// </summary>
    public async Task<ComparaisonShEntrePays> ComparaisonShEntrePays(
        ComparaisonShEntrePaysWhereUniqueInput uniqueId
    )
    {
        var comparaisonShEntrePaysItems = await this.ComparaisonShEntrePaysItems(
            new ComparaisonShEntrePaysFindManyArgs
            {
                Where = new ComparaisonShEntrePaysWhereInput { Id = uniqueId.Id }
            }
        );
        var comparaisonShEntrePays = comparaisonShEntrePaysItems.FirstOrDefault();
        if (comparaisonShEntrePays == null)
        {
            throw new NotFoundException();
        }

        return comparaisonShEntrePays;
    }

    /// <summary>
    /// Update one ComparaisonShEntrePays
    /// </summary>
    public async Task UpdateComparaisonShEntrePays(
        ComparaisonShEntrePaysWhereUniqueInput uniqueId,
        ComparaisonShEntrePaysUpdateInput updateDto
    )
    {
        var comparaisonShEntrePays = updateDto.ToModel(uniqueId);

        _context.Entry(comparaisonShEntrePays).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!_context.ComparaisonShEntrePaysItems.Any(e => e.Id == comparaisonShEntrePays.Id))
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
