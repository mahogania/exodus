using Clre.Infrastructure;

namespace Clre.APIs;

public class DemandForRcoClresService : DemandForRcoClresServiceBase
{
    public DemandForRcoClresService(ClreDbContext context)
        : base(context) { }
}
