using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[ApiController]
public class CustomsDetailedDeclarationValueAssessmentArticlesController
    : CustomsDetailedDeclarationValueAssessmentArticlesControllerBase
{
    public CustomsDetailedDeclarationValueAssessmentArticlesController(
        ICustomsDetailedDeclarationValueAssessmentArticlesService service
    )
        : base(service)
    {
    }
}
