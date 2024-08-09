using Microsoft.AspNetCore.Mvc;

namespace Clre.APIs;

[ApiController()]
public class ContainerOfTheDetailedDeclarationCustomsItemsController
    : ContainerOfTheDetailedDeclarationCustomsItemsControllerBase
{
    public ContainerOfTheDetailedDeclarationCustomsItemsController(
        IContainerOfTheDetailedDeclarationCustomsItemsService service
    )
        : base(service) { }
}
