using Clre.APIs;
using Clre.APIs.Common;
using Clre.APIs.Dtos;
using Clre.APIs.Errors;
using Clre.APIs.Extensions;
using Clre.Infrastructure;
using Clre.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Clre.APIs;

public abstract class GoodsAndWithReImportationInStatesServiceBase
    : IGoodsAndWithReImportationInStatesService
{
    protected readonly ClreDbContext _context;

    public GoodsAndWithReImportationInStatesServiceBase(ClreDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one GOODS AND WITH RE-IMPORTATION IN STATE
    /// </summary>
    public async Task<GoodsAndWithReImportationInState> CreateGoodsAndWithReImportationInState(
        GoodsAndWithReImportationInStateCreateInput createDto
    )
    {
        var goodsAndWithReImportationInState = new GoodsAndWithReImportationInStateDbModel
        {
            CommercialDesignationOfGoods = createDto.CommercialDesignationOfGoods,
            CreatedAt = createDto.CreatedAt,
            CurrencyCode = createDto.CurrencyCode,
            DateAndTimeOfFinalModification = createDto.DateAndTimeOfFinalModification,
            DateAndTimeOfFirstRegistration = createDto.DateAndTimeOfFirstRegistration,
            FinalModifierSId = createDto.FinalModifierSId,
            FirstRegistrantSId = createDto.FirstRegistrantSId,
            Identification = createDto.Identification,
            Origin = createDto.Origin,
            Quantity = createDto.Quantity,
            RectificationFrequency = createDto.RectificationFrequency,
            RegimeRequestNumber = createDto.RegimeRequestNumber,
            SequenceNumber = createDto.SequenceNumber,
            SptNumber = createDto.SptNumber,
            StateOfTheGoodsAtTheTimeOfExportation = createDto.StateOfTheGoodsAtTheTimeOfExportation,
            SuppressionOn = createDto.SuppressionOn,
            TechnicalDesignationOfGoods = createDto.TechnicalDesignationOfGoods,
            UpdatedAt = createDto.UpdatedAt,
            Value = createDto.Value
        };

        if (createDto.Id != null)
        {
            goodsAndWithReImportationInState.Id = createDto.Id;
        }

        _context.GoodsAndWithReImportationInStates.Add(goodsAndWithReImportationInState);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<GoodsAndWithReImportationInStateDbModel>(
            goodsAndWithReImportationInState.Id
        );

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one GOODS AND WITH RE-IMPORTATION IN STATE
    /// </summary>
    public async Task DeleteGoodsAndWithReImportationInState(
        GoodsAndWithReImportationInStateWhereUniqueInput uniqueId
    )
    {
        var goodsAndWithReImportationInState =
            await _context.GoodsAndWithReImportationInStates.FindAsync(uniqueId.Id);
        if (goodsAndWithReImportationInState == null)
        {
            throw new NotFoundException();
        }

        _context.GoodsAndWithReImportationInStates.Remove(goodsAndWithReImportationInState);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many GOODS AND WITH RE-IMPORTATION IN STATES
    /// </summary>
    public async Task<List<GoodsAndWithReImportationInState>> GoodsAndWithReImportationInStates(
        GoodsAndWithReImportationInStateFindManyArgs findManyArgs
    )
    {
        var goodsAndWithReImportationInStates = await _context
            .GoodsAndWithReImportationInStates.ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return goodsAndWithReImportationInStates.ConvertAll(goodsAndWithReImportationInState =>
            goodsAndWithReImportationInState.ToDto()
        );
    }

    /// <summary>
    /// Meta data about GOODS AND WITH RE-IMPORTATION IN STATE records
    /// </summary>
    public async Task<MetadataDto> GoodsAndWithReImportationInStatesMeta(
        GoodsAndWithReImportationInStateFindManyArgs findManyArgs
    )
    {
        var count = await _context
            .GoodsAndWithReImportationInStates.ApplyWhere(findManyArgs.Where)
            .CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one GOODS AND WITH RE-IMPORTATION IN STATE
    /// </summary>
    public async Task<GoodsAndWithReImportationInState> GoodsAndWithReImportationInState(
        GoodsAndWithReImportationInStateWhereUniqueInput uniqueId
    )
    {
        var goodsAndWithReImportationInStates = await this.GoodsAndWithReImportationInStates(
            new GoodsAndWithReImportationInStateFindManyArgs
            {
                Where = new GoodsAndWithReImportationInStateWhereInput { Id = uniqueId.Id }
            }
        );
        var goodsAndWithReImportationInState = goodsAndWithReImportationInStates.FirstOrDefault();
        if (goodsAndWithReImportationInState == null)
        {
            throw new NotFoundException();
        }

        return goodsAndWithReImportationInState;
    }

    /// <summary>
    /// Update one GOODS AND WITH RE-IMPORTATION IN STATE
    /// </summary>
    public async Task UpdateGoodsAndWithReImportationInState(
        GoodsAndWithReImportationInStateWhereUniqueInput uniqueId,
        GoodsAndWithReImportationInStateUpdateInput updateDto
    )
    {
        var goodsAndWithReImportationInState = updateDto.ToModel(uniqueId);

        _context.Entry(goodsAndWithReImportationInState).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (
                !_context.GoodsAndWithReImportationInStates.Any(e =>
                    e.Id == goodsAndWithReImportationInState.Id
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
