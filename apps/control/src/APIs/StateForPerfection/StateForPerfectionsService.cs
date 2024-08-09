using Control.Infrastructure;

namespace Control.APIs;

public class StateForPerfectionsService : StateForPerfectionsServiceBase
{
    public StateForPerfectionsService(ControlDbContext context)
        : base(context) { }
}
