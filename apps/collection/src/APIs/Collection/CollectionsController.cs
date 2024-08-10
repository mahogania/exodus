using Microsoft.AspNetCore.Mvc;

namespace Collection.APIs;

[ApiController]
public class CollectionsController : CollectionsControllerBase
{
    public CollectionsController(ICollectionsService service)
        : base(service)
    {
    }
}
