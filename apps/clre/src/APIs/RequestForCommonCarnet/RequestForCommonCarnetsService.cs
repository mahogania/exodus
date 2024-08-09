using Clre.Infrastructure;

namespace Clre.APIs;

public class RequestForCommonCarnetsService : RequestForCommonCarnetsServiceBase
{
    public RequestForCommonCarnetsService(ClreDbContext context)
        : base(context) { }
}
