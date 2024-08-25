using Microsoft.AspNetCore.Mvc;

namespace Code.APIs;

[ApiController()]
public class PeriodeTarifSpecialGeneralsController : PeriodeTarifSpecialGeneralsControllerBase
{
    public PeriodeTarifSpecialGeneralsController(IPeriodeTarifSpecialGeneralsService service)
        : base(service) { }
}
