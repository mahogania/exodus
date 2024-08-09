using Fret.Infrastructure;

namespace Fret.APIs;

public class TrainsService : TrainsServiceBase
{
    public TrainsService(FretDbContext context)
        : base(context) { }
}
