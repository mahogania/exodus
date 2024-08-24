using Control.APIs;
using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Control.APIs.Extensions;
using Control.Infrastructure;
using Control.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Control.APIs;

public abstract class CommonAtaCarnetControlAltsServiceBase : ICommonAtaCarnetControlAltsService
{
    protected readonly ControlDbContext _context;

    public CommonAtaCarnetControlAltsServiceBase(ControlDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one Common ATA Carnet Control Alt
    /// </summary>
    public async Task<CommonAtaCarnetControlAlt> CreateCommonAtaCarnetControlAlt(
        CommonAtaCarnetControlAltCreateInput createDto
    )
    {
        var commonAtaCarnetControlAlt = new CommonAtaCarnetControlAltDbModel
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
            commonAtaCarnetControlAlt.Id = createDto.Id;
        }

        _context.CommonAtaCarnetControlAlts.Add(commonAtaCarnetControlAlt);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<CommonAtaCarnetControlAltDbModel>(
            commonAtaCarnetControlAlt.Id
        );

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one Common ATA Carnet Control Alt
    /// </summary>
    public async Task DeleteCommonAtaCarnetControlAlt(
        CommonAtaCarnetControlAltWhereUniqueInput uniqueId
    )
    {
        var commonAtaCarnetControlAlt = await _context.CommonAtaCarnetControlAlts.FindAsync(
            uniqueId.Id
        );
        if (commonAtaCarnetControlAlt == null)
        {
            throw new NotFoundException();
        }

        _context.CommonAtaCarnetControlAlts.Remove(commonAtaCarnetControlAlt);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many Common ATA Carnet Control Alts
    /// </summary>
    public async Task<List<CommonAtaCarnetControlAlt>> CommonAtaCarnetControlAlts(
        CommonAtaCarnetControlAltFindManyArgs findManyArgs
    )
    {
        var commonAtaCarnetControlAlts = await _context
            .CommonAtaCarnetControlAlts.ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return commonAtaCarnetControlAlts.ConvertAll(commonAtaCarnetControlAlt =>
            commonAtaCarnetControlAlt.ToDto()
        );
    }

    /// <summary>
    /// Meta data about Common ATA Carnet Control Alt records
    /// </summary>
    public async Task<MetadataDto> CommonAtaCarnetControlAltsMeta(
        CommonAtaCarnetControlAltFindManyArgs findManyArgs
    )
    {
        var count = await _context
            .CommonAtaCarnetControlAlts.ApplyWhere(findManyArgs.Where)
            .CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one Common ATA Carnet Control Alt
    /// </summary>
    public async Task<CommonAtaCarnetControlAlt> CommonAtaCarnetControlAlt(
        CommonAtaCarnetControlAltWhereUniqueInput uniqueId
    )
    {
        var commonAtaCarnetControlAlts = await this.CommonAtaCarnetControlAlts(
            new CommonAtaCarnetControlAltFindManyArgs
            {
                Where = new CommonAtaCarnetControlAltWhereInput { Id = uniqueId.Id }
            }
        );
        var commonAtaCarnetControlAlt = commonAtaCarnetControlAlts.FirstOrDefault();
        if (commonAtaCarnetControlAlt == null)
        {
            throw new NotFoundException();
        }

        return commonAtaCarnetControlAlt;
    }

    /// <summary>
    /// Update one Common ATA Carnet Control Alt
    /// </summary>
    public async Task UpdateCommonAtaCarnetControlAlt(
        CommonAtaCarnetControlAltWhereUniqueInput uniqueId,
        CommonAtaCarnetControlAltUpdateInput updateDto
    )
    {
        var commonAtaCarnetControlAlt = updateDto.ToModel(uniqueId);

        _context.Entry(commonAtaCarnetControlAlt).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!_context.CommonAtaCarnetControlAlts.Any(e => e.Id == commonAtaCarnetControlAlt.Id))
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
