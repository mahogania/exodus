using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[ApiController()]
public class CommonOriginCertificateRequestsController
    : CommonOriginCertificateRequestsControllerBase
{
    public CommonOriginCertificateRequestsController(
        ICommonOriginCertificateRequestsService service
    )
        : base(service) { }
}
