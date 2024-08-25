using Control.APIs.Common;
using Control.APIs.Dtos;

namespace Control.APIs;

public interface IAppealsService
{
    /// <summary>
    /// Create one Appeal
    /// </summary>
    public Task<Appeal> CreateAppeal(AppealCreateInput appeal);

    /// <summary>
    /// Delete one Appeal
    /// </summary>
    public Task DeleteAppeal(AppealWhereUniqueInput uniqueId);

    /// <summary>
    /// Find many Appeal On The Result Of The Verification Of The Evaluation Of ValuesItems
    /// </summary>
    public Task<List<Appeal>> Appeals(AppealFindManyArgs findManyArgs);

    /// <summary>
    /// Meta data about Appeal records
    /// </summary>
    public Task<MetadataDto> AppealsMeta(AppealFindManyArgs findManyArgs);

    /// <summary>
    /// Get one Appeal
    /// </summary>
    public Task<Appeal> Appeal(AppealWhereUniqueInput uniqueId);

    /// <summary>
    /// Update one Appeal
    /// </summary>
    public Task UpdateAppeal(AppealWhereUniqueInput uniqueId, AppealUpdateInput updateDto);

    /// <summary>
    /// Connect multiple Common Verifications records to Appeal
    /// </summary>
    public Task ConnectCommonVerifications(
        AppealWhereUniqueInput uniqueId,
        CommonVerificationWhereUniqueInput[] commonVerificationsId
    );

    /// <summary>
    /// Disconnect multiple Common Verifications records from Appeal
    /// </summary>
    public Task DisconnectCommonVerifications(
        AppealWhereUniqueInput uniqueId,
        CommonVerificationWhereUniqueInput[] commonVerificationsId
    );

    /// <summary>
    /// Find multiple Common Verifications records for Appeal
    /// </summary>
    public Task<List<CommonVerification>> FindCommonVerifications(
        AppealWhereUniqueInput uniqueId,
        CommonVerificationFindManyArgs CommonVerificationFindManyArgs
    );

    /// <summary>
    /// Update multiple Common Verifications records for Appeal
    /// </summary>
    public Task UpdateCommonVerifications(
        AppealWhereUniqueInput uniqueId,
        CommonVerificationWhereUniqueInput[] commonVerificationsId
    );
}
