using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[ApiController()]
public class PostalGoodsClearanceDetailsController : PostalGoodsClearanceDetailsControllerBase
{
    public PostalGoodsClearanceDetailsController(IPostalGoodsClearanceDetailsService service)
        : base(service) { }
}
