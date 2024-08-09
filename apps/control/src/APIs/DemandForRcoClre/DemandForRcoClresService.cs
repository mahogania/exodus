using Control.Infrastructure;

namespace Control.APIs;

public class DemandForRcoClresService : DemandForRcoClresServiceBase
{
    public DemandForRcoClresService(ControlDbContext context)
        : base(context) { }
}
