using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Control.APIs.Extensions;
using Control.Infrastructure;
using Control.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Control.APIs;

public abstract class PlaceOfExecutionAtWithReexportationInTheStatesServiceBase
    : IPlaceOfExecutionAtWithReexportationInTheStatesService
{
    protected readonly ControlDbContext _context;

    public PlaceOfExecutionAtWithReexportationInTheStatesServiceBase(ControlDbContext context)
    {
        _context = context;
    }

    /// <summary>
    ///     Create one PLACE OF EXECUTION AT WITH REEXPORTATION IN THE STATE
    /// </summary>
    public async Task<PlaceOfExecutionAtWithReexportationInTheState>
        CreatePlaceOfExecutionAtWithReexportationInTheState(
            PlaceOfExecutionAtWithReexportationInTheStateCreateInput createDto
        )
    {
        var placeOfExecutionAtWithReexportationInTheState =
            new PlaceOfExecutionAtWithReexportationInTheStateDbModel
            {
                CreatedAt = createDto.CreatedAt,
                DateAndTimeOfFinalModification = createDto.DateAndTimeOfFinalModification,
                DateAndTimeOfFirstRegistration = createDto.DateAndTimeOfFirstRegistration,
                ExecutionPlaces = createDto.ExecutionPlaces,
                FinalModifierSId = createDto.FinalModifierSId,
                FirstRecorderSId = createDto.FirstRecorderSId,
                RectificationFrequency = createDto.RectificationFrequency,
                RequestNumberOfTheRegime = createDto.RequestNumberOfTheRegime,
                SequenceNumber = createDto.SequenceNumber,
                SuppressionOn = createDto.SuppressionOn,
                UpdatedAt = createDto.UpdatedAt
            };

        if (createDto.Id != null) placeOfExecutionAtWithReexportationInTheState.Id = createDto.Id;

        _context.PlaceOfExecutionAtWithReexportationInTheStates.Add(
            placeOfExecutionAtWithReexportationInTheState
        );
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<PlaceOfExecutionAtWithReexportationInTheStateDbModel>(
            placeOfExecutionAtWithReexportationInTheState.Id
        );

        if (result == null) throw new NotFoundException();

        return result.ToDto();
    }

    /// <summary>
    ///     Delete one PLACE OF EXECUTION AT WITH REEXPORTATION IN THE STATE
    /// </summary>
    public async Task DeletePlaceOfExecutionAtWithReexportationInTheState(
        PlaceOfExecutionAtWithReexportationInTheStateWhereUniqueInput uniqueId
    )
    {
        var placeOfExecutionAtWithReexportationInTheState =
            await _context.PlaceOfExecutionAtWithReexportationInTheStates.FindAsync(uniqueId.Id);
        if (placeOfExecutionAtWithReexportationInTheState == null) throw new NotFoundException();

        _context.PlaceOfExecutionAtWithReexportationInTheStates.Remove(
            placeOfExecutionAtWithReexportationInTheState
        );
        await _context.SaveChangesAsync();
    }

    /// <summary>
    ///     Find many PLACE OF EXECUTION AT WITH REEXPORTATION IN THE STATES
    /// </summary>
    public async Task<
        List<PlaceOfExecutionAtWithReexportationInTheState>
    > PlaceOfExecutionAtWithReexportationInTheStates(
        PlaceOfExecutionAtWithReexportationInTheStateFindManyArgs findManyArgs
    )
    {
        var placeOfExecutionAtWithReexportationInTheStates = await _context
            .PlaceOfExecutionAtWithReexportationInTheStates.ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return placeOfExecutionAtWithReexportationInTheStates.ConvertAll(
            placeOfExecutionAtWithReexportationInTheState =>
                placeOfExecutionAtWithReexportationInTheState.ToDto()
        );
    }

    /// <summary>
    ///     Meta data about PLACE OF EXECUTION AT WITH REEXPORTATION IN THE STATE records
    /// </summary>
    public async Task<MetadataDto> PlaceOfExecutionAtWithReexportationInTheStatesMeta(
        PlaceOfExecutionAtWithReexportationInTheStateFindManyArgs findManyArgs
    )
    {
        var count = await _context
            .PlaceOfExecutionAtWithReexportationInTheStates.ApplyWhere(findManyArgs.Where)
            .CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    ///     Get one PLACE OF EXECUTION AT WITH REEXPORTATION IN THE STATE
    /// </summary>
    public async Task<PlaceOfExecutionAtWithReexportationInTheState> PlaceOfExecutionAtWithReexportationInTheState(
        PlaceOfExecutionAtWithReexportationInTheStateWhereUniqueInput uniqueId
    )
    {
        var placeOfExecutionAtWithReexportationInTheStates =
            await PlaceOfExecutionAtWithReexportationInTheStates(
                new PlaceOfExecutionAtWithReexportationInTheStateFindManyArgs
                {
                    Where = new PlaceOfExecutionAtWithReexportationInTheStateWhereInput
                    {
                        Id = uniqueId.Id
                    }
                }
            );
        var placeOfExecutionAtWithReexportationInTheState =
            placeOfExecutionAtWithReexportationInTheStates.FirstOrDefault();
        if (placeOfExecutionAtWithReexportationInTheState == null) throw new NotFoundException();

        return placeOfExecutionAtWithReexportationInTheState;
    }

    /// <summary>
    ///     Update one PLACE OF EXECUTION AT WITH REEXPORTATION IN THE STATE
    /// </summary>
    public async Task UpdatePlaceOfExecutionAtWithReexportationInTheState(
        PlaceOfExecutionAtWithReexportationInTheStateWhereUniqueInput uniqueId,
        PlaceOfExecutionAtWithReexportationInTheStateUpdateInput updateDto
    )
    {
        var placeOfExecutionAtWithReexportationInTheState = updateDto.ToModel(uniqueId);

        _context.Entry(placeOfExecutionAtWithReexportationInTheState).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (
                !_context.PlaceOfExecutionAtWithReexportationInTheStates.Any(e =>
                    e.Id == placeOfExecutionAtWithReexportationInTheState.Id
                )
            )
                throw new NotFoundException();
            throw;
        }
    }
}
