using Control.APIs.Common;
using Control.APIs.Dtos;

namespace Control.APIs;

public interface IGoodsSubjectToAuthorizationsService
{
    /// <summary>
    ///     Create one GOODS SUBJECT TO AUTHORIZATION
    /// </summary>
    public Task<GoodsSubjectToAuthorization> CreateGoodsSubjectToAuthorization(
        GoodsSubjectToAuthorizationCreateInput goodssubjecttoauthorization
    );

    /// <summary>
    ///     Delete one GOODS SUBJECT TO AUTHORIZATION
    /// </summary>
    public Task DeleteGoodsSubjectToAuthorization(
        GoodsSubjectToAuthorizationWhereUniqueInput uniqueId
    );

    /// <summary>
    ///     Find many GOODS SUBJECT TO AUTHORIZATIONS
    /// </summary>
    public Task<List<GoodsSubjectToAuthorization>> GoodsSubjectToAuthorizations(
        GoodsSubjectToAuthorizationFindManyArgs findManyArgs
    );

    /// <summary>
    ///     Meta data about GOODS SUBJECT TO AUTHORIZATION records
    /// </summary>
    public Task<MetadataDto> GoodsSubjectToAuthorizationsMeta(
        GoodsSubjectToAuthorizationFindManyArgs findManyArgs
    );

    /// <summary>
    ///     Get one GOODS SUBJECT TO AUTHORIZATION
    /// </summary>
    public Task<GoodsSubjectToAuthorization> GoodsSubjectToAuthorization(
        GoodsSubjectToAuthorizationWhereUniqueInput uniqueId
    );

    /// <summary>
    ///     Update one GOODS SUBJECT TO AUTHORIZATION
    /// </summary>
    public Task UpdateGoodsSubjectToAuthorization(
        GoodsSubjectToAuthorizationWhereUniqueInput uniqueId,
        GoodsSubjectToAuthorizationUpdateInput updateDto
    );
}
