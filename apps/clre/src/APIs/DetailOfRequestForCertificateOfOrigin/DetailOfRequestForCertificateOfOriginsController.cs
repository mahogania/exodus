using Microsoft.AspNetCore.Mvc;

namespace Clre.APIs;

[ApiController()]
public class DetailOfRequestForCertificateOfOriginsController
    : DetailOfRequestForCertificateOfOriginsControllerBase
{
    public DetailOfRequestForCertificateOfOriginsController(
        IDetailOfRequestForCertificateOfOriginsService service
    )
        : base(service) { }
}
