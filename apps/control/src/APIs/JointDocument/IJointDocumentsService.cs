using Control.APIs.Common;
using Control.APIs.Dtos;

namespace Control.APIs;

public interface IJointDocumentsService
{
    /// <summary>
    /// Create one Joint Document
    /// </summary>
    public Task<JointDocument> CreateJointDocument(JointDocumentCreateInput jointdocument);

    /// <summary>
    /// Delete one Joint Document
    /// </summary>
    public Task DeleteJointDocument(JointDocumentWhereUniqueInput uniqueId);

    /// <summary>
    /// Find many Joint Documents
    /// </summary>
    public Task<List<JointDocument>> JointDocuments(JointDocumentFindManyArgs findManyArgs);

    /// <summary>
    /// Meta data about Joint Document records
    /// </summary>
    public Task<MetadataDto> JointDocumentsMeta(JointDocumentFindManyArgs findManyArgs);

    /// <summary>
    /// Get one Joint Document
    /// </summary>
    public Task<JointDocument> JointDocument(JointDocumentWhereUniqueInput uniqueId);

    /// <summary>
    /// Update one Joint Document
    /// </summary>
    public Task UpdateJointDocument(
        JointDocumentWhereUniqueInput uniqueId,
        JointDocumentUpdateInput updateDto
    );

    /// <summary>
    /// Get a COMMON DETAILED DECLARATION record for JOINT DOCUMENT OF THE DETAILED DECLARATION (CUSTOMS)
    /// </summary>
    public Task<CommonDetailedDeclaration> GetCommonDetailedDeclaration(
        JointDocumentWhereUniqueInput uniqueId
    );
}
