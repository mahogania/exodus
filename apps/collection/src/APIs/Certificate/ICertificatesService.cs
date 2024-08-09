using Collection.APIs.Common;
using Collection.APIs.Dtos;

namespace Collection.APIs;

public interface ICertificatesService
{
    /// <summary>
    /// Create one CERTIFICATE
    /// </summary>
    public Task<Certificate> CreateCertificate(CertificateCreateInput certificate);

    /// <summary>
    /// Delete one CERTIFICATE
    /// </summary>
    public Task DeleteCertificate(CertificateWhereUniqueInput uniqueId);

    /// <summary>
    /// Find many CERTIFICATES
    /// </summary>
    public Task<List<Certificate>> Certificates(CertificateFindManyArgs findManyArgs);

    /// <summary>
    /// Meta data about CERTIFICATE records
    /// </summary>
    public Task<MetadataDto> CertificatesMeta(CertificateFindManyArgs findManyArgs);

    /// <summary>
    /// Get one CERTIFICATE
    /// </summary>
    public Task<Certificate> Certificate(CertificateWhereUniqueInput uniqueId);

    /// <summary>
    /// Update one CERTIFICATE
    /// </summary>
    public Task UpdateCertificate(
        CertificateWhereUniqueInput uniqueId,
        CertificateUpdateInput updateDto
    );
}
