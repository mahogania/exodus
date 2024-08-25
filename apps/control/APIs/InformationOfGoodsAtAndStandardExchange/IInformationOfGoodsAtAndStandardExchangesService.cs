using Control.APIs.Common;
using Control.APIs.Dtos;

namespace Control.APIs;

public interface IInformationOfGoodsAtAndStandardExchangesService
{
    /// <summary>
    ///     Create one INFORMATION OF GOODS AT AND STANDARD EXCHANGE
    /// </summary>
    public Task<InformationOfGoodsAtAndStandardExchange> CreateInformationOfGoodsAtAndStandardExchange(
        InformationOfGoodsAtAndStandardExchangeCreateInput informationofgoodsatandstandardexchange
    );

    /// <summary>
    ///     Delete one INFORMATION OF GOODS AT AND STANDARD EXCHANGE
    /// </summary>
    public Task DeleteInformationOfGoodsAtAndStandardExchange(
        InformationOfGoodsAtAndStandardExchangeWhereUniqueInput uniqueId
    );

    /// <summary>
    ///     Find many INFORMATION OF GOODS AT AND STANDARD EXCHANGES
    /// </summary>
    public Task<
        List<InformationOfGoodsAtAndStandardExchange>
    > InformationOfGoodsAtAndStandardExchanges(
        InformationOfGoodsAtAndStandardExchangeFindManyArgs findManyArgs
    );

    /// <summary>
    ///     Meta data about INFORMATION OF GOODS AT AND STANDARD EXCHANGE records
    /// </summary>
    public Task<MetadataDto> InformationOfGoodsAtAndStandardExchangesMeta(
        InformationOfGoodsAtAndStandardExchangeFindManyArgs findManyArgs
    );

    /// <summary>
    ///     Get one INFORMATION OF GOODS AT AND STANDARD EXCHANGE
    /// </summary>
    public Task<InformationOfGoodsAtAndStandardExchange> InformationOfGoodsAtAndStandardExchange(
        InformationOfGoodsAtAndStandardExchangeWhereUniqueInput uniqueId
    );

    /// <summary>
    ///     Update one INFORMATION OF GOODS AT AND STANDARD EXCHANGE
    /// </summary>
    public Task UpdateInformationOfGoodsAtAndStandardExchange(
        InformationOfGoodsAtAndStandardExchangeWhereUniqueInput uniqueId,
        InformationOfGoodsAtAndStandardExchangeUpdateInput updateDto
    );
}
