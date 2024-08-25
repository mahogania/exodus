using Traveler.Infrastructure;

namespace Traveler.APIs;

public class TravelersArticlesEntryExitsService : TravelersArticlesEntryExitsServiceBase
{
    public TravelersArticlesEntryExitsService(TravelerDbContext context)
        : base(context) { }
}
