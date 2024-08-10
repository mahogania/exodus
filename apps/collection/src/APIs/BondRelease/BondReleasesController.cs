using Microsoft.AspNetCore.Mvc;

namespace Collection.APIs;

[ApiController]
public class BondReleasesController : BondReleasesControllerBase
{
    public BondReleasesController(IBondReleasesService service)
        : base(service)
    {
    }
}
