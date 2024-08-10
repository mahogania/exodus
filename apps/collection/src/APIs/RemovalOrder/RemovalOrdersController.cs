using Microsoft.AspNetCore.Mvc;

namespace Collection.APIs;

[ApiController]
public class RemovalOrdersController : RemovalOrdersControllerBase
{
    public RemovalOrdersController(IRemovalOrdersService service)
        : base(service)
    {
    }
}
