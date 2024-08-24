using Traveler.Infrastructure;

namespace Traveler.APIs;

public class TravelerSearchHistoriesService : TravelerSearchHistoriesServiceBase
{
    public TravelerSearchHistoriesService(TravelerDbContext context)
        : base(context) { }
}
