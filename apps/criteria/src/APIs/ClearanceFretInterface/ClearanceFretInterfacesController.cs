using Microsoft.AspNetCore.Mvc;

namespace Criteria.APIs;

[ApiController()]
public class ClearanceFretInterfacesController : ClearanceFretInterfacesControllerBase
{
    public ClearanceFretInterfacesController(IClearanceFretInterfacesService service)
        : base(service) { }
}
