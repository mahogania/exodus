using Control.Infrastructure;

namespace Control.APIs;

public class DetailOfRequestForCertificateOfOriginsService
    : DetailOfRequestForCertificateOfOriginsServiceBase
{
    public DetailOfRequestForCertificateOfOriginsService(ControlDbContext context)
        : base(context)
    {
    }
}
