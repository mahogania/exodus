using Criteria.Infrastructure;

namespace Criteria.APIs;

public class RvcIssuancesService : RvcIssuancesServiceBase
{
    public RvcIssuancesService(CriteriaDbContext context)
        : base(context) { }
}
