using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Control.APIs.Extensions;
using Control.Infrastructure;
using Control.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Control.APIs;

public abstract class ModelSpecificationOfTheDetailedDeclarationCustomsItemsServiceBase
    : IModelSpecificationOfTheDetailedDeclarationCustomsItemsService
{
    protected readonly ControlDbContext _context;

    public ModelSpecificationOfTheDetailedDeclarationCustomsItemsServiceBase(
        ControlDbContext context
    )
    {
        _context = context;
    }

    /// <summary>
    ///     Create one MODEL/SPECIFICATION OF THE DETAILED DECLARATION (CUSTOMS)
    /// </summary>
    public async Task<ModelSpecificationOfTheDetailedDeclarationCustoms>
        CreateModelSpecificationOfTheDetailedDeclarationCustoms(
            ModelSpecificationOfTheDetailedDeclarationCustomsCreateInput createDto
        )
    {
        var modelSpecificationOfTheDetailedDeclarationCustoms =
            new ModelSpecificationOfTheDetailedDeclarationCustomsDbModel
            {
                CreatedAt = createDto.CreatedAt,
                UpdatedAt = createDto.UpdatedAt
            };

        if (createDto.Id != null) modelSpecificationOfTheDetailedDeclarationCustoms.Id = createDto.Id;

        _context.ModelSpecificationOfTheDetailedDeclarationCustomsItems.Add(
            modelSpecificationOfTheDetailedDeclarationCustoms
        );
        await _context.SaveChangesAsync();

        var result =
            await _context.FindAsync<ModelSpecificationOfTheDetailedDeclarationCustomsDbModel>(
                modelSpecificationOfTheDetailedDeclarationCustoms.Id
            );

        if (result == null) throw new NotFoundException();

        return result.ToDto();
    }

    /// <summary>
    ///     Delete one MODEL/SPECIFICATION OF THE DETAILED DECLARATION (CUSTOMS)
    /// </summary>
    public async Task DeleteModelSpecificationOfTheDetailedDeclarationCustoms(
        ModelSpecificationOfTheDetailedDeclarationCustomsWhereUniqueInput uniqueId
    )
    {
        var modelSpecificationOfTheDetailedDeclarationCustoms =
            await _context.ModelSpecificationOfTheDetailedDeclarationCustomsItems.FindAsync(
                uniqueId.Id
            );
        if (modelSpecificationOfTheDetailedDeclarationCustoms == null) throw new NotFoundException();

        _context.ModelSpecificationOfTheDetailedDeclarationCustomsItems.Remove(
            modelSpecificationOfTheDetailedDeclarationCustoms
        );
        await _context.SaveChangesAsync();
    }

    /// <summary>
    ///     Find many MODEL/SPECIFICATION OF THE DETAILED DECLARATION (CUSTOMS)s
    /// </summary>
    public async Task<
        List<ModelSpecificationOfTheDetailedDeclarationCustoms>
    > ModelSpecificationOfTheDetailedDeclarationCustomsItems(
        ModelSpecificationOfTheDetailedDeclarationCustomsFindManyArgs findManyArgs
    )
    {
        var modelSpecificationOfTheDetailedDeclarationCustomsItems = await _context
            .ModelSpecificationOfTheDetailedDeclarationCustomsItems.ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return modelSpecificationOfTheDetailedDeclarationCustomsItems.ConvertAll(
            modelSpecificationOfTheDetailedDeclarationCustoms =>
                modelSpecificationOfTheDetailedDeclarationCustoms.ToDto()
        );
    }

    /// <summary>
    ///     Meta data about MODEL/SPECIFICATION OF THE DETAILED DECLARATION (CUSTOMS) records
    /// </summary>
    public async Task<MetadataDto> ModelSpecificationOfTheDetailedDeclarationCustomsItemsMeta(
        ModelSpecificationOfTheDetailedDeclarationCustomsFindManyArgs findManyArgs
    )
    {
        var count = await _context
            .ModelSpecificationOfTheDetailedDeclarationCustomsItems.ApplyWhere(findManyArgs.Where)
            .CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    ///     Get one MODEL/SPECIFICATION OF THE DETAILED DECLARATION (CUSTOMS)
    /// </summary>
    public async Task<ModelSpecificationOfTheDetailedDeclarationCustoms>
        ModelSpecificationOfTheDetailedDeclarationCustoms(
            ModelSpecificationOfTheDetailedDeclarationCustomsWhereUniqueInput uniqueId
        )
    {
        var modelSpecificationOfTheDetailedDeclarationCustomsItems =
            await ModelSpecificationOfTheDetailedDeclarationCustomsItems(
                new ModelSpecificationOfTheDetailedDeclarationCustomsFindManyArgs
                {
                    Where = new ModelSpecificationOfTheDetailedDeclarationCustomsWhereInput
                    {
                        Id = uniqueId.Id
                    }
                }
            );
        var modelSpecificationOfTheDetailedDeclarationCustoms =
            modelSpecificationOfTheDetailedDeclarationCustomsItems.FirstOrDefault();
        if (modelSpecificationOfTheDetailedDeclarationCustoms == null) throw new NotFoundException();

        return modelSpecificationOfTheDetailedDeclarationCustoms;
    }

    /// <summary>
    ///     Update one MODEL/SPECIFICATION OF THE DETAILED DECLARATION (CUSTOMS)
    /// </summary>
    public async Task UpdateModelSpecificationOfTheDetailedDeclarationCustoms(
        ModelSpecificationOfTheDetailedDeclarationCustomsWhereUniqueInput uniqueId,
        ModelSpecificationOfTheDetailedDeclarationCustomsUpdateInput updateDto
    )
    {
        var modelSpecificationOfTheDetailedDeclarationCustoms = updateDto.ToModel(uniqueId);

        _context.Entry(modelSpecificationOfTheDetailedDeclarationCustoms).State =
            EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (
                !_context.ModelSpecificationOfTheDetailedDeclarationCustomsItems.Any(e =>
                    e.Id == modelSpecificationOfTheDetailedDeclarationCustoms.Id
                )
            )
                throw new NotFoundException();
            throw;
        }
    }
}
