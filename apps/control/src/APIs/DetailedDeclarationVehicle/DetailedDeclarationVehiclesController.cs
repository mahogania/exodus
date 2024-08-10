using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[ApiController]
public class DetailedDeclarationVehiclesController : DetailedDeclarationVehiclesControllerBase
{
    public DetailedDeclarationVehiclesController(IDetailedDeclarationVehiclesService service)
        : base(service)
    {
    }
}
