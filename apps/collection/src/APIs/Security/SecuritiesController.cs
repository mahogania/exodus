using Microsoft.AspNetCore.Mvc;

namespace Collection.APIs;

[ApiController]
public class SecuritiesController : SecuritiesControllerBase
{
    public SecuritiesController(ISecuritiesService service)
        : base(service)
    {
    }
}
