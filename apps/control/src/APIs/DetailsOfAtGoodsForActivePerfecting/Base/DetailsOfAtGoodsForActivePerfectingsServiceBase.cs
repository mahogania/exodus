using Clre.APIs;
using Clre.APIs.Common;
using Clre.APIs.Dtos;
using Clre.APIs.Errors;
using Clre.APIs.Extensions;
using Clre.Infrastructure;
using Clre.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Clre.APIs;

public abstract class DetailsOfAtGoodsForActivePerfectingsServiceBase
    : IDetailsOfAtGoodsForActivePerfectingsService
{
    protected readonly ClreDbContext _context;

    public DetailsOfAtGoodsForActivePerfectingsServiceBase(ClreDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one DETAILS OF AT GOODS FOR ACTIVE PERFECTING
    /// </summary>
    public async Task<DetailsOfAtGoodsForActivePerfecting> CreateDetailsOfAtGoodsForActivePerfecting(
        DetailsOfAtGoodsForActivePerfectingCreateInput createDto
    )
    {
        var detailsOfAtGoodsForActivePerfecting = new DetailsOfAtGoodsForActivePerfectingDbModel
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
            detailsOfAtGoodsForActivePerfecting.Id = createDto.Id;
        }

        _context.DetailsOfAtGoodsForActivePerfectings.Add(detailsOfAtGoodsForActivePerfecting);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<DetailsOfAtGoodsForActivePerfectingDbModel>(
            detailsOfAtGoodsForActivePerfecting.Id
        );

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one DETAILS OF AT GOODS FOR ACTIVE PERFECTING
    /// </summary>
    public async Task DeleteDetailsOfAtGoodsForActivePerfecting(
        DetailsOfAtGoodsForActivePerfectingWhereUniqueInput uniqueId
    )
    {
        var detailsOfAtGoodsForActivePerfecting =
            await _context.DetailsOfAtGoodsForActivePerfectings.FindAsync(uniqueId.Id);
        if (detailsOfAtGoodsForActivePerfecting == null)
        {
            throw new NotFoundException();
        }

        _context.DetailsOfAtGoodsForActivePerfectings.Remove(detailsOfAtGoodsForActivePerfecting);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many DETAILS OF AT GOODS FOR ACTIVE PERFECTINGS
    /// </summary>
    public async Task<
        List<DetailsOfAtGoodsForActivePerfecting>
    > DetailsOfAtGoodsForActivePerfectings(
        DetailsOfAtGoodsForActivePerfectingFindManyArgs findManyArgs
    )
    {
        var detailsOfAtGoodsForActivePerfectings = await _context
            .DetailsOfAtGoodsForActivePerfectings.ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return detailsOfAtGoodsForActivePerfectings.ConvertAll(
            detailsOfAtGoodsForActivePerfecting => detailsOfAtGoodsForActivePerfecting.ToDto()
        );
    }

    /// <summary>
    /// Meta data about DETAILS OF AT GOODS FOR ACTIVE PERFECTING records
    /// </summary>
    public async Task<MetadataDto> DetailsOfAtGoodsForActivePerfectingsMeta(
        DetailsOfAtGoodsForActivePerfectingFindManyArgs findManyArgs
    )
    {
        var count = await _context
            .DetailsOfAtGoodsForActivePerfectings.ApplyWhere(findManyArgs.Where)
            .CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one DETAILS OF AT GOODS FOR ACTIVE PERFECTING
    /// </summary>
    public async Task<DetailsOfAtGoodsForActivePerfecting> DetailsOfAtGoodsForActivePerfecting(
        DetailsOfAtGoodsForActivePerfectingWhereUniqueInput uniqueId
    )
    {
        var detailsOfAtGoodsForActivePerfectings = await this.DetailsOfAtGoodsForActivePerfectings(
            new DetailsOfAtGoodsForActivePerfectingFindManyArgs
            {
                Where = new DetailsOfAtGoodsForActivePerfectingWhereInput { Id = uniqueId.Id }
            }
        );
        var detailsOfAtGoodsForActivePerfecting =
            detailsOfAtGoodsForActivePerfectings.FirstOrDefault();
        if (detailsOfAtGoodsForActivePerfecting == null)
        {
            throw new NotFoundException();
        }

        return detailsOfAtGoodsForActivePerfecting;
    }

    /// <summary>
    /// Update one DETAILS OF AT GOODS FOR ACTIVE PERFECTING
    /// </summary>
    public async Task UpdateDetailsOfAtGoodsForActivePerfecting(
        DetailsOfAtGoodsForActivePerfectingWhereUniqueInput uniqueId,
        DetailsOfAtGoodsForActivePerfectingUpdateInput updateDto
    )
    {
        var detailsOfAtGoodsForActivePerfecting = updateDto.ToModel(uniqueId);

        _context.Entry(detailsOfAtGoodsForActivePerfecting).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (
                !_context.DetailsOfAtGoodsForActivePerfectings.Any(e =>
                    e.Id == detailsOfAtGoodsForActivePerfecting.Id
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
