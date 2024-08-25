using Control.APIs.Common;
using Control.APIs.Dtos;

namespace Control.APIs;

public interface IModelValueEvaluationVerificationsService
{
    /// <summary>
    /// Create one Model Value Evaluation Verification
    /// </summary>
    public Task<ModelValueEvaluationVerification> CreateModelValueEvaluationVerification(
        ModelValueEvaluationVerificationCreateInput modelvalueevaluationverification
    );

    /// <summary>
    /// Delete one Model Value Evaluation Verification
    /// </summary>
    public Task DeleteModelValueEvaluationVerification(
        ModelValueEvaluationVerificationWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Find many Value Evaluation Model Verifications
    /// </summary>
    public Task<List<ModelValueEvaluationVerification>> ModelValueEvaluationVerifications(
        ModelValueEvaluationVerificationFindManyArgs findManyArgs
    );

    /// <summary>
    /// Meta data about Model Value Evaluation Verification records
    /// </summary>
    public Task<MetadataDto> ModelValueEvaluationVerificationsMeta(
        ModelValueEvaluationVerificationFindManyArgs findManyArgs
    );

    /// <summary>
    /// Get one Model Value Evaluation Verification
    /// </summary>
    public Task<ModelValueEvaluationVerification> ModelValueEvaluationVerification(
        ModelValueEvaluationVerificationWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Update one Model Value Evaluation Verification
    /// </summary>
    public Task UpdateModelValueEvaluationVerification(
        ModelValueEvaluationVerificationWhereUniqueInput uniqueId,
        ModelValueEvaluationVerificationUpdateInput updateDto
    );

    /// <summary>
    /// Get a Articles Submitted For Verification record for Model Value Evaluation Verification
    /// </summary>
    public Task<ArticlesSubmittedForVerification> GetArticlesSubmittedForVerification(
        ModelValueEvaluationVerificationWhereUniqueInput uniqueId
    );
}
