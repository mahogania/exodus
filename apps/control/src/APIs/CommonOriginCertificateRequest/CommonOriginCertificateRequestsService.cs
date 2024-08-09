using Clre.Infrastructure;

namespace Clre.APIs;

public class CommonOriginCertificateRequestsService : CommonOriginCertificateRequestsServiceBase
{
    public CommonOriginCertificateRequestsService(ClreDbContext context)
        : base(context) { }
}
