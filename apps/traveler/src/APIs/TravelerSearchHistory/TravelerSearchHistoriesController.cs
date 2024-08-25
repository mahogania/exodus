using Microsoft.AspNetCore.Mvc;

namespace Traveler.APIs;

[ApiController()]
public class TravelerSearchHistoriesController : TravelerSearchHistoriesControllerBase
{
    public TravelerSearchHistoriesController(ITravelerSearchHistoriesService service)
        : base(service) { }
}
