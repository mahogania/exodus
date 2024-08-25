using Criteria.APIs;
using Criteria.APIs.Common;
using Criteria.APIs.Dtos;
using Criteria.APIs.Errors;
using Criteria.APIs.Extensions;
using Criteria.Infrastructure;
using Criteria.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Criteria.APIs;

public abstract class InspectorRatingCriteriaServiceBase : IInspectorRatingCriteriaService
{
    protected readonly CriteriaDbContext _context;

    public InspectorRatingCriteriaServiceBase(CriteriaDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one Inspector Quotation Criterion
    /// </summary>
    public async Task<InspectorRatingCriterion> CreateInspectorRatingCriterion(
        InspectorRatingCriterionCreateInput createDto
    )
    {
        var inspectorRatingCriterion = new InspectorRatingCriterionDbModel
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
            inspectorRatingCriterion.Id = createDto.Id;
        }
        if (createDto.InspectorRatingCriteriaDeclarationModel != null)
        {
            inspectorRatingCriterion.InspectorRatingCriteriaDeclarationModel = await _context
                .InspectorRatingCriteriaDeclarationModels.Where(
                    inspectorRatingCriteriaDeclarationModel =>
                        createDto
                            .InspectorRatingCriteriaDeclarationModel.Select(t => t.Id)
                            .Contains(inspectorRatingCriteriaDeclarationModel.Id)
                )
                .ToListAsync();
        }

        if (createDto.InspectorRatingCriteriaInspector != null)
        {
            inspectorRatingCriterion.InspectorRatingCriteriaInspector = await _context
                .InspectorRatingCriteriaInspectors.Where(inspectorRatingCriteriaInspector =>
                    createDto
                        .InspectorRatingCriteriaInspector.Select(t => t.Id)
                        .Contains(inspectorRatingCriteriaInspector.Id)
                )
                .ToListAsync();
        }

        _context.InspectorRatingCriteria.Add(inspectorRatingCriterion);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<InspectorRatingCriterionDbModel>(
            inspectorRatingCriterion.Id
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
    public async Task DeleteInspectorRatingCriterion(
        InspectorRatingCriterionWhereUniqueInput uniqueId
    )
    {
        var inspectorRatingCriterion = await _context.InspectorRatingCriteria.FindAsync(
            uniqueId.Id
        );
        if (inspectorRatingCriterion == null)
        {
            throw new NotFoundException();
        }

        _context.InspectorRatingCriteria.Remove(inspectorRatingCriterion);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many Inspector Rating Criteria
    /// </summary>
    public async Task<List<InspectorRatingCriterion>> InspectorRatingCriteria(
        InspectorRatingCriterionFindManyArgs findManyArgs
    )
    {
        var inspectorRatingCriteria = await _context
            .InspectorRatingCriteria.Include(x => x.InspectorRatingCriteriaDeclarationModel)
            .Include(x => x.InspectorRatingCriteriaInspector)
            .ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return inspectorRatingCriteria.ConvertAll(inspectorRatingCriterion =>
            inspectorRatingCriterion.ToDto()
        );
    }

    /// <summary>
    /// Meta data about Inspector Quotation Criterion records
    /// </summary>
    public async Task<MetadataDto> InspectorRatingCriteriaMeta(
        InspectorRatingCriterionFindManyArgs findManyArgs
    )
    {
        var count = await _context
            .InspectorRatingCriteria.ApplyWhere(findManyArgs.Where)
            .CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one Inspector Quotation Criterion
    /// </summary>
    public async Task<InspectorRatingCriterion> InspectorRatingCriterion(
        InspectorRatingCriterionWhereUniqueInput uniqueId
    )
    {
        var inspectorRatingCriteria = await this.InspectorRatingCriteria(
            new InspectorRatingCriterionFindManyArgs
            {
                Where = new InspectorRatingCriterionWhereInput { Id = uniqueId.Id }
            }
        );
        var inspectorRatingCriterion = inspectorRatingCriteria.FirstOrDefault();
        if (inspectorRatingCriterion == null)
        {
            throw new NotFoundException();
        }

        return inspectorRatingCriterion;
    }

    /// <summary>
    /// Update one Inspector Quotation Criterion
    /// </summary>
    public async Task UpdateInspectorRatingCriterion(
        InspectorRatingCriterionWhereUniqueInput uniqueId,
        InspectorRatingCriterionUpdateInput updateDto
    )
    {
        var inspectorRatingCriterion = updateDto.ToModel(uniqueId);

        if (updateDto.InspectorRatingCriteriaDeclarationModel != null)
        {
            inspectorRatingCriterion.InspectorRatingCriteriaDeclarationModel = await _context
                .InspectorRatingCriteriaDeclarationModels.Where(
                    inspectorRatingCriteriaDeclarationModel =>
                        updateDto
                            .InspectorRatingCriteriaDeclarationModel.Select(t => t)
                            .Contains(inspectorRatingCriteriaDeclarationModel.Id)
                )
                .ToListAsync();
        }

        if (updateDto.InspectorRatingCriteriaInspector != null)
        {
            inspectorRatingCriterion.InspectorRatingCriteriaInspector = await _context
                .InspectorRatingCriteriaInspectors.Where(inspectorRatingCriteriaInspector =>
                    updateDto
                        .InspectorRatingCriteriaInspector.Select(t => t)
                        .Contains(inspectorRatingCriteriaInspector.Id)
                )
                .ToListAsync();
        }

        _context.Entry(inspectorRatingCriterion).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!_context.InspectorRatingCriteria.Any(e => e.Id == inspectorRatingCriterion.Id))
            {
                throw new NotFoundException();
            }
            else
            {
                throw;
            }
        }
    }

    /// <summary>
    /// Connect multiple  Inspector Rating Criteria Declaration Model  records to Inspector Quotation Criterion
    /// </summary>
    public async Task ConnectInspectorRatingCriteriaDeclarationModel(
        InspectorRatingCriterionWhereUniqueInput uniqueId,
        InspectorRatingCriteriaDeclarationModelWhereUniqueInput[] inspectorRatingCriteriaDeclarationModelsId
    )
    {
        var parent = await _context
            .InspectorRatingCriteria.Include(x => x.InspectorRatingCriteriaDeclarationModel)
            .FirstOrDefaultAsync(x => x.Id == uniqueId.Id);
        if (parent == null)
        {
            throw new NotFoundException();
        }

        var inspectorRatingCriteriaDeclarationModels = await _context
            .InspectorRatingCriteriaDeclarationModels.Where(t =>
                inspectorRatingCriteriaDeclarationModelsId.Select(x => x.Id).Contains(t.Id)
            )
            .ToListAsync();
        if (inspectorRatingCriteriaDeclarationModels.Count == 0)
        {
            throw new NotFoundException();
        }

        var inspectorRatingCriteriaDeclarationModelsToConnect =
            inspectorRatingCriteriaDeclarationModels.Except(
                parent.InspectorRatingCriteriaDeclarationModel
            );

        foreach (
            var inspectorRatingCriteriaDeclarationModel in inspectorRatingCriteriaDeclarationModelsToConnect
        )
        {
            parent.InspectorRatingCriteriaDeclarationModel.Add(
                inspectorRatingCriteriaDeclarationModel
            );
        }

        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Disconnect multiple  Inspector Rating Criteria Declaration Model  records from Inspector Quotation Criterion
    /// </summary>
    public async Task DisconnectInspectorRatingCriteriaDeclarationModel(
        InspectorRatingCriterionWhereUniqueInput uniqueId,
        InspectorRatingCriteriaDeclarationModelWhereUniqueInput[] inspectorRatingCriteriaDeclarationModelsId
    )
    {
        var parent = await _context
            .InspectorRatingCriteria.Include(x => x.InspectorRatingCriteriaDeclarationModel)
            .FirstOrDefaultAsync(x => x.Id == uniqueId.Id);
        if (parent == null)
        {
            throw new NotFoundException();
        }

        var inspectorRatingCriteriaDeclarationModels = await _context
            .InspectorRatingCriteriaDeclarationModels.Where(t =>
                inspectorRatingCriteriaDeclarationModelsId.Select(x => x.Id).Contains(t.Id)
            )
            .ToListAsync();

        foreach (
            var inspectorRatingCriteriaDeclarationModel in inspectorRatingCriteriaDeclarationModels
        )
        {
            parent.InspectorRatingCriteriaDeclarationModel?.Remove(
                inspectorRatingCriteriaDeclarationModel
            );
        }
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find multiple  Inspector Rating Criteria Declaration Model  records for Inspector Quotation Criterion
    /// </summary>
    public async Task<
        List<InspectorRatingCriteriaDeclarationModel>
    > FindInspectorRatingCriteriaDeclarationModel(
        InspectorRatingCriterionWhereUniqueInput uniqueId,
        InspectorRatingCriteriaDeclarationModelFindManyArgs inspectorRatingCriterionFindManyArgs
    )
    {
        var inspectorRatingCriteriaDeclarationModels = await _context
            .InspectorRatingCriteriaDeclarationModels.Where(m =>
                m.InspectorRatingCriteriaId == uniqueId.Id
            )
            .ApplyWhere(inspectorRatingCriterionFindManyArgs.Where)
            .ApplySkip(inspectorRatingCriterionFindManyArgs.Skip)
            .ApplyTake(inspectorRatingCriterionFindManyArgs.Take)
            .ApplyOrderBy(inspectorRatingCriterionFindManyArgs.SortBy)
            .ToListAsync();

        return inspectorRatingCriteriaDeclarationModels.Select(x => x.ToDto()).ToList();
    }

    /// <summary>
    /// Update multiple  Inspector Rating Criteria Declaration Model  records for Inspector Quotation Criterion
    /// </summary>
    public async Task UpdateInspectorRatingCriteriaDeclarationModel(
        InspectorRatingCriterionWhereUniqueInput uniqueId,
        InspectorRatingCriteriaDeclarationModelWhereUniqueInput[] inspectorRatingCriteriaDeclarationModelsId
    )
    {
        var inspectorRatingCriterion = await _context
            .InspectorRatingCriteria.Include(t => t.InspectorRatingCriteriaDeclarationModel)
            .FirstOrDefaultAsync(x => x.Id == uniqueId.Id);
        if (inspectorRatingCriterion == null)
        {
            throw new NotFoundException();
        }

        var inspectorRatingCriteriaDeclarationModels = await _context
            .InspectorRatingCriteriaDeclarationModels.Where(a =>
                inspectorRatingCriteriaDeclarationModelsId.Select(x => x.Id).Contains(a.Id)
            )
            .ToListAsync();

        if (inspectorRatingCriteriaDeclarationModels.Count == 0)
        {
            throw new NotFoundException();
        }

        inspectorRatingCriterion.InspectorRatingCriteriaDeclarationModel =
            inspectorRatingCriteriaDeclarationModels;
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Connect multiple Inspector Rating Criteria Inspector records to Inspector Quotation Criterion
    /// </summary>
    public async Task ConnectInspectorRatingCriteriaInspector(
        InspectorRatingCriterionWhereUniqueInput uniqueId,
        InspectorRatingCriteriaInspectorWhereUniqueInput[] inspectorRatingCriteriaInspectorsId
    )
    {
        var parent = await _context
            .InspectorRatingCriteria.Include(x => x.InspectorRatingCriteriaInspector)
            .FirstOrDefaultAsync(x => x.Id == uniqueId.Id);
        if (parent == null)
        {
            throw new NotFoundException();
        }

        var inspectorRatingCriteriaInspectors = await _context
            .InspectorRatingCriteriaInspectors.Where(t =>
                inspectorRatingCriteriaInspectorsId.Select(x => x.Id).Contains(t.Id)
            )
            .ToListAsync();
        if (inspectorRatingCriteriaInspectors.Count == 0)
        {
            throw new NotFoundException();
        }

        var inspectorRatingCriteriaInspectorsToConnect = inspectorRatingCriteriaInspectors.Except(
            parent.InspectorRatingCriteriaInspector
        );

        foreach (var inspectorRatingCriteriaInspector in inspectorRatingCriteriaInspectorsToConnect)
        {
            parent.InspectorRatingCriteriaInspector.Add(inspectorRatingCriteriaInspector);
        }

        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Disconnect multiple Inspector Rating Criteria Inspector records from Inspector Quotation Criterion
    /// </summary>
    public async Task DisconnectInspectorRatingCriteriaInspector(
        InspectorRatingCriterionWhereUniqueInput uniqueId,
        InspectorRatingCriteriaInspectorWhereUniqueInput[] inspectorRatingCriteriaInspectorsId
    )
    {
        var parent = await _context
            .InspectorRatingCriteria.Include(x => x.InspectorRatingCriteriaInspector)
            .FirstOrDefaultAsync(x => x.Id == uniqueId.Id);
        if (parent == null)
        {
            throw new NotFoundException();
        }

        var inspectorRatingCriteriaInspectors = await _context
            .InspectorRatingCriteriaInspectors.Where(t =>
                inspectorRatingCriteriaInspectorsId.Select(x => x.Id).Contains(t.Id)
            )
            .ToListAsync();

        foreach (var inspectorRatingCriteriaInspector in inspectorRatingCriteriaInspectors)
        {
            parent.InspectorRatingCriteriaInspector?.Remove(inspectorRatingCriteriaInspector);
        }
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find multiple Inspector Rating Criteria Inspector records for Inspector Quotation Criterion
    /// </summary>
    public async Task<List<InspectorRatingCriteriaInspector>> FindInspectorRatingCriteriaInspector(
        InspectorRatingCriterionWhereUniqueInput uniqueId,
        InspectorRatingCriteriaInspectorFindManyArgs inspectorRatingCriterionFindManyArgs
    )
    {
        var inspectorRatingCriteriaInspectors = await _context
            .InspectorRatingCriteriaInspectors.Where(m =>
                m.InspectorRatingCriteriaId == uniqueId.Id
            )
            .ApplyWhere(inspectorRatingCriterionFindManyArgs.Where)
            .ApplySkip(inspectorRatingCriterionFindManyArgs.Skip)
            .ApplyTake(inspectorRatingCriterionFindManyArgs.Take)
            .ApplyOrderBy(inspectorRatingCriterionFindManyArgs.SortBy)
            .ToListAsync();

        return inspectorRatingCriteriaInspectors.Select(x => x.ToDto()).ToList();
    }

    /// <summary>
    /// Update multiple Inspector Rating Criteria Inspector records for Inspector Quotation Criterion
    /// </summary>
    public async Task UpdateInspectorRatingCriteriaInspector(
        InspectorRatingCriterionWhereUniqueInput uniqueId,
        InspectorRatingCriteriaInspectorWhereUniqueInput[] inspectorRatingCriteriaInspectorsId
    )
    {
        var inspectorRatingCriterion = await _context
            .InspectorRatingCriteria.Include(t => t.InspectorRatingCriteriaInspector)
            .FirstOrDefaultAsync(x => x.Id == uniqueId.Id);
        if (inspectorRatingCriterion == null)
        {
            throw new NotFoundException();
        }

        var inspectorRatingCriteriaInspectors = await _context
            .InspectorRatingCriteriaInspectors.Where(a =>
                inspectorRatingCriteriaInspectorsId.Select(x => x.Id).Contains(a.Id)
            )
            .ToListAsync();

        if (inspectorRatingCriteriaInspectors.Count == 0)
        {
            throw new NotFoundException();
        }

        inspectorRatingCriterion.InspectorRatingCriteriaInspector =
            inspectorRatingCriteriaInspectors;
        await _context.SaveChangesAsync();
    }
}
