using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[ApiController()]
public class StateForPerfectionsController : StateForPerfectionsControllerBase
{
    public StateForPerfectionsController(IStateForPerfectionsService service)
        : base(service) { }
}
