using Evaluation.APIs.Common;
using Evaluation.APIs.Dtos;

namespace Evaluation.APIs;

public interface IExpressesService
{
    /// <summary>
    /// Create one Express
    /// </summary>
    public Task<Express> CreateExpress(ExpressCreateInput express);

    /// <summary>
    /// Delete one Express
    /// </summary>
    public Task DeleteExpress(ExpressWhereUniqueInput uniqueId);

    /// <summary>
    /// Find many Expresses
    /// </summary>
    public Task<List<Express>> Expresses(ExpressFindManyArgs findManyArgs);

    /// <summary>
    /// Meta data about Express records
    /// </summary>
    public Task<MetadataDto> ExpressesMeta(ExpressFindManyArgs findManyArgs);

    /// <summary>
    /// Get one Express
    /// </summary>
    public Task<Express> Express(ExpressWhereUniqueInput uniqueId);

    /// <summary>
    /// Update one Express
    /// </summary>
    public Task UpdateExpress(ExpressWhereUniqueInput uniqueId, ExpressUpdateInput updateDto);
}
