using Microsoft.AspNetCore.Mvc;

namespace Evaluation.APIs;

[ApiController()]
public class DetailsController : DetailsControllerBase
{
    public DetailsController(IDetailsService service)
        : base(service) { }
}
