using Microsoft.AspNetCore.Mvc;

namespace Fret.APIs;

[ApiController()]
public class ManifestsController : ManifestsControllerBase
{
    public ManifestsController(IManifestsService service)
        : base(service) { }
}
