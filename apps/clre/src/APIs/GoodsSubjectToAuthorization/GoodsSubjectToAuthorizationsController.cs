using Microsoft.AspNetCore.Mvc;

namespace Clre.APIs;

[ApiController()]
public class GoodsSubjectToAuthorizationsController : GoodsSubjectToAuthorizationsControllerBase
{
    public GoodsSubjectToAuthorizationsController(IGoodsSubjectToAuthorizationsService service)
        : base(service) { }
}
