using Microsoft.AspNetCore.Mvc;

namespace Code.APIs;

[ApiController()]
public class ArticlePaysPartenaireConventionDouanieresController
    : ArticlePaysPartenaireConventionDouanieresControllerBase
{
    public ArticlePaysPartenaireConventionDouanieresController(
        IArticlePaysPartenaireConventionDouanieresService service
    )
        : base(service) { }
}
