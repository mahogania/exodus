using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[ApiController()]
public class ItinerariesController : ItinerariesControllerBase
{
    public ItinerariesController(IItinerariesService service)
        : base(service) { }
}
