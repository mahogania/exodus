using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[ApiController]
public class AtAndStandardExchangesController : AtAndStandardExchangesControllerBase
{
    public AtAndStandardExchangesController(IAtAndStandardExchangesService service)
        : base(service)
    {
    }
}
