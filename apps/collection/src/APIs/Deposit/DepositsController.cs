using Microsoft.AspNetCore.Mvc;

namespace Collection.APIs;

[ApiController]
public class DepositsController : DepositsControllerBase
{
    public DepositsController(IDepositsService service)
        : base(service)
    {
    }
}
