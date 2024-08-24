using Control.APIs;
using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Control.APIs.Extensions;
using Control.Infrastructure;
using Control.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Control.APIs;

public abstract class ExtendedPeriodCarnetControlsServiceBase : IExtendedPeriodCarnetControlsService
{
    protected readonly ControlDbContext _context;

    public ExtendedPeriodCarnetControlsServiceBase(ControlDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one Extended Period Carnet Control
    /// </summary>
    public async Task<ExtendedPeriodCarnetControl> CreateExtendedPeriodCarnetControl(
        ExtendedPeriodCarnetControlCreateInput createDto
    )
    {
        var extendedPeriodCarnetControl = new ExtendedPeriodCarnetControlDbModel
        {
            AttachmentFileId = createDto.AttachmentFileId,
            AuthorizationDate = createDto.AuthorizationDate,
            CarnetNumber = createDto.CarnetNumber,
            CarnetTypeCode = createDto.CarnetTypeCode,
            CreatedAt = createDto.CreatedAt,
            DeletedOn = createDto.DeletedOn,
            FirstRecordDateAndTime = createDto.FirstRecordDateAndTime,
            FirstRecorderId = createDto.FirstRecorderId,
            LastModificationDateAndTime = createDto.LastModificationDateAndTime,
            LastModifierId = createDto.LastModifierId,
            ManagementNumberOfCarnet = createDto.ManagementNumberOfCarnet,
            ProcessingStatusCode = createDto.ProcessingStatusCode,
            SequenceNumber = createDto.SequenceNumber,
            UpdatedAt = createDto.UpdatedAt,
            VerificationResultContent = createDto.VerificationResultContent
        };

        if (createDto.Id != null)
        {
            extendedPeriodCarnetControl.Id = createDto.Id;
        }
        if (createDto.ExtendedPeriodCarnetRequest != null)
        {
            extendedPeriodCarnetControl.ExtendedPeriodCarnetRequest = await _context
                .ExtendedPeriodCarnetRequests.Where(extendedPeriodCarnetRequest =>
                    createDto.ExtendedPeriodCarnetRequest.Id == extendedPeriodCarnetRequest.Id
                )
                .FirstOrDefaultAsync();
        }

        _context.ExtendedPeriodCarnetControls.Add(extendedPeriodCarnetControl);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<ExtendedPeriodCarnetControlDbModel>(
            extendedPeriodCarnetControl.Id
        );

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one Extended Period Carnet Control
    /// </summary>
    public async Task DeleteExtendedPeriodCarnetControl(
        ExtendedPeriodCarnetControlWhereUniqueInput uniqueId
    )
    {
        var extendedPeriodCarnetControl = await _context.ExtendedPeriodCarnetControls.FindAsync(
            uniqueId.Id
        );
        if (extendedPeriodCarnetControl == null)
        {
            throw new NotFoundException();
        }

        _context.ExtendedPeriodCarnetControls.Remove(extendedPeriodCarnetControl);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many Extended Period Carnet Controls
    /// </summary>
    public async Task<List<ExtendedPeriodCarnetControl>> ExtendedPeriodCarnetControls(
        ExtendedPeriodCarnetControlFindManyArgs findManyArgs
    )
    {
        var extendedPeriodCarnetControls = await _context
            .ExtendedPeriodCarnetControls.Include(x => x.ExtendedPeriodCarnetRequest)
            .ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return extendedPeriodCarnetControls.ConvertAll(extendedPeriodCarnetControl =>
            extendedPeriodCarnetControl.ToDto()
        );
    }

    /// <summary>
    /// Meta data about Extended Period Carnet Control records
    /// </summary>
    public async Task<MetadataDto> ExtendedPeriodCarnetControlsMeta(
        ExtendedPeriodCarnetControlFindManyArgs findManyArgs
    )
    {
        var count = await _context
            .ExtendedPeriodCarnetControls.ApplyWhere(findManyArgs.Where)
            .CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one Extended Period Carnet Control
    /// </summary>
    public async Task<ExtendedPeriodCarnetControl> ExtendedPeriodCarnetControl(
        ExtendedPeriodCarnetControlWhereUniqueInput uniqueId
    )
    {
        var extendedPeriodCarnetControls = await this.ExtendedPeriodCarnetControls(
            new ExtendedPeriodCarnetControlFindManyArgs
            {
                Where = new ExtendedPeriodCarnetControlWhereInput { Id = uniqueId.Id }
            }
        );
        var extendedPeriodCarnetControl = extendedPeriodCarnetControls.FirstOrDefault();
        if (extendedPeriodCarnetControl == null)
        {
            throw new NotFoundException();
        }

        return extendedPeriodCarnetControl;
    }

    /// <summary>
    /// Update one Extended Period Carnet Control
    /// </summary>
    public async Task UpdateExtendedPeriodCarnetControl(
        ExtendedPeriodCarnetControlWhereUniqueInput uniqueId,
        ExtendedPeriodCarnetControlUpdateInput updateDto
    )
    {
        var extendedPeriodCarnetControl = updateDto.ToModel(uniqueId);

        _context.Entry(extendedPeriodCarnetControl).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (
                !_context.ExtendedPeriodCarnetControls.Any(e =>
                    e.Id == extendedPeriodCarnetControl.Id
                )
            )
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
    /// Get a Extended Period Carnet Request record for Extended Period Carnet Control
    /// </summary>
    public async Task<ExtendedPeriodCarnetRequest> GetExtendedPeriodCarnetRequest(
        ExtendedPeriodCarnetControlWhereUniqueInput uniqueId
    )
    {
        var extendedPeriodCarnetControl = await _context
            .ExtendedPeriodCarnetControls.Where(extendedPeriodCarnetControl =>
                extendedPeriodCarnetControl.Id == uniqueId.Id
            )
            .Include(extendedPeriodCarnetControl =>
                extendedPeriodCarnetControl.ExtendedPeriodCarnetRequest
            )
            .FirstOrDefaultAsync();
        if (extendedPeriodCarnetControl == null)
        {
            throw new NotFoundException();
        }
        return extendedPeriodCarnetControl.ExtendedPeriodCarnetRequest.ToDto();
    }
}
