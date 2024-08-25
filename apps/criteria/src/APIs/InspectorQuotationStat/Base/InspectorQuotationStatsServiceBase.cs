using Criteria.APIs;
using Criteria.APIs.Common;
using Criteria.APIs.Dtos;
using Criteria.APIs.Errors;
using Criteria.APIs.Extensions;
using Criteria.Infrastructure;
using Criteria.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Criteria.APIs;

public abstract class InspectorQuotationStatsServiceBase : IInspectorQuotationStatsService
{
    protected readonly CriteriaDbContext _context;

    public InspectorQuotationStatsServiceBase(CriteriaDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one Inspector Quotation Stat
    /// </summary>
    public async Task<InspectorQuotationStat> CreateInspectorQuotationStat(
        InspectorQuotationStatCreateInput createDto
    )
    {
        var inspectorQuotationStat = new InspectorQuotationStatDbModel
        {
            AffectationNumber = createDto.AffectationNumber,
            AgencyCode = createDto.AgencyCode,
            CreatedAt = createDto.CreatedAt,
            InspectorId = createDto.InspectorId,
            QuotationDate = createDto.QuotationDate,
            ServiceCode = createDto.ServiceCode,
            UpdatedAt = createDto.UpdatedAt
        };

        if (createDto.Id != null)
        {
            inspectorQuotationStat.Id = createDto.Id;
        }

        _context.InspectorQuotationStats.Add(inspectorQuotationStat);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<InspectorQuotationStatDbModel>(
            inspectorQuotationStat.Id
        );

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one Inspector Quotation Stat
    /// </summary>
    public async Task DeleteInspectorQuotationStat(InspectorQuotationStatWhereUniqueInput uniqueId)
    {
        var inspectorQuotationStat = await _context.InspectorQuotationStats.FindAsync(uniqueId.Id);
        if (inspectorQuotationStat == null)
        {
            throw new NotFoundException();
        }

        _context.InspectorQuotationStats.Remove(inspectorQuotationStat);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many Inspector Quotation Stats
    /// </summary>
    public async Task<List<InspectorQuotationStat>> InspectorQuotationStats(
        InspectorQuotationStatFindManyArgs findManyArgs
    )
    {
        var inspectorQuotationStats = await _context
            .InspectorQuotationStats.ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return inspectorQuotationStats.ConvertAll(inspectorQuotationStat =>
            inspectorQuotationStat.ToDto()
        );
    }

    /// <summary>
    /// Meta data about Inspector Quotation Stat records
    /// </summary>
    public async Task<MetadataDto> InspectorQuotationStatsMeta(
        InspectorQuotationStatFindManyArgs findManyArgs
    )
    {
        var count = await _context
            .InspectorQuotationStats.ApplyWhere(findManyArgs.Where)
            .CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one Inspector Quotation Stat
    /// </summary>
    public async Task<InspectorQuotationStat> InspectorQuotationStat(
        InspectorQuotationStatWhereUniqueInput uniqueId
    )
    {
        var inspectorQuotationStats = await this.InspectorQuotationStats(
            new InspectorQuotationStatFindManyArgs
            {
                Where = new InspectorQuotationStatWhereInput { Id = uniqueId.Id }
            }
        );
        var inspectorQuotationStat = inspectorQuotationStats.FirstOrDefault();
        if (inspectorQuotationStat == null)
        {
            throw new NotFoundException();
        }

        return inspectorQuotationStat;
    }

    /// <summary>
    /// Update one Inspector Quotation Stat
    /// </summary>
    public async Task UpdateInspectorQuotationStat(
        InspectorQuotationStatWhereUniqueInput uniqueId,
        InspectorQuotationStatUpdateInput updateDto
    )
    {
        var inspectorQuotationStat = updateDto.ToModel(uniqueId);

        _context.Entry(inspectorQuotationStat).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!_context.InspectorQuotationStats.Any(e => e.Id == inspectorQuotationStat.Id))
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
