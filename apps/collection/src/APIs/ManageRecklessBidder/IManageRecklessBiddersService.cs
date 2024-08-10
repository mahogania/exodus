using Collection.APIs.Common;
using Collection.APIs.Dtos;

namespace Collection.APIs;

public interface IManageRecklessBiddersService
{
    /// <summary>
    ///     Create one MANAGE RECKLESS BIDDER
    /// </summary>
    public Task<ManageRecklessBidder> CreateManageRecklessBidder(
        ManageRecklessBidderCreateInput managerecklessbidder
    );

    /// <summary>
    ///     Delete one MANAGE RECKLESS BIDDER
    /// </summary>
    public Task DeleteManageRecklessBidder(ManageRecklessBidderWhereUniqueInput uniqueId);

    /// <summary>
    ///     Find many MANAGE RECKLESS BIDDERS
    /// </summary>
    public Task<List<ManageRecklessBidder>> ManageRecklessBidders(
        ManageRecklessBidderFindManyArgs findManyArgs
    );

    /// <summary>
    ///     Meta data about MANAGE RECKLESS BIDDER records
    /// </summary>
    public Task<MetadataDto> ManageRecklessBiddersMeta(
        ManageRecklessBidderFindManyArgs findManyArgs
    );

    /// <summary>
    ///     Get one MANAGE RECKLESS BIDDER
    /// </summary>
    public Task<ManageRecklessBidder> ManageRecklessBidder(
        ManageRecklessBidderWhereUniqueInput uniqueId
    );

    /// <summary>
    ///     Update one MANAGE RECKLESS BIDDER
    /// </summary>
    public Task UpdateManageRecklessBidder(
        ManageRecklessBidderWhereUniqueInput uniqueId,
        ManageRecklessBidderUpdateInput updateDto
    );
}
