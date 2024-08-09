using Clre.Infrastructure;

namespace Clre.APIs;

public class RequestForRecoursesService : RequestForRecoursesServiceBase
{
    public RequestForRecoursesService(ClreDbContext context)
        : base(context) { }
}
