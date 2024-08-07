using Microsoft.EntityFrameworkCore;
using Statement.APIs;
using Statement.APIs.Common;
using Statement.APIs.Dtos;
using Statement.APIs.Errors;
using Statement.APIs.Extensions;
using Statement.Infrastructure;
using Statement.Infrastructure.Models;

namespace Statement.APIs;

public abstract class AttachmentsServiceBase : IAttachmentsService
{
    protected readonly StatementDbContext _context;

    public AttachmentsServiceBase(StatementDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one Attachment
    /// </summary>
    public async Task<Attachment> CreateAttachment(AttachmentCreateInput createDto)
    {
        var attachment = new AttachmentDbModel
        {
            AtchDocSrno = createDto.AtchDocSrno,
            CreatedAt = createDto.CreatedAt,
            DelOn = createDto.DelOn,
            DocDesc = createDto.DocDesc,
            DocKndCd = createDto.DocKndCd,
            DocNo = createDto.DocNo,
            File = createDto.File,
            FrstRegstId = createDto.FrstRegstId,
            FrstRgsrDttm = createDto.FrstRgsrDttm,
            LastChgDttm = createDto.LastChgDttm,
            LastChprId = createDto.LastChprId,
            MdfyDgcnt = createDto.MdfyDgcnt,
            PblsDt = createDto.PblsDt,
            PblsIttNm = createDto.PblsIttNm,
            PdlsNo = createDto.PdlsNo,
            ReffNo = createDto.ReffNo,
            UpdatedAt = createDto.UpdatedAt
        };

        if (createDto.Id != null)
        {
            attachment.Id = createDto.Id;
        }

        _context.Attachments.Add(attachment);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<AttachmentDbModel>(attachment.Id);

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one Attachment
    /// </summary>
    public async Task DeleteAttachment(AttachmentWhereUniqueInput uniqueId)
    {
        var attachment = await _context.Attachments.FindAsync(uniqueId.Id);
        if (attachment == null)
        {
            throw new NotFoundException();
        }

        _context.Attachments.Remove(attachment);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many Attachments
    /// </summary>
    public async Task<List<Attachment>> Attachments(AttachmentFindManyArgs findManyArgs)
    {
        var attachments = await _context
            .Attachments.ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return attachments.ConvertAll(attachment => attachment.ToDto());
    }

    /// <summary>
    /// Meta data about Attachment records
    /// </summary>
    public async Task<MetadataDto> AttachmentsMeta(AttachmentFindManyArgs findManyArgs)
    {
        var count = await _context.Attachments.ApplyWhere(findManyArgs.Where).CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one Attachment
    /// </summary>
    public async Task<Attachment> Attachment(AttachmentWhereUniqueInput uniqueId)
    {
        var attachments = await this.Attachments(
            new AttachmentFindManyArgs { Where = new AttachmentWhereInput { Id = uniqueId.Id } }
        );
        var attachment = attachments.FirstOrDefault();
        if (attachment == null)
        {
            throw new NotFoundException();
        }

        return attachment;
    }

    /// <summary>
    /// Update one Attachment
    /// </summary>
    public async Task UpdateAttachment(
        AttachmentWhereUniqueInput uniqueId,
        AttachmentUpdateInput updateDto
    )
    {
        var attachment = updateDto.ToModel(uniqueId);

        _context.Entry(attachment).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!_context.Attachments.Any(e => e.Id == attachment.Id))
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
