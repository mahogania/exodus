using Microsoft.AspNetCore.Mvc;

namespace Collection.APIs;

[ApiController()]
public class ReceiptsController : ReceiptsControllerBase
{
    public ReceiptsController(IReceiptsService service)
        : base(service) { }
}
