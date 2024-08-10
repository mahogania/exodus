using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Control.APIs.Extensions;
using Control.Infrastructure;
using Control.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Control.APIs;

public abstract class GoodsMacSuiteAtAndWithReExportationInStatesServiceBase
    : IGoodsMacSuiteAtAndWithReExportationInStatesService
{
    protected readonly ControlDbContext _context;

    public GoodsMacSuiteAtAndWithReExportationInStatesServiceBase(ControlDbContext context)
    {
        _context = context;
    }

    /// <summary>
    ///     Create one GOODS MAC SUITE AT AND WITH RE-EXPORTATION IN STATE
    /// </summary>
    public async Task<GoodsMacSuiteAtAndWithReExportationInState> CreateGoodsMacSuiteAtAndWithReExportationInState(
        GoodsMacSuiteAtAndWithReExportationInStateCreateInput createDto
    )
    {
        var goodsMacSuiteAtAndWithReExportationInState =
            new GoodsMacSuiteAtAndWithReExportationInStateDbModel
            {
                CommercialDesignationOfMaterials = createDto.CommercialDesignationOfMaterials,
                ConcernedArticleNumber = createDto.ConcernedArticleNumber,
                CreatedAt = createDto.CreatedAt,
                CurrencyCode = createDto.CurrencyCode,
                CurrencyValueOfGoods = createDto.CurrencyValueOfGoods,
                DateAndTimeOfFinalModification = createDto.DateAndTimeOfFinalModification,
                DateAndTimeOfFirstRegistration = createDto.DateAndTimeOfFirstRegistration,
                FinalModifierSId = createDto.FinalModifierSId,
                FirstRegistrantSId = createDto.FirstRegistrantSId,
                Identification = createDto.Identification,
                Origin = createDto.Origin,
                RectificationFrequency = createDto.RectificationFrequency,
                ReferenceSOfTheConcernedArticleModelS =
                    createDto.ReferenceSOfTheConcernedArticleModelS,
                RegimeRequestNumber = createDto.RegimeRequestNumber,
                SequenceNumber = createDto.SequenceNumber,
                SptNumber = createDto.SptNumber,
                StoragePlace = createDto.StoragePlace,
                SuppressionOn = createDto.SuppressionOn,
                TechnicalDesignationOfMaterials = createDto.TechnicalDesignationOfMaterials,
                UpdatedAt = createDto.UpdatedAt,
                Value = createDto.Value
            };

        if (createDto.Id != null) goodsMacSuiteAtAndWithReExportationInState.Id = createDto.Id;

        _context.GoodsMacSuiteAtAndWithReExportationInStates.Add(
            goodsMacSuiteAtAndWithReExportationInState
        );
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<GoodsMacSuiteAtAndWithReExportationInStateDbModel>(
            goodsMacSuiteAtAndWithReExportationInState.Id
        );

        if (result == null) throw new NotFoundException();

        return result.ToDto();
    }

    /// <summary>
    ///     Delete one GOODS MAC SUITE AT AND WITH RE-EXPORTATION IN STATE
    /// </summary>
    public async Task DeleteGoodsMacSuiteAtAndWithReExportationInState(
        GoodsMacSuiteAtAndWithReExportationInStateWhereUniqueInput uniqueId
    )
    {
        var goodsMacSuiteAtAndWithReExportationInState =
            await _context.GoodsMacSuiteAtAndWithReExportationInStates.FindAsync(uniqueId.Id);
        if (goodsMacSuiteAtAndWithReExportationInState == null) throw new NotFoundException();

        _context.GoodsMacSuiteAtAndWithReExportationInStates.Remove(
            goodsMacSuiteAtAndWithReExportationInState
        );
        await _context.SaveChangesAsync();
    }

    /// <summary>
    ///     Find many GOODS MAC SUITE AT AND WITH RE-EXPORTATION IN STATES
    /// </summary>
    public async Task<
        List<GoodsMacSuiteAtAndWithReExportationInState>
    > GoodsMacSuiteAtAndWithReExportationInStates(
        GoodsMacSuiteAtAndWithReExportationInStateFindManyArgs findManyArgs
    )
    {
        var goodsMacSuiteAtAndWithReExportationInStates = await _context
            .GoodsMacSuiteAtAndWithReExportationInStates.ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return goodsMacSuiteAtAndWithReExportationInStates.ConvertAll(
            goodsMacSuiteAtAndWithReExportationInState =>
                goodsMacSuiteAtAndWithReExportationInState.ToDto()
        );
    }

    /// <summary>
    ///     Meta data about GOODS MAC SUITE AT AND WITH RE-EXPORTATION IN STATE records
    /// </summary>
    public async Task<MetadataDto> GoodsMacSuiteAtAndWithReExportationInStatesMeta(
        GoodsMacSuiteAtAndWithReExportationInStateFindManyArgs findManyArgs
    )
    {
        var count = await _context
            .GoodsMacSuiteAtAndWithReExportationInStates.ApplyWhere(findManyArgs.Where)
            .CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    ///     Get one GOODS MAC SUITE AT AND WITH RE-EXPORTATION IN STATE
    /// </summary>
    public async Task<GoodsMacSuiteAtAndWithReExportationInState> GoodsMacSuiteAtAndWithReExportationInState(
        GoodsMacSuiteAtAndWithReExportationInStateWhereUniqueInput uniqueId
    )
    {
        var goodsMacSuiteAtAndWithReExportationInStates =
            await GoodsMacSuiteAtAndWithReExportationInStates(
                new GoodsMacSuiteAtAndWithReExportationInStateFindManyArgs
                {
                    Where = new GoodsMacSuiteAtAndWithReExportationInStateWhereInput
                    {
                        Id = uniqueId.Id
                    }
                }
            );
        var goodsMacSuiteAtAndWithReExportationInState =
            goodsMacSuiteAtAndWithReExportationInStates.FirstOrDefault();
        if (goodsMacSuiteAtAndWithReExportationInState == null) throw new NotFoundException();

        return goodsMacSuiteAtAndWithReExportationInState;
    }

    /// <summary>
    ///     Update one GOODS MAC SUITE AT AND WITH RE-EXPORTATION IN STATE
    /// </summary>
    public async Task UpdateGoodsMacSuiteAtAndWithReExportationInState(
        GoodsMacSuiteAtAndWithReExportationInStateWhereUniqueInput uniqueId,
        GoodsMacSuiteAtAndWithReExportationInStateUpdateInput updateDto
    )
    {
        var goodsMacSuiteAtAndWithReExportationInState = updateDto.ToModel(uniqueId);

        _context.Entry(goodsMacSuiteAtAndWithReExportationInState).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (
                !_context.GoodsMacSuiteAtAndWithReExportationInStates.Any(e =>
                    e.Id == goodsMacSuiteAtAndWithReExportationInState.Id
                )
            )
                throw new NotFoundException();
            throw;
        }
    }
}
