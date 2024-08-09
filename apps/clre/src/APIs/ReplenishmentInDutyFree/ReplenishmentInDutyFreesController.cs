using Microsoft.AspNetCore.Mvc;

namespace Clre.APIs;

[ApiController()]
public class ReplenishmentInDutyFreesController : ReplenishmentInDutyFreesControllerBase
{
    public ReplenishmentInDutyFreesController(IReplenishmentInDutyFreesService service)
        : base(service) { }
}
