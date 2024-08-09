using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[ApiController()]
public class DeclarationOfValueOfTheDetailedDeclarationCustomsItemsController
    : DeclarationOfValueOfTheDetailedDeclarationCustomsItemsControllerBase
{
    public DeclarationOfValueOfTheDetailedDeclarationCustomsItemsController(
        IDeclarationOfValueOfTheDetailedDeclarationCustomsItemsService service
    )
        : base(service) { }
}
