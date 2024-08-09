using Clre.APIs.Common;
using Clre.APIs.Dtos;

namespace Clre.APIs;

public interface ICommonOriginCertificateRequestsService
{
    /// <summary>
    /// Create one COMMON ORIGIN CERTIFICATE REQUEST
    /// </summary>
    public Task<CommonOriginCertificateRequest> CreateCommonOriginCertificateRequest(
        CommonOriginCertificateRequestCreateInput commonorigincertificaterequest
    );

    /// <summary>
    /// Delete one COMMON ORIGIN CERTIFICATE REQUEST
    /// </summary>
    public Task DeleteCommonOriginCertificateRequest(
        CommonOriginCertificateRequestWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Find many COMMON ORIGIN CERTIFICATE REQUESTS
    /// </summary>
    public Task<List<CommonOriginCertificateRequest>> CommonOriginCertificateRequests(
        CommonOriginCertificateRequestFindManyArgs findManyArgs
    );

    /// <summary>
    /// Meta data about COMMON ORIGIN CERTIFICATE REQUEST records
    /// </summary>
    public Task<MetadataDto> CommonOriginCertificateRequestsMeta(
        CommonOriginCertificateRequestFindManyArgs findManyArgs
    );

    /// <summary>
    /// Get one COMMON ORIGIN CERTIFICATE REQUEST
    /// </summary>
    public Task<CommonOriginCertificateRequest> CommonOriginCertificateRequest(
        CommonOriginCertificateRequestWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Update one COMMON ORIGIN CERTIFICATE REQUEST
    /// </summary>
    public Task UpdateCommonOriginCertificateRequest(
        CommonOriginCertificateRequestWhereUniqueInput uniqueId,
        CommonOriginCertificateRequestUpdateInput updateDto
    );
}
