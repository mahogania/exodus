using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[ApiController()]
public class ArticlesSubmittedForVerificationsController
    : ArticlesSubmittedForVerificationsControllerBase
{
    public ArticlesSubmittedForVerificationsController(
        IArticlesSubmittedForVerificationsService service
    )
        : base(service) { }
}
