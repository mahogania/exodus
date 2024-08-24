using Control.Infrastructure;

namespace Control.APIs;

public class TransitCarnetControlsService : TransitCarnetControlsServiceBase
{
    public TransitCarnetControlsService(ControlDbContext context)
        : base(context) { }
}
