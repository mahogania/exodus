using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[ApiController]
public class StateWithReImportationInTheStatesController
    : StateWithReImportationInTheStatesControllerBase
{
    public StateWithReImportationInTheStatesController(
        IStateWithReImportationInTheStatesService service
    )
        : base(service)
    {
    }
}
