using Microsoft.AspNetCore.Mvc;

namespace Clre.APIs;

[ApiController()]
public class CustomsDetailedDeclarationValueAssessmentArticlesController
    : CustomsDetailedDeclarationValueAssessmentArticlesControllerBase
{
    public CustomsDetailedDeclarationValueAssessmentArticlesController(
        ICustomsDetailedDeclarationValueAssessmentArticlesService service
    )
        : base(service) { }
}
