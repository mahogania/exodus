using Criteria.Infrastructure;

namespace Criteria.APIs;

public class ClearanceFretContainersService : ClearanceFretContainersServiceBase
{
    public ClearanceFretContainersService(CriteriaDbContext context)
        : base(context) { }
}
