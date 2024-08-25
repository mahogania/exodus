using Microsoft.AspNetCore.Mvc;

namespace Code.APIs;

[ApiController()]
public class ArticleTarifsController : ArticleTarifsControllerBase
{
    public ArticleTarifsController(IArticleTarifsService service)
        : base(service) { }
}
