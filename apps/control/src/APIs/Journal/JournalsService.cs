using Control.Infrastructure;

namespace Control.APIs;

public class JournalsService : JournalsServiceBase
{
    public JournalsService(ControlDbContext context)
        : base(context) { }
}
