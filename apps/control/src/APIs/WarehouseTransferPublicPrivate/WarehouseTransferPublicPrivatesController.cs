using Microsoft.AspNetCore.Mvc;

namespace Clre.APIs;

[ApiController()]
public class WarehouseTransferPublicPrivatesController
    : WarehouseTransferPublicPrivatesControllerBase
{
    public WarehouseTransferPublicPrivatesController(
        IWarehouseTransferPublicPrivatesService service
    )
        : base(service) { }
}
