using Collection.APIs;
using Collection.APIs.Common;
using Collection.APIs.Dtos;
using Collection.APIs.Errors;
using Collection.APIs.Extensions;
using Collection.Infrastructure;
using Collection.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Collection.APIs;

public abstract class CausesServiceBase : ICausesService
{
    protected readonly CollectionDbContext _context;

    public CausesServiceBase(CollectionDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one CAUSE
    /// </summary>
    public async Task<Cause> CreateCause(CauseCreateInput createDto)
    {
        var cause = new CauseDbModel
        {
            AlignmentOrder = createDto.AlignmentOrder,
            AmountActuallyPaid = createDto.AmountActuallyPaid,
            AmountOfOtherChargeableFees = createDto.AmountOfOtherChargeableFees,
            CreatedAt = createDto.CreatedAt,
            DeletionOn = createDto.DeletionOn,
            FinalModificationDateAndTime = createDto.FinalModificationDateAndTime,
            FinalModifierId = createDto.FinalModifierId,
            FirstRegistrantId = createDto.FirstRegistrantId,
            FirstRegistrationDateAndTime = createDto.FirstRegistrationDateAndTime,
            NoticeNo = createDto.NoticeNo,
            OtherChargeableFeesCode = createDto.OtherChargeableFeesCode,
            OtherChargeableFeesTaxCode = createDto.OtherChargeableFeesTaxCode,
            UpdatedAt = createDto.UpdatedAt
        };

        if (createDto.Id != null)
        {
            cause.Id = createDto.Id;
        }

        _context.Causes.Add(cause);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<CauseDbModel>(cause.Id);

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one CAUSE
    /// </summary>
    public async Task DeleteCause(CauseWhereUniqueInput uniqueId)
    {
        var cause = await _context.Causes.FindAsync(uniqueId.Id);
        if (cause == null)
        {
            throw new NotFoundException();
        }

        _context.Causes.Remove(cause);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many CAUSES
    /// </summary>
    public async Task<List<Cause>> Causes(CauseFindManyArgs findManyArgs)
    {
        var causes = await _context
            .Causes.ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return causes.ConvertAll(cause => cause.ToDto());
    }

    /// <summary>
    /// Meta data about CAUSE records
    /// </summary>
    public async Task<MetadataDto> CausesMeta(CauseFindManyArgs findManyArgs)
    {
        var count = await _context.Causes.ApplyWhere(findManyArgs.Where).CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one CAUSE
    /// </summary>
    public async Task<Cause> Cause(CauseWhereUniqueInput uniqueId)
    {
        var causes = await this.Causes(
            new CauseFindManyArgs { Where = new CauseWhereInput { Id = uniqueId.Id } }
        );
        var cause = causes.FirstOrDefault();
        if (cause == null)
        {
            throw new NotFoundException();
        }

        return cause;
    }

    /// <summary>
    /// Update one CAUSE
    /// </summary>
    public async Task UpdateCause(CauseWhereUniqueInput uniqueId, CauseUpdateInput updateDto)
    {
        var cause = updateDto.ToModel(uniqueId);

        _context.Entry(cause).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!_context.Causes.Any(e => e.Id == cause.Id))
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
