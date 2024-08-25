using Microsoft.AspNetCore.Mvc;

namespace Criteria.APIs;

[ApiController()]
public class InspectorRatingCriteriaInspectorsController
    : InspectorRatingCriteriaInspectorsControllerBase
{
    public InspectorRatingCriteriaInspectorsController(
        IInspectorRatingCriteriaInspectorsService service
    )
        : base(service) { }
}
