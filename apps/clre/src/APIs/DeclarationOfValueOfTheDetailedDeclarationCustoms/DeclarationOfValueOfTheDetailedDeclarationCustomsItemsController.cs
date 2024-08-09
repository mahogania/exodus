using Microsoft.AspNetCore.Mvc;

namespace Clre.APIs;

[ApiController()]
public class DeclarationOfValueOfTheDetailedDeclarationCustomsItemsController
    : DeclarationOfValueOfTheDetailedDeclarationCustomsItemsControllerBase
{
    public DeclarationOfValueOfTheDetailedDeclarationCustomsItemsController(
        IDeclarationOfValueOfTheDetailedDeclarationCustomsItemsService service
    )
        : base(service) { }
}
