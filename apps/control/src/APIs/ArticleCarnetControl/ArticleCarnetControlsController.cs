using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[ApiController()]
public class ArticleCarnetControlsController : ArticleCarnetControlsControllerBase
{
    public ArticleCarnetControlsController(IArticleCarnetControlsService service)
        : base(service) { }
}
