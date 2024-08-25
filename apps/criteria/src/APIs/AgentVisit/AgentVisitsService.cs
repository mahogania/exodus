using Criteria.Infrastructure;

namespace Criteria.APIs;

public class AgentVisitsService : AgentVisitsServiceBase
{
    public AgentVisitsService(CriteriaDbContext context)
        : base(context) { }
}
