using Microsoft.AspNetCore.Mvc;

namespace Criteria.APIs;

[ApiController()]
public class ClearanceFretContainersController : ClearanceFretContainersControllerBase
{
    public ClearanceFretContainersController(IClearanceFretContainersService service)
        : base(service) { }
}
