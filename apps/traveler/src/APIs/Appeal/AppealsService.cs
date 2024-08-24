using Traveler.Infrastructure;

namespace Traveler.APIs;

public class AppealsService : AppealsServiceBase
{
    public AppealsService(TravelerDbContext context)
        : base(context) { }
}
