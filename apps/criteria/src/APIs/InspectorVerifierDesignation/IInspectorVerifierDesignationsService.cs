using Criteria.APIs.Common;
using Criteria.APIs.Dtos;

namespace Criteria.APIs;

public interface IInspectorVerifierDesignationsService
{
    /// <summary>
    /// Create one Inspector Verifier Designation
    /// </summary>
    public Task<InspectorVerifierDesignation> CreateInspectorVerifierDesignation(
        InspectorVerifierDesignationCreateInput inspectorverifierdesignation
    );

    /// <summary>
    /// Delete one Inspector Verifier Designation
    /// </summary>
    public Task DeleteInspectorVerifierDesignation(
        InspectorVerifierDesignationWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Find many Inspector Verifier Designations
    /// </summary>
    public Task<List<InspectorVerifierDesignation>> InspectorVerifierDesignations(
        InspectorVerifierDesignationFindManyArgs findManyArgs
    );

    /// <summary>
    /// Meta data about Inspector Verifier Designation records
    /// </summary>
    public Task<MetadataDto> InspectorVerifierDesignationsMeta(
        InspectorVerifierDesignationFindManyArgs findManyArgs
    );

    /// <summary>
    /// Get one Inspector Verifier Designation
    /// </summary>
    public Task<InspectorVerifierDesignation> InspectorVerifierDesignation(
        InspectorVerifierDesignationWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Update one Inspector Verifier Designation
    /// </summary>
    public Task UpdateInspectorVerifierDesignation(
        InspectorVerifierDesignationWhereUniqueInput uniqueId,
        InspectorVerifierDesignationUpdateInput updateDto
    );
}
