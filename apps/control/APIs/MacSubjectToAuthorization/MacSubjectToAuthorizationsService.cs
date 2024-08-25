using Control.Infrastructure;

namespace Control.APIs;

public class MacSubjectToAuthorizationsService : MacSubjectToAuthorizationsServiceBase
{
    public MacSubjectToAuthorizationsService(ControlDbContext context)
        : base(context)
    {
    }
}
