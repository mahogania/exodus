using Control.APIs;
using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Control.APIs.Extensions;
using Control.Infrastructure;
using Control.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Control.APIs;

public abstract class CommonActiveGoodsRequestsServiceBase : ICommonActiveGoodsRequestsService
{
    protected readonly ControlDbContext _context;

    public CommonActiveGoodsRequestsServiceBase(ControlDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one Common Active Goods Request
    /// </summary>
    public async Task<CommonActiveGoodsRequest> CreateCommonActiveGoodsRequest(
        CommonActiveGoodsRequestCreateInput createDto
    )
    {
        var commonActiveGoodsRequest = new CommonActiveGoodsRequestDbModel
        {
            CreatedAt = createDto.CreatedAt,
            UpdatedAt = createDto.UpdatedAt
        };

        if (createDto.Id != null)
        {
            commonActiveGoodsRequest.Id = createDto.Id;
        }
        if (createDto.Details != null)
        {
            commonActiveGoodsRequest.Details = await _context
                .DetailOfActiveGoodsItems.Where(detailOfActiveGoods =>
                    createDto.Details.Select(t => t.Id).Contains(detailOfActiveGoods.Id)
                )
                .ToListAsync();
        }

        if (createDto.Journal != null)
        {
            commonActiveGoodsRequest.Journal = await _context
                .Journals.Where(journal => createDto.Journal.Id == journal.Id)
                .FirstOrDefaultAsync();
        }

        _context.CommonActiveGoodsRequests.Add(commonActiveGoodsRequest);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<CommonActiveGoodsRequestDbModel>(
            commonActiveGoodsRequest.Id
        );

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one Common Active Goods Request
    /// </summary>
    public async Task DeleteCommonActiveGoodsRequest(
        CommonActiveGoodsRequestWhereUniqueInput uniqueId
    )
    {
        var commonActiveGoodsRequest = await _context.CommonActiveGoodsRequests.FindAsync(
            uniqueId.Id
        );
        if (commonActiveGoodsRequest == null)
        {
            throw new NotFoundException();
        }

        _context.CommonActiveGoodsRequests.Remove(commonActiveGoodsRequest);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many COMMON ACTIVE PERFECTIONING GOODS REQUESTS
    /// </summary>
    public async Task<List<CommonActiveGoodsRequest>> CommonActiveGoodsRequests(
        CommonActiveGoodsRequestFindManyArgs findManyArgs
    )
    {
        var commonActiveGoodsRequests = await _context
            .CommonActiveGoodsRequests.Include(x => x.Details)
            .Include(x => x.Journal)
            .ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return commonActiveGoodsRequests.ConvertAll(commonActiveGoodsRequest =>
            commonActiveGoodsRequest.ToDto()
        );
    }

    /// <summary>
    /// Meta data about Common Active Goods Request records
    /// </summary>
    public async Task<MetadataDto> CommonActiveGoodsRequestsMeta(
        CommonActiveGoodsRequestFindManyArgs findManyArgs
    )
    {
        var count = await _context
            .CommonActiveGoodsRequests.ApplyWhere(findManyArgs.Where)
            .CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one Common Active Goods Request
    /// </summary>
    public async Task<CommonActiveGoodsRequest> CommonActiveGoodsRequest(
        CommonActiveGoodsRequestWhereUniqueInput uniqueId
    )
    {
        var commonActiveGoodsRequests = await this.CommonActiveGoodsRequests(
            new CommonActiveGoodsRequestFindManyArgs
            {
                Where = new CommonActiveGoodsRequestWhereInput { Id = uniqueId.Id }
            }
        );
        var commonActiveGoodsRequest = commonActiveGoodsRequests.FirstOrDefault();
        if (commonActiveGoodsRequest == null)
        {
            throw new NotFoundException();
        }

        return commonActiveGoodsRequest;
    }

    /// <summary>
    /// Update one Common Active Goods Request
    /// </summary>
    public async Task UpdateCommonActiveGoodsRequest(
        CommonActiveGoodsRequestWhereUniqueInput uniqueId,
        CommonActiveGoodsRequestUpdateInput updateDto
    )
    {
        var commonActiveGoodsRequest = updateDto.ToModel(uniqueId);

        if (updateDto.Details != null)
        {
            commonActiveGoodsRequest.Details = await _context
                .DetailOfActiveGoodsItems.Where(detailOfActiveGoods =>
                    updateDto.Details.Select(t => t).Contains(detailOfActiveGoods.Id)
                )
                .ToListAsync();
        }

        _context.Entry(commonActiveGoodsRequest).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!_context.CommonActiveGoodsRequests.Any(e => e.Id == commonActiveGoodsRequest.Id))
            {
                throw new NotFoundException();
            }
            else
            {
                throw;
            }
        }
    }

    /// <summary>
    /// Get a Journal record for Common Active Goods Request
    /// </summary>
    public async Task<Journal> GetJournal(CommonActiveGoodsRequestWhereUniqueInput uniqueId)
    {
        var commonActiveGoodsRequest = await _context
            .CommonActiveGoodsRequests.Where(commonActiveGoodsRequest =>
                commonActiveGoodsRequest.Id == uniqueId.Id
            )
            .Include(commonActiveGoodsRequest => commonActiveGoodsRequest.Journal)
            .FirstOrDefaultAsync();
        if (commonActiveGoodsRequest == null)
        {
            throw new NotFoundException();
        }
        return commonActiveGoodsRequest.Journal.ToDto();
    }
}
