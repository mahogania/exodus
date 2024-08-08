using Fret.Infrastructure;

namespace Fret.APIs;

public class CommonsService : CommonsServiceBase
{
    public CommonsService(FretDbContext context)
        : base(context) { }
}
