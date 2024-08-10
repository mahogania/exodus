using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[ApiController]
public class ReplenishmentInDutyFreesController : ReplenishmentInDutyFreesControllerBase
{
    public ReplenishmentInDutyFreesController(IReplenishmentInDutyFreesService service)
        : base(service)
    {
    }
}
