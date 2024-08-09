using Clre.APIs;
using Clre.APIs.Common;
using Clre.APIs.Dtos;
using Clre.APIs.Errors;
using Clre.APIs.Extensions;
using Clre.Infrastructure;
using Clre.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Clre.APIs;

public abstract class StateForPerfectionsServiceBase : IStateForPerfectionsService
{
    protected readonly ClreDbContext _context;

    public StateForPerfectionsServiceBase(ClreDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one STATE FOR PERFECTION
    /// </summary>
    public async Task<StateForPerfection> CreateStateForPerfection(
        StateForPerfectionCreateInput createDto
    )
    {
        var stateForPerfection = new StateForPerfectionDbModel
        {
            AddressOfTheDomiciliaryBank = createDto.AddressOfTheDomiciliaryBank,
            CorporateNameOfTheDomiciliaryBank = createDto.CorporateNameOfTheDomiciliaryBank,
            CreatedAt = createDto.CreatedAt,
            CustomsOfficeAtExportation = createDto.CustomsOfficeAtExportation,
            CustomsOfficeAtImportation = createDto.CustomsOfficeAtImportation,
            DateAndTimeOfFinalModification = createDto.DateAndTimeOfFinalModification,
            DateAndTimeOfFirstRegistration = createDto.DateAndTimeOfFirstRegistration,
            FinalModifierSId = createDto.FinalModifierSId,
            FinancingModeOfTheOperation = createDto.FinancingModeOfTheOperation,
            FirstRegistrantSId = createDto.FirstRegistrantSId,
            NatureOfTheOperation = createDto.NatureOfTheOperation,
            RateOfLosses = createDto.RateOfLosses,
            RateOfNonRecoverableWaste = createDto.RateOfNonRecoverableWaste,
            RateOfQuantitiesOfExportedMaterials = createDto.RateOfQuantitiesOfExportedMaterials,
            RateOfQuantitiesOfExportedPackaging = createDto.RateOfQuantitiesOfExportedPackaging,
            RateOfQuantitiesOfForeignOriginMaterialsAcquiredOnTheForeignMarket =
                createDto.RateOfQuantitiesOfForeignOriginMaterialsAcquiredOnTheForeignMarket,
            RateOfRecoverableWaste = createDto.RateOfRecoverableWaste,
            RateOfWasteOnFinishedProducts = createDto.RateOfWasteOnFinishedProducts,
            RecipientSAddress = createDto.RecipientSAddress,
            RecipientSCorporateName = createDto.RecipientSCorporateName,
            RecipientSName = createDto.RecipientSName,
            RectificationFrequency = createDto.RectificationFrequency,
            RegimeRequestNumber = createDto.RegimeRequestNumber,
            RequestedEndDate = createDto.RequestedEndDate,
            RequestedStartDate = createDto.RequestedStartDate,
            SuppressionOn = createDto.SuppressionOn,
            TotalAmountForeseenForTransformationRepair =
                createDto.TotalAmountForeseenForTransformationRepair,
            TypeOfActivePerfectionSolicited = createDto.TypeOfActivePerfectionSolicited,
            UpdatedAt = createDto.UpdatedAt
        };

        if (createDto.Id != null)
        {
            stateForPerfection.Id = createDto.Id;
        }

        _context.StateForPerfections.Add(stateForPerfection);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<StateForPerfectionDbModel>(stateForPerfection.Id);

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one STATE FOR PERFECTION
    /// </summary>
    public async Task DeleteStateForPerfection(StateForPerfectionWhereUniqueInput uniqueId)
    {
        var stateForPerfection = await _context.StateForPerfections.FindAsync(uniqueId.Id);
        if (stateForPerfection == null)
        {
            throw new NotFoundException();
        }

        _context.StateForPerfections.Remove(stateForPerfection);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many STATE FOR PERFECTIONS
    /// </summary>
    public async Task<List<StateForPerfection>> StateForPerfections(
        StateForPerfectionFindManyArgs findManyArgs
    )
    {
        var stateForPerfections = await _context
            .StateForPerfections.ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return stateForPerfections.ConvertAll(stateForPerfection => stateForPerfection.ToDto());
    }

    /// <summary>
    /// Meta data about STATE FOR PERFECTION records
    /// </summary>
    public async Task<MetadataDto> StateForPerfectionsMeta(
        StateForPerfectionFindManyArgs findManyArgs
    )
    {
        var count = await _context.StateForPerfections.ApplyWhere(findManyArgs.Where).CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one STATE FOR PERFECTION
    /// </summary>
    public async Task<StateForPerfection> StateForPerfection(
        StateForPerfectionWhereUniqueInput uniqueId
    )
    {
        var stateForPerfections = await this.StateForPerfections(
            new StateForPerfectionFindManyArgs
            {
                Where = new StateForPerfectionWhereInput { Id = uniqueId.Id }
            }
        );
        var stateForPerfection = stateForPerfections.FirstOrDefault();
        if (stateForPerfection == null)
        {
            throw new NotFoundException();
        }

        return stateForPerfection;
    }

    /// <summary>
    /// Update one STATE FOR PERFECTION
    /// </summary>
    public async Task UpdateStateForPerfection(
        StateForPerfectionWhereUniqueInput uniqueId,
        StateForPerfectionUpdateInput updateDto
    )
    {
        var stateForPerfection = updateDto.ToModel(uniqueId);

        _context.Entry(stateForPerfection).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!_context.StateForPerfections.Any(e => e.Id == stateForPerfection.Id))
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
