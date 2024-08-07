using Microsoft.EntityFrameworkCore;
using Statement.APIs;
using Statement.APIs.Common;
using Statement.APIs.Dtos;
using Statement.APIs.Errors;
using Statement.APIs.Extensions;
using Statement.Infrastructure;
using Statement.Infrastructure.Models;

namespace Statement.APIs;

public abstract class CancellationsServiceBase : ICancellationsService
{
    protected readonly StatementDbContext _context;

    public CancellationsServiceBase(StatementDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one Cancellation
    /// </summary>
    public async Task<Cancellation> CreateCancellation(CancellationCreateInput createDto)
    {
        var cancellation = new CancellationDbModel
        {
            AttachedFile = createDto.AttachedFile,
            CnclCn = createDto.CnclCn,
            CnclDgcnt = createDto.CnclDgcnt,
            CnclRqstDt = createDto.CnclRqstDt,
            CnclRsnCd = createDto.CnclRsnCd,
            CreatedAt = createDto.CreatedAt,
            DelOn = createDto.DelOn,
            FrstRegstId = createDto.FrstRegstId,
            FrstRgsrDttm = createDto.FrstRgsrDttm,
            LastChgDttm = createDto.LastChgDttm,
            LastChprId = createDto.LastChprId,
            LastOn = createDto.LastOn,
            PrcsSttsCd = createDto.PrcsSttsCd,
            ReffNo = createDto.ReffNo,
            UpdatedAt = createDto.UpdatedAt
        };

        if (createDto.Id != null)
        {
            cancellation.Id = createDto.Id;
        }

        _context.Cancellations.Add(cancellation);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<CancellationDbModel>(cancellation.Id);

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one Cancellation
    /// </summary>
    public async Task DeleteCancellation(CancellationWhereUniqueInput uniqueId)
    {
        var cancellation = await _context.Cancellations.FindAsync(uniqueId.Id);
        if (cancellation == null)
        {
            throw new NotFoundException();
        }

        _context.Cancellations.Remove(cancellation);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many Cancellations
    /// </summary>
    public async Task<List<Cancellation>> Cancellations(CancellationFindManyArgs findManyArgs)
    {
        var cancellations = await _context
            .Cancellations.ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return cancellations.ConvertAll(cancellation => cancellation.ToDto());
    }

    /// <summary>
    /// Meta data about Cancellation records
    /// </summary>
    public async Task<MetadataDto> CancellationsMeta(CancellationFindManyArgs findManyArgs)
    {
        var count = await _context.Cancellations.ApplyWhere(findManyArgs.Where).CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one Cancellation
    /// </summary>
    public async Task<Cancellation> Cancellation(CancellationWhereUniqueInput uniqueId)
    {
        var cancellations = await this.Cancellations(
            new CancellationFindManyArgs { Where = new CancellationWhereInput { Id = uniqueId.Id } }
        );
        var cancellation = cancellations.FirstOrDefault();
        if (cancellation == null)
        {
            throw new NotFoundException();
        }

        return cancellation;
    }

    /// <summary>
    /// Update one Cancellation
    /// </summary>
    public async Task UpdateCancellation(
        CancellationWhereUniqueInput uniqueId,
        CancellationUpdateInput updateDto
    )
    {
        var cancellation = updateDto.ToModel(uniqueId);

        _context.Entry(cancellation).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!_context.Cancellations.Any(e => e.Id == cancellation.Id))
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
