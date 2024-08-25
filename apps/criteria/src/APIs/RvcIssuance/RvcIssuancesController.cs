using Microsoft.AspNetCore.Mvc;

namespace Criteria.APIs;

[ApiController()]
public class RvcIssuancesController : RvcIssuancesControllerBase
{
    public RvcIssuancesController(IRvcIssuancesService service)
        : base(service) { }
}
