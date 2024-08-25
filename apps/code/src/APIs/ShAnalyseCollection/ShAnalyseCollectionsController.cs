using Microsoft.AspNetCore.Mvc;

namespace Code.APIs;

[ApiController()]
public class ShAnalyseCollectionsController : ShAnalyseCollectionsControllerBase
{
    public ShAnalyseCollectionsController(IShAnalyseCollectionsService service)
        : base(service) { }
}
