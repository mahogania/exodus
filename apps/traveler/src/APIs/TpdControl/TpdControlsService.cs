using Traveler.Infrastructure;

namespace Traveler.APIs;

public class TpdControlsService : TpdControlsServiceBase
{
    public TpdControlsService(TravelerDbContext context)
        : base(context) { }
}
