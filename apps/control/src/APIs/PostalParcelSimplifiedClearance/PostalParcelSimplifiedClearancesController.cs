using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[ApiController()]
public class PostalParcelSimplifiedClearancesController
    : PostalParcelSimplifiedClearancesControllerBase
{
    public PostalParcelSimplifiedClearancesController(
        IPostalParcelSimplifiedClearancesService service
    )
        : base(service) { }
}
