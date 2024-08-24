using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[ApiController()]
public class WarehouseTransfersController : WarehouseTransfersControllerBase
{
    public WarehouseTransfersController(IWarehouseTransfersService service)
        : base(service) { }
}
