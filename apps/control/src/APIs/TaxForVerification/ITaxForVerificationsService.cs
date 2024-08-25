using Control.APIs.Common;
using Control.APIs.Dtos;

namespace Control.APIs;

public interface ITaxForVerificationsService
{
    /// <summary>
    /// Create one Tax For Verification
    /// </summary>
    public Task<TaxForVerification> CreateTaxForVerification(
        TaxForVerificationCreateInput taxforverification
    );

    /// <summary>
    /// Delete one Tax For Verification
    /// </summary>
    public Task DeleteTaxForVerification(TaxForVerificationWhereUniqueInput uniqueId);

    /// <summary>
    /// Find many Tax For Verifications
    /// </summary>
    public Task<List<TaxForVerification>> TaxForVerifications(
        TaxForVerificationFindManyArgs findManyArgs
    );

    /// <summary>
    /// Meta data about Tax For Verification records
    /// </summary>
    public Task<MetadataDto> TaxForVerificationsMeta(TaxForVerificationFindManyArgs findManyArgs);

    /// <summary>
    /// Get one Tax For Verification
    /// </summary>
    public Task<TaxForVerification> TaxForVerification(TaxForVerificationWhereUniqueInput uniqueId);

    /// <summary>
    /// Update one Tax For Verification
    /// </summary>
    public Task UpdateTaxForVerification(
        TaxForVerificationWhereUniqueInput uniqueId,
        TaxForVerificationUpdateInput updateDto
    );

    /// <summary>
    /// Get a Articles Submitted For Verifications record for Tax For Verification
    /// </summary>
    public Task<ArticlesSubmittedForVerification> GetArticlesSubmittedForVerifications(
        TaxForVerificationWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Connect multiple Common Verifications records to Tax For Verification
    /// </summary>
    public Task ConnectCommonVerifications(
        TaxForVerificationWhereUniqueInput uniqueId,
        CommonVerificationWhereUniqueInput[] commonVerificationsId
    );

    /// <summary>
    /// Disconnect multiple Common Verifications records from Tax For Verification
    /// </summary>
    public Task DisconnectCommonVerifications(
        TaxForVerificationWhereUniqueInput uniqueId,
        CommonVerificationWhereUniqueInput[] commonVerificationsId
    );

    /// <summary>
    /// Find multiple Common Verifications records for Tax For Verification
    /// </summary>
    public Task<List<CommonVerification>> FindCommonVerifications(
        TaxForVerificationWhereUniqueInput uniqueId,
        CommonVerificationFindManyArgs CommonVerificationFindManyArgs
    );

    /// <summary>
    /// Update multiple Common Verifications records for Tax For Verification
    /// </summary>
    public Task UpdateCommonVerifications(
        TaxForVerificationWhereUniqueInput uniqueId,
        CommonVerificationWhereUniqueInput[] commonVerificationsId
    );
}
