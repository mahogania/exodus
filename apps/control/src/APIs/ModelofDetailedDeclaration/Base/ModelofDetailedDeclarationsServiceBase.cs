using Control.APIs;
using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Control.APIs.Extensions;
using Control.Infrastructure;
using Control.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Control.APIs;

public abstract class ModelofDetailedDeclarationsServiceBase : IModelofDetailedDeclarationsService
{
    protected readonly ControlDbContext _context;

    public ModelofDetailedDeclarationsServiceBase(ControlDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one Model of Detailed Declaration
    /// </summary>
    public async Task<ModelofDetailedDeclaration> CreateModelofDetailedDeclaration(
        ModelofDetailedDeclarationCreateInput createDto
    )
    {
        var modelofDetailedDeclaration = new ModelofDetailedDeclarationDbModel
        {
            CreatedAt = createDto.CreatedAt,
            DateAndTimeOfFinalModification = createDto.DateAndTimeOfFinalModification,
            DateAndTimeOfFirstRegistration = createDto.DateAndTimeOfFirstRegistration,
            DeletionOn = createDto.DeletionOn,
            FinalModifierId = createDto.FinalModifierId,
            FirstRegistrarId = createDto.FirstRegistrarId,
            InvoiceAmount = createDto.InvoiceAmount,
            ModelAndSpecificationNameComponent = createDto.ModelAndSpecificationNameComponent,
            Quantity = createDto.Quantity,
            UnitOfQuantityCode = createDto.UnitOfQuantityCode,
            UnitPrice = createDto.UnitPrice,
            UpdatedAt = createDto.UpdatedAt
        };

        if (createDto.Id != null)
        {
            modelofDetailedDeclaration.Id = createDto.Id;
        }
        if (createDto.Article != null)
        {
            modelofDetailedDeclaration.Article = await _context
                .Articles.Where(article => createDto.Article.Id == article.Id)
                .FirstOrDefaultAsync();
        }

        _context.ModelofDetailedDeclarations.Add(modelofDetailedDeclaration);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<ModelofDetailedDeclarationDbModel>(
            modelofDetailedDeclaration.Id
        );

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one Model of Detailed Declaration
    /// </summary>
    public async Task DeleteModelofDetailedDeclaration(
        ModelofDetailedDeclarationWhereUniqueInput uniqueId
    )
    {
        var modelofDetailedDeclaration = await _context.ModelofDetailedDeclarations.FindAsync(
            uniqueId.Id
        );
        if (modelofDetailedDeclaration == null)
        {
            throw new NotFoundException();
        }

        _context.ModelofDetailedDeclarations.Remove(modelofDetailedDeclaration);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many MODEL/SPECIFICATION OF THE DETAILED DECLARATION (CUSTOMS)s
    /// </summary>
    public async Task<List<ModelofDetailedDeclaration>> ModelofDetailedDeclarations(
        ModelofDetailedDeclarationFindManyArgs findManyArgs
    )
    {
        var modelofDetailedDeclarations = await _context
            .ModelofDetailedDeclarations.Include(x => x.Article)
            .ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return modelofDetailedDeclarations.ConvertAll(modelofDetailedDeclaration =>
            modelofDetailedDeclaration.ToDto()
        );
    }

    /// <summary>
    /// Meta data about Model of Detailed Declaration records
    /// </summary>
    public async Task<MetadataDto> ModelofDetailedDeclarationsMeta(
        ModelofDetailedDeclarationFindManyArgs findManyArgs
    )
    {
        var count = await _context
            .ModelofDetailedDeclarations.ApplyWhere(findManyArgs.Where)
            .CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one Model of Detailed Declaration
    /// </summary>
    public async Task<ModelofDetailedDeclaration> ModelofDetailedDeclaration(
        ModelofDetailedDeclarationWhereUniqueInput uniqueId
    )
    {
        var modelofDetailedDeclarations = await this.ModelofDetailedDeclarations(
            new ModelofDetailedDeclarationFindManyArgs
            {
                Where = new ModelofDetailedDeclarationWhereInput { Id = uniqueId.Id }
            }
        );
        var modelofDetailedDeclaration = modelofDetailedDeclarations.FirstOrDefault();
        if (modelofDetailedDeclaration == null)
        {
            throw new NotFoundException();
        }

        return modelofDetailedDeclaration;
    }

    /// <summary>
    /// Update one Model of Detailed Declaration
    /// </summary>
    public async Task UpdateModelofDetailedDeclaration(
        ModelofDetailedDeclarationWhereUniqueInput uniqueId,
        ModelofDetailedDeclarationUpdateInput updateDto
    )
    {
        var modelofDetailedDeclaration = updateDto.ToModel(uniqueId);

        _context.Entry(modelofDetailedDeclaration).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (
                !_context.ModelofDetailedDeclarations.Any(e =>
                    e.Id == modelofDetailedDeclaration.Id
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

    /// <summary>
    /// Get a Article record for Model of Detailed Declaration
    /// </summary>
    public async Task<Article> GetArticle(ModelofDetailedDeclarationWhereUniqueInput uniqueId)
    {
        var modelofDetailedDeclaration = await _context
            .ModelofDetailedDeclarations.Where(modelofDetailedDeclaration =>
                modelofDetailedDeclaration.Id == uniqueId.Id
            )
            .Include(modelofDetailedDeclaration => modelofDetailedDeclaration.Article)
            .FirstOrDefaultAsync();
        if (modelofDetailedDeclaration == null)
        {
            throw new NotFoundException();
        }
        return modelofDetailedDeclaration.Article.ToDto();
    }
}
