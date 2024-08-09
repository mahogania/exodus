using Microsoft.AspNetCore.Mvc;

namespace Clre.APIs;

[ApiController()]
public class ModelSpecificationOfTheDetailedDeclarationCustomsItemsController
    : ModelSpecificationOfTheDetailedDeclarationCustomsItemsControllerBase
{
    public ModelSpecificationOfTheDetailedDeclarationCustomsItemsController(
        IModelSpecificationOfTheDetailedDeclarationCustomsItemsService service
    )
        : base(service) { }
}
