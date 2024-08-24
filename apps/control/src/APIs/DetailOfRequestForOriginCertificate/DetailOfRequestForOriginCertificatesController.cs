using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[ApiController()]
public class DetailOfRequestForOriginCertificatesController
    : DetailOfRequestForOriginCertificatesControllerBase
{
    public DetailOfRequestForOriginCertificatesController(
        IDetailOfRequestForOriginCertificatesService service
    )
        : base(service) { }
}
