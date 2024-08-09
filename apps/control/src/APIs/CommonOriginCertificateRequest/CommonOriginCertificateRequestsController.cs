using Microsoft.AspNetCore.Mvc;

namespace Clre.APIs;

[ApiController()]
public class CommonOriginCertificateRequestsController
    : CommonOriginCertificateRequestsControllerBase
{
    public CommonOriginCertificateRequestsController(
        ICommonOriginCertificateRequestsService service
    )
        : base(service) { }
}
