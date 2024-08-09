using Microsoft.AspNetCore.Mvc;

namespace Collection.APIs;

[ApiController()]
public class DetailsController : DetailsControllerBase
{
    public DetailsController(IDetailsService service)
        : base(service) { }
}
