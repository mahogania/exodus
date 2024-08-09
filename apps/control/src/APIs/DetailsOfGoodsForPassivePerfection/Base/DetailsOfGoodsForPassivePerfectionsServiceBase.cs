using Clre.APIs;
using Clre.APIs.Common;
using Clre.APIs.Dtos;
using Clre.APIs.Errors;
using Clre.APIs.Extensions;
using Clre.Infrastructure;
using Clre.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Clre.APIs;

public abstract class DetailsOfGoodsForPassivePerfectionsServiceBase
    : IDetailsOfGoodsForPassivePerfectionsService
{
    protected readonly ClreDbContext _context;

    public DetailsOfGoodsForPassivePerfectionsServiceBase(ClreDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one DETAILS OF GOODS FOR PASSIVE PERFECTION
    /// </summary>
    public async Task<DetailsOfGoodsForPassivePerfection> CreateDetailsOfGoodsForPassivePerfection(
        DetailsOfGoodsForPassivePerfectionCreateInput createDto
    )
    {
        var detailsOfGoodsForPassivePerfection = new DetailsOfGoodsForPassivePerfectionDbModel
        {
            BrandName = createDto.BrandName,
            CreatedAt = createDto.CreatedAt,
            DateAndTimeOfFinalModification = createDto.DateAndTimeOfFinalModification,
            DateAndTimeOfFirstRegistration = createDto.DateAndTimeOfFirstRegistration,
            DeclaredGoodsNames = createDto.DeclaredGoodsNames,
            DocumentCode = createDto.DocumentCode,
            FinalModifierSId = createDto.FinalModifierSId,
            FirstRegistrantSId = createDto.FirstRegistrantSId,
            GoodsValue = createDto.GoodsValue,
            ImportExportTypeCode = createDto.ImportExportTypeCode,
            NatureOfGoodsCode = createDto.NatureOfGoodsCode,
            RectificationFrequency = createDto.RectificationFrequency,
            RegimeRequestNumber = createDto.RegimeRequestNumber,
            SequenceNumber = createDto.SequenceNumber,
            ShCode = createDto.ShCode,
            StorageLocation = createDto.StorageLocation,
            StorageLocationUnitCode = createDto.StorageLocationUnitCode,
            SuppressionOn = createDto.SuppressionOn,
            TechnicalName = createDto.TechnicalName,
            TransactionValueCurrencyCode = createDto.TransactionValueCurrencyCode,
            UpdatedAt = createDto.UpdatedAt
        };

        if (createDto.Id != null)
        {
            detailsOfGoodsForPassivePerfection.Id = createDto.Id;
        }

        _context.DetailsOfGoodsForPassivePerfections.Add(detailsOfGoodsForPassivePerfection);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<DetailsOfGoodsForPassivePerfectionDbModel>(
            detailsOfGoodsForPassivePerfection.Id
        );

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one DETAILS OF GOODS FOR PASSIVE PERFECTION
    /// </summary>
    public async Task DeleteDetailsOfGoodsForPassivePerfection(
        DetailsOfGoodsForPassivePerfectionWhereUniqueInput uniqueId
    )
    {
        var detailsOfGoodsForPassivePerfection =
            await _context.DetailsOfGoodsForPassivePerfections.FindAsync(uniqueId.Id);
        if (detailsOfGoodsForPassivePerfection == null)
        {
            throw new NotFoundException();
        }

        _context.DetailsOfGoodsForPassivePerfections.Remove(detailsOfGoodsForPassivePerfection);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many DETAILS OF GOODS FOR PASSIVE PERFECTIONS
    /// </summary>
    public async Task<List<DetailsOfGoodsForPassivePerfection>> DetailsOfGoodsForPassivePerfections(
        DetailsOfGoodsForPassivePerfectionFindManyArgs findManyArgs
    )
    {
        var detailsOfGoodsForPassivePerfections = await _context
            .DetailsOfGoodsForPassivePerfections.ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return detailsOfGoodsForPassivePerfections.ConvertAll(detailsOfGoodsForPassivePerfection =>
            detailsOfGoodsForPassivePerfection.ToDto()
        );
    }

    /// <summary>
    /// Meta data about DETAILS OF GOODS FOR PASSIVE PERFECTION records
    /// </summary>
    public async Task<MetadataDto> DetailsOfGoodsForPassivePerfectionsMeta(
        DetailsOfGoodsForPassivePerfectionFindManyArgs findManyArgs
    )
    {
        var count = await _context
            .DetailsOfGoodsForPassivePerfections.ApplyWhere(findManyArgs.Where)
            .CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one DETAILS OF GOODS FOR PASSIVE PERFECTION
    /// </summary>
    public async Task<DetailsOfGoodsForPassivePerfection> DetailsOfGoodsForPassivePerfection(
        DetailsOfGoodsForPassivePerfectionWhereUniqueInput uniqueId
    )
    {
        var detailsOfGoodsForPassivePerfections = await this.DetailsOfGoodsForPassivePerfections(
            new DetailsOfGoodsForPassivePerfectionFindManyArgs
            {
                Where = new DetailsOfGoodsForPassivePerfectionWhereInput { Id = uniqueId.Id }
            }
        );
        var detailsOfGoodsForPassivePerfection =
            detailsOfGoodsForPassivePerfections.FirstOrDefault();
        if (detailsOfGoodsForPassivePerfection == null)
        {
            throw new NotFoundException();
        }

        return detailsOfGoodsForPassivePerfection;
    }

    /// <summary>
    /// Update one DETAILS OF GOODS FOR PASSIVE PERFECTION
    /// </summary>
    public async Task UpdateDetailsOfGoodsForPassivePerfection(
        DetailsOfGoodsForPassivePerfectionWhereUniqueInput uniqueId,
        DetailsOfGoodsForPassivePerfectionUpdateInput updateDto
    )
    {
        var detailsOfGoodsForPassivePerfection = updateDto.ToModel(uniqueId);

        _context.Entry(detailsOfGoodsForPassivePerfection).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (
                !_context.DetailsOfGoodsForPassivePerfections.Any(e =>
                    e.Id == detailsOfGoodsForPassivePerfection.Id
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
