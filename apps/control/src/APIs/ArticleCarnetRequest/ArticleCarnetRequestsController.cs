using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[ApiController()]
public class ArticleCarnetRequestsController : ArticleCarnetRequestsControllerBase
{
    public ArticleCarnetRequestsController(IArticleCarnetRequestsService service)
        : base(service) { }
}
