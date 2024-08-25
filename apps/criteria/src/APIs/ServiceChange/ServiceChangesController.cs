using Microsoft.AspNetCore.Mvc;

namespace Criteria.APIs;

[ApiController()]
public class ServiceChangesController : ServiceChangesControllerBase
{
    public ServiceChangesController(IServiceChangesService service)
        : base(service) { }
}
