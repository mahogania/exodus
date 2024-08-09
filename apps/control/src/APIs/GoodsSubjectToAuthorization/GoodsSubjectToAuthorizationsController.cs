using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[ApiController()]
public class GoodsSubjectToAuthorizationsController : GoodsSubjectToAuthorizationsControllerBase
{
    public GoodsSubjectToAuthorizationsController(IGoodsSubjectToAuthorizationsService service)
        : base(service) { }
}
