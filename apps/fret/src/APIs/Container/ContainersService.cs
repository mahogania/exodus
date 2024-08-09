using Fret.Infrastructure;

namespace Fret.APIs;

public class ContainersService : ContainersServiceBase
{
    public ContainersService(FretDbContext context)
        : base(context) { }
}
