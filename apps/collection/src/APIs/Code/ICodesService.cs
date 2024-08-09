using Collection.APIs.Common;
using Collection.APIs.Dtos;

namespace Collection.APIs;

public interface ICodesService
{
    /// <summary>
    /// Create one CODE
    /// </summary>
    public Task<Code> CreateCode(CodeCreateInput code);

    /// <summary>
    /// Delete one CODE
    /// </summary>
    public Task DeleteCode(CodeWhereUniqueInput uniqueId);

    /// <summary>
    /// Find many CODES
    /// </summary>
    public Task<List<Code>> Codes(CodeFindManyArgs findManyArgs);

    /// <summary>
    /// Meta data about CODE records
    /// </summary>
    public Task<MetadataDto> CodesMeta(CodeFindManyArgs findManyArgs);

    /// <summary>
    /// Get one CODE
    /// </summary>
    public Task<Code> Code(CodeWhereUniqueInput uniqueId);

    /// <summary>
    /// Update one CODE
    /// </summary>
    public Task UpdateCode(CodeWhereUniqueInput uniqueId, CodeUpdateInput updateDto);
}
