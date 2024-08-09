using Microsoft.AspNetCore.Mvc;

namespace Clre.APIs;

[ApiController()]
public class CommonDetailedDeclarationCustomsValueAssessmentsController
    : CommonDetailedDeclarationCustomsValueAssessmentsControllerBase
{
    public CommonDetailedDeclarationCustomsValueAssessmentsController(
        ICommonDetailedDeclarationCustomsValueAssessmentsService service
    )
        : base(service) { }
}
