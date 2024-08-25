using Traveler.Infrastructure;

namespace Traveler.APIs;

public class AccompaniedBaggageEntryAndExitsService : AccompaniedBaggageEntryAndExitsServiceBase
{
    public AccompaniedBaggageEntryAndExitsService(TravelerDbContext context)
        : base(context) { }
}
