using Microsoft.AspNetCore.Mvc;

namespace Collection.APIs;

[ApiController()]
public class CreditsController : CreditsControllerBase
{
    public CreditsController(ICreditsService service)
        : base(service) { }
}
