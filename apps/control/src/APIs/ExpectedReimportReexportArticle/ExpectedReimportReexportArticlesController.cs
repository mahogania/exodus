using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[ApiController()]
public class ExpectedReimportReexportArticlesController
    : ExpectedReimportReexportArticlesControllerBase
{
    public ExpectedReimportReexportArticlesController(
        IExpectedReimportReexportArticlesService service
    )
        : base(service) { }
}
