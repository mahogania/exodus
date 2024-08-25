using Criteria.Infrastructure;

namespace Criteria.APIs;

public class ForeignClientsService : ForeignClientsServiceBase
{
    public ForeignClientsService(CriteriaDbContext context)
        : base(context) { }
}
