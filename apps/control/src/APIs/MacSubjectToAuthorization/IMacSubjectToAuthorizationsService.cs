using Control.APIs.Common;
using Control.APIs.Dtos;

namespace Control.APIs;

public interface IMacSubjectToAuthorizationsService
{
    /// <summary>
    /// Create one MAC SUBJECT TO AUTHORIZATION
    /// </summary>
    public Task<MacSubjectToAuthorization> CreateMacSubjectToAuthorization(
        MacSubjectToAuthorizationCreateInput macsubjecttoauthorization
    );

    /// <summary>
    /// Delete one MAC SUBJECT TO AUTHORIZATION
    /// </summary>
    public Task DeleteMacSubjectToAuthorization(MacSubjectToAuthorizationWhereUniqueInput uniqueId);

    /// <summary>
    /// Find many MAC SUBJECT TO AUTHORIZATIONS
    /// </summary>
    public Task<List<MacSubjectToAuthorization>> MacSubjectToAuthorizations(
        MacSubjectToAuthorizationFindManyArgs findManyArgs
    );

    /// <summary>
    /// Meta data about MAC SUBJECT TO AUTHORIZATION records
    /// </summary>
    public Task<MetadataDto> MacSubjectToAuthorizationsMeta(
        MacSubjectToAuthorizationFindManyArgs findManyArgs
    );

    /// <summary>
    /// Get one MAC SUBJECT TO AUTHORIZATION
    /// </summary>
    public Task<MacSubjectToAuthorization> MacSubjectToAuthorization(
        MacSubjectToAuthorizationWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Update one MAC SUBJECT TO AUTHORIZATION
    /// </summary>
    public Task UpdateMacSubjectToAuthorization(
        MacSubjectToAuthorizationWhereUniqueInput uniqueId,
        MacSubjectToAuthorizationUpdateInput updateDto
    );
}
