using Microsoft.AspNetCore.Mvc;

namespace Clre.APIs;

[ApiController()]
public class StateForPerfectionsController : StateForPerfectionsControllerBase
{
    public StateForPerfectionsController(IStateForPerfectionsService service)
        : base(service) { }
}
