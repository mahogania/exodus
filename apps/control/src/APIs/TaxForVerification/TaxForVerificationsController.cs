using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[ApiController()]
public class TaxForVerificationsController : TaxForVerificationsControllerBase
{
    public TaxForVerificationsController(ITaxForVerificationsService service)
        : base(service) { }
}
