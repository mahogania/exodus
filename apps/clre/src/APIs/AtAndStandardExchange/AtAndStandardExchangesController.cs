using Microsoft.AspNetCore.Mvc;

namespace Clre.APIs;

[ApiController()]
public class AtAndStandardExchangesController : AtAndStandardExchangesControllerBase
{
    public AtAndStandardExchangesController(IAtAndStandardExchangesService service)
        : base(service) { }
}
