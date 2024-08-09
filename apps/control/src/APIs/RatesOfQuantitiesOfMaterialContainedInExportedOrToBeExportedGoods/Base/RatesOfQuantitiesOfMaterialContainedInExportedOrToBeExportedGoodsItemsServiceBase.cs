using Clre.APIs;
using Clre.APIs.Common;
using Clre.APIs.Dtos;
using Clre.APIs.Errors;
using Clre.APIs.Extensions;
using Clre.Infrastructure;
using Clre.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Clre.APIs;

public abstract class RatesOfQuantitiesOfMaterialContainedInExportedOrToBeExportedGoodsItemsServiceBase
    : IRatesOfQuantitiesOfMaterialContainedInExportedOrToBeExportedGoodsItemsService
{
    protected readonly ClreDbContext _context;

    public RatesOfQuantitiesOfMaterialContainedInExportedOrToBeExportedGoodsItemsServiceBase(
        ClreDbContext context
    )
    {
        _context = context;
    }

    /// <summary>
    /// Create one RATES OF QUANTITIES OF MATERIAL CONTAINED IN EXPORTED OR TO BE EXPORTED GOODS
    /// </summary>
    public async Task<RatesOfQuantitiesOfMaterialContainedInExportedOrToBeExportedGoods> CreateRatesOfQuantitiesOfMaterialContainedInExportedOrToBeExportedGoods(
        RatesOfQuantitiesOfMaterialContainedInExportedOrToBeExportedGoodsCreateInput createDto
    )
    {
        var ratesOfQuantitiesOfMaterialContainedInExportedOrToBeExportedGoods =
            new RatesOfQuantitiesOfMaterialContainedInExportedOrToBeExportedGoodsDbModel
            {
                CreatedAt = createDto.CreatedAt,
                DateAndTimeOfFinalModification = createDto.DateAndTimeOfFinalModification,
                DateAndTimeOfFirstRegistration = createDto.DateAndTimeOfFirstRegistration,
                FinalModifierSId = createDto.FinalModifierSId,
                FirstRegistrantSId = createDto.FirstRegistrantSId,
                RatesOfQuantitiesOfForeignOriginMaterialsAcquiredOnTheNationalMarket =
                    createDto.RatesOfQuantitiesOfForeignOriginMaterialsAcquiredOnTheNationalMarket,
                RatesOfQuantitiesOfImportedMaterials =
                    createDto.RatesOfQuantitiesOfImportedMaterials,
                RatesOfQuantitiesOfImportedPackaging =
                    createDto.RatesOfQuantitiesOfImportedPackaging,
                RatesOfQuantitiesOfNationalOriginMaterials =
                    createDto.RatesOfQuantitiesOfNationalOriginMaterials,
                RectificationFrequency = createDto.RectificationFrequency,
                RegimeRequestNumber = createDto.RegimeRequestNumber,
                SequenceNumber = createDto.SequenceNumber,
                SuppressionOn = createDto.SuppressionOn,
                UpdatedAt = createDto.UpdatedAt
            };

        if (createDto.Id != null)
        {
            ratesOfQuantitiesOfMaterialContainedInExportedOrToBeExportedGoods.Id = createDto.Id;
        }

        _context.RatesOfQuantitiesOfMaterialContainedInExportedOrToBeExportedGoodsItems.Add(
            ratesOfQuantitiesOfMaterialContainedInExportedOrToBeExportedGoods
        );
        await _context.SaveChangesAsync();

        var result =
            await _context.FindAsync<RatesOfQuantitiesOfMaterialContainedInExportedOrToBeExportedGoodsDbModel>(
                ratesOfQuantitiesOfMaterialContainedInExportedOrToBeExportedGoods.Id
            );

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one RATES OF QUANTITIES OF MATERIAL CONTAINED IN EXPORTED OR TO BE EXPORTED GOODS
    /// </summary>
    public async Task DeleteRatesOfQuantitiesOfMaterialContainedInExportedOrToBeExportedGoods(
        RatesOfQuantitiesOfMaterialContainedInExportedOrToBeExportedGoodsWhereUniqueInput uniqueId
    )
    {
        var ratesOfQuantitiesOfMaterialContainedInExportedOrToBeExportedGoods =
            await _context.RatesOfQuantitiesOfMaterialContainedInExportedOrToBeExportedGoodsItems.FindAsync(
                uniqueId.Id
            );
        if (ratesOfQuantitiesOfMaterialContainedInExportedOrToBeExportedGoods == null)
        {
            throw new NotFoundException();
        }

        _context.RatesOfQuantitiesOfMaterialContainedInExportedOrToBeExportedGoodsItems.Remove(
            ratesOfQuantitiesOfMaterialContainedInExportedOrToBeExportedGoods
        );
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many RATES OF QUANTITIES OF MATERIAL CONTAINED IN EXPORTED OR TO BE EXPORTED GOODSItems
    /// </summary>
    public async Task<
        List<RatesOfQuantitiesOfMaterialContainedInExportedOrToBeExportedGoods>
    > RatesOfQuantitiesOfMaterialContainedInExportedOrToBeExportedGoodsItems(
        RatesOfQuantitiesOfMaterialContainedInExportedOrToBeExportedGoodsFindManyArgs findManyArgs
    )
    {
        var ratesOfQuantitiesOfMaterialContainedInExportedOrToBeExportedGoodsItems = await _context
            .RatesOfQuantitiesOfMaterialContainedInExportedOrToBeExportedGoodsItems.ApplyWhere(
                findManyArgs.Where
            )
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return ratesOfQuantitiesOfMaterialContainedInExportedOrToBeExportedGoodsItems.ConvertAll(
            ratesOfQuantitiesOfMaterialContainedInExportedOrToBeExportedGoods =>
                ratesOfQuantitiesOfMaterialContainedInExportedOrToBeExportedGoods.ToDto()
        );
    }

    /// <summary>
    /// Meta data about RATES OF QUANTITIES OF MATERIAL CONTAINED IN EXPORTED OR TO BE EXPORTED GOODS records
    /// </summary>
    public async Task<MetadataDto> RatesOfQuantitiesOfMaterialContainedInExportedOrToBeExportedGoodsItemsMeta(
        RatesOfQuantitiesOfMaterialContainedInExportedOrToBeExportedGoodsFindManyArgs findManyArgs
    )
    {
        var count = await _context
            .RatesOfQuantitiesOfMaterialContainedInExportedOrToBeExportedGoodsItems.ApplyWhere(
                findManyArgs.Where
            )
            .CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one RATES OF QUANTITIES OF MATERIAL CONTAINED IN EXPORTED OR TO BE EXPORTED GOODS
    /// </summary>
    public async Task<RatesOfQuantitiesOfMaterialContainedInExportedOrToBeExportedGoods> RatesOfQuantitiesOfMaterialContainedInExportedOrToBeExportedGoods(
        RatesOfQuantitiesOfMaterialContainedInExportedOrToBeExportedGoodsWhereUniqueInput uniqueId
    )
    {
        var ratesOfQuantitiesOfMaterialContainedInExportedOrToBeExportedGoodsItems =
            await this.RatesOfQuantitiesOfMaterialContainedInExportedOrToBeExportedGoodsItems(
                new RatesOfQuantitiesOfMaterialContainedInExportedOrToBeExportedGoodsFindManyArgs
                {
                    Where =
                        new RatesOfQuantitiesOfMaterialContainedInExportedOrToBeExportedGoodsWhereInput
                        {
                            Id = uniqueId.Id
                        }
                }
            );
        var ratesOfQuantitiesOfMaterialContainedInExportedOrToBeExportedGoods =
            ratesOfQuantitiesOfMaterialContainedInExportedOrToBeExportedGoodsItems.FirstOrDefault();
        if (ratesOfQuantitiesOfMaterialContainedInExportedOrToBeExportedGoods == null)
        {
            throw new NotFoundException();
        }

        return ratesOfQuantitiesOfMaterialContainedInExportedOrToBeExportedGoods;
    }

    /// <summary>
    /// Update one RATES OF QUANTITIES OF MATERIAL CONTAINED IN EXPORTED OR TO BE EXPORTED GOODS
    /// </summary>
    public async Task UpdateRatesOfQuantitiesOfMaterialContainedInExportedOrToBeExportedGoods(
        RatesOfQuantitiesOfMaterialContainedInExportedOrToBeExportedGoodsWhereUniqueInput uniqueId,
        RatesOfQuantitiesOfMaterialContainedInExportedOrToBeExportedGoodsUpdateInput updateDto
    )
    {
        var ratesOfQuantitiesOfMaterialContainedInExportedOrToBeExportedGoods = updateDto.ToModel(
            uniqueId
        );

        _context.Entry(ratesOfQuantitiesOfMaterialContainedInExportedOrToBeExportedGoods).State =
            EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (
                !_context.RatesOfQuantitiesOfMaterialContainedInExportedOrToBeExportedGoodsItems.Any(
                    e =>
                        e.Id == ratesOfQuantitiesOfMaterialContainedInExportedOrToBeExportedGoods.Id
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
