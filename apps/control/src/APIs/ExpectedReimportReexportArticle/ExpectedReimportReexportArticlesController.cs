using Microsoft.AspNetCore.Mvc;

namespace Clre.APIs;

[ApiController()]
public class ExpectedReimportReexportArticlesController
    : ExpectedReimportReexportArticlesControllerBase
{
    public ExpectedReimportReexportArticlesController(
        IExpectedReimportReexportArticlesService service
    )
        : base(service) { }
}
