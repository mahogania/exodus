using Criteria.APIs;
using Criteria.APIs.Common;
using Criteria.APIs.Dtos;
using Criteria.APIs.Errors;
using Criteria.APIs.Extensions;
using Criteria.Infrastructure;
using Criteria.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Criteria.APIs;

public abstract class InspectorQuotationModesServiceBase : IInspectorQuotationModesService
{
    protected readonly CriteriaDbContext _context;

    public InspectorQuotationModesServiceBase(CriteriaDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one Inspector Quotation Mode
    /// </summary>
    public async Task<InspectorQuotationMode> CreateInspectorQuotationMode(
        InspectorQuotationModeCreateInput createDto
    )
    {
        var inspectorQuotationMode = new InspectorQuotationModeDbModel
        {
            AgencyCode = createDto.AgencyCode,
            CreatedAt = createDto.CreatedAt,
            DeclarationTypeCode = createDto.DeclarationTypeCode,
            QuotationModeType = createDto.QuotationModeType,
            ServiceCode = createDto.ServiceCode,
            UpdatedAt = createDto.UpdatedAt
        };

        if (createDto.Id != null)
        {
            inspectorQuotationMode.Id = createDto.Id;
        }

        _context.InspectorQuotationModes.Add(inspectorQuotationMode);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<InspectorQuotationModeDbModel>(
            inspectorQuotationMode.Id
        );

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one Inspector Quotation Mode
    /// </summary>
    public async Task DeleteInspectorQuotationMode(InspectorQuotationModeWhereUniqueInput uniqueId)
    {
        var inspectorQuotationMode = await _context.InspectorQuotationModes.FindAsync(uniqueId.Id);
        if (inspectorQuotationMode == null)
        {
            throw new NotFoundException();
        }

        _context.InspectorQuotationModes.Remove(inspectorQuotationMode);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many Inspector Quotation Modes
    /// </summary>
    public async Task<List<InspectorQuotationMode>> InspectorQuotationModes(
        InspectorQuotationModeFindManyArgs findManyArgs
    )
    {
        var inspectorQuotationModes = await _context
            .InspectorQuotationModes.ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return inspectorQuotationModes.ConvertAll(inspectorQuotationMode =>
            inspectorQuotationMode.ToDto()
        );
    }

    /// <summary>
    /// Meta data about Inspector Quotation Mode records
    /// </summary>
    public async Task<MetadataDto> InspectorQuotationModesMeta(
        InspectorQuotationModeFindManyArgs findManyArgs
    )
    {
        var count = await _context
            .InspectorQuotationModes.ApplyWhere(findManyArgs.Where)
            .CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one Inspector Quotation Mode
    /// </summary>
    public async Task<InspectorQuotationMode> InspectorQuotationMode(
        InspectorQuotationModeWhereUniqueInput uniqueId
    )
    {
        var inspectorQuotationModes = await this.InspectorQuotationModes(
            new InspectorQuotationModeFindManyArgs
            {
                Where = new InspectorQuotationModeWhereInput { Id = uniqueId.Id }
            }
        );
        var inspectorQuotationMode = inspectorQuotationModes.FirstOrDefault();
        if (inspectorQuotationMode == null)
        {
            throw new NotFoundException();
        }

        return inspectorQuotationMode;
    }

    /// <summary>
    /// Update one Inspector Quotation Mode
    /// </summary>
    public async Task UpdateInspectorQuotationMode(
        InspectorQuotationModeWhereUniqueInput uniqueId,
        InspectorQuotationModeUpdateInput updateDto
    )
    {
        var inspectorQuotationMode = updateDto.ToModel(uniqueId);

        _context.Entry(inspectorQuotationMode).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!_context.InspectorQuotationModes.Any(e => e.Id == inspectorQuotationMode.Id))
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
