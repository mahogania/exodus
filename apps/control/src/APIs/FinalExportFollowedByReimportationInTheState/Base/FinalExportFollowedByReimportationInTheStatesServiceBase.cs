using Clre.APIs;
using Clre.APIs.Common;
using Clre.APIs.Dtos;
using Clre.APIs.Errors;
using Clre.APIs.Extensions;
using Clre.Infrastructure;
using Clre.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Clre.APIs;

public abstract class FinalExportFollowedByReimportationInTheStatesServiceBase
    : IFinalExportFollowedByReimportationInTheStatesService
{
    protected readonly ClreDbContext _context;

    public FinalExportFollowedByReimportationInTheStatesServiceBase(ClreDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one FINAL EXPORT FOLLOWED BY REIMPORTATION IN THE STATE
    /// </summary>
    public async Task<FinalExportFollowedByReimportationInTheState> CreateFinalExportFollowedByReimportationInTheState(
        FinalExportFollowedByReimportationInTheStateCreateInput createDto
    )
    {
        var finalExportFollowedByReimportationInTheState =
            new FinalExportFollowedByReimportationInTheStateDbModel
            {
                ApcCode = createDto.ApcCode,
                ContentOfTheRequestReason = createDto.ContentOfTheRequestReason,
                CreatedAt = createDto.CreatedAt,
                CustomsClearanceOfficeForFinalExportFollowedByEt =
                    createDto.CustomsClearanceOfficeForFinalExportFollowedByEt,
                CustomsDeclarationOffice = createDto.CustomsDeclarationOffice,
                DateAndTimeOfFinalModification = createDto.DateAndTimeOfFinalModification,
                DateAndTimeOfFirstRegistration = createDto.DateAndTimeOfFirstRegistration,
                DateOfEtDeclaration = createDto.DateOfEtDeclaration,
                EpcCode = createDto.EpcCode,
                EtDeclarationNumber = createDto.EtDeclarationNumber,
                ExecutionPlaces = createDto.ExecutionPlaces,
                ExpiryDate = createDto.ExpiryDate,
                FinalModifierSId = createDto.FinalModifierSId,
                FirstRegistrantSId = createDto.FirstRegistrantSId,
                LabelApc = createDto.LabelApc,
                LabelEpc = createDto.LabelEpc,
                NumberOfArticles = createDto.NumberOfArticles,
                RectificationFrequency = createDto.RectificationFrequency,
                RegimeRequestNumber = createDto.RegimeRequestNumber,
                SuppressionOn = createDto.SuppressionOn,
                UpdatedAt = createDto.UpdatedAt
            };

        if (createDto.Id != null)
        {
            finalExportFollowedByReimportationInTheState.Id = createDto.Id;
        }

        _context.FinalExportFollowedByReimportationInTheStates.Add(
            finalExportFollowedByReimportationInTheState
        );
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<FinalExportFollowedByReimportationInTheStateDbModel>(
            finalExportFollowedByReimportationInTheState.Id
        );

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one FINAL EXPORT FOLLOWED BY REIMPORTATION IN THE STATE
    /// </summary>
    public async Task DeleteFinalExportFollowedByReimportationInTheState(
        FinalExportFollowedByReimportationInTheStateWhereUniqueInput uniqueId
    )
    {
        var finalExportFollowedByReimportationInTheState =
            await _context.FinalExportFollowedByReimportationInTheStates.FindAsync(uniqueId.Id);
        if (finalExportFollowedByReimportationInTheState == null)
        {
            throw new NotFoundException();
        }

        _context.FinalExportFollowedByReimportationInTheStates.Remove(
            finalExportFollowedByReimportationInTheState
        );
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many FINAL EXPORT FOLLOWED BY REIMPORTATION IN THE STATES
    /// </summary>
    public async Task<
        List<FinalExportFollowedByReimportationInTheState>
    > FinalExportFollowedByReimportationInTheStates(
        FinalExportFollowedByReimportationInTheStateFindManyArgs findManyArgs
    )
    {
        var finalExportFollowedByReimportationInTheStates = await _context
            .FinalExportFollowedByReimportationInTheStates.ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return finalExportFollowedByReimportationInTheStates.ConvertAll(
            finalExportFollowedByReimportationInTheState =>
                finalExportFollowedByReimportationInTheState.ToDto()
        );
    }

    /// <summary>
    /// Meta data about FINAL EXPORT FOLLOWED BY REIMPORTATION IN THE STATE records
    /// </summary>
    public async Task<MetadataDto> FinalExportFollowedByReimportationInTheStatesMeta(
        FinalExportFollowedByReimportationInTheStateFindManyArgs findManyArgs
    )
    {
        var count = await _context
            .FinalExportFollowedByReimportationInTheStates.ApplyWhere(findManyArgs.Where)
            .CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one FINAL EXPORT FOLLOWED BY REIMPORTATION IN THE STATE
    /// </summary>
    public async Task<FinalExportFollowedByReimportationInTheState> FinalExportFollowedByReimportationInTheState(
        FinalExportFollowedByReimportationInTheStateWhereUniqueInput uniqueId
    )
    {
        var finalExportFollowedByReimportationInTheStates =
            await this.FinalExportFollowedByReimportationInTheStates(
                new FinalExportFollowedByReimportationInTheStateFindManyArgs
                {
                    Where = new FinalExportFollowedByReimportationInTheStateWhereInput
                    {
                        Id = uniqueId.Id
                    }
                }
            );
        var finalExportFollowedByReimportationInTheState =
            finalExportFollowedByReimportationInTheStates.FirstOrDefault();
        if (finalExportFollowedByReimportationInTheState == null)
        {
            throw new NotFoundException();
        }

        return finalExportFollowedByReimportationInTheState;
    }

    /// <summary>
    /// Update one FINAL EXPORT FOLLOWED BY REIMPORTATION IN THE STATE
    /// </summary>
    public async Task UpdateFinalExportFollowedByReimportationInTheState(
        FinalExportFollowedByReimportationInTheStateWhereUniqueInput uniqueId,
        FinalExportFollowedByReimportationInTheStateUpdateInput updateDto
    )
    {
        var finalExportFollowedByReimportationInTheState = updateDto.ToModel(uniqueId);

        _context.Entry(finalExportFollowedByReimportationInTheState).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (
                !_context.FinalExportFollowedByReimportationInTheStates.Any(e =>
                    e.Id == finalExportFollowedByReimportationInTheState.Id
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
