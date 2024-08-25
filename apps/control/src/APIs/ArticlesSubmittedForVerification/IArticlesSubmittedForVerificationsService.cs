using Control.APIs.Common;
using Control.APIs.Dtos;

namespace Control.APIs;

public interface IArticlesSubmittedForVerificationsService
{
    /// <summary>
    /// Create one Articles Submitted For Verification
    /// </summary>
    public Task<ArticlesSubmittedForVerification> CreateArticlesSubmittedForVerification(
        ArticlesSubmittedForVerificationCreateInput articlessubmittedforverification
    );

    /// <summary>
    /// Delete one Articles Submitted For Verification
    /// </summary>
    public Task DeleteArticlesSubmittedForVerification(
        ArticlesSubmittedForVerificationWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Find many Articles Submitted For Verifications
    /// </summary>
    public Task<List<ArticlesSubmittedForVerification>> ArticlesSubmittedForVerifications(
        ArticlesSubmittedForVerificationFindManyArgs findManyArgs
    );

    /// <summary>
    /// Meta data about Articles Submitted For Verification records
    /// </summary>
    public Task<MetadataDto> ArticlesSubmittedForVerificationsMeta(
        ArticlesSubmittedForVerificationFindManyArgs findManyArgs
    );

    /// <summary>
    /// Get one Articles Submitted For Verification
    /// </summary>
    public Task<ArticlesSubmittedForVerification> ArticlesSubmittedForVerification(
        ArticlesSubmittedForVerificationWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Update one Articles Submitted For Verification
    /// </summary>
    public Task UpdateArticlesSubmittedForVerification(
        ArticlesSubmittedForVerificationWhereUniqueInput uniqueId,
        ArticlesSubmittedForVerificationUpdateInput updateDto
    );

    /// <summary>
    /// Connect multiple Common Verification records to Articles Submitted For Verification
    /// </summary>
    public Task ConnectCommonVerification(
        ArticlesSubmittedForVerificationWhereUniqueInput uniqueId,
        CommonVerificationWhereUniqueInput[] commonVerificationsId
    );

    /// <summary>
    /// Disconnect multiple Common Verification records from Articles Submitted For Verification
    /// </summary>
    public Task DisconnectCommonVerification(
        ArticlesSubmittedForVerificationWhereUniqueInput uniqueId,
        CommonVerificationWhereUniqueInput[] commonVerificationsId
    );

    /// <summary>
    /// Find multiple Common Verification records for Articles Submitted For Verification
    /// </summary>
    public Task<List<CommonVerification>> FindCommonVerification(
        ArticlesSubmittedForVerificationWhereUniqueInput uniqueId,
        CommonVerificationFindManyArgs CommonVerificationFindManyArgs
    );

    /// <summary>
    /// Update multiple Common Verification records for Articles Submitted For Verification
    /// </summary>
    public Task UpdateCommonVerification(
        ArticlesSubmittedForVerificationWhereUniqueInput uniqueId,
        CommonVerificationWhereUniqueInput[] commonVerificationsId
    );

    /// <summary>
    /// Connect multiple Taxes For Verification records to Articles Submitted For Verification
    /// </summary>
    public Task ConnectTaxesForVerification(
        ArticlesSubmittedForVerificationWhereUniqueInput uniqueId,
        TaxForVerificationWhereUniqueInput[] taxForVerificationsId
    );

    /// <summary>
    /// Disconnect multiple Taxes For Verification records from Articles Submitted For Verification
    /// </summary>
    public Task DisconnectTaxesForVerification(
        ArticlesSubmittedForVerificationWhereUniqueInput uniqueId,
        TaxForVerificationWhereUniqueInput[] taxForVerificationsId
    );

    /// <summary>
    /// Find multiple Taxes For Verification records for Articles Submitted For Verification
    /// </summary>
    public Task<List<TaxForVerification>> FindTaxesForVerification(
        ArticlesSubmittedForVerificationWhereUniqueInput uniqueId,
        TaxForVerificationFindManyArgs TaxForVerificationFindManyArgs
    );

    /// <summary>
    /// Update multiple Taxes For Verification records for Articles Submitted For Verification
    /// </summary>
    public Task UpdateTaxesForVerification(
        ArticlesSubmittedForVerificationWhereUniqueInput uniqueId,
        TaxForVerificationWhereUniqueInput[] taxForVerificationsId
    );
}
