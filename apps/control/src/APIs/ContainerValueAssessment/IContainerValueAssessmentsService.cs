using Control.APIs.Common;
using Control.APIs.Dtos;

namespace Control.APIs;

public interface IContainerValueAssessmentsService
{
    /// <summary>
    /// Create one Container Value Assessment
    /// </summary>
    public Task<ContainerValueAssessment> CreateContainerValueAssessment(
        ContainerValueAssessmentCreateInput containervalueassessment
    );

    /// <summary>
    /// Delete one Container Value Assessment
    /// </summary>
    public Task DeleteContainerValueAssessment(ContainerValueAssessmentWhereUniqueInput uniqueId);

    /// <summary>
    /// Find many Value Evaluation_Containers
    /// </summary>
    public Task<List<ContainerValueAssessment>> ContainerValueAssessments(
        ContainerValueAssessmentFindManyArgs findManyArgs
    );

    /// <summary>
    /// Meta data about Container Value Assessment records
    /// </summary>
    public Task<MetadataDto> ContainerValueAssessmentsMeta(
        ContainerValueAssessmentFindManyArgs findManyArgs
    );

    /// <summary>
    /// Get one Container Value Assessment
    /// </summary>
    public Task<ContainerValueAssessment> ContainerValueAssessment(
        ContainerValueAssessmentWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Update one Container Value Assessment
    /// </summary>
    public Task UpdateContainerValueAssessment(
        ContainerValueAssessmentWhereUniqueInput uniqueId,
        ContainerValueAssessmentUpdateInput updateDto
    );

    /// <summary>
    /// Get a Common Verification record for Container Value Assessment
    /// </summary>
    public Task<CommonVerification> GetCommonVerification(
        ContainerValueAssessmentWhereUniqueInput uniqueId
    );
}
