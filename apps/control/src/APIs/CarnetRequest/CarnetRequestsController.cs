using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[ApiController()]
public class CarnetRequestsController : CarnetRequestsControllerBase
{
    public CarnetRequestsController(ICarnetRequestsService service)
        : base(service) { }
}
