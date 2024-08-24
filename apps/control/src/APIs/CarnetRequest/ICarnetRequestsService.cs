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

    /// <summary>
    /// Get a Common Carnet Request record for Carnet Request
    /// </summary>
    public Task<CommonCarnetRequest> GetCommonCarnetRequest(CarnetRequestWhereUniqueInput uniqueId);

    /// <summary>
    /// Get a Extended Period Carnet Requests record for Carnet Request
    /// </summary>
    public Task<ExtendedPeriodCarnetRequest> GetExtendedPeriodCarnetRequests(
        CarnetRequestWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Connect multiple Import Carnet Requests records to Carnet Request
    /// </summary>
    public Task ConnectImportCarnetRequests(
        CarnetRequestWhereUniqueInput uniqueId,
        ImportCarnetRequestWhereUniqueInput[] importCarnetRequestsId
    );

    /// <summary>
    /// Disconnect multiple Import Carnet Requests records from Carnet Request
    /// </summary>
    public Task DisconnectImportCarnetRequests(
        CarnetRequestWhereUniqueInput uniqueId,
        ImportCarnetRequestWhereUniqueInput[] importCarnetRequestsId
    );

    /// <summary>
    /// Find multiple Import Carnet Requests records for Carnet Request
    /// </summary>
    public Task<List<ImportCarnetRequest>> FindImportCarnetRequests(
        CarnetRequestWhereUniqueInput uniqueId,
        ImportCarnetRequestFindManyArgs ImportCarnetRequestFindManyArgs
    );

    /// <summary>
    /// Update multiple Import Carnet Requests records for Carnet Request
    /// </summary>
    public Task UpdateImportCarnetRequests(
        CarnetRequestWhereUniqueInput uniqueId,
        ImportCarnetRequestWhereUniqueInput[] importCarnetRequestsId
    );

    /// <summary>
    /// Connect multiple Reexport Carnet Requests records to Carnet Request
    /// </summary>
    public Task ConnectReexportCarnetRequests(
        CarnetRequestWhereUniqueInput uniqueId,
        ReexportCarnetRequestWhereUniqueInput[] reexportCarnetRequestsId
    );

    /// <summary>
    /// Disconnect multiple Reexport Carnet Requests records from Carnet Request
    /// </summary>
    public Task DisconnectReexportCarnetRequests(
        CarnetRequestWhereUniqueInput uniqueId,
        ReexportCarnetRequestWhereUniqueInput[] reexportCarnetRequestsId
    );

    /// <summary>
    /// Find multiple Reexport Carnet Requests records for Carnet Request
    /// </summary>
    public Task<List<ReexportCarnetRequest>> FindReexportCarnetRequests(
        CarnetRequestWhereUniqueInput uniqueId,
        ReexportCarnetRequestFindManyArgs ReexportCarnetRequestFindManyArgs
    );

    /// <summary>
    /// Update multiple Reexport Carnet Requests records for Carnet Request
    /// </summary>
    public Task UpdateReexportCarnetRequests(
        CarnetRequestWhereUniqueInput uniqueId,
        ReexportCarnetRequestWhereUniqueInput[] reexportCarnetRequestsId
    );

    /// <summary>
    /// Connect multiple Transit Carnet Requests records to Carnet Request
    /// </summary>
    public Task ConnectTransitCarnetRequests(
        CarnetRequestWhereUniqueInput uniqueId,
        TransitCarnetRequestWhereUniqueInput[] transitCarnetRequestsId
    );

    /// <summary>
    /// Disconnect multiple Transit Carnet Requests records from Carnet Request
    /// </summary>
    public Task DisconnectTransitCarnetRequests(
        CarnetRequestWhereUniqueInput uniqueId,
        TransitCarnetRequestWhereUniqueInput[] transitCarnetRequestsId
    );

    /// <summary>
    /// Find multiple Transit Carnet Requests records for Carnet Request
    /// </summary>
    public Task<List<TransitCarnetRequest>> FindTransitCarnetRequests(
        CarnetRequestWhereUniqueInput uniqueId,
        TransitCarnetRequestFindManyArgs TransitCarnetRequestFindManyArgs
    );

    /// <summary>
    /// Update multiple Transit Carnet Requests records for Carnet Request
    /// </summary>
    public Task UpdateTransitCarnetRequests(
        CarnetRequestWhereUniqueInput uniqueId,
        TransitCarnetRequestWhereUniqueInput[] transitCarnetRequestsId
    );
}
