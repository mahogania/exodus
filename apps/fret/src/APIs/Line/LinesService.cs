using Fret.Infrastructure;

namespace Fret.APIs;

public class LinesService : LinesServiceBase
{
    public LinesService(FretDbContext context)
        : base(context) { }
}
