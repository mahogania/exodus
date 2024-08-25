using Microsoft.AspNetCore.Mvc;

namespace Traveler.APIs;

[ApiController()]
public class ExitVouchersController : ExitVouchersControllerBase
{
    public ExitVouchersController(IExitVouchersService service)
        : base(service) { }
}
