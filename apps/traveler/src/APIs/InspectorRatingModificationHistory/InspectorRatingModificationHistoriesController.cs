using Microsoft.AspNetCore.Mvc;

namespace Traveler.APIs;

[ApiController()]
public class InspectorRatingModificationHistoriesController
    : InspectorRatingModificationHistoriesControllerBase
{
    public InspectorRatingModificationHistoriesController(
        IInspectorRatingModificationHistoriesService service
    )
        : base(service) { }
}
