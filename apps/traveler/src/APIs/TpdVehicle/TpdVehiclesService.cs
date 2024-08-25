using Traveler.Infrastructure;

namespace Traveler.APIs;

public class TpdVehiclesService : TpdVehiclesServiceBase
{
    public TpdVehiclesService(TravelerDbContext context)
        : base(context) { }
}
