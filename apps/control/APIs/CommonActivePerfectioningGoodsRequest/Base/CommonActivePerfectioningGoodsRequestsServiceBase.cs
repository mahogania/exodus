using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Control.APIs.Extensions;
using Control.Infrastructure;
using Control.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Control.APIs;

public abstract class CommonActivePerfectioningGoodsRequestsServiceBase
    : ICommonActivePerfectioningGoodsRequestsService
{
    protected readonly ControlDbContext _context;

    public CommonActivePerfectioningGoodsRequestsServiceBase(ControlDbContext context)
    {
        _context = context;
    }

    /// <summary>
    ///     Create one COMMON ACTIVE PERFECTIONING GOODS REQUEST
    /// </summary>
    public async Task<CommonActivePerfectioningGoodsRequest> CreateCommonActivePerfectioningGoodsRequest(
        CommonActivePerfectioningGoodsRequestCreateInput createDto
    )
    {
        var commonActivePerfectioningGoodsRequest = new CommonActivePerfectioningGoodsRequestDbModel
        {
            CreatedAt = createDto.CreatedAt,
            UpdatedAt = createDto.UpdatedAt
        };

        if (createDto.Id != null) commonActivePerfectioningGoodsRequest.Id = createDto.Id;

        _context.CommonActivePerfectioningGoodsRequests.Add(commonActivePerfectioningGoodsRequest);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<CommonActivePerfectioningGoodsRequestDbModel>(
            commonActivePerfectioningGoodsRequest.Id
        );

        if (result == null) throw new NotFoundException();

        return result.ToDto();
    }

    /// <summary>
    ///     Delete one COMMON ACTIVE PERFECTIONING GOODS REQUEST
    /// </summary>
    public async Task DeleteCommonActivePerfectioningGoodsRequest(
        CommonActivePerfectioningGoodsRequestWhereUniqueInput uniqueId
    )
    {
        var commonActivePerfectioningGoodsRequest =
            await _context.CommonActivePerfectioningGoodsRequests.FindAsync(uniqueId.Id);
        if (commonActivePerfectioningGoodsRequest == null) throw new NotFoundException();

        _context.CommonActivePerfectioningGoodsRequests.Remove(
            commonActivePerfectioningGoodsRequest
        );
        await _context.SaveChangesAsync();
    }

    /// <summary>
    ///     Find many COMMON ACTIVE PERFECTIONING GOODS REQUESTS
    /// </summary>
    public async Task<
        List<CommonActivePerfectioningGoodsRequest>
    > CommonActivePerfectioningGoodsRequests(
        CommonActivePerfectioningGoodsRequestFindManyArgs findManyArgs
    )
    {
        var commonActivePerfectioningGoodsRequests = await _context
            .CommonActivePerfectioningGoodsRequests.ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return commonActivePerfectioningGoodsRequests.ConvertAll(
            commonActivePerfectioningGoodsRequest => commonActivePerfectioningGoodsRequest.ToDto()
        );
    }

    /// <summary>
    ///     Meta data about COMMON ACTIVE PERFECTIONING GOODS REQUEST records
    /// </summary>
    public async Task<MetadataDto> CommonActivePerfectioningGoodsRequestsMeta(
        CommonActivePerfectioningGoodsRequestFindManyArgs findManyArgs
    )
    {
        var count = await _context
            .CommonActivePerfectioningGoodsRequests.ApplyWhere(findManyArgs.Where)
            .CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    ///     Get one COMMON ACTIVE PERFECTIONING GOODS REQUEST
    /// </summary>
    public async Task<CommonActivePerfectioningGoodsRequest> CommonActivePerfectioningGoodsRequest(
        CommonActivePerfectioningGoodsRequestWhereUniqueInput uniqueId
    )
    {
        var commonActivePerfectioningGoodsRequests =
            await CommonActivePerfectioningGoodsRequests(
                new CommonActivePerfectioningGoodsRequestFindManyArgs
                {
                    Where = new CommonActivePerfectioningGoodsRequestWhereInput { Id = uniqueId.Id }
                }
            );
        var commonActivePerfectioningGoodsRequest =
            commonActivePerfectioningGoodsRequests.FirstOrDefault();
        if (commonActivePerfectioningGoodsRequest == null) throw new NotFoundException();

        return commonActivePerfectioningGoodsRequest;
    }

    /// <summary>
    ///     Update one COMMON ACTIVE PERFECTIONING GOODS REQUEST
    /// </summary>
    public async Task UpdateCommonActivePerfectioningGoodsRequest(
        CommonActivePerfectioningGoodsRequestWhereUniqueInput uniqueId,
        CommonActivePerfectioningGoodsRequestUpdateInput updateDto
    )
    {
        var commonActivePerfectioningGoodsRequest = updateDto.ToModel(uniqueId);

        _context.Entry(commonActivePerfectioningGoodsRequest).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (
                !_context.CommonActivePerfectioningGoodsRequests.Any(e =>
                    e.Id == commonActivePerfectioningGoodsRequest.Id
                )
            )
                throw new NotFoundException();
            throw;
        }
    }
}
