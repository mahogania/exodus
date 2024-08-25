using Criteria.APIs;
using Criteria.APIs.Common;
using Criteria.APIs.Dtos;
using Criteria.APIs.Errors;
using Criteria.APIs.Extensions;
using Criteria.Infrastructure;
using Criteria.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Criteria.APIs;

public abstract class InspectorRatingCriteriaInspectorsServiceBase
    : IInspectorRatingCriteriaInspectorsService
{
    protected readonly CriteriaDbContext _context;

    public InspectorRatingCriteriaInspectorsServiceBase(CriteriaDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one Inspector Rating Criteria Inspector
    /// </summary>
    public async Task<InspectorRatingCriteriaInspector> CreateInspectorRatingCriteriaInspector(
        InspectorRatingCriteriaInspectorCreateInput createDto
    )
    {
        var inspectorRatingCriteriaInspector = new InspectorRatingCriteriaInspectorDbModel
        {
            CreatedAt = createDto.CreatedAt,
            FieldSequenceNumber = createDto.FieldSequenceNumber,
            InspectorId = createDto.InspectorId,
            OfficeCode = createDto.OfficeCode,
            ServiceCode = createDto.ServiceCode,
            UpdatedAt = createDto.UpdatedAt
        };

        if (createDto.Id != null)
        {
            inspectorRatingCriteriaInspector.Id = createDto.Id;
        }

        _context.InspectorRatingCriteriaInspectors.Add(inspectorRatingCriteriaInspector);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<InspectorRatingCriteriaInspectorDbModel>(
            inspectorRatingCriteriaInspector.Id
        );

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one Inspector Rating Criteria Inspector
    /// </summary>
    public async Task DeleteInspectorRatingCriteriaInspector(
        InspectorRatingCriteriaInspectorWhereUniqueInput uniqueId
    )
    {
        var inspectorRatingCriteriaInspector =
            await _context.InspectorRatingCriteriaInspectors.FindAsync(uniqueId.Id);
        if (inspectorRatingCriteriaInspector == null)
        {
            throw new NotFoundException();
        }

        _context.InspectorRatingCriteriaInspectors.Remove(inspectorRatingCriteriaInspector);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many Inspector Rating Criteria Inspectors
    /// </summary>
    public async Task<List<InspectorRatingCriteriaInspector>> InspectorRatingCriteriaInspectors(
        InspectorRatingCriteriaInspectorFindManyArgs findManyArgs
    )
    {
        var inspectorRatingCriteriaInspectors = await _context
            .InspectorRatingCriteriaInspectors.ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return inspectorRatingCriteriaInspectors.ConvertAll(inspectorRatingCriteriaInspector =>
            inspectorRatingCriteriaInspector.ToDto()
        );
    }

    /// <summary>
    /// Meta data about Inspector Rating Criteria Inspector records
    /// </summary>
    public async Task<MetadataDto> InspectorRatingCriteriaInspectorsMeta(
        InspectorRatingCriteriaInspectorFindManyArgs findManyArgs
    )
    {
        var count = await _context
            .InspectorRatingCriteriaInspectors.ApplyWhere(findManyArgs.Where)
            .CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one Inspector Rating Criteria Inspector
    /// </summary>
    public async Task<InspectorRatingCriteriaInspector> InspectorRatingCriteriaInspector(
        InspectorRatingCriteriaInspectorWhereUniqueInput uniqueId
    )
    {
        var inspectorRatingCriteriaInspectors = await this.InspectorRatingCriteriaInspectors(
            new InspectorRatingCriteriaInspectorFindManyArgs
            {
                Where = new InspectorRatingCriteriaInspectorWhereInput { Id = uniqueId.Id }
            }
        );
        var inspectorRatingCriteriaInspector = inspectorRatingCriteriaInspectors.FirstOrDefault();
        if (inspectorRatingCriteriaInspector == null)
        {
            throw new NotFoundException();
        }

        return inspectorRatingCriteriaInspector;
    }

    /// <summary>
    /// Update one Inspector Rating Criteria Inspector
    /// </summary>
    public async Task UpdateInspectorRatingCriteriaInspector(
        InspectorRatingCriteriaInspectorWhereUniqueInput uniqueId,
        InspectorRatingCriteriaInspectorUpdateInput updateDto
    )
    {
        var inspectorRatingCriteriaInspector = updateDto.ToModel(uniqueId);

        _context.Entry(inspectorRatingCriteriaInspector).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (
                !_context.InspectorRatingCriteriaInspectors.Any(e =>
                    e.Id == inspectorRatingCriteriaInspector.Id
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
