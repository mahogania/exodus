using Microsoft.AspNetCore.Mvc;

namespace Collection.APIs;

[ApiController]
public class CertificatesController : CertificatesControllerBase
{
    public CertificatesController(ICertificatesService service)
        : base(service)
    {
    }
}
