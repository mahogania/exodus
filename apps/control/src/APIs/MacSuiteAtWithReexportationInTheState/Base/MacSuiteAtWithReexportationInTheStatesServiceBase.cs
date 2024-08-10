using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Control.APIs.Extensions;
using Control.Infrastructure;
using Control.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Control.APIs;

public abstract class MacSuiteAtWithReexportationInTheStatesServiceBase
    : IMacSuiteAtWithReexportationInTheStatesService
{
    protected readonly ControlDbContext _context;

    public MacSuiteAtWithReexportationInTheStatesServiceBase(ControlDbContext context)
    {
        _context = context;
    }

    /// <summary>
    ///     Create one MAC SUITE AT WITH REEXPORTATION IN THE STATE
    /// </summary>
    public async Task<MacSuiteAtWithReexportationInTheState> CreateMacSuiteAtWithReexportationInTheState(
        MacSuiteAtWithReexportationInTheStateCreateInput createDto
    )
    {
        var macSuiteAtWithReexportationInTheState = new MacSuiteAtWithReexportationInTheStateDbModel
        {
            ApcCode = createDto.ApcCode,
            ApcLabel = createDto.ApcLabel,
            AtDeclarationDate = createDto.AtDeclarationDate,
            AtDeclarationNumber = createDto.AtDeclarationNumber,
            BusinessRegisterNumber = createDto.BusinessRegisterNumber,
            ContentOfTheRequestReason = createDto.ContentOfTheRequestReason,
            CreatedAt = createDto.CreatedAt,
            CustomsClearanceOfficeForMac = createDto.CustomsClearanceOfficeForMac,
            CustomsDeclarationOffice = createDto.CustomsDeclarationOffice,
            DateAndTimeOfFinalModification = createDto.DateAndTimeOfFinalModification,
            DateAndTimeOfFirstRegistration = createDto.DateAndTimeOfFirstRegistration,
            DueDate = createDto.DueDate,
            EpcCode = createDto.EpcCode,
            EpcLabel = createDto.EpcLabel,
            ExecutionPlaces = createDto.ExecutionPlaces,
            FinalModifierSId = createDto.FinalModifierSId,
            FirstRegistrantSId = createDto.FirstRegistrantSId,
            Importer = createDto.Importer,
            Nif = createDto.Nif,
            NifStatus = createDto.NifStatus,
            NumberOfArticles = createDto.NumberOfArticles,
            RcStatus = createDto.RcStatus,
            RectificationFrequency = createDto.RectificationFrequency,
            RegimeRequestNumber = createDto.RegimeRequestNumber,
            SuppressionOn = createDto.SuppressionOn,
            UpdatedAt = createDto.UpdatedAt
        };

        if (createDto.Id != null) macSuiteAtWithReexportationInTheState.Id = createDto.Id;

        _context.MacSuiteAtWithReexportationInTheStates.Add(macSuiteAtWithReexportationInTheState);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<MacSuiteAtWithReexportationInTheStateDbModel>(
            macSuiteAtWithReexportationInTheState.Id
        );

        if (result == null) throw new NotFoundException();

        return result.ToDto();
    }

    /// <summary>
    ///     Delete one MAC SUITE AT WITH REEXPORTATION IN THE STATE
    /// </summary>
    public async Task DeleteMacSuiteAtWithReexportationInTheState(
        MacSuiteAtWithReexportationInTheStateWhereUniqueInput uniqueId
    )
    {
        var macSuiteAtWithReexportationInTheState =
            await _context.MacSuiteAtWithReexportationInTheStates.FindAsync(uniqueId.Id);
        if (macSuiteAtWithReexportationInTheState == null) throw new NotFoundException();

        _context.MacSuiteAtWithReexportationInTheStates.Remove(
            macSuiteAtWithReexportationInTheState
        );
        await _context.SaveChangesAsync();
    }

    /// <summary>
    ///     Find many MAC SUITE AT WITH REEXPORTATION IN THE STATES
    /// </summary>
    public async Task<
        List<MacSuiteAtWithReexportationInTheState>
    > MacSuiteAtWithReexportationInTheStates(
        MacSuiteAtWithReexportationInTheStateFindManyArgs findManyArgs
    )
    {
        var macSuiteAtWithReexportationInTheStates = await _context
            .MacSuiteAtWithReexportationInTheStates.ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return macSuiteAtWithReexportationInTheStates.ConvertAll(
            macSuiteAtWithReexportationInTheState => macSuiteAtWithReexportationInTheState.ToDto()
        );
    }

    /// <summary>
    ///     Meta data about MAC SUITE AT WITH REEXPORTATION IN THE STATE records
    /// </summary>
    public async Task<MetadataDto> MacSuiteAtWithReexportationInTheStatesMeta(
        MacSuiteAtWithReexportationInTheStateFindManyArgs findManyArgs
    )
    {
        var count = await _context
            .MacSuiteAtWithReexportationInTheStates.ApplyWhere(findManyArgs.Where)
            .CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    ///     Get one MAC SUITE AT WITH REEXPORTATION IN THE STATE
    /// </summary>
    public async Task<MacSuiteAtWithReexportationInTheState> MacSuiteAtWithReexportationInTheState(
        MacSuiteAtWithReexportationInTheStateWhereUniqueInput uniqueId
    )
    {
        var macSuiteAtWithReexportationInTheStates =
            await MacSuiteAtWithReexportationInTheStates(
                new MacSuiteAtWithReexportationInTheStateFindManyArgs
                {
                    Where = new MacSuiteAtWithReexportationInTheStateWhereInput { Id = uniqueId.Id }
                }
            );
        var macSuiteAtWithReexportationInTheState =
            macSuiteAtWithReexportationInTheStates.FirstOrDefault();
        if (macSuiteAtWithReexportationInTheState == null) throw new NotFoundException();

        return macSuiteAtWithReexportationInTheState;
    }

    /// <summary>
    ///     Update one MAC SUITE AT WITH REEXPORTATION IN THE STATE
    /// </summary>
    public async Task UpdateMacSuiteAtWithReexportationInTheState(
        MacSuiteAtWithReexportationInTheStateWhereUniqueInput uniqueId,
        MacSuiteAtWithReexportationInTheStateUpdateInput updateDto
    )
    {
        var macSuiteAtWithReexportationInTheState = updateDto.ToModel(uniqueId);

        _context.Entry(macSuiteAtWithReexportationInTheState).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (
                !_context.MacSuiteAtWithReexportationInTheStates.Any(e =>
                    e.Id == macSuiteAtWithReexportationInTheState.Id
                )
            )
                throw new NotFoundException();
            throw;
        }
    }
}
