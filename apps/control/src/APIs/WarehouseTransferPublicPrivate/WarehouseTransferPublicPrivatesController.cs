using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[ApiController()]
public class WarehouseTransferPublicPrivatesController
    : WarehouseTransferPublicPrivatesControllerBase
{
    public WarehouseTransferPublicPrivatesController(
        IWarehouseTransferPublicPrivatesService service
    )
        : base(service) { }
}
