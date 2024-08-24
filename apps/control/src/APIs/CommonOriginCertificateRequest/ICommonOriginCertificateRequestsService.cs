using Control.APIs.Common;
using Control.APIs.Dtos;

namespace Control.APIs;

public interface ICommonOriginCertificateRequestsService
{
    /// <summary>
    /// Create one Common Origin Certificate Request
    /// </summary>
    public Task<CommonOriginCertificateRequest> CreateCommonOriginCertificateRequest(
        CommonOriginCertificateRequestCreateInput commonorigincertificaterequest
    );

    /// <summary>
    /// Delete one Common Origin Certificate Request
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
    /// Meta data about Common Origin Certificate Request records
    /// </summary>
    public Task<MetadataDto> CommonOriginCertificateRequestsMeta(
        CommonOriginCertificateRequestFindManyArgs findManyArgs
    );

    /// <summary>
    /// Get one Common Origin Certificate Request
    /// </summary>
    public Task<CommonOriginCertificateRequest> CommonOriginCertificateRequest(
        CommonOriginCertificateRequestWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Update one Common Origin Certificate Request
    /// </summary>
    public Task UpdateCommonOriginCertificateRequest(
        CommonOriginCertificateRequestWhereUniqueInput uniqueId,
        CommonOriginCertificateRequestUpdateInput updateDto
    );

    /// <summary>
    /// Get a Request record for Common Origin Certificate Request
    /// </summary>
    public Task<Journal> GetRequest(CommonOriginCertificateRequestWhereUniqueInput uniqueId);
}
