using Control.APIs;
using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Control.APIs.Extensions;
using Control.Infrastructure;
using Control.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Control.APIs;

public abstract class StateWithReImportationInTheStatesServiceBase
    : IStateWithReImportationInTheStatesService
{
    protected readonly ControlDbContext _context;

    public StateWithReImportationInTheStatesServiceBase(ControlDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one STATE WITH RE-IMPORTATION IN THE STATE
    /// </summary>
    public async Task<StateWithReImportationInTheState> CreateStateWithReImportationInTheState(
        StateWithReImportationInTheStateCreateInput createDto
    )
    {
        var stateWithReImportationInTheState = new StateWithReImportationInTheStateDbModel
        {
            Address = createDto.Address,
            ContractObject = createDto.ContractObject,
            ContractReference = createDto.ContractReference,
            CreatedAt = createDto.CreatedAt,
            CustomsOfficeForReImportationIndicative =
                createDto.CustomsOfficeForReImportationIndicative,
            DateAndTimeOfFinalModification = createDto.DateAndTimeOfFinalModification,
            DateAndTimeOfFirstRegistration = createDto.DateAndTimeOfFirstRegistration,
            ExportingCountryCode = createDto.ExportingCountryCode,
            FinalModifierSId = createDto.FinalModifierSId,
            FirstRegistrantSId = createDto.FirstRegistrantSId,
            ForeignRecipient = createDto.ForeignRecipient,
            RectificationFrequency = createDto.RectificationFrequency,
            RegimeRequestNumber = createDto.RegimeRequestNumber,
            RequestedEndDateOfTemporaryExport = createDto.RequestedEndDateOfTemporaryExport,
            RequestedStartDateOfTemporaryExport = createDto.RequestedStartDateOfTemporaryExport,
            SuppressionOn = createDto.SuppressionOn,
            UnknownFieldOne = createDto.UnknownFieldOne,
            UnknownFieldTwo = createDto.UnknownFieldTwo,
            UpdatedAt = createDto.UpdatedAt
        };

        if (createDto.Id != null)
        {
            stateWithReImportationInTheState.Id = createDto.Id;
        }

        _context.StateWithReImportationInTheStates.Add(stateWithReImportationInTheState);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<StateWithReImportationInTheStateDbModel>(
            stateWithReImportationInTheState.Id
        );

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one STATE WITH RE-IMPORTATION IN THE STATE
    /// </summary>
    public async Task DeleteStateWithReImportationInTheState(
        StateWithReImportationInTheStateWhereUniqueInput uniqueId
    )
    {
        var stateWithReImportationInTheState =
            await _context.StateWithReImportationInTheStates.FindAsync(uniqueId.Id);
        if (stateWithReImportationInTheState == null)
        {
            throw new NotFoundException();
        }

        _context.StateWithReImportationInTheStates.Remove(stateWithReImportationInTheState);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many STATE WITH RE-IMPORTATION IN THE STATES
    /// </summary>
    public async Task<List<StateWithReImportationInTheState>> StateWithReImportationInTheStates(
        StateWithReImportationInTheStateFindManyArgs findManyArgs
    )
    {
        var stateWithReImportationInTheStates = await _context
            .StateWithReImportationInTheStates.ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return stateWithReImportationInTheStates.ConvertAll(stateWithReImportationInTheState =>
            stateWithReImportationInTheState.ToDto()
        );
    }

    /// <summary>
    /// Meta data about STATE WITH RE-IMPORTATION IN THE STATE records
    /// </summary>
    public async Task<MetadataDto> StateWithReImportationInTheStatesMeta(
        StateWithReImportationInTheStateFindManyArgs findManyArgs
    )
    {
        var count = await _context
            .StateWithReImportationInTheStates.ApplyWhere(findManyArgs.Where)
            .CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one STATE WITH RE-IMPORTATION IN THE STATE
    /// </summary>
    public async Task<StateWithReImportationInTheState> StateWithReImportationInTheState(
        StateWithReImportationInTheStateWhereUniqueInput uniqueId
    )
    {
        var stateWithReImportationInTheStates = await this.StateWithReImportationInTheStates(
            new StateWithReImportationInTheStateFindManyArgs
            {
                Where = new StateWithReImportationInTheStateWhereInput { Id = uniqueId.Id }
            }
        );
        var stateWithReImportationInTheState = stateWithReImportationInTheStates.FirstOrDefault();
        if (stateWithReImportationInTheState == null)
        {
            throw new NotFoundException();
        }

        return stateWithReImportationInTheState;
    }

    /// <summary>
    /// Update one STATE WITH RE-IMPORTATION IN THE STATE
    /// </summary>
    public async Task UpdateStateWithReImportationInTheState(
        StateWithReImportationInTheStateWhereUniqueInput uniqueId,
        StateWithReImportationInTheStateUpdateInput updateDto
    )
    {
        var stateWithReImportationInTheState = updateDto.ToModel(uniqueId);

        _context.Entry(stateWithReImportationInTheState).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (
                !_context.StateWithReImportationInTheStates.Any(e =>
                    e.Id == stateWithReImportationInTheState.Id
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
