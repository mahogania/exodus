using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[ApiController]
public class RequestForCancellationOfTheDetailedDeclarationCustomsItemsController
    : RequestForCancellationOfTheDetailedDeclarationCustomsItemsControllerBase
{
    public RequestForCancellationOfTheDetailedDeclarationCustomsItemsController(
        IRequestForCancellationOfTheDetailedDeclarationCustomsItemsService service
    )
        : base(service)
    {
    }
}
