using Criteria.Infrastructure;

namespace Criteria.APIs;

public class ClearanceFretInterfacesService : ClearanceFretInterfacesServiceBase
{
    public ClearanceFretInterfacesService(CriteriaDbContext context)
        : base(context) { }
}
