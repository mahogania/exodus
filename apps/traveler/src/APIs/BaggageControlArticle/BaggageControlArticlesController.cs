using Microsoft.AspNetCore.Mvc;

namespace Traveler.APIs;

[ApiController()]
public class BaggageControlArticlesController : BaggageControlArticlesControllerBase
{
    public BaggageControlArticlesController(IBaggageControlArticlesService service)
        : base(service) { }
}
