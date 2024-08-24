using Control.Infrastructure;

namespace Control.APIs;

public class RcoDemandsService : RcoDemandsServiceBase
{
    public RcoDemandsService(ControlDbContext context)
        : base(context) { }
}
