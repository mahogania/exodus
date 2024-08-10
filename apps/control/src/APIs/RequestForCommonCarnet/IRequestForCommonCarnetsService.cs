using Control.APIs.Common;
using Control.APIs.Dtos;

namespace Control.APIs;

public interface IRequestForCommonCarnetsService
{
    /// <summary>
    ///     Create one REQUEST FOR COMMON CARNET
    /// </summary>
    public Task<RequestForCommonCarnet> CreateRequestForCommonCarnet(
        RequestForCommonCarnetCreateInput requestforcommoncarnet
    );

    /// <summary>
    ///     Delete one REQUEST FOR COMMON CARNET
    /// </summary>
    public Task DeleteRequestForCommonCarnet(RequestForCommonCarnetWhereUniqueInput uniqueId);

    /// <summary>
    ///     Find many REQUEST FOR COMMON CARNETS
    /// </summary>
    public Task<List<RequestForCommonCarnet>> RequestForCommonCarnets(
        RequestForCommonCarnetFindManyArgs findManyArgs
    );

    /// <summary>
    ///     Meta data about REQUEST FOR COMMON CARNET records
    /// </summary>
    public Task<MetadataDto> RequestForCommonCarnetsMeta(
        RequestForCommonCarnetFindManyArgs findManyArgs
    );

    /// <summary>
    ///     Get one REQUEST FOR COMMON CARNET
    /// </summary>
    public Task<RequestForCommonCarnet> RequestForCommonCarnet(
        RequestForCommonCarnetWhereUniqueInput uniqueId
    );

    /// <summary>
    ///     Update one REQUEST FOR COMMON CARNET
    /// </summary>
    public Task UpdateRequestForCommonCarnet(
        RequestForCommonCarnetWhereUniqueInput uniqueId,
        RequestForCommonCarnetUpdateInput updateDto
    );
}
