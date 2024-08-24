using Control.APIs;
using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Control.APIs.Extensions;
using Control.Infrastructure;
using Control.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Control.APIs;

public abstract class CommonAtaCarnetControlsServiceBase : ICommonAtaCarnetControlsService
{
    protected readonly ControlDbContext _context;

    public CommonAtaCarnetControlsServiceBase(ControlDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one Common ATA Carnet Control
    /// </summary>
    public async Task<CommonAtaCarnetControl> CreateCommonAtaCarnetControl(
        CommonAtaCarnetControlCreateInput createDto
    )
    {
        var commonAtaCarnetControl = new CommonAtaCarnetControlDbModel
        {
            AttachmentFileId = createDto.AttachmentFileId,
            AuthorizationDate = createDto.AuthorizationDate,
            CarnetNumber = createDto.CarnetNumber,
            CarnetTypeCode = createDto.CarnetTypeCode,
            CreatedAt = createDto.CreatedAt,
            DeletedOn = createDto.DeletedOn,
            FirstRecordDateAndTime = createDto.FirstRecordDateAndTime,
            FirstRecorderId = createDto.FirstRecorderId,
            GrantedDeadline = createDto.GrantedDeadline,
            LastModificationDateAndTime = createDto.LastModificationDateAndTime,
            LastModifierId = createDto.LastModifierId,
            ManagementNumberOfCarnet = createDto.ManagementNumberOfCarnet,
            ProcessingStatusCode = createDto.ProcessingStatusCode,
            UpdatedAt = createDto.UpdatedAt,
            VerificationResultContent = createDto.VerificationResultContent
        };

        if (createDto.Id != null)
        {
            commonAtaCarnetControl.Id = createDto.Id;
        }

        _context.CommonAtaCarnetControls.Add(commonAtaCarnetControl);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<CommonAtaCarnetControlDbModel>(
            commonAtaCarnetControl.Id
        );

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one Common ATA Carnet Control
    /// </summary>
    public async Task DeleteCommonAtaCarnetControl(CommonAtaCarnetControlWhereUniqueInput uniqueId)
    {
        var commonAtaCarnetControl = await _context.CommonAtaCarnetControls.FindAsync(uniqueId.Id);
        if (commonAtaCarnetControl == null)
        {
            throw new NotFoundException();
        }

        _context.CommonAtaCarnetControls.Remove(commonAtaCarnetControl);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many Common ATA Carnet Controls
    /// </summary>
    public async Task<List<CommonAtaCarnetControl>> CommonAtaCarnetControls(
        CommonAtaCarnetControlFindManyArgs findManyArgs
    )
    {
        var commonAtaCarnetControls = await _context
            .CommonAtaCarnetControls.ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return commonAtaCarnetControls.ConvertAll(commonAtaCarnetControl =>
            commonAtaCarnetControl.ToDto()
        );
    }

    /// <summary>
    /// Meta data about Common ATA Carnet Control records
    /// </summary>
    public async Task<MetadataDto> CommonAtaCarnetControlsMeta(
        CommonAtaCarnetControlFindManyArgs findManyArgs
    )
    {
        var count = await _context
            .CommonAtaCarnetControls.ApplyWhere(findManyArgs.Where)
            .CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one Common ATA Carnet Control
    /// </summary>
    public async Task<CommonAtaCarnetControl> CommonAtaCarnetControl(
        CommonAtaCarnetControlWhereUniqueInput uniqueId
    )
    {
        var commonAtaCarnetControls = await this.CommonAtaCarnetControls(
            new CommonAtaCarnetControlFindManyArgs
            {
                Where = new CommonAtaCarnetControlWhereInput { Id = uniqueId.Id }
            }
        );
        var commonAtaCarnetControl = commonAtaCarnetControls.FirstOrDefault();
        if (commonAtaCarnetControl == null)
        {
            throw new NotFoundException();
        }

        return commonAtaCarnetControl;
    }

    /// <summary>
    /// Update one Common ATA Carnet Control
    /// </summary>
    public async Task UpdateCommonAtaCarnetControl(
        CommonAtaCarnetControlWhereUniqueInput uniqueId,
        CommonAtaCarnetControlUpdateInput updateDto
    )
    {
        var commonAtaCarnetControl = updateDto.ToModel(uniqueId);

        _context.Entry(commonAtaCarnetControl).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!_context.CommonAtaCarnetControls.Any(e => e.Id == commonAtaCarnetControl.Id))
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
