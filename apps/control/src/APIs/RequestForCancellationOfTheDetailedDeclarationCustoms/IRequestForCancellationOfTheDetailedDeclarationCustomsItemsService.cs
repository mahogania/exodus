using Clre.APIs.Common;
using Clre.APIs.Dtos;

namespace Clre.APIs;

public interface IRequestForCancellationOfTheDetailedDeclarationCustomsItemsService
{
    /// <summary>
    /// Create one REQUEST FOR CANCELLATION OF THE DETAILED DECLARATION (CUSTOMS)
    /// </summary>
    public Task<RequestForCancellationOfTheDetailedDeclarationCustoms> CreateRequestForCancellationOfTheDetailedDeclarationCustoms(
        RequestForCancellationOfTheDetailedDeclarationCustomsCreateInput requestforcancellationofthedetaileddeclarationcustoms
    );

    /// <summary>
    /// Delete one REQUEST FOR CANCELLATION OF THE DETAILED DECLARATION (CUSTOMS)
    /// </summary>
    public Task DeleteRequestForCancellationOfTheDetailedDeclarationCustoms(
        RequestForCancellationOfTheDetailedDeclarationCustomsWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Find many REQUEST FOR CANCELLATION OF THE DETAILED DECLARATION (CUSTOMS)s
    /// </summary>
    public Task<
        List<RequestForCancellationOfTheDetailedDeclarationCustoms>
    > RequestForCancellationOfTheDetailedDeclarationCustomsItems(
        RequestForCancellationOfTheDetailedDeclarationCustomsFindManyArgs findManyArgs
    );

    /// <summary>
    /// Meta data about REQUEST FOR CANCELLATION OF THE DETAILED DECLARATION (CUSTOMS) records
    /// </summary>
    public Task<MetadataDto> RequestForCancellationOfTheDetailedDeclarationCustomsItemsMeta(
        RequestForCancellationOfTheDetailedDeclarationCustomsFindManyArgs findManyArgs
    );

    /// <summary>
    /// Get one REQUEST FOR CANCELLATION OF THE DETAILED DECLARATION (CUSTOMS)
    /// </summary>
    public Task<RequestForCancellationOfTheDetailedDeclarationCustoms> RequestForCancellationOfTheDetailedDeclarationCustoms(
        RequestForCancellationOfTheDetailedDeclarationCustomsWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Update one REQUEST FOR CANCELLATION OF THE DETAILED DECLARATION (CUSTOMS)
    /// </summary>
    public Task UpdateRequestForCancellationOfTheDetailedDeclarationCustoms(
        RequestForCancellationOfTheDetailedDeclarationCustomsWhereUniqueInput uniqueId,
        RequestForCancellationOfTheDetailedDeclarationCustomsUpdateInput updateDto
    );
}
