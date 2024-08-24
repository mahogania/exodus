using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[ApiController()]
public class ArticleAssessmentsController : ArticleAssessmentsControllerBase
{
    public ArticleAssessmentsController(IArticleAssessmentsService service)
        : base(service) { }
}
