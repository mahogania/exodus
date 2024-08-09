using Microsoft.AspNetCore.Mvc;

namespace Clre.APIs;

[ApiController()]
public class DetailedDeclarationVehiclesController : DetailedDeclarationVehiclesControllerBase
{
    public DetailedDeclarationVehiclesController(IDetailedDeclarationVehiclesService service)
        : base(service) { }
}
