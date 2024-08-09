using Clre.APIs;
using Clre.APIs.Common;
using Clre.APIs.Dtos;
using Clre.APIs.Errors;
using Clre.APIs.Extensions;
using Clre.Infrastructure;
using Clre.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Clre.APIs;

public abstract class JointDocumentOfTheDetailedDeclarationCustomsItemsServiceBase
    : IJointDocumentOfTheDetailedDeclarationCustomsItemsService
{
    protected readonly ClreDbContext _context;

    public JointDocumentOfTheDetailedDeclarationCustomsItemsServiceBase(ClreDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one JOINT DOCUMENT OF THE DETAILED DECLARATION (CUSTOMS)
    /// </summary>
    public async Task<JointDocumentOfTheDetailedDeclarationCustoms> CreateJointDocumentOfTheDetailedDeclarationCustoms(
        JointDocumentOfTheDetailedDeclarationCustomsCreateInput createDto
    )
    {
        var jointDocumentOfTheDetailedDeclarationCustoms =
            new JointDocumentOfTheDetailedDeclarationCustomsDbModel
            {
                CreatedAt = createDto.CreatedAt,
                UpdatedAt = createDto.UpdatedAt
            };

        if (createDto.Id != null)
        {
            jointDocumentOfTheDetailedDeclarationCustoms.Id = createDto.Id;
        }

        _context.JointDocumentOfTheDetailedDeclarationCustomsItems.Add(
            jointDocumentOfTheDetailedDeclarationCustoms
        );
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<JointDocumentOfTheDetailedDeclarationCustomsDbModel>(
            jointDocumentOfTheDetailedDeclarationCustoms.Id
        );

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one JOINT DOCUMENT OF THE DETAILED DECLARATION (CUSTOMS)
    /// </summary>
    public async Task DeleteJointDocumentOfTheDetailedDeclarationCustoms(
        JointDocumentOfTheDetailedDeclarationCustomsWhereUniqueInput uniqueId
    )
    {
        var jointDocumentOfTheDetailedDeclarationCustoms =
            await _context.JointDocumentOfTheDetailedDeclarationCustomsItems.FindAsync(uniqueId.Id);
        if (jointDocumentOfTheDetailedDeclarationCustoms == null)
        {
            throw new NotFoundException();
        }

        _context.JointDocumentOfTheDetailedDeclarationCustomsItems.Remove(
            jointDocumentOfTheDetailedDeclarationCustoms
        );
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many JOINT DOCUMENT OF THE DETAILED DECLARATION (CUSTOMS)s
    /// </summary>
    public async Task<
        List<JointDocumentOfTheDetailedDeclarationCustoms>
    > JointDocumentOfTheDetailedDeclarationCustomsItems(
        JointDocumentOfTheDetailedDeclarationCustomsFindManyArgs findManyArgs
    )
    {
        var jointDocumentOfTheDetailedDeclarationCustomsItems = await _context
            .JointDocumentOfTheDetailedDeclarationCustomsItems.ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return jointDocumentOfTheDetailedDeclarationCustomsItems.ConvertAll(
            jointDocumentOfTheDetailedDeclarationCustoms =>
                jointDocumentOfTheDetailedDeclarationCustoms.ToDto()
        );
    }

    /// <summary>
    /// Meta data about JOINT DOCUMENT OF THE DETAILED DECLARATION (CUSTOMS) records
    /// </summary>
    public async Task<MetadataDto> JointDocumentOfTheDetailedDeclarationCustomsItemsMeta(
        JointDocumentOfTheDetailedDeclarationCustomsFindManyArgs findManyArgs
    )
    {
        var count = await _context
            .JointDocumentOfTheDetailedDeclarationCustomsItems.ApplyWhere(findManyArgs.Where)
            .CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one JOINT DOCUMENT OF THE DETAILED DECLARATION (CUSTOMS)
    /// </summary>
    public async Task<JointDocumentOfTheDetailedDeclarationCustoms> JointDocumentOfTheDetailedDeclarationCustoms(
        JointDocumentOfTheDetailedDeclarationCustomsWhereUniqueInput uniqueId
    )
    {
        var jointDocumentOfTheDetailedDeclarationCustomsItems =
            await this.JointDocumentOfTheDetailedDeclarationCustomsItems(
                new JointDocumentOfTheDetailedDeclarationCustomsFindManyArgs
                {
                    Where = new JointDocumentOfTheDetailedDeclarationCustomsWhereInput
                    {
                        Id = uniqueId.Id
                    }
                }
            );
        var jointDocumentOfTheDetailedDeclarationCustoms =
            jointDocumentOfTheDetailedDeclarationCustomsItems.FirstOrDefault();
        if (jointDocumentOfTheDetailedDeclarationCustoms == null)
        {
            throw new NotFoundException();
        }

        return jointDocumentOfTheDetailedDeclarationCustoms;
    }

    /// <summary>
    /// Update one JOINT DOCUMENT OF THE DETAILED DECLARATION (CUSTOMS)
    /// </summary>
    public async Task UpdateJointDocumentOfTheDetailedDeclarationCustoms(
        JointDocumentOfTheDetailedDeclarationCustomsWhereUniqueInput uniqueId,
        JointDocumentOfTheDetailedDeclarationCustomsUpdateInput updateDto
    )
    {
        var jointDocumentOfTheDetailedDeclarationCustoms = updateDto.ToModel(uniqueId);

        _context.Entry(jointDocumentOfTheDetailedDeclarationCustoms).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (
                !_context.JointDocumentOfTheDetailedDeclarationCustomsItems.Any(e =>
                    e.Id == jointDocumentOfTheDetailedDeclarationCustoms.Id
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
