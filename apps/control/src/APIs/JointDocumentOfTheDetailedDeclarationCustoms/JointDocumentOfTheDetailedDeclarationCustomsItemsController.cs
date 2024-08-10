using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[ApiController]
public class JointDocumentOfTheDetailedDeclarationCustomsItemsController
    : JointDocumentOfTheDetailedDeclarationCustomsItemsControllerBase
{
    public JointDocumentOfTheDetailedDeclarationCustomsItemsController(
        IJointDocumentOfTheDetailedDeclarationCustomsItemsService service
    )
        : base(service)
    {
    }
}
