using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[ApiController]
public class RequestForTirCarnetOfTheArticlesController
    : RequestForTirCarnetOfTheArticlesControllerBase
{
    public RequestForTirCarnetOfTheArticlesController(
        IRequestForTirCarnetOfTheArticlesService service
    )
        : base(service)
    {
    }
}
