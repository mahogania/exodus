using Criteria.APIs;
using Criteria.APIs.Common;
using Criteria.APIs.Dtos;
using Criteria.APIs.Errors;
using Criteria.APIs.Extensions;
using Criteria.Infrastructure;
using Criteria.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Criteria.APIs;

public abstract class InspectorRatingCriteriaDeclarationModelsServiceBase
    : IInspectorRatingCriteriaDeclarationModelsService
{
    protected readonly CriteriaDbContext _context;

    public InspectorRatingCriteriaDeclarationModelsServiceBase(CriteriaDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one Inspector Rating Criteria Declaration Model
    /// </summary>
    public async Task<InspectorRatingCriteriaDeclarationModel> CreateInspectorRatingCriteriaDeclarationModel(
        InspectorRatingCriteriaDeclarationModelCreateInput createDto
    )
    {
        var inspectorRatingCriteriaDeclarationModel =
            new InspectorRatingCriteriaDeclarationModelDbModel
            {
                CreatedAt = createDto.CreatedAt,
                DeclarationTypeCode = createDto.DeclarationTypeCode,
                FieldSequenceNumber = createDto.FieldSequenceNumber,
                OfficeCode = createDto.OfficeCode,
                ServiceCode = createDto.ServiceCode,
                UpdatedAt = createDto.UpdatedAt
            };

        if (createDto.Id != null)
        {
            inspectorRatingCriteriaDeclarationModel.Id = createDto.Id;
        }

        _context.InspectorRatingCriteriaDeclarationModels.Add(
            inspectorRatingCriteriaDeclarationModel
        );
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<InspectorRatingCriteriaDeclarationModelDbModel>(
            inspectorRatingCriteriaDeclarationModel.Id
        );

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one Inspector Rating Criteria Declaration Model
    /// </summary>
    public async Task DeleteInspectorRatingCriteriaDeclarationModel(
        InspectorRatingCriteriaDeclarationModelWhereUniqueInput uniqueId
    )
    {
        var inspectorRatingCriteriaDeclarationModel =
            await _context.InspectorRatingCriteriaDeclarationModels.FindAsync(uniqueId.Id);
        if (inspectorRatingCriteriaDeclarationModel == null)
        {
            throw new NotFoundException();
        }

        _context.InspectorRatingCriteriaDeclarationModels.Remove(
            inspectorRatingCriteriaDeclarationModel
        );
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many Inspector Rating Criteria Declaration Models
    /// </summary>
    public async Task<
        List<InspectorRatingCriteriaDeclarationModel>
    > InspectorRatingCriteriaDeclarationModels(
        InspectorRatingCriteriaDeclarationModelFindManyArgs findManyArgs
    )
    {
        var inspectorRatingCriteriaDeclarationModels = await _context
            .InspectorRatingCriteriaDeclarationModels.ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return inspectorRatingCriteriaDeclarationModels.ConvertAll(
            inspectorRatingCriteriaDeclarationModel =>
                inspectorRatingCriteriaDeclarationModel.ToDto()
        );
    }

    /// <summary>
    /// Meta data about Inspector Rating Criteria Declaration Model records
    /// </summary>
    public async Task<MetadataDto> InspectorRatingCriteriaDeclarationModelsMeta(
        InspectorRatingCriteriaDeclarationModelFindManyArgs findManyArgs
    )
    {
        var count = await _context
            .InspectorRatingCriteriaDeclarationModels.ApplyWhere(findManyArgs.Where)
            .CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one Inspector Rating Criteria Declaration Model
    /// </summary>
    public async Task<InspectorRatingCriteriaDeclarationModel> InspectorRatingCriteriaDeclarationModel(
        InspectorRatingCriteriaDeclarationModelWhereUniqueInput uniqueId
    )
    {
        var inspectorRatingCriteriaDeclarationModels =
            await this.InspectorRatingCriteriaDeclarationModels(
                new InspectorRatingCriteriaDeclarationModelFindManyArgs
                {
                    Where = new InspectorRatingCriteriaDeclarationModelWhereInput
                    {
                        Id = uniqueId.Id
                    }
                }
            );
        var inspectorRatingCriteriaDeclarationModel =
            inspectorRatingCriteriaDeclarationModels.FirstOrDefault();
        if (inspectorRatingCriteriaDeclarationModel == null)
        {
            throw new NotFoundException();
        }

        return inspectorRatingCriteriaDeclarationModel;
    }

    /// <summary>
    /// Update one Inspector Rating Criteria Declaration Model
    /// </summary>
    public async Task UpdateInspectorRatingCriteriaDeclarationModel(
        InspectorRatingCriteriaDeclarationModelWhereUniqueInput uniqueId,
        InspectorRatingCriteriaDeclarationModelUpdateInput updateDto
    )
    {
        var inspectorRatingCriteriaDeclarationModel = updateDto.ToModel(uniqueId);

        _context.Entry(inspectorRatingCriteriaDeclarationModel).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (
                !_context.InspectorRatingCriteriaDeclarationModels.Any(e =>
                    e.Id == inspectorRatingCriteriaDeclarationModel.Id
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
