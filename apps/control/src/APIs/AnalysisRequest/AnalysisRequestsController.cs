using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[ApiController()]
public class AnalysisRequestsController : AnalysisRequestsControllerBase
{
    public AnalysisRequestsController(IAnalysisRequestsService service)
        : base(service) { }
}
