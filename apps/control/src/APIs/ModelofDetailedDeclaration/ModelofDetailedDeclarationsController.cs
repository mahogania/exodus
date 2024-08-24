using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[ApiController()]
public class ModelofDetailedDeclarationsController : ModelofDetailedDeclarationsControllerBase
{
    public ModelofDetailedDeclarationsController(IModelofDetailedDeclarationsService service)
        : base(service) { }
}
