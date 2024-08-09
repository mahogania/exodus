using Microsoft.AspNetCore.Mvc;

namespace Clre.APIs;

[ApiController()]
public class StateWithReImportationInTheStatesController
    : StateWithReImportationInTheStatesControllerBase
{
    public StateWithReImportationInTheStatesController(
        IStateWithReImportationInTheStatesService service
    )
        : base(service) { }
}
