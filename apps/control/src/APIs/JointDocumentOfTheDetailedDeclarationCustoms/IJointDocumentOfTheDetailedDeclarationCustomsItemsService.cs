using Control.APIs.Common;
using Control.APIs.Dtos;

namespace Control.APIs;

public interface IJointDocumentOfTheDetailedDeclarationCustomsItemsService
{
    /// <summary>
    /// Create one JOINT DOCUMENT OF THE DETAILED DECLARATION (CUSTOMS)
    /// </summary>
    public Task<JointDocumentOfTheDetailedDeclarationCustoms> CreateJointDocumentOfTheDetailedDeclarationCustoms(
        JointDocumentOfTheDetailedDeclarationCustomsCreateInput jointdocumentofthedetaileddeclarationcustoms
    );

    /// <summary>
    /// Delete one JOINT DOCUMENT OF THE DETAILED DECLARATION (CUSTOMS)
    /// </summary>
    public Task DeleteJointDocumentOfTheDetailedDeclarationCustoms(
        JointDocumentOfTheDetailedDeclarationCustomsWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Find many JOINT DOCUMENT OF THE DETAILED DECLARATION (CUSTOMS)s
    /// </summary>
    public Task<
        List<JointDocumentOfTheDetailedDeclarationCustoms>
    > JointDocumentOfTheDetailedDeclarationCustomsItems(
        JointDocumentOfTheDetailedDeclarationCustomsFindManyArgs findManyArgs
    );

    /// <summary>
    /// Meta data about JOINT DOCUMENT OF THE DETAILED DECLARATION (CUSTOMS) records
    /// </summary>
    public Task<MetadataDto> JointDocumentOfTheDetailedDeclarationCustomsItemsMeta(
        JointDocumentOfTheDetailedDeclarationCustomsFindManyArgs findManyArgs
    );

    /// <summary>
    /// Get one JOINT DOCUMENT OF THE DETAILED DECLARATION (CUSTOMS)
    /// </summary>
    public Task<JointDocumentOfTheDetailedDeclarationCustoms> JointDocumentOfTheDetailedDeclarationCustoms(
        JointDocumentOfTheDetailedDeclarationCustomsWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Update one JOINT DOCUMENT OF THE DETAILED DECLARATION (CUSTOMS)
    /// </summary>
    public Task UpdateJointDocumentOfTheDetailedDeclarationCustoms(
        JointDocumentOfTheDetailedDeclarationCustomsWhereUniqueInput uniqueId,
        JointDocumentOfTheDetailedDeclarationCustomsUpdateInput updateDto
    );
}
