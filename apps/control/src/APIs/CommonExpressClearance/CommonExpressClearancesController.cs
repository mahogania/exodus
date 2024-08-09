using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[ApiController()]
public class CommonExpressClearancesController : CommonExpressClearancesControllerBase
{
    public CommonExpressClearancesController(ICommonExpressClearancesService service)
        : base(service) { }
}
