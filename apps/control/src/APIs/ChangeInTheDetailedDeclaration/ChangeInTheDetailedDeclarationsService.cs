using Control.Infrastructure;

namespace Control.APIs;

public class ChangeInTheDetailedDeclarationsService : ChangeInTheDetailedDeclarationsServiceBase
{
    public ChangeInTheDetailedDeclarationsService(ControlDbContext context)
        : base(context) { }
}
