using Microsoft.AspNetCore.Mvc;

namespace Criteria.APIs;

[ApiController()]
public class InspectorChangesController : InspectorChangesControllerBase
{
    public InspectorChangesController(IInspectorChangesService service)
        : base(service) { }
}
