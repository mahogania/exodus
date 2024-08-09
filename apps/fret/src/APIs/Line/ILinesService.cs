using Fret.APIs.Common;
using Fret.APIs.Dtos;

namespace Fret.APIs;

public interface ILinesService
{
    /// <summary>
    /// Create one Ligne
    /// </summary>
    public Task<Line> CreateLine(LineCreateInput line);

    /// <summary>
    /// Delete one Ligne
    /// </summary>
    public Task DeleteLine(LineWhereUniqueInput uniqueId);

    /// <summary>
    /// Find many Lines
    /// </summary>
    public Task<List<Line>> Lines(LineFindManyArgs findManyArgs);

    /// <summary>
    /// Meta data about Ligne records
    /// </summary>
    public Task<MetadataDto> LinesMeta(LineFindManyArgs findManyArgs);

    /// <summary>
    /// Get one Ligne
    /// </summary>
    public Task<Line> Line(LineWhereUniqueInput uniqueId);

    /// <summary>
    /// Update one Ligne
    /// </summary>
    public Task UpdateLine(LineWhereUniqueInput uniqueId, LineUpdateInput updateDto);
}
