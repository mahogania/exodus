using Microsoft.AspNetCore.Mvc;

namespace Traveler.APIs;

[ApiController()]
public class TpdEntryAndExitHistoriesController : TpdEntryAndExitHistoriesControllerBase
{
    public TpdEntryAndExitHistoriesController(ITpdEntryAndExitHistoriesService service)
        : base(service) { }
}
