using Microsoft.AspNetCore.Mvc;

namespace Criteria.APIs;

[ApiController()]
public class InspectorVerifierDesignationsController : InspectorVerifierDesignationsControllerBase
{
    public InspectorVerifierDesignationsController(IInspectorVerifierDesignationsService service)
        : base(service) { }
}
