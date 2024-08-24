using Control.APIs;
using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Control.APIs.Extensions;
using Control.Infrastructure;
using Control.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Control.APIs;

public abstract class DetailOfActiveGoodsItemsServiceBase : IDetailOfActiveGoodsItemsService
{
    protected readonly ControlDbContext _context;

    public DetailOfActiveGoodsItemsServiceBase(ControlDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one Detail of Active Goods
    /// </summary>
    public async Task<DetailOfActiveGoods> CreateDetailOfActiveGoods(
        DetailOfActiveGoodsCreateInput createDto
    )
    {
        var detailOfActiveGoods = new DetailOfActiveGoodsDbModel
        {
            BrandName = createDto.BrandName,
            CodeOfImportExportType = createDto.CodeOfImportExportType,
            CountryOfOriginCode = createDto.CountryOfOriginCode,
            CountryOfShipmentCode = createDto.CountryOfShipmentCode,
            CreatedAt = createDto.CreatedAt,
            DateAndTimeOfFinalModification = createDto.DateAndTimeOfFinalModification,
            DateAndTimeOfFirstRegistration = createDto.DateAndTimeOfFirstRegistration,
            DeletionOn = createDto.DeletionOn,
            DocumentCode = createDto.DocumentCode,
            FinalModifierSId = createDto.FinalModifierSId,
            FirstRecorderSId = createDto.FirstRecorderSId,
            GoodsValue = createDto.GoodsValue,
            RectificationFrequency = createDto.RectificationFrequency,
            RegimeRequestNumber = createDto.RegimeRequestNumber,
            SequenceNumber = createDto.SequenceNumber,
            ShCode = createDto.ShCode,
            StorageLocation = createDto.StorageLocation,
            StorageLocationUnitCode = createDto.StorageLocationUnitCode,
            TransactionValueCurrencyCode = createDto.TransactionValueCurrencyCode,
            UpdatedAt = createDto.UpdatedAt
        };

        if (createDto.Id != null)
        {
            detailOfActiveGoods.Id = createDto.Id;
        }
        if (createDto.CommonActiveGoodsRequest != null)
        {
            detailOfActiveGoods.CommonActiveGoodsRequest = await _context
                .CommonActiveGoodsRequests.Where(commonActiveGoodsRequest =>
                    createDto.CommonActiveGoodsRequest.Id == commonActiveGoodsRequest.Id
                )
                .FirstOrDefaultAsync();
        }

        _context.DetailOfActiveGoodsItems.Add(detailOfActiveGoods);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<DetailOfActiveGoodsDbModel>(detailOfActiveGoods.Id);

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one Detail of Active Goods
    /// </summary>
    public async Task DeleteDetailOfActiveGoods(DetailOfActiveGoodsWhereUniqueInput uniqueId)
    {
        var detailOfActiveGoods = await _context.DetailOfActiveGoodsItems.FindAsync(uniqueId.Id);
        if (detailOfActiveGoods == null)
        {
            throw new NotFoundException();
        }

        _context.DetailOfActiveGoodsItems.Remove(detailOfActiveGoods);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many Details of Active Goods
    /// </summary>
    public async Task<List<DetailOfActiveGoods>> DetailOfActiveGoodsItems(
        DetailOfActiveGoodsFindManyArgs findManyArgs
    )
    {
        var detailOfActiveGoodsItems = await _context
            .DetailOfActiveGoodsItems.Include(x => x.CommonActiveGoodsRequest)
            .ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return detailOfActiveGoodsItems.ConvertAll(detailOfActiveGoods =>
            detailOfActiveGoods.ToDto()
        );
    }

    /// <summary>
    /// Meta data about Detail of Active Goods records
    /// </summary>
    public async Task<MetadataDto> DetailOfActiveGoodsItemsMeta(
        DetailOfActiveGoodsFindManyArgs findManyArgs
    )
    {
        var count = await _context
            .DetailOfActiveGoodsItems.ApplyWhere(findManyArgs.Where)
            .CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one Detail of Active Goods
    /// </summary>
    public async Task<DetailOfActiveGoods> DetailOfActiveGoods(
        DetailOfActiveGoodsWhereUniqueInput uniqueId
    )
    {
        var detailOfActiveGoodsItems = await this.DetailOfActiveGoodsItems(
            new DetailOfActiveGoodsFindManyArgs
            {
                Where = new DetailOfActiveGoodsWhereInput { Id = uniqueId.Id }
            }
        );
        var detailOfActiveGoods = detailOfActiveGoodsItems.FirstOrDefault();
        if (detailOfActiveGoods == null)
        {
            throw new NotFoundException();
        }

        return detailOfActiveGoods;
    }

    /// <summary>
    /// Update one Detail of Active Goods
    /// </summary>
    public async Task UpdateDetailOfActiveGoods(
        DetailOfActiveGoodsWhereUniqueInput uniqueId,
        DetailOfActiveGoodsUpdateInput updateDto
    )
    {
        var detailOfActiveGoods = updateDto.ToModel(uniqueId);

        _context.Entry(detailOfActiveGoods).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!_context.DetailOfActiveGoodsItems.Any(e => e.Id == detailOfActiveGoods.Id))
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
    /// Get a Common Active Goods Request record for Details of Active Goods
    /// </summary>
    public async Task<CommonActiveGoodsRequest> GetCommonActiveGoodsRequest(
        DetailOfActiveGoodsWhereUniqueInput uniqueId
    )
    {
        var detailOfActiveGoods = await _context
            .DetailOfActiveGoodsItems.Where(detailOfActiveGoods =>
                detailOfActiveGoods.Id == uniqueId.Id
            )
            .Include(detailOfActiveGoods => detailOfActiveGoods.CommonActiveGoodsRequest)
            .FirstOrDefaultAsync();
        if (detailOfActiveGoods == null)
        {
            throw new NotFoundException();
        }
        return detailOfActiveGoods.CommonActiveGoodsRequest.ToDto();
    }
}
