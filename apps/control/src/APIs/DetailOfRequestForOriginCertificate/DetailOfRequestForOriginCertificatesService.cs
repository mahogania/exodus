using Control.Infrastructure;

namespace Control.APIs;

public class DetailOfRequestForOriginCertificatesService
    : DetailOfRequestForOriginCertificatesServiceBase
{
    public DetailOfRequestForOriginCertificatesService(ControlDbContext context)
        : base(context) { }
}
