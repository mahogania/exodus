using Control.APIs.Common;
using Control.APIs.Dtos;

namespace Control.APIs;

public interface ICommonVerificationsService
{
    /// <summary>
    /// Create one Common Verification
    /// </summary>
    public Task<CommonVerification> CreateCommonVerification(
        CommonVerificationCreateInput commonverification
    );

    /// <summary>
    /// Delete one Common Verification
    /// </summary>
    public Task DeleteCommonVerification(CommonVerificationWhereUniqueInput uniqueId);

    /// <summary>
    /// Find many Common Verification Of The Evaluation Of Values Of The Detailed Declarations
    /// </summary>
    public Task<List<CommonVerification>> CommonVerifications(
        CommonVerificationFindManyArgs findManyArgs
    );

    /// <summary>
    /// Meta data about Common Verification records
    /// </summary>
    public Task<MetadataDto> CommonVerificationsMeta(CommonVerificationFindManyArgs findManyArgs);

    /// <summary>
    /// Get one Common Verification
    /// </summary>
    public Task<CommonVerification> CommonVerification(CommonVerificationWhereUniqueInput uniqueId);

    /// <summary>
    /// Update one Common Verification
    /// </summary>
    public Task UpdateCommonVerification(
        CommonVerificationWhereUniqueInput uniqueId,
        CommonVerificationUpdateInput updateDto
    );

    /// <summary>
    /// Get a Appeal record for Common Verification
    /// </summary>
    public Task<Appeal> GetAppeal(CommonVerificationWhereUniqueInput uniqueId);

    /// <summary>
    /// Get a Articles Submitted For Verification record for Common Verification
    /// </summary>
    public Task<ArticlesSubmittedForVerification> GetArticlesSubmittedForVerification(
        CommonVerificationWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Connect multiple Container Value Assessments records to Common Verification
    /// </summary>
    public Task ConnectContainerValueAssessments(
        CommonVerificationWhereUniqueInput uniqueId,
        ContainerValueAssessmentWhereUniqueInput[] containerValueAssessmentsId
    );

    /// <summary>
    /// Disconnect multiple Container Value Assessments records from Common Verification
    /// </summary>
    public Task DisconnectContainerValueAssessments(
        CommonVerificationWhereUniqueInput uniqueId,
        ContainerValueAssessmentWhereUniqueInput[] containerValueAssessmentsId
    );

    /// <summary>
    /// Find multiple Container Value Assessments records for Common Verification
    /// </summary>
    public Task<List<ContainerValueAssessment>> FindContainerValueAssessments(
        CommonVerificationWhereUniqueInput uniqueId,
        ContainerValueAssessmentFindManyArgs ContainerValueAssessmentFindManyArgs
    );

    /// <summary>
    /// Update multiple Container Value Assessments records for Common Verification
    /// </summary>
    public Task UpdateContainerValueAssessments(
        CommonVerificationWhereUniqueInput uniqueId,
        ContainerValueAssessmentWhereUniqueInput[] containerValueAssessmentsId
    );

    /// <summary>
    /// Connect multiple Taxes For Verification records to Common Verification
    /// </summary>
    public Task ConnectTaxesForVerification(
        CommonVerificationWhereUniqueInput uniqueId,
        TaxForVerificationWhereUniqueInput[] taxForVerificationsId
    );

    /// <summary>
    /// Disconnect multiple Taxes For Verification records from Common Verification
    /// </summary>
    public Task DisconnectTaxesForVerification(
        CommonVerificationWhereUniqueInput uniqueId,
        TaxForVerificationWhereUniqueInput[] taxForVerificationsId
    );

    /// <summary>
    /// Find multiple Taxes For Verification records for Common Verification
    /// </summary>
    public Task<List<TaxForVerification>> FindTaxesForVerification(
        CommonVerificationWhereUniqueInput uniqueId,
        TaxForVerificationFindManyArgs TaxForVerificationFindManyArgs
    );

    /// <summary>
    /// Update multiple Taxes For Verification records for Common Verification
    /// </summary>
    public Task UpdateTaxesForVerification(
        CommonVerificationWhereUniqueInput uniqueId,
        TaxForVerificationWhereUniqueInput[] taxForVerificationsId
    );

    /// <summary>
    /// Get a Verification Result record for Common Verification
    /// </summary>
    public Task<VerificationResult> GetVerificationResult(
        CommonVerificationWhereUniqueInput uniqueId
    );
}
