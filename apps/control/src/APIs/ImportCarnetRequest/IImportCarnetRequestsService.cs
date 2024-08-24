using Control.APIs.Common;
using Control.APIs.Dtos;

namespace Control.APIs;

public interface IImportCarnetRequestsService
{
    /// <summary>
    /// Create one Import Carnet Request
    /// </summary>
    public Task<ImportCarnetRequest> CreateImportCarnetRequest(
        ImportCarnetRequestCreateInput importcarnetrequest
    );

    /// <summary>
    /// Delete one Import Carnet Request
    /// </summary>
    public Task DeleteImportCarnetRequest(ImportCarnetRequestWhereUniqueInput uniqueId);

    /// <summary>
    /// Find many Import Carnet Requests
    /// </summary>
    public Task<List<ImportCarnetRequest>> ImportCarnetRequests(
        ImportCarnetRequestFindManyArgs findManyArgs
    );

    /// <summary>
    /// Meta data about Import Carnet Request records
    /// </summary>
    public Task<MetadataDto> ImportCarnetRequestsMeta(ImportCarnetRequestFindManyArgs findManyArgs);

    /// <summary>
    /// Get one Import Carnet Request
    /// </summary>
    public Task<ImportCarnetRequest> ImportCarnetRequest(
        ImportCarnetRequestWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Update one Import Carnet Request
    /// </summary>
    public Task UpdateImportCarnetRequest(
        ImportCarnetRequestWhereUniqueInput uniqueId,
        ImportCarnetRequestUpdateInput updateDto
    );

    /// <summary>
    /// Get a Import Carnet Control record for Import Carnet Request
    /// </summary>
    public Task<ImportCarnetControl> GetImportCarnetControl(
        ImportCarnetRequestWhereUniqueInput uniqueId
    );
}
