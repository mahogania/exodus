using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[ApiController()]
public class VerificationResultsController : VerificationResultsControllerBase
{
    public VerificationResultsController(IVerificationResultsService service)
        : base(service) { }
}
