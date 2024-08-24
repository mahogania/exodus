using Control.Infrastructure;

namespace Control.APIs;

public class ItinerariesService : ItinerariesServiceBase
{
    public ItinerariesService(ControlDbContext context)
        : base(context) { }
}
