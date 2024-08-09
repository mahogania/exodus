using Control.APIs;
using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Control.APIs.Extensions;
using Control.Infrastructure;
using Control.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Control.APIs;

public abstract class ExportedAndForImprovementGoodsItemsServiceBase
    : IExportedAndForImprovementGoodsItemsService
{
    protected readonly ControlDbContext _context;

    public ExportedAndForImprovementGoodsItemsServiceBase(ControlDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one EXPORTED AND FOR IMPROVEMENT GOODS
    /// </summary>
    public async Task<ExportedAndForImprovementGoods> CreateExportedAndForImprovementGoods(
        ExportedAndForImprovementGoodsCreateInput createDto
    )
    {
        var exportedAndForImprovementGoods = new ExportedAndForImprovementGoodsDbModel
        {
            CommercialDesignationOfTheGoods = createDto.CommercialDesignationOfTheGoods,
            CreatedAt = createDto.CreatedAt,
            CurrencyCode = createDto.CurrencyCode,
            DateAndTimeOfFinalModification = createDto.DateAndTimeOfFinalModification,
            DateAndTimeOfFirstRegistration = createDto.DateAndTimeOfFirstRegistration,
            FinalModifierSId = createDto.FinalModifierSId,
            FirstRegistrantSId = createDto.FirstRegistrantSId,
            Origin = createDto.Origin,
            Quantity = createDto.Quantity,
            RectificationFrequency = createDto.RectificationFrequency,
            RegimeRequestNumber = createDto.RegimeRequestNumber,
            SequenceNumber = createDto.SequenceNumber,
            SptNumber = createDto.SptNumber,
            SuppressionOn = createDto.SuppressionOn,
            TechnicalDesignationOfTheGoods = createDto.TechnicalDesignationOfTheGoods,
            UpdatedAt = createDto.UpdatedAt,
            Value = createDto.Value
        };

        if (createDto.Id != null)
        {
            exportedAndForImprovementGoods.Id = createDto.Id;
        }

        _context.ExportedAndForImprovementGoodsItems.Add(exportedAndForImprovementGoods);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<ExportedAndForImprovementGoodsDbModel>(
            exportedAndForImprovementGoods.Id
        );

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one EXPORTED AND FOR IMPROVEMENT GOODS
    /// </summary>
    public async Task DeleteExportedAndForImprovementGoods(
        ExportedAndForImprovementGoodsWhereUniqueInput uniqueId
    )
    {
        var exportedAndForImprovementGoods =
            await _context.ExportedAndForImprovementGoodsItems.FindAsync(uniqueId.Id);
        if (exportedAndForImprovementGoods == null)
        {
            throw new NotFoundException();
        }

        _context.ExportedAndForImprovementGoodsItems.Remove(exportedAndForImprovementGoods);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many EXPORTED AND FOR IMPROVEMENT GOODSItems
    /// </summary>
    public async Task<List<ExportedAndForImprovementGoods>> ExportedAndForImprovementGoodsItems(
        ExportedAndForImprovementGoodsFindManyArgs findManyArgs
    )
    {
        var exportedAndForImprovementGoodsItems = await _context
            .ExportedAndForImprovementGoodsItems.ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return exportedAndForImprovementGoodsItems.ConvertAll(exportedAndForImprovementGoods =>
            exportedAndForImprovementGoods.ToDto()
        );
    }

    /// <summary>
    /// Meta data about EXPORTED AND FOR IMPROVEMENT GOODS records
    /// </summary>
    public async Task<MetadataDto> ExportedAndForImprovementGoodsItemsMeta(
        ExportedAndForImprovementGoodsFindManyArgs findManyArgs
    )
    {
        var count = await _context
            .ExportedAndForImprovementGoodsItems.ApplyWhere(findManyArgs.Where)
            .CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one EXPORTED AND FOR IMPROVEMENT GOODS
    /// </summary>
    public async Task<ExportedAndForImprovementGoods> ExportedAndForImprovementGoods(
        ExportedAndForImprovementGoodsWhereUniqueInput uniqueId
    )
    {
        var exportedAndForImprovementGoodsItems = await this.ExportedAndForImprovementGoodsItems(
            new ExportedAndForImprovementGoodsFindManyArgs
            {
                Where = new ExportedAndForImprovementGoodsWhereInput { Id = uniqueId.Id }
            }
        );
        var exportedAndForImprovementGoods = exportedAndForImprovementGoodsItems.FirstOrDefault();
        if (exportedAndForImprovementGoods == null)
        {
            throw new NotFoundException();
        }

        return exportedAndForImprovementGoods;
    }

    /// <summary>
    /// Update one EXPORTED AND FOR IMPROVEMENT GOODS
    /// </summary>
    public async Task UpdateExportedAndForImprovementGoods(
        ExportedAndForImprovementGoodsWhereUniqueInput uniqueId,
        ExportedAndForImprovementGoodsUpdateInput updateDto
    )
    {
        var exportedAndForImprovementGoods = updateDto.ToModel(uniqueId);

        _context.Entry(exportedAndForImprovementGoods).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (
                !_context.ExportedAndForImprovementGoodsItems.Any(e =>
                    e.Id == exportedAndForImprovementGoods.Id
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
