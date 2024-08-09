using Clre.APIs.Common;
using Clre.APIs.Dtos;

namespace Clre.APIs;

public interface IAtAndStandardExchangesService
{
    /// <summary>
    /// Create one AT? AND STANDARD EXCHANGE
    /// </summary>
    public Task<AtAndStandardExchange> CreateAtAndStandardExchange(
        AtAndStandardExchangeCreateInput atandstandardexchange
    );

    /// <summary>
    /// Delete one AT? AND STANDARD EXCHANGE
    /// </summary>
    public Task DeleteAtAndStandardExchange(AtAndStandardExchangeWhereUniqueInput uniqueId);

    /// <summary>
    /// Find many AT? AND STANDARD EXCHANGES
    /// </summary>
    public Task<List<AtAndStandardExchange>> AtAndStandardExchanges(
        AtAndStandardExchangeFindManyArgs findManyArgs
    );

    /// <summary>
    /// Meta data about AT? AND STANDARD EXCHANGE records
    /// </summary>
    public Task<MetadataDto> AtAndStandardExchangesMeta(
        AtAndStandardExchangeFindManyArgs findManyArgs
    );

    /// <summary>
    /// Get one AT? AND STANDARD EXCHANGE
    /// </summary>
    public Task<AtAndStandardExchange> AtAndStandardExchange(
        AtAndStandardExchangeWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Update one AT? AND STANDARD EXCHANGE
    /// </summary>
    public Task UpdateAtAndStandardExchange(
        AtAndStandardExchangeWhereUniqueInput uniqueId,
        AtAndStandardExchangeUpdateInput updateDto
    );
}
