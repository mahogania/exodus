using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[ApiController()]
public class ModelSpecificationOfTheDetailedDeclarationCustomsItemsController
    : ModelSpecificationOfTheDetailedDeclarationCustomsItemsControllerBase
{
    public ModelSpecificationOfTheDetailedDeclarationCustomsItemsController(
        IModelSpecificationOfTheDetailedDeclarationCustomsItemsService service
    )
        : base(service) { }
}
