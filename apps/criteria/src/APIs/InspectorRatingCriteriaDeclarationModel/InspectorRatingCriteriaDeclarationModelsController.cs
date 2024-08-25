using Microsoft.AspNetCore.Mvc;

namespace Criteria.APIs;

[ApiController()]
public class InspectorRatingCriteriaDeclarationModelsController
    : InspectorRatingCriteriaDeclarationModelsControllerBase
{
    public InspectorRatingCriteriaDeclarationModelsController(
        IInspectorRatingCriteriaDeclarationModelsService service
    )
        : base(service) { }
}
