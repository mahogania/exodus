using Control.Infrastructure;

namespace Control.APIs;

public class RequestForRecoursesService : RequestForRecoursesServiceBase
{
    public RequestForRecoursesService(ControlDbContext context)
        : base(context)
    {
    }
}
