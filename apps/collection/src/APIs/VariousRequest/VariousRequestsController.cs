using Microsoft.AspNetCore.Mvc;

namespace Collection.APIs;

[ApiController]
public class VariousRequestsController : VariousRequestsControllerBase
{
    public VariousRequestsController(IVariousRequestsService service)
        : base(service)
    {
    }
}
