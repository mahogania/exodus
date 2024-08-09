using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[ApiController()]
public class ArticleOfTheDetailedDeclarationCustomsItemsController
    : ArticleOfTheDetailedDeclarationCustomsItemsControllerBase
{
    public ArticleOfTheDetailedDeclarationCustomsItemsController(
        IArticleOfTheDetailedDeclarationCustomsItemsService service
    )
        : base(service) { }
}
