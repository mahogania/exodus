using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[ApiController()]
public class DetailOfRequestForCertificateOfOriginsController
    : DetailOfRequestForCertificateOfOriginsControllerBase
{
    public DetailOfRequestForCertificateOfOriginsController(
        IDetailOfRequestForCertificateOfOriginsService service
    )
        : base(service) { }
}
