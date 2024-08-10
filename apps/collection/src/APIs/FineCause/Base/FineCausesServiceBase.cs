using Collection.APIs.Common;
using Collection.APIs.Dtos;
using Collection.APIs.Errors;
using Collection.APIs.Extensions;
using Collection.Infrastructure;
using Collection.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Collection.APIs;

public abstract class FineCausesServiceBase : IFineCausesService
{
    protected readonly CollectionDbContext _context;

    public FineCausesServiceBase(CollectionDbContext context)
    {
        _context = context;
    }

    /// <summary>
    ///     Create one FINE CAUSE
    /// </summary>
    public async Task<FineCause> CreateFineCause(FineCauseCreateInput createDto)
    {
        var fineCause = new FineCauseDbModel
        {
            AlignmentOrder = createDto.AlignmentOrder,
            CappedAmount = createDto.CappedAmount,
            CreatedAt = createDto.CreatedAt,
            DeletionFlag = createDto.DeletionFlag,
            FinalModificationDateAndTime = createDto.FinalModificationDateAndTime,
            FinalModifierId = createDto.FinalModifierId,
            FineAmount = createDto.FineAmount,
            FineTaxCode = createDto.FineTaxCode,
            FirstRegistrantId = createDto.FirstRegistrantId,
            FirstRegistrationDateAndTime = createDto.FirstRegistrationDateAndTime,
            InfractionCode = createDto.InfractionCode,
            MinimumAmount = createDto.MinimumAmount,
            NoticeNumber = createDto.NoticeNumber,
            OperationTypeCode = createDto.OperationTypeCode,
            UpdatedAt = createDto.UpdatedAt
        };

        if (createDto.Id != null) fineCause.Id = createDto.Id;

        _context.FineCauses.Add(fineCause);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<FineCauseDbModel>(fineCause.Id);

        if (result == null) throw new NotFoundException();

        return result.ToDto();
    }

    /// <summary>
    ///     Delete one FINE CAUSE
    /// </summary>
    public async Task DeleteFineCause(FineCauseWhereUniqueInput uniqueId)
    {
        var fineCause = await _context.FineCauses.FindAsync(uniqueId.Id);
        if (fineCause == null) throw new NotFoundException();

        _context.FineCauses.Remove(fineCause);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    ///     Find many FINE CAUSES
    /// </summary>
    public async Task<List<FineCause>> FineCauses(FineCauseFindManyArgs findManyArgs)
    {
        var fineCauses = await _context
            .FineCauses.ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return fineCauses.ConvertAll(fineCause => fineCause.ToDto());
    }

    /// <summary>
    ///     Meta data about FINE CAUSE records
    /// </summary>
    public async Task<MetadataDto> FineCausesMeta(FineCauseFindManyArgs findManyArgs)
    {
        var count = await _context.FineCauses.ApplyWhere(findManyArgs.Where).CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    ///     Get one FINE CAUSE
    /// </summary>
    public async Task<FineCause> FineCause(FineCauseWhereUniqueInput uniqueId)
    {
        var fineCauses = await FineCauses(
            new FineCauseFindManyArgs { Where = new FineCauseWhereInput { Id = uniqueId.Id } }
        );
        var fineCause = fineCauses.FirstOrDefault();
        if (fineCause == null) throw new NotFoundException();

        return fineCause;
    }

    /// <summary>
    ///     Update one FINE CAUSE
    /// </summary>
    public async Task UpdateFineCause(
        FineCauseWhereUniqueInput uniqueId,
        FineCauseUpdateInput updateDto
    )
    {
        var fineCause = updateDto.ToModel(uniqueId);

        _context.Entry(fineCause).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!_context.FineCauses.Any(e => e.Id == fineCause.Id))
                throw new NotFoundException();
            throw;
        }
    }
}
