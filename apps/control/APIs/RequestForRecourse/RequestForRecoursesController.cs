using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[ApiController]
public class RequestForRecoursesController : RequestForRecoursesControllerBase
{
    public RequestForRecoursesController(IRequestForRecoursesService service)
        : base(service)
    {
    }
}
