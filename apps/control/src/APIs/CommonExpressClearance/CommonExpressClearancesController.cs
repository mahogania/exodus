using Microsoft.AspNetCore.Mvc;

namespace Clre.APIs;

[ApiController()]
public class CommonExpressClearancesController : CommonExpressClearancesControllerBase
{
    public CommonExpressClearancesController(ICommonExpressClearancesService service)
        : base(service) { }
}
