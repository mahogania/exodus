using Microsoft.AspNetCore.Mvc;

namespace Clre.APIs;

[ApiController()]
public class InformationForDeterminingOriginsController
    : InformationForDeterminingOriginsControllerBase
{
    public InformationForDeterminingOriginsController(
        IInformationForDeterminingOriginsService service
    )
        : base(service) { }
}
