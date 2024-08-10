using Microsoft.AspNetCore.Mvc;

namespace Collection.APIs;

[ApiController]
public class FineRequestHistoriesController : FineRequestHistoriesControllerBase
{
    public FineRequestHistoriesController(IFineRequestHistoriesService service)
        : base(service)
    {
    }
}
