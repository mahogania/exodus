using Control.APIs.Common;
using Control.APIs.Dtos;

namespace Control.APIs;

public interface IDetailOfRequestForOriginCertificatesService
{
    /// <summary>
    /// Create one Detail of Request for Origin Certificate
    /// </summary>
    public Task<DetailOfRequestForOriginCertificate> CreateDetailOfRequestForOriginCertificate(
        DetailOfRequestForOriginCertificateCreateInput detailofrequestfororigincertificate
    );

    /// <summary>
    /// Delete one Detail of Request for Origin Certificate
    /// </summary>
    public Task DeleteDetailOfRequestForOriginCertificate(
        DetailOfRequestForOriginCertificateWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Find many DETAIL OF REQUEST FOR CERTIFICATE OF ORIGINS
    /// </summary>
    public Task<List<DetailOfRequestForOriginCertificate>> DetailOfRequestForOriginCertificates(
        DetailOfRequestForOriginCertificateFindManyArgs findManyArgs
    );

    /// <summary>
    /// Meta data about Detail of Request for Origin Certificate records
    /// </summary>
    public Task<MetadataDto> DetailOfRequestForOriginCertificatesMeta(
        DetailOfRequestForOriginCertificateFindManyArgs findManyArgs
    );

    /// <summary>
    /// Get one Detail of Request for Origin Certificate
    /// </summary>
    public Task<DetailOfRequestForOriginCertificate> DetailOfRequestForOriginCertificate(
        DetailOfRequestForOriginCertificateWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Update one Detail of Request for Origin Certificate
    /// </summary>
    public Task UpdateDetailOfRequestForOriginCertificate(
        DetailOfRequestForOriginCertificateWhereUniqueInput uniqueId,
        DetailOfRequestForOriginCertificateUpdateInput updateDto
    );

    /// <summary>
    /// Get a Common Origin Certificate Request record for Detail of Request for Origin Certificate
    /// </summary>
    public Task<CommonOriginCertificateRequest> GetCommonOriginCertificateRequest(
        DetailOfRequestForOriginCertificateWhereUniqueInput uniqueId
    );
}
