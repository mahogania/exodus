using Microsoft.AspNetCore.Mvc;

namespace Criteria.APIs;

[ApiController()]
public class AgentVisitsController : AgentVisitsControllerBase
{
    public AgentVisitsController(IAgentVisitsService service)
        : base(service) { }
}
