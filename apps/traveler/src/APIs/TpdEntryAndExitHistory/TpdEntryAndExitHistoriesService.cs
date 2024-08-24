using Traveler.Infrastructure;

namespace Traveler.APIs;

public class TpdEntryAndExitHistoriesService : TpdEntryAndExitHistoriesServiceBase
{
    public TpdEntryAndExitHistoriesService(TravelerDbContext context)
        : base(context) { }
}
