using Microsoft.AspNetCore.Mvc;

namespace Clre.APIs;

[ApiController()]
public class TextZoneForSpecifyingTheItinerariesController
    : TextZoneForSpecifyingTheItinerariesControllerBase
{
    public TextZoneForSpecifyingTheItinerariesController(
        ITextZoneForSpecifyingTheItinerariesService service
    )
        : base(service) { }
}
