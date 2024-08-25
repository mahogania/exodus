using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[ApiController]
public class CommonDetailedDeclarationCustomsValueAssessmentsController
    : CommonDetailedDeclarationCustomsValueAssessmentsControllerBase
{
    public CommonDetailedDeclarationCustomsValueAssessmentsController(
        ICommonDetailedDeclarationCustomsValueAssessmentsService service
    )
        : base(service)
    {
    }
}
