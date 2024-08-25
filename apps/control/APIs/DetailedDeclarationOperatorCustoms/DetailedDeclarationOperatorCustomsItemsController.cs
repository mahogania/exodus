using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[ApiController]
public class DetailedDeclarationOperatorCustomsItemsController
    : DetailedDeclarationOperatorCustomsItemsControllerBase
{
    public DetailedDeclarationOperatorCustomsItemsController(
        IDetailedDeclarationOperatorCustomsItemsService service
    )
        : base(service)
    {
    }
}
