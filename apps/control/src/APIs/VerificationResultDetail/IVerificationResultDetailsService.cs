using Control.APIs.Common;
using Control.APIs.Dtos;

namespace Control.APIs;

public interface IVerificationResultDetailsService
{
    /// <summary>
    /// Create one Verification Result Detail
    /// </summary>
    public Task<VerificationResultDetail> CreateVerificationResultDetail(
        VerificationResultDetailCreateInput verificationresultdetail
    );

    /// <summary>
    /// Delete one Verification Result Detail
    /// </summary>
    public Task DeleteVerificationResultDetail(VerificationResultDetailWhereUniqueInput uniqueId);

    /// <summary>
    /// Find many Verification Result Details
    /// </summary>
    public Task<List<VerificationResultDetail>> VerificationResultDetails(
        VerificationResultDetailFindManyArgs findManyArgs
    );

    /// <summary>
    /// Meta data about Verification Result Detail records
    /// </summary>
    public Task<MetadataDto> VerificationResultDetailsMeta(
        VerificationResultDetailFindManyArgs findManyArgs
    );

    /// <summary>
    /// Get one Verification Result Detail
    /// </summary>
    public Task<VerificationResultDetail> VerificationResultDetail(
        VerificationResultDetailWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Update one Verification Result Detail
    /// </summary>
    public Task UpdateVerificationResultDetail(
        VerificationResultDetailWhereUniqueInput uniqueId,
        VerificationResultDetailUpdateInput updateDto
    );

    /// <summary>
    /// Get a Verification Result record for Verification Result Detail
    /// </summary>
    public Task<VerificationResult> GetVerificationResult(
        VerificationResultDetailWhereUniqueInput uniqueId
    );
}
