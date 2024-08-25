using Microsoft.AspNetCore.Mvc;

namespace Criteria.APIs;

[ApiController()]
public class InspectorRatingCriteriaController : InspectorRatingCriteriaControllerBase
{
    public InspectorRatingCriteriaController(IInspectorRatingCriteriaService service)
        : base(service) { }
}
