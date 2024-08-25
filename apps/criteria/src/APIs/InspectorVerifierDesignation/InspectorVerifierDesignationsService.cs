using Criteria.Infrastructure;

namespace Criteria.APIs;

public class InspectorVerifierDesignationsService : InspectorVerifierDesignationsServiceBase
{
    public InspectorVerifierDesignationsService(CriteriaDbContext context)
        : base(context) { }
}
