using Microsoft.AspNetCore.Mvc;

namespace Code.APIs;

[ApiController()]
public class TarifGeneralsController : TarifGeneralsControllerBase
{
    public TarifGeneralsController(ITarifGeneralsService service)
        : base(service) { }
}
