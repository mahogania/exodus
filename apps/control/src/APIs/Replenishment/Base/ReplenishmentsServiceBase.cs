using Control.APIs;
using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Control.APIs.Extensions;
using Control.Infrastructure;
using Control.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Control.APIs;

public abstract class ReplenishmentsServiceBase : IReplenishmentsService
{
    protected readonly ControlDbContext _context;

    public ReplenishmentsServiceBase(ControlDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one Replenishment
    /// </summary>
    public async Task<Replenishment> CreateReplenishment(ReplenishmentCreateInput createDto)
    {
        var replenishment = new ReplenishmentDbModel
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
            replenishment.Id = createDto.Id;
        }

        _context.Replenishments.Add(replenishment);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<ReplenishmentDbModel>(replenishment.Id);

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one Replenishment
    /// </summary>
    public async Task DeleteReplenishment(ReplenishmentWhereUniqueInput uniqueId)
    {
        var replenishment = await _context.Replenishments.FindAsync(uniqueId.Id);
        if (replenishment == null)
        {
            throw new NotFoundException();
        }

        _context.Replenishments.Remove(replenishment);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many Replenishments
    /// </summary>
    public async Task<List<Replenishment>> Replenishments(ReplenishmentFindManyArgs findManyArgs)
    {
        var replenishments = await _context
            .Replenishments.ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return replenishments.ConvertAll(replenishment => replenishment.ToDto());
    }

    /// <summary>
    /// Meta data about Replenishment records
    /// </summary>
    public async Task<MetadataDto> ReplenishmentsMeta(ReplenishmentFindManyArgs findManyArgs)
    {
        var count = await _context.Replenishments.ApplyWhere(findManyArgs.Where).CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one Replenishment
    /// </summary>
    public async Task<Replenishment> Replenishment(ReplenishmentWhereUniqueInput uniqueId)
    {
        var replenishments = await this.Replenishments(
            new ReplenishmentFindManyArgs
            {
                Where = new ReplenishmentWhereInput { Id = uniqueId.Id }
            }
        );
        var replenishment = replenishments.FirstOrDefault();
        if (replenishment == null)
        {
            throw new NotFoundException();
        }

        return replenishment;
    }

    /// <summary>
    /// Update one Replenishment
    /// </summary>
    public async Task UpdateReplenishment(
        ReplenishmentWhereUniqueInput uniqueId,
        ReplenishmentUpdateInput updateDto
    )
    {
        var replenishment = updateDto.ToModel(uniqueId);

        _context.Entry(replenishment).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!_context.Replenishments.Any(e => e.Id == replenishment.Id))
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
