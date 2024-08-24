using Control.Infrastructure;

namespace Control.APIs;

public class ReplenishmentsService : ReplenishmentsServiceBase
{
    public ReplenishmentsService(ControlDbContext context)
        : base(context) { }
}
