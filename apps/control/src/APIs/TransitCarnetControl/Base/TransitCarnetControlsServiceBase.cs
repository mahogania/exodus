using Control.APIs;
using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Control.APIs.Extensions;
using Control.Infrastructure;
using Control.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Control.APIs;

public abstract class TransitCarnetControlsServiceBase : ITransitCarnetControlsService
{
    protected readonly ControlDbContext _context;

    public TransitCarnetControlsServiceBase(ControlDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one Transit Carnet Control
    /// </summary>
    public async Task<TransitCarnetControl> CreateTransitCarnetControl(
        TransitCarnetControlCreateInput createDto
    )
    {
        var transitCarnetControl = new TransitCarnetControlDbModel
        {
            ArrivalAuthorizationDate = createDto.ArrivalAuthorizationDate,
            ArrivalDate = createDto.ArrivalDate,
            ArticlesInTransit = createDto.ArticlesInTransit,
            AttachmentFileId = createDto.AttachmentFileId,
            AuthorizationDate = createDto.AuthorizationDate,
            CarnetNumber = createDto.CarnetNumber,
            CarnetTypeCode = createDto.CarnetTypeCode,
            CreatedAt = createDto.CreatedAt,
            CustomsSealCode = createDto.CustomsSealCode,
            DeletedOn = createDto.DeletedOn,
            DestinationOffice = createDto.DestinationOffice,
            FirstRecordDateAndTime = createDto.FirstRecordDateAndTime,
            FirstRecorderId = createDto.FirstRecorderId,
            LastModificationDateAndTime = createDto.LastModificationDateAndTime,
            LastModifierId = createDto.LastModifierId,
            ManagementNumberOfCarnet = createDto.ManagementNumberOfCarnet,
            OtherContents = createDto.OtherContents,
            ProcessingStatusCode = createDto.ProcessingStatusCode,
            ReExportationDate = createDto.ReExportationDate,
            ReExportedArticles = createDto.ReExportedArticles,
            ReferenceNo = createDto.ReferenceNo,
            UpdatedAt = createDto.UpdatedAt
        };

        if (createDto.Id != null)
        {
            transitCarnetControl.Id = createDto.Id;
        }

        _context.TransitCarnetControls.Add(transitCarnetControl);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<TransitCarnetControlDbModel>(transitCarnetControl.Id);

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one Transit Carnet Control
    /// </summary>
    public async Task DeleteTransitCarnetControl(TransitCarnetControlWhereUniqueInput uniqueId)
    {
        var transitCarnetControl = await _context.TransitCarnetControls.FindAsync(uniqueId.Id);
        if (transitCarnetControl == null)
        {
            throw new NotFoundException();
        }

        _context.TransitCarnetControls.Remove(transitCarnetControl);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many Transit Carnet Controls
    /// </summary>
    public async Task<List<TransitCarnetControl>> TransitCarnetControls(
        TransitCarnetControlFindManyArgs findManyArgs
    )
    {
        var transitCarnetControls = await _context
            .TransitCarnetControls.ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return transitCarnetControls.ConvertAll(transitCarnetControl =>
            transitCarnetControl.ToDto()
        );
    }

    /// <summary>
    /// Meta data about Transit Carnet Control records
    /// </summary>
    public async Task<MetadataDto> TransitCarnetControlsMeta(
        TransitCarnetControlFindManyArgs findManyArgs
    )
    {
        var count = await _context
            .TransitCarnetControls.ApplyWhere(findManyArgs.Where)
            .CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one Transit Carnet Control
    /// </summary>
    public async Task<TransitCarnetControl> TransitCarnetControl(
        TransitCarnetControlWhereUniqueInput uniqueId
    )
    {
        var transitCarnetControls = await this.TransitCarnetControls(
            new TransitCarnetControlFindManyArgs
            {
                Where = new TransitCarnetControlWhereInput { Id = uniqueId.Id }
            }
        );
        var transitCarnetControl = transitCarnetControls.FirstOrDefault();
        if (transitCarnetControl == null)
        {
            throw new NotFoundException();
        }

        return transitCarnetControl;
    }

    /// <summary>
    /// Update one Transit Carnet Control
    /// </summary>
    public async Task UpdateTransitCarnetControl(
        TransitCarnetControlWhereUniqueInput uniqueId,
        TransitCarnetControlUpdateInput updateDto
    )
    {
        var transitCarnetControl = updateDto.ToModel(uniqueId);

        _context.Entry(transitCarnetControl).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!_context.TransitCarnetControls.Any(e => e.Id == transitCarnetControl.Id))
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
