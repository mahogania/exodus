using Statement.APIs.Common;
using Statement.APIs.Dtos;

namespace Statement.APIs;

public interface IAttachmentsService
{
    /// <summary>
    /// Create one Attachment
    /// </summary>
    public Task<Attachment> CreateAttachment(AttachmentCreateInput attachment);

    /// <summary>
    /// Delete one Attachment
    /// </summary>
    public Task DeleteAttachment(AttachmentWhereUniqueInput uniqueId);

    /// <summary>
    /// Find many Attachments
    /// </summary>
    public Task<List<Attachment>> Attachments(AttachmentFindManyArgs findManyArgs);

    /// <summary>
    /// Meta data about Attachment records
    /// </summary>
    public Task<MetadataDto> AttachmentsMeta(AttachmentFindManyArgs findManyArgs);

    /// <summary>
    /// Get one Attachment
    /// </summary>
    public Task<Attachment> Attachment(AttachmentWhereUniqueInput uniqueId);

    /// <summary>
    /// Update one Attachment
    /// </summary>
    public Task UpdateAttachment(
        AttachmentWhereUniqueInput uniqueId,
        AttachmentUpdateInput updateDto
    );
}
