using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Control.APIs.Extensions;
using Control.Infrastructure;
using Control.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Control.APIs;

public abstract class PlaceOfExecutionAndWithReImportationInStatesServiceBase
    : IPlaceOfExecutionAndWithReImportationInStatesService
{
    protected readonly ControlDbContext _context;

    public PlaceOfExecutionAndWithReImportationInStatesServiceBase(ControlDbContext context)
    {
        _context = context;
    }

    /// <summary>
    ///     Create one PLACE OF EXECUTION AND WITH RE-IMPORTATION IN STATE
    /// </summary>
    public async Task<PlaceOfExecutionAndWithReImportationInState> CreatePlaceOfExecutionAndWithReImportationInState(
        PlaceOfExecutionAndWithReImportationInStateCreateInput createDto
    )
    {
        var placeOfExecutionAndWithReImportationInState =
            new PlaceOfExecutionAndWithReImportationInStateDbModel
            {
                CreatedAt = createDto.CreatedAt,
                DateAndTimeOfFinalModification = createDto.DateAndTimeOfFinalModification,
                DateAndTimeOfFirstRegistration = createDto.DateAndTimeOfFirstRegistration,
                ExecutionPlaces = createDto.ExecutionPlaces,
                FinalModifierSId = createDto.FinalModifierSId,
                FirstRegistrantSId = createDto.FirstRegistrantSId,
                RectificationFrequency = createDto.RectificationFrequency,
                RegimeRequestNumber = createDto.RegimeRequestNumber,
                SequenceNumber = createDto.SequenceNumber,
                SuppressionOn = createDto.SuppressionOn,
                UpdatedAt = createDto.UpdatedAt
            };

        if (createDto.Id != null) placeOfExecutionAndWithReImportationInState.Id = createDto.Id;

        _context.PlaceOfExecutionAndWithReImportationInStates.Add(
            placeOfExecutionAndWithReImportationInState
        );
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<PlaceOfExecutionAndWithReImportationInStateDbModel>(
            placeOfExecutionAndWithReImportationInState.Id
        );

        if (result == null) throw new NotFoundException();

        return result.ToDto();
    }

    /// <summary>
    ///     Delete one PLACE OF EXECUTION AND WITH RE-IMPORTATION IN STATE
    /// </summary>
    public async Task DeletePlaceOfExecutionAndWithReImportationInState(
        PlaceOfExecutionAndWithReImportationInStateWhereUniqueInput uniqueId
    )
    {
        var placeOfExecutionAndWithReImportationInState =
            await _context.PlaceOfExecutionAndWithReImportationInStates.FindAsync(uniqueId.Id);
        if (placeOfExecutionAndWithReImportationInState == null) throw new NotFoundException();

        _context.PlaceOfExecutionAndWithReImportationInStates.Remove(
            placeOfExecutionAndWithReImportationInState
        );
        await _context.SaveChangesAsync();
    }

    /// <summary>
    ///     Find many PLACE OF EXECUTION AND WITH RE-IMPORTATION IN STATES
    /// </summary>
    public async Task<
        List<PlaceOfExecutionAndWithReImportationInState>
    > PlaceOfExecutionAndWithReImportationInStates(
        PlaceOfExecutionAndWithReImportationInStateFindManyArgs findManyArgs
    )
    {
        var placeOfExecutionAndWithReImportationInStates = await _context
            .PlaceOfExecutionAndWithReImportationInStates.ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return placeOfExecutionAndWithReImportationInStates.ConvertAll(
            placeOfExecutionAndWithReImportationInState =>
                placeOfExecutionAndWithReImportationInState.ToDto()
        );
    }

    /// <summary>
    ///     Meta data about PLACE OF EXECUTION AND WITH RE-IMPORTATION IN STATE records
    /// </summary>
    public async Task<MetadataDto> PlaceOfExecutionAndWithReImportationInStatesMeta(
        PlaceOfExecutionAndWithReImportationInStateFindManyArgs findManyArgs
    )
    {
        var count = await _context
            .PlaceOfExecutionAndWithReImportationInStates.ApplyWhere(findManyArgs.Where)
            .CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    ///     Get one PLACE OF EXECUTION AND WITH RE-IMPORTATION IN STATE
    /// </summary>
    public async Task<PlaceOfExecutionAndWithReImportationInState> PlaceOfExecutionAndWithReImportationInState(
        PlaceOfExecutionAndWithReImportationInStateWhereUniqueInput uniqueId
    )
    {
        var placeOfExecutionAndWithReImportationInStates =
            await PlaceOfExecutionAndWithReImportationInStates(
                new PlaceOfExecutionAndWithReImportationInStateFindManyArgs
                {
                    Where = new PlaceOfExecutionAndWithReImportationInStateWhereInput
                    {
                        Id = uniqueId.Id
                    }
                }
            );
        var placeOfExecutionAndWithReImportationInState =
            placeOfExecutionAndWithReImportationInStates.FirstOrDefault();
        if (placeOfExecutionAndWithReImportationInState == null) throw new NotFoundException();

        return placeOfExecutionAndWithReImportationInState;
    }

    /// <summary>
    ///     Update one PLACE OF EXECUTION AND WITH RE-IMPORTATION IN STATE
    /// </summary>
    public async Task UpdatePlaceOfExecutionAndWithReImportationInState(
        PlaceOfExecutionAndWithReImportationInStateWhereUniqueInput uniqueId,
        PlaceOfExecutionAndWithReImportationInStateUpdateInput updateDto
    )
    {
        var placeOfExecutionAndWithReImportationInState = updateDto.ToModel(uniqueId);

        _context.Entry(placeOfExecutionAndWithReImportationInState).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (
                !_context.PlaceOfExecutionAndWithReImportationInStates.Any(e =>
                    e.Id == placeOfExecutionAndWithReImportationInState.Id
                )
            )
                throw new NotFoundException();
            throw;
        }
    }
}
