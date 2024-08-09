using Clre.APIs;
using Clre.APIs.Common;
using Clre.APIs.Dtos;
using Clre.APIs.Errors;
using Clre.APIs.Extensions;
using Clre.Infrastructure;
using Clre.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Clre.APIs;

public abstract class MaterialsAtWithReexportationInTheStatesServiceBase
    : IMaterialsAtWithReexportationInTheStatesService
{
    protected readonly ClreDbContext _context;

    public MaterialsAtWithReexportationInTheStatesServiceBase(ClreDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one MATERIALS AT WITH REEXPORTATION IN THE STATE
    /// </summary>
    public async Task<MaterialsAtWithReexportationInTheState> CreateMaterialsAtWithReexportationInTheState(
        MaterialsAtWithReexportationInTheStateCreateInput createDto
    )
    {
        var materialsAtWithReexportationInTheState =
            new MaterialsAtWithReexportationInTheStateDbModel
            {
                CommercialDesignationOfTheMaterials = createDto.CommercialDesignationOfTheMaterials,
                CreatedAt = createDto.CreatedAt,
                CurrencyCode = createDto.CurrencyCode,
                DateAndTimeOfFinalModification = createDto.DateAndTimeOfFinalModification,
                DateAndTimeOfFirstRegistration = createDto.DateAndTimeOfFirstRegistration,
                FinalModifierSId = createDto.FinalModifierSId,
                FirstRegistrantSId = createDto.FirstRegistrantSId,
                FobValueInCurrency = createDto.FobValueInCurrency,
                FobValueInDa = createDto.FobValueInDa,
                Identification = createDto.Identification,
                Origin = createDto.Origin,
                Quantity = createDto.Quantity,
                RectificationFrequency = createDto.RectificationFrequency,
                RegimeRequestNumber = createDto.RegimeRequestNumber,
                SequenceNumber = createDto.SequenceNumber,
                SptNumber = createDto.SptNumber,
                StateOfTheMaterialsAtTheTimeOfImportation =
                    createDto.StateOfTheMaterialsAtTheTimeOfImportation,
                SuppressionOn = createDto.SuppressionOn,
                TechnicalDesignationOfTheMaterials = createDto.TechnicalDesignationOfTheMaterials,
                UnknownField = createDto.UnknownField,
                UpdatedAt = createDto.UpdatedAt
            };

        if (createDto.Id != null)
        {
            materialsAtWithReexportationInTheState.Id = createDto.Id;
        }

        _context.MaterialsAtWithReexportationInTheStates.Add(
            materialsAtWithReexportationInTheState
        );
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<MaterialsAtWithReexportationInTheStateDbModel>(
            materialsAtWithReexportationInTheState.Id
        );

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one MATERIALS AT WITH REEXPORTATION IN THE STATE
    /// </summary>
    public async Task DeleteMaterialsAtWithReexportationInTheState(
        MaterialsAtWithReexportationInTheStateWhereUniqueInput uniqueId
    )
    {
        var materialsAtWithReexportationInTheState =
            await _context.MaterialsAtWithReexportationInTheStates.FindAsync(uniqueId.Id);
        if (materialsAtWithReexportationInTheState == null)
        {
            throw new NotFoundException();
        }

        _context.MaterialsAtWithReexportationInTheStates.Remove(
            materialsAtWithReexportationInTheState
        );
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many MATERIALS AT WITH REEXPORTATION IN THE STATES
    /// </summary>
    public async Task<
        List<MaterialsAtWithReexportationInTheState>
    > MaterialsAtWithReexportationInTheStates(
        MaterialsAtWithReexportationInTheStateFindManyArgs findManyArgs
    )
    {
        var materialsAtWithReexportationInTheStates = await _context
            .MaterialsAtWithReexportationInTheStates.ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return materialsAtWithReexportationInTheStates.ConvertAll(
            materialsAtWithReexportationInTheState => materialsAtWithReexportationInTheState.ToDto()
        );
    }

    /// <summary>
    /// Meta data about MATERIALS AT WITH REEXPORTATION IN THE STATE records
    /// </summary>
    public async Task<MetadataDto> MaterialsAtWithReexportationInTheStatesMeta(
        MaterialsAtWithReexportationInTheStateFindManyArgs findManyArgs
    )
    {
        var count = await _context
            .MaterialsAtWithReexportationInTheStates.ApplyWhere(findManyArgs.Where)
            .CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one MATERIALS AT WITH REEXPORTATION IN THE STATE
    /// </summary>
    public async Task<MaterialsAtWithReexportationInTheState> MaterialsAtWithReexportationInTheState(
        MaterialsAtWithReexportationInTheStateWhereUniqueInput uniqueId
    )
    {
        var materialsAtWithReexportationInTheStates =
            await this.MaterialsAtWithReexportationInTheStates(
                new MaterialsAtWithReexportationInTheStateFindManyArgs
                {
                    Where = new MaterialsAtWithReexportationInTheStateWhereInput
                    {
                        Id = uniqueId.Id
                    }
                }
            );
        var materialsAtWithReexportationInTheState =
            materialsAtWithReexportationInTheStates.FirstOrDefault();
        if (materialsAtWithReexportationInTheState == null)
        {
            throw new NotFoundException();
        }

        return materialsAtWithReexportationInTheState;
    }

    /// <summary>
    /// Update one MATERIALS AT WITH REEXPORTATION IN THE STATE
    /// </summary>
    public async Task UpdateMaterialsAtWithReexportationInTheState(
        MaterialsAtWithReexportationInTheStateWhereUniqueInput uniqueId,
        MaterialsAtWithReexportationInTheStateUpdateInput updateDto
    )
    {
        var materialsAtWithReexportationInTheState = updateDto.ToModel(uniqueId);

        _context.Entry(materialsAtWithReexportationInTheState).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (
                !_context.MaterialsAtWithReexportationInTheStates.Any(e =>
                    e.Id == materialsAtWithReexportationInTheState.Id
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
