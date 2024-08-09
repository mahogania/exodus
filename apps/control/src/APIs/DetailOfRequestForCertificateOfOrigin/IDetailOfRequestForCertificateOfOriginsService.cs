using Control.APIs.Common;
using Control.APIs.Dtos;

namespace Control.APIs;

public interface IDetailOfRequestForCertificateOfOriginsService
{
    /// <summary>
    /// Create one DETAIL OF REQUEST FOR CERTIFICATE OF ORIGIN
    /// </summary>
    public Task<DetailOfRequestForCertificateOfOrigin> CreateDetailOfRequestForCertificateOfOrigin(
        DetailOfRequestForCertificateOfOriginCreateInput detailofrequestforcertificateoforigin
    );

    /// <summary>
    /// Delete one DETAIL OF REQUEST FOR CERTIFICATE OF ORIGIN
    /// </summary>
    public Task DeleteDetailOfRequestForCertificateOfOrigin(
        DetailOfRequestForCertificateOfOriginWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Find many DETAIL OF REQUEST FOR CERTIFICATE OF ORIGINS
    /// </summary>
    public Task<List<DetailOfRequestForCertificateOfOrigin>> DetailOfRequestForCertificateOfOrigins(
        DetailOfRequestForCertificateOfOriginFindManyArgs findManyArgs
    );

    /// <summary>
    /// Meta data about DETAIL OF REQUEST FOR CERTIFICATE OF ORIGIN records
    /// </summary>
    public Task<MetadataDto> DetailOfRequestForCertificateOfOriginsMeta(
        DetailOfRequestForCertificateOfOriginFindManyArgs findManyArgs
    );

    /// <summary>
    /// Get one DETAIL OF REQUEST FOR CERTIFICATE OF ORIGIN
    /// </summary>
    public Task<DetailOfRequestForCertificateOfOrigin> DetailOfRequestForCertificateOfOrigin(
        DetailOfRequestForCertificateOfOriginWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Update one DETAIL OF REQUEST FOR CERTIFICATE OF ORIGIN
    /// </summary>
    public Task UpdateDetailOfRequestForCertificateOfOrigin(
        DetailOfRequestForCertificateOfOriginWhereUniqueInput uniqueId,
        DetailOfRequestForCertificateOfOriginUpdateInput updateDto
    );
}
