using Criteria.APIs;
using Criteria.APIs.Common;
using Criteria.APIs.Dtos;
using Criteria.APIs.Errors;
using Criteria.APIs.Extensions;
using Criteria.Infrastructure;
using Criteria.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Criteria.APIs;

public abstract class ServiceQuotationCriteriaServiceBase : IServiceQuotationCriteriaService
{
    protected readonly CriteriaDbContext _context;

    public ServiceQuotationCriteriaServiceBase(CriteriaDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one Service Quotation Criterion
    /// </summary>
    public async Task<ServiceQuotationCriterion> CreateServiceQuotationCriterion(
        ServiceQuotationCriterionCreateInput createDto
    )
    {
        var serviceQuotationCriterion = new ServiceQuotationCriterionDbModel
        {
            AgencyCode = createDto.AgencyCode,
            CreatedAt = createDto.CreatedAt,
            CriterionContent = createDto.CriterionContent,
            EndApplicationDate = createDto.EndApplicationDate,
            StartApplicationDate = createDto.StartApplicationDate,
            UpdatedAt = createDto.UpdatedAt
        };

        if (createDto.Id != null)
        {
            serviceQuotationCriterion.Id = createDto.Id;
        }

        _context.ServiceQuotationCriteria.Add(serviceQuotationCriterion);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<ServiceQuotationCriterionDbModel>(
            serviceQuotationCriterion.Id
        );

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one Service Quotation Criterion
    /// </summary>
    public async Task DeleteServiceQuotationCriterion(
        ServiceQuotationCriterionWhereUniqueInput uniqueId
    )
    {
        var serviceQuotationCriterion = await _context.ServiceQuotationCriteria.FindAsync(
            uniqueId.Id
        );
        if (serviceQuotationCriterion == null)
        {
            throw new NotFoundException();
        }

        _context.ServiceQuotationCriteria.Remove(serviceQuotationCriterion);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many Service Quotation Criteria
    /// </summary>
    public async Task<List<ServiceQuotationCriterion>> ServiceQuotationCriteria(
        ServiceQuotationCriterionFindManyArgs findManyArgs
    )
    {
        var serviceQuotationCriteria = await _context
            .ServiceQuotationCriteria.ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return serviceQuotationCriteria.ConvertAll(serviceQuotationCriterion =>
            serviceQuotationCriterion.ToDto()
        );
    }

    /// <summary>
    /// Meta data about Service Quotation Criterion records
    /// </summary>
    public async Task<MetadataDto> ServiceQuotationCriteriaMeta(
        ServiceQuotationCriterionFindManyArgs findManyArgs
    )
    {
        var count = await _context
            .ServiceQuotationCriteria.ApplyWhere(findManyArgs.Where)
            .CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one Service Quotation Criterion
    /// </summary>
    public async Task<ServiceQuotationCriterion> ServiceQuotationCriterion(
        ServiceQuotationCriterionWhereUniqueInput uniqueId
    )
    {
        var serviceQuotationCriteria = await this.ServiceQuotationCriteria(
            new ServiceQuotationCriterionFindManyArgs
            {
                Where = new ServiceQuotationCriterionWhereInput { Id = uniqueId.Id }
            }
        );
        var serviceQuotationCriterion = serviceQuotationCriteria.FirstOrDefault();
        if (serviceQuotationCriterion == null)
        {
            throw new NotFoundException();
        }

        return serviceQuotationCriterion;
    }

    /// <summary>
    /// Update one Service Quotation Criterion
    /// </summary>
    public async Task UpdateServiceQuotationCriterion(
        ServiceQuotationCriterionWhereUniqueInput uniqueId,
        ServiceQuotationCriterionUpdateInput updateDto
    )
    {
        var serviceQuotationCriterion = updateDto.ToModel(uniqueId);

        _context.Entry(serviceQuotationCriterion).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!_context.ServiceQuotationCriteria.Any(e => e.Id == serviceQuotationCriterion.Id))
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
