using Microsoft.AspNetCore.Mvc;

namespace Collection.APIs;

[ApiController]
public class OthersItemsController : OthersItemsControllerBase
{
    public OthersItemsController(IOthersItemsService service)
        : base(service)
    {
    }
}
