using Control.APIs;
using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Control.APIs.Extensions;
using Control.Infrastructure;
using Control.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Control.APIs;

public abstract class GoodsImportedForPerfectingsServiceBase : IGoodsImportedForPerfectingsService
{
    protected readonly ControlDbContext _context;

    public GoodsImportedForPerfectingsServiceBase(ControlDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one GOODS IMPORTED FOR PERFECTING
    /// </summary>
    public async Task<GoodsImportedForPerfecting> CreateGoodsImportedForPerfecting(
        GoodsImportedForPerfectingCreateInput createDto
    )
    {
        var goodsImportedForPerfecting = new GoodsImportedForPerfectingDbModel
        {
            AddressOfTheExporterOwnerOfGoodsToTransformRepair =
                createDto.AddressOfTheExporterOwnerOfGoodsToTransformRepair,
            AnotherUnknownField = createDto.AnotherUnknownField,
            CommercialDesignationOfGoods = createDto.CommercialDesignationOfGoods,
            CommercialDesignationOfGoodsToCompensate =
                createDto.CommercialDesignationOfGoodsToCompensate,
            CompensationOfAtAccounts = createDto.CompensationOfAtAccounts,
            CreatedAt = createDto.CreatedAt,
            CurrencyCode = createDto.CurrencyCode,
            DateAndTimeOfFinalModification = createDto.DateAndTimeOfFinalModification,
            DateAndTimeOfFirstRegistration = createDto.DateAndTimeOfFirstRegistration,
            DeletionOn = createDto.DeletionOn,
            FinalModifierSId = createDto.FinalModifierSId,
            FirstRecorderSId = createDto.FirstRecorderSId,
            LegalStatusOfImportedGoods = createDto.LegalStatusOfImportedGoods,
            NameAndTradeNameOfTheExporterOwnerOfGoodsToTransformRepair =
                createDto.NameAndTradeNameOfTheExporterOwnerOfGoodsToTransformRepair,
            Origin = createDto.Origin,
            Quantity = createDto.Quantity,
            QuantityOfGoodsToCompensate = createDto.QuantityOfGoodsToCompensate,
            RectificationFrequency = createDto.RectificationFrequency,
            RegimeRequestNumber = createDto.RegimeRequestNumber,
            SequenceNumber = createDto.SequenceNumber,
            ShorterOrigin = createDto.ShorterOrigin,
            SptNumber = createDto.SptNumber,
            TechnicalDesignationOfGoods = createDto.TechnicalDesignationOfGoods,
            TechnicalDesignationOfGoodsToCompensate =
                createDto.TechnicalDesignationOfGoodsToCompensate,
            UnknownField = createDto.UnknownField,
            UpdatedAt = createDto.UpdatedAt,
            ValueInCurrency = createDto.ValueInCurrency
        };

        if (createDto.Id != null)
        {
            goodsImportedForPerfecting.Id = createDto.Id;
        }

        _context.GoodsImportedForPerfectings.Add(goodsImportedForPerfecting);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<GoodsImportedForPerfectingDbModel>(
            goodsImportedForPerfecting.Id
        );

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one GOODS IMPORTED FOR PERFECTING
    /// </summary>
    public async Task DeleteGoodsImportedForPerfecting(
        GoodsImportedForPerfectingWhereUniqueInput uniqueId
    )
    {
        var goodsImportedForPerfecting = await _context.GoodsImportedForPerfectings.FindAsync(
            uniqueId.Id
        );
        if (goodsImportedForPerfecting == null)
        {
            throw new NotFoundException();
        }

        _context.GoodsImportedForPerfectings.Remove(goodsImportedForPerfecting);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many GOODS IMPORTED FOR PERFECTINGS
    /// </summary>
    public async Task<List<GoodsImportedForPerfecting>> GoodsImportedForPerfectings(
        GoodsImportedForPerfectingFindManyArgs findManyArgs
    )
    {
        var goodsImportedForPerfectings = await _context
            .GoodsImportedForPerfectings.ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return goodsImportedForPerfectings.ConvertAll(goodsImportedForPerfecting =>
            goodsImportedForPerfecting.ToDto()
        );
    }

    /// <summary>
    /// Meta data about GOODS IMPORTED FOR PERFECTING records
    /// </summary>
    public async Task<MetadataDto> GoodsImportedForPerfectingsMeta(
        GoodsImportedForPerfectingFindManyArgs findManyArgs
    )
    {
        var count = await _context
            .GoodsImportedForPerfectings.ApplyWhere(findManyArgs.Where)
            .CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one GOODS IMPORTED FOR PERFECTING
    /// </summary>
    public async Task<GoodsImportedForPerfecting> GoodsImportedForPerfecting(
        GoodsImportedForPerfectingWhereUniqueInput uniqueId
    )
    {
        var goodsImportedForPerfectings = await this.GoodsImportedForPerfectings(
            new GoodsImportedForPerfectingFindManyArgs
            {
                Where = new GoodsImportedForPerfectingWhereInput { Id = uniqueId.Id }
            }
        );
        var goodsImportedForPerfecting = goodsImportedForPerfectings.FirstOrDefault();
        if (goodsImportedForPerfecting == null)
        {
            throw new NotFoundException();
        }

        return goodsImportedForPerfecting;
    }

    /// <summary>
    /// Update one GOODS IMPORTED FOR PERFECTING
    /// </summary>
    public async Task UpdateGoodsImportedForPerfecting(
        GoodsImportedForPerfectingWhereUniqueInput uniqueId,
        GoodsImportedForPerfectingUpdateInput updateDto
    )
    {
        var goodsImportedForPerfecting = updateDto.ToModel(uniqueId);

        _context.Entry(goodsImportedForPerfecting).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (
                !_context.GoodsImportedForPerfectings.Any(e =>
                    e.Id == goodsImportedForPerfecting.Id
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
