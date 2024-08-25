using Control.APIs.Common;
using Control.APIs.Dtos;

namespace Control.APIs;

public interface ICommonCarnetRequestsService
{
    /// <summary>
    /// Create one Common Carnet Request
    /// </summary>
    public Task<CommonCarnetRequest> CreateCommonCarnetRequest(
        CommonCarnetRequestCreateInput commoncarnetrequest
    );

    /// <summary>
    /// Delete one Common Carnet Request
    /// </summary>
    public Task DeleteCommonCarnetRequest(CommonCarnetRequestWhereUniqueInput uniqueId);

    /// <summary>
    /// Find many Common Carnet Requests
    /// </summary>
    public Task<List<CommonCarnetRequest>> CommonCarnetRequests(
        CommonCarnetRequestFindManyArgs findManyArgs
    );

    /// <summary>
    /// Meta data about Common Carnet Request records
    /// </summary>
    public Task<MetadataDto> CommonCarnetRequestsMeta(CommonCarnetRequestFindManyArgs findManyArgs);

    /// <summary>
    /// Get one Common Carnet Request
    /// </summary>
    public Task<CommonCarnetRequest> CommonCarnetRequest(
        CommonCarnetRequestWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Update one Common Carnet Request
    /// </summary>
    public Task UpdateCommonCarnetRequest(
        CommonCarnetRequestWhereUniqueInput uniqueId,
        CommonCarnetRequestUpdateInput updateDto
    );

    /// <summary>
    /// Connect multiple Article Carnet Requests records to Common Carnet Request
    /// </summary>
    public Task ConnectArticleCarnetRequests(
        CommonCarnetRequestWhereUniqueInput uniqueId,
        ArticleCarnetRequestWhereUniqueInput[] articleCarnetRequestsId
    );

    /// <summary>
    /// Disconnect multiple Article Carnet Requests records from Common Carnet Request
    /// </summary>
    public Task DisconnectArticleCarnetRequests(
        CommonCarnetRequestWhereUniqueInput uniqueId,
        ArticleCarnetRequestWhereUniqueInput[] articleCarnetRequestsId
    );

    /// <summary>
    /// Find multiple Article Carnet Requests records for Common Carnet Request
    /// </summary>
    public Task<List<ArticleCarnetRequest>> FindArticleCarnetRequests(
        CommonCarnetRequestWhereUniqueInput uniqueId,
        ArticleCarnetRequestFindManyArgs ArticleCarnetRequestFindManyArgs
    );

    /// <summary>
    /// Update multiple Article Carnet Requests records for Common Carnet Request
    /// </summary>
    public Task UpdateArticleCarnetRequests(
        CommonCarnetRequestWhereUniqueInput uniqueId,
        ArticleCarnetRequestWhereUniqueInput[] articleCarnetRequestsId
    );

    /// <summary>
    /// Connect multiple CarnetControls records to Common Carnet Request
    /// </summary>
    public Task ConnectCarnetControls(
        CommonCarnetRequestWhereUniqueInput uniqueId,
        CarnetControlWhereUniqueInput[] carnetControlsId
    );

    /// <summary>
    /// Disconnect multiple CarnetControls records from Common Carnet Request
    /// </summary>
    public Task DisconnectCarnetControls(
        CommonCarnetRequestWhereUniqueInput uniqueId,
        CarnetControlWhereUniqueInput[] carnetControlsId
    );

    /// <summary>
    /// Find multiple CarnetControls records for Common Carnet Request
    /// </summary>
    public Task<List<CarnetControl>> FindCarnetControls(
        CommonCarnetRequestWhereUniqueInput uniqueId,
        CarnetControlFindManyArgs CarnetControlFindManyArgs
    );

    /// <summary>
    /// Update multiple CarnetControls records for Common Carnet Request
    /// </summary>
    public Task UpdateCarnetControls(
        CommonCarnetRequestWhereUniqueInput uniqueId,
        CarnetControlWhereUniqueInput[] carnetControlsId
    );

    /// <summary>
    /// Connect multiple Extended Period Carnet Requests records to Common Carnet Request
    /// </summary>
    public Task ConnectExtendedPeriodCarnetRequests(
        CommonCarnetRequestWhereUniqueInput uniqueId,
        ExtendedPeriodCarnetRequestWhereUniqueInput[] extendedPeriodCarnetRequestsId
    );

    /// <summary>
    /// Disconnect multiple Extended Period Carnet Requests records from Common Carnet Request
    /// </summary>
    public Task DisconnectExtendedPeriodCarnetRequests(
        CommonCarnetRequestWhereUniqueInput uniqueId,
        ExtendedPeriodCarnetRequestWhereUniqueInput[] extendedPeriodCarnetRequestsId
    );

    /// <summary>
    /// Find multiple Extended Period Carnet Requests records for Common Carnet Request
    /// </summary>
    public Task<List<ExtendedPeriodCarnetRequest>> FindExtendedPeriodCarnetRequests(
        CommonCarnetRequestWhereUniqueInput uniqueId,
        ExtendedPeriodCarnetRequestFindManyArgs ExtendedPeriodCarnetRequestFindManyArgs
    );

    /// <summary>
    /// Update multiple Extended Period Carnet Requests records for Common Carnet Request
    /// </summary>
    public Task UpdateExtendedPeriodCarnetRequests(
        CommonCarnetRequestWhereUniqueInput uniqueId,
        ExtendedPeriodCarnetRequestWhereUniqueInput[] extendedPeriodCarnetRequestsId
    );

    /// <summary>
    /// Connect multiple Import Carnet Requests records to Common Carnet Request
    /// </summary>
    public Task ConnectImportCarnetRequests(
        CommonCarnetRequestWhereUniqueInput uniqueId,
        ImportCarnetRequestWhereUniqueInput[] importCarnetRequestsId
    );

    /// <summary>
    /// Disconnect multiple Import Carnet Requests records from Common Carnet Request
    /// </summary>
    public Task DisconnectImportCarnetRequests(
        CommonCarnetRequestWhereUniqueInput uniqueId,
        ImportCarnetRequestWhereUniqueInput[] importCarnetRequestsId
    );

    /// <summary>
    /// Find multiple Import Carnet Requests records for Common Carnet Request
    /// </summary>
    public Task<List<ImportCarnetRequest>> FindImportCarnetRequests(
        CommonCarnetRequestWhereUniqueInput uniqueId,
        ImportCarnetRequestFindManyArgs ImportCarnetRequestFindManyArgs
    );

    /// <summary>
    /// Update multiple Import Carnet Requests records for Common Carnet Request
    /// </summary>
    public Task UpdateImportCarnetRequests(
        CommonCarnetRequestWhereUniqueInput uniqueId,
        ImportCarnetRequestWhereUniqueInput[] importCarnetRequestsId
    );

    /// <summary>
    /// Connect multiple Reexport Carnet Requests records to Common Carnet Request
    /// </summary>
    public Task ConnectReexportCarnetRequests(
        CommonCarnetRequestWhereUniqueInput uniqueId,
        ReexportCarnetRequestWhereUniqueInput[] reexportCarnetRequestsId
    );

    /// <summary>
    /// Disconnect multiple Reexport Carnet Requests records from Common Carnet Request
    /// </summary>
    public Task DisconnectReexportCarnetRequests(
        CommonCarnetRequestWhereUniqueInput uniqueId,
        ReexportCarnetRequestWhereUniqueInput[] reexportCarnetRequestsId
    );

    /// <summary>
    /// Find multiple Reexport Carnet Requests records for Common Carnet Request
    /// </summary>
    public Task<List<ReexportCarnetRequest>> FindReexportCarnetRequests(
        CommonCarnetRequestWhereUniqueInput uniqueId,
        ReexportCarnetRequestFindManyArgs ReexportCarnetRequestFindManyArgs
    );

    /// <summary>
    /// Update multiple Reexport Carnet Requests records for Common Carnet Request
    /// </summary>
    public Task UpdateReexportCarnetRequests(
        CommonCarnetRequestWhereUniqueInput uniqueId,
        ReexportCarnetRequestWhereUniqueInput[] reexportCarnetRequestsId
    );

    /// <summary>
    /// Connect multiple Transit Carnet Requests records to Common Carnet Request
    /// </summary>
    public Task ConnectTransitCarnetRequests(
        CommonCarnetRequestWhereUniqueInput uniqueId,
        TransitCarnetRequestWhereUniqueInput[] transitCarnetRequestsId
    );

    /// <summary>
    /// Disconnect multiple Transit Carnet Requests records from Common Carnet Request
    /// </summary>
    public Task DisconnectTransitCarnetRequests(
        CommonCarnetRequestWhereUniqueInput uniqueId,
        TransitCarnetRequestWhereUniqueInput[] transitCarnetRequestsId
    );

    /// <summary>
    /// Find multiple Transit Carnet Requests records for Common Carnet Request
    /// </summary>
    public Task<List<TransitCarnetRequest>> FindTransitCarnetRequests(
        CommonCarnetRequestWhereUniqueInput uniqueId,
        TransitCarnetRequestFindManyArgs TransitCarnetRequestFindManyArgs
    );

    /// <summary>
    /// Update multiple Transit Carnet Requests records for Common Carnet Request
    /// </summary>
    public Task UpdateTransitCarnetRequests(
        CommonCarnetRequestWhereUniqueInput uniqueId,
        TransitCarnetRequestWhereUniqueInput[] transitCarnetRequestsId
    );
}
