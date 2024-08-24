using Control.Infrastructure;

namespace Control.APIs;

public class RecourseRequestsService : RecourseRequestsServiceBase
{
    public RecourseRequestsService(ControlDbContext context)
        : base(context) { }
}
