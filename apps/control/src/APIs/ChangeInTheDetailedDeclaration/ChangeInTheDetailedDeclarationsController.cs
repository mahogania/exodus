using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[ApiController()]
public class ChangeInTheDetailedDeclarationsController
    : ChangeInTheDetailedDeclarationsControllerBase
{
    public ChangeInTheDetailedDeclarationsController(
        IChangeInTheDetailedDeclarationsService service
    )
        : base(service) { }
}
