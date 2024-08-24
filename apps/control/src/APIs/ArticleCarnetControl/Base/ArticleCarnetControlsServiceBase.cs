using Control.APIs;
using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Control.APIs.Extensions;
using Control.Infrastructure;
using Control.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Control.APIs;

public abstract class ArticleCarnetControlsServiceBase : IArticleCarnetControlsService
{
    protected readonly ControlDbContext _context;

    public ArticleCarnetControlsServiceBase(ControlDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one Article Carnet Control
    /// </summary>
    public async Task<ArticleCarnetControl> CreateArticleCarnetControl(
        ArticleCarnetControlCreateInput createDto
    )
    {
        var articleCarnetControl = new ArticleCarnetControlDbModel
        {
            ArticleNumber = createDto.ArticleNumber,
            AttachmentFileId = createDto.AttachmentFileId,
            AuthorizationDate = createDto.AuthorizationDate,
            CarnetNumber = createDto.CarnetNumber,
            CarnetTypeCode = createDto.CarnetTypeCode,
            CreatedAt = createDto.CreatedAt,
            CustomsNote = createDto.CustomsNote,
            DeletedOn = createDto.DeletedOn,
            FirstRecordDateAndTime = createDto.FirstRecordDateAndTime,
            FirstRecorderId = createDto.FirstRecorderId,
            LastModificationDateAndTime = createDto.LastModificationDateAndTime,
            LastModifierId = createDto.LastModifierId,
            ManagementNumberOfCarnet = createDto.ManagementNumberOfCarnet,
            OperationTypeCode = createDto.OperationTypeCode,
            ProcessingStatusCode = createDto.ProcessingStatusCode,
            ReferenceNo = createDto.ReferenceNo,
            UpdatedAt = createDto.UpdatedAt
        };

        if (createDto.Id != null)
        {
            articleCarnetControl.Id = createDto.Id;
        }

        _context.ArticleCarnetControls.Add(articleCarnetControl);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<ArticleCarnetControlDbModel>(articleCarnetControl.Id);

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one Article Carnet Control
    /// </summary>
    public async Task DeleteArticleCarnetControl(ArticleCarnetControlWhereUniqueInput uniqueId)
    {
        var articleCarnetControl = await _context.ArticleCarnetControls.FindAsync(uniqueId.Id);
        if (articleCarnetControl == null)
        {
            throw new NotFoundException();
        }

        _context.ArticleCarnetControls.Remove(articleCarnetControl);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many Article Carnet Controls
    /// </summary>
    public async Task<List<ArticleCarnetControl>> ArticleCarnetControls(
        ArticleCarnetControlFindManyArgs findManyArgs
    )
    {
        var articleCarnetControls = await _context
            .ArticleCarnetControls.ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return articleCarnetControls.ConvertAll(articleCarnetControl =>
            articleCarnetControl.ToDto()
        );
    }

    /// <summary>
    /// Meta data about Article Carnet Control records
    /// </summary>
    public async Task<MetadataDto> ArticleCarnetControlsMeta(
        ArticleCarnetControlFindManyArgs findManyArgs
    )
    {
        var count = await _context
            .ArticleCarnetControls.ApplyWhere(findManyArgs.Where)
            .CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one Article Carnet Control
    /// </summary>
    public async Task<ArticleCarnetControl> ArticleCarnetControl(
        ArticleCarnetControlWhereUniqueInput uniqueId
    )
    {
        var articleCarnetControls = await this.ArticleCarnetControls(
            new ArticleCarnetControlFindManyArgs
            {
                Where = new ArticleCarnetControlWhereInput { Id = uniqueId.Id }
            }
        );
        var articleCarnetControl = articleCarnetControls.FirstOrDefault();
        if (articleCarnetControl == null)
        {
            throw new NotFoundException();
        }

        return articleCarnetControl;
    }

    /// <summary>
    /// Update one Article Carnet Control
    /// </summary>
    public async Task UpdateArticleCarnetControl(
        ArticleCarnetControlWhereUniqueInput uniqueId,
        ArticleCarnetControlUpdateInput updateDto
    )
    {
        var articleCarnetControl = updateDto.ToModel(uniqueId);

        _context.Entry(articleCarnetControl).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!_context.ArticleCarnetControls.Any(e => e.Id == articleCarnetControl.Id))
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
