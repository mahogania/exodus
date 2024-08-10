using Microsoft.AspNetCore.Mvc;

namespace Collection.APIs;

[ApiController]
public class AdjustmentsController : AdjustmentsControllerBase
{
    public AdjustmentsController(IAdjustmentsService service)
        : base(service)
    {
    }
}
