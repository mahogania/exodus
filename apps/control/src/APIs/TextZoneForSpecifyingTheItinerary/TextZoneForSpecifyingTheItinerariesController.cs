using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[ApiController]
public class TextZoneForSpecifyingTheItinerariesController
    : TextZoneForSpecifyingTheItinerariesControllerBase
{
    public TextZoneForSpecifyingTheItinerariesController(
        ITextZoneForSpecifyingTheItinerariesService service
    )
        : base(service)
    {
    }
}
