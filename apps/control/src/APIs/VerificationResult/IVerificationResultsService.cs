using Control.APIs.Common;
using Control.APIs.Dtos;

namespace Control.APIs;

public interface IVerificationResultsService
{
    /// <summary>
    /// Create one Verification Result
    /// </summary>
    public Task<VerificationResult> CreateVerificationResult(
        VerificationResultCreateInput verificationresult
    );

    /// <summary>
    /// Delete one Verification Result
    /// </summary>
    public Task DeleteVerificationResult(VerificationResultWhereUniqueInput uniqueId);

    /// <summary>
    /// Find many Verification Results
    /// </summary>
    public Task<List<VerificationResult>> VerificationResults(
        VerificationResultFindManyArgs findManyArgs
    );

    /// <summary>
    /// Meta data about Verification Result records
    /// </summary>
    public Task<MetadataDto> VerificationResultsMeta(VerificationResultFindManyArgs findManyArgs);

    /// <summary>
    /// Get one Verification Result
    /// </summary>
    public Task<VerificationResult> VerificationResult(VerificationResultWhereUniqueInput uniqueId);

    /// <summary>
    /// Update one Verification Result
    /// </summary>
    public Task UpdateVerificationResult(
        VerificationResultWhereUniqueInput uniqueId,
        VerificationResultUpdateInput updateDto
    );

    /// <summary>
    /// Get a Common Verification record for Verification Result
    /// </summary>
    public Task<CommonVerification> GetCommonVerification(
        VerificationResultWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Connect multiple Verification Result Details records to Verification Result
    /// </summary>
    public Task ConnectVerificationResultDetails(
        VerificationResultWhereUniqueInput uniqueId,
        VerificationResultDetailWhereUniqueInput[] verificationResultDetailsId
    );

    /// <summary>
    /// Disconnect multiple Verification Result Details records from Verification Result
    /// </summary>
    public Task DisconnectVerificationResultDetails(
        VerificationResultWhereUniqueInput uniqueId,
        VerificationResultDetailWhereUniqueInput[] verificationResultDetailsId
    );

    /// <summary>
    /// Find multiple Verification Result Details records for Verification Result
    /// </summary>
    public Task<List<VerificationResultDetail>> FindVerificationResultDetails(
        VerificationResultWhereUniqueInput uniqueId,
        VerificationResultDetailFindManyArgs VerificationResultDetailFindManyArgs
    );

    /// <summary>
    /// Update multiple Verification Result Details records for Verification Result
    /// </summary>
    public Task UpdateVerificationResultDetails(
        VerificationResultWhereUniqueInput uniqueId,
        VerificationResultDetailWhereUniqueInput[] verificationResultDetailsId
    );
}
