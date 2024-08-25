using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[ApiController()]
public class SampleRequestsController : SampleRequestsControllerBase
{
    public SampleRequestsController(ISampleRequestsService service)
        : base(service) { }
}
