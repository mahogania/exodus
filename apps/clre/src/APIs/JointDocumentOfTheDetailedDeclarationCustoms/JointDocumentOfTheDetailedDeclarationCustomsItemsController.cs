using Microsoft.AspNetCore.Mvc;

namespace Clre.APIs;

[ApiController()]
public class JointDocumentOfTheDetailedDeclarationCustomsItemsController
    : JointDocumentOfTheDetailedDeclarationCustomsItemsControllerBase
{
    public JointDocumentOfTheDetailedDeclarationCustomsItemsController(
        IJointDocumentOfTheDetailedDeclarationCustomsItemsService service
    )
        : base(service) { }
}
