using Control.APIs.Common;
using Control.APIs.Dtos;

namespace Control.APIs;

public interface IInformationForDeterminingOriginsService
{
    /// <summary>
    ///     Create one INFORMATION FOR DETERMINING ORIGIN
    /// </summary>
    public Task<InformationForDeterminingOrigin> CreateInformationForDeterminingOrigin(
        InformationForDeterminingOriginCreateInput informationfordeterminingorigin
    );

    /// <summary>
    ///     Delete one INFORMATION FOR DETERMINING ORIGIN
    /// </summary>
    public Task DeleteInformationForDeterminingOrigin(
        InformationForDeterminingOriginWhereUniqueInput uniqueId
    );

    /// <summary>
    ///     Find many INFORMATION FOR DETERMINING ORIGIN | CLRES
    /// </summary>
    public Task<List<InformationForDeterminingOrigin>> InformationForDeterminingOrigins(
        InformationForDeterminingOriginFindManyArgs findManyArgs
    );

    /// <summary>
    ///     Meta data about INFORMATION FOR DETERMINING ORIGIN records
    /// </summary>
    public Task<MetadataDto> InformationForDeterminingOriginsMeta(
        InformationForDeterminingOriginFindManyArgs findManyArgs
    );

    /// <summary>
    ///     Get one INFORMATION FOR DETERMINING ORIGIN
    /// </summary>
    public Task<InformationForDeterminingOrigin> InformationForDeterminingOrigin(
        InformationForDeterminingOriginWhereUniqueInput uniqueId
    );

    /// <summary>
    ///     Update one INFORMATION FOR DETERMINING ORIGIN
    /// </summary>
    public Task UpdateInformationForDeterminingOrigin(
        InformationForDeterminingOriginWhereUniqueInput uniqueId,
        InformationForDeterminingOriginUpdateInput updateDto
    );
}
