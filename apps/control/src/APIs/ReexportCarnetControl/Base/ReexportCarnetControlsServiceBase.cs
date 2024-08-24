using Control.APIs;
using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Control.APIs.Extensions;
using Control.Infrastructure;
using Control.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Control.APIs;

public abstract class ReexportCarnetControlsServiceBase : IReexportCarnetControlsService
{
    protected readonly ControlDbContext _context;

    public ReexportCarnetControlsServiceBase(ControlDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one Reexport Carnet Control
    /// </summary>
    public async Task<ReexportCarnetControl> CreateReexportCarnetControl(
        ReexportCarnetControlCreateInput createDto
    )
    {
        var reexportCarnetControl = new ReexportCarnetControlDbModel
        {
            ActionsAgainstArticlesThatCannotBeReexported_1 =
                createDto.ActionsAgainstArticlesThatCannotBeReexported_1,
            ActionsAgainstArticlesThatCannotBeReexported_2 =
                createDto.ActionsAgainstArticlesThatCannotBeReexported_2,
            AttachmentFileId = createDto.AttachmentFileId,
            AuthorizationDate = createDto.AuthorizationDate,
            CarnetNumber = createDto.CarnetNumber,
            CarnetTypeCode = createDto.CarnetTypeCode,
            CreatedAt = createDto.CreatedAt,
            DeletedOn = createDto.DeletedOn,
            DestinationOffice = createDto.DestinationOffice,
            FirstRecordDateAndTime = createDto.FirstRecordDateAndTime,
            FirstRecorderId = createDto.FirstRecorderId,
            LastModificationDateAndTime = createDto.LastModificationDateAndTime,
            LastModifierId = createDto.LastModifierId,
            ManagementNumberOfCarnet = createDto.ManagementNumberOfCarnet,
            OtherContents = createDto.OtherContents,
            ProcessingStatusCode = createDto.ProcessingStatusCode,
            ReexportedArticles = createDto.ReexportedArticles,
            ReferenceNo = createDto.ReferenceNo,
            UpdatedAt = createDto.UpdatedAt
        };

        if (createDto.Id != null)
        {
            reexportCarnetControl.Id = createDto.Id;
        }

        _context.ReexportCarnetControls.Add(reexportCarnetControl);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<ReexportCarnetControlDbModel>(
            reexportCarnetControl.Id
        );

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one Reexport Carnet Control
    /// </summary>
    public async Task DeleteReexportCarnetControl(ReexportCarnetControlWhereUniqueInput uniqueId)
    {
        var reexportCarnetControl = await _context.ReexportCarnetControls.FindAsync(uniqueId.Id);
        if (reexportCarnetControl == null)
        {
            throw new NotFoundException();
        }

        _context.ReexportCarnetControls.Remove(reexportCarnetControl);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many Reexport Carnet Controls
    /// </summary>
    public async Task<List<ReexportCarnetControl>> ReexportCarnetControls(
        ReexportCarnetControlFindManyArgs findManyArgs
    )
    {
        var reexportCarnetControls = await _context
            .ReexportCarnetControls.ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return reexportCarnetControls.ConvertAll(reexportCarnetControl =>
            reexportCarnetControl.ToDto()
        );
    }

    /// <summary>
    /// Meta data about Reexport Carnet Control records
    /// </summary>
    public async Task<MetadataDto> ReexportCarnetControlsMeta(
        ReexportCarnetControlFindManyArgs findManyArgs
    )
    {
        var count = await _context
            .ReexportCarnetControls.ApplyWhere(findManyArgs.Where)
            .CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one Reexport Carnet Control
    /// </summary>
    public async Task<ReexportCarnetControl> ReexportCarnetControl(
        ReexportCarnetControlWhereUniqueInput uniqueId
    )
    {
        var reexportCarnetControls = await this.ReexportCarnetControls(
            new ReexportCarnetControlFindManyArgs
            {
                Where = new ReexportCarnetControlWhereInput { Id = uniqueId.Id }
            }
        );
        var reexportCarnetControl = reexportCarnetControls.FirstOrDefault();
        if (reexportCarnetControl == null)
        {
            throw new NotFoundException();
        }

        return reexportCarnetControl;
    }

    /// <summary>
    /// Update one Reexport Carnet Control
    /// </summary>
    public async Task UpdateReexportCarnetControl(
        ReexportCarnetControlWhereUniqueInput uniqueId,
        ReexportCarnetControlUpdateInput updateDto
    )
    {
        var reexportCarnetControl = updateDto.ToModel(uniqueId);

        _context.Entry(reexportCarnetControl).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!_context.ReexportCarnetControls.Any(e => e.Id == reexportCarnetControl.Id))
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
