using Fret.Infrastructure;

namespace Fret.APIs;

public class ManifestsService : ManifestsServiceBase
{
    public ManifestsService(FretDbContext context)
        : base(context) { }
}
