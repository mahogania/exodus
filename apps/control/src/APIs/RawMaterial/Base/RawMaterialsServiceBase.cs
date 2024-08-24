using Control.APIs;
using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Control.APIs.Extensions;
using Control.Infrastructure;
using Control.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Control.APIs;

public abstract class RawMaterialsServiceBase : IRawMaterialsService
{
    protected readonly ControlDbContext _context;

    public RawMaterialsServiceBase(ControlDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one Raw Material
    /// </summary>
    public async Task<RawMaterial> CreateRawMaterial(RawMaterialCreateInput createDto)
    {
        var rawMaterial = new RawMaterialDbModel
        {
            ArticleNumber = createDto.ArticleNumber,
            CreatedAt = createDto.CreatedAt,
            DateAndTimeOfFinalModification = createDto.DateAndTimeOfFinalModification,
            DateAndTimeOfFirstRegistration = createDto.DateAndTimeOfFirstRegistration,
            FinalModifierSId = createDto.FinalModifierSId,
            FirstRegistrantSId = createDto.FirstRegistrantSId,
            MaterialRawSequenceNumber = createDto.MaterialRawSequenceNumber,
            NetWeight = createDto.NetWeight,
            PartialClearanceTypeCode = createDto.PartialClearanceTypeCode,
            PreviousArticleNumber = createDto.PreviousArticleNumber,
            PreviousDetailedDeclarationNumber = createDto.PreviousDetailedDeclarationNumber,
            PreviousShCode = createDto.PreviousShCode,
            PreviousSpecificCodeOfTheMerchandiseClassification =
                createDto.PreviousSpecificCodeOfTheMerchandiseClassification,
            Quantity = createDto.Quantity,
            QuantityUnitCode = createDto.QuantityUnitCode,
            RectificationFrequency = createDto.RectificationFrequency,
            ReferenceNumber = createDto.ReferenceNumber,
            SuppressionOn = createDto.SuppressionOn,
            UpdatedAt = createDto.UpdatedAt
        };

        if (createDto.Id != null)
        {
            rawMaterial.Id = createDto.Id;
        }
        if (createDto.Article != null)
        {
            rawMaterial.Article = await _context
                .Articles.Where(article => createDto.Article.Id == article.Id)
                .FirstOrDefaultAsync();
        }

        _context.RawMaterials.Add(rawMaterial);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<RawMaterialDbModel>(rawMaterial.Id);

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one Raw Material
    /// </summary>
    public async Task DeleteRawMaterial(RawMaterialWhereUniqueInput uniqueId)
    {
        var rawMaterial = await _context.RawMaterials.FindAsync(uniqueId.Id);
        if (rawMaterial == null)
        {
            throw new NotFoundException();
        }

        _context.RawMaterials.Remove(rawMaterial);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many RAW MATERIAL OF THE DETAILED DECLARATION (CUSTOMS)s
    /// </summary>
    public async Task<List<RawMaterial>> RawMaterials(RawMaterialFindManyArgs findManyArgs)
    {
        var rawMaterials = await _context
            .RawMaterials.Include(x => x.Article)
            .ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return rawMaterials.ConvertAll(rawMaterial => rawMaterial.ToDto());
    }

    /// <summary>
    /// Meta data about Raw Material records
    /// </summary>
    public async Task<MetadataDto> RawMaterialsMeta(RawMaterialFindManyArgs findManyArgs)
    {
        var count = await _context.RawMaterials.ApplyWhere(findManyArgs.Where).CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one Raw Material
    /// </summary>
    public async Task<RawMaterial> RawMaterial(RawMaterialWhereUniqueInput uniqueId)
    {
        var rawMaterials = await this.RawMaterials(
            new RawMaterialFindManyArgs { Where = new RawMaterialWhereInput { Id = uniqueId.Id } }
        );
        var rawMaterial = rawMaterials.FirstOrDefault();
        if (rawMaterial == null)
        {
            throw new NotFoundException();
        }

        return rawMaterial;
    }

    /// <summary>
    /// Update one Raw Material
    /// </summary>
    public async Task UpdateRawMaterial(
        RawMaterialWhereUniqueInput uniqueId,
        RawMaterialUpdateInput updateDto
    )
    {
        var rawMaterial = updateDto.ToModel(uniqueId);

        _context.Entry(rawMaterial).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!_context.RawMaterials.Any(e => e.Id == rawMaterial.Id))
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
    /// Get a Article record for RAW MATERIAL OF THE DETAILED DECLARATION (CUSTOMS)
    /// </summary>
    public async Task<Article> GetArticle(RawMaterialWhereUniqueInput uniqueId)
    {
        var rawMaterial = await _context
            .RawMaterials.Where(rawMaterial => rawMaterial.Id == uniqueId.Id)
            .Include(rawMaterial => rawMaterial.Article)
            .FirstOrDefaultAsync();
        if (rawMaterial == null)
        {
            throw new NotFoundException();
        }
        return rawMaterial.Article.ToDto();
    }
}
