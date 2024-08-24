using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[ApiController()]
public class PostalGoodsClearancesController : PostalGoodsClearancesControllerBase
{
    public PostalGoodsClearancesController(IPostalGoodsClearancesService service)
        : base(service) { }
}
