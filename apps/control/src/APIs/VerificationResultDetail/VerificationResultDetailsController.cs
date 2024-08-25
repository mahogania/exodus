using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[ApiController()]
public class VerificationResultDetailsController : VerificationResultDetailsControllerBase
{
    public VerificationResultDetailsController(IVerificationResultDetailsService service)
        : base(service) { }
}
