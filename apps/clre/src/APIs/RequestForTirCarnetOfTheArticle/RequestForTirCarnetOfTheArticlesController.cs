using Microsoft.AspNetCore.Mvc;

namespace Clre.APIs;

[ApiController()]
public class RequestForTirCarnetOfTheArticlesController
    : RequestForTirCarnetOfTheArticlesControllerBase
{
    public RequestForTirCarnetOfTheArticlesController(
        IRequestForTirCarnetOfTheArticlesService service
    )
        : base(service) { }
}
