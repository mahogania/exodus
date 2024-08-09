using Clre.APIs;
using Clre.APIs.Common;
using Clre.APIs.Dtos;
using Clre.APIs.Errors;
using Clre.APIs.Extensions;
using Clre.Infrastructure;
using Clre.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Clre.APIs;

public abstract class ReplenishmentInDutyFreesServiceBase : IReplenishmentInDutyFreesService
{
    protected readonly ClreDbContext _context;

    public ReplenishmentInDutyFreesServiceBase(ClreDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one REPLENISHMENT IN DUTY-FREE
    /// </summary>
    public async Task<ReplenishmentInDutyFree> CreateReplenishmentInDutyFree(
        ReplenishmentInDutyFreeCreateInput createDto
    )
    {
        var replenishmentInDutyFree = new ReplenishmentInDutyFreeDbModel
        {
            ApcCode = createDto.ApcCode,
            CreatedAt = createDto.CreatedAt,
            CustomsClearanceOfficeForReplenishmentInDutyFree =
                createDto.CustomsClearanceOfficeForReplenishmentInDutyFree,
            CustomsClearanceOfficeOfDeclaration = createDto.CustomsClearanceOfficeOfDeclaration,
            DateAndTimeOfFinalModification = createDto.DateAndTimeOfFinalModification,
            DateAndTimeOfFirstRegistration = createDto.DateAndTimeOfFirstRegistration,
            DateOfDau = createDto.DateOfDau,
            DeclarationStatus = createDto.DeclarationStatus,
            EpcCode = createDto.EpcCode,
            EpcLabel = createDto.EpcLabel,
            ExportDeclarationNumber = createDto.ExportDeclarationNumber,
            FinalModifierSId = createDto.FinalModifierSId,
            FirstRegistrantSId = createDto.FirstRegistrantSId,
            RectificationFrequency = createDto.RectificationFrequency,
            RegimeRequestNumber = createDto.RegimeRequestNumber,
            RequestTypeCode = createDto.RequestTypeCode,
            RequestedEndDate = createDto.RequestedEndDate,
            RequestedStartDate = createDto.RequestedStartDate,
            SuppressionOn = createDto.SuppressionOn,
            UpdatedAt = createDto.UpdatedAt
        };

        if (createDto.Id != null)
        {
            replenishmentInDutyFree.Id = createDto.Id;
        }

        _context.ReplenishmentInDutyFrees.Add(replenishmentInDutyFree);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<ReplenishmentInDutyFreeDbModel>(
            replenishmentInDutyFree.Id
        );

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one REPLENISHMENT IN DUTY-FREE
    /// </summary>
    public async Task DeleteReplenishmentInDutyFree(
        ReplenishmentInDutyFreeWhereUniqueInput uniqueId
    )
    {
        var replenishmentInDutyFree = await _context.ReplenishmentInDutyFrees.FindAsync(
            uniqueId.Id
        );
        if (replenishmentInDutyFree == null)
        {
            throw new NotFoundException();
        }

        _context.ReplenishmentInDutyFrees.Remove(replenishmentInDutyFree);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many REPLENISHMENT IN DUTY-FREES
    /// </summary>
    public async Task<List<ReplenishmentInDutyFree>> ReplenishmentInDutyFrees(
        ReplenishmentInDutyFreeFindManyArgs findManyArgs
    )
    {
        var replenishmentInDutyFrees = await _context
            .ReplenishmentInDutyFrees.ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return replenishmentInDutyFrees.ConvertAll(replenishmentInDutyFree =>
            replenishmentInDutyFree.ToDto()
        );
    }

    /// <summary>
    /// Meta data about REPLENISHMENT IN DUTY-FREE records
    /// </summary>
    public async Task<MetadataDto> ReplenishmentInDutyFreesMeta(
        ReplenishmentInDutyFreeFindManyArgs findManyArgs
    )
    {
        var count = await _context
            .ReplenishmentInDutyFrees.ApplyWhere(findManyArgs.Where)
            .CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one REPLENISHMENT IN DUTY-FREE
    /// </summary>
    public async Task<ReplenishmentInDutyFree> ReplenishmentInDutyFree(
        ReplenishmentInDutyFreeWhereUniqueInput uniqueId
    )
    {
        var replenishmentInDutyFrees = await this.ReplenishmentInDutyFrees(
            new ReplenishmentInDutyFreeFindManyArgs
            {
                Where = new ReplenishmentInDutyFreeWhereInput { Id = uniqueId.Id }
            }
        );
        var replenishmentInDutyFree = replenishmentInDutyFrees.FirstOrDefault();
        if (replenishmentInDutyFree == null)
        {
            throw new NotFoundException();
        }

        return replenishmentInDutyFree;
    }

    /// <summary>
    /// Update one REPLENISHMENT IN DUTY-FREE
    /// </summary>
    public async Task UpdateReplenishmentInDutyFree(
        ReplenishmentInDutyFreeWhereUniqueInput uniqueId,
        ReplenishmentInDutyFreeUpdateInput updateDto
    )
    {
        var replenishmentInDutyFree = updateDto.ToModel(uniqueId);

        _context.Entry(replenishmentInDutyFree).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!_context.ReplenishmentInDutyFrees.Any(e => e.Id == replenishmentInDutyFree.Id))
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
