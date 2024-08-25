using Control.Infrastructure;

namespace Control.APIs;

public class AppealsService : AppealsServiceBase
{
    public AppealsService(ControlDbContext context)
        : base(context) { }
}
