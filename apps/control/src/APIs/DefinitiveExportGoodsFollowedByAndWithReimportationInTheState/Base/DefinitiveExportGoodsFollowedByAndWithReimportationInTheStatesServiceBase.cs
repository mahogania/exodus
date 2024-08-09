using Clre.APIs;
using Clre.APIs.Common;
using Clre.APIs.Dtos;
using Clre.APIs.Errors;
using Clre.APIs.Extensions;
using Clre.Infrastructure;
using Clre.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Clre.APIs;

public abstract class DefinitiveExportGoodsFollowedByAndWithReimportationInTheStatesServiceBase
    : IDefinitiveExportGoodsFollowedByAndWithReimportationInTheStatesService
{
    protected readonly ClreDbContext _context;

    public DefinitiveExportGoodsFollowedByAndWithReimportationInTheStatesServiceBase(
        ClreDbContext context
    )
    {
        _context = context;
    }

    /// <summary>
    /// Create one DEFINITIVE EXPORT GOODS FOLLOWED BY AND WITH REIMPORTATION IN THE STATE
    /// </summary>
    public async Task<DefinitiveExportGoodsFollowedByAndWithReimportationInTheState> CreateDefinitiveExportGoodsFollowedByAndWithReimportationInTheState(
        DefinitiveExportGoodsFollowedByAndWithReimportationInTheStateCreateInput createDto
    )
    {
        var definitiveExportGoodsFollowedByAndWithReimportationInTheState =
            new DefinitiveExportGoodsFollowedByAndWithReimportationInTheStateDbModel
            {
                CommercialDesignationOfTheMaterials = createDto.CommercialDesignationOfTheMaterials,
                CreatedAt = createDto.CreatedAt,
                CurrencyCode = createDto.CurrencyCode,
                DateAndTimeOfFinalModification = createDto.DateAndTimeOfFinalModification,
                DateAndTimeOfFirstRegistration = createDto.DateAndTimeOfFirstRegistration,
                FinalModifierSId = createDto.FinalModifierSId,
                FirstRecorderSId = createDto.FirstRecorderSId,
                Identification = createDto.Identification,
                NumberOfTheArticleConcerned = createDto.NumberOfTheArticleConcerned,
                Origin = createDto.Origin,
                RectificationFrequency = createDto.RectificationFrequency,
                ReferenceSOfTheModelSOfTheArticleConcerned =
                    createDto.ReferenceSOfTheModelSOfTheArticleConcerned,
                RequestNumberOfTheRegime = createDto.RequestNumberOfTheRegime,
                SequenceNumber = createDto.SequenceNumber,
                SptNumber = createDto.SptNumber,
                StorageLocation = createDto.StorageLocation,
                SuppressionOn = createDto.SuppressionOn,
                TechnicalDesignationOfTheMaterials = createDto.TechnicalDesignationOfTheMaterials,
                UnknownField = createDto.UnknownField,
                UpdatedAt = createDto.UpdatedAt,
                Value = createDto.Value,
                ValueInCurrencyOfTheGoods = createDto.ValueInCurrencyOfTheGoods
            };

        if (createDto.Id != null)
        {
            definitiveExportGoodsFollowedByAndWithReimportationInTheState.Id = createDto.Id;
        }

        _context.DefinitiveExportGoodsFollowedByAndWithReimportationInTheStates.Add(
            definitiveExportGoodsFollowedByAndWithReimportationInTheState
        );
        await _context.SaveChangesAsync();

        var result =
            await _context.FindAsync<DefinitiveExportGoodsFollowedByAndWithReimportationInTheStateDbModel>(
                definitiveExportGoodsFollowedByAndWithReimportationInTheState.Id
            );

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one DEFINITIVE EXPORT GOODS FOLLOWED BY AND WITH REIMPORTATION IN THE STATE
    /// </summary>
    public async Task DeleteDefinitiveExportGoodsFollowedByAndWithReimportationInTheState(
        DefinitiveExportGoodsFollowedByAndWithReimportationInTheStateWhereUniqueInput uniqueId
    )
    {
        var definitiveExportGoodsFollowedByAndWithReimportationInTheState =
            await _context.DefinitiveExportGoodsFollowedByAndWithReimportationInTheStates.FindAsync(
                uniqueId.Id
            );
        if (definitiveExportGoodsFollowedByAndWithReimportationInTheState == null)
        {
            throw new NotFoundException();
        }

        _context.DefinitiveExportGoodsFollowedByAndWithReimportationInTheStates.Remove(
            definitiveExportGoodsFollowedByAndWithReimportationInTheState
        );
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many DEFINITIVE EXPORT GOODS FOLLOWED BY AND WITH REIMPORTATION IN THE STATES
    /// </summary>
    public async Task<
        List<DefinitiveExportGoodsFollowedByAndWithReimportationInTheState>
    > DefinitiveExportGoodsFollowedByAndWithReimportationInTheStates(
        DefinitiveExportGoodsFollowedByAndWithReimportationInTheStateFindManyArgs findManyArgs
    )
    {
        var definitiveExportGoodsFollowedByAndWithReimportationInTheStates = await _context
            .DefinitiveExportGoodsFollowedByAndWithReimportationInTheStates.ApplyWhere(
                findManyArgs.Where
            )
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return definitiveExportGoodsFollowedByAndWithReimportationInTheStates.ConvertAll(
            definitiveExportGoodsFollowedByAndWithReimportationInTheState =>
                definitiveExportGoodsFollowedByAndWithReimportationInTheState.ToDto()
        );
    }

    /// <summary>
    /// Meta data about DEFINITIVE EXPORT GOODS FOLLOWED BY AND WITH REIMPORTATION IN THE STATE records
    /// </summary>
    public async Task<MetadataDto> DefinitiveExportGoodsFollowedByAndWithReimportationInTheStatesMeta(
        DefinitiveExportGoodsFollowedByAndWithReimportationInTheStateFindManyArgs findManyArgs
    )
    {
        var count = await _context
            .DefinitiveExportGoodsFollowedByAndWithReimportationInTheStates.ApplyWhere(
                findManyArgs.Where
            )
            .CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one DEFINITIVE EXPORT GOODS FOLLOWED BY AND WITH REIMPORTATION IN THE STATE
    /// </summary>
    public async Task<DefinitiveExportGoodsFollowedByAndWithReimportationInTheState> DefinitiveExportGoodsFollowedByAndWithReimportationInTheState(
        DefinitiveExportGoodsFollowedByAndWithReimportationInTheStateWhereUniqueInput uniqueId
    )
    {
        var definitiveExportGoodsFollowedByAndWithReimportationInTheStates =
            await this.DefinitiveExportGoodsFollowedByAndWithReimportationInTheStates(
                new DefinitiveExportGoodsFollowedByAndWithReimportationInTheStateFindManyArgs
                {
                    Where =
                        new DefinitiveExportGoodsFollowedByAndWithReimportationInTheStateWhereInput
                        {
                            Id = uniqueId.Id
                        }
                }
            );
        var definitiveExportGoodsFollowedByAndWithReimportationInTheState =
            definitiveExportGoodsFollowedByAndWithReimportationInTheStates.FirstOrDefault();
        if (definitiveExportGoodsFollowedByAndWithReimportationInTheState == null)
        {
            throw new NotFoundException();
        }

        return definitiveExportGoodsFollowedByAndWithReimportationInTheState;
    }

    /// <summary>
    /// Update one DEFINITIVE EXPORT GOODS FOLLOWED BY AND WITH REIMPORTATION IN THE STATE
    /// </summary>
    public async Task UpdateDefinitiveExportGoodsFollowedByAndWithReimportationInTheState(
        DefinitiveExportGoodsFollowedByAndWithReimportationInTheStateWhereUniqueInput uniqueId,
        DefinitiveExportGoodsFollowedByAndWithReimportationInTheStateUpdateInput updateDto
    )
    {
        var definitiveExportGoodsFollowedByAndWithReimportationInTheState = updateDto.ToModel(
            uniqueId
        );

        _context.Entry(definitiveExportGoodsFollowedByAndWithReimportationInTheState).State =
            EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (
                !_context.DefinitiveExportGoodsFollowedByAndWithReimportationInTheStates.Any(e =>
                    e.Id == definitiveExportGoodsFollowedByAndWithReimportationInTheState.Id
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
