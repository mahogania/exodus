using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[ApiController()]
public class ArticlesController : ArticlesControllerBase
{
    public ArticlesController(IArticlesService service)
        : base(service) { }
}
