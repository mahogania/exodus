using Control.Infrastructure;

namespace Control.APIs;

public class RequestForCommonCarnetsService : RequestForCommonCarnetsServiceBase
{
    public RequestForCommonCarnetsService(ControlDbContext context)
        : base(context)
    {
    }
}
