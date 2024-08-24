using Traveler.Infrastructure;

namespace Traveler.APIs;

public class BaggageControlArticlesService : BaggageControlArticlesServiceBase
{
    public BaggageControlArticlesService(TravelerDbContext context)
        : base(context) { }
}
