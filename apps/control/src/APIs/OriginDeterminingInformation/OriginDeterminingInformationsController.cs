using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[ApiController()]
public class OriginDeterminingInformationsController : OriginDeterminingInformationsControllerBase
{
    public OriginDeterminingInformationsController(IOriginDeterminingInformationsService service)
        : base(service) { }
}
