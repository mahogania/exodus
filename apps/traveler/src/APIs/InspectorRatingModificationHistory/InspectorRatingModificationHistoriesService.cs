using Traveler.Infrastructure;

namespace Traveler.APIs;

public class InspectorRatingModificationHistoriesService
    : InspectorRatingModificationHistoriesServiceBase
{
    public InspectorRatingModificationHistoriesService(TravelerDbContext context)
        : base(context) { }
}
