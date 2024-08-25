using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Control.APIs.Extensions;
using Control.Infrastructure;
using Control.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Control.APIs;

public abstract class RawMaterialOfTheDetailedDeclarationCustomsItemsServiceBase
    : IRawMaterialOfTheDetailedDeclarationCustomsItemsService
{
    protected readonly ControlDbContext _context;

    public RawMaterialOfTheDetailedDeclarationCustomsItemsServiceBase(ControlDbContext context)
    {
        _context = context;
    }

    /// <summary>
    ///     Create one RAW MATERIAL OF THE DETAILED DECLARATION (CUSTOMS)
    /// </summary>
    public async Task<RawMaterialOfTheDetailedDeclarationCustoms> CreateRawMaterialOfTheDetailedDeclarationCustoms(
        RawMaterialOfTheDetailedDeclarationCustomsCreateInput createDto
    )
    {
        var rawMaterialOfTheDetailedDeclarationCustoms =
            new RawMaterialOfTheDetailedDeclarationCustomsDbModel
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

        if (createDto.Id != null) rawMaterialOfTheDetailedDeclarationCustoms.Id = createDto.Id;

        _context.RawMaterialOfTheDetailedDeclarationCustomsItems.Add(
            rawMaterialOfTheDetailedDeclarationCustoms
        );
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<RawMaterialOfTheDetailedDeclarationCustomsDbModel>(
            rawMaterialOfTheDetailedDeclarationCustoms.Id
        );

        if (result == null) throw new NotFoundException();

        return result.ToDto();
    }

    /// <summary>
    ///     Delete one RAW MATERIAL OF THE DETAILED DECLARATION (CUSTOMS)
    /// </summary>
    public async Task DeleteRawMaterialOfTheDetailedDeclarationCustoms(
        RawMaterialOfTheDetailedDeclarationCustomsWhereUniqueInput uniqueId
    )
    {
        var rawMaterialOfTheDetailedDeclarationCustoms =
            await _context.RawMaterialOfTheDetailedDeclarationCustomsItems.FindAsync(uniqueId.Id);
        if (rawMaterialOfTheDetailedDeclarationCustoms == null) throw new NotFoundException();

        _context.RawMaterialOfTheDetailedDeclarationCustomsItems.Remove(
            rawMaterialOfTheDetailedDeclarationCustoms
        );
        await _context.SaveChangesAsync();
    }

    /// <summary>
    ///     Find many RAW MATERIAL OF THE DETAILED DECLARATION (CUSTOMS)s
    /// </summary>
    public async Task<
        List<RawMaterialOfTheDetailedDeclarationCustoms>
    > RawMaterialOfTheDetailedDeclarationCustomsItems(
        RawMaterialOfTheDetailedDeclarationCustomsFindManyArgs findManyArgs
    )
    {
        var rawMaterialOfTheDetailedDeclarationCustomsItems = await _context
            .RawMaterialOfTheDetailedDeclarationCustomsItems.ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return rawMaterialOfTheDetailedDeclarationCustomsItems.ConvertAll(
            rawMaterialOfTheDetailedDeclarationCustoms =>
                rawMaterialOfTheDetailedDeclarationCustoms.ToDto()
        );
    }

    /// <summary>
    ///     Meta data about RAW MATERIAL OF THE DETAILED DECLARATION (CUSTOMS) records
    /// </summary>
    public async Task<MetadataDto> RawMaterialOfTheDetailedDeclarationCustomsItemsMeta(
        RawMaterialOfTheDetailedDeclarationCustomsFindManyArgs findManyArgs
    )
    {
        var count = await _context
            .RawMaterialOfTheDetailedDeclarationCustomsItems.ApplyWhere(findManyArgs.Where)
            .CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    ///     Get one RAW MATERIAL OF THE DETAILED DECLARATION (CUSTOMS)
    /// </summary>
    public async Task<RawMaterialOfTheDetailedDeclarationCustoms> RawMaterialOfTheDetailedDeclarationCustoms(
        RawMaterialOfTheDetailedDeclarationCustomsWhereUniqueInput uniqueId
    )
    {
        var rawMaterialOfTheDetailedDeclarationCustomsItems =
            await RawMaterialOfTheDetailedDeclarationCustomsItems(
                new RawMaterialOfTheDetailedDeclarationCustomsFindManyArgs
                {
                    Where = new RawMaterialOfTheDetailedDeclarationCustomsWhereInput
                    {
                        Id = uniqueId.Id
                    }
                }
            );
        var rawMaterialOfTheDetailedDeclarationCustoms =
            rawMaterialOfTheDetailedDeclarationCustomsItems.FirstOrDefault();
        if (rawMaterialOfTheDetailedDeclarationCustoms == null) throw new NotFoundException();

        return rawMaterialOfTheDetailedDeclarationCustoms;
    }

    /// <summary>
    ///     Update one RAW MATERIAL OF THE DETAILED DECLARATION (CUSTOMS)
    /// </summary>
    public async Task UpdateRawMaterialOfTheDetailedDeclarationCustoms(
        RawMaterialOfTheDetailedDeclarationCustomsWhereUniqueInput uniqueId,
        RawMaterialOfTheDetailedDeclarationCustomsUpdateInput updateDto
    )
    {
        var rawMaterialOfTheDetailedDeclarationCustoms = updateDto.ToModel(uniqueId);

        _context.Entry(rawMaterialOfTheDetailedDeclarationCustoms).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (
                !_context.RawMaterialOfTheDetailedDeclarationCustomsItems.Any(e =>
                    e.Id == rawMaterialOfTheDetailedDeclarationCustoms.Id
                )
            )
                throw new NotFoundException();
            throw;
        }
    }
}
