using Microsoft.AspNetCore.Mvc;

namespace Collection.APIs;

[ApiController]
public class NoticesController : NoticesControllerBase
{
    public NoticesController(INoticesService service)
        : base(service)
    {
    }
}
