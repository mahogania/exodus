using Microsoft.AspNetCore.Mvc;

namespace Collection.APIs;

[ApiController]
public class ArticlesController : ArticlesControllerBase
{
    public ArticlesController(IArticlesService service)
        : base(service)
    {
    }
}
