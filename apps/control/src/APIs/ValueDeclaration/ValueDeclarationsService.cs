using Control.Infrastructure;

namespace Control.APIs;

public class ValueDeclarationsService : ValueDeclarationsServiceBase
{
    public ValueDeclarationsService(ControlDbContext context)
        : base(context) { }
}
