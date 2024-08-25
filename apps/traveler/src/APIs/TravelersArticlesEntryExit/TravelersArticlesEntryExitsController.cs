using Microsoft.AspNetCore.Mvc;

namespace Traveler.APIs;

[ApiController()]
public class TravelersArticlesEntryExitsController : TravelersArticlesEntryExitsControllerBase
{
    public TravelersArticlesEntryExitsController(ITravelersArticlesEntryExitsService service)
        : base(service) { }
}
