using Traveler.Infrastructure;

namespace Traveler.APIs;

public class GeneralTravelerInformationTpdsService : GeneralTravelerInformationTpdsServiceBase
{
    public GeneralTravelerInformationTpdsService(TravelerDbContext context)
        : base(context) { }
}
