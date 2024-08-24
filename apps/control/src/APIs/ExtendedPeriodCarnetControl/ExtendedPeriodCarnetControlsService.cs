using Control.Infrastructure;

namespace Control.APIs;

public class ExtendedPeriodCarnetControlsService : ExtendedPeriodCarnetControlsServiceBase
{
    public ExtendedPeriodCarnetControlsService(ControlDbContext context)
        : base(context) { }
}
