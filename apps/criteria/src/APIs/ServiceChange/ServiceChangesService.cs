using Criteria.Infrastructure;

namespace Criteria.APIs;

public class ServiceChangesService : ServiceChangesServiceBase
{
    public ServiceChangesService(CriteriaDbContext context)
        : base(context) { }
}
