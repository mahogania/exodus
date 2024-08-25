using Microsoft.AspNetCore.Mvc;

namespace Code.APIs;

[ApiController()]
public class PeriodeTarifNormalGeneralsController : PeriodeTarifNormalGeneralsControllerBase
{
    public PeriodeTarifNormalGeneralsController(IPeriodeTarifNormalGeneralsService service)
        : base(service) { }
}
