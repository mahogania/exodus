using Control.APIs;
using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Control.APIs.Extensions;
using Control.Infrastructure;
using Control.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Control.APIs;

public abstract class ArticleCarnetRequestsServiceBase : IArticleCarnetRequestsService
{
    protected readonly ControlDbContext _context;

    public ArticleCarnetRequestsServiceBase(ControlDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one Article Carnet Request
    /// </summary>
    public async Task<ArticleCarnetRequest> CreateArticleCarnetRequest(
        ArticleCarnetRequestCreateInput createDto
    )
    {
        var articleCarnetRequest = new ArticleCarnetRequestDbModel
        {
            ArticleNumber = createDto.ArticleNumber,
            CarnetNumber = createDto.CarnetNumber,
            CarnetTypeCode = createDto.CarnetTypeCode,
            CreatedAt = createDto.CreatedAt,
            ManagementNumberOfCarnet = createDto.ManagementNumberOfCarnet,
            OperationTypeCode = createDto.OperationTypeCode,
            ReferenceNo = createDto.ReferenceNo,
            UpdatedAt = createDto.UpdatedAt
        };

        if (createDto.Id != null)
        {
            articleCarnetRequest.Id = createDto.Id;
        }
        if (createDto.ArticleCarnetControl != null)
        {
            articleCarnetRequest.ArticleCarnetControl = await _context
                .ArticleCarnetControls.Where(articleCarnetControl =>
                    createDto.ArticleCarnetControl.Id == articleCarnetControl.Id
                )
                .FirstOrDefaultAsync();
        }

        _context.ArticleCarnetRequests.Add(articleCarnetRequest);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<ArticleCarnetRequestDbModel>(articleCarnetRequest.Id);

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one Article Carnet Request
    /// </summary>
    public async Task DeleteArticleCarnetRequest(ArticleCarnetRequestWhereUniqueInput uniqueId)
    {
        var articleCarnetRequest = await _context.ArticleCarnetRequests.FindAsync(uniqueId.Id);
        if (articleCarnetRequest == null)
        {
            throw new NotFoundException();
        }

        _context.ArticleCarnetRequests.Remove(articleCarnetRequest);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many Article Carnet Requests
    /// </summary>
    public async Task<List<ArticleCarnetRequest>> ArticleCarnetRequests(
        ArticleCarnetRequestFindManyArgs findManyArgs
    )
    {
        var articleCarnetRequests = await _context
            .ArticleCarnetRequests.Include(x => x.ArticleCarnetControl)
            .ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return articleCarnetRequests.ConvertAll(articleCarnetRequest =>
            articleCarnetRequest.ToDto()
        );
    }

    /// <summary>
    /// Meta data about Article Carnet Request records
    /// </summary>
    public async Task<MetadataDto> ArticleCarnetRequestsMeta(
        ArticleCarnetRequestFindManyArgs findManyArgs
    )
    {
        var count = await _context
            .ArticleCarnetRequests.ApplyWhere(findManyArgs.Where)
            .CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one Article Carnet Request
    /// </summary>
    public async Task<ArticleCarnetRequest> ArticleCarnetRequest(
        ArticleCarnetRequestWhereUniqueInput uniqueId
    )
    {
        var articleCarnetRequests = await this.ArticleCarnetRequests(
            new ArticleCarnetRequestFindManyArgs
            {
                Where = new ArticleCarnetRequestWhereInput { Id = uniqueId.Id }
            }
        );
        var articleCarnetRequest = articleCarnetRequests.FirstOrDefault();
        if (articleCarnetRequest == null)
        {
            throw new NotFoundException();
        }

        return articleCarnetRequest;
    }

    /// <summary>
    /// Update one Article Carnet Request
    /// </summary>
    public async Task UpdateArticleCarnetRequest(
        ArticleCarnetRequestWhereUniqueInput uniqueId,
        ArticleCarnetRequestUpdateInput updateDto
    )
    {
        var articleCarnetRequest = updateDto.ToModel(uniqueId);

        _context.Entry(articleCarnetRequest).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!_context.ArticleCarnetRequests.Any(e => e.Id == articleCarnetRequest.Id))
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
    /// Get a Article Carnet Control record for Article Carnet Request
    /// </summary>
    public async Task<ArticleCarnetControl> GetArticleCarnetControl(
        ArticleCarnetRequestWhereUniqueInput uniqueId
    )
    {
        var articleCarnetRequest = await _context
            .ArticleCarnetRequests.Where(articleCarnetRequest =>
                articleCarnetRequest.Id == uniqueId.Id
            )
            .Include(articleCarnetRequest => articleCarnetRequest.ArticleCarnetControl)
            .FirstOrDefaultAsync();
        if (articleCarnetRequest == null)
        {
            throw new NotFoundException();
        }
        return articleCarnetRequest.ArticleCarnetControl.ToDto();
    }
}
