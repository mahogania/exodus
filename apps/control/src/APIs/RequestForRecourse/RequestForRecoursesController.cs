using Microsoft.AspNetCore.Mvc;

namespace Clre.APIs;

[ApiController()]
public class RequestForRecoursesController : RequestForRecoursesControllerBase
{
    public RequestForRecoursesController(IRequestForRecoursesService service)
        : base(service) { }
}
