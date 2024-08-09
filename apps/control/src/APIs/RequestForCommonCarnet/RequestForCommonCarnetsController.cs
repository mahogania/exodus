using Microsoft.AspNetCore.Mvc;

namespace Clre.APIs;

[ApiController()]
public class RequestForCommonCarnetsController : RequestForCommonCarnetsControllerBase
{
    public RequestForCommonCarnetsController(IRequestForCommonCarnetsService service)
        : base(service) { }
}
