using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[ApiController()]
public class InformationForDeterminingOriginsController
    : InformationForDeterminingOriginsControllerBase
{
    public InformationForDeterminingOriginsController(
        IInformationForDeterminingOriginsService service
    )
        : base(service) { }
}
