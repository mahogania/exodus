using Microsoft.AspNetCore.Mvc;

namespace Code.APIs;

[ApiController()]
public class ShProfilsController : ShProfilsControllerBase
{
    public ShProfilsController(IShProfilsService service)
        : base(service) { }
}
