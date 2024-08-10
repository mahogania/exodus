using Microsoft.AspNetCore.Mvc;

namespace Collection.APIs;

[ApiController]
public class DelaysController : DelaysControllerBase
{
    public DelaysController(IDelaysService service)
        : base(service)
    {
    }
}
