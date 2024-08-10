using Collection.APIs.Common;
using Collection.APIs.Dtos;

namespace Collection.APIs;

public interface IAppealsService
{
    /// <summary>
    ///     Create one APPEAL
    /// </summary>
    public Task<Appeal> CreateAppeal(AppealCreateInput appeal);

    /// <summary>
    ///     Delete one APPEAL
    /// </summary>
    public Task DeleteAppeal(AppealWhereUniqueInput uniqueId);

    /// <summary>
    ///     Find many APPEALS
    /// </summary>
    public Task<List<Appeal>> Appeals(AppealFindManyArgs findManyArgs);

    /// <summary>
    ///     Meta data about APPEAL records
    /// </summary>
    public Task<MetadataDto> AppealsMeta(AppealFindManyArgs findManyArgs);

    /// <summary>
    ///     Get one APPEAL
    /// </summary>
    public Task<Appeal> Appeal(AppealWhereUniqueInput uniqueId);

    /// <summary>
    ///     Update one APPEAL
    /// </summary>
    public Task UpdateAppeal(AppealWhereUniqueInput uniqueId, AppealUpdateInput updateDto);
}
