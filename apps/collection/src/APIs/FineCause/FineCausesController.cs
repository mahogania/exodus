using Microsoft.AspNetCore.Mvc;

namespace Collection.APIs;

[ApiController]
public class FineCausesController : FineCausesControllerBase
{
    public FineCausesController(IFineCausesService service)
        : base(service)
    {
    }
}
