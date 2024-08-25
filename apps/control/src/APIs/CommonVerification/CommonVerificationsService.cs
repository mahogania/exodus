using Control.Infrastructure;

namespace Control.APIs;

public class CommonVerificationsService : CommonVerificationsServiceBase
{
    public CommonVerificationsService(ControlDbContext context)
        : base(context) { }
}
