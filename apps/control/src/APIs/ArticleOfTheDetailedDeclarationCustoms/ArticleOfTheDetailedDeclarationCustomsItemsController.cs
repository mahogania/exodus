using Microsoft.AspNetCore.Mvc;

namespace Clre.APIs;

[ApiController()]
public class ArticleOfTheDetailedDeclarationCustomsItemsController
    : ArticleOfTheDetailedDeclarationCustomsItemsControllerBase
{
    public ArticleOfTheDetailedDeclarationCustomsItemsController(
        IArticleOfTheDetailedDeclarationCustomsItemsService service
    )
        : base(service) { }
}
