using Microsoft.AspNetCore.Mvc;

namespace Collection.APIs;

[ApiController]
public class IssuancesController : IssuancesControllerBase
{
    public IssuancesController(IIssuancesService service)
        : base(service)
    {
    }
}
