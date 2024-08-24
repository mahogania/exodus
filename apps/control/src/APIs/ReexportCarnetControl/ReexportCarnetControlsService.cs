using Control.Infrastructure;

namespace Control.APIs;

public class ReexportCarnetControlsService : ReexportCarnetControlsServiceBase
{
    public ReexportCarnetControlsService(ControlDbContext context)
        : base(context) { }
}
