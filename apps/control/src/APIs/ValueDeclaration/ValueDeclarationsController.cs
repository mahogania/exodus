using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[ApiController()]
public class ValueDeclarationsController : ValueDeclarationsControllerBase
{
    public ValueDeclarationsController(IValueDeclarationsService service)
        : base(service) { }
}
