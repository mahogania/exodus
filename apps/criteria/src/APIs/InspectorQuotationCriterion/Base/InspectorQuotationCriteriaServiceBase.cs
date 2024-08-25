using Criteria.APIs;
using Criteria.APIs.Common;
using Criteria.APIs.Dtos;
using Criteria.APIs.Errors;
using Criteria.APIs.Extensions;
using Criteria.Infrastructure;
using Criteria.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Criteria.APIs;

public abstract class InspectorQuotationCriteriaServiceBase : IInspectorQuotationCriteriaService
{
    protected readonly CriteriaDbContext _context;

    public InspectorQuotationCriteriaServiceBase(CriteriaDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one Inspector Quotation Criterion
    /// </summary>
    public async Task<InspectorQuotationCriterion> CreateInspectorQuotationCriterion(
        InspectorQuotationCriterionCreateInput createDto
    )
    {
        var inspectorQuotationCriterion = new InspectorQuotationCriterionDbModel
        {
            AgencyCode = createDto.AgencyCode,
            ApplicationPriority = createDto.ApplicationPriority,
            CreatedAt = createDto.CreatedAt,
            EndApcCode = createDto.EndApcCode,
            EndFieldShCode = createDto.EndFieldShCode,
            ServiceCode = createDto.ServiceCode,
            StartApcCode = createDto.StartApcCode,
            StartFieldShCode = createDto.StartFieldShCode,
            UpdatedAt = createDto.UpdatedAt
        };

        if (createDto.Id != null)
        {
            inspectorQuotationCriterion.Id = createDto.Id;
        }

        _context.InspectorQuotationCriteria.Add(inspectorQuotationCriterion);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<InspectorQuotationCriterionDbModel>(
            inspectorQuotationCriterion.Id
        );

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one Inspector Quotation Criterion
    /// </summary>
    public async Task DeleteInspectorQuotationCriterion(
        InspectorQuotationCriterionWhereUniqueInput uniqueId
    )
    {
        var inspectorQuotationCriterion = await _context.InspectorQuotationCriteria.FindAsync(
            uniqueId.Id
        );
        if (inspectorQuotationCriterion == null)
        {
            throw new NotFoundException();
        }

        _context.InspectorQuotationCriteria.Remove(inspectorQuotationCriterion);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many Inspector Quotation Criteria
    /// </summary>
    public async Task<List<InspectorQuotationCriterion>> InspectorQuotationCriteria(
        InspectorQuotationCriterionFindManyArgs findManyArgs
    )
    {
        var inspectorQuotationCriteria = await _context
            .InspectorQuotationCriteria.ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return inspectorQuotationCriteria.ConvertAll(inspectorQuotationCriterion =>
            inspectorQuotationCriterion.ToDto()
        );
    }

    /// <summary>
    /// Meta data about Inspector Quotation Criterion records
    /// </summary>
    public async Task<MetadataDto> InspectorQuotationCriteriaMeta(
        InspectorQuotationCriterionFindManyArgs findManyArgs
    )
    {
        var count = await _context
            .InspectorQuotationCriteria.ApplyWhere(findManyArgs.Where)
            .CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one Inspector Quotation Criterion
    /// </summary>
    public async Task<InspectorQuotationCriterion> InspectorQuotationCriterion(
        InspectorQuotationCriterionWhereUniqueInput uniqueId
    )
    {
        var inspectorQuotationCriteria = await this.InspectorQuotationCriteria(
            new InspectorQuotationCriterionFindManyArgs
            {
                Where = new InspectorQuotationCriterionWhereInput { Id = uniqueId.Id }
            }
        );
        var inspectorQuotationCriterion = inspectorQuotationCriteria.FirstOrDefault();
        if (inspectorQuotationCriterion == null)
        {
            throw new NotFoundException();
        }

        return inspectorQuotationCriterion;
    }

    /// <summary>
    /// Update one Inspector Quotation Criterion
    /// </summary>
    public async Task UpdateInspectorQuotationCriterion(
        InspectorQuotationCriterionWhereUniqueInput uniqueId,
        InspectorQuotationCriterionUpdateInput updateDto
    )
    {
        var inspectorQuotationCriterion = updateDto.ToModel(uniqueId);

        _context.Entry(inspectorQuotationCriterion).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (
                !_context.InspectorQuotationCriteria.Any(e =>
                    e.Id == inspectorQuotationCriterion.Id
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
