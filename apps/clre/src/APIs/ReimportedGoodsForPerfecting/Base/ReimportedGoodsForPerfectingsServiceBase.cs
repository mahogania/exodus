using Clre.APIs;
using Clre.APIs.Common;
using Clre.APIs.Dtos;
using Clre.APIs.Errors;
using Clre.APIs.Extensions;
using Clre.Infrastructure;
using Clre.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Clre.APIs;

public abstract class ReimportedGoodsForPerfectingsServiceBase
    : IReimportedGoodsForPerfectingsService
{
    protected readonly ClreDbContext _context;

    public ReimportedGoodsForPerfectingsServiceBase(ClreDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one REIMPORTED GOODS FOR PERFECTING
    /// </summary>
    public async Task<ReimportedGoodsForPerfecting> CreateReimportedGoodsForPerfecting(
        ReimportedGoodsForPerfectingCreateInput createDto
    )
    {
        var reimportedGoodsForPerfecting = new ReimportedGoodsForPerfectingDbModel
        {
            CommercialDesignationOfGoods = createDto.CommercialDesignationOfGoods,
            CountryOfImportation = createDto.CountryOfImportation,
            CreatedAt = createDto.CreatedAt,
            CurrencyCode = createDto.CurrencyCode,
            DateAndTimeOfFinalModification = createDto.DateAndTimeOfFinalModification,
            DateAndTimeOfFirstRegistration = createDto.DateAndTimeOfFirstRegistration,
            DeletionOn = createDto.DeletionOn,
            FinalModifierSId = createDto.FinalModifierSId,
            FirstRecorderSId = createDto.FirstRecorderSId,
            FobValue = createDto.FobValue,
            NatureOfGoodsRemainingOutsideTheCustomsTerritory =
                createDto.NatureOfGoodsRemainingOutsideTheCustomsTerritory,
            Origin = createDto.Origin,
            Quantity = createDto.Quantity,
            QuantityOfEachGoodRemainingOutsideTheCustomsTerritory =
                createDto.QuantityOfEachGoodRemainingOutsideTheCustomsTerritory,
            RectificationFrequency = createDto.RectificationFrequency,
            RegimeRequestNumber = createDto.RegimeRequestNumber,
            SequenceNumber = createDto.SequenceNumber,
            SptNumber = createDto.SptNumber,
            TechnicalDesignationOfGoods = createDto.TechnicalDesignationOfGoods,
            UpdatedAt = createDto.UpdatedAt
        };

        if (createDto.Id != null)
        {
            reimportedGoodsForPerfecting.Id = createDto.Id;
        }

        _context.ReimportedGoodsForPerfectings.Add(reimportedGoodsForPerfecting);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<ReimportedGoodsForPerfectingDbModel>(
            reimportedGoodsForPerfecting.Id
        );

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one REIMPORTED GOODS FOR PERFECTING
    /// </summary>
    public async Task DeleteReimportedGoodsForPerfecting(
        ReimportedGoodsForPerfectingWhereUniqueInput uniqueId
    )
    {
        var reimportedGoodsForPerfecting = await _context.ReimportedGoodsForPerfectings.FindAsync(
            uniqueId.Id
        );
        if (reimportedGoodsForPerfecting == null)
        {
            throw new NotFoundException();
        }

        _context.ReimportedGoodsForPerfectings.Remove(reimportedGoodsForPerfecting);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many REIMPORTED GOODS FOR PERFECTINGS
    /// </summary>
    public async Task<List<ReimportedGoodsForPerfecting>> ReimportedGoodsForPerfectings(
        ReimportedGoodsForPerfectingFindManyArgs findManyArgs
    )
    {
        var reimportedGoodsForPerfectings = await _context
            .ReimportedGoodsForPerfectings.ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return reimportedGoodsForPerfectings.ConvertAll(reimportedGoodsForPerfecting =>
            reimportedGoodsForPerfecting.ToDto()
        );
    }

    /// <summary>
    /// Meta data about REIMPORTED GOODS FOR PERFECTING records
    /// </summary>
    public async Task<MetadataDto> ReimportedGoodsForPerfectingsMeta(
        ReimportedGoodsForPerfectingFindManyArgs findManyArgs
    )
    {
        var count = await _context
            .ReimportedGoodsForPerfectings.ApplyWhere(findManyArgs.Where)
            .CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one REIMPORTED GOODS FOR PERFECTING
    /// </summary>
    public async Task<ReimportedGoodsForPerfecting> ReimportedGoodsForPerfecting(
        ReimportedGoodsForPerfectingWhereUniqueInput uniqueId
    )
    {
        var reimportedGoodsForPerfectings = await this.ReimportedGoodsForPerfectings(
            new ReimportedGoodsForPerfectingFindManyArgs
            {
                Where = new ReimportedGoodsForPerfectingWhereInput { Id = uniqueId.Id }
            }
        );
        var reimportedGoodsForPerfecting = reimportedGoodsForPerfectings.FirstOrDefault();
        if (reimportedGoodsForPerfecting == null)
        {
            throw new NotFoundException();
        }

        return reimportedGoodsForPerfecting;
    }

    /// <summary>
    /// Update one REIMPORTED GOODS FOR PERFECTING
    /// </summary>
    public async Task UpdateReimportedGoodsForPerfecting(
        ReimportedGoodsForPerfectingWhereUniqueInput uniqueId,
        ReimportedGoodsForPerfectingUpdateInput updateDto
    )
    {
        var reimportedGoodsForPerfecting = updateDto.ToModel(uniqueId);

        _context.Entry(reimportedGoodsForPerfecting).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (
                !_context.ReimportedGoodsForPerfectings.Any(e =>
                    e.Id == reimportedGoodsForPerfecting.Id
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
