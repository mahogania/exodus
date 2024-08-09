using Clre.Infrastructure;

namespace Clre.APIs;

public class DetailOfRequestForCertificateOfOriginsService
    : DetailOfRequestForCertificateOfOriginsServiceBase
{
    public DetailOfRequestForCertificateOfOriginsService(ClreDbContext context)
        : base(context) { }
}
