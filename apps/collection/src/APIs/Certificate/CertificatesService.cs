using Collection.Infrastructure;

namespace Collection.APIs;

public class CertificatesService : CertificatesServiceBase
{
    public CertificatesService(CollectionDbContext context)
        : base(context) { }
}
