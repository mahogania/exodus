using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[ApiController()]
public class RequestForCommonCarnetsController : RequestForCommonCarnetsControllerBase
{
    public RequestForCommonCarnetsController(IRequestForCommonCarnetsService service)
        : base(service) { }
}
