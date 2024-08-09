using Microsoft.AspNetCore.Mvc;

namespace Clre.APIs;

[ApiController()]
public class RequestForCancellationOfTheDetailedDeclarationCustomsItemsController
    : RequestForCancellationOfTheDetailedDeclarationCustomsItemsControllerBase
{
    public RequestForCancellationOfTheDetailedDeclarationCustomsItemsController(
        IRequestForCancellationOfTheDetailedDeclarationCustomsItemsService service
    )
        : base(service) { }
}
