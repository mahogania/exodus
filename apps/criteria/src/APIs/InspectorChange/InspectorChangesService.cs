using Criteria.Infrastructure;

namespace Criteria.APIs;

public class InspectorChangesService : InspectorChangesServiceBase
{
    public InspectorChangesService(CriteriaDbContext context)
        : base(context) { }
}
