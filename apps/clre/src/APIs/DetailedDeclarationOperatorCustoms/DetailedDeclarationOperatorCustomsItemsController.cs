using Microsoft.AspNetCore.Mvc;

namespace Clre.APIs;

[ApiController()]
public class DetailedDeclarationOperatorCustomsItemsController
    : DetailedDeclarationOperatorCustomsItemsControllerBase
{
    public DetailedDeclarationOperatorCustomsItemsController(
        IDetailedDeclarationOperatorCustomsItemsService service
    )
        : base(service) { }
}
