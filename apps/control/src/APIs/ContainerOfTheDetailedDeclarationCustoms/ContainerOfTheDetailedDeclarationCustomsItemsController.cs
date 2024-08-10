using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[ApiController]
public class ContainerOfTheDetailedDeclarationCustomsItemsController
    : ContainerOfTheDetailedDeclarationCustomsItemsControllerBase
{
    public ContainerOfTheDetailedDeclarationCustomsItemsController(
        IContainerOfTheDetailedDeclarationCustomsItemsService service
    )
        : base(service)
    {
    }
}
