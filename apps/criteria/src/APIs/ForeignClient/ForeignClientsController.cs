using Microsoft.AspNetCore.Mvc;

namespace Criteria.APIs;

[ApiController()]
public class ForeignClientsController : ForeignClientsControllerBase
{
    public ForeignClientsController(IForeignClientsService service)
        : base(service) { }
}
