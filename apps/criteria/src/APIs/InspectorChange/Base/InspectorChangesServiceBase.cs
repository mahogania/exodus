using Criteria.APIs;
using Criteria.APIs.Common;
using Criteria.APIs.Dtos;
using Criteria.APIs.Errors;
using Criteria.APIs.Extensions;
using Criteria.Infrastructure;
using Criteria.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Criteria.APIs;

public abstract class InspectorChangesServiceBase : IInspectorChangesService
{
    protected readonly CriteriaDbContext _context;

    public InspectorChangesServiceBase(CriteriaDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one Inspector Change
    /// </summary>
    public async Task<InspectorChange> CreateInspectorChange(InspectorChangeCreateInput createDto)
    {
        var inspectorChange = new InspectorChangeDbModel
        {
            CreatedAt = createDto.CreatedAt,
            DetailedDeclarationNumber = createDto.DetailedDeclarationNumber,
            InitialVerifierId = createDto.InitialVerifierId,
            InitialVisitOfficerId = createDto.InitialVisitOfficerId,
            InspectorChangeReasonCode = createDto.InspectorChangeReasonCode,
            ModificationDate = createDto.ModificationDate,
            ModificationNumber = createDto.ModificationNumber,
            ModificationResponsibleId = createDto.ModificationResponsibleId,
            NewInspectorId = createDto.NewInspectorId,
            NewVisitOfficerId = createDto.NewVisitOfficerId,
            ReasonForModification = createDto.ReasonForModification,
            UpdatedAt = createDto.UpdatedAt
        };

        if (createDto.Id != null)
        {
            inspectorChange.Id = createDto.Id;
        }

        _context.InspectorChanges.Add(inspectorChange);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<InspectorChangeDbModel>(inspectorChange.Id);

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one Inspector Change
    /// </summary>
    public async Task DeleteInspectorChange(InspectorChangeWhereUniqueInput uniqueId)
    {
        var inspectorChange = await _context.InspectorChanges.FindAsync(uniqueId.Id);
        if (inspectorChange == null)
        {
            throw new NotFoundException();
        }

        _context.InspectorChanges.Remove(inspectorChange);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many Inspector Changes
    /// </summary>
    public async Task<List<InspectorChange>> InspectorChanges(
        InspectorChangeFindManyArgs findManyArgs
    )
    {
        var inspectorChanges = await _context
            .InspectorChanges.ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return inspectorChanges.ConvertAll(inspectorChange => inspectorChange.ToDto());
    }

    /// <summary>
    /// Meta data about Inspector Change records
    /// </summary>
    public async Task<MetadataDto> InspectorChangesMeta(InspectorChangeFindManyArgs findManyArgs)
    {
        var count = await _context.InspectorChanges.ApplyWhere(findManyArgs.Where).CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one Inspector Change
    /// </summary>
    public async Task<InspectorChange> InspectorChange(InspectorChangeWhereUniqueInput uniqueId)
    {
        var inspectorChanges = await this.InspectorChanges(
            new InspectorChangeFindManyArgs
            {
                Where = new InspectorChangeWhereInput { Id = uniqueId.Id }
            }
        );
        var inspectorChange = inspectorChanges.FirstOrDefault();
        if (inspectorChange == null)
        {
            throw new NotFoundException();
        }

        return inspectorChange;
    }

    /// <summary>
    /// Update one Inspector Change
    /// </summary>
    public async Task UpdateInspectorChange(
        InspectorChangeWhereUniqueInput uniqueId,
        InspectorChangeUpdateInput updateDto
    )
    {
        var inspectorChange = updateDto.ToModel(uniqueId);

        _context.Entry(inspectorChange).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!_context.InspectorChanges.Any(e => e.Id == inspectorChange.Id))
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
