using Control.Infrastructure;

namespace Control.APIs;

public class CommonOriginCertificateRequestsService : CommonOriginCertificateRequestsServiceBase
{
    public CommonOriginCertificateRequestsService(ControlDbContext context)
        : base(context)
    {
    }
}
