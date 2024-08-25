using Control.Infrastructure;

namespace Control.APIs;

public class TextZoneForSpecifyingTheItinerariesService
    : TextZoneForSpecifyingTheItinerariesServiceBase
{
    public TextZoneForSpecifyingTheItinerariesService(ControlDbContext context)
        : base(context)
    {
    }
}
