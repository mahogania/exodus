using Control.APIs.Common;
using Control.APIs.Dtos;

namespace Control.APIs;

public interface ICarnetRequestsService
{
    /// <summary>
    /// Create one Carnet Request
    /// </summary>
    public Task<CarnetRequest> CreateCarnetRequest(CarnetRequestCreateInput carnetrequest);

    /// <summary>
    /// Delete one Carnet Request
    /// </summary>
    public Task DeleteCarnetRequest(CarnetRequestWhereUniqueInput uniqueId);

    /// <summary>
    /// Find many Carnet Requests
    /// </summary>
    public Task<List<CarnetRequest>> CarnetRequests(CarnetRequestFindManyArgs findManyArgs);

    /// <summary>
    /// Meta data about Carnet Request records
    /// </summary>
    public Task<MetadataDto> CarnetRequestsMeta(CarnetRequestFindManyArgs findManyArgs);

    /// <summary>
    /// Get one Carnet Request
    /// </summary>
    public Task<CarnetRequest> CarnetRequest(CarnetRequestWhereUniqueInput uniqueId);

    /// <summary>
    /// Update one Carnet Request
    /// </summary>
    public Task UpdateCarnetRequest(
        CarnetRequestWhereUniqueInput uniqueId,
        CarnetRequestUpdateInput updateDto
    );

    /// <summary>
    /// Connect multiple Article Carnet Requests records to Carnet Request
    /// </summary>
    public Task ConnectArticleCarnetRequests(
        CarnetRequestWhereUniqueInput uniqueId,
        ArticleCarnetRequestWhereUniqueInput[] articleCarnetRequestsId
    );

    /// <summary>
    /// Disconnect multiple Article Carnet Requests records from Carnet Request
    /// </summary>
    public Task DisconnectArticleCarnetRequests(
        CarnetRequestWhereUniqueInput uniqueId,
        ArticleCarnetRequestWhereUniqueInput[] articleCarnetRequestsId
    );

    /// <summary>
    /// Find multiple Article Carnet Requests records for Carnet Request
    /// </summary>
    public Task<List<ArticleCarnetRequest>> FindArticleCarnetRequests(
        CarnetRequestWhereUniqueInput uniqueId,
        ArticleCarnetRequestFindManyArgs ArticleCarnetRequestFindManyArgs
    );

    /// <summary>
    /// Update multiple Article Carnet Requests records for Carnet Request
    /// </summary>
    public Task UpdateArticleCarnetRequests(
        CarnetRequestWhereUniqueInput uniqueId,
        ArticleCarnetRequestWhereUniqueInput[] articleCarnetRequestsId
    );
}
