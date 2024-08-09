using Clre.Infrastructure;

namespace Clre.APIs;

public class StateForPerfectionsService : StateForPerfectionsServiceBase
{
    public StateForPerfectionsService(ClreDbContext context)
        : base(context) { }
}
