using Fret.Infrastructure;

namespace Fret.APIs;

public class TrailersService : TrailersServiceBase
{
    public TrailersService(FretDbContext context)
        : base(context) { }
}
